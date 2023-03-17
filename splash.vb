Public Class splash
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        theme.myCustomSkinDark(Me)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If System.IO.File.Exists(Application.StartupPath & "\SQLSettings.dat") Then
                SplashLoader.Visible = True
                SplashLoader.Value = SplashLoader.Value + 1
                If (SplashLoader.Value = 10) Then
                    lblSet.Text = "Reading modules.."
                ElseIf (SplashLoader.Value = 20) Then
                    lblSet.Text = "Turning on modules."
                ElseIf (SplashLoader.Value = 40) Then
                    lblSet.Text = "Starting modules.."
                ElseIf (SplashLoader.Value = 60) Then
                    lblSet.Text = "Loading modules.."
                ElseIf (SplashLoader.Value = 80) Then
                    lblSet.Text = "Done Loading modules.."
                ElseIf (SplashLoader.Value = 100) Then
                    Timer1.Enabled = False
                    Me.Hide()
                    login.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
                    login.Show()
                End If
            Else
                SplashLoader.Visible = True
                SplashLoader.Value = SplashLoader.Value + 1
                If (SplashLoader.Value = 10) Then
                    lblSet.Text = "Reading modules.."
                ElseIf (SplashLoader.Value = 20) Then
                    lblSet.Text = "Turning on modules."
                ElseIf (SplashLoader.Value = 40) Then
                    lblSet.Text = "Starting modules.."
                ElseIf (SplashLoader.Value = 60) Then
                    lblSet.Text = "Loading modules.."
                ElseIf (SplashLoader.Value = 80) Then
                    lblSet.Text = "Done Loading modules.."
                ElseIf (SplashLoader.Value = 100) Then
                    ' frmSqlServerSetting.Reset()
                    frmSqlServerSetting.Show()
                    Timer1.Enabled = False
                    Me.Hide()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error!")
            End
        End Try
    End Sub
End Class
