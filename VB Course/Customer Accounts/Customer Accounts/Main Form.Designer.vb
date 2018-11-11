<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewRecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ByCustomerNumberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ByLastNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Main = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramPurposeDescriptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pdPrint = New System.Drawing.Printing.PrintDocument()
        Me.lblMyName = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.SearchToolStripMenuItem, Me.Main})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.PrintToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(120, 26)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(120, 26)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(120, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewRecordToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(47, 24)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'AddNewRecordToolStripMenuItem
        '
        Me.AddNewRecordToolStripMenuItem.Name = "AddNewRecordToolStripMenuItem"
        Me.AddNewRecordToolStripMenuItem.Size = New System.Drawing.Size(197, 26)
        Me.AddNewRecordToolStripMenuItem.Text = "Add New Record"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ByCustomerNumberToolStripMenuItem, Me.ByLastNameToolStripMenuItem})
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(65, 24)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'ByCustomerNumberToolStripMenuItem
        '
        Me.ByCustomerNumberToolStripMenuItem.Name = "ByCustomerNumberToolStripMenuItem"
        Me.ByCustomerNumberToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.ByCustomerNumberToolStripMenuItem.Text = "By Customer Number "
        '
        'ByLastNameToolStripMenuItem
        '
        Me.ByLastNameToolStripMenuItem.Name = "ByLastNameToolStripMenuItem"
        Me.ByLastNameToolStripMenuItem.Size = New System.Drawing.Size(229, 26)
        Me.ByLastNameToolStripMenuItem.Text = "By Last Name "
        '
        'Main
        '
        Me.Main.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramPurposeDescriptionToolStripMenuItem})
        Me.Main.Name = "Main"
        Me.Main.Size = New System.Drawing.Size(62, 24)
        Me.Main.Text = "About"
        '
        'ProgramPurposeDescriptionToolStripMenuItem
        '
        Me.ProgramPurposeDescriptionToolStripMenuItem.Name = "ProgramPurposeDescriptionToolStripMenuItem"
        Me.ProgramPurposeDescriptionToolStripMenuItem.Size = New System.Drawing.Size(278, 26)
        Me.ProgramPurposeDescriptionToolStripMenuItem.Text = "Program Purpose Description"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PapayaWhip
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lblDisplay)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(230, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(570, 429)
        Me.Panel1.TabIndex = 2
        '
        'lblDisplay
        '
        Me.lblDisplay.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDisplay.Location = New System.Drawing.Point(34, 5)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(469, 98)
        Me.lblDisplay.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Broadway", 16.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(34, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(469, 280)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Welcome to Appex  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "An application that helps you " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "store , Edit and Search " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cus" &
    "tomer Account Information!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(28, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 287)
        Me.Label2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Khaki
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(89, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 190)
        Me.Label3.TabIndex = 4
        '
        'pdPrint
        '
        '
        'lblMyName
        '
        Me.lblMyName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMyName.Location = New System.Drawing.Point(28, 42)
        Me.lblMyName.Name = "lblMyName"
        Me.lblMyName.Size = New System.Drawing.Size(177, 68)
        Me.lblMyName.TabIndex = 5
        Me.lblMyName.Text = "Click to see my Name"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblMyName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Customer Accounts "
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewRecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ByCustomerNumberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ByLastNameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Main As ToolStripMenuItem
    Friend WithEvents ProgramPurposeDescriptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblDisplay As Label
    Friend WithEvents pdPrint As Printing.PrintDocument
    Friend WithEvents lblMyName As Label
End Class
