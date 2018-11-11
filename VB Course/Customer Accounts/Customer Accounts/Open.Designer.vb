<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Open
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
        Me.txtOpen = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtOpen
        '
        Me.txtOpen.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txtOpen.Location = New System.Drawing.Point(12, 12)
        Me.txtOpen.Multiline = True
        Me.txtOpen.Name = "txtOpen"
        Me.txtOpen.ReadOnly = True
        Me.txtOpen.Size = New System.Drawing.Size(456, 501)
        Me.txtOpen.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(502, 184)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 83)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Back to Main Form"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(502, 316)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(98, 46)
        Me.btnLoad.TabIndex = 2
        Me.btnLoad.Text = "Load Content"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'Open
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 525)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtOpen)
        Me.Name = "Open"
        Me.Text = "Open"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOpen As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnLoad As Button
End Class
