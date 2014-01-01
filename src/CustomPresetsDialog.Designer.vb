<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomPresetsDialog
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
        Me.StopFreq = New System.Windows.Forms.TextBox()
        Me.StopFrequencyLabel = New System.Windows.Forms.Label()
        Me.StartFreqLabel = New System.Windows.Forms.Label()
        Me.StartFreq = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'StopFreq
        '
        Me.StopFreq.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StopFreq.Location = New System.Drawing.Point(99, 38)
        Me.StopFreq.Name = "StopFreq"
        Me.StopFreq.Size = New System.Drawing.Size(181, 20)
        Me.StopFreq.TabIndex = 11
        '
        'StopFrequencyLabel
        '
        Me.StopFrequencyLabel.AutoSize = True
        Me.StopFrequencyLabel.Location = New System.Drawing.Point(11, 41)
        Me.StopFrequencyLabel.Name = "StopFrequencyLabel"
        Me.StopFrequencyLabel.Size = New System.Drawing.Size(82, 13)
        Me.StopFrequencyLabel.TabIndex = 10
        Me.StopFrequencyLabel.Text = "Start Frequency"
        '
        'StartFreqLabel
        '
        Me.StartFreqLabel.AutoSize = True
        Me.StartFreqLabel.Location = New System.Drawing.Point(58, 15)
        Me.StartFreqLabel.Name = "StartFreqLabel"
        Me.StartFreqLabel.Size = New System.Drawing.Size(35, 13)
        Me.StartFreqLabel.TabIndex = 9
        Me.StartFreqLabel.Text = "Name"
        '
        'StartFreq
        '
        Me.StartFreq.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartFreq.Location = New System.Drawing.Point(99, 12)
        Me.StartFreq.Name = "StartFreq"
        Me.StartFreq.Size = New System.Drawing.Size(181, 20)
        Me.StartFreq.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(99, 64)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(181, 20)
        Me.TextBox1.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Stop Frequency"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(205, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CustomPresets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 124)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StopFreq)
        Me.Controls.Add(Me.StopFrequencyLabel)
        Me.Controls.Add(Me.StartFreqLabel)
        Me.Controls.Add(Me.StartFreq)
        Me.Name = "CustomPresets"
        Me.ShowIcon = False
        Me.Text = "Add Custom preset"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StopFreq As System.Windows.Forms.TextBox
    Friend WithEvents StopFrequencyLabel As System.Windows.Forms.Label
    Friend WithEvents StartFreqLabel As System.Windows.Forms.Label
    Friend WithEvents StartFreq As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
