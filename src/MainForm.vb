Imports System.ComponentModel

Public Class MainForm
    'Public Variables etc.
    Public bw As BackgroundWorker = New BackgroundWorker
    'For invoking DrawPoint properly...
    Public Delegate Sub DrawPointInvoker(X As Double, Y As Double, SeriesRef As Integer)
    Public WithEvents com As New IO.Ports.SerialPort

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Startup Stuff...
        consolePrint("Starting @ " + TimeOfDay.ToLongDateString)
    End Sub

    Private Sub SettingsButton_Click(sender As Object, e As EventArgs) Handles SettingsButton.Click
        'Settings Window for COM port selection
        SettingsDialog.Show()
    End Sub



    Private Sub Frequency_Validating(sender As Object, e As CancelEventArgs) Handles Frequency.Validating
        ' remember if the port is already open.  If not then close it after updating, otherwise leave open
        '  Could possibly use the state of the manual button instead
        Dim portOpen As Boolean
        portOpen = com.IsOpen
        If Not portOpen Then
            openComPort()
        End If
        If isValidFreq(Frequency.Text) Then
            com.WriteLine("F " + Frequency.Text)
            Debug.Print("Validating Frequency")
        End If
        If Not portOpen Then
            ClosePort()
        End If

    End Sub

    Private Sub ManualButton_Click(sender As Object, e As EventArgs) Handles ManualButton.Click
        If ManualButton.Text = "Manual" Then
            'When you click the Manual button it opens the com port
            openComPort()
            com.WriteLine("Y")
        ElseIf ManualButton.Text = "Stop" Then
            'When you click the Stop button it closes the com port
            openComPort()
            com.WriteLine("N")
            ClosePort()
        End If
    End Sub

    Private Sub CustomPresetButton_Click(sender As Object, e As EventArgs) Handles CustomPresetButton.Click
        CustomPresetsDialog.Show()
    End Sub

    Private Sub ClearGraph_Click(sender As Object, e As EventArgs) Handles ClearGraph.Click
        For Each i In Chart.Series
            Chart.Series(i.Name.ToString).Points.Clear()
        Next
        Chart.ChartAreas(0).AxisX.Maximum = Double.NaN
        Chart.ChartAreas(0).AxisX.Minimum = Double.NaN
    End Sub

    Private Sub MainForm_Close(sender As Object, e As EventArgs) Handles Me.FormClosing
        If com.IsOpen Then
            com.WriteLine("N")
            ClosePort()
        End If
    End Sub

    Private Sub ScanButton_Click(sender As Object, e As EventArgs) Handles ScanButton.Click
        If ScanButton.Text = "Start Scan" Then
            '  Check that valid values are present
            If isValidFreq(StartFreq.Text) And isValidFreq(StopFreq.Text) Then
                openComPort()
                '                OpenPort(My.Settings.ComPort)
                com.WriteLine("L " + StartFreq.Text)
                com.WriteLine("H " + StopFreq.Text)
                com.WriteLine("I " + ScanInterval.Text)
                com.WriteLine("S")
                ScanButton.Text = "Stop Scan"
                StatusLabel.Text = "Scanning"
                Chart.ChartAreas(0).AxisX.Minimum = StartFreq.Text / 1000000
                Chart.ChartAreas(0).AxisX.Maximum = StopFreq.Text / 1000000
            Else
                MsgBox("Invalid frequency values", MsgBoxStyle.Exclamation, "Start Scan Button Pressed")
            End If
        ElseIf ScanButton.Text = "Stop Scan" Then
            openComPort()
            com.WriteLine("N")
            ClosePort()
            ScanButton.Text = "Start Scan"
        End If
    End Sub

    Private Sub SWRZoom_ValueChanged(sender As Object, e As EventArgs) Handles SWRZoom.ValueChanged
        Chart.ChartAreas(0).AxisY.Maximum = (SWRZoom.Value / 10)
    End Sub

    'Functions that HAVE to be in the MainForm to work... Stupid threading...
#Region "Functions"
    'Draws point on graph
    Public Sub DrawPoint(X As Double, Y As Double, SeriesRef As Integer)
        If Me.Chart.InvokeRequired Then
            'If you need to invoke then invoke.
            consolePrint("DrawPoint(" + X.ToString + ", " + Y.ToString + ") Invoked", True)
            Me.Chart.Invoke(New DrawPointInvoker(AddressOf DrawPoint), X, Y, SeriesRef)
        Else
            'Add the points
            consolePrint("HANDLE: " + Me.Chart.IsHandleCreated.ToString + "; " + Me.Chart.Handle.ToString, True)
            Me.Chart.Series(SeriesRef).Points.AddXY(X, Y)

            'I cant be bothered to write another Delegate for the labels so I'm doin' it here!
            If SeriesRef = 0 Then
                Me.SWRLabel.Text = "SWR: " + Y.ToString
            End If
            Me.Frequency.Text = X.ToString * 1000000

            consolePrint("ChartPoints: " + Chart.Series(SeriesRef).Points.Count().ToString + "Last point:" + Chart.Series(SeriesRef).Points(Chart.Series(SeriesRef).Points.Count - 1).XValue.ToString + ";" + Chart.Series(SeriesRef).Points(Chart.Series(SeriesRef).Points.Count - 1).YValues(0).ToString, True)
        End If
    End Sub
    Public Sub Read(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        'While not being canceled.
        While bw.CancellationPending = False And com.IsOpen
            Try
                'Read COM port line
                Dim Line As String = com.ReadLine()
                Parse(Line)
            Catch generatedExceptionName As TimeoutException
                'Catch timeouts, assume failure will not correct itself and cancel scan
                consolePrint("COM Timeout")
                com.WriteLine("N")
                bw.CancelAsync()
                System.Threading.Thread.Sleep(3000)
                com.Close()
                consolePrint("Idle")
                'StatusLabel.Text = "Idle"
                'ManualButton.Text = "Manual"
                'ScanButton.Text = "Start Scan"

                'ClosePort()
            End Try
        End While
    End Sub
    Public Sub Parse(input As String)
        consolePrint("PARSING: " + input, True)
        Try
            'Basic parse variables
            Dim P_command As String
            Dim P_params As String()

            'Parse variables for Data return
            Dim P_freq As String
            Dim P_V1 As Double
            Dim P_V2 As Double
            Dim P_Rx As Double
            Dim P_SWR As Double

            'Parse variables for Preset return

            'Split input into a command and some parameters
            P_command = input.Substring(0, 2)
            P_params = input.Substring(2).Split(" ")

            '"Send Data for Freq" Command
            If P_command = "D " Then
                P_freq = P_params(0)
                P_V1 = P_params(1)
                P_V2 = P_params(2)
                P_Rx = (P_V2 * 47) / (P_V1 - P_V2)
                If P_Rx >= 50 Then
                    P_SWR = P_Rx / 50
                Else
                    P_SWR = 50 / P_Rx
                End If
                consolePrint("PARSED: SWR: " + P_SWR.ToString + " Freq: " + P_freq.ToString, True)
                If Not P_SWR > 20 Then
                    DrawPoint(P_freq / 1000000, P_SWR, 0)
                    DrawPoint(P_freq / 1000000, P_Rx, 1)
                End If
            ElseIf P_command = "PR" Then
                Presets.Add(P_params)
                consolePrint("Added preset " + P_params(0).ToString)
                consolePrint("PRESET: " + String.Join(",", P_params))
                updatePresets()
            ElseIf P_command = "X" Then
                consolePrint("Scan Ended")
                com.WriteLine("N")
                ScanButton.Text = "Start Scan"
                StatusLabel.Text = "Idle"
            Else
                consolePrint("UNPARSED")
            End If
        Catch ex As Exception
            consolePrint("ERROR: Parse Error")
            consolePrint("Stacktrace: " + ex.ToString, True)
        End Try
    End Sub

    Public Function isValidFreq(f As String) As Boolean
        Dim fr As Double
        fr = Val(f)
        If fr >= 1000000 And fr <= 30000000 Then
            isValidFreq = True
        Else
            isValidFreq = False
        End If
    End Function

    Private Function openComPort() As Boolean
        '  Routine to check if the port is open.  If it is just return true.
        '  If not check that a valid com port is selected or set in settings and open it
        '  Return true if sucessful, false if not
        Try
            If Not com.IsOpen Then
                If My.Settings.ComPort <> Nothing Then
                    OpenPort(My.Settings.ComPort)
                Else
                    MsgBox("Select a com port!")
                End If
            End If
            openComPort = True
        Catch ex As Exception
            MsgBox("Error opening com port!")
            openComPort = False
        End Try
    End Function

#End Region





End Class