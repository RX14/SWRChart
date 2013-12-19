﻿Public Class MainForm

    Public ComPort As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.Out.WriteLine(vbNewLine + "STARTUP!" + vbNewLine + "------" + vbNewLine + TimeOfDay.ToLongTimeString)
        For Each sp As String In My.Computer.Ports.SerialPortNames
            SettingsDialog.ComPortSelection.Items.Add(sp)
        Next
    End Sub

    Private Sub SettingsButton_Click(sender As Object, e As EventArgs) Handles SettingsButton.Click
        SettingsDialog.Show()
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        'When you click the start button it opens the com port
        If ComPort <> Nothing Then
            OpenPort(ComPort)
        Else
            MsgBox("Select a com port!")
        End If
    End Sub

End Class