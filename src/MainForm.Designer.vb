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
        Me.PresetsBox = New System.Windows.Forms.ListBox()
        Me.CustomPresetButton = New System.Windows.Forms.Button()
        Me.Frequency = New System.Windows.Forms.TextBox()
        Me.FrequencyLabel = New System.Windows.Forms.Label()
        CType(Me.Chart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart
        '
        Me.Chart.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.AxisX.Title = "Frequency"
        ChartArea1.AxisY.Maximum = 5.0R
        ChartArea1.AxisY.Minimum = 1.0R
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
        Me.Chart.Size = New System.Drawing.Size(536, 525)
        Me.Chart.TabIndex = 0
        Me.Chart.Text = "Chart1"
        '
        'ManualButton
        '
        Me.ManualButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ManualButton.Location = New System.Drawing.Point(736, 465)
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
        Me.StatusLabel.Location = New System.Drawing.Point(542, 501)
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
        Me.SettingsButton.Location = New System.Drawing.Point(784, 494)
        Me.SettingsButton.Name = "SettingsButton"
        Me.SettingsButton.Size = New System.Drawing.Size(27, 27)
        Me.SettingsButton.TabIndex = 3
        Me.SettingsButton.UseVisualStyleBackColor = True
        '
        'StartFreq
        '
        Me.StartFreq.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartFreq.Location = New System.Drawing.Point(630, 38)
        Me.StartFreq.Name = "StartFreq"
        Me.StartFreq.Size = New System.Drawing.Size(181, 20)
        Me.StartFreq.TabIndex = 4
        '
        'StartFreqLabel
        '
        Me.StartFreqLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartFreqLabel.AutoSize = True
        Me.StartFreqLabel.Location = New System.Drawing.Point(542, 41)
        Me.StartFreqLabel.Name = "StartFreqLabel"
        Me.StartFreqLabel.Size = New System.Drawing.Size(82, 13)
        Me.StartFreqLabel.TabIndex = 5
        Me.StartFreqLabel.Text = "Start Frequency"
        '
        'StopFrequencyLabel
        '
        Me.StopFrequencyLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StopFrequencyLabel.AutoSize = True
        Me.StopFrequencyLabel.Location = New System.Drawing.Point(542, 67)
        Me.StopFrequencyLabel.Name = "StopFrequencyLabel"
        Me.StopFrequencyLabel.Size = New System.Drawing.Size(82, 13)
        Me.StopFrequencyLabel.TabIndex = 6
        Me.StopFrequencyLabel.Text = "Stop Frequency"
        '
        'StopFreq
        '
        Me.StopFreq.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StopFreq.Location = New System.Drawing.Point(630, 64)
        Me.StopFreq.Name = "StopFreq"
        Me.StopFreq.Size = New System.Drawing.Size(181, 20)
        Me.StopFreq.TabIndex = 7
        '
        'ScanInterval
        '
        Me.ScanInterval.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ScanInterval.Location = New System.Drawing.Point(630, 90)
        Me.ScanInterval.Name = "ScanInterval"
        Me.ScanInterval.Size = New System.Drawing.Size(181, 20)
        Me.ScanInterval.TabIndex = 8
        '
        'IntervalLabel
        '
        Me.IntervalLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IntervalLabel.AutoSize = True
        Me.IntervalLabel.Location = New System.Drawing.Point(582, 93)
        Me.IntervalLabel.Name = "IntervalLabel"
        Me.IntervalLabel.Size = New System.Drawing.Size(42, 13)
        Me.IntervalLabel.TabIndex = 9
        Me.IntervalLabel.Text = "Interval"
        '
        'ScanButton
        '
        Me.ScanButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ScanButton.Location = New System.Drawing.Point(736, 116)
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
        Me.SWRLabel.Location = New System.Drawing.Point(542, 475)
        Me.SWRLabel.Name = "SWRLabel"
        Me.SWRLabel.Size = New System.Drawing.Size(39, 13)
        Me.SWRLabel.TabIndex = 11
        Me.SWRLabel.Text = "SWR: "
        '
        'ClearGraph
        '
        Me.ClearGraph.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClearGraph.Location = New System.Drawing.Point(736, 436)
        Me.ClearGraph.Name = "ClearGraph"
        Me.ClearGraph.Size = New System.Drawing.Size(75, 23)
        Me.ClearGraph.TabIndex = 12
        Me.ClearGraph.Text = "Clear Graph"
        Me.ClearGraph.UseVisualStyleBackColor = True
        '
        'PresetsBox
        '
        Me.PresetsBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PresetsBox.FormattingEnabled = True
        Me.PresetsBox.Items.AddRange(New Object() {"No Presets"})
        Me.PresetsBox.Location = New System.Drawing.Point(545, 147)
        Me.PresetsBox.Name = "PresetsBox"
        Me.PresetsBox.Size = New System.Drawing.Size(265, 277)
        Me.PresetsBox.TabIndex = 15
        '
        'CustomPresetButton
        '
        Me.CustomPresetButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomPresetButton.BackgroundImage = CType(resources.GetObject("CustomPresetButton.BackgroundImage"), System.Drawing.Image)
        Me.CustomPresetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CustomPresetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CustomPresetButton.ForeColor = System.Drawing.SystemColors.Control
        Me.CustomPresetButton.Location = New System.Drawing.Point(542, 116)
        Me.CustomPresetButton.Name = "CustomPresetButton"
        Me.CustomPresetButton.Size = New System.Drawing.Size(25, 27)
        Me.CustomPresetButton.TabIndex = 16
        Me.CustomPresetButton.UseVisualStyleBackColor = True
        '
        'Frequency
        '
        Me.Frequency.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Frequency.Location = New System.Drawing.Point(630, 12)
        Me.Frequency.Name = "Frequency"
        Me.Frequency.Size = New System.Drawing.Size(181, 20)
        Me.Frequency.TabIndex = 17
        '
        'FrequencyLabel
        '
        Me.FrequencyLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FrequencyLabel.AutoSize = True
        Me.FrequencyLabel.Location = New System.Drawing.Point(567, 15)
        Me.FrequencyLabel.Name = "FrequencyLabel"
        Me.FrequencyLabel.Size = New System.Drawing.Size(57, 13)
        Me.FrequencyLabel.TabIndex = 18
        Me.FrequencyLabel.Text = "Frequency"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 525)
        Me.Controls.Add(Me.FrequencyLabel)
        Me.Controls.Add(Me.Frequency)
        Me.Controls.Add(Me.CustomPresetButton)
        Me.Controls.Add(Me.PresetsBox)
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
    Friend WithEvents PresetsBox As System.Windows.Forms.ListBox
    Friend WithEvents CustomPresetButton As System.Windows.Forms.Button
    Friend WithEvents Frequency As System.Windows.Forms.TextBox
    Friend WithEvents FrequencyLabel As System.Windows.Forms.Label

End Class
