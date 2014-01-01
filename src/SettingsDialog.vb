Public Class SettingsDialog

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        MainForm.ComPort = ComPortSelection.Text
        Me.Close()
    End Sub

    Private Sub SettingsDialog_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ComPortSelection.Items.Clear()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            If Len(sp) = 4 Then sp = "COM " + Mid(sp, 4)
            ComPortSelection.Items.Add(sp)
        Next
        Console.Out.WriteLine("SettingsLoad")
    End Sub
End Class