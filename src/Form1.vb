Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Chart.Series.Item(0).Points.AddXY(12, 41)
    End Sub

    Private Sub DrawPoint(X As Integer, Y As Integer)
        Chart.Series.Item(0).Points.AddXY(X, Y)
    End Sub

End Class
