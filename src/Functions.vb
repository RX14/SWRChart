Module Functions
    Public WithEvents com As New IO.Ports.SerialPort
    Public Sub DrawPoint(X As Double, Y As Double, Optional SeriesRef As Integer = 0)
        MainForm.Chart.Series.Item(SeriesRef).Points.AddXY(X, Y)
    End Sub

    Public Sub OpenPort(ComPort As String)
        Try
            com.PortName = ComPort
            com.BaudRate = 9600
            com.Parity = IO.Ports.Parity.None
            com.DataBits = 8
            com.StopBits = IO.Ports.StopBits.One
            com.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub com_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles com.DataReceived
        Console.WriteLine("Com Recieved" + com.ReadLine)
    End Sub
End Module
