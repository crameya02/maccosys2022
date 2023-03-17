Imports System.Data.SqlClient
Imports System.Globalization
Imports TheArtOfDev.HtmlRenderer.Adapters

Public Class ClsARO
    Public Property UID As Integer
    Public Property ID As String
    Public Property AROID As String
    Public Property EntryDate As String
    Public Property FY As String
    Public Property Office As String
    Public Property Purpose As String
    Public Property FundCode As String
    Public Property Description As String
    Public Property AccountCode As String
    Public Property Appropriation As String
    Public Property ForLaterRelease As String
    Public Property PreviouslyRelease As String
    Public Property Allotment As String
    Public Sub saveAppro(DataGridView As DataGridView)
        If (ClsConn.OpenConnection() = True) Then
            cmd = New SqlCommand("INSERT INTO ARO VALUES(@ID,@AROID, @EntryDate, @FY, @Office, @FundCode)", sqlCon)
            cmd.Parameters.AddWithValue("@ID", ID)
            cmd.Parameters.AddWithValue("@AROID", AROID)
            cmd.Parameters.AddWithValue("@EntryDate", EntryDate)
            cmd.Parameters.AddWithValue("@FY", FY)
            cmd.Parameters.AddWithValue("@Office", Office)
            cmd.Parameters.AddWithValue("@FundCode", FundCode)
            cmd.ExecuteNonQuery()
            cmd = New SqlCommand("INSERT INTO ARO_Appropriation VALUES(@ID,@Description, @AccountCode, @Amount)", sqlCon)
            cmd.Prepare()
            For Each row As DataGridViewRow In DataGridView.Rows
                If Not row.IsNewRow Then
                    cmd.Parameters.AddWithValue("@ID", ID)

                    cmd.Parameters.AddWithValue("@Description", row.Cells(1).Value)
                    cmd.Parameters.AddWithValue("@AccountCode", row.Cells(0).Value)
                    cmd.Parameters.AddWithValue("@Amount", row.Cells(2).Value.ToString.Replace(",", ""))
                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()
                End If
            Next
            ClsConn.CloseConnection()
        End If
    End Sub
    'THis code has a problem when modifying appropriation when adding new rows to the datagrid it should be delete insert method
    'Public Sub updateAppro(DataGridView As DataGridView)
    '    If (ClsConn.OpenConnection() = True) Then

    '        cmd = New SqlCommand("UPDATE  ARO SET  Office=@Office, FundCode=@FundCode WHERE ID =@ID", sqlCon)
    '        cmd.Parameters.AddWithValue("@ID", ID)
    '        cmd.Parameters.AddWithValue("@Office", Office)
    '        cmd.Parameters.AddWithValue("@FundCode", FundCode)
    '        cmd.ExecuteNonQuery()
    '        cmd = New SqlCommand("UPDATE ARO_Appropriation SET Description=@Description, AccountCode=@AccountCode,Amount= @Amount where UID=@UID", sqlCon)
    '        cmd.Prepare()
    '        For Each row As DataGridViewRow In DataGridView.Rows
    '            If Not row.IsNewRow Then
    '                cmd.Parameters.AddWithValue("@UID", row.Cells(3).Value)
    '                cmd.Parameters.AddWithValue("@Description", row.Cells(1).Value)
    '                cmd.Parameters.AddWithValue("@AccountCode", row.Cells(0).Value)
    '                cmd.Parameters.AddWithValue("@Amount", row.Cells(2).Value.ToString.Replace(",", ""))
    '                cmd.ExecuteNonQuery()
    '                cmd.Parameters.Clear()
    '            End If
    '        Next
    '        ClsConn.CloseConnection()
    '    End If
    'End Sub
    ' this code snippet has a problem when updating appro, the allotment is not updated with it
    Public Sub updateAppro(DataGridView As DataGridView)
        If (ClsConn.OpenConnection() = True) Then
            'Update ARO
            cmd = New SqlCommand("UPDATE  ARO SET  Office=@Office, FundCode=@FundCode WHERE ID =@ID", sqlCon)
            cmd.Parameters.AddWithValue("@ID", ID)
            cmd.Parameters.AddWithValue("@Office", Office)
            cmd.Parameters.AddWithValue("@FundCode", FundCode)
            cmd.ExecuteNonQuery()
            'chatgpt suggestion

            cmd = New SqlCommand("MERGE INTO ARO_Appropriation AS target
USING (VALUES (@ID, @Description, @AccountCode, @Amount, @UID)) AS source (ID, Description, AccountCode, Amount, UID)
    ON target.ID = source.ID AND COALESCE(target.UID, '') = COALESCE(source.UID, '')
WHEN MATCHED THEN
    UPDATE SET target.Description = source.Description, target.AccountCode = source.AccountCode, target.Amount = source.Amount
WHEN NOT MATCHED THEN
    INSERT (ID, Description, AccountCode, Amount) VALUES (source.ID, source.Description, source.AccountCode, source.Amount);

", sqlCon)

            For Each row As DataGridViewRow In DataGridView.Rows
                If Not row.IsNewRow Then
                    cmd.Parameters.AddWithValue("@ID", ID)
                    cmd.Parameters.AddWithValue("@Description", row.Cells(1).Value)
                    cmd.Parameters.AddWithValue("@AccountCode", row.Cells(0).Value)
                    cmd.Parameters.AddWithValue("@Amount", row.Cells(2).Value.ToString.Replace(",", ""))
                    cmd.Parameters.AddWithValue("@UID", If(String.IsNullOrEmpty(row.Cells(3).Value), DBNull.Value, row.Cells(3).Value))

                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()
                End If
            Next
            ClsConn.CloseConnection()
        End If
    End Sub
    'this code is fine but no need to use delete insert method because no new rows will be allowed to be added, so updating will suffice
    'Public Sub updateAllotmentv2(DataGridView As DataGridView)
    '    If (ClsConn.OpenConnection() = True) Then
    '        cmd = New SqlCommand("DELETE FROM ARO_Allotment WHERE ID=@ID", sqlCon)
    '        cmd.Prepare()
    '        For Each row As DataGridViewRow In DataGridView.Rows
    '            If Not row.IsNewRow Then
    '                cmd.Parameters.AddWithValue("@ID", row.Cells(4).Value)
    '                'cmd.Parameters.AddWithValue("@Purpose", Purpose)
    '                cmd.ExecuteNonQuery()
    '                cmd.Parameters.Clear()
    '            End If
    '        Next
    '        cmd = New SqlCommand("INSERT INTO ARO_Allotment VALUES(@ID,@Purpose,@EntryDate,@Description, @AccountCode, @Amount)", sqlCon)
    '        cmd.Prepare()
    '        For Each row As DataGridViewRow In DataGridView.Rows
    '            If Not row.IsNewRow Then
    '                cmd.Parameters.AddWithValue("@ID", row.Cells(4).Value)
    '                cmd.Parameters.AddWithValue("@Purpose", Purpose)
    '                cmd.Parameters.AddWithValue("@EntryDate", EntryDate)
    '                cmd.Parameters.AddWithValue("@Description", row.Cells(1).Value)
    '                cmd.Parameters.AddWithValue("@AccountCode", row.Cells(0).Value)
    '                cmd.Parameters.AddWithValue("@Amount", row.Cells(3).Value.ToString.Replace(",", ""))
    '                cmd.ExecuteNonQuery()
    '                cmd.Parameters.Clear()
    '            End If
    '        Next
    '        ClsConn.CloseConnection()
    '    End If
    'End Sub
    Public Sub saveAllotment(DataGridView As DataGridView)
        If (ClsConn.OpenConnection() = True) Then

            cmd = New SqlCommand("INSERT INTO ARO_Allotment VALUES(@ID,@Purpose,@EntryDate,@Description, @AccountCode, @Amount)", sqlCon)
            cmd.Prepare()
            For Each row As DataGridViewRow In DataGridView.Rows
                If Not row.IsNewRow Then
                    cmd.Parameters.AddWithValue("@ID", row.Cells(4).Value)
                    cmd.Parameters.AddWithValue("@Purpose", Purpose)
                    cmd.Parameters.AddWithValue("@EntryDate", EntryDate)
                    cmd.Parameters.AddWithValue("@Description", row.Cells(1).Value)
                    cmd.Parameters.AddWithValue("@AccountCode", row.Cells(0).Value)
                    cmd.Parameters.AddWithValue("@Amount", row.Cells(3).Value.ToString.Replace(",", ""))
                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()
                End If
            Next
            ClsConn.CloseConnection()
        End If
    End Sub
    'this is a working code for update allotment however when using the merge statement in updating appropriation it doest save new rows, because when adding a new row in appropriation it wont have an allotment uid, if we save it the values will duplicate
    'Public Sub updateAllotment(DataGridView As DataGridView)
    '    If (ClsConn.OpenConnection() = True) Then
    '        For Each row As DataGridViewRow In DataGridView.Rows
    '            'check if it is last row which handles input for new data
    '            If Not row.IsNewRow Then
    '                cmd = New SqlCommand("UPDATE ARO_allotment SET Purpose = @Purpose, Amount =@Amount  WHERE  UID = @UID", sqlCon)
    '                cmd.Parameters.AddWithValue("@UID", row.Cells(5).Value)
    '                cmd.Parameters.AddWithValue("@Purpose", Purpose)

    '                cmd.Parameters.AddWithValue("@Amount", row.Cells(3).Value.ToString.Replace(",", ""))
    '                cmd.ExecuteNonQuery()
    '                cmd.Parameters.Clear()
    '            End If
    '        Next
    '        ClsConn.CloseConnection()
    '    End If
    'End Sub
    Public Sub updateAllotment(DataGridView As DataGridView)
        If (ClsConn.OpenConnection() = True) Then
            cmd = New SqlCommand("
            MERGE INTO ARO_allotment AS target
            USING (VALUES (@UID, @Purpose, @Amount, @EntryDate,@Description,@AccountCode,@ID)) AS source (UID, Purpose, Amount, EntryDate,Description,AccountCode,ID)
                ON COALESCE(target.UID, '') = COALESCE(source.UID, '')
            WHEN MATCHED THEN
                UPDATE SET target.Purpose = source.Purpose, target.Amount = source.Amount, target.EntryDate = source.EntryDate
            WHEN NOT MATCHED THEN
                INSERT ( Purpose, Amount, EntryDate,Description,AccountCode,ID) VALUES ( source.Purpose, source.Amount, source.EntryDate,source.Description,source.AccountCode,source.ID);
        ", sqlCon)

            For Each row As DataGridViewRow In DataGridView.Rows
                If Not row.IsNewRow Then
                    cmd.Parameters.AddWithValue("@UID", If(Convert.IsDBNull(row.Cells(5).Value), DBNull.Value, row.Cells(5).Value))
                    cmd.Parameters.AddWithValue("@Purpose", Purpose)
                    cmd.Parameters.AddWithValue("@Amount", row.Cells(3).Value.ToString.Replace(",", ""))


                    cmd.Parameters.AddWithValue("@ID", row.Cells(4).Value)

                    'cmd.Parameters.AddWithValue("@EntryDate", frmARO_Allotment.entrydate)
                    'MsgBox(EntryDate)
                    cmd.Parameters.AddWithValue("@EntryDate", EntryDate)
                    cmd.Parameters.AddWithValue("@Description", row.Cells(1).Value)
                    cmd.Parameters.AddWithValue("@AccountCode", row.Cells(0).Value)
                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()
                End If
            Next
            ClsConn.CloseConnection()


        End If
    End Sub
    Public Sub updateAugmentation(DataGridView As DataGridView)
        If (ClsConn.OpenConnection() = True) Then
            cmd = New SqlCommand("
            MERGE INTO ARO_Augmentation AS target
            USING (VALUES (@UID, @Remarks, @Amount, @DateCreated,@Description,@AccountCode,@ID,@DateModified)) AS source (UID, Remarks, Amount, DateCreated,Description,AccountCode,ID,DateModified)
                ON COALESCE(target.UID, '') = COALESCE(source.UID, '')
            WHEN MATCHED THEN
                UPDATE SET target.Remarks = source.Remarks, target.Amount = source.Amount, target.DateCreated = source.DateCreated , target.DateModified = source.DateModified
            WHEN NOT MATCHED THEN
                INSERT ( Remarks, Amount, DateCreated,Description,AccountCode,ID) VALUES ( source.Remarks, source.Amount, source.DateCreated,source.Description,source.AccountCode,source.ID);
        ", sqlCon)

            For Each row As DataGridViewRow In DataGridView.Rows
                If Not row.IsNewRow Then
                    cmd.Parameters.AddWithValue("@UID", If(Convert.IsDBNull(row.Cells(5).Value), DBNull.Value, row.Cells(5).Value))
                    cmd.Parameters.AddWithValue("@Remarks", If(Convert.IsDBNull(row.Cells(6).Value), "NA", row.Cells(6).Value))
                    cmd.Parameters.AddWithValue("@Amount", row.Cells(4).Value.ToString.Replace(",", ""))


                    cmd.Parameters.AddWithValue("@ID", row.Cells(3).Value)

                    cmd.Parameters.AddWithValue("@DateCreated", EntryDate)
                    cmd.Parameters.AddWithValue("@DateModified", EntryDate)
                    cmd.Parameters.AddWithValue("@Description", row.Cells(1).Value)
                    cmd.Parameters.AddWithValue("@AccountCode", row.Cells(0).Value)
                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()
                End If
            Next
            ClsConn.CloseConnection()


        End If
    End Sub
    Public Sub updateReversion(DataGridView As DataGridView)
        If (ClsConn.OpenConnection() = True) Then
            cmd = New SqlCommand("
            MERGE INTO ARO_Reversion AS target
            USING (VALUES (@UID, @Remarks, @Amount, @DateCreated,@Description,@AccountCode,@ID,@DateModified)) AS source (UID, Remarks, Amount, DateCreated,Description,AccountCode,ID,DateModified)
                ON COALESCE(target.UID, '') = COALESCE(source.UID, '')
            WHEN MATCHED THEN
                UPDATE SET target.Remarks = source.Remarks, target.Amount = source.Amount, target.DateCreated = source.DateCreated , target.DateModified = source.DateModified
            WHEN NOT MATCHED THEN
                INSERT ( Remarks, Amount, DateCreated,Description,AccountCode,ID) VALUES ( source.Remarks, source.Amount, source.DateCreated,source.Description,source.AccountCode,source.ID);
        ", sqlCon)

            For Each row As DataGridViewRow In DataGridView.Rows
                If Not row.IsNewRow Then
                    cmd.Parameters.AddWithValue("@UID", If(Convert.IsDBNull(row.Cells(8).Value), DBNull.Value, row.Cells(8).Value))
                    cmd.Parameters.AddWithValue("@Remarks", If(Convert.IsDBNull(row.Cells(9).Value), "NA", row.Cells(9).Value))
                    cmd.Parameters.AddWithValue("@Amount", row.Cells(7).Value.ToString.Replace(",", ""))


                    cmd.Parameters.AddWithValue("@ID", row.Cells(3).Value)

                    cmd.Parameters.AddWithValue("@DateCreated", EntryDate)
                    cmd.Parameters.AddWithValue("@DateModified", EntryDate)
                    cmd.Parameters.AddWithValue("@Description", row.Cells(1).Value)
                    cmd.Parameters.AddWithValue("@AccountCode", row.Cells(0).Value)
                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()
                End If
            Next
            ClsConn.CloseConnection()


        End If
    End Sub
    Public Sub updateSupplementalBudget(DataGridView As DataGridView)
        If (ClsConn.OpenConnection() = True) Then
            cmd = New SqlCommand("
            MERGE INTO ARO_SupplementalBudget AS target
            USING (VALUES (@UID, @Remarks, @Amount, @DateCreated,@Description,@AccountCode,@ID,@DateModified)) AS source (UID, Remarks, Amount, DateCreated,Description,AccountCode,ID,DateModified)
                ON COALESCE(target.UID, '') = COALESCE(source.UID, '')
            WHEN MATCHED THEN
                UPDATE SET target.Remarks = source.Remarks, target.Amount = source.Amount, target.DateCreated = source.DateCreated , target.DateModified = source.DateModified
            WHEN NOT MATCHED THEN
                INSERT ( Remarks, Amount, DateCreated,Description,AccountCode,ID) VALUES ( source.Remarks, source.Amount, source.DateCreated,source.Description,source.AccountCode,source.ID);
        ", sqlCon)

            For Each row As DataGridViewRow In DataGridView.Rows
                If Not row.IsNewRow Then
                    cmd.Parameters.AddWithValue("@UID", If(Convert.IsDBNull(row.Cells(11).Value), DBNull.Value, row.Cells(11).Value))
                    cmd.Parameters.AddWithValue("@Remarks", If(Convert.IsDBNull(row.Cells(12).Value), "NA", row.Cells(12).Value))
                    cmd.Parameters.AddWithValue("@Amount", row.Cells(10).Value.ToString.Replace(",", ""))


                    cmd.Parameters.AddWithValue("@ID", row.Cells(3).Value)

                    cmd.Parameters.AddWithValue("@DateCreated", EntryDate)
                    cmd.Parameters.AddWithValue("@DateModified", EntryDate)
                    cmd.Parameters.AddWithValue("@Description", row.Cells(1).Value)
                    cmd.Parameters.AddWithValue("@AccountCode", row.Cells(0).Value)
                    cmd.ExecuteNonQuery()
                    cmd.Parameters.Clear()
                End If
            Next
            ClsConn.CloseConnection()


        End If
    End Sub
    Public Sub deleteAppropriationID(ByVal id As String)
        If (ClsConn.OpenConnection() = True) Then
            cmd = New SqlCommand("delete from ARO_appropriation where UID=@UID", sqlCon)
            cmd.Parameters.AddWithValue("@UID", id)
            cmd.ExecuteNonQuery()
            ClsConn.CloseConnection()
        End If
    End Sub
End Class
