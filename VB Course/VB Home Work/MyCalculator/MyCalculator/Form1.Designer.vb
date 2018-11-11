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
        Me.lblNumber1 = New System.Windows.Forms.Label()
        Me.lblOperation = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt1stNum = New System.Windows.Forms.TextBox()
        Me.txt2ndNum = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btntimes = New System.Windows.Forms.Button()
        Me.btnDiv2 = New System.Windows.Forms.Button()
        Me.btnExpo = New System.Windows.Forms.Button()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNumber1
        '
        Me.lblNumber1.AutoSize = True
        Me.lblNumber1.Location = New System.Drawing.Point(71, 45)
        Me.lblNumber1.Name = "lblNumber1"
        Me.lblNumber1.Size = New System.Drawing.Size(89, 17)
        Me.lblNumber1.TabIndex = 0
        Me.lblNumber1.Text = "First Number"
        '
        'lblOperation
        '
        Me.lblOperation.AutoSize = True
        Me.lblOperation.Location = New System.Drawing.Point(71, 140)
        Me.lblOperation.Name = "lblOperation"
        Me.lblOperation.Size = New System.Drawing.Size(71, 17)
        Me.lblOperation.TabIndex = 1
        Me.lblOperation.Text = "Operation"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Second Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(71, 270)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Result"
        '
        'txt1stNum
        '
        Me.txt1stNum.Location = New System.Drawing.Point(222, 45)
        Me.txt1stNum.Name = "txt1stNum"
        Me.txt1stNum.Size = New System.Drawing.Size(185, 22)
        Me.txt1stNum.TabIndex = 4
        '
        'txt2ndNum
        '
        Me.txt2ndNum.Location = New System.Drawing.Point(222, 79)
        Me.txt2ndNum.Name = "txt2ndNum"
        Me.txt2ndNum.Size = New System.Drawing.Size(185, 22)
        Me.txt2ndNum.TabIndex = 5
        '
        'txtResult
        '
        Me.txtResult.BackColor = System.Drawing.SystemColors.Menu
        Me.txtResult.Location = New System.Drawing.Point(222, 270)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(185, 22)
        Me.txtResult.TabIndex = 6
        '
        'btnPlus
        '
        Me.btnPlus.Location = New System.Drawing.Point(222, 121)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(48, 23)
        Me.btnPlus.TabIndex = 7
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'btnMinus
        '
        Me.btnMinus.Location = New System.Drawing.Point(330, 121)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(50, 23)
        Me.btnMinus.TabIndex = 8
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btntimes
        '
        Me.btntimes.Location = New System.Drawing.Point(437, 121)
        Me.btntimes.Name = "btntimes"
        Me.btntimes.Size = New System.Drawing.Size(61, 23)
        Me.btntimes.TabIndex = 9
        Me.btntimes.Text = "*"
        Me.btntimes.UseVisualStyleBackColor = True
        '
        'btnDiv2
        '
        Me.btnDiv2.Location = New System.Drawing.Point(222, 162)
        Me.btnDiv2.Name = "btnDiv2"
        Me.btnDiv2.Size = New System.Drawing.Size(48, 23)
        Me.btnDiv2.TabIndex = 10
        Me.btnDiv2.Text = "\"
        Me.btnDiv2.UseVisualStyleBackColor = True
        '
        'btnExpo
        '
        Me.btnExpo.Location = New System.Drawing.Point(333, 161)
        Me.btnExpo.Name = "btnExpo"
        Me.btnExpo.Size = New System.Drawing.Size(47, 23)
        Me.btnExpo.TabIndex = 11
        Me.btnExpo.Text = "^"
        Me.btnExpo.UseVisualStyleBackColor = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(437, 161)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(61, 23)
        Me.btnMod.TabIndex = 12
        Me.btnMod.Text = "MOD"
        Me.btnMod.UseVisualStyleBackColor = True
        '
        'btnDiv
        '
        Me.btnDiv.Location = New System.Drawing.Point(548, 121)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(53, 23)
        Me.btnDiv.TabIndex = 13
        Me.btnDiv.Text = "/"
        Me.btnDiv.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(195, 343)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(409, 343)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 389)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDiv)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnExpo)
        Me.Controls.Add(Me.btnDiv2)
        Me.Controls.Add(Me.btntimes)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txt2ndNum)
        Me.Controls.Add(Me.txt1stNum)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblOperation)
        Me.Controls.Add(Me.lblNumber1)
        Me.Name = "Form1"
        Me.Text = "My Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumber1 As Label
    Friend WithEvents lblOperation As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt1stNum As TextBox
    Friend WithEvents txt2ndNum As TextBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents btnPlus As Button
    Friend WithEvents btnMinus As Button
    Friend WithEvents btntimes As Button
    Friend WithEvents btnDiv2 As Button
    Friend WithEvents btnExpo As Button
    Friend WithEvents btnMod As Button
    Friend WithEvents btnDiv As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
