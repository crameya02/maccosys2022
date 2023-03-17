<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSAAOB_Print_Option
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
        Me.MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        Me.cmbOffice = New MaterialSkin.Controls.MaterialComboBox()
        Me.txtOffice = New MaterialSkin.Controls.MaterialTextBox()
        Me.txtDateFrom = New MaterialSkin.Controls.MaterialTextBox()
        Me.dtpDateFrom = New MaterialSkin.Controls.MaterialComboBox()
        Me.dtpDateTo = New MaterialSkin.Controls.MaterialComboBox()
        Me.txtDateTo = New MaterialSkin.Controls.MaterialTextBox()
        Me.SuspendLayout()
        '
        'MaterialButton1
        '
        Me.MaterialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton1.Depth = 0
        Me.MaterialButton1.HighEmphasis = False
        Me.MaterialButton1.Icon = Nothing
        Me.MaterialButton1.Location = New System.Drawing.Point(584, 205)
        Me.MaterialButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton1.Name = "MaterialButton1"
        Me.MaterialButton1.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton1.Size = New System.Drawing.Size(64, 36)
        Me.MaterialButton1.TabIndex = 1
        Me.MaterialButton1.Text = "OK"
        Me.MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.MaterialButton1.UseAccentColor = False
        Me.MaterialButton1.UseVisualStyleBackColor = True
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
        Me.cmbOffice.Location = New System.Drawing.Point(8, 66)
        Me.cmbOffice.Margin = New System.Windows.Forms.Padding(5)
        Me.cmbOffice.MaxDropDownItems = 4
        Me.cmbOffice.MouseState = MaterialSkin.MouseState.OUT
        Me.cmbOffice.Name = "cmbOffice"
        Me.cmbOffice.Size = New System.Drawing.Size(198, 49)
        Me.cmbOffice.StartIndex = 0
        Me.cmbOffice.TabIndex = 14
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
        Me.txtOffice.Location = New System.Drawing.Point(203, 66)
        Me.txtOffice.MaxLength = 50
        Me.txtOffice.MouseState = MaterialSkin.MouseState.OUT
        Me.txtOffice.Multiline = False
        Me.txtOffice.Name = "txtOffice"
        Me.txtOffice.Size = New System.Drawing.Size(447, 50)
        Me.txtOffice.TabIndex = 15
        Me.txtOffice.Text = ""
        Me.txtOffice.TrailingIcon = Nothing
        '
        'txtDateFrom
        '
        Me.txtDateFrom.AnimateReadOnly = False
        Me.txtDateFrom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDateFrom.Depth = 0
        Me.txtDateFrom.Enabled = False
        Me.txtDateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtDateFrom.Hint = "From"
        Me.txtDateFrom.LeadingIcon = Nothing
        Me.txtDateFrom.Location = New System.Drawing.Point(6, 130)
        Me.txtDateFrom.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.txtDateFrom.MaxLength = 50
        Me.txtDateFrom.MouseState = MaterialSkin.MouseState.OUT
        Me.txtDateFrom.Multiline = False
        Me.txtDateFrom.Name = "txtDateFrom"
        Me.txtDateFrom.Size = New System.Drawing.Size(282, 50)
        Me.txtDateFrom.TabIndex = 17
        Me.txtDateFrom.Text = ""
        Me.txtDateFrom.TrailingIcon = Nothing
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.AutoResize = False
        Me.dtpDateFrom.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpDateFrom.Depth = 0
        Me.dtpDateFrom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.dtpDateFrom.DropDownHeight = 45
        Me.dtpDateFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dtpDateFrom.DropDownWidth = 121
        Me.dtpDateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.dtpDateFrom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dtpDateFrom.FormattingEnabled = True
        Me.dtpDateFrom.IntegralHeight = False
        Me.dtpDateFrom.ItemHeight = 43
        Me.dtpDateFrom.Location = New System.Drawing.Point(288, 130)
        Me.dtpDateFrom.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.dtpDateFrom.MaxDropDownItems = 1
        Me.dtpDateFrom.MouseState = MaterialSkin.MouseState.OUT
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(36, 49)
        Me.dtpDateFrom.StartIndex = 0
        Me.dtpDateFrom.TabIndex = 18
        '
        'dtpDateTo
        '
        Me.dtpDateTo.AutoResize = False
        Me.dtpDateTo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpDateTo.Depth = 0
        Me.dtpDateTo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.dtpDateTo.DropDownHeight = 45
        Me.dtpDateTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dtpDateTo.DropDownWidth = 121
        Me.dtpDateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.dtpDateTo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dtpDateTo.FormattingEnabled = True
        Me.dtpDateTo.IntegralHeight = False
        Me.dtpDateTo.ItemHeight = 43
        Me.dtpDateTo.Location = New System.Drawing.Point(612, 131)
        Me.dtpDateTo.Margin = New System.Windows.Forms.Padding(0, 3, 3, 3)
        Me.dtpDateTo.MaxDropDownItems = 1
        Me.dtpDateTo.MouseState = MaterialSkin.MouseState.OUT
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(36, 49)
        Me.dtpDateTo.StartIndex = 0
        Me.dtpDateTo.TabIndex = 18
        '
        'txtDateTo
        '
        Me.txtDateTo.AnimateReadOnly = False
        Me.txtDateTo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDateTo.Depth = 0
        Me.txtDateTo.Enabled = False
        Me.txtDateTo.Font = New System.Drawing.Font("Roboto", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtDateTo.Hint = "To"
        Me.txtDateTo.LeadingIcon = Nothing
        Me.txtDateTo.Location = New System.Drawing.Point(330, 131)
        Me.txtDateTo.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.txtDateTo.MaxLength = 50
        Me.txtDateTo.MouseState = MaterialSkin.MouseState.OUT
        Me.txtDateTo.Multiline = False
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Size = New System.Drawing.Size(282, 50)
        Me.txtDateTo.TabIndex = 17
        Me.txtDateTo.Text = ""
        Me.txtDateTo.TrailingIcon = Nothing
        '
        'frmSAAOB_Print_Option
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 260)
        Me.Controls.Add(Me.txtDateTo)
        Me.Controls.Add(Me.dtpDateTo)
        Me.Controls.Add(Me.txtDateFrom)
        Me.Controls.Add(Me.dtpDateFrom)
        Me.Controls.Add(Me.cmbOffice)
        Me.Controls.Add(Me.txtOffice)
        Me.Controls.Add(Me.MaterialButton1)
        Me.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSAAOB_Print_Option"
        Me.Padding = New System.Windows.Forms.Padding(3, 24, 3, 3)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents cmbOffice As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents txtOffice As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents txtDateFrom As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents dtpDateFrom As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents dtpDateTo As MaterialSkin.Controls.MaterialComboBox
    Friend WithEvents txtDateTo As MaterialSkin.Controls.MaterialTextBox
End Class
