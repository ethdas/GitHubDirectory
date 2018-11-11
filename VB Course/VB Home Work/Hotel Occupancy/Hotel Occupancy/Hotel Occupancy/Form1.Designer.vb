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
        Me.FloorOccupancyData = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotalOccupied = New System.Windows.Forms.Label()
        Me.lblOverallOccupancy = New System.Windows.Forms.Label()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FloorOccupancyData
        '
        Me.FloorOccupancyData.FormattingEnabled = True
        Me.FloorOccupancyData.ItemHeight = 16
        Me.FloorOccupancyData.Location = New System.Drawing.Point(75, 44)
        Me.FloorOccupancyData.Name = "FloorOccupancyData"
        Me.FloorOccupancyData.Size = New System.Drawing.Size(557, 212)
        Me.FloorOccupancyData.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(88, 285)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total Rooms Occupied"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(88, 321)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Overall Occupancy Rate"
        '
        'lblTotalOccupied
        '
        Me.lblTotalOccupied.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalOccupied.Location = New System.Drawing.Point(301, 285)
        Me.lblTotalOccupied.Name = "lblTotalOccupied"
        Me.lblTotalOccupied.Size = New System.Drawing.Size(201, 23)
        Me.lblTotalOccupied.TabIndex = 3
        '
        'lblOverallOccupancy
        '
        Me.lblOverallOccupancy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOverallOccupancy.Location = New System.Drawing.Point(301, 321)
        Me.lblOverallOccupancy.Name = "lblOverallOccupancy"
        Me.lblOverallOccupancy.Size = New System.Drawing.Size(201, 23)
        Me.lblOverallOccupancy.TabIndex = 4
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(125, 380)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(104, 52)
        Me.btnReport.TabIndex = 5
        Me.btnReport.Text = "Complete " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(304, 380)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(104, 52)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(483, 380)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(104, 52)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 444)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.lblOverallOccupancy)
        Me.Controls.Add(Me.lblTotalOccupied)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FloorOccupancyData)
        Me.Name = "Form1"
        Me.Text = "Hotel Occupancy"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FloorOccupancyData As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotalOccupied As Label
    Friend WithEvents lblOverallOccupancy As Label
    Friend WithEvents btnReport As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
