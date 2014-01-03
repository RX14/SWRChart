Imports System.ComponentModel

Public Class MainForm
    'Public Variables etc.
    Public bw As BackgroundWorker = New BackgroundWorker
    'For invoking DrawPoint properly...
    Public Delegate Sub DrawPointInvoker(X As Double, Y As Double)
    Public WithEvents com As New IO.Ports.SerialPort

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Startup Stuff...
        consolePrint("Starting @ " + TimeOfDay.ToLongDateString)
    End Sub

    Private Sub SettingsButton_Click(sender As Object, e As EventArgs) Handles SettingsButton.Click
        'Settings Window for COM port selection
        SettingsDialog.Show()
    End Sub

    Private Sub ManualButton_Click(sender As Object, e As EventArgs) Handles ManualButton.Click
        If ManualButton.Text = "Manual" Then
            'When you click the Start button it opens the com port
            If My.Settings.ComPort <> Nothing Then
                OpenPort(My.Settings.ComPort)
            Else
                MsgBox("Select a com port!")
            End If
        ElseIf ManualButton.Text = "Stop" Then
            'When you click the Stop button it closes the com port
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
    End Sub

    'Functions that HAVE to be in the MainForm to work...
#Region "Functions"
    'Draws point on graph
    Public Sub DrawPoint(X As Double, Y As Double, Optional SeriesRef As Integer = 0)
        If Me.Chart.InvokeRequired Then
            'If you need to invoke then invoke.
            consolePrint("DrawPoint(" + X.ToString + ", " + Y.ToString + ") Invoked", True)
            Me.Chart.Invoke(New DrawPointInvoker(AddressOf DrawPoint), X, Y)
        Else
            'Add the points
            consolePrint("HANDLE: " + Me.Chart.IsHandleCreated.ToString + "; " + Me.Chart.Handle.ToString, True)
            Me.Chart.Series(SeriesRef).Points.AddXY(X, Y)
            consolePrint("ChartPoints: " + Chart.Series(0).Points.Count().ToString + "Last point:" + Chart.Series(0).Points(Chart.Series(0).Points.Count - 1).XValue.ToString + ";" + Chart.Series(0).Points(Chart.Series(0).Points.Count - 1).YValues(0).ToString, True)
        End If
    End Sub
    Public Sub Read(ByVal sender As Object, ByVal e As DoWorkEventArgs)

        'While not being canceled.
        While bw.CancellationPending = False
            Try
                'Read COM port line
                Dim Line As String = com.ReadLine()
                Parse(Line)
            Catch generatedExceptionName As TimeoutException
                'Catch timeouts
                consolePrint("COM Timeout")
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
                P_Rx = (P_V2 * 50) / ((2 * P_V1) - P_V2)
                If P_Rx >= 50 Then
                    P_SWR = P_Rx / 50
                Else
                    P_SWR = 50 / P_Rx
                End If
                consolePrint("PARSED: SWR: " + P_SWR.ToString + " Freq: " + P_freq.ToString, True)
                DrawPoint(P_freq, P_SWR)
            ElseIf P_command = "PR" Then
                Presets.Add(P_params)
                consolePrint("Added preset " + P_params(0).ToString)
                consolePrint("PRESET: " + String.Join(",", P_params))
                updatePresets()
            Else
                consolePrint("UNPARSED")
            End If
        Catch ex As Exception
            consolePrint("ERROR: Parse Error")
            consolePrint("Stacktrace: " + ex.ToString, True)
        End Try
    End Sub
#End Region
End Class