Imports System.Data.SqlClient
Imports System.Windows.Interop

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
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ARODGV_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles ARODGV.CellEndEdit
        'Try
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
        End If
        'Catch ex As Exception

        'End Try

    End Sub

    Private Sub cmbOffice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOffice.SelectedIndexChanged
        cmbOffice.ValueMember = "Office"
        txtOffice.Text = cmbOffice.SelectedValue.ToString
        cmbOffice.ValueMember = "RCNumber"
    End Sub
    Public id, aroid, entrydate, fy, office, purpose, fundcode As String

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

            For i As Integer = 0 To ARODGV.Rows.Count - 1
                If Not ARODGV.Rows(i).IsNewRow Then
                    ARODGV.Rows(i).Cells("Allotment").Value = "0.00"
                    ARODGV.Rows(i).Cells("UUID").Value = ""
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
                        .updateAllotment(ARODGV)
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


End Class