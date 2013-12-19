Module Functions
    Public WithEvents com As New IO.Ports.SerialPort
    Public Sub DrawPoint(X As Double, Y As Double, Optional SeriesRef As Integer = 0)
        'Draws a point on the graph given X + Y coordinates
        MainForm.Chart.Series.Item(SeriesRef).Points.AddXY(X, Y)
    End Sub

    Public Sub OpenPort(ComPort As String)
        'Opens port when given the name of a COM port
        Try
            'Set COM port setttings
            com.PortName = ComPort
            com.BaudRate = 9600
            com.Parity = IO.Ports.Parity.None
            com.DataBits = 8
            com.StopBits = IO.Ports.StopBits.One
            'Open comport
            com.Open()
            MainForm.StatusLabel.Text = "ComPort Opened... Reading Data"
            MainForm.StartButton.Text = "Stop"
        Catch ex As Exception
            'Open Messagebox on failure
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub ClosePort()
        Try
            com.Close()
            com = Nothing
            MainForm.StatusLabel.Text = "Idle"
            MainForm.StartButton.Text = "Start"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub com_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles com.DataReceived
        'Handles recieving COM data
        Dim line As String = com.ReadLine 'For storing the read line
        'If the first character is a number then...
        If Asc(line(0)) < 58 And Asc(line(0)) > 47 Then
            'Console.Out.WriteLine("DEBUG: COMDATA: " + line)
            Dim lineSplit As String() = line.Split(",")
            Dim X As Double = Convert.ToInt32(lineSplit(0))
            Dim Y As Double = Convert.ToInt32(lineSplit(1))
            Console.Out.WriteLine("DEBUG: COMPARSEDDATA: " + X.ToString + ";" + Y.ToString)
            DrawPoint(13, 5)
        Else
            'Write other lines to console as debug datas
            Console.Out.WriteLine("DEBUG: COMDEBUG: " + line)
        End If
    End Sub
End Module
