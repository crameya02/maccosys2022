Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Text.RegularExpressions

Public Class frmARO_Adjustments_OtherDetails

    Private Sub frmARO_Adjustments_OtherDetails_Load(sender As Object, e As EventArgs) Handles Me.Load
        theme.myCustomSkinDark(Me)
        'ARODGV(2, frmARO_Adjustments.ARODGV.Rows.Count - 1).ReadOnly = True
    End Sub
    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles ARODGV.CellEndEdit
        Try
            If ARODGV.Rows.Count > 0 Then

                If e.ColumnIndex = 2 Then
                    Dim value As String = ARODGV.Rows(e.RowIndex).Cells(2).Value.ToString



                    Dim newValue As Decimal
                    If Decimal.TryParse(value, newValue) Then
                        ARODGV.Rows(e.RowIndex).Cells(2).Value = String.Format("{0:N2}", newValue)

                        Dim defaultCellValue As String = frmARO_Adjustments.defaultAccountCode
                        Dim columnIndex As Integer = 1 ' Replace with the index of the column you want to set the default value for
                        ARODGV.Rows(e.RowIndex).Cells(columnIndex).Value = defaultCellValue


                    Else
                        'Handles invalid input
                    End If

                    Dim cell As DataGridViewCell = ARODGV.Rows(e.RowIndex).Cells(e.ColumnIndex)
                    'Check if the cell value is a mathematical expression
                    Dim match As Match = Regex.Match(cell.Value.ToString(), "(\d+\.\d+|\d+)\s*([\+\-\*\/])\s*(\d+\.\d+|\d+)")
                    If match.Success Then
                        Dim left As Double = Double.Parse(match.Groups(1).Value)
                        Dim op As String = match.Groups(2).Value
                        Dim right As Double = Double.Parse(match.Groups(3).Value)
                        Dim result As Double
                        'Perform the calculation
                        Select Case op
                            Case "+"
                                result = left + right
                            Case "-"
                                result = left - right
                            Case "*"
                                result = left * right
                            Case "/"
                                result = left / right
                        End Select
                        'Set the result as the new value of the cell
                        cell.Value = String.Format("{0:N2}", result)
                    End If
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub





    Private Sub ARODGV_KeyDown(sender As Object, e As KeyEventArgs) Handles ARODGV.KeyDown
        Try


            If e.KeyCode = Keys.Delete Then


                Dim message As String = "Are you sure you want to delete this item?" & vbCrLf & vbCrLf & "" & vbCrLf & vbCrLf & "This action cannot be undone."
                Dim title As String = "Confirmation"
                Dim buttons As MessageBoxButtons = MessageBoxButtons.OKCancel

                Dim result As DialogResult = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

                If result = DialogResult.OK Then
                    ' User clicked OK, perform the action
                    Dim ARODeleteAdjustment As New ClsARO
                    With ARODeleteAdjustment
                        If ARODGV.CurrentRow.Cells(3).Value Is Nothing Then
                            'automatically remove the row

                            Exit Sub
                        Else
                            Dim sqlquery As String = ""
                            If Me.Text = "Augmentation" Then
                                sqlquery = ("DELETE FROM ARO_Augmentation WHERE UID=@UID")
                                .deleteAdjustmentID(ARODGV.CurrentRow.Cells(4).Value.ToString(), sqlquery)
                                Dim SnackBarMessage1 As MaterialSkin.Controls.MaterialSnackBar
                                SnackBarMessage1 = New MaterialSkin.Controls.MaterialSnackBar("Augmentation item Successfully deleted", "Ok", True)
                                SnackBarMessage1.Show(Me)
                                RefreshData()
                                sqlquery = ""

                            End If

                            If Me.Text = "Reversion" Then
                                sqlquery = ("DELETE FROM ARO_Reversion WHERE UID=@UID")
                                .deleteAdjustmentID(ARODGV.CurrentRow.Cells(4).Value.ToString(), sqlquery)
                                Dim SnackBarMessage1 As MaterialSkin.Controls.MaterialSnackBar
                                SnackBarMessage1 = New MaterialSkin.Controls.MaterialSnackBar("Reversion item Successfully deleted", "Ok", True)
                                SnackBarMessage1.Show(Me)
                                RefreshData()
                                sqlquery = ""

                            End If

                            If Me.Text = "Supplemental Budget" Then
                                sqlquery = ("DELETE FROM ARO_SupplementalBudget WHERE UID=@UID")
                                .deleteAdjustmentID(ARODGV.CurrentRow.Cells(4).Value.ToString(), sqlquery)
                                Dim SnackBarMessage1 As MaterialSkin.Controls.MaterialSnackBar
                                SnackBarMessage1 = New MaterialSkin.Controls.MaterialSnackBar("Supplemental Budget item Successfully deleted", "Ok", True)
                                SnackBarMessage1.Show(Me)
                                RefreshData()
                                sqlquery = ""



                            End If
                        End If

                    End With

                Else
                    e.Handled = True ' Cancel the Delete key down event
                End If

            End If
            If e.KeyCode = Keys.S AndAlso e.Control Then ' check if ctrl+S is pressed
                e.SuppressKeyPress = True ' suppress the default behavior of ctrl+f
                btnUpdate.PerformClick()
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub ShowAdjustment(id As Integer, mode As Integer)
        ' Fetch the latest ID from the database
        If (ClsConn.OpenConnection() = True) Then
            Dim sql1 As String = "SELECT ID, AccountCode, Amount,Remarks, UID from ARO_Augmentation where ID=@ID order by AccountCode asc"

            Dim sql2 As String = "SELECT ID, AccountCode, Amount,Remarks, UID from ARO_Reversion where ID=@ID order by AccountCode asc"

            Dim sql3 As String = "SELECT ID, AccountCode, Amount,Remarks, UID from ARO_SupplementalBudget where ID=@ID order by AccountCode asc"
            Dim sql As String = ""
            If mode = 1 Then
                sql = sql1
            ElseIf mode = 2 Then
                sql = sql2
            Else
                sql = sql3
            End If
            cmd = New SqlCommand(sql, sqlCon)
            cmd.Parameters.AddWithValue("@ID", id)
            ARODGV.DataSource = Nothing
            ARODGV.Rows.Clear()
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While (rdr.Read() = True)
                ARODGV.Rows.Add(
                    rdr(0),
                    rdr(1),
                    Convert.ToDouble(rdr(2)).ToString("N2", CultureInfo.InvariantCulture),
                    rdr(3),
                   rdr(4)
                 )
            End While
            'Format Cellvalues to Decimal of Appropriation Column
            If ARODGV.Columns(2).Name = "Amount" Then
                Dim runningTotal As Decimal = 0
                For i As Integer = 0 To ARODGV.Rows.Count - 1
                    If Not ARODGV.Rows(i).IsNewRow Then
                        Dim cellValue As Decimal
                        If Decimal.TryParse(ARODGV.Rows(i).Cells("Amount").Value.ToString(), cellValue) Then
                            runningTotal += cellValue
                        Else
                            ' Handle invalid input
                        End If

                    End If
                Next
                ARODGV.Rows(ARODGV.Rows.Count - 1).Cells("Amount").Value = String.Format("{0:N2}", runningTotal)
            End If



            ARODGV.Enabled = True
            ARODGV.Columns(0).ReadOnly = True
            ARODGV.Columns(1).ReadOnly = True

            'frmARO_Adjustments_OtherDetails.ARODGV(2, frmARO_Adjustments_OtherDetails.ARODGV.Rows.Count - 1).ReadOnly = True
            ARODGV.Columns(4).ReadOnly = True
            ClsConn.CloseConnection()

        End If
    End Sub
    Dim runningTotal As Decimal
    Private Sub ARODGV_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles ARODGV.UserDeletedRow
        Try
            runningTotal = 0
            For i As Integer = 0 To ARODGV.Rows.Count - 1
                If Not ARODGV.Rows(i).IsNewRow Then
                    Dim cellValue As Decimal
                    If Decimal.TryParse(ARODGV.Rows(i).Cells("Amount").Value.ToString(), cellValue) Then
                        runningTotal += cellValue
                    Else
                        Throw New ArgumentException("Invalid input in cell")
                    End If
                End If
            Next
            ARODGV.Rows(ARODGV.Rows.Count - 1).Cells("Amount").Value = runningTotal.ToString("N2")
        Catch ex As Exception
            ' Handle the exception appropriately
        End Try
    End Sub




    Private Sub ARODGV_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles ARODGV.CellValueChanged
        Try


            'If ARODGV.Columns(e.ColumnIndex).Name = "Amount" Then
            '    Dim runningTotal As Decimal = 0
            '    For i As Integer = 0 To ARODGV.Rows.Count - 1
            '        If Not ARODGV.Rows(i).IsNewRow Then
            '            Dim cellValue As Decimal
            '            If Decimal.TryParse(ARODGV.Rows(i).Cells("Amount").Value.ToString(), cellValue) Then
            '                runningTotal += cellValue
            '            Else
            '                ' Handle invalid input
            '            End If

            '        End If
            '    Next
            '    ARODGV.Rows(ARODGV.Rows.Count - 1).Cells("Amount").Value = String.Format("{0:N2}", runningTotal)
            '            End If

            If e.ColumnIndex = ARODGV.Columns("Amount").Index AndAlso e.RowIndex >= 0 Then
                Dim cellValue As Decimal
                If Decimal.TryParse(ARODGV.Rows(e.RowIndex).Cells("Amount").Value.ToString(), cellValue) Then
                    runningTotal = 0
                    For i As Integer = 0 To ARODGV.Rows.Count - 1
                        If Not ARODGV.Rows(i).IsNewRow AndAlso i <> ARODGV.Rows.Count - 1 Then
                            If Decimal.TryParse(ARODGV.Rows(i).Cells("Amount").Value.ToString(), cellValue) Then
                                runningTotal += cellValue
                            Else
                                Throw New ArgumentException("Invalid input in cell")
                            End If
                        End If
                    Next
                    ARODGV.Rows(ARODGV.Rows.Count - 1).Cells("Amount").Value = runningTotal.ToString("N2")
                Else
                    ' Handle invalid input
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            mode = 2

            If ARODGV.Rows.Count = 1 Then
                ARODGV.AllowUserToAddRows = False
                If ARODGV.Rows.Count = 0 Then
                    MessageBox.Show("Sorry no data added to grid", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    ARODGV.AllowUserToAddRows = True
                    Exit Sub
                End If
                ARODGV.AllowUserToAddRows = True
            End If
            If ARODGV.Rows.Count = 0 Then
                MessageBox.Show("Sorry no data added to grid", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim ARO As New ClsARO
            With ARO


                .EntryDate = Now().ToString("MM/dd/yyyy")
                Select Case mode
                    Case Modes.add


                    Case Modes.edit
                        If Me.Text = "Augmentation" Then
                            .updateAugmentation(ARODGV)
                            customSnackbar(Me, "Record Successfully updated Augmentation", "Ok")
                            RefreshData()
                            'augmentation
                            ShowAdjustment(frmARO_Adjustments.defauiltID, 1)
                        End If

                        If Me.Text = "Reversion" Then
                            .updateReversion(ARODGV)
                            customSnackbar(Me, "Record Successfully updated Reversion", "Ok")
                            RefreshData()

                            'Reversion
                            ShowAdjustment(frmARO_Adjustments.defauiltID, 2)
                        End If

                        If Me.Text = "Supplemental Budget" Then
                            .updateSupplementalBudget(ARODGV)
                            customSnackbar(Me, "Record Successfully updated Supplemental Budget", "Ok")
                            RefreshData()
                            'SupplementalBudget
                            'MsgBox(frmARO_Adjustments.defauiltID.ToString)
                            ShowAdjustment(frmARO_Adjustments.defauiltID, 3)
                        End If

                End Select

            End With


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub RefreshData()
        Try
            ' Fetch the latest ID from the database
            If (ClsConn.OpenConnection() = True) Then


                '                Dim sql As String = "Select 
                'ARO.ID, 
                'ARO_Appropriation.AccountCode,
                'ARO_Appropriation.Description,
                'ARO_Appropriation.Amount,
                'ARO_Appropriation.UID,
                'sum(ISNULL(ARO_Augmentation.Amount, 0)) as Augmentation,
                'sum(ISNULL(ARO_Reversion.Amount, 0)) as Reversion,
                'sum(ISNULL(ARO_SupplementalBudget.Amount, 0)) as SupplementalBudget
                'from ARO 
                'inner join ARO_Appropriation on aro.id = ARO_Appropriation.id
                'LEFT JOIN ARO_Augmentation
                'ON ARO_Appropriation.UID = ARO_Augmentation.ID LEFT JOIN ARO_Reversion
                'ON ARO_Appropriation.UID = ARO_Reversion.ID LEFT JOIN ARO_SupplementalBudget
                'ON ARO_Appropriation.UID = ARO_SupplementalBudget.ID where ARO.ID=@ID
                'group by ARO.ID, 
                'ARO_Appropriation.AccountCode,
                'ARO_Appropriation.Description,
                'ARO_Appropriation.Amount,
                'ARO_Appropriation.UID
                'order by ARO_Appropriation.UID asc"
                Dim sql As String = "SELECT 
    ARO.ID, 
    ARO_Appropriation.AccountCode,
    ARO_Appropriation.Description,
    ARO_Appropriation.Amount,
    ARO_Appropriation.UID,
    ISNULL(AugmentationSum.SumAmount, 0) AS Augmentation,
    ISNULL(ReversionSum.SumAmount, 0) AS Reversion,
    ISNULL(SupplementalBudgetSum.SumAmount, 0) AS SupplementalBudget
FROM ARO 
INNER JOIN ARO_Appropriation ON ARO.ID = ARO_Appropriation.ID
LEFT JOIN (
    SELECT 
        ARO_Augmentation.ID, 
        SUM(ISNULL(ARO_Augmentation.Amount, 0)) AS SumAmount 
    FROM ARO_Augmentation 
    GROUP BY ARO_Augmentation.ID
) AS AugmentationSum ON ARO_Appropriation.UID = AugmentationSum.ID
LEFT JOIN (
    SELECT 
        ARO_Reversion.ID, 
        SUM(ISNULL(ARO_Reversion.Amount, 0)) AS SumAmount 
    FROM ARO_Reversion 
    GROUP BY ARO_Reversion.ID
) AS ReversionSum ON ARO_Appropriation.UID = ReversionSum.ID
LEFT JOIN (
    SELECT 
        ARO_SupplementalBudget.ID, 
        SUM(ISNULL(ARO_SupplementalBudget.Amount, 0)) AS SumAmount 
    FROM ARO_SupplementalBudget 
    GROUP BY ARO_SupplementalBudget.ID
) AS SupplementalBudgetSum ON ARO_Appropriation.UID = SupplementalBudgetSum.ID
WHERE ARO.ID = @ID
GROUP BY 
    ARO.ID, 
    ARO_Appropriation.AccountCode,
    ARO_Appropriation.Description,
    ARO_Appropriation.Amount,
    ARO_Appropriation.UID,AugmentationSum.SumAmount,ReversionSum.SumAmount,SupplementalBudgetSum.SumAmount
order by ARO_Appropriation.AccountCode asc
"
                cmd = New SqlCommand(sql, sqlCon)
                cmd.Parameters.AddWithValue("@ID", frmARO_Adjustments.id)
                frmARO_Adjustments.ARODGV.DataSource = Nothing
                frmARO_Adjustments.ARODGV.Rows.Clear()
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                While (rdr.Read() = True)
                    frmARO_Adjustments.ARODGV.Rows.Add(
                        rdr(1),
                        rdr(2),
                        Convert.ToDouble(rdr(3)).ToString("N2", CultureInfo.InvariantCulture),
                        rdr(4),
                        Convert.ToDouble(rdr(5)).ToString("N2", CultureInfo.InvariantCulture),
                        Convert.ToDouble(rdr(6)).ToString("N2", CultureInfo.InvariantCulture),
                        Convert.ToDouble(rdr(7)).ToString("N2", CultureInfo.InvariantCulture)
                     )
                End While
                'Format Cellvalues to Decimal of Appropriation Column
                If frmARO_Adjustments.ARODGV.Columns(2).Name = "Appropriation" Then
                    Dim runningTotal As Decimal = 0
                    For i As Integer = 0 To frmARO_Adjustments.ARODGV.Rows.Count - 1
                        If Not frmARO_Adjustments.ARODGV.Rows(i).IsNewRow Then
                            Dim cellValue As Decimal
                            If Decimal.TryParse(frmARO_Adjustments.ARODGV.Rows(i).Cells("Appropriation").Value.ToString(), cellValue) Then
                                runningTotal += cellValue
                            Else
                                ' Handle invalid input
                            End If

                        End If
                    Next
                    frmARO_Adjustments.ARODGV.Rows(frmARO_Adjustments.ARODGV.Rows.Count - 1).Cells("Appropriation").Value = String.Format("{0:N2}", runningTotal)
                End If


                'Format Cellvalues to Decimal of Allotment Column
                If frmARO_Adjustments.ARODGV.Columns(4).Name = "Augmentation" Then
                    Dim runningTotal As Decimal = 0
                    For i As Integer = 0 To frmARO_Adjustments.ARODGV.Rows.Count - 1
                        If Not frmARO_Adjustments.ARODGV.Rows(i).IsNewRow Then
                            Dim cellValue As Decimal
                            If Decimal.TryParse(frmARO_Adjustments.ARODGV.Rows(i).Cells("Augmentation").Value.ToString(), cellValue) Then
                                runningTotal += cellValue
                            Else
                                ' Handle invalid input
                            End If

                        End If
                    Next
                    frmARO_Adjustments.ARODGV.Rows(frmARO_Adjustments.ARODGV.Rows.Count - 1).Cells("Augmentation").Value = String.Format("{0:N2}", runningTotal)
                End If
                If frmARO_Adjustments.ARODGV.Columns(5).Name = "Reversion" Then
                    Dim runningTotal As Decimal = 0
                    For i As Integer = 0 To frmARO_Adjustments.ARODGV.Rows.Count - 1
                        If Not frmARO_Adjustments.ARODGV.Rows(i).IsNewRow Then
                            Dim cellValue As Decimal
                            If Decimal.TryParse(frmARO_Adjustments.ARODGV.Rows(i).Cells("Reversion").Value.ToString(), cellValue) Then
                                runningTotal += cellValue
                            Else
                                ' Handle invalid input
                            End If

                        End If
                    Next
                    frmARO_Adjustments.ARODGV.Rows(frmARO_Adjustments.ARODGV.Rows.Count - 1).Cells("Reversion").Value = String.Format("{0:N2}", runningTotal)
                End If
                If frmARO_Adjustments.ARODGV.Columns(6).Name = "SupplementalBudget" Then
                    Dim runningTotal As Decimal = 0
                    For i As Integer = 0 To frmARO_Adjustments.ARODGV.Rows.Count - 1
                        If Not frmARO_Adjustments.ARODGV.Rows(i).IsNewRow Then
                            Dim cellValue As Decimal
                            If Decimal.TryParse(frmARO_Adjustments.ARODGV.Rows(i).Cells("SupplementalBudget").Value.ToString(), cellValue) Then
                                runningTotal += cellValue
                            Else
                                ' Handle invalid input
                            End If

                        End If
                    Next
                    frmARO_Adjustments.ARODGV.Rows(frmARO_Adjustments.ARODGV.Rows.Count - 1).Cells("SupplementalBudget").Value = String.Format("{0:N2}", runningTotal)
                End If
                frmARO_Adjustments.ARODGV.Enabled = True
                frmARO_Adjustments.ARODGV.Columns(0).ReadOnly = True
                frmARO_Adjustments.ARODGV.Columns(1).ReadOnly = True
                frmARO_Adjustments.ARODGV.Columns(2).ReadOnly = True
                frmARO_Adjustments.ARODGV(3, frmARO_Adjustments.ARODGV.Rows.Count - 1).ReadOnly = True
                ClsConn.CloseConnection()

            End If





        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class