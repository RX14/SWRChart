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
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
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
        Me.SWRZoom = New System.Windows.Forms.TrackBar()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ShowR_CheckBox = New System.Windows.Forms.CheckBox()
        Me.ShowV_CheckBox = New System.Windows.Forms.CheckBox()
        Me.V1Label = New System.Windows.Forms.Label()
        Me.V2Label = New System.Windows.Forms.Label()
        Me.V3Label = New System.Windows.Forms.Label()
        Me.ShowP_CheckBox = New System.Windows.Forms.CheckBox()
        CType(Me.Chart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SWRZoom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart
        '
        Me.Chart.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.AxisX.Title = "Frequency"
        ChartArea1.AxisY.Maximum = 5.0R
        ChartArea1.AxisY.Minimum = 0.0R
        ChartArea1.AxisY.Title = "SWR"
        ChartArea1.CursorX.IsUserEnabled = True
        ChartArea1.CursorX.IsUserSelectionEnabled = True
        ChartArea1.CursorY.IsUserEnabled = True
        ChartArea1.CursorY.IsUserSelectionEnabled = True
        ChartArea1.Name = "ChartArea1"
        Me.Chart.ChartAreas.Add(ChartArea1)
        Me.Chart.ImeMode = System.Windows.Forms.ImeMode.[On]
        Legend1.Name = "Legend1"
        Me.Chart.Legends.Add(Legend1)
        Me.Chart.Location = New System.Drawing.Point(0, 0)
        Me.Chart.Name = "Chart"
        Series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Legend = "Legend1"
        Series1.LegendText = "SWR: #VALX{N3}, #VAL{N2}"
        Series1.LegendToolTip = "#VALX"
        Series1.Name = "Series1"
        Series1.ToolTip = "#VALX\n#VAL"
        Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Legend = "Legend1"
        Series2.LegendText = "R: #VALX{N3}, #VAL{N2}"
        Series2.Name = "Series2"
        Series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary
        Series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series3.Color = System.Drawing.Color.Green
        Series3.Legend = "Legend1"
        Series3.Name = "Series3"
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series4.Color = System.Drawing.Color.Gold
        Series4.Legend = "Legend1"
        Series4.Name = "Series4"
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series5.Color = System.Drawing.Color.Navy
        Series5.Legend = "Legend1"
        Series5.Name = "Series5"
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series6.Legend = "Legend1"
        Series6.Name = "Series6"
        Series7.ChartArea = "ChartArea1"
        Series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series7.Legend = "Legend1"
        Series7.Name = "Series7"
        Me.Chart.Series.Add(Series1)
        Me.Chart.Series.Add(Series2)
        Me.Chart.Series.Add(Series3)
        Me.Chart.Series.Add(Series4)
        Me.Chart.Series.Add(Series5)
        Me.Chart.Series.Add(Series6)
        Me.Chart.Series.Add(Series7)
        Me.Chart.Size = New System.Drawing.Size(848, 574)
        Me.Chart.TabIndex = 0
        Me.Chart.Text = "Chart1"
        '
        'ManualButton
        '
        Me.ManualButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ManualButton.Location = New System.Drawing.Point(1047, 472)
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
        Me.StatusLabel.Location = New System.Drawing.Point(854, 557)
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
        Me.SettingsButton.Location = New System.Drawing.Point(1096, 543)
        Me.SettingsButton.Name = "SettingsButton"
        Me.SettingsButton.Size = New System.Drawing.Size(27, 27)
        Me.SettingsButton.TabIndex = 3
        Me.SettingsButton.UseVisualStyleBackColor = True
        '
        'StartFreq
        '
        Me.StartFreq.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartFreq.Location = New System.Drawing.Point(942, 38)
        Me.StartFreq.Name = "StartFreq"
        Me.StartFreq.Size = New System.Drawing.Size(181, 20)
        Me.StartFreq.TabIndex = 4
        Me.StartFreq.Text = "1000000"
        '
        'StartFreqLabel
        '
        Me.StartFreqLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartFreqLabel.AutoSize = True
        Me.StartFreqLabel.Location = New System.Drawing.Point(854, 41)
        Me.StartFreqLabel.Name = "StartFreqLabel"
        Me.StartFreqLabel.Size = New System.Drawing.Size(82, 13)
        Me.StartFreqLabel.TabIndex = 5
        Me.StartFreqLabel.Text = "Start Frequency"
        '
        'StopFrequencyLabel
        '
        Me.StopFrequencyLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StopFrequencyLabel.AutoSize = True
        Me.StopFrequencyLabel.Location = New System.Drawing.Point(854, 67)
        Me.StopFrequencyLabel.Name = "StopFrequencyLabel"
        Me.StopFrequencyLabel.Size = New System.Drawing.Size(82, 13)
        Me.StopFrequencyLabel.TabIndex = 6
        Me.StopFrequencyLabel.Text = "Stop Frequency"
        '
        'StopFreq
        '
        Me.StopFreq.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StopFreq.Location = New System.Drawing.Point(942, 64)
        Me.StopFreq.Name = "StopFreq"
        Me.StopFreq.Size = New System.Drawing.Size(181, 20)
        Me.StopFreq.TabIndex = 7
        Me.StopFreq.Text = "30000000"
        '
        'ScanInterval
        '
        Me.ScanInterval.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ScanInterval.Location = New System.Drawing.Point(942, 90)
        Me.ScanInterval.Name = "ScanInterval"
        Me.ScanInterval.Size = New System.Drawing.Size(181, 20)
        Me.ScanInterval.TabIndex = 8
        Me.ScanInterval.Text = "1000000"
        '
        'IntervalLabel
        '
        Me.IntervalLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IntervalLabel.AutoSize = True
        Me.IntervalLabel.Location = New System.Drawing.Point(894, 93)
        Me.IntervalLabel.Name = "IntervalLabel"
        Me.IntervalLabel.Size = New System.Drawing.Size(42, 13)
        Me.IntervalLabel.TabIndex = 9
        Me.IntervalLabel.Text = "Interval"
        '
        'ScanButton
        '
        Me.ScanButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ScanButton.Location = New System.Drawing.Point(1048, 116)
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
        Me.SWRLabel.Location = New System.Drawing.Point(854, 505)
        Me.SWRLabel.Name = "SWRLabel"
        Me.SWRLabel.Size = New System.Drawing.Size(39, 13)
        Me.SWRLabel.TabIndex = 11
        Me.SWRLabel.Text = "SWR: "
        '
        'ClearGraph
        '
        Me.ClearGraph.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClearGraph.Location = New System.Drawing.Point(1047, 443)
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
        Me.PresetsBox.Location = New System.Drawing.Point(857, 147)
        Me.PresetsBox.Name = "PresetsBox"
        Me.PresetsBox.Size = New System.Drawing.Size(265, 290)
        Me.PresetsBox.TabIndex = 15
        '
        'CustomPresetButton
        '
        Me.CustomPresetButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomPresetButton.BackgroundImage = CType(resources.GetObject("CustomPresetButton.BackgroundImage"), System.Drawing.Image)
        Me.CustomPresetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CustomPresetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CustomPresetButton.ForeColor = System.Drawing.SystemColors.Control
        Me.CustomPresetButton.Location = New System.Drawing.Point(854, 116)
        Me.CustomPresetButton.Name = "CustomPresetButton"
        Me.CustomPresetButton.Size = New System.Drawing.Size(25, 27)
        Me.CustomPresetButton.TabIndex = 16
        Me.CustomPresetButton.UseVisualStyleBackColor = True
        '
        'Frequency
        '
        Me.Frequency.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Frequency.Location = New System.Drawing.Point(942, 12)
        Me.Frequency.Name = "Frequency"
        Me.Frequency.Size = New System.Drawing.Size(181, 20)
        Me.Frequency.TabIndex = 17
        '
        'FrequencyLabel
        '
        Me.FrequencyLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FrequencyLabel.AutoSize = True
        Me.FrequencyLabel.Location = New System.Drawing.Point(879, 15)
        Me.FrequencyLabel.Name = "FrequencyLabel"
        Me.FrequencyLabel.Size = New System.Drawing.Size(57, 13)
        Me.FrequencyLabel.TabIndex = 18
        Me.FrequencyLabel.Text = "Frequency"
        '
        'SWRZoom
        '
        Me.SWRZoom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SWRZoom.BackColor = System.Drawing.Color.White
        Me.SWRZoom.LargeChange = 10
        Me.SWRZoom.Location = New System.Drawing.Point(0, 0)
        Me.SWRZoom.Maximum = 50
        Me.SWRZoom.Minimum = 15
        Me.SWRZoom.Name = "SWRZoom"
        Me.SWRZoom.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.SWRZoom.Size = New System.Drawing.Size(45, 574)
        Me.SWRZoom.SmallChange = 5
        Me.SWRZoom.TabIndex = 19
        Me.SWRZoom.TickStyle = System.Windows.Forms.TickStyle.None
        Me.SWRZoom.Value = 50
        '
        'PrintButton
        '
        Me.PrintButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrintButton.Location = New System.Drawing.Point(957, 443)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintButton.TabIndex = 20
        Me.PrintButton.Text = "Print Graph"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ShowR_CheckBox
        '
        Me.ShowR_CheckBox.AutoSize = True
        Me.ShowR_CheckBox.Location = New System.Drawing.Point(857, 443)
        Me.ShowR_CheckBox.Name = "ShowR_CheckBox"
        Me.ShowR_CheckBox.Size = New System.Drawing.Size(64, 17)
        Me.ShowR_CheckBox.TabIndex = 21
        Me.ShowR_CheckBox.Text = "Show R"
        Me.ShowR_CheckBox.UseVisualStyleBackColor = True
        '
        'ShowV_CheckBox
        '
        Me.ShowV_CheckBox.AutoSize = True
        Me.ShowV_CheckBox.Location = New System.Drawing.Point(857, 459)
        Me.ShowV_CheckBox.Name = "ShowV_CheckBox"
        Me.ShowV_CheckBox.Size = New System.Drawing.Size(63, 17)
        Me.ShowV_CheckBox.TabIndex = 21
        Me.ShowV_CheckBox.Text = "Show V"
        Me.ShowV_CheckBox.UseVisualStyleBackColor = True
        '
        'V1Label
        '
        Me.V1Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.V1Label.AutoSize = True
        Me.V1Label.Location = New System.Drawing.Point(854, 518)
        Me.V1Label.Name = "V1Label"
        Me.V1Label.Size = New System.Drawing.Size(26, 13)
        Me.V1Label.TabIndex = 11
        Me.V1Label.Text = "V1: "
        '
        'V2Label
        '
        Me.V2Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.V2Label.AutoSize = True
        Me.V2Label.Location = New System.Drawing.Point(854, 531)
        Me.V2Label.Name = "V2Label"
        Me.V2Label.Size = New System.Drawing.Size(26, 13)
        Me.V2Label.TabIndex = 11
        Me.V2Label.Text = "V2: "
        '
        'V3Label
        '
        Me.V3Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.V3Label.AutoSize = True
        Me.V3Label.Location = New System.Drawing.Point(854, 543)
        Me.V3Label.Name = "V3Label"
        Me.V3Label.Size = New System.Drawing.Size(26, 13)
        Me.V3Label.TabIndex = 11
        Me.V3Label.Text = "V3: "
        '
        'ShowP_CheckBox
        '
        Me.ShowP_CheckBox.AutoSize = True
        Me.ShowP_CheckBox.Location = New System.Drawing.Point(857, 475)
        Me.ShowP_CheckBox.Name = "ShowP_CheckBox"
        Me.ShowP_CheckBox.Size = New System.Drawing.Size(86, 17)
        Me.ShowP_CheckBox.TabIndex = 21
        Me.ShowP_CheckBox.Text = "Show Power"
        Me.ShowP_CheckBox.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1129, 574)
        Me.Controls.Add(Me.ShowP_CheckBox)
        Me.Controls.Add(Me.ShowV_CheckBox)
        Me.Controls.Add(Me.ShowR_CheckBox)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.SWRZoom)
        Me.Controls.Add(Me.FrequencyLabel)
        Me.Controls.Add(Me.Frequency)
        Me.Controls.Add(Me.CustomPresetButton)
        Me.Controls.Add(Me.PresetsBox)
        Me.Controls.Add(Me.ClearGraph)
        Me.Controls.Add(Me.V3Label)
        Me.Controls.Add(Me.V2Label)
        Me.Controls.Add(Me.V1Label)
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
        CType(Me.SWRZoom, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents SWRZoom As System.Windows.Forms.TrackBar
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents ShowR_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents ShowV_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents V1Label As System.Windows.Forms.Label
    Friend WithEvents V2Label As System.Windows.Forms.Label
    Friend WithEvents V3Label As System.Windows.Forms.Label
    Friend WithEvents ShowP_CheckBox As System.Windows.Forms.CheckBox

End Class
