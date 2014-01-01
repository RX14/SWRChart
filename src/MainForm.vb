Imports System.ComponentModel

Public Class MainForm
    'Public Variables etc.
    Public bw As BackgroundWorker = New BackgroundWorker
    Public Delegate Sub DrawPointInvoker(X As Double, Y As Double)
    Public WithEvents com As New IO.Ports.SerialPort
    Public ComPort As String

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.Out.WriteLine(vbNewLine + "STARTUP!" + vbNewLine + "------" + vbNewLine + TimeOfDay.ToLongTimeString)
    End Sub

    Private Sub SettingsButton_Click(sender As Object, e As EventArgs) Handles SettingsButton.Click
        SettingsDialog.Show()
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        If StartButton.Text = "Start" Then
            'When you click the start button it opens the com port
            If ComPort <> Nothing Then
                OpenPort(ComPort)
            Else
                MsgBox("Select a com port!")
            End If
        ElseIf StartButton.Text = "Stop" Then
            ClosePort()
        End If
    End Sub
#Region "Functions"
    Public Sub DrawPoint(X As Double, Y As Double, Optional SeriesRef As Integer = 0)
        If Me.Chart.InvokeRequired Then
            Console.Out.WriteLine("Invoke")
            Me.Chart.Invoke(New DrawPointInvoker(AddressOf DrawPoint), X, Y)
        Else
            'Draws a point on the graph given X + Y coordinates
            Console.Out.WriteLine("DEBUG: HANDLE: " + Me.Chart.IsHandleCreated.ToString + "; " + Me.Chart.Handle.ToString)
            Me.Chart.Series(SeriesRef).Points.AddXY(X, Y)
            Console.Out.WriteLine("DEBUG: ChartPoints: " + Chart.Series(0).Points.Count().ToString + "Last point:" + Chart.Series(0).Points(Chart.Series(0).Points.Count - 1).XValue.ToString + ";" + Chart.Series(0).Points(Chart.Series(0).Points.Count - 1).YValues(0).ToString)
        End If
    End Sub

    Public Sub Read(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        Dim x, y As Double

        While bw.CancellationPending = False
            Try
                Dim Line As String = com.ReadLine()
                'If the first character is a number then...
                If Asc(Line(0)) < 58 And Asc(Line(0)) > 47 Then
                    Console.Out.WriteLine("DEBUG: COMDATA: " + Line)
                    Dim lineSplit As String() = Line.Split(",")
                    If Line.Count > 3 Then
                        Console.Out.WriteLine("line(0)=" + lineSplit(0) + "; line(1)=" + lineSplit(1) + "l line(2)=" + lineSplit(2))
                        x = Convert.ToInt32(lineSplit(0) / 1000000)
                        y = Convert.ToInt32(Mid(lineSplit(1), 5))
                        Console.Out.WriteLine("DEBUG: COMPARSEDDATA: " + x.ToString + ";" + y.ToString)
                        DrawPoint(x, y)
                    Else
                        Console.Out.WriteLine("Parse Error")
                    End If
                Else
                    'Write other lines to console as debug data
                    Console.Out.WriteLine("DEBUG: COMDEBUG: " + Line)
                End If
            Catch generatedExceptionName As TimeoutException
                Console.Out.WriteLine("Timeout")
            End Try
        End While
    End Sub
#End Region
End Class