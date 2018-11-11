<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClickableNumberImages
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClickableNumberImages))
        Me.PicOne = New System.Windows.Forms.PictureBox()
        Me.PicTwo = New System.Windows.Forms.PictureBox()
        Me.PicThree = New System.Windows.Forms.PictureBox()
        Me.PicFour = New System.Windows.Forms.PictureBox()
        Me.PicFive = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblSpanish = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.PicOne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicThree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicFour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicFive, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PicOne
        '
        Me.PicOne.Image = CType(resources.GetObject("PicOne.Image"), System.Drawing.Image)
        Me.PicOne.Location = New System.Drawing.Point(90, 70)
        Me.PicOne.Name = "PicOne"
        Me.PicOne.Size = New System.Drawing.Size(88, 144)
        Me.PicOne.TabIndex = 0
        Me.PicOne.TabStop = False
        '
        'PicTwo
        '
        Me.PicTwo.Image = CType(resources.GetObject("PicTwo.Image"), System.Drawing.Image)
        Me.PicTwo.Location = New System.Drawing.Point(228, 70)
        Me.PicTwo.Name = "PicTwo"
        Me.PicTwo.Size = New System.Drawing.Size(88, 144)
        Me.PicTwo.TabIndex = 1
        Me.PicTwo.TabStop = False
        '
        'PicThree
        '
        Me.PicThree.Image = CType(resources.GetObject("PicThree.Image"), System.Drawing.Image)
        Me.PicThree.Location = New System.Drawing.Point(366, 70)
        Me.PicThree.Name = "PicThree"
        Me.PicThree.Size = New System.Drawing.Size(88, 144)
        Me.PicThree.TabIndex = 2
        Me.PicThree.TabStop = False
        '
        'PicFour
        '
        Me.PicFour.Image = CType(resources.GetObject("PicFour.Image"), System.Drawing.Image)
        Me.PicFour.Location = New System.Drawing.Point(504, 70)
        Me.PicFour.Name = "PicFour"
        Me.PicFour.Size = New System.Drawing.Size(88, 144)
        Me.PicFour.TabIndex = 3
        Me.PicFour.TabStop = False
        '
        'PicFive
        '
        Me.PicFive.Image = CType(resources.GetObject("PicFive.Image"), System.Drawing.Image)
        Me.PicFive.Location = New System.Drawing.Point(642, 70)
        Me.PicFive.Name = "PicFive"
        Me.PicFive.Size = New System.Drawing.Size(88, 144)
        Me.PicFive.TabIndex = 4
        Me.PicFive.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblSpanish})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 344)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblSpanish
        '
        Me.lblSpanish.Name = "lblSpanish"
        Me.lblSpanish.Size = New System.Drawing.Size(0, 17)
        Me.lblSpanish.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'ClickableNumberImages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(800, 366)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PicFive)
        Me.Controls.Add(Me.PicFour)
        Me.Controls.Add(Me.PicThree)
        Me.Controls.Add(Me.PicTwo)
        Me.Controls.Add(Me.PicOne)
        Me.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ClickableNumberImages"
        Me.Text = "Clickable Numbers"
        CType(Me.PicOne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicThree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicFour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicFive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicOne As PictureBox
    Friend WithEvents PicTwo As PictureBox
    Friend WithEvents PicThree As PictureBox
    Friend WithEvents PicFour As PictureBox
    Friend WithEvents PicFive As PictureBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblSpanish As ToolStripStatusLabel
End Class
