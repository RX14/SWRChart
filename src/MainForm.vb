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

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles ManualButton.Click
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
        Dim x, y As Double

        'While not being canceled.
        While bw.CancellationPending = False
            Try
                'Read COM port line
                Dim Line As String = com.ReadLine()
                'If the first character is a number then...
                If Asc(Line(0)) < 58 And Asc(Line(0)) > 47 Then
                    consolePrint("COMDATA: " + Line, True)
                    Dim lineSplit As String() = Line.Split(",")
                    'Check line count
                    If Line.Count > 3 Then
                        x = Convert.ToDouble(lineSplit(0) / 1000000)
                        y = Convert.ToDouble(Mid(lineSplit(1), 5))
                        consolePrint("COMPARSEDDATA: " + x.ToString + ";" + y.ToString, True)
                        DrawPoint(x, y)
                    Else
                        consolePrint("ERROR: Parse Error")
                    End If
                Else
                    'Write other lines to console as debug data
                    consolePrint("UNPARSED: " + Line)
                End If
            Catch generatedExceptionName As TimeoutException
                'Catch timeouts
                consolePrint("COM Timeout")
            End Try
        End While
    End Sub
#End Region
End Class