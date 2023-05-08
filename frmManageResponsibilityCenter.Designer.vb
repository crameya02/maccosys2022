<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageResponsibilityCenter
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManageResponsibilityCenter))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.InsertRowAboveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSave = New MaterialSkin.Controls.MaterialButton()
        Me.btnExport = New MaterialSkin.Controls.MaterialButton()
        Me.RCDGV = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.DGVAROFLP = New Bunifu.UI.WinForms.BunifuPanel()
        Me.btnImport = New MaterialSkin.Controls.MaterialButton()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.InsertRowBelowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnsFLP = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtSearchRC = New MaterialSkin.Controls.MaterialTextBox2()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.RCDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DGVAROFLP.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.btnsFLP.SuspendLayout()
        Me.SuspendLayout()
        '
        'InsertRowAboveToolStripMenuItem
        '
        Me.InsertRowAboveToolStripMenuItem.Name = "InsertRowAboveToolStripMenuItem"
        Me.InsertRowAboveToolStripMenuItem.Size = New System.Drawing.Size(194, 24)
        Me.InsertRowAboveToolStripMenuItem.Text = "Insert Row Above"
        '
        'btnSave
        '
        Me.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnSave.Depth = 0
        Me.btnSave.HighEmphasis = False
        Me.btnSave.Icon = CType(resources.GetObject("btnSave.Icon"), System.Drawing.Image)
        Me.btnSave.Location = New System.Drawing.Point(9, 11)
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
        'btnExport
        '
        Me.btnExport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnExport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnExport.Depth = 0
        Me.btnExport.HighEmphasis = False
        Me.btnExport.Icon = Global.maccosys2022.My.Resources.Resources.icons8_microsoft_excel_96
        Me.btnExport.Location = New System.Drawing.Point(103, 11)
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
        'RCDGV
        '
        Me.RCDGV.AllowCustomTheming = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.RCDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.RCDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.RCDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.RCDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RCDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.RCDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(95, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RCDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.RCDGV.ColumnHeadersHeight = 40
        Me.RCDGV.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.RCDGV.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RCDGV.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White
        Me.RCDGV.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.RCDGV.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.RCDGV.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.RCDGV.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.RCDGV.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.RCDGV.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.RCDGV.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.RCDGV.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.RCDGV.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.RCDGV.CurrentTheme.Name = Nothing
        Me.RCDGV.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.RCDGV.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RCDGV.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.RCDGV.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.RCDGV.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(95, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.RCDGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.RCDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RCDGV.EnableHeadersVisualStyles = False
        Me.RCDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.RCDGV.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.RCDGV.HeaderBgColor = System.Drawing.Color.Empty
        Me.RCDGV.HeaderForeColor = System.Drawing.Color.White
        Me.RCDGV.Location = New System.Drawing.Point(0, 0)
        Me.RCDGV.Margin = New System.Windows.Forms.Padding(30)
        Me.RCDGV.Name = "RCDGV"
        Me.RCDGV.RowHeadersVisible = False
        Me.RCDGV.RowHeadersWidth = 51
        Me.RCDGV.RowTemplate.Height = 40
        Me.RCDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.RCDGV.Size = New System.Drawing.Size(1023, 652)
        Me.RCDGV.TabIndex = 13
        Me.RCDGV.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark
        '
        'DGVAROFLP
        '
        Me.DGVAROFLP.BackgroundColor = System.Drawing.Color.Transparent
        Me.DGVAROFLP.BackgroundImage = CType(resources.GetObject("DGVAROFLP.BackgroundImage"), System.Drawing.Image)
        Me.DGVAROFLP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DGVAROFLP.BorderColor = System.Drawing.Color.Transparent
        Me.DGVAROFLP.BorderRadius = 3
        Me.DGVAROFLP.BorderThickness = 1
        Me.DGVAROFLP.Controls.Add(Me.RCDGV)
        Me.DGVAROFLP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGVAROFLP.Location = New System.Drawing.Point(30, 63)
        Me.DGVAROFLP.Name = "DGVAROFLP"
        Me.DGVAROFLP.ShowBorders = True
        Me.DGVAROFLP.Size = New System.Drawing.Size(1023, 652)
        Me.DGVAROFLP.TabIndex = 19
        '
        'btnImport
        '
        Me.btnImport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnImport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnImport.Depth = 0
        Me.btnImport.HighEmphasis = False
        Me.btnImport.Icon = Global.maccosys2022.My.Resources.Resources.icons8_upload_to_ftp_96
        Me.btnImport.Location = New System.Drawing.Point(216, 11)
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
        Me.btnImport.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertRowAboveToolStripMenuItem, Me.InsertRowBelowToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(195, 52)
        '
        'InsertRowBelowToolStripMenuItem
        '
        Me.InsertRowBelowToolStripMenuItem.Name = "InsertRowBelowToolStripMenuItem"
        Me.InsertRowBelowToolStripMenuItem.Size = New System.Drawing.Size(194, 24)
        Me.InsertRowBelowToolStripMenuItem.Text = "Insert Row Below"
        '
        'btnsFLP
        '
        Me.btnsFLP.Controls.Add(Me.btnSave)
        Me.btnsFLP.Controls.Add(Me.btnExport)
        Me.btnsFLP.Controls.Add(Me.btnImport)
        Me.btnsFLP.Controls.Add(Me.txtSearchRC)
        Me.btnsFLP.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnsFLP.Location = New System.Drawing.Point(30, 0)
        Me.btnsFLP.Margin = New System.Windows.Forms.Padding(0)
        Me.btnsFLP.Name = "btnsFLP"
        Me.btnsFLP.Padding = New System.Windows.Forms.Padding(5, 5, 0, 0)
        Me.btnsFLP.Size = New System.Drawing.Size(1023, 63)
        Me.btnsFLP.TabIndex = 17
        '
        'txtSearchRC
        '
        Me.txtSearchRC.AnimateReadOnly = False
        Me.txtSearchRC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtSearchRC.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtSearchRC.Depth = 0
        Me.txtSearchRC.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtSearchRC.HideSelection = True
        Me.txtSearchRC.Hint = "Search"
        Me.txtSearchRC.LeadingIcon = Nothing
        Me.txtSearchRC.Location = New System.Drawing.Point(327, 8)
        Me.txtSearchRC.MaxLength = 32767
        Me.txtSearchRC.MouseState = MaterialSkin.MouseState.OUT
        Me.txtSearchRC.Name = "txtSearchRC"
        Me.txtSearchRC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchRC.PrefixSuffixText = Nothing
        Me.txtSearchRC.ReadOnly = False
        Me.txtSearchRC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSearchRC.SelectedText = ""
        Me.txtSearchRC.SelectionLength = 0
        Me.txtSearchRC.SelectionStart = 0
        Me.txtSearchRC.ShortcutsEnabled = True
        Me.txtSearchRC.Size = New System.Drawing.Size(291, 48)
        Me.txtSearchRC.TabIndex = 4
        Me.txtSearchRC.TabStop = False
        Me.txtSearchRC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtSearchRC.TrailingIcon = Nothing
        Me.txtSearchRC.UseSystemPasswordChar = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'frmManageResponsibilityCenter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1153, 775)
        Me.Controls.Add(Me.DGVAROFLP)
        Me.Controls.Add(Me.btnsFLP)
        Me.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmManageResponsibilityCenter"
        Me.Padding = New System.Windows.Forms.Padding(30, 0, 100, 60)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "frmManageResponsibilityCenter"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RCDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DGVAROFLP.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.btnsFLP.ResumeLayout(False)
        Me.btnsFLP.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents InsertRowAboveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnSave As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnExport As MaterialSkin.Controls.MaterialButton
    Friend WithEvents RCDGV As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents DGVAROFLP As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents btnImport As MaterialSkin.Controls.MaterialButton
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents btnsFLP As FlowLayoutPanel
    Friend WithEvents InsertRowBelowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtSearchRC As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents Timer1 As Timer
End Class
