Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading

Public Class frmOBRE
    Private Sub frmOBRE_Load(sender As Object, e As EventArgs) Handles Me.Load
        theme.myCustomSkinDark(Me)
        Me.Size = DashBoard.FlowLayoutPanel1.Size

    End Sub

    Private Sub MaterialComboBox1_DropDown(sender As Object, e As EventArgs) Handles dtpDate.DropDown
        Using form As New Form
            form.FormBorderStyle = FormBorderStyle.None
            form.StartPosition = FormStartPosition.Manual
            form.Location = Cursor.Position
            form.ShowInTaskbar = False
            Dim calendarControl As New ClsCalendarControl()
            AddHandler calendarControl.DateSelected, AddressOf CalendarControl_DateSelected
            form.Controls.Add(calendarControl)
            form.ClientSize = New Size(calendarControl._calendar.Size.Width + 49, calendarControl._calendar.Size.Height + 7)
            calendarControl.Dock = DockStyle.Fill

            form.ShowDialog()
        End Using
    End Sub
    Private Sub CalendarControl_DateSelected(sender As Object, e As EventArgs)
        Dim calendarControl = DirectCast(sender, ClsCalendarControl)
        'MessageBox.Show("Selected date: " & calendarControl.SelectedDate.ToShortDateString())
        txtDate.Text = calendarControl.SelectedDate.ToShortDateString()
        calendarControl.FindForm().Close()
        SendKeys.Send("{TAB}")
    End Sub
    Public id, payee, entrydate, obreno, uid, totalamount As String


    Private Sub CopySelectedRowsToClipboard(datagrid As DataGridView)
        Dim selectedRows As DataGridViewSelectedRowCollection = datagrid.SelectedRows
        If selectedRows.Count > 0 Then
            Dim clipboardData As New StringBuilder()
            For Each row As DataGridViewRow In selectedRows
                Dim rowData As New StringBuilder()
                For Each cell As DataGridViewCell In row.Cells
                    rowData.Append(cell.Value)
                    rowData.Append(vbTab)
                Next
                clipboardData.AppendLine(rowData.ToString())
            Next
            Clipboard.SetText(clipboardData.ToString())
        End If
    End Sub

    Private Sub PasteRowsFromClipboard(datagrid As DataGridView)
        Dim clipboardData As String = Clipboard.GetText()
        If Not String.IsNullOrEmpty(clipboardData) Then
            Dim rows As String() = clipboardData.Split(CType(vbNewLine, Char()), StringSplitOptions.RemoveEmptyEntries)
            If rows.Length > 0 Then
                Dim targetRowIndex As Integer = datagrid.CurrentCell.RowIndex
                For Each rowData As String In rows
                    Dim cells As String() = rowData.Split(vbTab)
                    If cells.Length = datagrid.Columns.Count Then
                        datagrid.Rows.Insert(targetRowIndex, cells)
                        targetRowIndex += 1
                    End If
                Next
            End If
        End If
    End Sub
    Sub displayrunningtotal(datagridview As DataGridView)
        Try
            runningTotal = 0
            For i As Integer = 0 To datagridview.Rows.Count - 1
                If Not datagridview.Rows(i).IsNewRow Then
                    Dim cellValue As Decimal
                    If Decimal.TryParse(datagridview.Rows(i).Cells("Amount").Value.ToString(), cellValue) Then
                        runningTotal += cellValue
                    Else
                        Throw New ArgumentException("Invalid input in cell")
                    End If
                End If
            Next
            datagridview.Rows(datagridview.Rows.Count - 1).Cells("Amount").Value = runningTotal.ToString("N2")
        Catch ex As Exception
            ' Handle the exception appropriately
        End Try
    End Sub
    Private Sub OBREDGV_KeyDown(sender As Object, e As KeyEventArgs) Handles OBREDGV.KeyDown
        Try


            If e.Control AndAlso e.KeyCode = Keys.C Then
                ' Copy selected rows to clipboard
                Dim clipboardContent As String = ""
                For Each selectedRow As DataGridViewRow In OBREDGV.SelectedRows
                    For Each cell As DataGridViewCell In selectedRow.Cells
                        clipboardContent &= cell.Value.ToString() & vbTab
                    Next
                    clipboardContent = clipboardContent.TrimEnd(vbTab) & vbCrLf
                Next
                Clipboard.SetText(clipboardContent)
            ElseIf e.Control AndAlso e.KeyCode = Keys.V Then
                ' Paste clipboard content to selected rows
                Dim clipboardContent As String = Clipboard.GetText()
                Dim rows As String() = clipboardContent.Split(vbCrLf.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)


                Dim rowIndex As Integer = OBREDGV.SelectedRows(0).Index
                OBREDGV.EndEdit() ' Commit any pending edits before adding new rows
                For Each row As String In rows
                    Dim values As String() = row.Split(vbTab.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    Dim columnIndex As Integer = 0
                    OBREDGV.Rows.Add() ' Add a new row
                    For Each value As String In values
                        OBREDGV.Rows(rowIndex).Cells(columnIndex).Value = value
                        columnIndex += 1
                    Next
                    rowIndex += 1
                Next
            End If



            If e.KeyCode = Keys.F1 AndAlso OBREDGV.CurrentCell.ColumnIndex = 0 Then
                frmResponsibilityCenter.Size = New System.Drawing.Size(800, 388)
                frmResponsibilityCenter.FormStyle = FormStyles.ActionBar_40
                frmResponsibilityCenter.TopLevel = True
                frmResponsibilityCenter.RCDGV.AllowUserToAddRows = False
                frmResponsibilityCenter.RCDGV.AllowUserToResizeColumns = False
                frmResponsibilityCenter.RCDGV.AllowUserToResizeRows = False
                frmResponsibilityCenter.RCDGV.AllowUserToDeleteRows = False
                frmResponsibilityCenter.RCDGV.AllowUserToResizeColumns = False
                frmResponsibilityCenter.ShowDialog()

            End If

            If e.KeyCode = Keys.F1 AndAlso OBREDGV.CurrentCell.ColumnIndex = 2 Then
                frmChartofAccounts.Size = New System.Drawing.Size(800, 388)
                frmChartofAccounts.FormStyle = FormStyles.ActionBar_40
                frmChartofAccounts.TopLevel = True
                frmChartofAccounts.COADGV.AllowUserToAddRows = False
                frmChartofAccounts.COADGV.AllowUserToResizeColumns = False
                frmChartofAccounts.COADGV.AllowUserToResizeRows = False
                frmChartofAccounts.COADGV.AllowUserToDeleteRows = False
                frmChartofAccounts.COADGV.AllowUserToResizeColumns = False
                frmChartofAccounts.request = "frmOBRE"
                frmChartofAccounts.ShowDialog()
                'frmChartofAccountsV2.ShowDialog()
            End If
            If e.KeyCode = Keys.Delete Then

                Dim message As String = "Are you sure you want to delete this item?" & vbCrLf & vbCrLf & "" & vbCrLf & vbCrLf & "This action cannot be undone."
                Dim title As String = "Confirmation"
                Dim buttons As MessageBoxButtons = MessageBoxButtons.OKCancel

                Dim result As DialogResult = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                If result = DialogResult.OK Then
                    ' User clicked OK, perform the action
                    Dim DeleteOBREOtherDetails As New ClsOBRE
                    With DeleteOBREOtherDetails
                        If OBREDGV.CurrentRow.Cells(4).Value Is Nothing Then
                            'automatically remove the row
                            MsgBox("test")
                            Exit Sub
                        Else
                            'MessageBox.Show("Are you sure you want to delete the item?", vbYesNo)
                            .deleteOBREDetails(OBREDGV.CurrentRow.Cells(4).Value.ToString())
                            Dim SnackBarMessage1 As MaterialSkin.Controls.MaterialSnackBar
                            SnackBarMessage1 = New MaterialSkin.Controls.MaterialSnackBar("Record Successfully deleted", "Ok", True)
                            SnackBarMessage1.Show(Me)
                        End If
                    End With
                Else
                    e.Handled = True ' Cancel the Delete key down event
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            mode = 2
            If String.IsNullOrEmpty(txtPayee.Text) Then
                MessageBox.Show("Please fill up required fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If OBREDGV.Rows.Count = 1 Then
                OBREDGV.AllowUserToAddRows = False
                If OBREDGV.Rows.Count = 0 Then
                    MessageBox.Show("Sorry no data added to grid", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    OBREDGV.AllowUserToAddRows = True
                    Exit Sub
                End If
                OBREDGV.AllowUserToAddRows = True
            End If
            If OBREDGV.Rows.Count = 0 Then
                MessageBox.Show("Sorry no data added to grid", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If


            Dim OBRE As New ClsOBRE
            With OBRE

                Dim txtautoID = autoID("SELECT TOP 1 ID FROM OBRE ORDER BY ID DESC")
                .UID = uid
                'If id Is Nothing Then
                '    .ID = txtautoID.txtID
                'Else
                '    .ID = id
                'End If
                .ID = uid

                .OBREmacco_ID = txtOBREmacco_ID.Text
                .OBREmbo_ID = ""
                .OBRE_NO = ""
                .EntryDate = txtDate.Text
                .Payee = txtPayee.Text
                .OfficeName = ""
                .TotalAmount = "0.00"

                Select Case mode
                    Case Modes.add
                        ' ARODGV.Columns.Remove("btnDelRow")
                        '.save(OBREDGV)
                        'customSnackbar(Me, "Record Successfully Saved", "Ok")
                        ''DashBoard.btnAddStudent.Enabled = False
                        'btnSave.Enabled = False
                    Case Modes.edit
                        '.updateOBRE(OBREDGV)
                        .saveOrUpdateOBRE(OBREDGV)
                        .updateOBREOtherDetails(OBREDGV)
                        customSnackbar(Me, "Record Successfully Updated", "Ok")
                        '    btnSave.Text = "SAVE"
                        '    MaterialLabel1.Text = "Add Student"
                        '    mode = Modes.add
                        '    txtID.Enabled = True
                End Select
                'Initial_State()
            End With
            'DashBoard.ShowRegistration()
            ' ClearTextbox(Me)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles OBREDGV.CellEndEdit
        Try
            If OBREDGV.Rows.Count > 0 Then

                If e.ColumnIndex = 3 Then
                    Dim value As String = OBREDGV.Rows(e.RowIndex).Cells(3).Value.ToString
                    Dim newValue As Decimal
                    If Decimal.TryParse(value, newValue) Then
                        OBREDGV.Rows(e.RowIndex).Cells(3).Value = String.Format("{0:N2}", newValue)
                    Else
                        'Handles invalid input
                    End If

                    Dim cell As DataGridViewCell = OBREDGV.Rows(e.RowIndex).Cells(e.ColumnIndex)
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
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        ClearTextbox(Me)
        OBREDGV.DataSource = Nothing
        OBREDGV.Rows.Clear()
        mode = 1
        btnSave.Text = "SAVE"
        btnSave.Enabled = False
        btnSave.Enabled = True
        id = Nothing
    End Sub

    Private Sub dtpDate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dtpDate.SelectedIndexChanged

    End Sub

    Private Sub btnGetData_Click(sender As Object, e As EventArgs) Handles btnGetData.Click
        'frmOBRE_OtherDetails.Size = New System.Drawing.Size(1117, 525)
        frmOBRE_OtherDetails.FormStyle = FormStyles.ActionBar_40
        frmOBRE_OtherDetails.TopLevel = True
        frmOBRE_OtherDetails.OBREDGV.AllowUserToAddRows = False
        frmOBRE_OtherDetails.OBREDGV.AllowUserToResizeColumns = False
        frmOBRE_OtherDetails.OBREDGV.AllowUserToResizeRows = False
        frmOBRE_OtherDetails.OBREDGV.AllowUserToDeleteRows = False
        frmOBRE_OtherDetails.OBREDGV.AllowUserToResizeColumns = False
        frmOBRE_OtherDetails.OBREDGV.DataSource = Nothing
        frmOBRE_OtherDetails.OBREDGV.Rows.Clear()
        frmOBRE_OtherDetails.ShowDialog()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If btnSave.Text = "SAVE" Then
                mode = 1
            Else
                mode = 2
            End If
            If String.IsNullOrEmpty(txtPayee.Text) Then
                MessageBox.Show("Please fill up required fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If OBREDGV.Rows.Count = 1 Then
                OBREDGV.AllowUserToAddRows = False
                If OBREDGV.Rows.Count = 0 Then
                    MessageBox.Show("Sorry no data added to grid", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    OBREDGV.AllowUserToAddRows = True
                    Exit Sub
                End If
                OBREDGV.AllowUserToAddRows = True
            End If
            If OBREDGV.Rows.Count = 0 Then
                MessageBox.Show("Sorry no data added to grid", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If


            Dim OBRE As New ClsOBRE
            With OBRE



                Select Case mode
                    Case Modes.add
                        Dim txtautoID = autoID("SELECT TOP 1 ID FROM OBRE ORDER BY ID DESC")
                        .ID = txtautoID.txtID
                        .OBREmacco_ID = txtOBREmacco_ID.Text
                        .OBREmbo_ID = ""
                        .OBRE_NO = ""
                        .EntryDate = txtDate.Text
                        .Payee = txtPayee.Text
                        .OfficeName = ""
                        .TotalAmount = "0.00"
                        .save(OBREDGV)
                        customSnackbar(Me, "Record Successfully Saved", "Ok")
                        'DashBoard.btnAddStudent.Enabled = False
                        btnSave.Enabled = False
                    Case Modes.edit
                        .ID = id
                        .OBREmacco_ID = txtOBREmacco_ID.Text
                        .OBREmbo_ID = ""
                        .OBRE_NO = ""
                        .EntryDate = txtDate.Text
                        .Payee = txtPayee.Text
                        .OfficeName = ""
                        .TotalAmount = "0.00"
                        .updateOBRE(OBREDGV)
                        customSnackbar(Me, "Record Successfully Updated", "Ok")
                        btnSave.Text = "SAVE"
                        Me.btnSave.Enabled = False

                        '    MaterialLabel1.Text = "Add Student"
                        mode = Modes.add
                        '    txtID.Enabled = True
                End Select
                'Initial_State()
            End With
            'DashBoard.ShowRegistration()
            'ClearTextbox(Me)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub OBREDGV_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles OBREDGV.CellValueChanged
        If OBREDGV.Columns(e.ColumnIndex).Name = "Amount" Then
            Dim runningTotal As Decimal = 0
            For i As Integer = 0 To OBREDGV.Rows.Count - 1
                If Not OBREDGV.Rows(i).IsNewRow Then
                    Dim cellValue As Decimal
                    If Decimal.TryParse(OBREDGV.Rows(i).Cells("Amount").Value.ToString(), cellValue) Then
                        runningTotal += cellValue
                    Else
                        ' Handle invalid input
                    End If

                End If
            Next
            OBREDGV.Rows(OBREDGV.Rows.Count - 1).Cells("Amount").Value = String.Format("{0:N2}", runningTotal)
        End If
    End Sub
    Dim runningTotal As Decimal
    Private Sub OBREDGV_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles OBREDGV.UserDeletedRow
        Try
            runningTotal = 0
            For i As Integer = 0 To OBREDGV.Rows.Count - 1
                If Not OBREDGV.Rows(i).IsNewRow Then
                    Dim cellValue As Decimal
                    If Decimal.TryParse(OBREDGV.Rows(i).Cells("Amount").Value.ToString(), cellValue) Then
                        runningTotal += cellValue
                    Else
                        Throw New ArgumentException("Invalid input in cell")
                    End If
                End If
            Next
            OBREDGV.Rows(OBREDGV.Rows.Count - 1).Cells("Amount").Value = runningTotal.ToString("N2")
        Catch ex As Exception
            ' Handle the exception appropriately
        End Try
    End Sub
End Class