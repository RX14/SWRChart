Module Functions
    Public Sub DrawPoint(X As Integer, Y As Integer, Optional SeriesRef As Integer = 0)
        MainForm.Chart.Series.Item(SeriesRef).Points.AddXY(X, Y)
    End Sub
End Module
