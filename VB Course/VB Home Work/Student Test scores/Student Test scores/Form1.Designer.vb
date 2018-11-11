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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReportPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblAverage6 = New System.Windows.Forms.Label()
        Me.lblAverage5 = New System.Windows.Forms.Label()
        Me.lblAverage4 = New System.Windows.Forms.Label()
        Me.lblAverage3 = New System.Windows.Forms.Label()
        Me.lblAverage2 = New System.Windows.Forms.Label()
        Me.lblAverage1 = New System.Windows.Forms.Label()
        Me.txtScore6_4 = New System.Windows.Forms.TextBox()
        Me.txtScore6_3 = New System.Windows.Forms.TextBox()
        Me.txtScore6_2 = New System.Windows.Forms.TextBox()
        Me.txtScore6_5 = New System.Windows.Forms.TextBox()
        Me.txtScore6_1 = New System.Windows.Forms.TextBox()
        Me.txtScore5_4 = New System.Windows.Forms.TextBox()
        Me.txtScore5_3 = New System.Windows.Forms.TextBox()
        Me.txtScore5_2 = New System.Windows.Forms.TextBox()
        Me.txtScore5_5 = New System.Windows.Forms.TextBox()
        Me.txtScore5_1 = New System.Windows.Forms.TextBox()
        Me.txtScore4_4 = New System.Windows.Forms.TextBox()
        Me.txtScore4_3 = New System.Windows.Forms.TextBox()
        Me.txtScore4_2 = New System.Windows.Forms.TextBox()
        Me.txtScore4_5 = New System.Windows.Forms.TextBox()
        Me.txtScore4_1 = New System.Windows.Forms.TextBox()
        Me.txtScore2_4 = New System.Windows.Forms.TextBox()
        Me.txtScore2_3 = New System.Windows.Forms.TextBox()
        Me.txtScore2_2 = New System.Windows.Forms.TextBox()
        Me.txtScore2_5 = New System.Windows.Forms.TextBox()
        Me.txtScore2_1 = New System.Windows.Forms.TextBox()
        Me.txtScore3_4 = New System.Windows.Forms.TextBox()
        Me.txtScore3_3 = New System.Windows.Forms.TextBox()
        Me.txtScore3_2 = New System.Windows.Forms.TextBox()
        Me.txtScore3_5 = New System.Windows.Forms.TextBox()
        Me.txtScore3_1 = New System.Windows.Forms.TextBox()
        Me.txtScore1_4 = New System.Windows.Forms.TextBox()
        Me.txtScore1_3 = New System.Windows.Forms.TextBox()
        Me.txtScore1_2 = New System.Windows.Forms.TextBox()
        Me.txtScore1_5 = New System.Windows.Forms.TextBox()
        Me.txtScore1_1 = New System.Windows.Forms.TextBox()
        Me.txtNSix = New System.Windows.Forms.TextBox()
        Me.txtNFive = New System.Windows.Forms.TextBox()
        Me.txtNFour = New System.Windows.Forms.TextBox()
        Me.txtNThree = New System.Windows.Forms.TextBox()
        Me.txtNTwo = New System.Windows.Forms.TextBox()
        Me.txtNOne = New System.Windows.Forms.TextBox()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.lblScores = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.ofdOpenStudentFile = New System.Windows.Forms.OpenFileDialog()
        Me.sfdSaveStudentFile = New System.Windows.Forms.SaveFileDialog()
        Me.pdPrint = New System.Drawing.Printing.PrintDocument()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuReport, Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.mnuFileSave, Me.mnuFileSaveAs, Me.ToolStripSeparator1, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(44, 24)
        Me.mnuFile.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
        Me.OpenToolStripMenuItem.Text = "&Open ..."
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuFileSave.Size = New System.Drawing.Size(186, 26)
        Me.mnuFileSave.Text = "Save"
        '
        'mnuFileSaveAs
        '
        Me.mnuFileSaveAs.Name = "mnuFileSaveAs"
        Me.mnuFileSaveAs.Size = New System.Drawing.Size(186, 26)
        Me.mnuFileSaveAs.Text = "Save AS"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(183, 6)
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.mnuFileExit.Size = New System.Drawing.Size(186, 26)
        Me.mnuFileExit.Text = "Exit"
        '
        'mnuReport
        '
        Me.mnuReport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuReportPrint, Me.ResetToolStripMenuItem})
        Me.mnuReport.Name = "mnuReport"
        Me.mnuReport.Size = New System.Drawing.Size(66, 24)
        Me.mnuReport.Text = "Report"
        '
        'mnuReportPrint
        '
        Me.mnuReportPrint.Name = "mnuReportPrint"
        Me.mnuReportPrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.mnuReportPrint.Size = New System.Drawing.Size(168, 26)
        Me.mnuReportPrint.Text = "Print "
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(168, 26)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(53, 24)
        Me.mnuHelp.Text = "Help"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(125, 26)
        Me.mnuHelpAbout.Text = "About"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblAverage6)
        Me.GroupBox1.Controls.Add(Me.lblAverage5)
        Me.GroupBox1.Controls.Add(Me.lblAverage4)
        Me.GroupBox1.Controls.Add(Me.lblAverage3)
        Me.GroupBox1.Controls.Add(Me.lblAverage2)
        Me.GroupBox1.Controls.Add(Me.lblAverage1)
        Me.GroupBox1.Controls.Add(Me.txtScore6_4)
        Me.GroupBox1.Controls.Add(Me.txtScore6_3)
        Me.GroupBox1.Controls.Add(Me.txtScore6_2)
        Me.GroupBox1.Controls.Add(Me.txtScore6_5)
        Me.GroupBox1.Controls.Add(Me.txtScore6_1)
        Me.GroupBox1.Controls.Add(Me.txtScore5_4)
        Me.GroupBox1.Controls.Add(Me.txtScore5_3)
        Me.GroupBox1.Controls.Add(Me.txtScore5_2)
        Me.GroupBox1.Controls.Add(Me.txtScore5_5)
        Me.GroupBox1.Controls.Add(Me.txtScore5_1)
        Me.GroupBox1.Controls.Add(Me.txtScore4_4)
        Me.GroupBox1.Controls.Add(Me.txtScore4_3)
        Me.GroupBox1.Controls.Add(Me.txtScore4_2)
        Me.GroupBox1.Controls.Add(Me.txtScore4_5)
        Me.GroupBox1.Controls.Add(Me.txtScore4_1)
        Me.GroupBox1.Controls.Add(Me.txtScore2_4)
        Me.GroupBox1.Controls.Add(Me.txtScore2_3)
        Me.GroupBox1.Controls.Add(Me.txtScore2_2)
        Me.GroupBox1.Controls.Add(Me.txtScore2_5)
        Me.GroupBox1.Controls.Add(Me.txtScore2_1)
        Me.GroupBox1.Controls.Add(Me.txtScore3_4)
        Me.GroupBox1.Controls.Add(Me.txtScore3_3)
        Me.GroupBox1.Controls.Add(Me.txtScore3_2)
        Me.GroupBox1.Controls.Add(Me.txtScore3_5)
        Me.GroupBox1.Controls.Add(Me.txtScore3_1)
        Me.GroupBox1.Controls.Add(Me.txtScore1_4)
        Me.GroupBox1.Controls.Add(Me.txtScore1_3)
        Me.GroupBox1.Controls.Add(Me.txtScore1_2)
        Me.GroupBox1.Controls.Add(Me.txtScore1_5)
        Me.GroupBox1.Controls.Add(Me.txtScore1_1)
        Me.GroupBox1.Controls.Add(Me.txtNSix)
        Me.GroupBox1.Controls.Add(Me.txtNFive)
        Me.GroupBox1.Controls.Add(Me.txtNFour)
        Me.GroupBox1.Controls.Add(Me.txtNThree)
        Me.GroupBox1.Controls.Add(Me.txtNTwo)
        Me.GroupBox1.Controls.Add(Me.txtNOne)
        Me.GroupBox1.Controls.Add(Me.lblAverage)
        Me.GroupBox1.Controls.Add(Me.lblScores)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Location = New System.Drawing.Point(61, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(664, 324)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Data"
        '
        'lblAverage6
        '
        Me.lblAverage6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverage6.Location = New System.Drawing.Point(561, 264)
        Me.lblAverage6.Name = "lblAverage6"
        Me.lblAverage6.Size = New System.Drawing.Size(79, 22)
        Me.lblAverage6.TabIndex = 44
        '
        'lblAverage5
        '
        Me.lblAverage5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverage5.Location = New System.Drawing.Point(561, 227)
        Me.lblAverage5.Name = "lblAverage5"
        Me.lblAverage5.Size = New System.Drawing.Size(79, 22)
        Me.lblAverage5.TabIndex = 43
        '
        'lblAverage4
        '
        Me.lblAverage4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverage4.Location = New System.Drawing.Point(561, 192)
        Me.lblAverage4.Name = "lblAverage4"
        Me.lblAverage4.Size = New System.Drawing.Size(79, 22)
        Me.lblAverage4.TabIndex = 42
        '
        'lblAverage3
        '
        Me.lblAverage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverage3.Location = New System.Drawing.Point(561, 157)
        Me.lblAverage3.Name = "lblAverage3"
        Me.lblAverage3.Size = New System.Drawing.Size(79, 22)
        Me.lblAverage3.TabIndex = 41
        '
        'lblAverage2
        '
        Me.lblAverage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverage2.Location = New System.Drawing.Point(561, 124)
        Me.lblAverage2.Name = "lblAverage2"
        Me.lblAverage2.Size = New System.Drawing.Size(79, 22)
        Me.lblAverage2.TabIndex = 40
        '
        'lblAverage1
        '
        Me.lblAverage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverage1.Location = New System.Drawing.Point(561, 87)
        Me.lblAverage1.Name = "lblAverage1"
        Me.lblAverage1.Size = New System.Drawing.Size(79, 22)
        Me.lblAverage1.TabIndex = 39
        '
        'txtScore6_4
        '
        Me.txtScore6_4.Location = New System.Drawing.Point(384, 262)
        Me.txtScore6_4.Name = "txtScore6_4"
        Me.txtScore6_4.Size = New System.Drawing.Size(52, 22)
        Me.txtScore6_4.TabIndex = 34
        '
        'txtScore6_3
        '
        Me.txtScore6_3.Location = New System.Drawing.Point(318, 262)
        Me.txtScore6_3.Name = "txtScore6_3"
        Me.txtScore6_3.Size = New System.Drawing.Size(52, 22)
        Me.txtScore6_3.TabIndex = 33
        '
        'txtScore6_2
        '
        Me.txtScore6_2.Location = New System.Drawing.Point(252, 262)
        Me.txtScore6_2.Name = "txtScore6_2"
        Me.txtScore6_2.Size = New System.Drawing.Size(52, 22)
        Me.txtScore6_2.TabIndex = 32
        '
        'txtScore6_5
        '
        Me.txtScore6_5.Location = New System.Drawing.Point(450, 262)
        Me.txtScore6_5.Name = "txtScore6_5"
        Me.txtScore6_5.Size = New System.Drawing.Size(52, 22)
        Me.txtScore6_5.TabIndex = 35
        '
        'txtScore6_1
        '
        Me.txtScore6_1.Location = New System.Drawing.Point(186, 262)
        Me.txtScore6_1.Name = "txtScore6_1"
        Me.txtScore6_1.Size = New System.Drawing.Size(52, 22)
        Me.txtScore6_1.TabIndex = 31
        '
        'txtScore5_4
        '
        Me.txtScore5_4.Location = New System.Drawing.Point(384, 227)
        Me.txtScore5_4.Name = "txtScore5_4"
        Me.txtScore5_4.Size = New System.Drawing.Size(52, 22)
        Me.txtScore5_4.TabIndex = 28
        '
        'txtScore5_3
        '
        Me.txtScore5_3.Location = New System.Drawing.Point(318, 227)
        Me.txtScore5_3.Name = "txtScore5_3"
        Me.txtScore5_3.Size = New System.Drawing.Size(52, 22)
        Me.txtScore5_3.TabIndex = 27
        '
        'txtScore5_2
        '
        Me.txtScore5_2.Location = New System.Drawing.Point(252, 227)
        Me.txtScore5_2.Name = "txtScore5_2"
        Me.txtScore5_2.Size = New System.Drawing.Size(52, 22)
        Me.txtScore5_2.TabIndex = 26
        '
        'txtScore5_5
        '
        Me.txtScore5_5.Location = New System.Drawing.Point(450, 227)
        Me.txtScore5_5.Name = "txtScore5_5"
        Me.txtScore5_5.Size = New System.Drawing.Size(52, 22)
        Me.txtScore5_5.TabIndex = 29
        '
        'txtScore5_1
        '
        Me.txtScore5_1.Location = New System.Drawing.Point(186, 227)
        Me.txtScore5_1.Name = "txtScore5_1"
        Me.txtScore5_1.Size = New System.Drawing.Size(52, 22)
        Me.txtScore5_1.TabIndex = 25
        '
        'txtScore4_4
        '
        Me.txtScore4_4.Location = New System.Drawing.Point(384, 192)
        Me.txtScore4_4.Name = "txtScore4_4"
        Me.txtScore4_4.Size = New System.Drawing.Size(52, 22)
        Me.txtScore4_4.TabIndex = 22
        '
        'txtScore4_3
        '
        Me.txtScore4_3.Location = New System.Drawing.Point(318, 192)
        Me.txtScore4_3.Name = "txtScore4_3"
        Me.txtScore4_3.Size = New System.Drawing.Size(52, 22)
        Me.txtScore4_3.TabIndex = 21
        '
        'txtScore4_2
        '
        Me.txtScore4_2.Location = New System.Drawing.Point(252, 192)
        Me.txtScore4_2.Name = "txtScore4_2"
        Me.txtScore4_2.Size = New System.Drawing.Size(52, 22)
        Me.txtScore4_2.TabIndex = 20
        '
        'txtScore4_5
        '
        Me.txtScore4_5.Location = New System.Drawing.Point(450, 192)
        Me.txtScore4_5.Name = "txtScore4_5"
        Me.txtScore4_5.Size = New System.Drawing.Size(52, 22)
        Me.txtScore4_5.TabIndex = 23
        '
        'txtScore4_1
        '
        Me.txtScore4_1.Location = New System.Drawing.Point(186, 192)
        Me.txtScore4_1.Name = "txtScore4_1"
        Me.txtScore4_1.Size = New System.Drawing.Size(52, 22)
        Me.txtScore4_1.TabIndex = 19
        '
        'txtScore2_4
        '
        Me.txtScore2_4.Location = New System.Drawing.Point(384, 122)
        Me.txtScore2_4.Name = "txtScore2_4"
        Me.txtScore2_4.Size = New System.Drawing.Size(52, 22)
        Me.txtScore2_4.TabIndex = 10
        '
        'txtScore2_3
        '
        Me.txtScore2_3.Location = New System.Drawing.Point(318, 122)
        Me.txtScore2_3.Name = "txtScore2_3"
        Me.txtScore2_3.Size = New System.Drawing.Size(52, 22)
        Me.txtScore2_3.TabIndex = 9
        '
        'txtScore2_2
        '
        Me.txtScore2_2.Location = New System.Drawing.Point(252, 122)
        Me.txtScore2_2.Name = "txtScore2_2"
        Me.txtScore2_2.Size = New System.Drawing.Size(52, 22)
        Me.txtScore2_2.TabIndex = 8
        '
        'txtScore2_5
        '
        Me.txtScore2_5.Location = New System.Drawing.Point(450, 122)
        Me.txtScore2_5.Name = "txtScore2_5"
        Me.txtScore2_5.Size = New System.Drawing.Size(52, 22)
        Me.txtScore2_5.TabIndex = 11
        '
        'txtScore2_1
        '
        Me.txtScore2_1.Location = New System.Drawing.Point(186, 122)
        Me.txtScore2_1.Name = "txtScore2_1"
        Me.txtScore2_1.Size = New System.Drawing.Size(52, 22)
        Me.txtScore2_1.TabIndex = 7
        '
        'txtScore3_4
        '
        Me.txtScore3_4.Location = New System.Drawing.Point(384, 157)
        Me.txtScore3_4.Name = "txtScore3_4"
        Me.txtScore3_4.Size = New System.Drawing.Size(52, 22)
        Me.txtScore3_4.TabIndex = 16
        '
        'txtScore3_3
        '
        Me.txtScore3_3.Location = New System.Drawing.Point(318, 157)
        Me.txtScore3_3.Name = "txtScore3_3"
        Me.txtScore3_3.Size = New System.Drawing.Size(52, 22)
        Me.txtScore3_3.TabIndex = 15
        '
        'txtScore3_2
        '
        Me.txtScore3_2.Location = New System.Drawing.Point(252, 157)
        Me.txtScore3_2.Name = "txtScore3_2"
        Me.txtScore3_2.Size = New System.Drawing.Size(52, 22)
        Me.txtScore3_2.TabIndex = 14
        '
        'txtScore3_5
        '
        Me.txtScore3_5.Location = New System.Drawing.Point(450, 157)
        Me.txtScore3_5.Name = "txtScore3_5"
        Me.txtScore3_5.Size = New System.Drawing.Size(52, 22)
        Me.txtScore3_5.TabIndex = 17
        '
        'txtScore3_1
        '
        Me.txtScore3_1.Location = New System.Drawing.Point(186, 157)
        Me.txtScore3_1.Name = "txtScore3_1"
        Me.txtScore3_1.Size = New System.Drawing.Size(52, 22)
        Me.txtScore3_1.TabIndex = 13
        '
        'txtScore1_4
        '
        Me.txtScore1_4.Location = New System.Drawing.Point(384, 87)
        Me.txtScore1_4.Name = "txtScore1_4"
        Me.txtScore1_4.Size = New System.Drawing.Size(52, 22)
        Me.txtScore1_4.TabIndex = 4
        '
        'txtScore1_3
        '
        Me.txtScore1_3.Location = New System.Drawing.Point(318, 87)
        Me.txtScore1_3.Name = "txtScore1_3"
        Me.txtScore1_3.Size = New System.Drawing.Size(52, 22)
        Me.txtScore1_3.TabIndex = 3
        '
        'txtScore1_2
        '
        Me.txtScore1_2.Location = New System.Drawing.Point(252, 87)
        Me.txtScore1_2.Name = "txtScore1_2"
        Me.txtScore1_2.Size = New System.Drawing.Size(52, 22)
        Me.txtScore1_2.TabIndex = 2
        '
        'txtScore1_5
        '
        Me.txtScore1_5.Location = New System.Drawing.Point(450, 87)
        Me.txtScore1_5.Name = "txtScore1_5"
        Me.txtScore1_5.Size = New System.Drawing.Size(52, 22)
        Me.txtScore1_5.TabIndex = 5
        '
        'txtScore1_1
        '
        Me.txtScore1_1.Location = New System.Drawing.Point(186, 87)
        Me.txtScore1_1.Name = "txtScore1_1"
        Me.txtScore1_1.Size = New System.Drawing.Size(52, 22)
        Me.txtScore1_1.TabIndex = 1
        '
        'txtNSix
        '
        Me.txtNSix.Location = New System.Drawing.Point(12, 262)
        Me.txtNSix.Name = "txtNSix"
        Me.txtNSix.Size = New System.Drawing.Size(151, 22)
        Me.txtNSix.TabIndex = 30
        '
        'txtNFive
        '
        Me.txtNFive.Location = New System.Drawing.Point(12, 227)
        Me.txtNFive.Name = "txtNFive"
        Me.txtNFive.Size = New System.Drawing.Size(151, 22)
        Me.txtNFive.TabIndex = 24
        '
        'txtNFour
        '
        Me.txtNFour.Location = New System.Drawing.Point(12, 192)
        Me.txtNFour.Name = "txtNFour"
        Me.txtNFour.Size = New System.Drawing.Size(151, 22)
        Me.txtNFour.TabIndex = 18
        '
        'txtNThree
        '
        Me.txtNThree.Location = New System.Drawing.Point(12, 157)
        Me.txtNThree.Name = "txtNThree"
        Me.txtNThree.Size = New System.Drawing.Size(151, 22)
        Me.txtNThree.TabIndex = 12
        '
        'txtNTwo
        '
        Me.txtNTwo.Location = New System.Drawing.Point(12, 122)
        Me.txtNTwo.Name = "txtNTwo"
        Me.txtNTwo.Size = New System.Drawing.Size(151, 22)
        Me.txtNTwo.TabIndex = 6
        '
        'txtNOne
        '
        Me.txtNOne.Location = New System.Drawing.Point(12, 87)
        Me.txtNOne.Name = "txtNOne"
        Me.txtNOne.Size = New System.Drawing.Size(151, 22)
        Me.txtNOne.TabIndex = 0
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverage.Location = New System.Drawing.Point(572, 45)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(68, 17)
        Me.lblAverage.TabIndex = 2
        Me.lblAverage.Text = "Average"
        '
        'lblScores
        '
        Me.lblScores.AutoSize = True
        Me.lblScores.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScores.Location = New System.Drawing.Point(293, 45)
        Me.lblScores.Name = "lblScores"
        Me.lblScores.Size = New System.Drawing.Size(95, 17)
        Me.lblScores.TabIndex = 1
        Me.lblScores.Text = "Test Scores"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(40, 45)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(54, 17)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name "
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(487, 390)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(214, 39)
        Me.btnCalc.TabIndex = 1
        Me.btnCalc.Text = "Calculate Averages"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'ofdOpenStudentFile
        '
        Me.ofdOpenStudentFile.FileName = "OpenFileDialog1"
        '
        'pdPrint
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Student Test Scores"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuFileSave As ToolStripMenuItem
    Friend WithEvents mnuFileSaveAs As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuReport As ToolStripMenuItem
    Friend WithEvents mnuReportPrint As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuHelpAbout As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblAverage6 As Label
    Friend WithEvents lblAverage5 As Label
    Friend WithEvents lblAverage4 As Label
    Friend WithEvents lblAverage3 As Label
    Friend WithEvents lblAverage2 As Label
    Friend WithEvents lblAverage1 As Label
    Friend WithEvents txtScore6_4 As TextBox
    Friend WithEvents txtScore6_3 As TextBox
    Friend WithEvents txtScore6_2 As TextBox
    Friend WithEvents txtScore6_5 As TextBox
    Friend WithEvents txtScore6_1 As TextBox
    Friend WithEvents txtScore5_4 As TextBox
    Friend WithEvents txtScore5_3 As TextBox
    Friend WithEvents txtScore5_2 As TextBox
    Friend WithEvents txtScore5_5 As TextBox
    Friend WithEvents txtScore5_1 As TextBox
    Friend WithEvents txtScore4_4 As TextBox
    Friend WithEvents txtScore4_3 As TextBox
    Friend WithEvents txtScore4_2 As TextBox
    Friend WithEvents txtScore4_5 As TextBox
    Friend WithEvents txtScore4_1 As TextBox
    Friend WithEvents txtScore2_4 As TextBox
    Friend WithEvents txtScore2_3 As TextBox
    Friend WithEvents txtScore2_2 As TextBox
    Friend WithEvents txtScore2_5 As TextBox
    Friend WithEvents txtScore2_1 As TextBox
    Friend WithEvents txtScore3_4 As TextBox
    Friend WithEvents txtScore3_3 As TextBox
    Friend WithEvents txtScore3_2 As TextBox
    Friend WithEvents txtScore3_5 As TextBox
    Friend WithEvents txtScore3_1 As TextBox
    Friend WithEvents txtScore1_4 As TextBox
    Friend WithEvents txtScore1_3 As TextBox
    Friend WithEvents txtScore1_2 As TextBox
    Friend WithEvents txtScore1_5 As TextBox
    Friend WithEvents txtScore1_1 As TextBox
    Friend WithEvents txtNSix As TextBox
    Friend WithEvents txtNFive As TextBox
    Friend WithEvents txtNFour As TextBox
    Friend WithEvents txtNThree As TextBox
    Friend WithEvents txtNTwo As TextBox
    Friend WithEvents txtNOne As TextBox
    Friend WithEvents lblAverage As Label
    Friend WithEvents lblScores As Label
    Friend WithEvents lblName As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents ofdOpenStudentFile As OpenFileDialog
    Friend WithEvents sfdSaveStudentFile As SaveFileDialog
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pdPrint As Printing.PrintDocument
End Class
