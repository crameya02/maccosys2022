<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSqlServerSetting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSqlServerSetting))
        Me.cmbServerName = New MaterialSkin.Controls.MaterialComboBox()
        Me.cmbAuthentication = New MaterialSkin.Controls.MaterialComboBox()
        Me.txtUserName = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtPassword = New MaterialSkin.Controls.MaterialTextBox()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnTestConnection = New MaterialSkin.Controls.MaterialButton()
        Me.btnBlankDataDB = New MaterialSkin.Controls.MaterialButton()
        Me.btnCreateDemoDataDB = New MaterialSkin.Controls.MaterialButton()
        Me.SearchDatabase = New MaterialSkin.Controls.MaterialButton()
        Me.txtServerName = New MaterialSkin.Controls.MaterialTextBox()
        Me.SuspendLayout()
        '
        'cmbServerName
        '
        Me.cmbServerName.AutoResize = False
        Me.cmbServerName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbServerName.Depth = 0
        Me.cmbServerName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbServerName.DropDownHeight = 174
        Me.cmbServerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbServerName.DropDownWidth = 121
        Me.cmbServerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cmbServerName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbServerName.FormattingEnabled = True
        Me.cmbServerName.IntegralHeight = False
        Me.cmbServerName.ItemHeight = 43
        Me.cmbServerName.Location = New System.Drawing.Point(295, 82)
        Me.cmbServerName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbServerName.MaxDropDownItems = 4
        Me.cmbServerName.MouseState = MaterialSkin.MouseState.OUT
        Me.cmbServerName.Name = "cmbServerName"
        Me.cmbServerName.Size = New System.Drawing.Size(460, 49)
        Me.cmbServerName.StartIndex = 0
        Me.cmbServerName.TabIndex = 0
        '
        'cmbAuthentication
        '
        Me.cmbAuthentication.AutoResize = False
        Me.cmbAuthentication.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbAuthentication.Depth = 0
        Me.cmbAuthentication.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.cmbAuthentication.DropDownHeight = 174
        Me.cmbAuthentication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAuthentication.DropDownWidth = 121
        Me.cmbAuthentication.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.cmbAuthentication.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmbAuthentication.FormattingEnabled = True
        Me.cmbAuthentication.IntegralHeight = False
        Me.cmbAuthentication.ItemHeight = 43
        Me.cmbAuthentication.Items.AddRange(New Object() {"Windows Authentication", "SQL Server Authentication"})
        Me.cmbAuthentication.Location = New System.Drawing.Point(295, 150)
        Me.cmbAuthentication.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbAuthentication.MaxDropDownItems = 4
        Me.cmbAuthentication.MouseState = MaterialSkin.MouseState.OUT
        Me.cmbAuthentication.Name = "cmbAuthentication"
        Me.cmbAuthentication.Size = New System.Drawing.Size(460, 49)
        Me.cmbAuthentication.StartIndex = 0
        Me.cmbAuthentication.TabIndex = 0
        '
        'txtUserName
        '
        Me.txtUserName.AnimateReadOnly = False
        Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUserName.Depth = 0
        Me.txtUserName.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtUserName.LeadingIcon = Nothing
        Me.txtUserName.Location = New System.Drawing.Point(295, 218)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUserName.MaxLength = 50
        Me.txtUserName.MouseState = MaterialSkin.MouseState.OUT
        Me.txtUserName.Multiline = False
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(461, 50)
        Me.txtUserName.TabIndex = 1
        Me.txtUserName.Text = ""
        Me.txtUserName.TrailingIcon = Nothing
        '
        'txtPassword
        '
        Me.txtPassword.AnimateReadOnly = False
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Depth = 0
        Me.txtPassword.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtPassword.LeadingIcon = Nothing
        Me.txtPassword.Location = New System.Drawing.Point(295, 287)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPassword.MaxLength = 50
        Me.txtPassword.MouseState = MaterialSkin.MouseState.OUT
        Me.txtPassword.Multiline = False
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(461, 50)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.Text = ""
        Me.txtPassword.TrailingIcon = Nothing
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.Location = New System.Drawing.Point(32, 103)
        Me.MaterialLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(125, 19)
        Me.MaterialLabel1.TabIndex = 2
        Me.MaterialLabel1.Text = "SQL Server Name"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel2.Location = New System.Drawing.Point(32, 170)
        Me.MaterialLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(104, 19)
        Me.MaterialLabel2.TabIndex = 2
        Me.MaterialLabel2.Text = "Authentication"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel3.Location = New System.Drawing.Point(32, 240)
        Me.MaterialLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(160, 19)
        Me.MaterialLabel3.TabIndex = 2
        Me.MaterialLabel3.Text = "SQL Server User Name"
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel4.Location = New System.Drawing.Point(32, 304)
        Me.MaterialLabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(153, 19)
        Me.MaterialLabel4.TabIndex = 2
        Me.MaterialLabel4.Text = "SQL Server Password"
        '
        'Timer1
        '
        '
        'btnTestConnection
        '
        Me.btnTestConnection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnTestConnection.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnTestConnection.Depth = 0
        Me.btnTestConnection.HighEmphasis = True
        Me.btnTestConnection.Icon = Nothing
        Me.btnTestConnection.Location = New System.Drawing.Point(31, 358)
        Me.btnTestConnection.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.btnTestConnection.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnTestConnection.Name = "btnTestConnection"
        Me.btnTestConnection.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnTestConnection.Size = New System.Drawing.Size(175, 36)
        Me.btnTestConnection.TabIndex = 3
        Me.btnTestConnection.Text = "Test DB Connection"
        Me.btnTestConnection.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTestConnection.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnTestConnection.UseAccentColor = False
        Me.btnTestConnection.UseVisualStyleBackColor = True
        '
        'btnBlankDataDB
        '
        Me.btnBlankDataDB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnBlankDataDB.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnBlankDataDB.Depth = 0
        Me.btnBlankDataDB.HighEmphasis = True
        Me.btnBlankDataDB.Icon = Nothing
        Me.btnBlankDataDB.Location = New System.Drawing.Point(275, 358)
        Me.btnBlankDataDB.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.btnBlankDataDB.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnBlankDataDB.Name = "btnBlankDataDB"
        Me.btnBlankDataDB.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnBlankDataDB.Size = New System.Drawing.Size(190, 36)
        Me.btnBlankDataDB.TabIndex = 3
        Me.btnBlankDataDB.Text = "Create Blank Data DB "
        Me.btnBlankDataDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBlankDataDB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnBlankDataDB.UseAccentColor = False
        Me.btnBlankDataDB.UseVisualStyleBackColor = True
        '
        'btnCreateDemoDataDB
        '
        Me.btnCreateDemoDataDB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCreateDemoDataDB.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnCreateDemoDataDB.Depth = 0
        Me.btnCreateDemoDataDB.HighEmphasis = True
        Me.btnCreateDemoDataDB.Icon = Nothing
        Me.btnCreateDemoDataDB.Location = New System.Drawing.Point(539, 358)
        Me.btnCreateDemoDataDB.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.btnCreateDemoDataDB.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCreateDemoDataDB.Name = "btnCreateDemoDataDB"
        Me.btnCreateDemoDataDB.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnCreateDemoDataDB.Size = New System.Drawing.Size(185, 36)
        Me.btnCreateDemoDataDB.TabIndex = 3
        Me.btnCreateDemoDataDB.Text = "Create Demo Data DB "
        Me.btnCreateDemoDataDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCreateDemoDataDB.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnCreateDemoDataDB.UseAccentColor = False
        Me.btnCreateDemoDataDB.UseVisualStyleBackColor = True
        '
        'SearchDatabase
        '
        Me.SearchDatabase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SearchDatabase.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.SearchDatabase.Depth = 0
        Me.SearchDatabase.HighEmphasis = True
        Me.SearchDatabase.Icon = Nothing
        Me.SearchDatabase.Location = New System.Drawing.Point(765, 91)
        Me.SearchDatabase.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.SearchDatabase.MouseState = MaterialSkin.MouseState.HOVER
        Me.SearchDatabase.Name = "SearchDatabase"
        Me.SearchDatabase.NoAccentTextColor = System.Drawing.Color.Empty
        Me.SearchDatabase.Size = New System.Drawing.Size(155, 36)
        Me.SearchDatabase.TabIndex = 4
        Me.SearchDatabase.Text = "Search Database"
        Me.SearchDatabase.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.SearchDatabase.UseAccentColor = False
        Me.SearchDatabase.UseVisualStyleBackColor = True
        '
        'txtServerName
        '
        Me.txtServerName.AnimateReadOnly = False
        Me.txtServerName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtServerName.Depth = 0
        Me.txtServerName.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtServerName.LeadingIcon = Nothing
        Me.txtServerName.Location = New System.Drawing.Point(295, 82)
        Me.txtServerName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtServerName.MaxLength = 50
        Me.txtServerName.MouseState = MaterialSkin.MouseState.OUT
        Me.txtServerName.Multiline = False
        Me.txtServerName.Name = "txtServerName"
        Me.txtServerName.Size = New System.Drawing.Size(424, 50)
        Me.txtServerName.TabIndex = 6
        Me.txtServerName.Text = ""
        Me.txtServerName.TrailingIcon = Nothing
        '
        'frmSqlServerSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(987, 414)
        Me.Controls.Add(Me.txtServerName)
        Me.Controls.Add(Me.SearchDatabase)
        Me.Controls.Add(Me.btnCreateDemoDataDB)
        Me.Controls.Add(Me.btnBlankDataDB)
        Me.Controls.Add(Me.btnTestConnection)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.cmbAuthentication)
        Me.Controls.Add(Me.cmbServerName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmSqlServerSetting"
        Me.Padding = New System.Windows.Forms.Padding(4, 79, 4, 4)
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SQL Server Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbServerName As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents cmbAuthentication As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents txtUserName As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtPassword As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnTestConnection As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnBlankDataDB As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnCreateDemoDataDB As MaterialSkin.Controls.MaterialButton
    Friend WithEvents SearchDatabase As MaterialSkin.Controls.MaterialButton
    Friend WithEvents txtServerName As MaterialSkin.Controls.MaterialTextBox
End Class
