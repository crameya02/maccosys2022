<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Loader
    'Inherits System.Windows.Forms.Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loader))
        Me.BunifuCircleProgress1 = New Bunifu.UI.WinForms.BunifuCircleProgress()
        Me.BunifuLabel1 = New Bunifu.UI.WinForms.BunifuLabel()
        Me.SuspendLayout()
        '
        'BunifuCircleProgress1
        '
        Me.BunifuCircleProgress1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCircleProgress1.Animated = True
        Me.BunifuCircleProgress1.AnimationInterval = 1
        Me.BunifuCircleProgress1.AnimationSpeed = 1
        Me.BunifuCircleProgress1.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuCircleProgress1.CircleMargin = 10
        Me.BunifuCircleProgress1.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Bold)
        Me.BunifuCircleProgress1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuCircleProgress1.IsPercentage = False
        Me.BunifuCircleProgress1.LineProgressThickness = 10
        Me.BunifuCircleProgress1.LineThickness = 10
        Me.BunifuCircleProgress1.Location = New System.Drawing.Point(6, 8)
        Me.BunifuCircleProgress1.Name = "BunifuCircleProgress1"
        Me.BunifuCircleProgress1.ProgressAnimationSpeed = 200
        Me.BunifuCircleProgress1.ProgressBackColor = System.Drawing.Color.Gainsboro
        Me.BunifuCircleProgress1.ProgressColor = System.Drawing.Color.DodgerBlue
        Me.BunifuCircleProgress1.ProgressColor2 = System.Drawing.Color.DodgerBlue
        Me.BunifuCircleProgress1.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round
        Me.BunifuCircleProgress1.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Gradient
        Me.BunifuCircleProgress1.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round
        Me.BunifuCircleProgress1.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.BunifuCircleProgress1.Size = New System.Drawing.Size(200, 200)
        Me.BunifuCircleProgress1.SubScriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.BunifuCircleProgress1.SubScriptMargin = New System.Windows.Forms.Padding(5, -20, 0, 0)
        Me.BunifuCircleProgress1.SubScriptText = ""
        Me.BunifuCircleProgress1.SuperScriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.BunifuCircleProgress1.SuperScriptMargin = New System.Windows.Forms.Padding(5, 20, 0, 0)
        Me.BunifuCircleProgress1.SuperScriptText = "%"
        Me.BunifuCircleProgress1.TabIndex = 21
        Me.BunifuCircleProgress1.Text = "0"
        Me.BunifuCircleProgress1.TextMargin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.BunifuCircleProgress1.ValueByTransition = 0
        Me.BunifuCircleProgress1.ValueMargin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.BunifuCircleProgress1.Visible = False
        '
        'BunifuLabel1
        '
        Me.BunifuLabel1.AllowParentOverrides = False
        Me.BunifuLabel1.AutoEllipsis = False
        Me.BunifuLabel1.AutoSize = False
        Me.BunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default
        Me.BunifuLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuLabel1.Location = New System.Drawing.Point(18, 218)
        Me.BunifuLabel1.Name = "BunifuLabel1"
        Me.BunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BunifuLabel1.Size = New System.Drawing.Size(174, 41)
        Me.BunifuLabel1.TabIndex = 22
        Me.BunifuLabel1.Text = "Please wait while generating excel file."
        Me.BunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.[Default]
        '
        'Loader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(212, 216)
        Me.Controls.Add(Me.BunifuLabel1)
        Me.Controls.Add(Me.BunifuCircleProgress1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Loader"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Sizable = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loader"
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuCircleProgress1 As Bunifu.UI.WinForms.BunifuCircleProgress
    Friend WithEvents BunifuLabel1 As Bunifu.UI.WinForms.BunifuLabel
End Class
