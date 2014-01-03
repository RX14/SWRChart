Imports System.ComponentModel
Module Functions
    Public Presets As New List(Of String())
    Public Sub ClosePort()
        Try
            consolePrint("Stopping")
            MainForm.ManualButton.Text = "Stopping"
            MainForm.ManualButton.Refresh()
            'Safe stop of BackgroundWorker
            MainForm.bw.CancelAsync()
            'Wait long enough for the BackgroundWorker to finish
            System.Threading.Thread.Sleep(2000)
            MainForm.com.Close()
            'Reset state
            consolePrint("Idle")
            MainForm.StatusLabel.Text = "Idle"
            MainForm.ManualButton.Text = "Manual"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub OpenPort(ComPort As String)
        'Opens port when given the name of a COM port
        MainForm.bw.WorkerSupportsCancellation = True
        'Sets the work for the BackgroundWorker
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
            'Run BackgroundWorker to parse incoming COM data
            MainForm.bw.RunWorkerAsync()
            consolePrint("Opened Port")
            MainForm.StatusLabel.Text = "ComPort Opened... Reading Data"
            MainForm.ManualButton.Text = "Stop"
        Catch ex As Exception
            'Open Messagebox on failure
            MsgBox(ex.ToString)
        End Try

    End Sub
    Public Sub consolePrint(text As String, Optional debug As Boolean = False)
        'If the Debugger is attached AND it is a debug message then:
        If Debugger.IsAttached And debug = True Then
            Console.Out.WriteLine("DEBUG: " + text)
        End If
        'If it is not a debug message then:
        If debug = False Then
            Console.Out.WriteLine("STATUS: " + text)
        End If
    End Sub
    Public Sub updatePresets()
        MainForm.PresetsBox.Items.Clear()
        For Each Preset In Presets
            MainForm.PresetsBox.Items.Add(Preset(1))
        Next
    End Sub
End Module
