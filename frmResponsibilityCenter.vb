Imports System.Data.SqlClient
Imports System.Data.DataTable
Imports System.IO
Imports System.Globalization
Public Class frmResponsibilityCenter




    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
            Try
                'If cmfund.Text = "" Then
                '    MessageBox.Show("Please enter Fund name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                '    cmfund.Focus()
                '    Exit Sub
                'End If


                If RCDGV.Rows.Count = 0 Then
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
            Dim cb1 As String = "insert into ResponsibilityCenter(RCID,RCNumber,Office" _
                                    & ") VALUES (@d2,@d3,@d4)"
            cmd = New SqlCommand(cb1)
                cmd.Connection = sqlCon
                ' Prepare command for repeated execution
                cmd.Prepare()
                ' Data to be inserted


                For Each row As DataGridViewRow In RCDGV.Rows
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
            MessageBox.Show("Successfully saved", "Responsibility Center", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Print()
        Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
            RCDGV.DataSource = Nothing

            RCDGV.Rows.Clear()
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

                    If RCDGV.Columns.Count = 0 AndAlso Row1.Count > 0 Then
                        Dim i As Integer
                        For i = 0 To Row1.Count - 1
                            RCDGV.Columns.Add("Column" & i + 1, "Column" & i + 1)
                        Next
                    End If

                    RCDGV.Rows.Add(Row1)
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
            Dim headers = (From header As DataGridViewColumn In RCDGV.Columns.Cast(Of DataGridViewColumn)()
                           Select header.HeaderText).ToArray
            Dim rows = From row As DataGridViewRow In RCDGV.Rows.Cast(Of DataGridViewRow)()
                       Where Not row.IsNewRow
                       Select Array.ConvertAll(row.Cells.Cast(Of DataGridViewCell).ToArray, Function(c) If(c.Value IsNot Nothing, c.Value.ToString, ""))
        Using sw As New IO.StreamWriter("Responsibility-Center-" & System.DateTime.Now.ToString("dddd") & ".csv")
            sw.WriteLine(String.Join("|", headers))
            For Each r In rows
                sw.WriteLine(String.Join("|", r))
            Next
        End Using
        Process.Start("Responsibility-Center-" & System.DateTime.Now.ToString("dddd") & ".csv")
        'ExportExcel(dgw)
    End Sub

    Private Sub frmResponsibilityCenter_Load(sender As Object, e As EventArgs) Handles Me.Load
        theme.myCustomSkinDark(Me)
    End Sub
End Class