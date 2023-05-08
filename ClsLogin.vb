Imports System.Data.SqlClient
Imports Microsoft.Office.Interop.Excel

Public Class ClsLogin
    Public Property username As String
    Public Property password As String
    Public Property userRole As String
    Public Property firstName As String
    Public Property lastName As String
    Public Property Name As String
    Public Property ContactNo As String
    Public Property ActiveStatus As String
    Public Property userEmail As String
    Public Property oldpassword As String

    Public Sub USER_LOOKUP()
        Try
            If (ClsConn.OpenConnection() = True) Then
                cmd = sqlCon.CreateCommand()
                cmd.CommandText = "SELECT UserID,Password,UserType FROM Registration where UserID = @d1 and Password=@d2 and Active='Yes'"
                cmd.Parameters.AddWithValue("@d1", username)
                cmd.Parameters.AddWithValue("@d2", Encrypt(password))
                Dim rdr As SqlDataReader
                rdr = cmd.ExecuteReader()
                If rdr.Read() Then
                    userRole = rdr.GetValue(2).ToString.Trim
                    'DashBoard.UserType.Text = rdr.GetValue(2).ToString.Trim
                    Dim st As String = "Successfully logged in " & userRole
                    'LogFunc(UserID.Text, st)
                    'MsgBox(st)
                    login.Hide()
                    DashBoard.Show()
                    ' login.Timer1.Enabled = False
                Else
                    MsgBox("Login Failed...Try again !", MsgBoxStyle.Critical, "Login Denied")
                End If
                cmd.Dispose()
                ClsConn.CloseConnection()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub updatePassword()
        If (ClsConn.OpenConnection() = True) Then
            cmd = New SqlCommand("update Registration set Password=@UserPassword where UserID=@UserName and Password=@oldpassword", sqlCon)
            cmd.Parameters.AddWithValue("@UserPassword", Encrypt(password))
            cmd.Parameters.AddWithValue("@UserName", username)
            cmd.Parameters.AddWithValue("@oldpassword", Encrypt(oldpassword))
            Dim RowsAffected As Integer = 0
            RowsAffected = cmd.ExecuteNonQuery()


            If RowsAffected > 0 Then
                Dim st As String = "Successfully changed the password"
                MessageBox.Show(st, "Task completed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'LogFunc(UserID.Text, st)
                'frmCustomDialog2.ShowDialog()
                'Me.Hide()
                'frmLogin.Show()
                'frmLogin.UserID.Text = ""
                'frmLogin.Password.Text = ""
                'frmLogin.UserID.Focus()
            Else
                MessageBox.Show("invalid user name or password", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'DashBoard.txtnewpassword.Text = ""
                'DashBoard.txtnewpassword.Text = ""
                'DashBoard.txtconfirmpassword.Text = ""
            End If
            ClsConn.CloseConnection()
        End If
    End Sub

    Public Sub save()
        If (ClsConn.OpenConnection() = True) Then
            mode = Modes.add
            Dim ct As String = "select userid from registration where userid=@d1"
            cmd = New SqlCommand(ct)
            cmd.Parameters.AddWithValue("@d1", username)
            cmd.Connection = sqlCon
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                MessageBox.Show("User id Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                'txtUserID.Text = ""
                'txtUserID.Focus()
                If (rdr IsNot Nothing) Then
                    rdr.Close()
                End If
                Return
            End If

            Dim ct2 As String = "select EmailID from registration where EmailID=@d1"
            cmd = New SqlCommand(ct2)
            cmd.Parameters.AddWithValue("@d1", userEmail)
            cmd.Connection = sqlCon
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                MessageBox.Show("Email Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                If (rdr IsNot Nothing) Then
                    rdr.Close()
                End If
                Return
            End If

            'If chkActive.Checked = True Then
            ActiveStatus = "Yes"
            'Else
            '    st1 = "No"
            'End If

            Dim cb As String = "insert into Registration(userid, UserType, Password, Name, ContactNo, EmailID,JoiningDate,Active) VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8)"
            cmd = New SqlCommand(cb)
            cmd.Connection = sqlCon
            cmd.Parameters.AddWithValue("@d1", username)
            cmd.Parameters.AddWithValue("@d2", userRole)
            cmd.Parameters.AddWithValue("@d3", Encrypt(password))
            cmd.Parameters.AddWithValue("@d4", Name)
            cmd.Parameters.AddWithValue("@d5", ContactNo)
            cmd.Parameters.AddWithValue("@d6", userEmail)
            cmd.Parameters.AddWithValue("@d7", Now)
            cmd.Parameters.AddWithValue("@d8", ActiveStatus)
            cmd.ExecuteReader()
            Dim st As String = "added the new user '" & username & "'"
            ' LogFunc(lblUser.Text, st)
            MessageBox.Show("Successfully Registered", "User", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MsgBox("Welcome : " & username, vbInformation)
            ClsConn.CloseConnection()
        End If
    End Sub
End Class
