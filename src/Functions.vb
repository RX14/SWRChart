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
    Public Sub Parse(input As String)
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
            MainForm.DrawPoint(P_freq, P_SWR)
        ElseIf P_command = "PR" Then
            Presets.Add(P_params)
            updatePresets()
        End If
    End Sub
    Private Sub updatePresets()
        MainForm.PresetsBox.Items.Clear()
        For Each Preset In Presets
            MainForm.PresetsBox.Items.Add(Preset(1))
        Next
    End Sub
End Module
