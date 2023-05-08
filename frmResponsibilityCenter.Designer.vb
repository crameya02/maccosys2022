<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResponsibilityCenter
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResponsibilityCenter))
        Me.RCDGV = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnNew = New MaterialSkin.Controls.MaterialButton()
        Me.btnSave = New MaterialSkin.Controls.MaterialButton()
        Me.btnUpdate = New MaterialSkin.Controls.MaterialButton()
        Me.btnImport = New MaterialSkin.Controls.MaterialButton()
        Me.btnDelete = New MaterialSkin.Controls.MaterialButton()
        Me.btnGetData = New MaterialSkin.Controls.MaterialButton()
        Me.btnPrint = New MaterialSkin.Controls.MaterialButton()
        Me.btnExport = New MaterialSkin.Controls.MaterialButton()
        Me.txtSearchRC = New MaterialSkin.Controls.MaterialTextBox2()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.RCDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RCDGV
        '
        Me.RCDGV.AllowCustomTheming = False
        Me.RCDGV.AllowUserToAddRows = False
        Me.RCDGV.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.RCDGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.RCDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.RCDGV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RCDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.RCDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RCDGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.RCDGV.ColumnHeadersHeight = 40
        Me.RCDGV.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RCDGV.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RCDGV.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.RCDGV.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RCDGV.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.RCDGV.CurrentTheme.BackColor = System.Drawing.Color.White
        Me.RCDGV.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RCDGV.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue
        Me.RCDGV.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.RCDGV.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.RCDGV.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.RCDGV.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.RCDGV.CurrentTheme.Name = Nothing
        Me.RCDGV.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White
        Me.RCDGV.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RCDGV.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.RCDGV.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RCDGV.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.RCDGV.DefaultCellStyle = DataGridViewCellStyle3
        Me.RCDGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RCDGV.EnableHeadersVisualStyles = False
        Me.RCDGV.GridColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RCDGV.HeaderBackColor = System.Drawing.Color.DodgerBlue
        Me.RCDGV.HeaderBgColor = System.Drawing.Color.Empty
        Me.RCDGV.HeaderForeColor = System.Drawing.Color.White
        Me.RCDGV.Location = New System.Drawing.Point(0, 0)
        Me.RCDGV.Name = "RCDGV"
        Me.RCDGV.ReadOnly = True
        Me.RCDGV.RowHeadersVisible = False
        Me.RCDGV.RowHeadersWidth = 51
        Me.RCDGV.RowTemplate.Height = 40
        Me.RCDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.RCDGV.Size = New System.Drawing.Size(831, 388)
        Me.RCDGV.TabIndex = 0
        Me.RCDGV.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RCDGV)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 62)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(831, 388)
        Me.Panel2.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(831, 62)
        Me.Panel1.TabIndex = 2
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnNew)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSave)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnUpdate)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnImport)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnDelete)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnGetData)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnPrint)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnExport)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtSearchRC)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(5)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(831, 62)
        Me.FlowLayoutPanel1.TabIndex = 0
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
        Me.btnNew.TabIndex = 22
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
        Me.btnSave.Location = New System.Drawing.Point(98, 11)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSave.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSave.Name = "btnSave"
        Me.btnSave.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnSave.Size = New System.Drawing.Size(86, 36)
        Me.btnSave.TabIndex = 23
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
        Me.btnUpdate.TabIndex = 24
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnUpdate.UseAccentColor = False
        Me.btnUpdate.UseVisualStyleBackColor = True
        Me.btnUpdate.Visible = False
        '
        'btnImport
        '
        Me.btnImport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnImport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnImport.Depth = 0
        Me.btnImport.HighEmphasis = False
        Me.btnImport.Icon = Global.maccosys2022.My.Resources.Resources.icons8_upload_to_ftp_96
        Me.btnImport.Location = New System.Drawing.Point(305, 11)
        Me.btnImport.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnImport.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnImport.Name = "btnImport"
        Me.btnImport.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnImport.Size = New System.Drawing.Size(104, 36)
        Me.btnImport.TabIndex = 29
        Me.btnImport.Text = "Import"
        Me.btnImport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnImport.UseAccentColor = False
        Me.btnImport.UseVisualStyleBackColor = True
        Me.btnImport.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnDelete.Depth = 0
        Me.btnDelete.HighEmphasis = False
        Me.btnDelete.Icon = Global.maccosys2022.My.Resources.Resources.icons8_trash_96
        Me.btnDelete.Location = New System.Drawing.Point(417, 11)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnDelete.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnDelete.Size = New System.Drawing.Size(101, 36)
        Me.btnDelete.TabIndex = 25
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnDelete.UseAccentColor = False
        Me.btnDelete.UseVisualStyleBackColor = True
        Me.btnDelete.Visible = False
        '
        'btnGetData
        '
        Me.btnGetData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnGetData.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnGetData.Depth = 0
        Me.btnGetData.HighEmphasis = False
        Me.btnGetData.Icon = Global.maccosys2022.My.Resources.Resources.icons8_search_more_96
        Me.btnGetData.Location = New System.Drawing.Point(526, 11)
        Me.btnGetData.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnGetData.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnGetData.Name = "btnGetData"
        Me.btnGetData.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnGetData.Size = New System.Drawing.Size(77, 36)
        Me.btnGetData.TabIndex = 28
        Me.btnGetData.Text = "Get"
        Me.btnGetData.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnGetData.UseAccentColor = False
        Me.btnGetData.UseVisualStyleBackColor = True
        Me.btnGetData.Visible = False
        '
        'btnPrint
        '
        Me.btnPrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPrint.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnPrint.Depth = 0
        Me.btnPrint.HighEmphasis = False
        Me.btnPrint.Icon = Global.maccosys2022.My.Resources.Resources.icons8_print_96
        Me.btnPrint.Location = New System.Drawing.Point(611, 11)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnPrint.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnPrint.Size = New System.Drawing.Size(91, 36)
        Me.btnPrint.TabIndex = 26
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
        Me.btnExport.Location = New System.Drawing.Point(710, 11)
        Me.btnExport.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnExport.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnExport.Name = "btnExport"
        Me.btnExport.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnExport.Size = New System.Drawing.Size(105, 36)
        Me.btnExport.TabIndex = 27
        Me.btnExport.Text = "Export"
        Me.btnExport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnExport.UseAccentColor = False
        Me.btnExport.UseVisualStyleBackColor = True
        Me.btnExport.Visible = False
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
        Me.txtSearchRC.Location = New System.Drawing.Point(8, 56)
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
        Me.txtSearchRC.TabIndex = 21
        Me.txtSearchRC.TabStop = False
        Me.txtSearchRC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtSearchRC.TrailingIcon = Nothing
        Me.txtSearchRC.UseSystemPasswordChar = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmResponsibilityCenter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmResponsibilityCenter"
        Me.Padding = New System.Windows.Forms.Padding(0)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Responsibility Center"
        CType(Me.RCDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RCDGV As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnNew As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnSave As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnUpdate As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnImport As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnDelete As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnGetData As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnPrint As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnExport As MaterialSkin.Controls.MaterialButton
    Friend WithEvents txtSearchRC As MaterialSkin.Controls.MaterialTextBox2
End Class
