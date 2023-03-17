
Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.IO
Imports System.Globalization
Imports Bunifu.UI.WinForms
Imports Microsoft.Office.Interop.Excel
Imports System.Windows.Input
Imports Microsoft.VisualBasic.Devices
Imports CrystalDecisions.ReportAppServer.DataDefModel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmChartofAccounts

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If COADGV.Rows.Count = 0 Then
                MessageBox.Show("sorry no data added to grid", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            'con = New SqlConnection(cs)
            'con.Open()
            'Dim cb As String = "insert into RCIIndex(Id, IndexType, DateCreated, FundType) Values (@d1,@d2,@d3,@d4)"
            'cmd = New SqlCommand(cb)
            'cmd.Parameters.AddWithValue("@d1", Val(txtid.Text))
            'cmd.Parameters.AddWithValue("@d2", txtindexype.Text)
            'cmd.Parameters.AddWithValue("@d3", dtpDate.Text)
            'cmd.Parameters.AddWithValue("@d4", cmfund.Text)


            'cmd.Connection = con
            'cmd.ExecuteReader()
            'con.Close()
            sqlCon = New SqlConnection(cs)
            sqlCon.Open()
            Dim cb1 As String = "insert into ChartOfAccounts(AID,Account_Code,Account_Title" _
                                    & ") VALUES (@d2,@d3,@d4)"
            cmd = New SqlCommand(cb1)
            cmd.Connection = sqlCon
            ' Prepare command for repeated execution
            cmd.Prepare()
            ' Data to be inserted


            For Each row As DataGridViewRow In COADGV.Rows
                If Not row.IsNewRow Then
                    cmd.Parameters.AddWithValue("@d2", row.Cells(0).Value)
                    cmd.Parameters.AddWithValue("@d3", row.Cells(1).Value)
                    cmd.Parameters.AddWithValue("@d4", row.Cells(2).Value)

                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()
                End If
            Next
            sqlCon.Close()
            'Dim st As String = "added the new ChartOfAccounts having DV no.'" & txtdvno.Text & "'"
            'LogFunc(lblUser.Text, st)
            ' LedgerSave(dtpDate.Value.Date, txtAdviceName.Text, txtAdviceNo.Text, "Expenses", Val(txtGrandTotal.Text), 0, "")
            btnSave.Enabled = False
            MessageBox.Show("Successfully saved", "ChartOfAccounts", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Print()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        COADGV.DataSource = Nothing

        COADGV.Rows.Clear()

    End Sub

    Private Sub btnimport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Try
            Dim selectedfile As String = ""
            OpenFileDialog1.ShowDialog()
            selectedfile = Path.GetFullPath(OpenFileDialog1.FileName)
            Dim TextFieldParser1 As New Microsoft.VisualBasic.FileIO.TextFieldParser(selectedfile)
            TextFieldParser1.Delimiters = New String() {"|"}
            While Not TextFieldParser1.EndOfData
                Dim Row1 As String() = TextFieldParser1.ReadFields()

                If COADGV.Columns.Count = 0 AndAlso Row1.Count > 0 Then
                    Dim i As Integer
                    For i = 0 To Row1.Count - 1
                        COADGV.Columns.Add("Column" & i + 1, "Column" & i + 1)
                    Next
                End If

                COADGV.Rows.Add(Row1)
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim headers = (From header As DataGridViewColumn In COADGV.Columns.Cast(Of DataGridViewColumn)()
                       Select header.HeaderText).ToArray
        Dim rows = From row As DataGridViewRow In COADGV.Rows.Cast(Of DataGridViewRow)()
                   Where Not row.IsNewRow
                   Select Array.ConvertAll(row.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot Nothing, c.Value.ToString, ""))
        Using sw As New IO.StreamWriter("Chart-of-Accounts-" & System.DateTime.Now.ToString("dddd") & ".csv")
            sw.WriteLine(String.Join("|", headers))
            For Each r In rows
                sw.WriteLine(String.Join("|", r))
            Next
        End Using
        Process.Start("Chart-of-Accounts-" & System.DateTime.Now.ToString("dddd") & ".csv")
        'ExportExcel(dgw)
    End Sub

    'Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
    '    Try
    '    For Each row As DataGridViewRow In BunifuDataGridView1.SelectedRows
    '        BunifuDataGridView1.Rows.Remove(row)
    '        BunifuDataGridView1.Refresh()
    '        '' DataGridView1.Rows.RemoveAt(index) the other way
    '    Next



    'Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub
    Public COAsearchString As String = ""
    Private Sub loadChartofAccounts()
        Try
            'Dim strStart As String = COAsearchString
            'Dim inputString As String = txtSearchCOA.Text
            'Dim strSearch As String = strStart & inputString
            ' If (ClsConn.OpenConnection() = True) Then

            'With COADGV
            '    Dim str As String = String.Format("SELECT  Account_Code as Account_Code, Account_Title as Account_Title FROM ChartOfAccounts WHERE Account_Code like '%{0}%' order by AID desc", COAsearchString)

            '    .DataSource = ClsConn.LoadData(str)
            'End With
            With COADGV
                Dim str As String = String.Format("SELECT  Account_Code as Account_Code, Account_Title as Account_Title FROM ChartOfAccounts WHERE Account_Code like @search order by AID desc")

                .DataSource = ClsConn.LoadDataWithSearch(str, COAsearchString, txtSearchCOA.Text)
            End With

            'End If

            ' lblTotalStudents.Text = ClsConn.CountRec("SELECT COUNT(idparticipant) as students FROM participants")

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            ClsConn.CloseConnection()
        End Try
    End Sub

    Private Sub frmChartofAccounts_Load(sender As Object, e As EventArgs) Handles Me.Load
        'ClsConn.CloseConnection()
        'ClsConn.OpenConnection()
        theme.myCustomSkinDark(Me)
        'dCOADGV.Columns.Clear()
        loadChartofAccounts()

        'Loader.Show()
        ' Me.Enabled = False
        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'loadChartofAccounts()
        'Loader.Close()

        Timer1.Enabled = False

        'Me.Enabled = True
    End Sub



    Private Sub txtSearchCOA_TextChanged(sender As Object, e As EventArgs) Handles txtSearchCOA.TextChanged
        'Dim searchString As String = frmARO.txtFundCode.Text.Remove(0, 1) & "-" & txtSearchCOA.Text
        'Dim str As String = String.Format("SELECT  Account_Code as Account_Code, Account_Title as Account_Title FROM ChartOfAccounts WHERE Account_Code like '%{0}%' OR Account_Title like '%{0}%' order by AID desc", searchString)
        'COADGV.DataSource = ClsConn.LoadData(str).DefaultView
        'Dim strStart As String = "5-01"
        'Dim inputString As String = txtSearchCOA.Text
        'Dim strSearch As String = COAsearchString & inputString
        With COADGV
            Dim str As String = String.Format("SELECT  Account_Code as Account_Code, Account_Title as Account_Title FROM ChartOfAccounts WHERE Account_Code like @search order by AID desc")

            .DataSource = ClsConn.LoadDataWithSearch(str, COAsearchString, txtSearchCOA.Text)
        End With
    End Sub

    Private Sub COADGV_MouseClick(sender As Object, e As MouseEventArgs) Handles COADGV.MouseClick
        Try
            If COADGV.Rows.Count > 0 Then
                frmARO.ARODGV.SelectedCells(0).Value = Me.COADGV.SelectedCells(0).Value.ToString
                frmARO.ARODGV.SelectedCells(1).Value = Me.COADGV.SelectedCells(1).Value.ToString
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtSearchCOA_Click(sender As Object, e As EventArgs) Handles txtSearchCOA.Click

    End Sub
End Class