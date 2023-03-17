<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOBRE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOBRE))
        Me.OBREDGV = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.DGVAROFLP = New Bunifu.UI.WinForms.BunifuPanel()
        Me.btnNew = New MaterialSkin.Controls.MaterialButton()
        Me.btnSave = New MaterialSkin.Controls.MaterialButton()
        Me.btnUpdate = New MaterialSkin.Controls.MaterialButton()
        Me.btnDelete = New MaterialSkin.Controls.MaterialButton()
        Me.btnPrint = New MaterialSkin.Controls.MaterialButton()
        Me.txtOBREmacco_ID = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtbxFLP = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtPayee = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtDate = New MaterialSkin.Controls.MaterialTextBox()
        Me.dtpDate = New MaterialSkin.Controls.MaterialComboBox()
        Me.btnExport = New MaterialSkin.Controls.MaterialButton()
        Me.btnGetData = New MaterialSkin.Controls.MaterialButton()
        Me.btnImport = New MaterialSkin.Controls.MaterialButton()
        Me.btnsFLP = New System.Windows.Forms.FlowLayoutPanel()
        Me.ResponsibilityCenter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Particulars = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNIQUEID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.OBREDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DGVAROFLP.SuspendLayout()
        Me.txtbxFLP.SuspendLayout()
        Me.btnsFLP.SuspendLayout()
        Me.SuspendLayout()
        '
        'OBREDGV
        '
        Me.OBREDGV.AllowCustomTheming = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.OBREDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.OBREDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.OBREDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.OBREDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OBREDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.OBREDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(95, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.OBREDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.OBREDGV.ColumnHeadersHeight = 40
        Me.OBREDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ResponsibilityCenter, Me.Particulars, Me.AccountCode, Me.Amount, Me.UNIQUEID})
        Me.OBREDGV.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.OBREDGV.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.OBREDGV.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White
        Me.OBREDGV.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.OBREDGV.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.OBREDGV.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.OBREDGV.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.OBREDGV.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.OBREDGV.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.OBREDGV.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.OBREDGV.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.OBREDGV.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.OBREDGV.CurrentTheme.Name = Nothing
        Me.OBREDGV.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.OBREDGV.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.OBREDGV.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.OBREDGV.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.OBREDGV.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(95, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.OBREDGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.OBREDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OBREDGV.EnableHeadersVisualStyles = False
        Me.OBREDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.OBREDGV.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.OBREDGV.HeaderBgColor = System.Drawing.Color.Empty
        Me.OBREDGV.HeaderForeColor = System.Drawing.Color.White
        Me.OBREDGV.Location = New System.Drawing.Point(0, 0)
        Me.OBREDGV.Name = "OBREDGV"
        Me.OBREDGV.RowHeadersVisible = False
        Me.OBREDGV.RowHeadersWidth = 51
        Me.OBREDGV.RowTemplate.Height = 40
        Me.OBREDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.OBREDGV.Size = New System.Drawing.Size(1153, 651)
        Me.OBREDGV.TabIndex = 13
        Me.OBREDGV.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark
        '
        'DGVAROFLP
        '
        Me.DGVAROFLP.BackgroundColor = System.Drawing.Color.Transparent
        Me.DGVAROFLP.BackgroundImage = CType(resources.GetObject("DGVAROFLP.BackgroundImage"), System.Drawing.Image)
        Me.DGVAROFLP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DGVAROFLP.BorderColor = System.Drawing.Color.Transparent
        Me.DGVAROFLP.BorderRadius = 3
        Me.DGVAROFLP.BorderThickness = 1
        Me.DGVAROFLP.Controls.Add(Me.OBREDGV)
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
        Me.btnSave.Visible = False
        '
        'btnUpdate
        '
        Me.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnUpdate.Depth = 0
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
        'txtOBREmacco_ID
        '
        Me.txtOBREmacco_ID.AnimateReadOnly = False
        Me.txtOBREmacco_ID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOBREmacco_ID.Depth = 0
        Me.txtOBREmacco_ID.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtOBREmacco_ID.Hint = "OBRE Number"
        Me.txtOBREmacco_ID.LeadingIcon = Nothing
        Me.txtOBREmacco_ID.Location = New System.Drawing.Point(293, 8)
        Me.txtOBREmacco_ID.MaxLength = 50
        Me.txtOBREmacco_ID.MouseState = MaterialSkin.MouseState.OUT
        Me.txtOBREmacco_ID.Multiline = False
        Me.txtOBREmacco_ID.Name = "txtOBREmacco_ID"
        Me.txtOBREmacco_ID.Size = New System.Drawing.Size(282, 50)
        Me.txtOBREmacco_ID.TabIndex = 13
        Me.txtOBREmacco_ID.Text = ""
        Me.txtOBREmacco_ID.TrailingIcon = Nothing
        '
        'txtbxFLP
        '
        Me.txtbxFLP.Controls.Add(Me.txtPayee)
        Me.txtbxFLP.Controls.Add(Me.txtOBREmacco_ID)
        Me.txtbxFLP.Controls.Add(Me.txtDate)
        Me.txtbxFLP.Controls.Add(Me.dtpDate)
        Me.txtbxFLP.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtbxFLP.Location = New System.Drawing.Point(0, 52)
        Me.txtbxFLP.Margin = New System.Windows.Forms.Padding(0)
        Me.txtbxFLP.Name = "txtbxFLP"
        Me.txtbxFLP.Padding = New System.Windows.Forms.Padding(5)
        Me.txtbxFLP.Size = New System.Drawing.Size(1153, 72)
        Me.txtbxFLP.TabIndex = 18
        '
        'txtPayee
        '
        Me.txtPayee.AnimateReadOnly = False
        Me.txtPayee.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPayee.Depth = 0
        Me.txtPayee.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtPayee.Hint = "Payee"
        Me.txtPayee.LeadingIcon = Nothing
        Me.txtPayee.Location = New System.Drawing.Point(10, 10)
        Me.txtPayee.Margin = New System.Windows.Forms.Padding(5)
        Me.txtPayee.MaxLength = 250
        Me.txtPayee.MouseState = MaterialSkin.MouseState.OUT
        Me.txtPayee.Multiline = False
        Me.txtPayee.Name = "txtPayee"
        Me.txtPayee.Size = New System.Drawing.Size(275, 50)
        Me.txtPayee.TabIndex = 1
        Me.txtPayee.Text = ""
        Me.txtPayee.TrailingIcon = Nothing
        '
        'txtDate
        '
        Me.txtDate.AnimateReadOnly = False
        Me.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDate.Depth = 0
        Me.txtDate.Enabled = False
        Me.txtDate.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtDate.Hint = "Date"
        Me.txtDate.LeadingIcon = Nothing
        Me.txtDate.Location = New System.Drawing.Point(581, 8)
        Me.txtDate.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.txtDate.MaxLength = 50
        Me.txtDate.MouseState = MaterialSkin.MouseState.OUT
        Me.txtDate.Multiline = False
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(282, 50)
        Me.txtDate.TabIndex = 14
        Me.txtDate.Text = ""
        Me.txtDate.TrailingIcon = Nothing
        '
        'dtpDate
        '
        Me.dtpDate.AutoResize = False
        Me.dtpDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpDate.Depth = 0
        Me.dtpDate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.dtpDate.DropDownHeight = 45
        Me.dtpDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dtpDate.DropDownWidth = 121
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.dtpDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dtpDate.FormattingEnabled = True
        Me.dtpDate.IntegralHeight = False
        Me.dtpDate.ItemHeight = 43
        Me.dtpDate.Location = New System.Drawing.Point(863, 8)
        Me.dtpDate.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.dtpDate.MaxDropDownItems = 1
        Me.dtpDate.MouseState = MaterialSkin.MouseState.OUT
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(36, 49)
        Me.dtpDate.StartIndex = 0
        Me.dtpDate.TabIndex = 16
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
        Me.btnsFLP.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnsFLP.Location = New System.Drawing.Point(0, 0)
        Me.btnsFLP.Margin = New System.Windows.Forms.Padding(0)
        Me.btnsFLP.Name = "btnsFLP"
        Me.btnsFLP.Padding = New System.Windows.Forms.Padding(5, 5, 0, 0)
        Me.btnsFLP.Size = New System.Drawing.Size(1153, 52)
        Me.btnsFLP.TabIndex = 17
        '
        'ResponsibilityCenter
        '
        Me.ResponsibilityCenter.HeaderText = "Responsibility Center"
        Me.ResponsibilityCenter.MinimumWidth = 6
        Me.ResponsibilityCenter.Name = "ResponsibilityCenter"
        '
        'Particulars
        '
        Me.Particulars.HeaderText = "Particulars"
        Me.Particulars.MinimumWidth = 6
        Me.Particulars.Name = "Particulars"
        '
        'AccountCode
        '
        Me.AccountCode.HeaderText = "Account Code"
        Me.AccountCode.MinimumWidth = 6
        Me.AccountCode.Name = "AccountCode"
        '
        'Amount
        '
        Me.Amount.HeaderText = "Amount"
        Me.Amount.MinimumWidth = 6
        Me.Amount.Name = "Amount"
        '
        'UNIQUEID
        '
        Me.UNIQUEID.HeaderText = "UID"
        Me.UNIQUEID.MinimumWidth = 6
        Me.UNIQUEID.Name = "UNIQUEID"
        '
        'frmOBRE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1153, 775)
        Me.Controls.Add(Me.DGVAROFLP)
        Me.Controls.Add(Me.txtbxFLP)
        Me.Controls.Add(Me.btnsFLP)
        Me.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None
        Me.Name = "frmOBRE"
        Me.Padding = New System.Windows.Forms.Padding(0)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "frmOBRE"
        CType(Me.OBREDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DGVAROFLP.ResumeLayout(False)
        Me.txtbxFLP.ResumeLayout(False)
        Me.btnsFLP.ResumeLayout(False)
        Me.btnsFLP.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OBREDGV As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents DGVAROFLP As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents btnNew As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnSave As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnUpdate As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnDelete As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnPrint As MaterialSkin.Controls.MaterialButton
    Friend WithEvents txtOBREmacco_ID As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtbxFLP As FlowLayoutPanel
    Friend WithEvents txtPayee As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents btnExport As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnGetData As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnImport As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnsFLP As FlowLayoutPanel
    Friend WithEvents txtDate As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents dtpDate As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents ResponsibilityCenter As DataGridViewTextBoxColumn
    Friend WithEvents Particulars As DataGridViewTextBoxColumn
    Friend WithEvents AccountCode As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents UNIQUEID As DataGridViewTextBoxColumn
End Class
