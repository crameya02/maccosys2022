Imports System.Data.SqlClient
Imports System.IO
Imports Bunifu.UI.WinForms
Imports CrystalDecisions.ReportAppServer.DataDefModel
Imports MaterialSkin.Controls
Imports Microsoft.Office.Interop.Excel

Public Class DashBoard
    Function countObreCurrent() As Integer

        Dim result As Integer = ClsConn.CountRecWithDate("SELECT COUNT(uid) AS UID FROM OBRE_OtherDetails where EntryDate between @datefrom and @dateto;", GetCurrentMonthDates(DateTime.Today).currentBeginningDate, GetCurrentMonthDates(DateTime.Today).currentEndingDate)
        Return result
    End Function
    Dim previousObrePercent As String = ""
    Function countObrePrevious() As Integer

        Dim result As Integer = ClsConn.CountRecWithDate("SELECT COUNT(uid) AS UID FROM OBRE_OtherDetails where EntryDate between @datefrom and @dateto;", GetCurrentMonthDates(DateTime.Today).previousBeginningDate, GetCurrentMonthDates(DateTime.Today).previousEndingDate)
        Return result
    End Function
    Function getpercentagediff() As String
        Dim currentValue As Integer = countObreCurrent()
        Dim previousValue As Integer = countObrePrevious()

        Dim percentageChange As Double = ((currentValue - previousValue) / previousValue) * 100

        Dim changeText As String = ""
        If percentageChange < 0 Then
            changeText = $"{Math.Abs(percentageChange)}% less than previous month"
        ElseIf percentageChange > 0 Then
            changeText = $"{percentageChange}% more than previous month"
        Else
            changeText = "no change from previous month"
        End If

        'Console.WriteLine(changeText)
        Return changeText
    End Function
    Sub InitializeCardsRefactored()
        lblObre.Text = countObreCurrent.ToString()
        obresubtitle.Text = getpercentagediff()
        ' Obligations and Unobligated Balances
        balancesSubtitle.Text = $"P {ClsConn.getSAAOB_Balances("01/01/{ReadWorkingYear()}", GetCurrentMonthDates(DateTime.Today).currentEndingDate).GrandTotalObli} of P {ClsConn.getSAAOB_Balances("01/01/{ReadWorkingYear()}", GetCurrentMonthDates(DateTime.Today).currentEndingDate).GrandTotalUnobli}"
        lblBalancePercent.Text = ""
        lblbalancepercent2.Text = ""

        Dim prefObli As Decimal = Decimal.Zero
        If Decimal.TryParse(ClsConn.getSAAOB_Balances("01/01/{ReadWorkingYear()}", GetCurrentMonthDates(DateTime.Today).currentEndingDate).GrandTotalObli, prefObli) Then
            Dim suffixObli As Decimal = Decimal.Zero
            If Decimal.TryParse(ClsConn.getSAAOB_Balances("01/01/{ReadWorkingYear()}", GetCurrentMonthDates(DateTime.Today).currentEndingDate).GrandTotalUnobli, suffixObli) Then
                If suffixObli = 0 Then
                    lblBalancePercent.Text = "0"
                    lblbalancepercent2.Text = "%"
                    Exit Sub
                End If
                Dim result As Decimal = (prefObli / suffixObli) * 100
                lblBalancePercent.Text = Math.Truncate(result).ToString()

                Dim decimalPart As Integer = CInt((result - Math.Truncate(result)) * 100)
                lblbalancepercent2.Text = $".{decimalPart.ToString("00")}%"
            End If
        End If

        ' Allotment and Appropriation
        allotsubtitle.Text = $"P {ClsConn.getSAAOB_Balances("01/01/{ReadWorkingYear()}", GetCurrentMonthDates(DateTime.Today).currentEndingDate).GrandTotalAllot} of P {ClsConn.getSAAOB_Balances("01/01/{ReadWorkingYear()}", GetCurrentMonthDates(DateTime.Today).currentEndingDate).GrandTotalAppro}"
        allotpercent.Text = ""
        allotpercent2.Text = ""

        Dim prefAllot As Decimal = Decimal.Zero
        If Decimal.TryParse(ClsConn.getSAAOB_Balances("01/01/{ReadWorkingYear()}", GetCurrentMonthDates(DateTime.Today).currentEndingDate).GrandTotalAllot, prefAllot) Then

            Dim suffixAppro As Decimal = Decimal.Zero
            If Decimal.TryParse(ClsConn.getSAAOB_Balances("01/01/{ReadWorkingYear()}", GetCurrentMonthDates(DateTime.Today).currentEndingDate).GrandTotalAppro, suffixAppro) Then
                If suffixAppro = 0 Then
                    allotpercent.Text = "0"
                    allotpercent2.Text = "%"
                    Exit Sub
                End If
                Dim result1 As Decimal = (prefAllot / suffixAppro) * 100
                allotpercent.Text = Math.Truncate(result1).ToString()
                Dim decimalPart1 As Integer = CInt((result1 - Math.Truncate(result1)) * 100)
                allotpercent2.Text = $".{decimalPart1.ToString("00")}%"

            End If
        End If

    End Sub
    Sub initializeCards()
        lblObre.Text = ""
        lblObre.Text = countObreCurrent.ToString
        obresubtitle.Text = ""
        obresubtitle.Text = getpercentagediff()


        'for Obligations and Unobligated Balances
        balancesSubtitle.Text = ""
        Dim prefObli As String = ClsConn.getSAAOB_Balances("01/01/" & ReadWorkingYear(), GetCurrentMonthDates(DateTime.Today).currentEndingDate).GrandTotalObli.ToString
        Dim suffixObli As String = ClsConn.getSAAOB_Balances("01/01/" & ReadWorkingYear(), GetCurrentMonthDates(DateTime.Today).currentEndingDate).GrandTotalUnobli.ToString
        balancesSubtitle.Text = "P " & prefObli & " of P " & suffixObli
        lblBalancePercent.Text = ""
        lblbalancepercent2.Text = ""

        Dim value As Decimal
        If Decimal.Parse(prefObli) Then
            ' Conversion successful, decValue contains the parsed value
            value = Decimal.Parse(prefObli)
        End If
        Dim total As Decimal
        If Decimal.Parse(suffixObli) Then
            ' Conversion successful, decValue contains the parsed value
            total = Decimal.Parse(suffixObli)
        End If
        If value = 0 Then
            lblBalancePercent.Text = "0"
            lblbalancepercent2.Text = ".%"
        Else
            Dim result As Decimal = (value / total) * 100
            Dim numberString As String = result.ToString("0.00")
            Dim numberParts() As String = numberString.Split("."c)
            Dim wholeNumberPart As String = numberParts(0)
            Dim decimalPart As String = numberParts(1)

            lblBalancePercent.Text = wholeNumberPart
            lblbalancepercent2.Text = "." & decimalPart & "%"
        End If



        'for Allotment and Appropriation
        allotsubtitle.Text = ""
        Dim prefAllot As String = ClsConn.getSAAOB_Balances("01/01/" & ReadWorkingYear(), GetCurrentMonthDates(DateTime.Today).currentEndingDate).GrandTotalAllot.ToString
        Dim suffixAppro As String = ClsConn.getSAAOB_Balances("01/01/" & ReadWorkingYear(), GetCurrentMonthDates(DateTime.Today).currentEndingDate).GrandTotalAppro.ToString
        allotsubtitle.Text = "P " & prefAllot & " of P " & suffixAppro
        allotpercent.Text = ""
        allotpercent2.Text = ""

        Dim value1 As Decimal
        If Decimal.Parse(prefAllot) Then
            ' Conversion successful, decValue contains the parsed value
            value1 = Decimal.Parse(prefAllot)
        End If
        Dim total1 As Decimal
        If Decimal.Parse(suffixAppro) Then
            ' Conversion successful, decValue contains the parsed value
            total1 = Decimal.Parse(suffixAppro)
        End If
        If value1 = 0 Then
            allotpercent.Text = "0"
            allotpercent2.Text = ".%"
        Else
            Dim result1 As Decimal = (value1 / total1) * 100
            Dim numberString1 As String = result1.ToString("0.00")
            Dim numberParts1() As String = numberString1.Split("."c)
            Dim wholeNumberPart1 As String = numberParts1(0)
            Dim decimalPart1 As String = numberParts1(1)

            allotpercent.Text = wholeNumberPart1
            allotpercent2.Text = "." & decimalPart1 & "%"
        End If

    End Sub
    Private Sub DashBoardTabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DashBoardTabControl.SelectedIndexChanged

        If DashBoardTabControl.SelectedIndex = 0 Then
            Me.Text = "Home"
            'initializeCards()
            InitializeCardsRefactored()
        End If
        If DashBoardTabControl.SelectedIndex = 1 Then
            Me.Text = "RAAO"
            frmARO_Option.ShowDialog()
        End If
        If DashBoardTabControl.SelectedIndex = 2 Then
            FlowLayoutPanel1.Controls.Clear()
            Me.Text = "Obligation Request"
            'frmOBRE.WindowState = FormWindowState.Maximized
            'frmOBRE.ARODGV.Columns(0).Visible = True
            'frmOBRE.FormStyle = FormStyles.StatusAndActionBar_None
            FormToDisplay(frmOBRE, FlowLayoutPanel1)
        End If
        If DashBoardTabControl.SelectedIndex = 3 Then
            FlowLayoutPanel2.Controls.Clear()
            'frmOBRE.WindowState = FormWindowState.Maximized
            'frmOBRE.ARODGV.Columns(0).Visible = True
            'frmOBRE.FormStyle = FormStyles.StatusAndActionBar_None
            FormToDisplay(frmSAAOB, FlowLayoutPanel2)
            Me.Text = "SAAOB"
        End If
        If DashBoardTabControl.SelectedIndex = 4 Then
            Me.Text = "Responsibility Center"

            FlowLayoutPanel3.Controls.Clear()
            FormToDisplay(frmManageResponsibilityCenter, FlowLayoutPanel3)
        End If
        If DashBoardTabControl.SelectedIndex = 5 Then
            Me.Text = "Account Codes"
            FlowLayoutPanel4.Controls.Clear()
            FormToDisplay(frmManageChartofAccounts, FlowLayoutPanel4)
        End If

        If DashBoardTabControl.SelectedIndex = 6 Then
            'frmResponsibilityCenter.WindowState = FormWindowState.Maximized
            'frmResponsibilityCenter.RCDGV.Columns(0).Visible = True
            'frmResponsibilityCenter.FormStyle = FormStyles.StatusAndActionBar_None
            'FormToDisplay(frmResponsibilityCenter, FlowLayoutPanel5)
            Me.Text = "Application Info."
        End If
        If DashBoardTabControl.SelectedIndex = 7 Then
            'frmChartofAccountsV2.WindowState = FormWindowState.Maximized
            ''frmChartofAccounts.COADGV.Columns(0).Visible = True
            'frmChartofAccountsV2.FormStyle = FormStyles.StatusAndActionBar_None
            'FormToDisplay(frmChartofAccountsV2, FlowLayoutPanel6)
            Me.Text = "Settings"
            txtYear.Clear()
            txtYear.Text = ReadWorkingYear()
        End If
    End Sub
    Private Sub DashBoard_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        Dim forms As Form() = {
            frmARO,
            frmARO_Allotment,
            frmARO_Adjustments,
            frmOBRE,
            frmManageResponsibilityCenter,
            frmManageChartofAccounts,
            frmSAAOB,
            frmReport
        }

        For Each form As Form In forms
            form.Size = FlowLayoutPanel0.Size
        Next

    End Sub
    Private Sub DashBoard_Load(sender As Object, e As EventArgs) Handles Me.Load
        theme.myCustomSkinDark(Me)
        Me.Size = New Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height)
        initializeCards()
        ' InitializeCardsRefactored()
    End Sub



    Private Sub MaterialLabel14_Click(sender As Object, e As EventArgs) Handles MaterialLabel14.Click

    End Sub

    Private Sub btnManageUser_Click(sender As Object, e As EventArgs) Handles btnManageUser.Click
        Dim manageUser As New ClsLogin
        With manageUser
            .username = login.UserID.Text
            .password = login.Password.Text
            .USER_LOOKUP()

            If .userRole = "Admin" Then
                '    MsgBox(.userRole)
                '    'manageUsers.ShowDialog()
                '    Exit Sub
                'Else

                If panelChangePassword.Collapse = True Then
                    panelChangePassword.Collapse = False
                Else
                    panelChangePassword.Collapse = True
                End If
            End If
        End With
    End Sub
    Private Sub panelChangePassword_SaveClick(sender As Object, e As EventArgs) Handles panelChangePassword.SaveClick
        Try



            If Len(Trim(txtoldpassword.Text)) = 0 Then
                MessageBox.Show("Please enter old password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtoldpassword.SelectAll()
                txtoldpassword.Focus()
                Exit Sub
            End If
            If Len(Trim(txtnewpassword.Text)) = 0 Then
                MessageBox.Show("Please enter new password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtnewpassword.SelectAll()
                txtnewpassword.Focus()
                Exit Sub
            End If
            If Len(Trim(txtconfirmpassword.Text)) = 0 Then
                MessageBox.Show("Please confirm new password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtconfirmpassword.SelectAll()
                txtconfirmpassword.Focus()
                Exit Sub
            End If
            If txtnewpassword.TextLength < 5 Then
                MessageBox.Show("The New Password Should be of Atleast 5 Characters", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtnewpassword.Text = ""
                txtconfirmpassword.Text = ""
                txtnewpassword.SelectAll()
                txtnewpassword.Focus()
                Exit Sub
            ElseIf txtnewpassword.Text <> txtconfirmpassword.Text Then
                MessageBox.Show("Password do not match", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtnewpassword.Text = ""
                txtoldpassword.Text = ""
                txtconfirmpassword.Text = ""
                txtconfirmpassword.SelectAll()
                txtconfirmpassword.Focus()
                Exit Sub
            ElseIf txtoldpassword.Text = txtnewpassword.Text Then
                MessageBox.Show("Password is same..Re-enter new password", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtnewpassword.Text = ""
                txtconfirmpassword.Text = ""
                txtnewpassword.SelectAll()
                txtnewpassword.Focus()
                Exit Sub
            End If
            Dim userCredential As New ClsLogin
            With userCredential
                .username = login.UserID.Text
                .password = txtnewpassword.Text
                .oldpassword = txtoldpassword.Text
                .updatePassword()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MaterialExpansionPanel1_SaveClick(sender As Object, e As EventArgs) Handles MaterialExpansionPanel1.SaveClick
        Dim defaultAppPath As String = Path.Combine(Directory.GetCurrentDirectory(), "Setting")

        Dim backUpPath As String = defaultAppPath
        Dim mySettings As String = backUpPath & "\Settings.ini"
        Dim objIniFile As New ClsIni(mySettings)
        If (Not System.IO.Directory.Exists(backUpPath)) Then
            System.IO.Directory.CreateDirectory(backUpPath)
        End If
        If Not System.IO.File.Exists(mySettings) Then
            System.IO.File.Create(mySettings).Dispose()
        End If
        Dim readYear As String = objIniFile.GetString("SAAOB", "year", "")

        If readYear = "" Then
            objIniFile.WriteString("SAAOB", "year", Now.Year.ToString)

            readYear = objIniFile.GetString("SAAOB", "year", "")

        Else
            objIniFile.WriteString("SAAOB", "year", txtYear.Text)

        End If


        Dim SnackBarMessage As MaterialSnackBar = New MaterialSnackBar("SAAOB settings successfully modified.", 750)
        SnackBarMessage.Show(Me)
    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click

        If MaterialExpansionPanel2.Collapse = False Then
            MaterialExpansionPanel2.Collapse = True
        Else
            MaterialExpansionPanel2.Collapse = False
        End If

    End Sub
    Private Sub btnServerSetting_Click(sender As Object, e As EventArgs) Handles btnServerSetting.Click
        If pnlDBsetting.Collapse = False Then
            pnlDBsetting.Collapse = True
        Else
            pnlDBsetting.Collapse = False
        End If
    End Sub

    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs) Handles MaterialButton2.Click
        If MaterialExpansionPanel1.Collapse = False Then
            MaterialExpansionPanel1.Collapse = True
        Else
            MaterialExpansionPanel1.Collapse = False
        End If
    End Sub
    Public Sub Backup()
        Try
            Dim dt As DateTime = Today
            Dim destdir As String = "0218_DB" & ".bak"
            'old destdir  Dim destdir As String = "0218_DB " & System.DateTime.Now.ToString("dd-MM-yyyy_h-mm-ss") & ".bak"
            Dim objdlg As New SaveFileDialog
            objdlg.FileName = destdir
            objdlg.ShowDialog()
            Dim Filename As String = objdlg.FileName

            'Timer2.Enabled = True
            sqlCon = New SqlConnection(cs)
            sqlCon.Open()
            Dim cb As String = "backup database [0218_DB] to disk='" & Filename & "'with init,stats=10"
            cmd = New SqlCommand(cb)
            cmd.Connection = sqlCon
            cmd.ExecuteReader()
            sqlCon.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        Backup()
    End Sub

    Sub restore()

        Dim SessionLoginforDB As New ClsLogin
        With SessionLoginforDB
            .username = login.UserID.Text
            .password = login.Password.Text
            .USER_LOOKUP()


            If .userRole <> "Admin" Then

                Exit Sub

            Else

                Try
                    With OpenFileDialog1
                        .Filter = ("DB Backup File|*.bak;")
                        .FilterIndex = 4
                    End With
                    'Clear the file name
                    OpenFileDialog1.FileName = ""

                    If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                        Cursor = Cursors.WaitCursor
                        ' Timer2.Enabled = True
                        SqlConnection.ClearAllPools()
                        sqlCon = New SqlConnection(cs)
                        sqlCon.Open()
                        Dim cb As String = "USE Master ALTER DATABASE [0218_DB] SET Single_User WITH Rollback Immediate Restore database [0218_DB] FROM disk='" & OpenFileDialog1.FileName & "' WITH REPLACE ALTER DATABASE [0218_DB] SET Multi_User "
                        cmd = New SqlCommand(cb)
                        cmd.Connection = sqlCon
                        cmd.ExecuteReader()
                        sqlCon.Close()
                        Dim st As String = "Sucessfully performed the restore"

                        MessageBox.Show("Successfully performed", "Database Restore", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If




                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End With
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        restore()
    End Sub

    Private Sub BunifuPictureBox2_Click(sender As Object, e As EventArgs) Handles BunifuPictureBox2.Click

    End Sub
End Class