Public Class MainForm

    Public ComPort As String = "Com10"

    Delegate Sub DrawPoint() '(x As Double, y As Double)
    Public DrawPointDelegate As DrawPoint

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.Out.WriteLine(vbNewLine + "STARTUP!" + vbNewLine + "------" + vbNewLine + TimeOfDay.ToLongTimeString)
        DrawPointDelegate = New DrawPoint(AddressOf DoDrawPoint)
    End Sub

    Private Sub SettingsButton_Click(sender As Object, e As EventArgs) Handles SettingsButton.Click
        SettingsDialog.Show()
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        If StartButton.Text = "Start" Then
            'When you click the start button it opens the com port
            If ComPort <> Nothing Then
                OpenPort(ComPort)
                'DrawPoint(12, 4)
            Else
                MsgBox("Select a com port!")
            End If
        ElseIf StartButton.Text = "Stop" Then
            'Chart.Update()
            ClosePort()
        End If
    End Sub

    Public Sub DoDrawPoint() '(X As Double, Y As Double)
        'Chart.Update()
        Chart.Series(0).Points.AddXY(X, Y)
        Console.Out.WriteLine("DEBUG: ChartPoints: " + Chart.Series(0).Points.Count().ToString + "Last point:" + Chart.Series(0).Points(Chart.Series(0).Points.Count - 1).XValue.ToString + ";" + Chart.Series(0).Points(Chart.Series(0).Points.Count - 1).YValues(0).ToString)
        Label1.Text = Chart.Series(0).Points.Count.ToString
        'Chart.ResetAutoValues()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Label1.Text = Chart.Series(0).Points.Count.ToString
        x = 2
        y = 3
        DoDrawPoint()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

End Class