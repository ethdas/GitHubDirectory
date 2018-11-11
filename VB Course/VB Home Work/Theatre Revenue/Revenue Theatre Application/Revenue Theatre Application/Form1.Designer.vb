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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAdultTicketsSold = New System.Windows.Forms.TextBox()
        Me.txtAdultTicketPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtChildTicketsSold = New System.Windows.Forms.TextBox()
        Me.txtChildTicketPrice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblGrossRevenue = New System.Windows.Forms.Label()
        Me.lblGrossChildTicketSales = New System.Windows.Forms.Label()
        Me.lblGrossAdultTicketSales = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblNetRevenue = New System.Windows.Forms.Label()
        Me.lblNetChildTicketSales = New System.Windows.Forms.Label()
        Me.lblNetAdultTicketSales = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnCalcRevenue = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAdultTicketsSold)
        Me.GroupBox1.Controls.Add(Me.txtAdultTicketPrice)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(267, 124)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Adult Tickt Sales"
        '
        'txtAdultTicketsSold
        '
        Me.txtAdultTicketsSold.Location = New System.Drawing.Point(151, 67)
        Me.txtAdultTicketsSold.Name = "txtAdultTicketsSold"
        Me.txtAdultTicketsSold.Size = New System.Drawing.Size(100, 22)
        Me.txtAdultTicketsSold.TabIndex = 1
        '
        'txtAdultTicketPrice
        '
        Me.txtAdultTicketPrice.Location = New System.Drawing.Point(151, 38)
        Me.txtAdultTicketPrice.Name = "txtAdultTicketPrice"
        Me.txtAdultTicketPrice.Size = New System.Drawing.Size(100, 22)
        Me.txtAdultTicketPrice.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tickets Sold"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Price Per Ticket"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtChildTicketsSold)
        Me.GroupBox2.Controls.Add(Me.txtChildTicketPrice)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(318, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(267, 124)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Child Tickt Sales"
        '
        'txtChildTicketsSold
        '
        Me.txtChildTicketsSold.Location = New System.Drawing.Point(151, 67)
        Me.txtChildTicketsSold.Name = "txtChildTicketsSold"
        Me.txtChildTicketsSold.Size = New System.Drawing.Size(100, 22)
        Me.txtChildTicketsSold.TabIndex = 1
        '
        'txtChildTicketPrice
        '
        Me.txtChildTicketPrice.Location = New System.Drawing.Point(151, 38)
        Me.txtChildTicketPrice.Name = "txtChildTicketPrice"
        Me.txtChildTicketPrice.Size = New System.Drawing.Size(100, 22)
        Me.txtChildTicketPrice.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tickets Sold"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Price Per Ticket"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblGrossRevenue)
        Me.GroupBox3.Controls.Add(Me.lblGrossChildTicketSales)
        Me.GroupBox3.Controls.Add(Me.lblGrossAdultTicketSales)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(27, 144)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(267, 186)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Gross Ticket Revenue"
        '
        'lblGrossRevenue
        '
        Me.lblGrossRevenue.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblGrossRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrossRevenue.Location = New System.Drawing.Point(151, 121)
        Me.lblGrossRevenue.Name = "lblGrossRevenue"
        Me.lblGrossRevenue.Size = New System.Drawing.Size(110, 23)
        Me.lblGrossRevenue.TabIndex = 2
        '
        'lblGrossChildTicketSales
        '
        Me.lblGrossChildTicketSales.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblGrossChildTicketSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrossChildTicketSales.Location = New System.Drawing.Point(151, 85)
        Me.lblGrossChildTicketSales.Name = "lblGrossChildTicketSales"
        Me.lblGrossChildTicketSales.Size = New System.Drawing.Size(110, 23)
        Me.lblGrossChildTicketSales.TabIndex = 1
        '
        'lblGrossAdultTicketSales
        '
        Me.lblGrossAdultTicketSales.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblGrossAdultTicketSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrossAdultTicketSales.Location = New System.Drawing.Point(151, 39)
        Me.lblGrossAdultTicketSales.Name = "lblGrossAdultTicketSales"
        Me.lblGrossAdultTicketSales.Size = New System.Drawing.Size(110, 23)
        Me.lblGrossAdultTicketSales.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 34)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Total Gross Revenue" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " for Ticket Sales"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Child Ticket Sales"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Adult Ticket Sales"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblNetRevenue)
        Me.GroupBox4.Controls.Add(Me.lblNetChildTicketSales)
        Me.GroupBox4.Controls.Add(Me.lblNetAdultTicketSales)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Location = New System.Drawing.Point(318, 144)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(267, 186)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Net Ticket Revenue"
        '
        'lblNetRevenue
        '
        Me.lblNetRevenue.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblNetRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNetRevenue.Location = New System.Drawing.Point(151, 121)
        Me.lblNetRevenue.Name = "lblNetRevenue"
        Me.lblNetRevenue.Size = New System.Drawing.Size(110, 23)
        Me.lblNetRevenue.TabIndex = 2
        '
        'lblNetChildTicketSales
        '
        Me.lblNetChildTicketSales.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblNetChildTicketSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNetChildTicketSales.Location = New System.Drawing.Point(151, 85)
        Me.lblNetChildTicketSales.Name = "lblNetChildTicketSales"
        Me.lblNetChildTicketSales.Size = New System.Drawing.Size(110, 23)
        Me.lblNetChildTicketSales.TabIndex = 1
        '
        'lblNetAdultTicketSales
        '
        Me.lblNetAdultTicketSales.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblNetAdultTicketSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNetAdultTicketSales.Location = New System.Drawing.Point(151, 39)
        Me.lblNetAdultTicketSales.Name = "lblNetAdultTicketSales"
        Me.lblNetAdultTicketSales.Size = New System.Drawing.Size(110, 23)
        Me.lblNetAdultTicketSales.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 121)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(127, 34)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Total Net Revenue" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " for Ticket Sales"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(29, 85)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 17)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Child Ticket Sales"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(28, 39)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(121, 17)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Adult Ticket Sales"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnCalcRevenue
        '
        Me.btnCalcRevenue.Location = New System.Drawing.Point(27, 356)
        Me.btnCalcRevenue.Name = "btnCalcRevenue"
        Me.btnCalcRevenue.Size = New System.Drawing.Size(230, 32)
        Me.btnCalcRevenue.TabIndex = 2
        Me.btnCalcRevenue.Text = "Calculate Ticket &Revenue"
        Me.btnCalcRevenue.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(341, 356)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(77, 31)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(502, 357)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 31)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 419)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalcRevenue)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Theatre Revenue"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtAdultTicketsSold As TextBox
    Friend WithEvents txtAdultTicketPrice As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtChildTicketsSold As TextBox
    Friend WithEvents txtChildTicketPrice As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lblGrossRevenue As Label
    Friend WithEvents lblGrossChildTicketSales As Label
    Friend WithEvents lblGrossAdultTicketSales As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents lblNetRevenue As Label
    Friend WithEvents lblNetChildTicketSales As Label
    Friend WithEvents lblNetAdultTicketSales As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnCalcRevenue As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
