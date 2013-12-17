Module Functions
    Public Sub DrawPoint(X As Double, Y As Double, Optional SeriesRef As Integer = 0)
        MainForm.Chart.Series.Item(SeriesRef).Points.AddXY(X, Y)
    End Sub

    'This code was taken from a Microsoft Example Code Snippet.
    Public Function ReceiveSerialData(ComPort As String) As String
        ' Receive strings from a serial port. 
        Dim returnStr As String = ""

        Dim com As IO.Ports.SerialPort = Nothing
        Try
            com = My.Computer.Ports.OpenSerialPort(ComPort)
            com.ReadTimeout = 10000
            Do
                Dim Incoming As String = com.ReadLine()
                If Incoming Is Nothing Then
                    Exit Do
                Else
                    returnStr &= Incoming & vbCrLf
                End If
            Loop
        Catch ex As TimeoutException
            returnStr = "Error: Serial Port read timed out."
        Finally
            If com IsNot Nothing Then com.Close()
        End Try

        Return returnStr
    End Function
End Module
