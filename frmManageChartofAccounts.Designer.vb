<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmManageChartofAccounts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManageChartofAccounts))
        Me.COADGV = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnSave = New MaterialSkin.Controls.MaterialButton()
        Me.btnExport = New MaterialSkin.Controls.MaterialButton()
        Me.btnImport = New MaterialSkin.Controls.MaterialButton()
        Me.txtSearchCOA = New MaterialSkin.Controls.MaterialTextBox2()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.InsertRowAboveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertRowBelowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.COADGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'COADGV
        '
        Me.COADGV.AllowCustomTheming = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.COADGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.COADGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.COADGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.COADGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.COADGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.COADGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(95, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.COADGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.COADGV.ColumnHeadersHeight = 40
        Me.COADGV.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.COADGV.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.COADGV.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White
        Me.COADGV.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.COADGV.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.COADGV.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.COADGV.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.COADGV.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.COADGV.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.COADGV.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.COADGV.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.COADGV.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.COADGV.CurrentTheme.Name = Nothing
        Me.COADGV.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.COADGV.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.COADGV.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.COADGV.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.COADGV.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(95, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.COADGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.COADGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.COADGV.EnableHeadersVisualStyles = False
        Me.COADGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.COADGV.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.COADGV.HeaderBgColor = System.Drawing.Color.Empty
        Me.COADGV.HeaderForeColor = System.Drawing.Color.White
        Me.COADGV.Location = New System.Drawing.Point(0, 0)
        Me.COADGV.Name = "COADGV"
        Me.COADGV.RowHeadersVisible = False
        Me.COADGV.RowHeadersWidth = 51
        Me.COADGV.RowTemplate.Height = 40
        Me.COADGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.COADGV.Size = New System.Drawing.Size(670, 333)
        Me.COADGV.TabIndex = 14
        Me.COADGV.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.COADGV)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(30, 57)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(670, 333)
        Me.Panel2.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(30, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(670, 57)
        Me.Panel1.TabIndex = 4
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSave)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnExport)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnImport)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtSearchCOA)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(670, 57)
        Me.FlowLayoutPanel1.TabIndex = 4
        '
        'btnSave
        '
        Me.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnSave.Depth = 0
        Me.btnSave.HighEmphasis = False
        Me.btnSave.Icon = CType(resources.GetObject("btnSave.Icon"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(4, 6)
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
        '
        'btnExport
        '
        Me.btnExport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnExport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnExport.Depth = 0
        Me.btnExport.HighEmphasis = False
        Me.btnExport.Icon = Global.maccosys2022.My.Resources.Resources.icons8_microsoft_excel_96
        Me.btnExport.Location = New System.Drawing.Point(98, 6)
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
        'btnImport
        '
        Me.btnImport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnImport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnImport.Depth = 0
        Me.btnImport.HighEmphasis = False
        Me.btnImport.Icon = Global.maccosys2022.My.Resources.Resources.icons8_upload_to_ftp_96
        Me.btnImport.Location = New System.Drawing.Point(211, 6)
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
        'txtSearchCOA
        '
        Me.txtSearchCOA.AnimateReadOnly = False
        Me.txtSearchCOA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtSearchCOA.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtSearchCOA.Depth = 0
        Me.txtSearchCOA.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtSearchCOA.HideSelection = True
        Me.txtSearchCOA.Hint = "Search"
        Me.txtSearchCOA.LeadingIcon = Nothing
        Me.txtSearchCOA.Location = New System.Drawing.Point(322, 3)
        Me.txtSearchCOA.MaxLength = 32767
        Me.txtSearchCOA.MouseState = MaterialSkin.MouseState.OUT
        Me.txtSearchCOA.Name = "txtSearchCOA"
        Me.txtSearchCOA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchCOA.PrefixSuffixText = Nothing
        Me.txtSearchCOA.ReadOnly = False
        Me.txtSearchCOA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSearchCOA.SelectedText = ""
        Me.txtSearchCOA.SelectionLength = 0
        Me.txtSearchCOA.SelectionStart = 0
        Me.txtSearchCOA.ShortcutsEnabled = True
        Me.txtSearchCOA.Size = New System.Drawing.Size(291, 48)
        Me.txtSearchCOA.TabIndex = 3
        Me.txtSearchCOA.TabStop = False
        Me.txtSearchCOA.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtSearchCOA.TrailingIcon = Nothing
        Me.txtSearchCOA.UseSystemPasswordChar = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertRowAboveToolStripMenuItem, Me.InsertRowBelowToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(195, 52)
        '
        'InsertRowAboveToolStripMenuItem
        '
        Me.InsertRowAboveToolStripMenuItem.Name = "InsertRowAboveToolStripMenuItem"
        Me.InsertRowAboveToolStripMenuItem.Size = New System.Drawing.Size(194, 24)
        Me.InsertRowAboveToolStripMenuItem.Text = "Insert Row Above"
        '
        'InsertRowBelowToolStripMenuItem
        '
        Me.InsertRowBelowToolStripMenuItem.Name = "InsertRowBelowToolStripMenuItem"
        Me.InsertRowBelowToolStripMenuItem.Size = New System.Drawing.Size(194, 24)
        Me.InsertRowBelowToolStripMenuItem.Text = "Insert Row Below"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'frmManageChartofAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmManageChartofAccounts"
        Me.Padding = New System.Windows.Forms.Padding(30, 0, 100, 60)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "frmManageChartofAccounts"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.COADGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents COADGV As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnSave As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnExport As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnImport As MaterialSkin.Controls.MaterialButton
    Friend WithEvents txtSearchCOA As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents InsertRowAboveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InsertRowBelowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
End Class
