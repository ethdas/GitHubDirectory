<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Audio_Books
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCart = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbAudioBook = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(231, 238)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 47)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnCart
        '
        Me.btnCart.Location = New System.Drawing.Point(49, 238)
        Me.btnCart.Name = "btnCart"
        Me.btnCart.Size = New System.Drawing.Size(131, 47)
        Me.btnCart.TabIndex = 4
        Me.btnCart.Text = "Add Book to Cart"
        Me.btnCart.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbAudioBook)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 174)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select an Audio Book"
        '
        'lbAudioBook
        '
        Me.lbAudioBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAudioBook.FormattingEnabled = True
        Me.lbAudioBook.ItemHeight = 20
        Me.lbAudioBook.Items.AddRange(New Object() {"Learn Calculus in One Way(Audio)", "The History of Scotland(Audio)", "The Science of Body Language(Audio)", "Relaxation Technique(Audio)"})
        Me.lbAudioBook.Location = New System.Drawing.Point(20, 21)
        Me.lbAudioBook.Name = "lbAudioBook"
        Me.lbAudioBook.Size = New System.Drawing.Size(319, 124)
        Me.lbAudioBook.TabIndex = 0
        '
        'Audio_Books
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 328)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCart)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Audio_Books"
        Me.Text = "Audio Books"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnCart As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbAudioBook As ListBox
End Class
