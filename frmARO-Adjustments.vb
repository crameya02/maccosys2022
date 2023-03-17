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
                If e.ColumnIndex = 7 Then
                    Dim value As String = ARODGV.Rows(e.RowIndex).Cells(7).Value.ToString
                    Dim newValue As Decimal
                    If Decimal.TryParse(value, newValue) Then
                        ARODGV.Rows(e.RowIndex).Cells(7).Value = String.Format("{0:N2}", newValue)

                    Else
                        'Handles invalid input
                    End If
                End If
                If e.ColumnIndex = 10 Then
                    Dim value As String = ARODGV.Rows(e.RowIndex).Cells(10).Value.ToString
                    Dim newValue As Decimal
                    If Decimal.TryParse(value, newValue) Then
                        ARODGV.Rows(e.RowIndex).Cells(10).Value = String.Format("{0:N2}", newValue)

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
        Try
            mode = 1
            If String.IsNullOrEmpty(txtPurpose.Text) Then
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
                .Purpose = txtPurpose.Text
                .EntryDate = Now().ToString("MM/dd/yyyy")
                Select Case mode
                    Case Modes.add
                        ' ARODGV.Columns.Remove("btnDelRow")
                        .saveAllotment(ARODGV)
                        customSnackbar(Me, "Record Successfully Saved", "Ok")
                        'DashBoard.btnAddStudent.Enabled = False
                        'btnSave.Enabled = False
                    Case Modes.edit
                        '.saveAllotment(ARODGV)
                        'customSnackbar(Me, "Record Successfully Saved", "Ok")
                        'btnSave.Text = "SAVE"
                        'mode = Modes.add
                        btnSave.Enabled = False
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
            ClearTextbox(Me)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class