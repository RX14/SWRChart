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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ManualButton = New System.Windows.Forms.Button()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.SettingsButton = New System.Windows.Forms.Button()
        Me.StartFreq = New System.Windows.Forms.TextBox()
        Me.StartFreqLabel = New System.Windows.Forms.Label()
        Me.StopFrequencyLabel = New System.Windows.Forms.Label()
        Me.StopFreq = New System.Windows.Forms.TextBox()
        Me.ScanInterval = New System.Windows.Forms.TextBox()
        Me.IntervalLabel = New System.Windows.Forms.Label()
        Me.ScanButton = New System.Windows.Forms.Button()
        Me.SWRLabel = New System.Windows.Forms.Label()
        Me.ClearGraph = New System.Windows.Forms.Button()
        Me.VoltageLabel = New System.Windows.Forms.Label()
        Me.ResistanceLabel = New System.Windows.Forms.Label()
        Me.Presets = New System.Windows.Forms.ListBox()
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
        Me.Chart.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Chart.Location = New System.Drawing.Point(0, 0)
        Me.Chart.Name = "Chart"
        Series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Name = "Series1"
        Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Me.Chart.Series.Add(Series1)
        Me.Chart.Size = New System.Drawing.Size(536, 471)
        Me.Chart.TabIndex = 0
        Me.Chart.Text = "Chart1"
        '
        'ManualButton
        '
        Me.ManualButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ManualButton.Location = New System.Drawing.Point(736, 411)
        Me.ManualButton.Name = "ManualButton"
        Me.ManualButton.Size = New System.Drawing.Size(75, 23)
        Me.ManualButton.TabIndex = 1
        Me.ManualButton.Text = "Manual"
        Me.ManualButton.UseVisualStyleBackColor = True
        '
        'StatusLabel
        '
        Me.StatusLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Location = New System.Drawing.Point(542, 447)
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
        Me.SettingsButton.Location = New System.Drawing.Point(784, 440)
        Me.SettingsButton.Name = "SettingsButton"
        Me.SettingsButton.Size = New System.Drawing.Size(27, 27)
        Me.SettingsButton.TabIndex = 3
        Me.SettingsButton.UseVisualStyleBackColor = True
        '
        'StartFreq
        '
        Me.StartFreq.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartFreq.Location = New System.Drawing.Point(630, 13)
        Me.StartFreq.Name = "StartFreq"
        Me.StartFreq.Size = New System.Drawing.Size(181, 20)
        Me.StartFreq.TabIndex = 4
        '
        'StartFreqLabel
        '
        Me.StartFreqLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartFreqLabel.AutoSize = True
        Me.StartFreqLabel.Location = New System.Drawing.Point(542, 16)
        Me.StartFreqLabel.Name = "StartFreqLabel"
        Me.StartFreqLabel.Size = New System.Drawing.Size(82, 13)
        Me.StartFreqLabel.TabIndex = 5
        Me.StartFreqLabel.Text = "Start Frequency"
        '
        'StopFrequencyLabel
        '
        Me.StopFrequencyLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StopFrequencyLabel.AutoSize = True
        Me.StopFrequencyLabel.Location = New System.Drawing.Point(542, 42)
        Me.StopFrequencyLabel.Name = "StopFrequencyLabel"
        Me.StopFrequencyLabel.Size = New System.Drawing.Size(82, 13)
        Me.StopFrequencyLabel.TabIndex = 6
        Me.StopFrequencyLabel.Text = "Stop Frequency"
        '
        'StopFreq
        '
        Me.StopFreq.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StopFreq.Location = New System.Drawing.Point(630, 39)
        Me.StopFreq.Name = "StopFreq"
        Me.StopFreq.Size = New System.Drawing.Size(181, 20)
        Me.StopFreq.TabIndex = 7
        '
        'ScanInterval
        '
        Me.ScanInterval.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ScanInterval.Location = New System.Drawing.Point(630, 65)
        Me.ScanInterval.Name = "ScanInterval"
        Me.ScanInterval.Size = New System.Drawing.Size(181, 20)
        Me.ScanInterval.TabIndex = 8
        '
        'IntervalLabel
        '
        Me.IntervalLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IntervalLabel.AutoSize = True
        Me.IntervalLabel.Location = New System.Drawing.Point(582, 68)
        Me.IntervalLabel.Name = "IntervalLabel"
        Me.IntervalLabel.Size = New System.Drawing.Size(42, 13)
        Me.IntervalLabel.TabIndex = 9
        Me.IntervalLabel.Text = "Interval"
        '
        'ScanButton
        '
        Me.ScanButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ScanButton.Location = New System.Drawing.Point(736, 91)
        Me.ScanButton.Name = "ScanButton"
        Me.ScanButton.Size = New System.Drawing.Size(75, 23)
        Me.ScanButton.TabIndex = 10
        Me.ScanButton.Text = "Start Scan"
        Me.ScanButton.UseVisualStyleBackColor = True
        '
        'SWRLabel
        '
        Me.SWRLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SWRLabel.AutoSize = True
        Me.SWRLabel.Location = New System.Drawing.Point(563, 421)
        Me.SWRLabel.Name = "SWRLabel"
        Me.SWRLabel.Size = New System.Drawing.Size(39, 13)
        Me.SWRLabel.TabIndex = 11
        Me.SWRLabel.Text = "SWR: "
        '
        'ClearGraph
        '
        Me.ClearGraph.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClearGraph.Location = New System.Drawing.Point(736, 382)
        Me.ClearGraph.Name = "ClearGraph"
        Me.ClearGraph.Size = New System.Drawing.Size(75, 23)
        Me.ClearGraph.TabIndex = 12
        Me.ClearGraph.Text = "Clear Graph"
        Me.ClearGraph.UseVisualStyleBackColor = True
        '
        'VoltageLabel
        '
        Me.VoltageLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VoltageLabel.AutoSize = True
        Me.VoltageLabel.Location = New System.Drawing.Point(553, 404)
        Me.VoltageLabel.Name = "VoltageLabel"
        Me.VoltageLabel.Size = New System.Drawing.Size(49, 13)
        Me.VoltageLabel.TabIndex = 13
        Me.VoltageLabel.Text = "Voltage: "
        '
        'ResistanceLabel
        '
        Me.ResistanceLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ResistanceLabel.AutoSize = True
        Me.ResistanceLabel.Location = New System.Drawing.Point(536, 387)
        Me.ResistanceLabel.Name = "ResistanceLabel"
        Me.ResistanceLabel.Size = New System.Drawing.Size(66, 13)
        Me.ResistanceLabel.TabIndex = 14
        Me.ResistanceLabel.Text = "Resistance: "
        '
        'Presets
        '
        Me.Presets.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Presets.FormattingEnabled = True
        Me.Presets.Location = New System.Drawing.Point(545, 121)
        Me.Presets.Name = "Presets"
        Me.Presets.Size = New System.Drawing.Size(265, 251)
        Me.Presets.TabIndex = 15
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 471)
        Me.Controls.Add(Me.Presets)
        Me.Controls.Add(Me.ResistanceLabel)
        Me.Controls.Add(Me.VoltageLabel)
        Me.Controls.Add(Me.ClearGraph)
        Me.Controls.Add(Me.SWRLabel)
        Me.Controls.Add(Me.ScanButton)
        Me.Controls.Add(Me.IntervalLabel)
        Me.Controls.Add(Me.ScanInterval)
        Me.Controls.Add(Me.StopFreq)
        Me.Controls.Add(Me.StopFrequencyLabel)
        Me.Controls.Add(Me.StartFreqLabel)
        Me.Controls.Add(Me.StartFreq)
        Me.Controls.Add(Me.SettingsButton)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.ManualButton)
        Me.Controls.Add(Me.Chart)
        Me.Name = "MainForm"
        Me.ShowIcon = False
        Me.Text = "SWRChart"
        CType(Me.Chart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ManualButton As System.Windows.Forms.Button
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents SettingsButton As System.Windows.Forms.Button
    Public WithEvents Chart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents StartFreq As System.Windows.Forms.TextBox
    Friend WithEvents StartFreqLabel As System.Windows.Forms.Label
    Friend WithEvents StopFrequencyLabel As System.Windows.Forms.Label
    Friend WithEvents StopFreq As System.Windows.Forms.TextBox
    Friend WithEvents ScanInterval As System.Windows.Forms.TextBox
    Friend WithEvents IntervalLabel As System.Windows.Forms.Label
    Friend WithEvents ScanButton As System.Windows.Forms.Button
    Friend WithEvents SWRLabel As System.Windows.Forms.Label
    Friend WithEvents ClearGraph As System.Windows.Forms.Button
    Friend WithEvents VoltageLabel As System.Windows.Forms.Label
    Friend WithEvents ResistanceLabel As System.Windows.Forms.Label
    Friend WithEvents Presets As System.Windows.Forms.ListBox

End Class
