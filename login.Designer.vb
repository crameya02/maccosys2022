<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.btnLogin = New MaterialSkin.Controls.MaterialButton()
        Me.Password = New MaterialSkin.Controls.MaterialTextBox2()
        Me.UserID = New MaterialSkin.Controls.MaterialTextBox2()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnLogin.Depth = 0
        Me.btnLogin.HighEmphasis = False
        Me.btnLogin.Icon = Global.maccosys2022.My.Resources.Resources.icons8_sent_96
        Me.btnLogin.Location = New System.Drawing.Point(282, 288)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.btnLogin.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnLogin.Size = New System.Drawing.Size(92, 36)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.btnLogin.UseAccentColor = False
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Password
        '
        Me.Password.AnimateReadOnly = False
        Me.Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Password.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.Password.Depth = 0
        Me.Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Password.HideSelection = True
        Me.Password.Hint = "Password"
        Me.Password.LeadingIcon = Global.maccosys2022.My.Resources.Resources.icons8_password_48
        Me.Password.Location = New System.Drawing.Point(51, 201)
        Me.Password.Margin = New System.Windows.Forms.Padding(4)
        Me.Password.MaxLength = 32767
        Me.Password.MouseState = MaterialSkin.MouseState.OUT
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.Password.PrefixSuffixText = Nothing
        Me.Password.ReadOnly = False
        Me.Password.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Password.SelectedText = ""
        Me.Password.SelectionLength = 0
        Me.Password.SelectionStart = 0
        Me.Password.ShortcutsEnabled = True
        Me.Password.Size = New System.Drawing.Size(354, 48)
        Me.Password.TabIndex = 2
        Me.Password.TabStop = False
        Me.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Password.TrailingIcon = Nothing
        Me.Password.UseSystemPasswordChar = True
        '
        'UserID
        '
        Me.UserID.AnimateReadOnly = False
        Me.UserID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.UserID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.UserID.Depth = 0
        Me.UserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.UserID.HideSelection = True
        Me.UserID.Hint = "Username"
        Me.UserID.LeadingIcon = Global.maccosys2022.My.Resources.Resources.icons8_user_48
        Me.UserID.Location = New System.Drawing.Point(51, 124)
        Me.UserID.Margin = New System.Windows.Forms.Padding(4)
        Me.UserID.MaxLength = 32767
        Me.UserID.MouseState = MaterialSkin.MouseState.OUT
        Me.UserID.Name = "UserID"
        Me.UserID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UserID.PrefixSuffixText = Nothing
        Me.UserID.ReadOnly = False
        Me.UserID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UserID.SelectedText = ""
        Me.UserID.SelectionLength = 0
        Me.UserID.SelectionStart = 0
        Me.UserID.ShortcutsEnabled = True
        Me.UserID.Size = New System.Drawing.Size(354, 48)
        Me.UserID.TabIndex = 1
        Me.UserID.TabStop = False
        Me.UserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.UserID.TrailingIcon = Nothing
        Me.UserID.UseSystemPasswordChar = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 323)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.UserID)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "login"
        Me.Padding = New System.Windows.Forms.Padding(3, 64, 4, 4)
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserID As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents Password As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents btnLogin As MaterialSkin.Controls.MaterialButton
End Class
