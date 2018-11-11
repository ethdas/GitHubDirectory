<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainPage
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvRentalPrices = New System.Windows.Forms.DataGridView()
        Me.KayakTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KayaksRentalPricesDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KayaksRentalPricesDataSet = New Kayak_Rental_Prices.KayaksRentalPricesDataSet()
        Me.KayakTypesTableAdapter = New Kayak_Rental_Prices.KayaksRentalPricesDataSetTableAdapters.KayakTypesTableAdapter()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HourlyRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DailyRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeeklyRateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvRentalPrices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KayakTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KayaksRentalPricesDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KayaksRentalPricesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvRentalPrices
        '
        Me.dgvRentalPrices.AllowUserToAddRows = False
        Me.dgvRentalPrices.AllowUserToDeleteRows = False
        Me.dgvRentalPrices.AllowUserToResizeColumns = False
        Me.dgvRentalPrices.AllowUserToResizeRows = False
        Me.dgvRentalPrices.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRentalPrices.AutoGenerateColumns = False
        Me.dgvRentalPrices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRentalPrices.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvRentalPrices.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRentalPrices.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRentalPrices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRentalPrices.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.HourlyRateDataGridViewTextBoxColumn, Me.DailyRateDataGridViewTextBoxColumn, Me.WeeklyRateDataGridViewTextBoxColumn})
        Me.dgvRentalPrices.DataSource = Me.KayakTypesBindingSource
        Me.dgvRentalPrices.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvRentalPrices.Location = New System.Drawing.Point(25, 52)
        Me.dgvRentalPrices.Name = "dgvRentalPrices"
        Me.dgvRentalPrices.ReadOnly = True
        Me.dgvRentalPrices.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonFace
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.Format = "N2"
        DataGridViewCellStyle6.NullValue = Nothing
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRentalPrices.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvRentalPrices.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.dgvRentalPrices.RowTemplate.DefaultCellStyle.Format = "N2"
        Me.dgvRentalPrices.RowTemplate.DefaultCellStyle.NullValue = Nothing
        Me.dgvRentalPrices.RowTemplate.Height = 24
        Me.dgvRentalPrices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvRentalPrices.Size = New System.Drawing.Size(678, 245)
        Me.dgvRentalPrices.TabIndex = 0
        '
        'KayakTypesBindingSource
        '
        Me.KayakTypesBindingSource.DataMember = "KayakTypes"
        Me.KayakTypesBindingSource.DataSource = Me.KayaksRentalPricesDataSetBindingSource
        '
        'KayaksRentalPricesDataSetBindingSource
        '
        Me.KayaksRentalPricesDataSetBindingSource.DataSource = Me.KayaksRentalPricesDataSet
        Me.KayaksRentalPricesDataSetBindingSource.Position = 0
        '
        'KayaksRentalPricesDataSet
        '
        Me.KayaksRentalPricesDataSet.DataSetName = "KayaksRentalPricesDataSet"
        Me.KayaksRentalPricesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KayakTypesTableAdapter
        '
        Me.KayakTypesTableAdapter.ClearBeforeFill = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        Me.NameDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HourlyRateDataGridViewTextBoxColumn
        '
        Me.HourlyRateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.HourlyRateDataGridViewTextBoxColumn.DataPropertyName = "Hourly Rate"
        DataGridViewCellStyle3.Format = "N2"
        Me.HourlyRateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.HourlyRateDataGridViewTextBoxColumn.HeaderText = "Hourly Rate"
        Me.HourlyRateDataGridViewTextBoxColumn.Name = "HourlyRateDataGridViewTextBoxColumn"
        Me.HourlyRateDataGridViewTextBoxColumn.ReadOnly = True
        Me.HourlyRateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DailyRateDataGridViewTextBoxColumn
        '
        Me.DailyRateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DailyRateDataGridViewTextBoxColumn.DataPropertyName = "Daily Rate"
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DailyRateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.DailyRateDataGridViewTextBoxColumn.HeaderText = "Daily Rate"
        Me.DailyRateDataGridViewTextBoxColumn.Name = "DailyRateDataGridViewTextBoxColumn"
        Me.DailyRateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WeeklyRateDataGridViewTextBoxColumn
        '
        Me.WeeklyRateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.WeeklyRateDataGridViewTextBoxColumn.DataPropertyName = "Weekly Rate"
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.WeeklyRateDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.WeeklyRateDataGridViewTextBoxColumn.HeaderText = "Weekly Rate"
        Me.WeeklyRateDataGridViewTextBoxColumn.Name = "WeeklyRateDataGridViewTextBoxColumn"
        Me.WeeklyRateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 309)
        Me.Controls.Add(Me.dgvRentalPrices)
        Me.Name = "MainPage"
        Me.Text = "Kayak Rental Prices "
        CType(Me.dgvRentalPrices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KayakTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KayaksRentalPricesDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KayaksRentalPricesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvRentalPrices As DataGridView
    Friend WithEvents KayaksRentalPricesDataSetBindingSource As BindingSource
    Friend WithEvents KayaksRentalPricesDataSet As KayaksRentalPricesDataSet
    Friend WithEvents KayakTypesBindingSource As BindingSource
    Friend WithEvents KayakTypesTableAdapter As KayaksRentalPricesDataSetTableAdapters.KayakTypesTableAdapter
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HourlyRateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DailyRateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeeklyRateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
