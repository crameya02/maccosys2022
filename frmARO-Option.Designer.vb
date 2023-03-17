<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmARO_Option
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
        Me.mrbAppro = New MaterialSkin.Controls.MaterialRadioButton()
        Me.mrbAllot = New MaterialSkin.Controls.MaterialRadioButton()
        Me.mrbAdj = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        Me.SuspendLayout()
        '
        'mrbAppro
        '
        Me.mrbAppro.AutoSize = True
        Me.mrbAppro.Depth = 0
        Me.mrbAppro.Location = New System.Drawing.Point(26, 100)
        Me.mrbAppro.Margin = New System.Windows.Forms.Padding(0)
        Me.mrbAppro.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.mrbAppro.MouseState = MaterialSkin.MouseState.HOVER
        Me.mrbAppro.Name = "mrbAppro"
        Me.mrbAppro.Ripple = True
        Me.mrbAppro.Size = New System.Drawing.Size(131, 37)
        Me.mrbAppro.TabIndex = 1
        Me.mrbAppro.TabStop = True
        Me.mrbAppro.Text = "Appropriation"
        Me.mrbAppro.UseVisualStyleBackColor = True
        '
        'mrbAllot
        '
        Me.mrbAllot.AutoSize = True
        Me.mrbAllot.Depth = 0
        Me.mrbAllot.Location = New System.Drawing.Point(26, 137)
        Me.mrbAllot.Margin = New System.Windows.Forms.Padding(0)
        Me.mrbAllot.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.mrbAllot.MouseState = MaterialSkin.MouseState.HOVER
        Me.mrbAllot.Name = "mrbAllot"
        Me.mrbAllot.Ripple = True
        Me.mrbAllot.Size = New System.Drawing.Size(103, 37)
        Me.mrbAllot.TabIndex = 2
        Me.mrbAllot.TabStop = True
        Me.mrbAllot.Text = "Allotment"
        Me.mrbAllot.UseVisualStyleBackColor = True
        '
        'mrbAdj
        '
        Me.mrbAdj.AutoSize = True
        Me.mrbAdj.Depth = 0
        Me.mrbAdj.Location = New System.Drawing.Point(26, 174)
        Me.mrbAdj.Margin = New System.Windows.Forms.Padding(0)
        Me.mrbAdj.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.mrbAdj.MouseState = MaterialSkin.MouseState.HOVER
        Me.mrbAdj.Name = "mrbAdj"
        Me.mrbAdj.Ripple = True
        Me.mrbAdj.Size = New System.Drawing.Size(124, 37)
        Me.mrbAdj.TabIndex = 3
        Me.mrbAdj.TabStop = True
        Me.mrbAdj.Text = "Adjustments"
        Me.mrbAdj.UseVisualStyleBackColor = True
        '
        'MaterialButton1
        '
        Me.MaterialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton1.Depth = 0
        Me.MaterialButton1.HighEmphasis = False
        Me.MaterialButton1.Icon = Nothing
        Me.MaterialButton1.Location = New System.Drawing.Point(378, 195)
        Me.MaterialButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton1.Name = "MaterialButton1"
        Me.MaterialButton1.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton1.Size = New System.Drawing.Size(64, 36)
        Me.MaterialButton1.TabIndex = 0
        Me.MaterialButton1.Text = "OK"
        Me.MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text
        Me.MaterialButton1.UseAccentColor = False
        Me.MaterialButton1.UseVisualStyleBackColor = True
        '
        'frmARO_Option
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 240)
        Me.Controls.Add(Me.MaterialButton1)
        Me.Controls.Add(Me.mrbAppro)
        Me.Controls.Add(Me.mrbAdj)
        Me.Controls.Add(Me.mrbAllot)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmARO_Option"
        Me.Sizable = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "What do you want to do?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mrbAppro As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents mrbAllot As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents mrbAdj As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
End Class
