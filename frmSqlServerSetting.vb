﻿Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Data.Sql
Imports System.Data
Imports Microsoft.SqlServer.Management.Smo
Imports Microsoft.SqlServer.Management.Common
Imports Microsoft.SqlServer
Imports System.Threading
Imports System.ComponentModel

Public Class frmSqlServerSetting
    Dim st As String
    Dim SqlConnStr As String
    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnCreateDemoDataDB.Click
        Try
            If cmbServerName.Text = "" Then
                MsgBox("Please Select/Enter Server Name", MsgBoxStyle.Information)
                cmbServerName.Focus()
                Exit Sub
            End If
            If cmbAuthentication.SelectedIndex = 1 Then
                If txtUserName.Text.Length = 0 Then
                    MsgBox("please enter user name", MsgBoxStyle.Information)
                    txtUserName.Focus()
                    Exit Sub
                End If
                If txtPassword.Text.Length = 0 Then
                    MsgBox("please enter password", MsgBoxStyle.Information)
                    txtPassword.Focus()
                    Exit Sub
                End If
            End If
            Cursor = Cursors.WaitCursor
            Timer1.Enabled = True
            If cmbAuthentication.SelectedIndex = 0 Then
                sqlCon = New SqlConnection("Data source=" & cmbServerName.Text & ";Initial Catalog=master;Integrated Security=True;")
            End If
            If cmbAuthentication.SelectedIndex = 1 Then


                sqlCon = New SqlConnection("Data Source=" & cmbServerName.Text.Trim & ";Initial Catalog=master;User ID=" & txtUserName.Text.Trim & ";Password=" & txtPassword.Text & "")
            End If
            sqlCon.Open()
            If (sqlCon.State = ConnectionState.Open) Then
                If MsgBox("It will create the DB and configure the sql server, Do you want to proceed?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then

                    Using sw As StreamWriter = New StreamWriter(Application.StartupPath & "\SQLSettings.dat")
                        If cmbAuthentication.SelectedIndex = 0 Then
                            sw.WriteLine("Data Source=" & cmbServerName.Text.Trim & ";Initial Catalog=0218_DB;Integrated Security=True")
                            sw.Close()
                        End If
                        If cmbAuthentication.SelectedIndex = 1 Then
                            sw.WriteLine("Data Source=" & cmbServerName.Text.Trim & ";Initial Catalog=0218_DB;User ID=" & txtUserName.Text.Trim & ";Password=" & txtPassword.Text & "")
                            sw.Close()
                        End If
                        'CreateDB()
                    End Using
                Else
                    End
                End If
            End If
            MessageBox.Show("DB has been created and SQL Server setting has been saved successfully..." & vbCrLf & "Application will be closed,Please start it again", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End
        Catch ex As Exception
            MessageBox.Show("Unable to connect to sql server" + vbCrLf + Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If (sqlCon.State = ConnectionState.Open) Then
                sqlCon.Close()
            End If
        End Try
    End Sub

    'Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
    '    If lblSet.Text = "Main Form" Then
    '        Me.Close()
    '    Else
    '        If MsgBox("Do you want to close the application....", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
    '            End
    '        End If
    '    End If
    'End Sub
    Sub CreateDB()
        Try
            sqlCon = New SqlConnection("Data source=" & cmbServerName.Text & ";Initial Catalog=master;Integrated Security=True;")
            sqlCon.Open()
            Dim cb2 As String = "Select * from sysdatabases where name='0218_DB'"
            cmd = New SqlCommand(cb2)
            cmd.Connection = sqlCon
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then

                sqlCon = New SqlConnection("Data source=" & cmbServerName.Text & ";Initial Catalog=master;Integrated Security=True;")
                sqlCon.Open()
                Dim cb1 As String = "Drop Database 0218_DB"
                cmd = New SqlCommand(cb1)
                cmd.Connection = sqlCon
                cmd.ExecuteNonQuery()
                sqlCon.Close()
                Try
                    sqlCon = New SqlConnection("Data source=" & cmbServerName.Text & ";Initial Catalog=master;Integrated Security=True;")
                    sqlCon.Open()
                    Dim cb As String = "Create Database 0218_DB"
                    cmd = New SqlCommand(cb)
                    cmd.Connection = sqlCon

                    cmd.ExecuteNonQuery()
                    sqlCon.Close()
                    Using sr As StreamReader = New StreamReader(Application.StartupPath & "\DBScript.sql")
                        st = sr.ReadToEnd()
                        Dim server As New Server(New ServerConnection(sqlCon))
                        server.ConnectionContext.ExecuteNonQuery(st)
                    End Using
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                sqlCon = New SqlConnection("Data source=" & cmbServerName.Text & ";Initial Catalog=master;Integrated Security=True;")
                sqlCon.Open()
                Dim cb3 As String = "Create Database 0218_DB"
                cmd = New SqlCommand(cb3)
                cmd.Connection = sqlCon
                cmd.ExecuteNonQuery()
                sqlCon.Close()
                Using sr As StreamReader = New StreamReader(Application.StartupPath & "\DBScript.sql")
                    st = sr.ReadToEnd()
                    Dim server As New Server(New ServerConnection(sqlCon))
                    server.ConnectionContext.ExecuteNonQuery(st)
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If (sqlCon.State = ConnectionState.Open) Then
                sqlCon.Close()
            End If
        End Try
    End Sub


    Private Sub cmbAuthentication_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbAuthentication.SelectedIndexChanged
        If cmbAuthentication.SelectedIndex = 0 Then
            txtUserName.ReadOnly = True
            txtPassword.ReadOnly = True
            txtUserName.Text = ""
            txtPassword.Text = ""
        End If
        If cmbAuthentication.SelectedIndex = 1 Then
            txtUserName.ReadOnly = False
            txtPassword.ReadOnly = False
        End If
    End Sub

    Private Sub cmbServerName_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbServerName.SelectedIndexChanged
        cmbAuthentication.Enabled = True
        txtServerName.Text = cmbServerName.Text
    End Sub

    Sub Reset()
        txtPassword.Text = ""
        txtUserName.Text = ""
        cmbServerName.Text = ""
        cmbAuthentication.SelectedIndex = 0
    End Sub

    Private Sub btnTestConnection_Click_1(sender As System.Object, e As System.EventArgs) Handles btnTestConnection.Click
        If cmbServerName.Text = "" Then
            MsgBox("Please select/enter Server Name", MsgBoxStyle.Information)
            cmbServerName.Focus()
            Exit Sub
        End If
        If cmbAuthentication.SelectedIndex = 1 Then
            If txtUserName.Text.Length = 0 Then
                MsgBox("please enter user name", MsgBoxStyle.Information)
                txtUserName.Focus()
                Exit Sub
            End If
            If txtPassword.Text.Length = 0 Then
                MsgBox("please enter password", MsgBoxStyle.Information)
                txtPassword.Focus()
                Exit Sub
            End If
        End If
        Cursor = Cursors.WaitCursor
        Timer1.Enabled = True
        Dim SqlConn As New SqlConnection

        If cmbAuthentication.SelectedIndex = 0 Then
            SqlConnStr = "Data Source=" & cmbServerName.Text.Trim & ";Initial Catalog=master;Integrated Security=True"
        End If
        If cmbAuthentication.SelectedIndex = 1 Then
            SqlConnStr = "Data Source=" & cmbServerName.Text.Trim & ";Initial Catalog=master;User ID=" & txtUserName.Text.Trim & ";Password=" & txtPassword.Text & ""
        End If
        If SqlConn.State = ConnectionState.Closed Then
            SqlConn.ConnectionString = SqlConnStr
            Try
                SqlConn.Open()
                MessageBox.Show("Succsessfull DB Connnection", "DB Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Invalid DB SqlConnnection" + vbCrLf + Err.Description, "DB Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


    Private Sub timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Cursor = Cursors.Default
        Timer1.Enabled = False
    End Sub
    Sub CreateBlankDB()
        Try
            sqlCon = New SqlConnection("Data source=" & cmbServerName.Text & ";Initial Catalog=master;Integrated Security=True;MultipleActiveResultSets=True")
            sqlCon.Open()


            Dim cb2 As String = "Select * from sysdatabases where name='0218_DB'"
            cmd = New SqlCommand(cb2)
            cmd.Connection = sqlCon
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                sqlCon = New SqlConnection("Data source=" & cmbServerName.Text & ";Initial Catalog=master;Integrated Security=True;MultipleActiveResultSets=True")
                sqlCon.Open()
                Dim cb1 As String = "Drop Database 0218_DB"
                cmd = New SqlCommand(cb1)
                cmd.Connection = sqlCon
                cmd.ExecuteNonQuery()
                sqlCon.Close()
                sqlCon = New SqlConnection("Data source=" & cmbServerName.Text & ";Initial Catalog=master;Integrated Security=True;MultipleActiveResultSets=True")
                sqlCon.Open()
                Dim cb As String = "Create Database 0218_DB"
                cmd = New SqlCommand(cb)
                cmd.Connection = sqlCon
                cmd.ExecuteNonQuery()
                sqlCon.Close()
                Using sr As StreamReader = New StreamReader(Application.StartupPath & "\BlankDBscript.sql")
                    st = sr.ReadToEnd()
                    Dim server As New Server(New ServerConnection(sqlCon))
                    server.ConnectionContext.ExecuteNonQuery(st)
                End Using
            Else
                sqlCon = New SqlConnection("Data source=" & cmbServerName.Text & ";Initial Catalog=master;Integrated Security=True;MultipleActiveResultSets=True")
                sqlCon.Open()
                Dim cb3 As String = "Create Database 0218_DB"
                cmd = New SqlCommand(cb3)
                cmd.Connection = sqlCon
                cmd.ExecuteNonQuery()
                sqlCon.Close()
                Using sr As StreamReader = New StreamReader(Application.StartupPath & "\BlankDBscript.sql")
                    st = sr.ReadToEnd()
                    Dim server As New Server(New ServerConnection(sqlCon))
                    server.ConnectionContext.ExecuteNonQuery(st)
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If (sqlCon.State = ConnectionState.Open) Then
                sqlCon.Close()
            End If
        End Try
    End Sub

    Private Sub btnBlankDataDB_Click(sender As System.Object, e As System.EventArgs) Handles btnBlankDataDB.Click
        Try
            If cmbServerName.Text = "" Then
                MsgBox("Please Select/Enter Server Name", MsgBoxStyle.Information)
                cmbServerName.Focus()
                Exit Sub
            End If
            If cmbAuthentication.SelectedIndex = 1 Then
                If txtUserName.Text.Length = 0 Then
                    MsgBox("please enter user name", MsgBoxStyle.Information)
                    txtUserName.Focus()
                    Exit Sub
                End If
                If txtPassword.Text.Length = 0 Then
                    MsgBox("please enter password", MsgBoxStyle.Information)
                    txtPassword.Focus()
                    Exit Sub
                End If
            End If
            Cursor = Cursors.WaitCursor
            Timer1.Enabled = True
            If cmbAuthentication.SelectedIndex = 0 Then
                sqlCon = New SqlConnection("Data source=" & cmbServerName.Text & ";Initial Catalog=master;Integrated Security=True;MultipleActiveResultSets=True")
            End If
            If cmbAuthentication.SelectedIndex = 1 Then
                sqlCon = New SqlConnection("Data Source=" & cmbServerName.Text.Trim & ";Initial Catalog=master;User ID=" & txtUserName.Text.Trim & ";Password=" & txtPassword.Text & ";MultipleActiveResultSets=True")
            End If
            sqlCon.Open()
            If (sqlCon.State = ConnectionState.Open) Then
                If MsgBox("It will create the DB and configure the sql server, Do you want to proceed?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then

                    Using sw As StreamWriter = New StreamWriter(Application.StartupPath & "\SQLSettings.dat")
                        If cmbAuthentication.SelectedIndex = 0 Then
                            sw.WriteLine("Data Source=" & cmbServerName.Text.Trim & ";Initial Catalog=0218_DB;Integrated Security=True;MultipleActiveResultSets=True")
                            sw.Close()
                        End If
                        If cmbAuthentication.SelectedIndex = 1 Then
                            sw.WriteLine("Data Source=" & cmbServerName.Text.Trim & ";Initial Catalog=0218_DB;User ID=" & txtUserName.Text.Trim & ";Password=" & txtPassword.Text & ";MultipleActiveResultSets=True")
                            sw.Close()
                        End If
                        'CreateBlankDB()
                        MessageBox.Show("DB has been created and SQL Server setting has been saved successfully..." & vbCrLf & "Application will be closed,Please start it again", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End
                    End Using
                Else
                    End
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Unable to connect to sql server" + vbCrLf + Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If (sqlCon.State = ConnectionState.Open) Then
                sqlCon.Close()
            End If
        End Try
    End Sub

    Private Sub SearchDatabase_Click(sender As Object, e As EventArgs) Handles SearchDatabase.Click
        Try
            Cursor = Cursors.WaitCursor
            Timer1.Enabled = True
            Dim dataTable As DataTable = SmoApplication.EnumAvailableSqlServers(True)
            cmbServerName.ValueMember = "Name"
            cmbServerName.DataSource = dataTable
            Dim serverName As String = cmbServerName.SelectedValue.ToString()
            Dim server As New Server(serverName)
        Catch ex As Exception
            MessageBox.Show("Sorry unable to find SQL Server instance" & vbCrLf & "If you have installed SQL Server then enter name of SQL Server instance manually", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub frmSqlServerSetting_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'End
    End Sub

    Private Sub frmSqlServerSetting_Load(sender As Object, e As EventArgs) Handles Me.Load
        theme.myCustomSkinDark(Me)
        Try

            Cursor = Cursors.WaitCursor
            Timer1.Enabled = True




            If Not System.IO.File.Exists(Application.StartupPath & "\SQLSettings.dat") Then
                File.Create(Application.StartupPath & "\SQLSettings.dat").Dispose()
                Using sw As StreamWriter = New StreamWriter(Application.StartupPath & "\SQLSettings.dat")


                    sw.WriteLine("Data Source=localhost;Initial Catalog=0218_DB;User ID=sa;Password=xxx;MultipleActiveResultSets=True")
                    sw.Close()


                End Using
                Application.Restart()
            End If


        Catch ex As Exception
            MessageBox.Show("Unable to create to sql server settings" + vbCrLf + Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try
    End Sub
End Class
