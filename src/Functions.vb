Module Functions
    Dim cont As Boolean = True
    Public x, y As Double



    Public WithEvents com As New IO.Ports.SerialPort

    'Public Sub DrawPoint(X As Double, Y As Double, Optional SeriesRef As Integer = 0)
    'Draws a point on the graph given X + Y coordinates
    '    MainForm.Chart.Series.Item(SeriesRef).Points.AddXY(X, Y)
    '   Console.Out.WriteLine("DEBUG: ChartPoints: " + MainForm.Chart.Series.Item(0).Points.Count().ToString)
    'End Sub

    Public Sub OpenPort(ComPort As String)
        'Opens port when given the name of a COM port
        Dim readThread As New Threading.Thread(AddressOf Read)


        Try
            'Set COM port setttings
            cont = True
            com.PortName = ComPort
            com.BaudRate = 9600
            com.Parity = IO.Ports.Parity.None
            com.DataBits = 8
            com.StopBits = IO.Ports.StopBits.One
            com.ReadTimeout = 1000
            com.WriteTimeout = 1000
            'Open comport
            com.Open()
            MainForm.StatusLabel.Text = "ComPort Opened... Reading Data"
            MainForm.StartButton.Text = "Stop"
            readThread.Start()
        Catch ex As Exception
            'Open Messagebox on failure
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub Read()

        Dim mainformcontrol = New MainForm
        mainformcontrol = MainForm

        While cont
            Try
                Dim Line As String = com.ReadLine()
                'If the first character is a number then...
                If Asc(Line(0)) < 58 And Asc(Line(0)) > 47 Then
                    Console.Out.WriteLine("DEBUG: COMDATA: " + Line)
                    Dim lineSplit As String() = Line.Split(",")
                    If Line.Count > 3 Then
                        Console.Out.WriteLine("line(0)=" + lineSplit(0) + "; line(1)=" + lineSplit(1) + "l line(2)=" + lineSplit(2))
                        '                        Dim X As Double = Convert.ToInt32(lineSplit(0))
                        '                        Dim Y As Double = Convert.ToInt32(Mid(lineSplit(1), 5))
                        x = Convert.ToInt32(lineSplit(0))
                        y = Convert.ToInt32(Mid(lineSplit(1), 5))
                        Console.Out.WriteLine("DEBUG: COMPARSEDDATA: " + x.ToString + ";" + y.ToString)
                        mainformcontrol.Invoke(mainformcontrol.DrawPointDelegate)
                        'MainForm.Chart.Update()
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


    Public Sub ClosePort()
        Try
            cont = False
            '  wait long enough for the timeout to take place
            MainForm.StartButton.Text = "Stopping"
            System.Threading.Thread.Sleep(2000)
            com.Close()
            '            com = Nothing
            MainForm.StatusLabel.Text = "Idle"
            MainForm.StartButton.Text = "Start"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    '   Private Sub com_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles com.DataReceived
    'Handles receiving COM data
    '        Dim line As String=com.
    'If the first character is a number then...
    '     If Asc(line(0)) < 58 And Asc(line(0)) > 47 Then
    '        Console.Out.WriteLine("DEBUG: COMDATA: " + line)
    ' Dim lineSplit As String() = line.Split(",")
    '        If line.Count > 3 Then
    '            Console.Out.WriteLine("line(0)=" + lineSplit(0) + "; line(1)=" + lineSplit(1) + "l line(2)=" + lineSplit(2))
    'Dim X As Double = Convert.ToInt32(lineSplit(0))
    'Dim Y As Double = Convert.ToInt32(Mid(lineSplit(1), 5))
    '            Console.Out.WriteLine("DEBUG: COMPARSEDDATA: " + X.ToString + ";" + Y.ToString)
    '            MainForm.DoDrawPoint(X / 1000000, Y)
    '        Else
    '            Console.Out.WriteLine("Parse Error")
    '        End If
    '    Else
    'Write other lines to console as debug datas
    '        Console.Out.WriteLine("DEBUG: COMDEBUG: " + line)
    '    End If
    'End Sub
End Module
