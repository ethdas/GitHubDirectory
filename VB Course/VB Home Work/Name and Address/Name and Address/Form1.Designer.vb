<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NameAddress
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
        Me.lblNameAddress = New System.Windows.Forms.Label()
        Me.btnShowInfo = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblStreet = New System.Windows.Forms.Label()
        Me.lblCityStateZip = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNameAddress
        '
        Me.lblNameAddress.AutoSize = True
        Me.lblNameAddress.Location = New System.Drawing.Point(613, 330)
        Me.lblNameAddress.Name = "lblNameAddress"
        Me.lblNameAddress.Size = New System.Drawing.Size(160, 51)
        Me.lblNameAddress.TabIndex = 0
        Me.lblNameAddress.Text = "William Wolfe" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "888 South Main Street" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WaynesVille , NC 28786" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblNameAddress.Visible = False
        '
        'btnShowInfo
        '
        Me.btnShowInfo.Location = New System.Drawing.Point(129, 243)
        Me.btnShowInfo.Name = "btnShowInfo"
        Me.btnShowInfo.Size = New System.Drawing.Size(98, 31)
        Me.btnShowInfo.TabIndex = 1
        Me.btnShowInfo.Text = "Show Info"
        Me.btnShowInfo.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(404, 242)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 32)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(299, 36)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(92, 17)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "William Wolfe"
        Me.lblName.Visible = False
        '
        'lblStreet
        '
        Me.lblStreet.AutoSize = True
        Me.lblStreet.Location = New System.Drawing.Point(271, 68)
        Me.lblStreet.Name = "lblStreet"
        Me.lblStreet.Size = New System.Drawing.Size(149, 17)
        Me.lblStreet.TabIndex = 4
        Me.lblStreet.Text = "888 South Main Street"
        Me.lblStreet.Visible = False
        '
        'lblCityStateZip
        '
        Me.lblCityStateZip.AutoSize = True
        Me.lblCityStateZip.Location = New System.Drawing.Point(265, 100)
        Me.lblCityStateZip.Name = "lblCityStateZip"
        Me.lblCityStateZip.Size = New System.Drawing.Size(160, 17)
        Me.lblCityStateZip.TabIndex = 5
        Me.lblCityStateZip.Text = "WaynesVille , NC 28786"
        Me.lblCityStateZip.Visible = False
        '
        'NameAddress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblCityStateZip)
        Me.Controls.Add(Me.lblStreet)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnShowInfo)
        Me.Controls.Add(Me.lblNameAddress)
        Me.Name = "NameAddress"
        Me.Text = "Name and Address"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNameAddress As Label
    Friend WithEvents btnShowInfo As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblStreet As Label
    Friend WithEvents lblCityStateZip As Label
End Class
