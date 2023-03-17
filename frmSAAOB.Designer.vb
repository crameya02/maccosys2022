<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSAAOB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSAAOB))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnNew = New MaterialSkin.Controls.MaterialButton()
        Me.btnSave = New MaterialSkin.Controls.MaterialButton()
        Me.btnUpdate = New MaterialSkin.Controls.MaterialButton()
        Me.btnDelete = New MaterialSkin.Controls.MaterialButton()
        Me.btnPrint = New MaterialSkin.Controls.MaterialButton()
        Me.btnExport = New MaterialSkin.Controls.MaterialButton()
        Me.DGVAROFLP = New Bunifu.UI.WinForms.BunifuPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.MaterialListView1 = New MaterialSkin.Controls.MaterialListView()
        Me.Project = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Account_Code = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Appro = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Allot = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Obli = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Unobli = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.SAAOBDGV501 = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.Program = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Appropriation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Allotment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Obligations = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnobligatedBalance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.SAAOBDGV502 = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.SAAOBDGV107 = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtOffice = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtbxFLP = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtPurpose = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtFundCode = New MaterialSkin.Controls.MaterialComboBox()
        Me.cmbOffice = New MaterialSkin.Controls.MaterialComboBox()
        Me.btnGetData = New MaterialSkin.Controls.MaterialButton()
        Me.btnImport = New MaterialSkin.Controls.MaterialButton()
        Me.btnsFLP = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnOption = New MaterialSkin.Controls.MaterialButton()
        Me.DGVAROFLP.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.SAAOBDGV501, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SAAOBDGV502, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SAAOBDGV107, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.txtbxFLP.SuspendLayout()
        Me.btnsFLP.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btnUpdate.Visible = False
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
        'DGVAROFLP
        '
        Me.DGVAROFLP.BackgroundColor = System.Drawing.Color.Transparent
        Me.DGVAROFLP.BackgroundImage = CType(resources.GetObject("DGVAROFLP.BackgroundImage"), System.Drawing.Image)
        Me.DGVAROFLP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DGVAROFLP.BorderColor = System.Drawing.Color.Transparent
        Me.DGVAROFLP.BorderRadius = 3
        Me.DGVAROFLP.BorderThickness = 1
        Me.DGVAROFLP.Controls.Add(Me.TableLayoutPanel1)
        Me.DGVAROFLP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVAROFLP.Location = New System.Drawing.Point(0, 124)
        Me.DGVAROFLP.Margin = New System.Windows.Forms.Padding(0)
        Me.DGVAROFLP.Name = "DGVAROFLP"
        Me.DGVAROFLP.ShowBorders = True
        Me.DGVAROFLP.Size = New System.Drawing.Size(1153, 651)
        Me.DGVAROFLP.TabIndex = 19
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1153, 651)
        Me.TableLayoutPanel1.TabIndex = 16
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.Controls.Add(Me.MaterialListView1)
        Me.FlowLayoutPanel1.Controls.Add(Me.MaterialLabel2)
        Me.FlowLayoutPanel1.Controls.Add(Me.SAAOBDGV501)
        Me.FlowLayoutPanel1.Controls.Add(Me.MaterialLabel1)
        Me.FlowLayoutPanel1.Controls.Add(Me.SAAOBDGV502)
        Me.FlowLayoutPanel1.Controls.Add(Me.MaterialLabel3)
        Me.FlowLayoutPanel1.Controls.Add(Me.SAAOBDGV107)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1153, 651)
        Me.FlowLayoutPanel1.TabIndex = 14
        Me.FlowLayoutPanel1.WrapContents = False
        '
        'MaterialListView1
        '
        Me.MaterialListView1.AutoSizeTable = False
        Me.MaterialListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MaterialListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Project, Me.Account_Code, Me.Appro, Me.Allot, Me.Obli, Me.Unobli})
        Me.MaterialListView1.Depth = 0
        Me.MaterialListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaterialListView1.FullRowSelect = True
        Me.MaterialListView1.HideSelection = False
        Me.MaterialListView1.Location = New System.Drawing.Point(3, 3)
        Me.MaterialListView1.MinimumSize = New System.Drawing.Size(200, 100)
        Me.MaterialListView1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialListView1.MouseState = MaterialSkin.MouseState.OUT
        Me.MaterialListView1.Name = "MaterialListView1"
        Me.MaterialListView1.OwnerDraw = True
        Me.MaterialListView1.Size = New System.Drawing.Size(1126, 100)
        Me.MaterialListView1.TabIndex = 21
        Me.MaterialListView1.UseCompatibleStateImageBehavior = False
        Me.MaterialListView1.View = System.Windows.Forms.View.Details
        Me.MaterialListView1.Visible = False
        '
        'Project
        '
        Me.Project.Text = "Function/ Program/ Project"
        Me.Project.Width = 230
        '
        'Account_Code
        '
        Me.Account_Code.Text = "Account Code"
        Me.Account_Code.Width = 230
        '
        'Appro
        '
        Me.Appro.Text = "Appropriation"
        Me.Appro.Width = 230
        '
        'Allot
        '
        Me.Allot.Text = "Allotment"
        Me.Allot.Width = 230
        '
        'Obli
        '
        Me.Obli.Text = "Obligation"
        Me.Obli.Width = 150
        '
        'Unobli
        '
        Me.Unobli.Text = "Unobligated Balance"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel2.Location = New System.Drawing.Point(3, 106)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(194, 24)
        Me.MaterialLabel2.TabIndex = 14
        Me.MaterialLabel2.Text = "1. Personnel Services"
        Me.MaterialLabel2.Visible = False
        '
        'SAAOBDGV501
        '
        Me.SAAOBDGV501.AllowCustomTheming = True
        Me.SAAOBDGV501.AllowUserToAddRows = False
        Me.SAAOBDGV501.AllowUserToDeleteRows = False
        Me.SAAOBDGV501.AllowUserToResizeColumns = False
        Me.SAAOBDGV501.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.SAAOBDGV501.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.SAAOBDGV501.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SAAOBDGV501.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.SAAOBDGV501.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SAAOBDGV501.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.SAAOBDGV501.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(95, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SAAOBDGV501.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.SAAOBDGV501.ColumnHeadersHeight = 40
        Me.SAAOBDGV501.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Program, Me.AccountCode, Me.Appropriation, Me.Allotment, Me.Obligations, Me.UnobligatedBalance})
        Me.SAAOBDGV501.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.SAAOBDGV501.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.SAAOBDGV501.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White
        Me.SAAOBDGV501.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.SAAOBDGV501.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.SAAOBDGV501.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.SAAOBDGV501.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.SAAOBDGV501.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.SAAOBDGV501.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.SAAOBDGV501.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.SAAOBDGV501.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.SAAOBDGV501.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.SAAOBDGV501.CurrentTheme.Name = Nothing
        Me.SAAOBDGV501.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.SAAOBDGV501.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.SAAOBDGV501.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.SAAOBDGV501.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.SAAOBDGV501.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(95, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SAAOBDGV501.DefaultCellStyle = DataGridViewCellStyle3
        Me.SAAOBDGV501.EnableHeadersVisualStyles = False
        Me.SAAOBDGV501.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.SAAOBDGV501.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.SAAOBDGV501.HeaderBgColor = System.Drawing.Color.Empty
        Me.SAAOBDGV501.HeaderForeColor = System.Drawing.Color.White
        Me.SAAOBDGV501.Location = New System.Drawing.Point(0, 130)
        Me.SAAOBDGV501.Margin = New System.Windows.Forms.Padding(0)
        Me.SAAOBDGV501.MultiSelect = False
        Me.SAAOBDGV501.Name = "SAAOBDGV501"
        Me.SAAOBDGV501.ReadOnly = True
        Me.SAAOBDGV501.RowHeadersVisible = False
        Me.SAAOBDGV501.RowHeadersWidth = 51
        Me.SAAOBDGV501.RowTemplate.Height = 40
        Me.SAAOBDGV501.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SAAOBDGV501.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SAAOBDGV501.Size = New System.Drawing.Size(1129, 173)
        Me.SAAOBDGV501.TabIndex = 13
        Me.SAAOBDGV501.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark
        Me.SAAOBDGV501.Visible = False
        '
        'Program
        '
        Me.Program.HeaderText = "Function/Program/Project/Activity"
        Me.Program.MinimumWidth = 6
        Me.Program.Name = "Program"
        Me.Program.ReadOnly = True
        '
        'AccountCode
        '
        Me.AccountCode.HeaderText = "Acccount Code"
        Me.AccountCode.MinimumWidth = 6
        Me.AccountCode.Name = "AccountCode"
        Me.AccountCode.ReadOnly = True
        '
        'Appropriation
        '
        Me.Appropriation.HeaderText = "Appropriation"
        Me.Appropriation.MinimumWidth = 6
        Me.Appropriation.Name = "Appropriation"
        Me.Appropriation.ReadOnly = True
        '
        'Allotment
        '
        Me.Allotment.HeaderText = "Allotment"
        Me.Allotment.MinimumWidth = 6
        Me.Allotment.Name = "Allotment"
        Me.Allotment.ReadOnly = True
        Me.Allotment.Visible = False
        '
        'Obligations
        '
        Me.Obligations.HeaderText = "Obligations"
        Me.Obligations.MinimumWidth = 6
        Me.Obligations.Name = "Obligations"
        Me.Obligations.ReadOnly = True
        '
        'UnobligatedBalance
        '
        Me.UnobligatedBalance.HeaderText = "Unobligated Balance"
        Me.UnobligatedBalance.MinimumWidth = 6
        Me.UnobligatedBalance.Name = "UnobligatedBalance"
        Me.UnobligatedBalance.ReadOnly = True
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel1.Location = New System.Drawing.Point(3, 303)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(416, 24)
        Me.MaterialLabel1.TabIndex = 14
        Me.MaterialLabel1.Text = "2. Maintenance and Other Operating Expenses"
        Me.MaterialLabel1.Visible = False
        '
        'SAAOBDGV502
        '
        Me.SAAOBDGV502.AllowCustomTheming = True
        Me.SAAOBDGV502.AllowUserToAddRows = False
        Me.SAAOBDGV502.AllowUserToDeleteRows = False
        Me.SAAOBDGV502.AllowUserToResizeColumns = False
        Me.SAAOBDGV502.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        Me.SAAOBDGV502.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.SAAOBDGV502.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SAAOBDGV502.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.SAAOBDGV502.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SAAOBDGV502.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.SAAOBDGV502.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(95, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SAAOBDGV502.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.SAAOBDGV502.ColumnHeadersHeight = 40
        Me.SAAOBDGV502.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.SAAOBDGV502.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.SAAOBDGV502.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.SAAOBDGV502.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White
        Me.SAAOBDGV502.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.SAAOBDGV502.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.SAAOBDGV502.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.SAAOBDGV502.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.SAAOBDGV502.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.SAAOBDGV502.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.SAAOBDGV502.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.SAAOBDGV502.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.SAAOBDGV502.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.SAAOBDGV502.CurrentTheme.Name = Nothing
        Me.SAAOBDGV502.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.SAAOBDGV502.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.SAAOBDGV502.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.SAAOBDGV502.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.SAAOBDGV502.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(95, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SAAOBDGV502.DefaultCellStyle = DataGridViewCellStyle6
        Me.SAAOBDGV502.EnableHeadersVisualStyles = False
        Me.SAAOBDGV502.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.SAAOBDGV502.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.SAAOBDGV502.HeaderBgColor = System.Drawing.Color.Empty
        Me.SAAOBDGV502.HeaderForeColor = System.Drawing.Color.White
        Me.SAAOBDGV502.Location = New System.Drawing.Point(0, 327)
        Me.SAAOBDGV502.Margin = New System.Windows.Forms.Padding(0)
        Me.SAAOBDGV502.MultiSelect = False
        Me.SAAOBDGV502.Name = "SAAOBDGV502"
        Me.SAAOBDGV502.ReadOnly = True
        Me.SAAOBDGV502.RowHeadersVisible = False
        Me.SAAOBDGV502.RowHeadersWidth = 51
        Me.SAAOBDGV502.RowTemplate.Height = 40
        Me.SAAOBDGV502.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SAAOBDGV502.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SAAOBDGV502.Size = New System.Drawing.Size(1129, 169)
        Me.SAAOBDGV502.TabIndex = 13
        Me.SAAOBDGV502.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark
        Me.SAAOBDGV502.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Function/Program/Project/Activity"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Acccount Code"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Appropriation"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Allotment"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Obligations"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Unobligated Balance"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto Medium", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6
        Me.MaterialLabel3.Location = New System.Drawing.Point(3, 496)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(294, 24)
        Me.MaterialLabel3.TabIndex = 14
        Me.MaterialLabel3.Text = "3. Property, Plant and Equipment"
        Me.MaterialLabel3.Visible = False
        '
        'SAAOBDGV107
        '
        Me.SAAOBDGV107.AllowCustomTheming = True
        Me.SAAOBDGV107.AllowUserToAddRows = False
        Me.SAAOBDGV107.AllowUserToDeleteRows = False
        Me.SAAOBDGV107.AllowUserToResizeColumns = False
        Me.SAAOBDGV107.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        Me.SAAOBDGV107.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.SAAOBDGV107.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SAAOBDGV107.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.SAAOBDGV107.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SAAOBDGV107.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.SAAOBDGV107.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(95, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SAAOBDGV107.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.SAAOBDGV107.ColumnHeadersHeight = 40
        Me.SAAOBDGV107.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.SAAOBDGV107.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.SAAOBDGV107.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.SAAOBDGV107.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White
        Me.SAAOBDGV107.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.SAAOBDGV107.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.SAAOBDGV107.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.SAAOBDGV107.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.SAAOBDGV107.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.SAAOBDGV107.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.SAAOBDGV107.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.SAAOBDGV107.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.SAAOBDGV107.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.SAAOBDGV107.CurrentTheme.Name = Nothing
        Me.SAAOBDGV107.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.SAAOBDGV107.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.SAAOBDGV107.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.SAAOBDGV107.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.SAAOBDGV107.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(95, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SAAOBDGV107.DefaultCellStyle = DataGridViewCellStyle9
        Me.SAAOBDGV107.EnableHeadersVisualStyles = False
        Me.SAAOBDGV107.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.SAAOBDGV107.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.SAAOBDGV107.HeaderBgColor = System.Drawing.Color.Empty
        Me.SAAOBDGV107.HeaderForeColor = System.Drawing.Color.White
        Me.SAAOBDGV107.Location = New System.Drawing.Point(0, 520)
        Me.SAAOBDGV107.Margin = New System.Windows.Forms.Padding(0)
        Me.SAAOBDGV107.MultiSelect = False
        Me.SAAOBDGV107.Name = "SAAOBDGV107"
        Me.SAAOBDGV107.ReadOnly = True
        Me.SAAOBDGV107.RowHeadersVisible = False
        Me.SAAOBDGV107.RowHeadersWidth = 51
        Me.SAAOBDGV107.RowTemplate.Height = 40
        Me.SAAOBDGV107.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SAAOBDGV107.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SAAOBDGV107.Size = New System.Drawing.Size(1129, 173)
        Me.SAAOBDGV107.TabIndex = 13
        Me.SAAOBDGV107.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark
        Me.SAAOBDGV107.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Function/Program/Project/Activity"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Acccount Code"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Appropriation"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Allotment"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Obligations"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "Unobligated Balance"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
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
        Me.txtOffice.Visible = False
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
        Me.txtbxFLP.Visible = False
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
        'txtFundCode
        '
        Me.txtFundCode.AutoResize = False
        Me.txtFundCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFundCode.Depth = 0
        Me.txtFundCode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.txtFundCode.DropDownHeight = 174
        Me.txtFundCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtFundCode.DropDownWidth = 121
        Me.txtFundCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.txtFundCode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtFundCode.FormattingEnabled = True
        Me.txtFundCode.Hint = "Fund Code"
        Me.txtFundCode.IntegralHeight = False
        Me.txtFundCode.ItemHeight = 43
        Me.txtFundCode.Items.AddRange(New Object() {"05-01", "05-02", "01-07"})
        Me.txtFundCode.Location = New System.Drawing.Point(295, 10)
        Me.txtFundCode.Margin = New System.Windows.Forms.Padding(5)
        Me.txtFundCode.MaxDropDownItems = 4
        Me.txtFundCode.MouseState = MaterialSkin.MouseState.OUT
        Me.txtFundCode.Name = "txtFundCode"
        Me.txtFundCode.Size = New System.Drawing.Size(274, 49)
        Me.txtFundCode.StartIndex = 0
        Me.txtFundCode.TabIndex = 12
        Me.txtFundCode.Visible = False
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
        Me.cmbOffice.Visible = False
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
        Me.btnsFLP.Controls.Add(Me.btnOption)
        Me.btnsFLP.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnsFLP.Location = New System.Drawing.Point(0, 0)
        Me.btnsFLP.Margin = New System.Windows.Forms.Padding(0)
        Me.btnsFLP.Name = "btnsFLP"
        Me.btnsFLP.Padding = New System.Windows.Forms.Padding(5, 5, 0, 0)
        Me.btnsFLP.Size = New System.Drawing.Size(1153, 52)
        Me.btnsFLP.TabIndex = 17
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
        Me.btnOption.TabIndex = 1
        Me.btnOption.Text = "Options"
        Me.btnOption.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnOption.UseAccentColor = False
        Me.btnOption.UseVisualStyleBackColor = True
        '
        'frmSAAOB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1153, 775)
        Me.Controls.Add(Me.DGVAROFLP)
        Me.Controls.Add(Me.txtbxFLP)
        Me.Controls.Add(Me.btnsFLP)
        Me.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None
        Me.Name = "frmSAAOB"
        Me.Padding = New System.Windows.Forms.Padding(0)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "frmSAAOB"
        Me.DGVAROFLP.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.SAAOBDGV501, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SAAOBDGV502, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SAAOBDGV107, System.ComponentModel.ISupportInitialize).EndInit()
        Me.txtbxFLP.ResumeLayout(False)
        Me.btnsFLP.ResumeLayout(False)
        Me.btnsFLP.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnNew As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnSave As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnUpdate As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnDelete As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnPrint As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnExport As MaterialSkin.Controls.MaterialButton
    Friend WithEvents DGVAROFLP As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents txtOffice As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtbxFLP As FlowLayoutPanel
    Friend WithEvents txtPurpose As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtFundCode As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents cmbOffice As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents btnGetData As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnImport As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnsFLP As FlowLayoutPanel
    Friend WithEvents btnOption As MaterialSkin.Controls.MaterialButton
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents SAAOBDGV501 As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents Program As DataGridViewTextBoxColumn
    Friend WithEvents AccountCode As DataGridViewTextBoxColumn
    Friend WithEvents Appropriation As DataGridViewTextBoxColumn
    Friend WithEvents Allotment As DataGridViewTextBoxColumn
    Friend WithEvents Obligations As DataGridViewTextBoxColumn
    Friend WithEvents UnobligatedBalance As DataGridViewTextBoxColumn
    Friend WithEvents SAAOBDGV502 As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents SAAOBDGV107 As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialListView1 As MaterialSkin.Controls.MaterialListView
    Friend WithEvents Project As ColumnHeader
    Friend WithEvents Account_Code As ColumnHeader
    Friend WithEvents Appro As ColumnHeader
    Friend WithEvents Obli As ColumnHeader
    Friend WithEvents Unobli As ColumnHeader
    Friend WithEvents Allot As ColumnHeader
End Class
