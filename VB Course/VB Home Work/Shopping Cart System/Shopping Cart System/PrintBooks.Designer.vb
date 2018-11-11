<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintBooks
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbprint = New System.Windows.Forms.ListBox()
        Me.btnCart = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbprint)
        Me.GroupBox1.Location = New System.Drawing.Point(50, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(396, 160)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Print Book"
        '
        'lbprint
        '
        Me.lbprint.DisplayMember = "0.00"
        Me.lbprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbprint.FormattingEnabled = True
        Me.lbprint.ItemHeight = 20
        Me.lbprint.Items.AddRange(New Object() {"I did it Your Way(print)", "The History of Scotland(print)", "Learn Calculus in One Day(print)", "Feel the Stress(print)", ""})
        Me.lbprint.Location = New System.Drawing.Point(6, 21)
        Me.lbprint.Name = "lbprint"
        Me.lbprint.Size = New System.Drawing.Size(376, 124)
        Me.lbprint.TabIndex = 0
        Me.lbprint.ValueMember = "0.00"
        '
        'btnCart
        '
        Me.btnCart.Location = New System.Drawing.Point(56, 206)
        Me.btnCart.Name = "btnCart"
        Me.btnCart.Size = New System.Drawing.Size(131, 47)
        Me.btnCart.TabIndex = 1
        Me.btnCart.Text = "Add Book to Cart"
        Me.btnCart.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(332, 206)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 47)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'PrintBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 294)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCart)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "PrintBooks"
        Me.Text = "Print Books"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbprint As ListBox
    Friend WithEvents btnCart As Button
    Friend WithEvents btnClose As Button
End Class
