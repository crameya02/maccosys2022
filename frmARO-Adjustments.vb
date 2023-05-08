Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmARO_Adjustments
    'Public Sub ShowAppro()
    '    frmARO.ARODGV.DataSource = ClsConn.LoadData("SELECT AccountCode as Account_Code, Description as Description, Appropriation as Appropriation FROM ARO_OtherDetails").DefaultView
    'End Sub

    Private Sub btnGetData_Click(sender As Object, e As EventArgs) Handles btnGetData.Click
        'frmARO_OtherDetails.Size = New System.Drawing.Size(1117, 525)

        mode = 1
        action = 3
        frmARO_OtherDetails.FormStyle = FormStyles.ActionBar_40
        frmARO_OtherDetails.TopLevel = True
        frmARO_OtherDetails.ARODGV.AllowUserToAddRows = False
        frmARO_OtherDetails.ARODGV.AllowUserToResizeColumns = False
        frmARO_OtherDetails.ARODGV.AllowUserToResizeRows = False
        frmARO_OtherDetails.ARODGV.AllowUserToDeleteRows = False
        frmARO_OtherDetails.ARODGV.AllowUserToResizeColumns = False

        ' btnGetData.Enabled = False
        frmARO_OtherDetails.ShowDialog()


    End Sub



    Public Sub ShowResponsibilityCenter()
        cmbOffice.DataSource = ClsConn.LoadData("SELECT RCNumber, Office from ResponsibilityCenter order by RCNumber asc").DefaultView
        cmbOffice.ValueMember = "RCNumber"
        'cmbOffice.DisplayMember = "RCNumber"
        cmbOffice.DisplayMember = "RCNumber"
    End Sub
    Private Sub frmARO_Augmentation_Load(sender As Object, e As EventArgs) Handles Me.Load
        theme.myCustomSkinDark(Me)
        Me.Size = DashBoard.FlowLayoutPanel0.Size
        ShowResponsibilityCenter()
        ARODGV.Enabled = False

    End Sub
    Private Sub ARODGV_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles ARODGV.CellValueChanged
        Try


            If ARODGV.Columns(e.ColumnIndex).Name = "Appropriation" Then
                Dim runningTotal As Decimal = 0
                For i As Integer = 0 To ARODGV.Rows.Count - 1
                    If Not ARODGV.Rows(i).IsNewRow Then
                        Dim cellValue As Decimal
                        If ARODGV.Rows(i).Cells("Appropriation").Value Is Nothing Then
                            ARODGV.Rows(i).Cells("Appropriation").Value = "0.00"
                        End If
                        If Decimal.TryParse(ARODGV.Rows(i).Cells("Appropriation").Value.ToString(), cellValue) Then
                            runningTotal += cellValue
                        Else
                            ' Handle invalid input
                        End If

                    End If
                Next
                ARODGV.Rows(ARODGV.Rows.Count - 1).Cells("Appropriation").Value = String.Format("{0:N2}", runningTotal)
            End If

            If ARODGV.Columns(e.ColumnIndex).Name = "Augmentation" Then
                Dim runningTotal As Decimal = 0
                For i As Integer = 0 To ARODGV.Rows.Count - 1
                    If Not ARODGV.Rows(i).IsNewRow Then
                        Dim cellValue As Decimal
                        If ARODGV.Rows(i).Cells("Augmentation").Value Is Nothing Then
                            ARODGV.Rows(i).Cells("Augmentation").Value = "0.00"
                        End If
                        If Decimal.TryParse(ARODGV.Rows(i).Cells("Augmentation").Value.ToString(), cellValue) Then
                            runningTotal += cellValue
                        Else
                            ' Handle invalid input
                        End If

                    End If
                Next
                ARODGV.Rows(ARODGV.Rows.Count - 1).Cells("Augmentation").Value = String.Format("{0:N2}", runningTotal)
            End If
            If ARODGV.Columns(e.ColumnIndex).Name = "Reversion" Then
                Dim runningTotal As Decimal = 0
                For i As Integer = 0 To ARODGV.Rows.Count - 1
                    If Not ARODGV.Rows(i).IsNewRow Then
                        Dim cellValue As Decimal
                        If ARODGV.Rows(i).Cells("Reversion").Value Is Nothing Then
                            ARODGV.Rows(i).Cells("Reversion").Value = "0.00"
                        End If
                        If Decimal.TryParse(ARODGV.Rows(i).Cells("Reversion").Value.ToString(), cellValue) Then
                            runningTotal += cellValue
                        Else
                            ' Handle invalid input
                        End If

                    End If
                Next
                ARODGV.Rows(ARODGV.Rows.Count - 1).Cells("Reversion").Value = String.Format("{0:N2}", runningTotal)
            End If
            If ARODGV.Columns(e.ColumnIndex).Name = "SupplementalBudget" Then
                Dim runningTotal As Decimal = 0
                For i As Integer = 0 To ARODGV.Rows.Count - 1
                    If Not ARODGV.Rows(i).IsNewRow Then
                        Dim cellValue As Decimal
                        If ARODGV.Rows(i).Cells("SupplementalBudget").Value Is Nothing Then
                            ARODGV.Rows(i).Cells("SupplementalBudget").Value = "0.00"
                        End If
                        If Decimal.TryParse(ARODGV.Rows(i).Cells("SupplementalBudget").Value.ToString(), cellValue) Then
                            runningTotal += cellValue
                        Else
                            ' Handle invalid input
                        End If

                    End If
                Next
                ARODGV.Rows(ARODGV.Rows.Count - 1).Cells("SupplementalBudget").Value = String.Format("{0:N2}", runningTotal)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ARODGV_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles ARODGV.CellEndEdit
        Try
            If ARODGV.Rows.Count > 0 Then

                If e.ColumnIndex = 4 Then
                    Dim value As String = ARODGV.Rows(e.RowIndex).Cells(4).Value.ToString
                    Dim newValue As Decimal
                    If Decimal.TryParse(value, newValue) Then
                        ARODGV.Rows(e.RowIndex).Cells(4).Value = String.Format("{0:N2}", newValue)

                    Else
                        'Handles invalid input
                    End If
                End If
                If e.ColumnIndex = 5 Then
                    Dim value As String = ARODGV.Rows(e.RowIndex).Cells(5).Value.ToString
                    Dim newValue As Decimal
                    If Decimal.TryParse(value, newValue) Then
                        ARODGV.Rows(e.RowIndex).Cells(5).Value = String.Format("{0:N2}", newValue)

                    Else
                        'Handles invalid input
                    End If
                End If
                If e.ColumnIndex = 6 Then
                    Dim value As String = ARODGV.Rows(e.RowIndex).Cells(6).Value.ToString
                    Dim newValue As Decimal
                    If Decimal.TryParse(value, newValue) Then
                        ARODGV.Rows(e.RowIndex).Cells(6).Value = String.Format("{0:N2}", newValue)

                    Else
                        'Handles invalid input
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbOffice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOffice.SelectedIndexChanged
        cmbOffice.ValueMember = "Office"
        txtOffice.Text = cmbOffice.SelectedValue.ToString
        cmbOffice.ValueMember = "RCNumber"
    End Sub
    Public id, aroid, entrydate, fy, office, purpose, fundcode As String

    Private Sub btnOption_Click(sender As Object, e As EventArgs) Handles btnOption.Click
        frmARO_Option.ShowDialog()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Try
        '    mode = 1
        '    If String.IsNullOrEmpty(txtPurpose.Text) Then
        '        MessageBox.Show("Please fill up required fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        Exit Sub
        '    End If
        '    If ARODGV.Rows.Count = 1 Then
        '        ARODGV.AllowUserToAddRows = False
        '        If ARODGV.Rows.Count = 0 Then
        '            MessageBox.Show("Sorry no data added to grid", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '            ARODGV.AllowUserToAddRows = True
        '            Exit Sub
        '        End If
        '        ARODGV.AllowUserToAddRows = True
        '    End If
        '    If ARODGV.Rows.Count = 0 Then
        '        MessageBox.Show("Sorry no data added to grid", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '        Exit Sub
        '    End If

        '    Dim ARO As New ClsARO
        '    With ARO
        '        '.ID = id
        '        .Purpose = txtPurpose.Text
        '        .EntryDate = Now().ToString("MM/dd/yyyy")
        '        Select Case mode
        '            Case Modes.add
        '                ' ARODGV.Columns.Remove("btnDelRow")
        '                .saveAllotment(ARODGV)
        '                customSnackbar(Me, "Record Successfully Saved", "Ok")
        '                'DashBoard.btnAddStudent.Enabled = False
        '                'btnSave.Enabled = False
        '            Case Modes.edit
        '                '.saveAllotment(ARODGV)
        '                'customSnackbar(Me, "Record Successfully Saved", "Ok")
        '                'btnSave.Text = "SAVE"
        '                'mode = Modes.add
        '                btnSave.Enabled = False
        '        End Select
        '        'Initial_State()
        '    End With
        '    'DashBoard.ShowRegistration()
        '    'ClearTextbox(Me)

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
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
                .ID = id
                .Purpose = txtPurpose.Text
                .EntryDate = Now().ToString("MM/dd/yyyy")
                Select Case mode
                    Case Modes.add
                    ' ARODGV.Columns.Remove("btnDelRow")
                    '.save(ARODGV)
                    'customSnackbar(Me, "Record Successfully Saved", "Ok")
                        'DashBoard.btnAddStudent.Enabled = False
                        'btnSave.Enabled = False
                    Case Modes.edit
                        .updateAugmentation(ARODGV)
                        .updateReversion(ARODGV)
                        .updateSupplementalBudget(ARODGV)
                        customSnackbar(Me, "Record Successfully updated", "Ok")
                        'btnSave.Text = "SAVE"
                        'mode = Modes.add
                End Select
                'Initial_State()
            End With
            'DashBoard.ShowRegistration()
            'ClearTextbox(Me)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub dataGridView1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles ARODGV.MouseDown
        If e.Button = MouseButtons.Right Then ' Check if right mouse button is clicked
            Dim hti As DataGridView.HitTestInfo = ARODGV.HitTest(e.X, e.Y) ' Get the info of clicked cell
            If hti.RowIndex >= 0 Then ' Check if a row is clicked
                ARODGV.ClearSelection() ' Clear any previously selected rows
                ' ARODGV.Rows(hti.RowIndex).Selected = True ' Select the clicked row
                ' ARODGV.Columns(hti.ColumnIndex).Selected = True

                ARODGV.CurrentCell = ARODGV(hti.ColumnIndex, hti.RowIndex)
                If hti.ColumnIndex = 0 Or hti.ColumnIndex = 1 Or hti.ColumnIndex = 2 Or hti.ColumnIndex = 3 Then
                    Exit Sub
                Else
                    If hti.RowIndex = ARODGV.Rows.Count - 1 Then
                        Exit Sub
                    End If
                    ContextMenuStrip1.Show(ARODGV, e.Location)   ' Show the context menu at the clicked location
                End If
            End If
        End If
    End Sub
    Public Property selectedRowIndex As Integer = 0
    Public Property selectedColumnIndex As Integer = 0



    Public Property selectedCellValue As String = ""
    Public Property defaultAccountCode As String = ""
    Public Property defauiltID As Integer = 0
    Public Property defaultDescription As String = ""


    Private Sub InsertRowAboveToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles EditSelectedItemToolStripMenuItem.Click
        selectedRowIndex = ARODGV.CurrentCell.RowIndex ' Get the index of the selected row
        selectedColumnIndex = ARODGV.CurrentCell.ColumnIndex  ' Get the index of the selected row
        selectedCellValue = ARODGV.Rows(selectedRowIndex).Cells(selectedColumnIndex).Value.ToString()
        defauiltID = ARODGV.Rows(selectedRowIndex).Cells(3).Value
        defaultDescription = ARODGV.Rows(selectedRowIndex).Cells(1).Value.ToString
        'For 5-02 Report where there are multiple offices 
        Dim GroupColumns As Integer()() = New Integer(2)() {}

        GroupColumns(0) = New Integer() {0, 1, 2, 3} 'Appropriation
        GroupColumns(1) = New Integer() {4, 5, 6} 'Adjustments



        Dim searchColumn As Integer = selectedColumnIndex

        Dim foundIndex As Integer = -1

        For i As Integer = 0 To GroupColumns.Length - 1 'loop through each sub-array
            If Array.IndexOf(GroupColumns(i), searchColumn) >= 0 Then 'check if office is found in sub-array
                foundIndex = i 'set found index to current sub-array index
                Exit For 'exit loop if office is found
            End If
        Next

        If foundIndex >= 0 Then ' is found

            If foundIndex = 1 Then
                'MsgBox("Selected Row: " & selectedRowIndex & vbCrLf & "Selected Column: " & selectedColumnIndex & vbCrLf & "Cell Value: " & selectedCellValue & vbCrLf & "Selected Column: " & ARODGV.Rows(selectedRowIndex).Cells(3).Value.ToString())
                If searchColumn = 4 Then 'augmentation
                    ShowAdjustment(ARODGV.Rows(selectedRowIndex).Cells(3).Value.ToString, 1)
                    frmARO_Adjustments_OtherDetails.Text = "Augmentation"
                End If
                If searchColumn = 5 Then 'reversion
                    ShowAdjustment(ARODGV.Rows(selectedRowIndex).Cells(3).Value.ToString, 2)
                    frmARO_Adjustments_OtherDetails.Text = "Reversion"
                End If
                If searchColumn = 6 Then 'supplementalbudget
                    ShowAdjustment(ARODGV.Rows(selectedRowIndex).Cells(3).Value.ToString, 3)
                    frmARO_Adjustments_OtherDetails.Text = "Supplemental Budget"
                End If
                defaultAccountCode = ARODGV.Rows(selectedRowIndex).Cells(0).Value.ToString()

                frmARO_Adjustments_OtherDetails.FormStyle = FormStyles.ActionBar_40

                frmARO_Adjustments_OtherDetails.ShowDialog()
            End If


        Else ' not found
            MsgBox("Error")
        End If



    End Sub
    Sub ShowAdjustment(id As Integer, mode As Integer)
        ' Fetch the latest ID from the database
        If (ClsConn.OpenConnection() = True) Then
            Dim sql1 As String = "SELECT ID, AccountCode, Amount,Remarks, UID from ARO_Augmentation where ID=@ID order by uid asc"

            Dim sql2 As String = "SELECT ID, AccountCode, Amount,Remarks, UID from ARO_Reversion where ID=@ID order by uid asc"

            Dim sql3 As String = "SELECT ID, AccountCode, Amount,Remarks, UID from ARO_SupplementalBudget where ID=@ID order by uid asc"
            Dim sql As String = ""
            If mode = 1 Then
                sql = sql1
            ElseIf mode = 2 Then
                sql = sql2
            Else
                sql = sql3
            End If
            cmd = New SqlCommand(Sql, sqlCon)
            cmd.Parameters.AddWithValue("@ID", id)
            frmARO_Adjustments_OtherDetails.ARODGV.DataSource = Nothing
            frmARO_Adjustments_OtherDetails.ARODGV.Rows.Clear()
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While (rdr.Read() = True)
                frmARO_Adjustments_OtherDetails.ARODGV.Rows.Add(
                    rdr(0),
                    rdr(1),
                    Convert.ToDouble(rdr(2)).ToString("N2", CultureInfo.InvariantCulture),
                    rdr(3),
                   rdr(4)
                 )
            End While
            'Format Cellvalues to Decimal of Appropriation Column
            If frmARO_Adjustments_OtherDetails.ARODGV.Columns(2).Name = "Amount" Then
                Dim runningTotal As Decimal = 0
                For i As Integer = 0 To frmARO_Adjustments_OtherDetails.ARODGV.Rows.Count - 1
                    If Not frmARO_Adjustments_OtherDetails.ARODGV.Rows(i).IsNewRow Then
                        Dim cellValue As Decimal
                        If Decimal.TryParse(frmARO_Adjustments_OtherDetails.ARODGV.Rows(i).Cells("Amount").Value.ToString(), cellValue) Then
                            runningTotal += cellValue
                        Else
                            ' Handle invalid input
                        End If

                    End If
                Next
                frmARO_Adjustments_OtherDetails.ARODGV.Rows(frmARO_Adjustments_OtherDetails.ARODGV.Rows.Count - 1).Cells("Amount").Value = String.Format("{0:N2}", runningTotal)
            End If



            frmARO_Adjustments_OtherDetails.ARODGV.Enabled = True
            frmARO_Adjustments_OtherDetails.ARODGV.Columns(0).ReadOnly = True
            frmARO_Adjustments_OtherDetails.ARODGV.Columns(1).ReadOnly = True

            'frmARO_Adjustments_OtherDetails.ARODGV(2, frmARO_Adjustments_OtherDetails.ARODGV.Rows.Count - 1).ReadOnly = True
            frmARO_Adjustments_OtherDetails.ARODGV.Columns(4).ReadOnly = True
            ClsConn.CloseConnection()

        End If
    End Sub

    Private Sub ARODGV_KeyDown(sender As Object, e As KeyEventArgs) Handles ARODGV.KeyDown
        If e.KeyCode = Keys.F AndAlso e.Control Then ' check if ctrl+f is pressed
            e.SuppressKeyPress = True ' suppress the default behavior of ctrl+f
            Dim input As String = InputBox("Enter search text") ' show input box
            If Not String.IsNullOrEmpty(input) Then ' check if input is not empty
                Dim cell As DataGridViewCell = ARODGV.Rows.Cast(Of DataGridViewRow).SelectMany(Function(row) row.Cells.Cast(Of DataGridViewCell)).FirstOrDefault(Function(c) c.Value IsNot Nothing AndAlso c.Value.ToString().Contains(input)) ' find the cell containing the input
                If cell IsNot Nothing Then ' check if cell is found
                    ARODGV.CurrentCell = cell ' set the current cell to the found cell
                    ARODGV.Focus() ' focus the datagridview
                Else
                    MessageBox.Show($"Text '{input}' not found") ' show message box if text is not found
                End If
            End If
        End If
        If e.KeyCode = Keys.Enter Then
            InsertRowAboveToolStripMenuItem_Click_1(sender, e)
        End If
    End Sub

End Class