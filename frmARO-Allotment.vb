Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Windows.Interop
Imports Microsoft.SqlServer.Management.Smo
Imports System.Linq

Public Class frmARO_Allotment
    Public Sub ShowAppro()
        frmARO.ARODGV.DataSource = ClsConn.LoadData("SELECT AccountCode as Account_Code, Description as Description, Appropriation as Appropriation FROM ARO_OtherDetails").DefaultView
    End Sub
    Private Sub btnGetData_Click(sender As Object, e As EventArgs) Handles btnGetData.Click
        'frmARO_OtherDetails.Size = New System.Drawing.Size(1117, 525)
        mode = 1
        action = 2
        frmARO_OtherDetails.FormStyle = FormStyles.ActionBar_40
        frmARO_OtherDetails.TopLevel = True
        frmARO_OtherDetails.ARODGV.AllowUserToAddRows = False
        frmARO_OtherDetails.ARODGV.AllowUserToResizeColumns = False
        frmARO_OtherDetails.ARODGV.AllowUserToResizeRows = False
        frmARO_OtherDetails.ARODGV.AllowUserToDeleteRows = False
        frmARO_OtherDetails.ARODGV.AllowUserToResizeColumns = False

        frmARO_OtherDetails.ShowDialog()

    End Sub
    Public Sub ShowResponsibilityCenter()
        cmbOffice.DataSource = ClsConn.LoadData("SELECT RCNumber, Office from ResponsibilityCenter order by RCNumber asc").DefaultView
        cmbOffice.ValueMember = "RCNumber"
        'cmbOffice.DisplayMember = "RCNumber"
        cmbOffice.DisplayMember = "RCNumber"
    End Sub
    Private Sub frmARO_Allotment_Load(sender As Object, e As EventArgs) Handles Me.Load
        theme.myCustomSkinDark(Me)
        Me.Size = DashBoard.FlowLayoutPanel0.Size
        ShowResponsibilityCenter()
        ARODGV.Enabled = False
    End Sub
    Private Sub ARODGV_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles ARODGV.CellValueChanged
        Try


            If ARODGV.Columns(e.ColumnIndex).Name = "Allotment" Then
                Dim runningTotal As Decimal = 0
                For i As Integer = 0 To ARODGV.Rows.Count - 1
                    If Not ARODGV.Rows(i).IsNewRow Then
                        Dim cellValue As Decimal
                        If ARODGV.Rows(i).Cells("Allotment").Value Is Nothing Then
                            ARODGV.Rows(i).Cells("Allotment").Value = "0.00"
                        End If
                        If Decimal.TryParse(ARODGV.Rows(i).Cells("Allotment").Value.ToString(), cellValue) Then
                            runningTotal += cellValue
                        Else
                            ' Handle invalid input
                        End If

                    End If
                Next

                ARODGV.Rows(ARODGV.Rows.Count - 1).Cells("Allotment").Value = String.Format("{0:N2}", runningTotal)
            End If
            If ARODGV.Columns(e.ColumnIndex).Name = "prevAllot" Then
                Dim runningTotal As Decimal = 0
                For i As Integer = 0 To ARODGV.Rows.Count - 1
                    If Not ARODGV.Rows(i).IsNewRow Then
                        Dim cellValue As Decimal
                        If ARODGV.Rows(i).Cells("prevAllot").Value Is Nothing Then
                            ARODGV.Rows(i).Cells("prevAllot").Value = "0.00"
                        End If
                        If Decimal.TryParse(ARODGV.Rows(i).Cells("prevAllot").Value.ToString(), cellValue) Then
                            runningTotal += cellValue
                        Else
                            ' Handle invalid input
                        End If

                    End If
                Next

                ARODGV.Rows(ARODGV.Rows.Count - 1).Cells("PrevAllot").Value = String.Format("{0:N2}", runningTotal)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ARODGV_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles ARODGV.CellEndEdit
        Try
            If ARODGV.Rows.Count > 0 Then

                If ARODGV.Columns(e.ColumnIndex).Name = "Allotment" Then
                    If ARODGV.Rows(e.RowIndex).Cells("Allotment").Value Is Nothing Then
                        ARODGV.Rows(e.RowIndex).Cells("Allotment").Value = "0.00"
                    Else
                        Dim value As String = ARODGV.Rows(e.RowIndex).Cells("Allotment").Value.ToString()
                        Dim newValue As Decimal
                        If Decimal.TryParse(value, newValue) Then
                            ARODGV.Rows(e.RowIndex).Cells("Allotment").Value = String.Format("{0:N2}", newValue)

                        Else
                            'Handles invalid input
                        End If
                    End If
                End If
                If ARODGV.Columns(e.ColumnIndex).Name = "prevAllot" Then
                    If ARODGV.Rows(e.RowIndex).Cells("prevAllot").Value Is Nothing Then
                        ARODGV.Rows(e.RowIndex).Cells("prevAllot").Value = "0.00"
                    Else
                        Dim value As String = ARODGV.Rows(e.RowIndex).Cells("prevAllot").Value.ToString()
                        Dim newValue As Decimal
                        If Decimal.TryParse(value, newValue) Then
                            ARODGV.Rows(e.RowIndex).Cells("prevAllot").Value = String.Format("{0:N2}", newValue)

                        Else
                            'Handles invalid input
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub cmbOffice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOffice.SelectedIndexChanged
        cmbOffice.ValueMember = "Office"
        txtOffice.Text = cmbOffice.SelectedValue.ToString
        cmbOffice.ValueMember = "RCNumber"
    End Sub
    Public id, aroid, entrydate, fy, office, purpose, fundcode As String


    Private Sub ToggleColumnVisibilityWithChecker(dgv As DataGridView, colIndex As Integer, showColumn As Boolean)
        Dim col As DataGridViewColumn = dgv.Columns(colIndex)
        If showColumn Then
            col.Visible = True
        Else
            col.Visible = False
        End If
    End Sub

    Private Sub cmbPurpose_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPurpose.SelectedIndexChanged
        Try
            If cmbPurpose.SelectedItem.ToString() = "1st Quarter Release" Then
                ToggleColumnVisibilityWithChecker(ARODGV, 6, False)
            Else
                ToggleColumnVisibilityWithChecker(ARODGV, 6, True)
            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ToggleColumnVisibility(dgv As DataGridView, colIndex As Integer)
        Dim col As DataGridViewColumn = dgv.Columns(colIndex)
        col.Visible = Not col.Visible
    End Sub
    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        ToggleColumnVisibility(ARODGV, 4)
        ToggleColumnVisibility(ARODGV, 5)

    End Sub

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Try

            Dim columnIndex As Integer = 7 ' Set the column index to Column of PurposeAllot
            Dim desiredText As String = cmbPurpose.Text

            For rowIndex = ARODGV.RowCount - 1 To 0 Step -1
                Dim cellValue As Object = ARODGV(columnIndex, rowIndex).Value
                If cellValue IsNot Nothing AndAlso Not String.IsNullOrEmpty(cellValue.ToString()) AndAlso cellValue.ToString() <> desiredText Then
                    ARODGV.Rows.RemoveAt(rowIndex)
                End If
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtPurpose_TextChanged(sender As Object, e As EventArgs) Handles txtPurpose.TextChanged

    End Sub

    Private Sub btnsFLP_Paint(sender As Object, e As PaintEventArgs) Handles btnsFLP.Paint

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim message As String = "Are you sure you want to perform this action?" & vbCrLf & vbCrLf & "By doing so, the Allotment values will be set to 0.00 so you can create a new instance of Appropriation (e.g. '2nd Quarter Release')." & vbCrLf & vbCrLf & "This action cannot be undone."
        Dim title As String = "Confirmation"
        Dim buttons As MessageBoxButtons = MessageBoxButtons.OKCancel

        Dim result As DialogResult = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If result = DialogResult.OK Then
            ' User clicked OK, perform the action



            mode = 1

            id = ""
            aroid = ""
            entrydate = ""
            fy = ""
            office = ""
            purpose = ""
            fundcode = ""
            txtPurpose.Text = ""
            cmbPurpose.SelectedIndex = 0
            cmbPurpose.Enabled = False
            cmbPurpose.Enabled = True
            For i As Integer = 0 To ARODGV.Rows.Count - 1
                If Not ARODGV.Rows(i).IsNewRow Then
                    ARODGV.Rows(i).Cells("Allotment").Value = "0.00"
                    ARODGV.Rows(i).Cells("UUID").Value = ""
                    ARODGV.Rows(i).Cells("prevAllot").Value = "0.00"
                    ARODGV.Rows(i).Cells("PurposeAllot").Value = ""
                End If
            Next
            btnSave.Enabled = True
            btnUpdate.Enabled = False

        Else
            ' User clicked Cancel, do nothing
        End If



    End Sub

    Private Sub btnOption_Click(sender As Object, e As EventArgs) Handles btnOption.Click
        frmARO_Option.ShowDialog()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            mode = 1
            If String.IsNullOrEmpty(cmbPurpose.Text) Then
                MessageBox.Show("Please fill up required fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
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
                '.ID = id
                ' .Purpose = txtPurpose.Text
                .Purpose = cmbPurpose.Text
                .EntryDate = Now().ToString("MM/dd/yyyy")

                Select Case mode
                    Case Modes.add
                        ' ARODGV.Columns.Remove("btnDelRow")
                        .saveAllotment(ARODGV)
                        customSnackbar(Me, "Record Successfully Saved", "Ok")

                        'DashBoard.btnAddStudent.Enabled = False
                        btnSave.Enabled = False
                    Case Modes.edit
                        '.saveAllotment(ARODGV)
                        'customSnackbar(Me, "Record Successfully Saved", "Ok")
                        'btnSave.Text = "SAVE"
                        'mode = Modes.add
                        'btnSave.Enabled = False
                End Select
                'Initial_State()
            End With
            'DashBoard.ShowRegistration()
            'ClearTextbox(Me)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            mode = 2
            If String.IsNullOrEmpty(cmbPurpose.Text) Then
                MessageBox.Show("Please fill up required fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
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
                '.Purpose = txtPurpose.Text
                .Purpose = cmbPurpose.Text
                .EntryDate = Now().ToString("MM/dd/yyyy")
                Select Case mode
                    Case Modes.add
                    ' ARODGV.Columns.Remove("btnDelRow")
                    '.save(ARODGV)
                    'customSnackbar(Me, "Record Successfully Saved", "Ok")
                        'DashBoard.btnAddStudent.Enabled = False
                        'btnSave.Enabled = False
                    Case Modes.edit
                        .updateAllotment(ARODGV)
                        customSnackbar(Me, "Record Successfully updated", "Ok")

                        btnUpdate.Enabled = False
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
    End Sub
End Class