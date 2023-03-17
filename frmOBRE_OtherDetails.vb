Imports System.Globalization
Imports System.Data.SqlClient


Public Class frmOBRE_OtherDetails
    Public Sub ShowOBRE()
        OBREDGV.DataSource = ClsConn.LoadData("SELECT OBRE.UID as UID, OBRE.OBREmacco_ID as [OBREmaccoID], OBRE.EntryDate as [Date], OBRE.Payee as Payee,OBRE.TotalAmount as TotalAmount, ID as ID" _
                                             & " from OBRE order by UID desc").DefaultView
    End Sub
    Private Sub frmOBRE_OtherDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        theme.myCustomSkinDark(Me)
        ShowOBRE()
    End Sub
    Private Sub txtSearchCOA_TextChanged(sender As Object, e As EventArgs) Handles txtSearchARO.TextChanged
        Dim searchString As String = txtSearchARO.Text
        Dim str As String = String.Format("SELECT OBRE.UID as UID, OBRE.OBREmacco_ID as [OBREmaccoID], OBRE.EntryDate as [Date], OBRE.Payee as Payee,OBRE.TotalAmount as TotalAmount, ID as ID" _
                                             & " from OBRE  WHERE OBREmacco_ID like '%{0}%' OR Payee like '%{0}%' order by UID desc", searchString)
        OBREDGV.DataSource = ClsConn.LoadData(str).DefaultView

    End Sub

    Private Sub OBREDGV_MouseClick(sender As Object, e As MouseEventArgs) Handles OBREDGV.MouseClick
        Try
            If OBREDGV.Rows.Count > 0 Then
                Dim dr As DataGridViewRow = OBREDGV.SelectedRows(0)

                frmOBRE.uid = dr.Cells(0).Value.ToString()
                frmOBRE.txtOBREmacco_ID.Text = dr.Cells(1).Value.ToString()
                frmOBRE.txtDate.Text = dr.Cells(2).Value.ToString()
                frmOBRE.txtPayee.Text = dr.Cells(3).Value.ToString()
                frmOBRE.totalamount = dr.Cells(4).Value.ToString()
                frmOBRE.id = dr.Cells(5).Value.ToString()







                'frmAdvice.btnSave.Enabled = False
                'frmAdvice.btnDelete.Enabled = True
                'frmAdvice.btnUpdate.Enabled = True
                'frmAdvice.btnPrint.Enabled = True
                'frmAdvice.btnRemove.Enabled = False
                'frmAdvice.save.Enabled = False

                ' Fetch the latest ID from the database
                If (ClsConn.OpenConnection() = True) Then


                    Dim sql As String = "

Select RTRIM(OBRE.ID), RTRIM(OBRE_OtherDetails.ID),RTRIM(OBRE.OBREmacco_ID),RTRIM(OBRE_OtherDetails.ResCenter),RTRIM(OBRE_OtherDetails.Particulars),RTRIM(OBRE_OtherDetails.AccountCode)" _
                    & ",RTRIM(OBRE_OtherDetails.Amount),RTRIM(OBRE_OtherDetails.UID) from OBRE inner join OBRE_OtherDetails on OBRE.ID=OBRE_OtherDetails.ID where obre.uid=" & dr.Cells(0).Value & ""
                    cmd = New SqlCommand(sql, sqlCon)
                    frmOBRE.OBREDGV.DataSource = Nothing
                    frmOBRE.OBREDGV.Rows.Clear()
                    rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                    While (rdr.Read() = True)
                        Dim value6 As Double = rdr(6)
                        Dim formattedValue6 As String = value6.ToString("N2", CultureInfo.InvariantCulture)
                        frmOBRE.OBREDGV.Rows.Add(rdr(3), rdr(4), rdr(5), formattedValue6, rdr(7))
                    End While
                    If frmOBRE.OBREDGV.Columns(3).Name = "Amount" Then
                        Dim runningTotal As Decimal = 0
                        For i As Integer = 0 To frmOBRE.OBREDGV.Rows.Count - 1
                            If Not frmOBRE.OBREDGV.Rows(i).IsNewRow Then
                                Dim cellValue As Decimal
                                If Decimal.TryParse(frmOBRE.OBREDGV.Rows(i).Cells("Amount").Value.ToString(), cellValue) Then
                                    runningTotal += cellValue
                                Else
                                    ' Handle invalid input
                                End If

                            End If
                        Next
                        frmOBRE.OBREDGV.Rows(frmOBRE.OBREDGV.Rows.Count - 1).Cells("Amount").Value = String.Format("{0:N2}", runningTotal)
                    End If

                    frmOBRE.OBREDGV.Enabled = True
                    'frmOBRE.OBREDGV.Columns(0).ReadOnly = True
                    'frmOBRE.OBREDGV.Columns(1).ReadOnly = True
                    'frmOBRE.OBREDGV.Columns(2).ReadOnly = True
                    'frmOBRE.OBREDGV(3, frmOBRE.OBREDGV.Rows.Count - 1).ReadOnly = True

                    Me.Close()
                    ClsConn.CloseConnection()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class