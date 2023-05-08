Imports System.Data.SqlClient

Public Class ClsResponsibilityCenter
    Public Sub updateResponsilibityCenter(DataGridView As DataGridView)
        If (ClsConn.OpenConnection() = True) Then
            cmd = New SqlCommand("
            MERGE INTO ResponsibilityCenter AS target
            USING (VALUES (@RCID, @RCNumber, @Office, @OfficeGroup,@UID)) AS source (RCID, RCNumber, Office, OfficeGroup,UID)
                ON COALESCE(target.UID, '') = COALESCE(source.UID, '')
            WHEN MATCHED THEN
                UPDATE SET target.RCID = source.RCID, target.RCNumber = source.RCNumber, target.Office = source.Office , target.OfficeGroup = source.OfficeGroup
            WHEN NOT MATCHED THEN
                INSERT ( RCID, RCNumber, Office,OfficeGroup) VALUES ( source.RCID, source.RCNumber, source.Office,source.OfficeGroup);
        ", sqlCon)

            For Each row As DataGridViewRow In DataGridView.Rows
                If Not row.IsNewRow Then
                    cmd.Parameters.AddWithValue("@UID", If(String.IsNullOrEmpty(row.Cells(4).Value), DBNull.Value, row.Cells(4).Value))

                    cmd.Parameters.AddWithValue("@RCID", row.Cells(0).Value)




                    cmd.Parameters.AddWithValue("@RCNumber", row.Cells(1).Value)

                    cmd.Parameters.AddWithValue("@Office", row.Cells(2).Value.ToString)
                    cmd.Parameters.AddWithValue("@OfficeGroup", row.Cells(3).Value.ToString)

                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()
                End If
            Next
            ClsConn.CloseConnection()


        End If
    End Sub
    Public Sub deleteResponsibilityCenter(ByVal id As String)
        If (ClsConn.OpenConnection() = True) Then
            cmd = New SqlCommand("delete from ResponsibilityCenter where UID=@UID", sqlCon)
            cmd.Parameters.AddWithValue("@UID", id)
            cmd.ExecuteNonQuery()
            ClsConn.CloseConnection()
        End If
    End Sub

End Class
