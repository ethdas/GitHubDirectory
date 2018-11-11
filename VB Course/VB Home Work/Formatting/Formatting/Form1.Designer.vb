<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblEnterData = New System.Windows.Forms.Label()
        Me.lblFormatted = New System.Windows.Forms.Label()
        Me.txtEnterData = New System.Windows.Forms.TextBox()
        Me.txtFormatted = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnNumberF = New System.Windows.Forms.Button()
        Me.btnFixedF = New System.Windows.Forms.Button()
        Me.btnExpoF = New System.Windows.Forms.Button()
        Me.btnCurrF = New System.Windows.Forms.Button()
        Me.btnPercF = New System.Windows.Forms.Button()
        Me.btnShortD = New System.Windows.Forms.Button()
        Me.btnLongD = New System.Windows.Forms.Button()
        Me.btnShortT = New System.Windows.Forms.Button()
        Me.btnLongT = New System.Windows.Forms.Button()
        Me.btnDateTime = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEnterData
        '
        Me.lblEnterData.AutoSize = True
        Me.lblEnterData.Location = New System.Drawing.Point(32, 36)
        Me.lblEnterData.Name = "lblEnterData"
        Me.lblEnterData.Size = New System.Drawing.Size(155, 17)
        Me.lblEnterData.TabIndex = 0
        Me.lblEnterData.Text = "Enter a number or date"
        '
        'lblFormatted
        '
        Me.lblFormatted.AutoSize = True
        Me.lblFormatted.Location = New System.Drawing.Point(35, 76)
        Me.lblFormatted.Name = "lblFormatted"
        Me.lblFormatted.Size = New System.Drawing.Size(72, 17)
        Me.lblFormatted.TabIndex = 1
        Me.lblFormatted.Text = "Formatted"
        '
        'txtEnterData
        '
        Me.txtEnterData.Location = New System.Drawing.Point(222, 36)
        Me.txtEnterData.Name = "txtEnterData"
        Me.txtEnterData.Size = New System.Drawing.Size(284, 22)
        Me.txtEnterData.TabIndex = 2
        '
        'txtFormatted
        '
        Me.txtFormatted.BackColor = System.Drawing.SystemColors.Menu
        Me.txtFormatted.Location = New System.Drawing.Point(222, 76)
        Me.txtFormatted.Name = "txtFormatted"
        Me.txtFormatted.Size = New System.Drawing.Size(284, 22)
        Me.txtFormatted.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnDateTime)
        Me.GroupBox1.Controls.Add(Me.btnLongT)
        Me.GroupBox1.Controls.Add(Me.btnShortT)
        Me.GroupBox1.Controls.Add(Me.btnLongD)
        Me.GroupBox1.Controls.Add(Me.btnShortD)
        Me.GroupBox1.Controls.Add(Me.btnPercF)
        Me.GroupBox1.Controls.Add(Me.btnCurrF)
        Me.GroupBox1.Controls.Add(Me.btnExpoF)
        Me.GroupBox1.Controls.Add(Me.btnFixedF)
        Me.GroupBox1.Controls.Add(Me.btnNumberF)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 146)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(691, 276)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Format"
        '
        'btnNumberF
        '
        Me.btnNumberF.Location = New System.Drawing.Point(7, 36)
        Me.btnNumberF.Name = "btnNumberF"
        Me.btnNumberF.Size = New System.Drawing.Size(175, 23)
        Me.btnNumberF.TabIndex = 0
        Me.btnNumberF.Text = "Number Format(n)"
        Me.btnNumberF.UseVisualStyleBackColor = True
        '
        'btnFixedF
        '
        Me.btnFixedF.Location = New System.Drawing.Point(7, 66)
        Me.btnFixedF.Name = "btnFixedF"
        Me.btnFixedF.Size = New System.Drawing.Size(175, 23)
        Me.btnFixedF.TabIndex = 1
        Me.btnFixedF.Text = "Fixed-point Format(f)"
        Me.btnFixedF.UseVisualStyleBackColor = True
        '
        'btnExpoF
        '
        Me.btnExpoF.Location = New System.Drawing.Point(7, 96)
        Me.btnExpoF.Name = "btnExpoF"
        Me.btnExpoF.Size = New System.Drawing.Size(175, 23)
        Me.btnExpoF.TabIndex = 2
        Me.btnExpoF.Text = "Exponential Format(e)"
        Me.btnExpoF.UseVisualStyleBackColor = True
        '
        'btnCurrF
        '
        Me.btnCurrF.Location = New System.Drawing.Point(7, 126)
        Me.btnCurrF.Name = "btnCurrF"
        Me.btnCurrF.Size = New System.Drawing.Size(175, 23)
        Me.btnCurrF.TabIndex = 3
        Me.btnCurrF.Text = "Currency Format (c)"
        Me.btnCurrF.UseVisualStyleBackColor = True
        '
        'btnPercF
        '
        Me.btnPercF.Location = New System.Drawing.Point(7, 156)
        Me.btnPercF.Name = "btnPercF"
        Me.btnPercF.Size = New System.Drawing.Size(175, 23)
        Me.btnPercF.TabIndex = 4
        Me.btnPercF.Text = "Percent Format (p)"
        Me.btnPercF.UseVisualStyleBackColor = True
        '
        'btnShortD
        '
        Me.btnShortD.Location = New System.Drawing.Point(344, 36)
        Me.btnShortD.Name = "btnShortD"
        Me.btnShortD.Size = New System.Drawing.Size(175, 23)
        Me.btnShortD.TabIndex = 5
        Me.btnShortD.Text = "Short Date (d)"
        Me.btnShortD.UseVisualStyleBackColor = True
        '
        'btnLongD
        '
        Me.btnLongD.Location = New System.Drawing.Point(344, 66)
        Me.btnLongD.Name = "btnLongD"
        Me.btnLongD.Size = New System.Drawing.Size(175, 23)
        Me.btnLongD.TabIndex = 6
        Me.btnLongD.Text = "Long Date (D)"
        Me.btnLongD.UseVisualStyleBackColor = True
        '
        'btnShortT
        '
        Me.btnShortT.Location = New System.Drawing.Point(344, 96)
        Me.btnShortT.Name = "btnShortT"
        Me.btnShortT.Size = New System.Drawing.Size(175, 23)
        Me.btnShortT.TabIndex = 7
        Me.btnShortT.Text = "Short Time (t)"
        Me.btnShortT.UseVisualStyleBackColor = True
        '
        'btnLongT
        '
        Me.btnLongT.Location = New System.Drawing.Point(344, 126)
        Me.btnLongT.Name = "btnLongT"
        Me.btnLongT.Size = New System.Drawing.Size(175, 23)
        Me.btnLongT.TabIndex = 8
        Me.btnLongT.Text = "Long Time (T)"
        Me.btnLongT.UseVisualStyleBackColor = True
        '
        'btnDateTime
        '
        Me.btnDateTime.Location = New System.Drawing.Point(344, 156)
        Me.btnDateTime.Name = "btnDateTime"
        Me.btnDateTime.Size = New System.Drawing.Size(175, 23)
        Me.btnDateTime.TabIndex = 9
        Me.btnDateTime.Text = "Full Date/Time (F)"
        Me.btnDateTime.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtFormatted)
        Me.Controls.Add(Me.txtEnterData)
        Me.Controls.Add(Me.lblFormatted)
        Me.Controls.Add(Me.lblEnterData)
        Me.Name = "Form1"
        Me.Text = "Formatting"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEnterData As Label
    Friend WithEvents lblFormatted As Label
    Friend WithEvents txtEnterData As TextBox
    Friend WithEvents txtFormatted As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnDateTime As Button
    Friend WithEvents btnLongT As Button
    Friend WithEvents btnShortT As Button
    Friend WithEvents btnLongD As Button
    Friend WithEvents btnShortD As Button
    Friend WithEvents btnPercF As Button
    Friend WithEvents btnCurrF As Button
    Friend WithEvents btnExpoF As Button
    Friend WithEvents btnFixedF As Button
    Friend WithEvents btnNumberF As Button
End Class
