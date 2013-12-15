Module Functions
    Public Sub DrawPoint(X As Integer, Y As Integer, Optional SeriesRef As Integer = 0)
        MainForm.Chart.Series.Item(SeriesRef).Points.AddXY(X, Y)
    End Sub

    'This code was taken from a Microsoft Example Code Snippet.
    Function ReceiveSerialData(ComPort As String) As String
        ' Receive strings from a serial port. 
        Dim returnStr As String = ""

        Dim com1 As IO.Ports.SerialPort = Nothing
        Try
            com1 = My.Computer.Ports.OpenSerialPort(ComPort)
            com1.ReadTimeout = 10000
            Do
                Dim Incoming As String = com1.ReadLine()
                If Incoming Is Nothing Then
                    Exit Do
                Else
                    returnStr &= Incoming & vbCrLf
                End If
            Loop
        Catch ex As TimeoutException
            returnStr = "Error: Serial Port read timed out."
        Finally
            If com1 IsNot Nothing Then com1.Close()
        End Try

        Return returnStr
    End Function
End Module
