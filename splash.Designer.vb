<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class splash
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
        Me.lblSet = New MaterialSkin.Controls.MaterialLabel()
        Me.SplashLoader = New MaterialSkin.Controls.MaterialProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.SuspendLayout()
        '
        'lblSet
        '
        Me.lblSet.AutoSize = True
        Me.lblSet.Depth = 0
        Me.lblSet.Font = New System.Drawing.Font("Roboto", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblSet.FontType = MaterialSkin.MaterialSkinManager.fontType.Overline
        Me.lblSet.Location = New System.Drawing.Point(22, 395)
        Me.lblSet.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSet.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblSet.Name = "lblSet"
        Me.lblSet.Size = New System.Drawing.Size(1, 0)
        Me.lblSet.TabIndex = 5
        '
        'SplashLoader
        '
        Me.SplashLoader.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.SplashLoader.Depth = 0
        Me.SplashLoader.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplashLoader.Location = New System.Drawing.Point(0, 413)
        Me.SplashLoader.Margin = New System.Windows.Forms.Padding(0)
        Me.SplashLoader.MouseState = MaterialSkin.MouseState.HOVER
        Me.SplashLoader.Name = "SplashLoader"
        Me.SplashLoader.Size = New System.Drawing.Size(803, 5)
        Me.SplashLoader.TabIndex = 4
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H3
        Me.MaterialLabel1.HighEmphasis = True
        Me.MaterialLabel1.Location = New System.Drawing.Point(34, 201)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(564, 58)
        Me.MaterialLabel1.TabIndex = 8
        Me.MaterialLabel1.Text = "Data Management System"
        Me.MaterialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MaterialLabel1.UseAccent = True
        '
        'splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(803, 418)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.lblSet)
        Me.Controls.Add(Me.SplashLoader)
        Me.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "splash"
        Me.Padding = New System.Windows.Forms.Padding(0)
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSet As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents SplashLoader As MaterialSkin.Controls.MaterialProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
End Class
