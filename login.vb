Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Drawing.Imaging

Public Class login
    Declare Function Wow64DisableWow64FsRedirection Lib "kernel32" (ByRef oldvalue As Long) As Boolean
    Declare Function Wow64EnableWow64FsRedirection Lib "kernel32" (ByRef oldvalue As Long) As Boolean
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If Len(Trim(UserID.Text)) = 0 Then
            MessageBox.Show("Please enter User Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            UserID.SelectAll()
            Exit Sub
        End If
        If Len(Trim(Password.Text)) = 0 Then
            MessageBox.Show("Please enter password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Password.SelectAll()
            Exit Sub
        End If
        Dim LookforUser As New ClsLogin
        With LookforUser
            .username = UserID.Text
            .password = Password.Text
            .USER_LOOKUP()
        End With
    End Sub
    Private Sub login_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        End
        Application.Exit()
    End Sub

    Public Sub PreVentFlicker()
        With Me
            .SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
            .SetStyle(ControlStyles.UserPaint, True)
            .SetStyle(ControlStyles.AllPaintingInWmPaint, True)
            .UpdateStyles()
        End With
    End Sub
    Private Sub LoginForm1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PreVentFlicker()
        theme.myCustomSkinDark(Me)
    End Sub



    'Private Sub btnChangePassword_Click(sender As System.Object, e As System.EventArgs) Handles btnChangePassword.Click
    '    Me.Hide()
    '    frmChangePassword.Show()
    '    frmChangePassword.UserID.Text = ""
    '    frmChangePassword.OldPassword.Text = ""
    '    frmChangePassword.NewPassword.Text = ""
    '    frmChangePassword.ConfirmPassword.Text = ""
    '    frmChangePassword.UserID.Focus()
    'End Sub

    'Private Sub btnChangePassword_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnChangePassword.MouseHover
    '    ToolTip1.IsBalloon = True
    '    ToolTip1.UseAnimation = True
    '    ToolTip1.ToolTipTitle = ""
    '    ToolTip1.SetToolTip(btnChangePassword, "Change Password")
    'End Sub

    'Private Sub btnRecoveryPassword_MouseHover(sender As System.Object, e As System.EventArgs) Handles btnRecoveryPassword.MouseHover
    '    ToolTip1.IsBalloon = True
    '    ToolTip1.UseAnimation = True
    '    ToolTip1.ToolTipTitle = ""
    '    ToolTip1.SetToolTip(btnRecoveryPassword, "Password Recovery")
    'End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        'this is magic code that has an enormous positive effect on reducing flickering.
        'don't remove this.
        'found this nugget here: http://www.vbmigration.com/detknowledgebase.aspx?Id=692
        Get
            Dim params As CreateParams = MyBase.CreateParams
            params.ExStyle = params.ExStyle Or &H2000000
            Return params
        End Get
    End Property



    'Private Sub btnRecoveryPassword_Click(sender As System.Object, e As System.EventArgs) Handles btnRecoveryPassword.Click
    '    'Me.Hide()
    '    'frmRecoveryPassword.Show()
    '    'frmRecoveryPassword.txtEmailID.Text = ""
    '    'frmRecoveryPassword.txtEmailID.Focus()
    '    Me.Hide()
    '    SendCode.Show()
    'End Sub





    'Private Sub btnKeyboard_Click(sender As Object, e As EventArgs) Handles btnKeyboard.Click
    '    Dim old As Long
    '    If Environment.Is64BitOperatingSystem Then
    '        If Wow64DisableWow64FsRedirection(old) Then
    '            Process.Start("osk.exe")
    '            Wow64EnableWow64FsRedirection(old)
    '        End If
    '    Else
    '        Process.Start("osk.exe")
    '    End If
    'End Sub


    'Private Sub btnKeyboard_MouseHover(sender As Object, e As EventArgs) Handles btnKeyboard.MouseHover
    '    ToolTip1.IsBalloon = True
    '    ToolTip1.UseAnimation = True
    '    ToolTip1.ToolTipTitle = ""
    '    ToolTip1.SetToolTip(btnKeyboard, "OnScreen Keyboard")
    'End Sub
End Class

