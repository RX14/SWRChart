Public Class SettingsDialog

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        MainForm.ComPort = ComPortSelection.Text
        Me.Close()
    End Sub
End Class