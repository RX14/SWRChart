Public Class MainForm

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Chart.Series.Item(0).Points.AddXY(12, 41)
    End Sub

End Class
