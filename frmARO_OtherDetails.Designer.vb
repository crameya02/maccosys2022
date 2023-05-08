<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmARO_OtherDetails
    Inherits MaterialSkin.Controls.MaterialForm

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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmARO_OtherDetails))
        Me.ARODGV = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BunifuCircleProgress1 = New Bunifu.UI.WinForms.BunifuCircleProgress()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtSearchARO = New MaterialSkin.Controls.MaterialTextBox2()
        Me.btnNew = New MaterialSkin.Controls.MaterialButton()
        Me.btnSave = New MaterialSkin.Controls.MaterialButton()
        Me.btnUpdate = New MaterialSkin.Controls.MaterialButton()
        Me.btnDelete = New MaterialSkin.Controls.MaterialButton()
        Me.btnPrint = New MaterialSkin.Controls.MaterialButton()
        Me.btnExport = New MaterialSkin.Controls.MaterialButton()
        Me.btnGetData = New MaterialSkin.Controls.MaterialButton()
        Me.btnImport = New MaterialSkin.Controls.MaterialButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.ARODGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ARODGV
        '
        Me.ARODGV.AllowCustomTheming = False
        Me.ARODGV.AllowUserToAddRows = False
        Me.ARODGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.ARODGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ARODGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ARODGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ARODGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.ARODGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ARODGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ARODGV.ColumnHeadersHeight = 40
        Me.ARODGV.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ARODGV.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ARODGV.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.ARODGV.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ARODGV.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.ARODGV.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.ARODGV.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ARODGV.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.ARODGV.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.ARODGV.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.ARODGV.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ARODGV.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.ARODGV.CurrentTheme.Name = Nothing
        Me.ARODGV.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.ARODGV.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ARODGV.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.ARODGV.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ARODGV.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ARODGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.ARODGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ARODGV.EnableHeadersVisualStyles = False
        Me.ARODGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ARODGV.HeaderBackColor = System.Drawing.Color.DodgerBlue
        Me.ARODGV.HeaderBgColor = System.Drawing.Color.Empty
        Me.ARODGV.HeaderForeColor = System.Drawing.Color.White
        Me.ARODGV.Location = New System.Drawing.Point(0, 0)
        Me.ARODGV.Name = "ARODGV"
        Me.ARODGV.ReadOnly = True
        Me.ARODGV.RowHeadersVisible = False
        Me.ARODGV.RowHeadersWidth = 51
        Me.ARODGV.RowTemplate.Height = 40
        Me.ARODGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ARODGV.Size = New System.Drawing.Size(794, 385)
        Me.ARODGV.TabIndex = 0
        Me.ARODGV.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BunifuCircleProgress1)
        Me.Panel2.Controls.Add(Me.ARODGV)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 62)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(794, 385)
        Me.Panel2.TabIndex = 5
        '
        'BunifuCircleProgress1
        '
        Me.BunifuCircleProgress1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.BunifuCircleProgress1.Animated = True
        Me.BunifuCircleProgress1.AnimationInterval = 1
        Me.BunifuCircleProgress1.AnimationSpeed = 1
        Me.BunifuCircleProgress1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCircleProgress1.CircleMargin = 10
        Me.BunifuCircleProgress1.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCircleProgress1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuCircleProgress1.IsPercentage = True
        Me.BunifuCircleProgress1.LineProgressThickness = 10
        Me.BunifuCircleProgress1.LineThickness = 10
        Me.BunifuCircleProgress1.Location = New System.Drawing.Point(314, 103)
        Me.BunifuCircleProgress1.Name = "BunifuCircleProgress1"
        Me.BunifuCircleProgress1.ProgressAnimationSpeed = 200
        Me.BunifuCircleProgress1.ProgressBackColor = System.Drawing.Color.Gainsboro
        Me.BunifuCircleProgress1.ProgressColor = System.Drawing.Color.DodgerBlue
        Me.BunifuCircleProgress1.ProgressColor2 = System.Drawing.Color.DodgerBlue
        Me.BunifuCircleProgress1.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round
        Me.BunifuCircleProgress1.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid
        Me.BunifuCircleProgress1.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round
        Me.BunifuCircleProgress1.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.BunifuCircleProgress1.Size = New System.Drawing.Size(162, 162)
        Me.BunifuCircleProgress1.SubScriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.BunifuCircleProgress1.SubScriptMargin = New System.Windows.Forms.Padding(5, -20, 0, 0)
        Me.BunifuCircleProgress1.SubScriptText = ".00"
        Me.BunifuCircleProgress1.SuperScriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.BunifuCircleProgress1.SuperScriptMargin = New System.Windows.Forms.Padding(5, 50, 0, 0)
        Me.BunifuCircleProgress1.SuperScriptText = "%"
        Me.BunifuCircleProgress1.TabIndex = 17
        Me.BunifuCircleProgress1.Text = "30"
        Me.BunifuCircleProgress1.TextMargin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.BunifuCircleProgress1.Value = 30
        Me.BunifuCircleProgress1.ValueByTransition = 30
        Me.BunifuCircleProgress1.ValueMargin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.BunifuCircleProgress1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(794, 62)
        Me.Panel1.TabIndex = 4
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.txtSearchARO)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnNew)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSave)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnUpdate)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnDelete)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnPrint)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnExport)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnGetData)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnImport)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 64, 3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(794, 62)
        Me.FlowLayoutPanel1.TabIndex = 5
        '
        'txtSearchARO
        '
        Me.txtSearchARO.AnimateReadOnly = False
        Me.txtSearchARO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtSearchARO.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtSearchARO.Depth = 0
        Me.txtSearchARO.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtSearchARO.HideSelection = True
        Me.txtSearchARO.Hint = "Search"
        Me.txtSearchARO.LeadingIcon = Nothing
        Me.txtSearchARO.Location = New System.Drawing.Point(3, 6)
        Me.txtSearchARO.MaxLength = 32767
        Me.txtSearchARO.MouseState = MaterialSkin.MouseState.OUT
        Me.txtSearchARO.Name = "txtSearchARO"
        Me.txtSearchARO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchARO.PrefixSuffixText = Nothing
        Me.txtSearchARO.ReadOnly = False
        Me.txtSearchARO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSearchARO.SelectedText = ""
        Me.txtSearchARO.SelectionLength = 0
        Me.txtSearchARO.SelectionStart = 0
        Me.txtSearchARO.ShortcutsEnabled = True
        Me.txtSearchARO.Size = New System.Drawing.Size(291, 48)
        Me.txtSearchARO.TabIndex = 3
        Me.txtSearchARO.TabStop = False
        Me.txtSearchARO.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtSearchARO.TrailingIcon = Nothing
        Me.txtSearchARO.UseSystemPasswordChar = False
        '
        'btnNew
        '
        Me.btnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNew.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnNew.Depth = 0
        Me.btnNew.HighEmphasis = False
        Me.btnNew.Icon = Global.maccosys2022.My.Resources.Resources.icons8_new_copy_96
        Me.btnNew.Location = New System.Drawing.Point(301, 9)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnNew.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnNew.Name = "btnNew"
        Me.btnNew.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnNew.Size = New System.Drawing.Size(81, 36)
        Me.btnNew.TabIndex = 4
        Me.btnNew.Text = "New"
        Me.btnNew.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnNew.UseAccentColor = False
        Me.btnNew.UseVisualStyleBackColor = True
        Me.btnNew.Visible = False
        '
        'btnSave
        '
        Me.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnSave.Depth = 0
        Me.btnSave.HighEmphasis = False
        Me.btnSave.Icon = CType(resources.GetObject("btnSave.Icon"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(390, 9)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSave.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSave.Name = "btnSave"
        Me.btnSave.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnSave.Size = New System.Drawing.Size(86, 36)
        Me.btnSave.TabIndex = 5
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
        Me.btnUpdate.Location = New System.Drawing.Point(484, 9)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnUpdate.Size = New System.Drawing.Size(105, 36)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnUpdate.UseAccentColor = False
        Me.btnUpdate.UseVisualStyleBackColor = True
        Me.btnUpdate.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnDelete.Depth = 0
        Me.btnDelete.HighEmphasis = False
        Me.btnDelete.Icon = Global.maccosys2022.My.Resources.Resources.icons8_trash_96
        Me.btnDelete.Location = New System.Drawing.Point(597, 9)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnDelete.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnDelete.Size = New System.Drawing.Size(101, 36)
        Me.btnDelete.TabIndex = 7
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
        Me.btnPrint.Location = New System.Drawing.Point(706, 9)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnPrint.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnPrint.Size = New System.Drawing.Size(91, 36)
        Me.btnPrint.TabIndex = 8
        Me.btnPrint.Text = "Print"
        Me.btnPrint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnPrint.UseAccentColor = False
        Me.btnPrint.UseVisualStyleBackColor = True
        Me.btnPrint.Visible = False
        '
        'btnExport
        '
        Me.btnExport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnExport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnExport.Depth = 0
        Me.btnExport.HighEmphasis = False
        Me.btnExport.Icon = Global.maccosys2022.My.Resources.Resources.icons8_microsoft_excel_96
        Me.btnExport.Location = New System.Drawing.Point(805, 9)
        Me.btnExport.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnExport.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnExport.Name = "btnExport"
        Me.btnExport.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnExport.Size = New System.Drawing.Size(105, 36)
        Me.btnExport.TabIndex = 9
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
        Me.btnGetData.Location = New System.Drawing.Point(918, 9)
        Me.btnGetData.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnGetData.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnGetData.Name = "btnGetData"
        Me.btnGetData.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnGetData.Size = New System.Drawing.Size(77, 36)
        Me.btnGetData.TabIndex = 10
        Me.btnGetData.Text = "Get"
        Me.btnGetData.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnGetData.UseAccentColor = False
        Me.btnGetData.UseVisualStyleBackColor = True
        Me.btnGetData.Visible = False
        '
        'btnImport
        '
        Me.btnImport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnImport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnImport.Depth = 0
        Me.btnImport.HighEmphasis = False
        Me.btnImport.Icon = Global.maccosys2022.My.Resources.Resources.icons8_upload_to_ftp_96
        Me.btnImport.Location = New System.Drawing.Point(1003, 9)
        Me.btnImport.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnImport.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnImport.Name = "btnImport"
        Me.btnImport.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnImport.Size = New System.Drawing.Size(104, 36)
        Me.btnImport.TabIndex = 11
        Me.btnImport.Text = "Import"
        Me.btnImport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnImport.UseAccentColor = False
        Me.btnImport.UseVisualStyleBackColor = True
        Me.btnImport.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BackgroundWorker1
        '
        '
        'frmARO_OtherDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmARO_OtherDetails"
        Me.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Appropriations"
        CType(Me.ARODGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ARODGV As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents txtSearchARO As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents btnNew As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnSave As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnUpdate As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnDelete As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnPrint As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnExport As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnGetData As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnImport As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Timer2 As Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BunifuCircleProgress1 As Bunifu.UI.WinForms.BunifuCircleProgress
End Class
