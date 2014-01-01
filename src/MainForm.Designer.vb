<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataPoint1 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0.0R, 0.0R)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.SettingsButton = New System.Windows.Forms.Button()
        CType(Me.Chart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart
        '
        Me.Chart.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.AxisX.Title = "Frequency"
        ChartArea1.AxisY.Title = "SWR"
        ChartArea1.Name = "ChartArea1"
        Me.Chart.ChartAreas.Add(ChartArea1)
        Me.Chart.Location = New System.Drawing.Point(0, 0)
        Me.Chart.Name = "Chart"
        Series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.Name = "Series1"
        Series1.Points.Add(DataPoint1)
        Me.Chart.Series.Add(Series1)
        Me.Chart.Size = New System.Drawing.Size(300, 264)
        Me.Chart.TabIndex = 0
        Me.Chart.Text = "Chart1"
        '
        'StartButton
        '
        Me.StartButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.StartButton.Location = New System.Drawing.Point(7, 270)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(75, 23)
        Me.StartButton.TabIndex = 1
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'StatusLabel
        '
        Me.StatusLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Location = New System.Drawing.Point(88, 275)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(24, 13)
        Me.StatusLabel.TabIndex = 2
        Me.StatusLabel.Text = "Idle"
        '
        'SettingsButton
        '
        Me.SettingsButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SettingsButton.BackgroundImage = CType(resources.GetObject("SettingsButton.BackgroundImage"), System.Drawing.Image)
        Me.SettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SettingsButton.ForeColor = System.Drawing.SystemColors.Control
        Me.SettingsButton.Location = New System.Drawing.Point(267, 269)
        Me.SettingsButton.Name = "SettingsButton"
        Me.SettingsButton.Size = New System.Drawing.Size(27, 27)
        Me.SettingsButton.TabIndex = 3
        Me.SettingsButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 300)
        Me.Controls.Add(Me.SettingsButton)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.Chart)
        Me.Name = "MainForm"
        Me.ShowIcon = False
        Me.Text = "SWRGraph"
        CType(Me.Chart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StartButton As System.Windows.Forms.Button
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents SettingsButton As System.Windows.Forms.Button
    Public WithEvents Chart As System.Windows.Forms.DataVisualization.Charting.Chart

End Class
