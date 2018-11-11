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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkLube = New System.Windows.Forms.CheckBox()
        Me.chkOil = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkTrans = New System.Windows.Forms.CheckBox()
        Me.chkRad = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkTireR = New System.Windows.Forms.CheckBox()
        Me.chkRepM = New System.Windows.Forms.CheckBox()
        Me.chkInsp = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtLabor = New System.Windows.Forms.TextBox()
        Me.txtParts = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTaxOnParts = New System.Windows.Forms.Label()
        Me.lblParts = New System.Windows.Forms.Label()
        Me.lblService = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.chkLube)
        Me.GroupBox1.Controls.Add(Me.chkOil)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Location = New System.Drawing.Point(23, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(229, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Oil && Lube"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(152, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "($18.00)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(152, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "($26.00)"
        '
        'chkLube
        '
        Me.chkLube.AutoSize = True
        Me.chkLube.Location = New System.Drawing.Point(7, 62)
        Me.chkLube.Name = "chkLube"
        Me.chkLube.Size = New System.Drawing.Size(143, 22)
        Me.chkLube.TabIndex = 1
        Me.chkLube.Text = "Lube Job             "
        Me.ToolTip1.SetToolTip(Me.chkLube, "Check the box if you require a lube job")
        Me.chkLube.UseVisualStyleBackColor = True
        '
        'chkOil
        '
        Me.chkOil.AutoSize = True
        Me.chkOil.Location = New System.Drawing.Point(7, 34)
        Me.chkOil.Name = "chkOil"
        Me.chkOil.Size = New System.Drawing.Size(139, 22)
        Me.chkOil.TabIndex = 0
        Me.chkOil.Text = "Oil Change         "
        Me.ToolTip1.SetToolTip(Me.chkOil, "Check the box if you need an Oil Change")
        Me.chkOil.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.chkTrans)
        Me.GroupBox2.Controls.Add(Me.chkRad)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox2.Location = New System.Drawing.Point(272, 36)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(274, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Flushes"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(189, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 17)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "($80.00)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(189, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "($30.00)"
        '
        'chkTrans
        '
        Me.chkTrans.AutoSize = True
        Me.chkTrans.Location = New System.Drawing.Point(7, 62)
        Me.chkTrans.Name = "chkTrans"
        Me.chkTrans.Size = New System.Drawing.Size(152, 21)
        Me.chkTrans.TabIndex = 1
        Me.chkTrans.Text = "Transmission Flush"
        Me.ToolTip1.SetToolTip(Me.chkTrans, "Check box if you need a transmission flush")
        Me.chkTrans.UseVisualStyleBackColor = True
        '
        'chkRad
        '
        Me.chkRad.AutoSize = True
        Me.chkRad.Location = New System.Drawing.Point(7, 34)
        Me.chkRad.Name = "chkRad"
        Me.chkRad.Size = New System.Drawing.Size(122, 21)
        Me.chkRad.TabIndex = 0
        Me.chkRad.Text = "Radiator Flush"
        Me.ToolTip1.SetToolTip(Me.chkRad, "check box if you need a Radiator Flush")
        Me.chkRad.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.chkTireR)
        Me.GroupBox3.Controls.Add(Me.chkRepM)
        Me.GroupBox3.Controls.Add(Me.chkInsp)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox3.Location = New System.Drawing.Point(23, 146)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(229, 100)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Misc"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(142, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "($20.00)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(134, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "($100.00)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(142, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "($15.00)"
        '
        'chkTireR
        '
        Me.chkTireR.AutoSize = True
        Me.chkTireR.Location = New System.Drawing.Point(7, 73)
        Me.chkTireR.Name = "chkTireR"
        Me.chkTireR.Size = New System.Drawing.Size(112, 21)
        Me.chkTireR.TabIndex = 2
        Me.chkTireR.Text = "Tire Rotation"
        Me.ToolTip1.SetToolTip(Me.chkTireR, "Check box if you need a tire rotation")
        Me.chkTireR.UseVisualStyleBackColor = True
        '
        'chkRepM
        '
        Me.chkRepM.AutoSize = True
        Me.chkRepM.Location = New System.Drawing.Point(7, 50)
        Me.chkRepM.Name = "chkRepM"
        Me.chkRepM.Size = New System.Drawing.Size(129, 21)
        Me.chkRepM.TabIndex = 1
        Me.chkRepM.Text = "Replace Muffler"
        Me.ToolTip1.SetToolTip(Me.chkRepM, "check box if you require Muffler replacement")
        Me.chkRepM.UseVisualStyleBackColor = True
        '
        'chkInsp
        '
        Me.chkInsp.AutoSize = True
        Me.chkInsp.Location = New System.Drawing.Point(7, 22)
        Me.chkInsp.Name = "chkInsp"
        Me.chkInsp.Size = New System.Drawing.Size(94, 21)
        Me.chkInsp.TabIndex = 0
        Me.chkInsp.Text = "Inspection"
        Me.ToolTip1.SetToolTip(Me.chkInsp, "Check box if you want us to do a general inspection")
        Me.chkInsp.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.txtLabor)
        Me.GroupBox4.Controls.Add(Me.txtParts)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox4.Location = New System.Drawing.Point(272, 146)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(274, 100)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Parts and Labor"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(141, 58)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(120, 16)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "($20.00 per hour)"
        '
        'txtLabor
        '
        Me.txtLabor.Location = New System.Drawing.Point(63, 54)
        Me.txtLabor.Name = "txtLabor"
        Me.txtLabor.Size = New System.Drawing.Size(76, 22)
        Me.txtLabor.TabIndex = 3
        '
        'txtParts
        '
        Me.txtParts.Location = New System.Drawing.Point(62, 22)
        Me.txtParts.Name = "txtParts"
        Me.txtParts.Size = New System.Drawing.Size(76, 22)
        Me.txtParts.TabIndex = 2
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 59)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 17)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Labor"
        Me.ToolTip1.SetToolTip(Me.Label17, "Enter amount of labor hours")
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(7, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(41, 17)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Parts"
        Me.ToolTip1.SetToolTip(Me.Label16, "Enter Total cost for parts here")
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblTotal)
        Me.GroupBox5.Controls.Add(Me.lblTaxOnParts)
        Me.GroupBox5.Controls.Add(Me.lblParts)
        Me.GroupBox5.Controls.Add(Me.lblService)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox5.Location = New System.Drawing.Point(23, 253)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(523, 136)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Summary"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(246, 104)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 7
        '
        'lblTaxOnParts
        '
        Me.lblTaxOnParts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTaxOnParts.Location = New System.Drawing.Point(246, 73)
        Me.lblTaxOnParts.Name = "lblTaxOnParts"
        Me.lblTaxOnParts.Size = New System.Drawing.Size(100, 23)
        Me.lblTaxOnParts.TabIndex = 6
        '
        'lblParts
        '
        Me.lblParts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblParts.Location = New System.Drawing.Point(246, 47)
        Me.lblParts.Name = "lblParts"
        Me.lblParts.Size = New System.Drawing.Size(100, 23)
        Me.lblParts.TabIndex = 5
        '
        'lblService
        '
        Me.lblService.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblService.Location = New System.Drawing.Point(246, 18)
        Me.lblService.Name = "lblService"
        Me.lblService.Size = New System.Drawing.Size(100, 23)
        Me.lblService.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(147, 104)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 17)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Total Fees"
        Me.ToolTip1.SetToolTip(Me.Label11, "Total feed due")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(125, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 17)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Tax (on parts)"
        Me.ToolTip1.SetToolTip(Me.Label10, "Amount of Tax on Parts")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(181, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 17)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Parts"
        Me.ToolTip1.SetToolTip(Me.Label9, "Gross Parts cost")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(98, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Service and Labor"
        Me.ToolTip1.SetToolTip(Me.Label8, "Amount for all other services Excluding Parts")
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(23, 396)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(119, 32)
        Me.btnCalc.TabIndex = 4
        Me.btnCalc.Text = "Calculate &Total"
        Me.ToolTip1.SetToolTip(Me.btnCalc, "Click here to calculate")
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(220, 396)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(119, 32)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "&Clear"
        Me.ToolTip1.SetToolTip(Me.btnClear, "Click here to reset all values")
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(417, 396)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(119, 32)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Click here to exit form")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(575, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Joe's Automotive"
        Me.TransparencyKey = System.Drawing.Color.DarkSlateBlue
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents chkLube As CheckBox
    Friend WithEvents chkOil As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents chkTrans As CheckBox
    Friend WithEvents chkRad As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents chkTireR As CheckBox
    Friend WithEvents chkRepM As CheckBox
    Friend WithEvents chkInsp As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtLabor As TextBox
    Friend WithEvents txtParts As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTaxOnParts As Label
    Friend WithEvents lblParts As Label
    Friend WithEvents lblService As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
