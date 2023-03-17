Imports System.Data.SqlClient
Imports System.Text
Imports TheArtOfDev.HtmlRenderer.Adapters

Public Class ClsOBRE
    Public Property UID As Integer
    Public Property ID As String
    Public Property OBREmacco_ID As String
    Public Property OBREmbo_ID As String
    Public Property OBRE_NO As String
    Public Property EntryDate As String
    Public Property Payee As String
    Public Property OfficeName As String
    Public Property TotalAmount As String
    Public Property ResCenter As String
    Public Property Particulars As String
    Public Property AccountCode As String
    Public Property Amount As String

    Public Sub save(DataGridView As DataGridView)
        If (ClsConn.OpenConnection() = True) Then
            'Dim mstream As New System.IO.MemoryStream()
            'manageStudents.pbImage.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            'arrImage = mstream.GetBuffer()
            'Dim FileSize As UInt32
            'FileSize = mstream.Length
            'mstream.Close()

            cmd = New SqlCommand("INSERT INTO OBRE VALUES(@ID,@OBREmacco_ID, @OBREmbo_ID, @OBRE_NO, @EntryDate,@Payee, @OfficeName,@TotalAmount)", sqlCon)
            cmd.Parameters.AddWithValue("@ID", ID)
            cmd.Parameters.AddWithValue("@OBREmacco_ID", OBREmacco_ID)
            cmd.Parameters.AddWithValue("@OBREmbo_ID", OBREmbo_ID)
            cmd.Parameters.AddWithValue("@OBRE_NO", OBRE_NO)
            cmd.Parameters.AddWithValue("@EntryDate", EntryDate)
            cmd.Parameters.AddWithValue("@Payee", Payee)
            cmd.Parameters.AddWithValue("@OfficeName", OfficeName)
            cmd.Parameters.AddWithValue("@TotalAmount", TotalAmount)
            cmd.ExecuteNonQuery()

            cmd = New SqlCommand("INSERT INTO OBRE_OtherDetails VALUES(@ID,@OBREmacco_ID, @OBREmbo_ID, @OBRE_NO,@EntryDate, @Payee, @OfficeName,@ResCenter,@Particulars,@AccountCode,@Amount)", sqlCon)
            cmd.Prepare()

            For Each row As DataGridViewRow In DataGridView.Rows
                If Not row.IsNewRow Then
                    cmd.Parameters.AddWithValue("@ID", ID)
                    cmd.Parameters.AddWithValue("@OBREmacco_ID", OBREmacco_ID)
                    cmd.Parameters.AddWithValue("@OBREmbo_ID", OBREmbo_ID)
                    cmd.Parameters.AddWithValue("@OBRE_NO", OBRE_NO)
                    cmd.Parameters.AddWithValue("@EntryDate", EntryDate)
                    cmd.Parameters.AddWithValue("@Payee", Payee)
                    cmd.Parameters.AddWithValue("@OfficeName", OfficeName)
                    cmd.Parameters.AddWithValue("@ResCenter", row.Cells(0).Value.ToString())
                    cmd.Parameters.AddWithValue("@Particulars", row.Cells(1).Value.ToString())
                    cmd.Parameters.AddWithValue("@AccountCode", row.Cells(2).Value.ToString())
                    cmd.Parameters.AddWithValue("@Amount", row.Cells(3).Value.ToString.Replace(",", ""))
                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()
                End If
            Next

            ClsConn.CloseConnection()
        End If
    End Sub
    'changed to merge statement to handle both update and insert 
    Public Sub updateOBRE(DataGridView As DataGridView)

        If (ClsConn.OpenConnection() = True) Then
            'Dim mstream As New System.IO.MemoryStream()
            'manageStudents.pbImage.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            'arrImage = mstream.GetBuffer()
            'Dim FileSize As UInt32
            'FileSize = mstream.Length
            'mstream.Close()

            cmd = New SqlCommand("UPDATE OBRE SET OBREmacco_ID=@OBREmacco_ID, OBREmbo_ID=@OBREmbo_ID, OBRE_NO=@OBRE_NO, Payee=@Payee, OfficeName=@OfficeName,TotalAmount=@TotalAmount,EntryDate=@EntryDate WHERE UID= @UID", sqlCon)
            cmd.Parameters.AddWithValue("@UID", ID)
            cmd.Parameters.AddWithValue("@OBREmacco_ID", OBREmacco_ID)
            cmd.Parameters.AddWithValue("@OBREmbo_ID", OBREmbo_ID)
            cmd.Parameters.AddWithValue("@OBRE_NO", OBRE_NO)
            cmd.Parameters.AddWithValue("@EntryDate", EntryDate)
            cmd.Parameters.AddWithValue("@Payee", Payee)
            cmd.Parameters.AddWithValue("@OfficeName", OfficeName)
            cmd.Parameters.AddWithValue("@TotalAmount", TotalAmount)
            cmd.ExecuteNonQuery()



            cmd = New SqlCommand("UPDATE OBRE_OtherDetails SET OBREmacco_ID= @OBREmacco_ID, OBREmbo_ID=@OBREmbo_ID, OBRE_NO=@OBRE_NO, Payee=@Payee, OfficeName=@OfficeName,ResCenter=@ResCenter, Particulars=@Particulars,AccountCode=@AccountCode,Amount=@Amount,EntryDate=@EntryDate WHERE  UID=@UID", sqlCon)
            cmd.Prepare()



            For Each row As DataGridViewRow In DataGridView.Rows
                If Not row.IsNewRow Then
                    'cmd.Parameters.AddWithValue("@ID", ID)
                    'MsgBox(ID)
                    cmd.Parameters.AddWithValue("@UID", row.Cells(4).Value)
                    ' MsgBox(row.Cells(4).Value.ToString)
                    cmd.Parameters.AddWithValue("@OBREmacco_ID", OBREmacco_ID)
                    cmd.Parameters.AddWithValue("@OBREmbo_ID", OBREmbo_ID)
                    cmd.Parameters.AddWithValue("@OBRE_NO", OBRE_NO)
                    cmd.Parameters.AddWithValue("@EntryDate", EntryDate)
                    cmd.Parameters.AddWithValue("@Payee", Payee)
                    cmd.Parameters.AddWithValue("@OfficeName", OfficeName)
                    cmd.Parameters.AddWithValue("@ResCenter", row.Cells(0).Value.ToString())
                    cmd.Parameters.AddWithValue("@Particulars", row.Cells(1).Value.ToString())
                    cmd.Parameters.AddWithValue("@AccountCode", row.Cells(2).Value.ToString())
                    cmd.Parameters.AddWithValue("@Amount", row.Cells(3).Value.ToString.Replace(",", ""))
                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()
                End If
            Next

            ClsConn.CloseConnection()
        End If
    End Sub
    Public Sub saveOrUpdateOBRE(DataGridView As DataGridView)
        If (ClsConn.OpenConnection() = True) Then
            cmd = New SqlCommand("
            MERGE INTO OBRE AS target
            USING (VALUES (@OBREmacco_ID, @OBREmbo_ID, @OBRE_NO, @Payee, @OfficeName,@TotalAmount,@EntryDate, @UID,@ID)) AS source (OBREmacco_ID, OBREmbo_ID, OBRE_NO, Payee, OfficeName,TotalAmount,EntryDate,UID,ID)
                ON COALESCE(target.UID, '') = COALESCE(source.UID, '')
            WHEN MATCHED THEN



                UPDATE SET target.OBREmacco_ID=source.OBREmacco_ID, target.OBREmbo_ID=source.OBREmbo_ID, target.OBRE_NO=source.OBRE_NO, target.Payee=source.Payee, target.OfficeName=source.OfficeName,target.TotalAmount=source.TotalAmount,target.EntryDate=source.EntryDate, target.ID=source.ID
            WHEN NOT MATCHED THEN


                INSERT (ID,OBREmacco_ID, OBREmbo_ID, OBRE_NO, EntryDate,Payee, OfficeName,TotalAmount) VALUES (source.ID,source.OBREmacco_ID, source.OBREmbo_ID, source.OBRE_NO, source.EntryDate,source.Payee, source.OfficeName,source.TotalAmount);", sqlCon)


            cmd.Parameters.AddWithValue("@ID", ID)
            cmd.Parameters.AddWithValue("@UID", If(Convert.IsDBNull(UID), DBNull.Value, UID))
            cmd.Parameters.AddWithValue("@OBREmacco_ID", OBREmacco_ID)
            cmd.Parameters.AddWithValue("@OBREmbo_ID", OBREmbo_ID)
            cmd.Parameters.AddWithValue("@OBRE_NO", OBRE_NO)
            cmd.Parameters.AddWithValue("@EntryDate", EntryDate)
            cmd.Parameters.AddWithValue("@Payee", Payee)
            cmd.Parameters.AddWithValue("@OfficeName", OfficeName)
            cmd.Parameters.AddWithValue("@TotalAmount", TotalAmount)
            cmd.ExecuteNonQuery()

            ClsConn.CloseConnection()


        End If
    End Sub
    Public Sub updateOBREOtherDetails(DataGridView As DataGridView)
        If (ClsConn.OpenConnection() = True) Then
            cmd = New SqlCommand("
            MERGE INTO OBRE_OtherDetails AS target
            USING (VALUES (@UID, @Rescenter, @Particulars, @AccountCode,@Amount,@ID,@EntryDate)) AS source (UID, Rescenter, Particulars, AccountCode,Amount,ID,EntryDate)
                ON COALESCE(target.UID, '') = COALESCE(source.UID, '')
            WHEN MATCHED THEN
                UPDATE SET target.Rescenter = source.Rescenter, target.Particulars = source.Particulars, target.AccountCode = source.AccountCode , target.Amount = source.Amount, target.EntryDate=source.EntryDate
            WHEN NOT MATCHED THEN
                INSERT ( Rescenter, Particulars, AccountCode,Amount,ID,EntryDate) VALUES ( source.Rescenter, source.Particulars, source.AccountCode,source.Amount,source.ID,source.EntryDate);
        ", sqlCon)
            cmd.Prepare()

            For Each row As DataGridViewRow In DataGridView.Rows
                If Not row.IsNewRow Then
                    cmd.Parameters.AddWithValue("@ResCenter", row.Cells(0).Value.ToString())
                    cmd.Parameters.AddWithValue("@Particulars", row.Cells(1).Value.ToString())
                    cmd.Parameters.AddWithValue("@AccountCode", row.Cells(2).Value.ToString())
                    cmd.Parameters.AddWithValue("@Amount", row.Cells(3).Value.ToString.Replace(",", ""))
                    'If row.Cells(4).Value Is Nothing Then
                    '    cmd.Parameters.AddWithValue("@UID", DBNull.Value)
                    '    MsgBox("true")
                    'Else
                    '    MsgBox("false")
                    '    cmd.Parameters.AddWithValue("@UID", row.Cells(4).Value)
                    'End If
                    cmd.Parameters.AddWithValue("@EntryDate", EntryDate)
                    cmd.Parameters.AddWithValue("@UID", If((row.Cells(4).Value) Is Nothing, DBNull.Value, row.Cells(4).Value))
                    cmd.Parameters.AddWithValue("@ID", ID)
                        cmd.ExecuteNonQuery()
                        cmd.Parameters.Clear()
                    End If
            Next
            ClsConn.CloseConnection()


        End If
    End Sub

    Public Sub deleteOBREDetails(ByVal id As String)
        If (ClsConn.OpenConnection() = True) Then
            cmd = New SqlCommand("delete from OBRE_OtherDetails where UID=@UID", sqlCon)
            cmd.Parameters.AddWithValue("@UID", id)
            cmd.ExecuteNonQuery()
            ClsConn.CloseConnection()
        End If
    End Sub
End Class
