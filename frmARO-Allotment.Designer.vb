<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmARO_Allotment
    Inherits MaterialSkin.Controls.MaterialForm

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmARO_Allotment))
        Me.ARODGV = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.AccountCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Appropriation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Allotment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNIQUEID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UUID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGVAROFLP = New Bunifu.UI.WinForms.BunifuPanel()
        Me.btnNew = New MaterialSkin.Controls.MaterialButton()
        Me.btnSave = New MaterialSkin.Controls.MaterialButton()
        Me.btnUpdate = New MaterialSkin.Controls.MaterialButton()
        Me.btnDelete = New MaterialSkin.Controls.MaterialButton()
        Me.btnPrint = New MaterialSkin.Controls.MaterialButton()
        Me.txtOffice = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtbxFLP = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtPurpose = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtFundCode = New MaterialSkin.Controls.MaterialComboBox()
        Me.cmbOffice = New MaterialSkin.Controls.MaterialComboBox()
        Me.btnExport = New MaterialSkin.Controls.MaterialButton()
        Me.btnGetData = New MaterialSkin.Controls.MaterialButton()
        Me.btnsFLP = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnImport = New MaterialSkin.Controls.MaterialButton()
        Me.btnOption = New MaterialSkin.Controls.MaterialButton()
        CType(Me.ARODGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DGVAROFLP.SuspendLayout()
        Me.txtbxFLP.SuspendLayout()
        Me.btnsFLP.SuspendLayout()
        Me.SuspendLayout()
        '
        'ARODGV
        '
        Me.ARODGV.AllowCustomTheming = True
        Me.ARODGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.ARODGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ARODGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ARODGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ARODGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ARODGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.ARODGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(95, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ARODGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ARODGV.ColumnHeadersHeight = 40
        Me.ARODGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AccountCode, Me.Description, Me.Appropriation, Me.Allotment, Me.UNIQUEID, Me.UUID})
        Me.ARODGV.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ARODGV.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ARODGV.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White
        Me.ARODGV.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.ARODGV.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.ARODGV.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ARODGV.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ARODGV.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.ARODGV.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.ARODGV.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.ARODGV.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.ARODGV.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.ARODGV.CurrentTheme.Name = Nothing
        Me.ARODGV.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ARODGV.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ARODGV.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.ARODGV.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.ARODGV.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(95, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ARODGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.ARODGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ARODGV.EnableHeadersVisualStyles = False
        Me.ARODGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ARODGV.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.ARODGV.HeaderBgColor = System.Drawing.Color.Empty
        Me.ARODGV.HeaderForeColor = System.Drawing.Color.White
        Me.ARODGV.Location = New System.Drawing.Point(0, 0)
        Me.ARODGV.Name = "ARODGV"
        Me.ARODGV.RowHeadersVisible = False
        Me.ARODGV.RowHeadersWidth = 51
        Me.ARODGV.RowTemplate.Height = 40
        Me.ARODGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ARODGV.Size = New System.Drawing.Size(1153, 651)
        Me.ARODGV.TabIndex = 13
        Me.ARODGV.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark
        '
        'AccountCode
        '
        Me.AccountCode.HeaderText = "Account Code"
        Me.AccountCode.MinimumWidth = 6
        Me.AccountCode.Name = "AccountCode"
        '
        'Description
        '
        Me.Description.HeaderText = "Description"
        Me.Description.MinimumWidth = 6
        Me.Description.Name = "Description"
        '
        'Appropriation
        '
        Me.Appropriation.HeaderText = "Appropriation"
        Me.Appropriation.MinimumWidth = 6
        Me.Appropriation.Name = "Appropriation"
        '
        'Allotment
        '
        Me.Allotment.HeaderText = "Allotment"
        Me.Allotment.MinimumWidth = 6
        Me.Allotment.Name = "Allotment"
        '
        'UNIQUEID
        '
        Me.UNIQUEID.HeaderText = "UID"
        Me.UNIQUEID.MinimumWidth = 6
        Me.UNIQUEID.Name = "UNIQUEID"
        Me.UNIQUEID.ReadOnly = True
        Me.UNIQUEID.Visible = False
        '
        'UUID
        '
        Me.UUID.HeaderText = "UUID"
        Me.UUID.MinimumWidth = 6
        Me.UUID.Name = "UUID"
        Me.UUID.ReadOnly = True
        Me.UUID.Visible = False
        '
        'DGVAROFLP
        '
        Me.DGVAROFLP.BackgroundColor = System.Drawing.Color.Transparent
        Me.DGVAROFLP.BackgroundImage = CType(resources.GetObject("DGVAROFLP.BackgroundImage"), System.Drawing.Image)
        Me.DGVAROFLP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DGVAROFLP.BorderColor = System.Drawing.Color.Transparent
        Me.DGVAROFLP.BorderRadius = 3
        Me.DGVAROFLP.BorderThickness = 1
        Me.DGVAROFLP.Controls.Add(Me.ARODGV)
        Me.DGVAROFLP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVAROFLP.Location = New System.Drawing.Point(0, 124)
        Me.DGVAROFLP.Name = "DGVAROFLP"
        Me.DGVAROFLP.ShowBorders = True
        Me.DGVAROFLP.Size = New System.Drawing.Size(1153, 651)
        Me.DGVAROFLP.TabIndex = 19
        '
        'btnNew
        '
        Me.btnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNew.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnNew.Depth = 0
        Me.btnNew.HighEmphasis = False
        Me.btnNew.Icon = Global.maccosys2022.My.Resources.Resources.icons8_new_copy_96
        Me.btnNew.Location = New System.Drawing.Point(9, 11)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnNew.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnNew.Name = "btnNew"
        Me.btnNew.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnNew.Size = New System.Drawing.Size(81, 36)
        Me.btnNew.TabIndex = 0
        Me.btnNew.Text = "New"
        Me.btnNew.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnNew.UseAccentColor = False
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnSave.Depth = 0
        Me.btnSave.Enabled = False
        Me.btnSave.HighEmphasis = False
        Me.btnSave.Icon = CType(resources.GetObject("btnSave.Icon"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(98, 11)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSave.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSave.Name = "btnSave"
        Me.btnSave.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnSave.Size = New System.Drawing.Size(86, 36)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        Me.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnSave.UseAccentColor = False
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnUpdate.Depth = 0
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.HighEmphasis = False
        Me.btnUpdate.Icon = Global.maccosys2022.My.Resources.Resources.icons8_update_file_96
        Me.btnUpdate.Location = New System.Drawing.Point(192, 11)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnUpdate.Size = New System.Drawing.Size(105, 36)
        Me.btnUpdate.TabIndex = 0
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnUpdate.UseAccentColor = False
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnDelete.Depth = 0
        Me.btnDelete.HighEmphasis = False
        Me.btnDelete.Icon = Global.maccosys2022.My.Resources.Resources.icons8_trash_96
        Me.btnDelete.Location = New System.Drawing.Point(305, 11)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnDelete.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnDelete.Size = New System.Drawing.Size(101, 36)
        Me.btnDelete.TabIndex = 0
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnDelete.UseAccentColor = False
        Me.btnDelete.UseVisualStyleBackColor = True
        Me.btnDelete.Visible = False
        '
        'btnPrint
        '
        Me.btnPrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPrint.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnPrint.Depth = 0
        Me.btnPrint.HighEmphasis = False
        Me.btnPrint.Icon = Global.maccosys2022.My.Resources.Resources.icons8_print_96
        Me.btnPrint.Location = New System.Drawing.Point(414, 11)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnPrint.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnPrint.Size = New System.Drawing.Size(91, 36)
        Me.btnPrint.TabIndex = 0
        Me.btnPrint.Text = "Print"
        Me.btnPrint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnPrint.UseAccentColor = False
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'txtOffice
        '
        Me.txtOffice.AnimateReadOnly = False
        Me.txtOffice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOffice.Depth = 0
        Me.txtOffice.Enabled = False
        Me.txtOffice.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtOffice.Hint = "Office"
        Me.txtOffice.LeadingIcon = Nothing
        Me.txtOffice.Location = New System.Drawing.Point(859, 8)
        Me.txtOffice.MaxLength = 50
        Me.txtOffice.MouseState = MaterialSkin.MouseState.OUT
        Me.txtOffice.Multiline = False
        Me.txtOffice.Name = "txtOffice"
        Me.txtOffice.Size = New System.Drawing.Size(282, 50)
        Me.txtOffice.TabIndex = 13
        Me.txtOffice.Text = ""
        Me.txtOffice.TrailingIcon = Nothing
        '
        'txtbxFLP
        '
        Me.txtbxFLP.Controls.Add(Me.txtPurpose)
        Me.txtbxFLP.Controls.Add(Me.txtFundCode)
        Me.txtbxFLP.Controls.Add(Me.cmbOffice)
        Me.txtbxFLP.Controls.Add(Me.txtOffice)
        Me.txtbxFLP.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtbxFLP.Location = New System.Drawing.Point(0, 52)
        Me.txtbxFLP.Margin = New System.Windows.Forms.Padding(0)
        Me.txtbxFLP.Name = "txtbxFLP"
        Me.txtbxFLP.Padding = New System.Windows.Forms.Padding(5)
        Me.txtbxFLP.Size = New System.Drawing.Size(1153, 72)
        Me.txtbxFLP.TabIndex = 18
        '
        'txtPurpose
        '
        Me.txtPurpose.AnimateReadOnly = False
        Me.txtPurpose.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPurpose.Depth = 0
        Me.txtPurpose.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtPurpose.Hint = "Purpose"
        Me.txtPurpose.LeadingIcon = Nothing
        Me.txtPurpose.Location = New System.Drawing.Point(10, 10)
        Me.txtPurpose.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPurpose.MaxLength = 50
        Me.txtPurpose.MouseState = MaterialSkin.MouseState.OUT
        Me.txtPurpose.Multiline = False
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.Size = New System.Drawing.Size(275, 50)
        Me.txtPurpose.TabIndex = 1
        Me.txtPurpose.Text = ""
        Me.txtPurpose.TrailingIcon = Nothing
        '
        'txtFundCode
        '
        Me.txtFundCode.AutoResize = False
        Me.txtFundCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFundCode.Depth = 0
        Me.txtFundCode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.txtFundCode.DropDownHeight = 174
        Me.txtFundCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtFundCode.DropDownWidth = 121
        Me.txtFundCode.Enabled = False
        Me.txtFundCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.txtFundCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtFundCode.FormattingEnabled = True
        Me.txtFundCode.Hint = "Fund Code"
        Me.txtFundCode.IntegralHeight = False
        Me.txtFundCode.ItemHeight = 43
        Me.txtFundCode.Items.AddRange(New Object() {"05-01", "05-02", "01-07", "05-03"})
        Me.txtFundCode.Location = New System.Drawing.Point(295, 10)
        Me.txtFundCode.Margin = New System.Windows.Forms.Padding(5)
        Me.txtFundCode.MaxDropDownItems = 4
        Me.txtFundCode.MouseState = MaterialSkin.MouseState.OUT
        Me.txtFundCode.Name = "txtFundCode"
        Me.txtFundCode.Size = New System.Drawing.Size(274, 49)
        Me.txtFundCode.StartIndex = 0
        Me.txtFundCode.TabIndex = 12
        '
        'cmbOffice
        '
        Me.cmbOffice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbOffice.AutoResize = False
        Me.cmbOffice.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbOffice.Depth = 0
        Me.cmbOffice.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbOffice.DropDownHeight = 174
        Me.cmbOffice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOffice.DropDownWidth = 121
        Me.cmbOffice.Enabled = False
        Me.cmbOffice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cmbOffice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbOffice.FormattingEnabled = True
        Me.cmbOffice.Hint = "Responsibility Center"
        Me.cmbOffice.IntegralHeight = False
        Me.cmbOffice.ItemHeight = 43
        Me.cmbOffice.Location = New System.Drawing.Point(579, 10)
        Me.cmbOffice.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbOffice.MaxDropDownItems = 4
        Me.cmbOffice.MouseState = MaterialSkin.MouseState.OUT
        Me.cmbOffice.Name = "cmbOffice"
        Me.cmbOffice.Size = New System.Drawing.Size(272, 49)
        Me.cmbOffice.StartIndex = 0
        Me.cmbOffice.TabIndex = 12
        '
        'btnExport
        '
        Me.btnExport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnExport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnExport.Depth = 0
        Me.btnExport.HighEmphasis = False
        Me.btnExport.Icon = Global.maccosys2022.My.Resources.Resources.icons8_microsoft_excel_96
        Me.btnExport.Location = New System.Drawing.Point(513, 11)
        Me.btnExport.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnExport.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnExport.Name = "btnExport"
        Me.btnExport.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnExport.Size = New System.Drawing.Size(105, 36)
        Me.btnExport.TabIndex = 0
        Me.btnExport.Text = "Export"
        Me.btnExport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnExport.UseAccentColor = False
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnGetData
        '
        Me.btnGetData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnGetData.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnGetData.Depth = 0
        Me.btnGetData.HighEmphasis = False
        Me.btnGetData.Icon = Global.maccosys2022.My.Resources.Resources.icons8_search_more_96
        Me.btnGetData.Location = New System.Drawing.Point(626, 11)
        Me.btnGetData.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnGetData.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnGetData.Name = "btnGetData"
        Me.btnGetData.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnGetData.Size = New System.Drawing.Size(77, 36)
        Me.btnGetData.TabIndex = 0
        Me.btnGetData.Text = "Get"
        Me.btnGetData.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnGetData.UseAccentColor = False
        Me.btnGetData.UseVisualStyleBackColor = True
        '
        'btnsFLP
        '
        Me.btnsFLP.Controls.Add(Me.btnNew)
        Me.btnsFLP.Controls.Add(Me.btnSave)
        Me.btnsFLP.Controls.Add(Me.btnUpdate)
        Me.btnsFLP.Controls.Add(Me.btnDelete)
        Me.btnsFLP.Controls.Add(Me.btnPrint)
        Me.btnsFLP.Controls.Add(Me.btnExport)
        Me.btnsFLP.Controls.Add(Me.btnGetData)
        Me.btnsFLP.Controls.Add(Me.btnImport)
        Me.btnsFLP.Controls.Add(Me.btnOption)
        Me.btnsFLP.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnsFLP.Location = New System.Drawing.Point(0, 0)
        Me.btnsFLP.Margin = New System.Windows.Forms.Padding(0)
        Me.btnsFLP.Name = "btnsFLP"
        Me.btnsFLP.Padding = New System.Windows.Forms.Padding(5, 5, 0, 0)
        Me.btnsFLP.Size = New System.Drawing.Size(1153, 52)
        Me.btnsFLP.TabIndex = 17
        '
        'btnImport
        '
        Me.btnImport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnImport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnImport.Depth = 0
        Me.btnImport.HighEmphasis = False
        Me.btnImport.Icon = Global.maccosys2022.My.Resources.Resources.icons8_upload_to_ftp_96
        Me.btnImport.Location = New System.Drawing.Point(711, 11)
        Me.btnImport.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnImport.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnImport.Name = "btnImport"
        Me.btnImport.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnImport.Size = New System.Drawing.Size(104, 36)
        Me.btnImport.TabIndex = 0
        Me.btnImport.Text = "Import"
        Me.btnImport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnImport.UseAccentColor = False
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'btnOption
        '
        Me.btnOption.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOption.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnOption.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnOption.Depth = 0
        Me.btnOption.HighEmphasis = False
        Me.btnOption.Icon = Global.maccosys2022.My.Resources.Resources.icons8_settings_96
        Me.btnOption.Location = New System.Drawing.Point(823, 11)
        Me.btnOption.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnOption.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnOption.Name = "btnOption"
        Me.btnOption.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnOption.Size = New System.Drawing.Size(111, 36)
        Me.btnOption.TabIndex = 2
        Me.btnOption.Text = "Options"
        Me.btnOption.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnOption.UseAccentColor = False
        Me.btnOption.UseVisualStyleBackColor = True
        '
        'frmARO_Allotment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1153, 775)
        Me.Controls.Add(Me.DGVAROFLP)
        Me.Controls.Add(Me.txtbxFLP)
        Me.Controls.Add(Me.btnsFLP)
        Me.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None
        Me.Name = "frmARO_Allotment"
        Me.Padding = New System.Windows.Forms.Padding(0)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "frmARO_Allotment"
        CType(Me.ARODGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DGVAROFLP.ResumeLayout(False)
        Me.txtbxFLP.ResumeLayout(False)
        Me.btnsFLP.ResumeLayout(False)
        Me.btnsFLP.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ARODGV As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents DGVAROFLP As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents btnNew As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnSave As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnUpdate As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnDelete As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnPrint As MaterialSkin.Controls.MaterialButton
    Friend WithEvents txtOffice As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtbxFLP As FlowLayoutPanel
    Friend WithEvents txtPurpose As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtFundCode As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents cmbOffice As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents btnExport As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnGetData As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnsFLP As FlowLayoutPanel
    Friend WithEvents btnImport As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnOption As MaterialSkin.Controls.MaterialButton
    Friend WithEvents AccountCode As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents Appropriation As DataGridViewTextBoxColumn
    Friend WithEvents Allotment As DataGridViewTextBoxColumn
    Friend WithEvents UNIQUEID As DataGridViewTextBoxColumn
    Friend WithEvents UUID As DataGridViewTextBoxColumn
End Class
