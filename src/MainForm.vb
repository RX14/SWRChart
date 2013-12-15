Public Class MainForm

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each sp As String In My.Computer.Ports.SerialPortNames
            SettingsDialog.ComPortSelection.Items.Add(sp)
        Next
    End Sub

    Private Sub SettingsButton_Click(sender As Object, e As EventArgs) Handles SettingsButton.Click
        SettingsDialog.Show()
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        DrawPoint(150000000, 2.0)
        DrawPoint(155000000, 1.5)
        DrawPoint(160000000, 1.1)
        DrawPoint(165000000, 1.3)

    End Sub
End Class