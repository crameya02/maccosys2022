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
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.ARODGV = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.DGVAROFLP = New Bunifu.UI.WinForms.BunifuPanel()
        Me.btnNew = New MaterialSkin.Controls.MaterialButton()
        Me.btnSave = New MaterialSkin.Controls.MaterialButton()
        Me.btnUpdate = New MaterialSkin.Controls.MaterialButton()
        Me.btnDelete = New MaterialSkin.Controls.MaterialButton()
        Me.btnPrint = New MaterialSkin.Controls.MaterialButton()
        Me.txtOffice = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtbxFLP = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtPurpose = New MaterialSkin.Controls.MaterialTextBox()
        Me.cmbPurpose = New MaterialSkin.Controls.MaterialComboBox()
        Me.txtFundCode = New MaterialSkin.Controls.MaterialComboBox()
        Me.cmbOffice = New MaterialSkin.Controls.MaterialComboBox()
        Me.btnExport = New MaterialSkin.Controls.MaterialButton()
        Me.btnGetData = New MaterialSkin.Controls.MaterialButton()
        Me.btnsFLP = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnImport = New MaterialSkin.Controls.MaterialButton()
        Me.btnOption = New MaterialSkin.Controls.MaterialButton()
        Me.BunifuButton1 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.AccountCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Appropriation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Allotment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNIQUEID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UUID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prevAllot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurposeAllot = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.ARODGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AccountCode, Me.Description, Me.Appropriation, Me.Allotment, Me.UNIQUEID, Me.UUID, Me.prevAllot, Me.PurposeAllot})
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
        Me.ARODGV.Size = New System.Drawing.Size(1736, 651)
        Me.ARODGV.TabIndex = 13
        Me.ARODGV.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark
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
        Me.DGVAROFLP.Size = New System.Drawing.Size(1736, 651)
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
        Me.btnPrint.Visible = False
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
        Me.txtOffice.Location = New System.Drawing.Point(983, 8)
        Me.txtOffice.MaxLength = 50
        Me.txtOffice.MouseState = MaterialSkin.MouseState.OUT
        Me.txtOffice.Multiline = False
        Me.txtOffice.Name = "txtOffice"
        Me.txtOffice.Size = New System.Drawing.Size(496, 50)
        Me.txtOffice.TabIndex = 13
        Me.txtOffice.Text = ""
        Me.txtOffice.TrailingIcon = Nothing
        '
        'txtbxFLP
        '
        Me.txtbxFLP.Controls.Add(Me.txtPurpose)
        Me.txtbxFLP.Controls.Add(Me.cmbPurpose)
        Me.txtbxFLP.Controls.Add(Me.txtFundCode)
        Me.txtbxFLP.Controls.Add(Me.cmbOffice)
        Me.txtbxFLP.Controls.Add(Me.txtOffice)
        Me.txtbxFLP.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtbxFLP.Location = New System.Drawing.Point(0, 52)
        Me.txtbxFLP.Margin = New System.Windows.Forms.Padding(0)
        Me.txtbxFLP.Name = "txtbxFLP"
        Me.txtbxFLP.Padding = New System.Windows.Forms.Padding(5)
        Me.txtbxFLP.Size = New System.Drawing.Size(1736, 72)
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
        Me.txtPurpose.Visible = False
        '
        'cmbPurpose
        '
        Me.cmbPurpose.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbPurpose.AutoResize = False
        Me.cmbPurpose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbPurpose.Depth = 0
        Me.cmbPurpose.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbPurpose.DropDownHeight = 174
        Me.cmbPurpose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPurpose.DropDownWidth = 121
        Me.cmbPurpose.Enabled = False
        Me.cmbPurpose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cmbPurpose.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbPurpose.FormattingEnabled = True
        Me.cmbPurpose.Hint = "Purpose"
        Me.cmbPurpose.IntegralHeight = False
        Me.cmbPurpose.ItemHeight = 43
        Me.cmbPurpose.Items.AddRange(New Object() {"", "1st Quarter Release", "2nd Quarter Release", "3rd Quarter Release", "4th Quarter Release"})
        Me.cmbPurpose.Location = New System.Drawing.Point(295, 10)
        Me.cmbPurpose.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbPurpose.MaxDropDownItems = 4
        Me.cmbPurpose.MouseState = MaterialSkin.MouseState.OUT
        Me.cmbPurpose.Name = "cmbPurpose"
        Me.cmbPurpose.Size = New System.Drawing.Size(272, 49)
        Me.cmbPurpose.StartIndex = 0
        Me.cmbPurpose.TabIndex = 14
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
        Me.txtFundCode.Location = New System.Drawing.Point(577, 10)
        Me.txtFundCode.Margin = New System.Windows.Forms.Padding(5)
        Me.txtFundCode.MaxDropDownItems = 4
        Me.txtFundCode.MouseState = MaterialSkin.MouseState.OUT
        Me.txtFundCode.Name = "txtFundCode"
        Me.txtFundCode.Size = New System.Drawing.Size(116, 49)
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
        Me.cmbOffice.Location = New System.Drawing.Point(703, 10)
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
        Me.btnExport.Visible = False
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
        Me.btnsFLP.Controls.Add(Me.BunifuButton1)
        Me.btnsFLP.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnsFLP.Location = New System.Drawing.Point(0, 0)
        Me.btnsFLP.Margin = New System.Windows.Forms.Padding(0)
        Me.btnsFLP.Name = "btnsFLP"
        Me.btnsFLP.Padding = New System.Windows.Forms.Padding(5, 5, 0, 0)
        Me.btnsFLP.Size = New System.Drawing.Size(1736, 52)
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
        Me.btnImport.Size = New System.Drawing.Size(84, 36)
        Me.btnImport.TabIndex = 0
        Me.btnImport.Text = "View"
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
        Me.btnOption.Location = New System.Drawing.Point(803, 11)
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
        'BunifuButton1
        '
        Me.BunifuButton1.AllowAnimations = True
        Me.BunifuButton1.AllowMouseEffects = True
        Me.BunifuButton1.AllowToggling = False
        Me.BunifuButton1.AnimationSpeed = 200
        Me.BunifuButton1.AutoGenerateColors = False
        Me.BunifuButton1.AutoRoundBorders = False
        Me.BunifuButton1.AutoSizeLeftIcon = True
        Me.BunifuButton1.AutoSizeRightIcon = True
        Me.BunifuButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.BunifuButton1.BackgroundImage = CType(resources.GetObject("BunifuButton1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.ButtonText = "BunifuButton1"
        Me.BunifuButton1.ButtonTextMarginLeft = 0
        Me.BunifuButton1.ColorContrastOnClick = 45
        Me.BunifuButton1.ColorContrastOnHover = 45
        Me.BunifuButton1.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.BunifuButton1.CustomizableEdges = BorderEdges1
        Me.BunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton1.DisabledFillColor = System.Drawing.Color.Empty
        Me.BunifuButton1.DisabledForecolor = System.Drawing.Color.Empty
        Me.BunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton1.ForeColor = System.Drawing.Color.White
        Me.BunifuButton1.IconLeft = Nothing
        Me.BunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton1.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton1.IconMarginLeft = 11
        Me.BunifuButton1.IconPadding = 10
        Me.BunifuButton1.IconRight = Nothing
        Me.BunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton1.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton1.IconSize = 25
        Me.BunifuButton1.IdleBorderColor = System.Drawing.Color.Empty
        Me.BunifuButton1.IdleBorderRadius = 0
        Me.BunifuButton1.IdleBorderThickness = 0
        Me.BunifuButton1.IdleFillColor = System.Drawing.Color.Empty
        Me.BunifuButton1.IdleIconLeftImage = Nothing
        Me.BunifuButton1.IdleIconRightImage = Nothing
        Me.BunifuButton1.IndicateFocus = False
        Me.BunifuButton1.Location = New System.Drawing.Point(921, 8)
        Me.BunifuButton1.Name = "BunifuButton1"
        Me.BunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton1.OnDisabledState.BorderRadius = 1
        Me.BunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.OnDisabledState.BorderThickness = 1
        Me.BunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton1.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton1.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton1.onHoverState.BorderRadius = 1
        Me.BunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.onHoverState.BorderThickness = 1
        Me.BunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton1.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton1.onHoverState.IconRightImage = Nothing
        Me.BunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton1.OnIdleState.BorderRadius = 1
        Me.BunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.OnIdleState.BorderThickness = 1
        Me.BunifuButton1.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton1.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton1.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuButton1.OnPressedState.BorderRadius = 1
        Me.BunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.OnPressedState.BorderThickness = 1
        Me.BunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.BunifuButton1.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton1.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton1.Size = New System.Drawing.Size(150, 39)
        Me.BunifuButton1.TabIndex = 3
        Me.BunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton1.TextMarginLeft = 0
        Me.BunifuButton1.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton1.UseDefaultRadiusAndThickness = True
        Me.BunifuButton1.Visible = False
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
        'prevAllot
        '
        Me.prevAllot.HeaderText = "Previous Allotments"
        Me.prevAllot.MinimumWidth = 6
        Me.prevAllot.Name = "prevAllot"
        Me.prevAllot.ReadOnly = True
        '
        'PurposeAllot
        '
        Me.PurposeAllot.HeaderText = "Purpose"
        Me.PurposeAllot.MinimumWidth = 6
        Me.PurposeAllot.Name = "PurposeAllot"
        Me.PurposeAllot.Visible = False
        '
        'frmARO_Allotment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1736, 775)
        Me.Controls.Add(Me.DGVAROFLP)
        Me.Controls.Add(Me.txtbxFLP)
        Me.Controls.Add(Me.btnsFLP)
        Me.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
    Friend WithEvents cmbPurpose As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents BunifuButton1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents AccountCode As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents Appropriation As DataGridViewTextBoxColumn
    Friend WithEvents Allotment As DataGridViewTextBoxColumn
    Friend WithEvents UNIQUEID As DataGridViewTextBoxColumn
    Friend WithEvents UUID As DataGridViewTextBoxColumn
    Friend WithEvents prevAllot As DataGridViewTextBoxColumn
    Friend WithEvents PurposeAllot As DataGridViewTextBoxColumn
End Class
