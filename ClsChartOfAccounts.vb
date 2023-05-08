Imports System.Data.SqlClient

Public Class ClsChartOfAccounts
    Public Sub updateChartOfAccounts(DataGridView As DataGridView)
        If (ClsConn.OpenConnection() = True) Then
            cmd = New SqlCommand("
            MERGE INTO ChartOfAccounts AS target
            USING (VALUES (@AID, @AccountCode, @AccountTitle,@UID)) AS source (AID, Account_Code, Account_Title,UID)
                ON COALESCE(target.UID, '') = COALESCE(source.UID, '')
            WHEN MATCHED THEN
                UPDATE SET target.AID = source.AID, target.Account_Code = source.Account_Code, target.Account_Title = source.Account_Title 
            WHEN NOT MATCHED THEN
                INSERT ( AID, Account_Code, Account_Title) VALUES ( source.AID, source.Account_Code,source.Account_Title);
        ", sqlCon)

            For Each row As DataGridViewRow In DataGridView.Rows
                If Not row.IsNewRow Then
                    cmd.Parameters.AddWithValue("@UID", If(String.IsNullOrEmpty(row.Cells(3).Value), DBNull.Value, row.Cells(3).Value))

                    cmd.Parameters.AddWithValue("@AID", row.Cells(0).Value)




                    cmd.Parameters.AddWithValue("@AccountCode", row.Cells(1).Value)

                    cmd.Parameters.AddWithValue("@AccountTitle", row.Cells(2).Value.ToString)


                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()
                End If
            Next
            ClsConn.CloseConnection()


        End If
    End Sub
    Public Sub deleteChartOfAccounts(ByVal id As String)
        If (ClsConn.OpenConnection() = True) Then
            cmd = New SqlCommand("delete from ChartOfAccounts where UID=@UID", sqlCon)
            cmd.Parameters.AddWithValue("@UID", id)
            cmd.ExecuteNonQuery()
            ClsConn.CloseConnection()
        End If
    End Sub
End Class
