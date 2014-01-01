Imports System.ComponentModel
Module Functions
    Public Sub ClosePort()
        Try
            MainForm.StartButton.Text = "Stopping"
            MainForm.StartButton.Refresh()
            MainForm.bw.CancelAsync()
            'wait long enough for the timeout to take place
            System.Threading.Thread.Sleep(2000)
            MainForm.com.Close()
            MainForm.StatusLabel.Text = "Idle"
            MainForm.StartButton.Text = "Start"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub OpenPort(ComPort As String)
        'Opens port when given the name of a COM port
        MainForm.bw.WorkerSupportsCancellation = True
        AddHandler MainForm.bw.DoWork, AddressOf MainForm.Read

        Try
            'Set COM port setttings
            MainForm.com.PortName = ComPort
            MainForm.com.BaudRate = 9600
            MainForm.com.Parity = IO.Ports.Parity.None
            MainForm.com.DataBits = 8
            MainForm.com.StopBits = IO.Ports.StopBits.One
            MainForm.com.ReadTimeout = 1000
            'MainForm.com.WriteTimeout = 1000
            'Open comport
            MainForm.com.Open()
            MainForm.bw.RunWorkerAsync()
            MainForm.StatusLabel.Text = "ComPort Opened... Reading Data"
            MainForm.StartButton.Text = "Stop"
        Catch ex As Exception
            'Open Messagebox on failure
            MsgBox(ex.ToString)
        End Try

    End Sub
 End Module
