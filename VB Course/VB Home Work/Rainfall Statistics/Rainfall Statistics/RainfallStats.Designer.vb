<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RainfallStats
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
        Me.lbStatistics = New System.Windows.Forms.ListBox()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.lblMaximum = New System.Windows.Forms.Label()
        Me.lblMinimum = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbStatistics
        '
        Me.lbStatistics.FormattingEnabled = True
        Me.lbStatistics.ItemHeight = 16
        Me.lbStatistics.Location = New System.Drawing.Point(21, 12)
        Me.lbStatistics.Name = "lbStatistics"
        Me.lbStatistics.Size = New System.Drawing.Size(308, 388)
        Me.lbStatistics.TabIndex = 0
        Me.lbStatistics.Visible = False
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(21, 406)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(178, 32)
        Me.btnInput.TabIndex = 1
        Me.btnInput.Text = "Input  Monthly Rainfall"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(313, 406)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(105, 32)
        Me.btnDisplay.TabIndex = 2
        Me.btnDisplay.Text = "Display Stats "
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(532, 406)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(52, 32)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(698, 406)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(55, 32)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(460, 36)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(230, 20)
        Me.lblHeading.TabIndex = 5
        Me.lblHeading.Text = "Monthly Rainfall Statistics"
        Me.lblHeading.Visible = False
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(370, 80)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(383, 33)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTotal.Visible = False
        '
        'lblAverage
        '
        Me.lblAverage.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverage.Location = New System.Drawing.Point(370, 145)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(383, 33)
        Me.lblAverage.TabIndex = 7
        Me.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblAverage.Visible = False
        '
        'lblMaximum
        '
        Me.lblMaximum.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblMaximum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMaximum.Location = New System.Drawing.Point(370, 210)
        Me.lblMaximum.Name = "lblMaximum"
        Me.lblMaximum.Size = New System.Drawing.Size(383, 33)
        Me.lblMaximum.TabIndex = 8
        Me.lblMaximum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblMaximum.Visible = False
        '
        'lblMinimum
        '
        Me.lblMinimum.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblMinimum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMinimum.Location = New System.Drawing.Point(370, 275)
        Me.lblMinimum.Name = "lblMinimum"
        Me.lblMinimum.Size = New System.Drawing.Size(383, 33)
        Me.lblMinimum.TabIndex = 9
        Me.lblMinimum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblMinimum.Visible = False
        '
        'RainfallStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblMinimum)
        Me.Controls.Add(Me.lblMaximum)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.lbStatistics)
        Me.Name = "RainfallStats"
        Me.Text = "Rainfall Statistics"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbStatistics As ListBox
    Friend WithEvents btnInput As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblAverage As Label
    Friend WithEvents lblMaximum As Label
    Friend WithEvents lblMinimum As Label
End Class
