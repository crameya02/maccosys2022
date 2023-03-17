Imports Microsoft.Office.Interop.Excel
Imports System.Data.SqlClient
Imports System.Data
Imports MaterialSkin.Controls
Imports System.Text.RegularExpressions
Imports System.Windows
Imports Bunifu.UI.WinForms

Public Class frmARO
    'Private Sub BunifuDataGridView2_Paint(sender As Object, e As PaintEventArgs) _
    'Handles ARODGV.Paint
    '    If ARODGV.Rows.Count = 1 Then
    '        TextRenderer.DrawText(e.Graphics, "No records found.",
    '        ARODGV.Font, ARODGV.ClientRectangle,
    '        ARODGV.ForeColor, ARODGV.BackgroundColor,
    '        TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
    '    End If
    'End Sub
    Dim resourcePath As String = My.Application.Info.DirectoryPath.ToString
    Private Sub frmARO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        theme.myCustomSkinDark(Me)
        Me.Size = DashBoard.FlowLayoutPanel0.Size
        Dim columnToMakeReadOnly As DataGridViewColumn = ARODGV.Columns("Description")
        columnToMakeReadOnly.ReadOnly = True


        'ARODGV.AllowUserToAddRows = False


        'ARODGV.DataSource = Nothing
        'ARODGV.Columns.Clear()
        'ARODGV.Rows.Clear()
        'ShowRegistration()
        'Dim deleteimg As New DataGridViewImageColumn()
        'Dim inImgdelete As Image = Image.FromFile(resourcePath & "\dgwbuttons\light\icons8-trash-24.png")
        'MessageBox.Show(resourcePath & "\dgwbuttons\light\icons8-trash-24.png")
        'deleteimg.Image = inImgdelete
        'ARODGV.Columns.Add(deleteimg)
        'deleteimg.HeaderText = ""
        'deleteimg.Name = "btnDelRow"
        'deleteimg.Width = 50

        'Dim btn As New DataGridViewButtonColumn()
        'ARODGV.Columns.Add(btn)
        'With btn
        '    .HeaderText = ""
        '    .Text = "Delete"
        '    .Name = "btnDelRow"
        '    .UseColumnTextForButtonValue = True
        '    .Width = 220

        'End With
        'ARODGV.AutoResizeColumns()
        'ARODGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ShowResponsibilityCenter()

        'SuggestOffice()
    End Sub
    Private Function GenerateautoAccountCode() As String
        Dim value As String = "0"
        ' Dim iCell1 As String = DataGridView1.CurrentRow.Cells(0).Value
        Try
            ' Fetch the latest ID from the database
            sqlCon.Open()
            'old  cmd = New SqlCommand("SELECT TOP 1 ID FROM Advice ORDER BY ID DESC where AdviceName = '" & txtAdviceName.Text & "'", con)
            cmd = New SqlCommand("SELECT Account_Title FROM ChartOfAccounts WHERE Account_Code = '" & teststring.ToString & "'", sqlCon)
            'cmd = New SqlCommand("SELECT Account_Title FROM ChartOfAccounts WHERE Account_Code = '4-02-01-130'", con)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            If rdr.HasRows Then
                rdr.Read()
                value = rdr.Item("Account_Title")
            End If
            rdr.Close()

        Catch ex As Exception
            ' If an error occurs, check the connection state and close it if necessary.
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            If sqlCon.State = ConnectionState.Open Then
                sqlCon.Close()
            End If
            value = ""
        End Try
        Return value

    End Function
    Sub auto()
        ARODGV.CurrentRow.Cells(1).Value = GenerateautoAccountCode()
    End Sub
    Dim teststring As String
    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles ARODGV.CellEndEdit
        Try
            If ARODGV.Rows.Count > 0 Then
                If e.ColumnIndex = 0 Then
                    ARODGV.Rows(e.RowIndex).Cells(0).Value = ARODGV.Rows(e.RowIndex).Cells(0).Value.ToString().Insert(0, txtFundCode.Text.Remove(0, 1) & "-")


                    teststring = Convert.ToString(ARODGV.Rows(e.RowIndex).Cells(0).Value)

                    auto()
                    If ARODGV.Rows(e.RowIndex).Cells(2).Value Is Nothing Then
                        ARODGV.Rows(e.RowIndex).Cells(2).Value = "0.00"
                    End If
                End If
                    If e.ColumnIndex = 2 Then
                    Dim value As String = ARODGV.Rows(e.RowIndex).Cells(2).Value.ToString



                    Dim newValue As Decimal
                    If Decimal.TryParse(value, newValue) Then
                        ARODGV.Rows(e.RowIndex).Cells(2).Value = String.Format("{0:N2}", newValue)
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
    'Private Sub dataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles ARODGV.CellFormatting
    '    ' Check if the DataGridView has rows
    '    If ARODGV.RowCount > 0 Then
    '        ' Check if the column you want to format is being processed
    '        If ARODGV.Columns(e.ColumnIndex).Name = "AccountCode" Then
    '            ' Check if the value of the cell is not Nothing
    '            If Not e.Value Is Nothing Then
    '                ' Format the value of the cell
    '                e.Value = String.Format("{0:00}-{1:000}", e.Value.ToString().Substring(0, 2), e.Value.ToString().Substring(2, 3))
    '                e.FormattingApplied = True
    '            End If
    '        End If
    '    End If
    'End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ARODGV.CellContentClick
        'If e.ColumnIndex = 3 = True Then
        '    If MsgBox("Are you sure you want to delete this record?", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Delete") = MsgBoxResult.Cancel Then
        '        Exit Sub
        '    Else
        '        If ARODGV.Columns(e.ColumnIndex).Name = "btnDelRow" AndAlso Me.ARODGV.Rows(e.RowIndex).IsNewRow = False Then
        '            Me.ARODGV.EndEdit()
        '            Me.ARODGV.Rows.RemoveAt(e.RowIndex)
        '        End If

        '    End If
        'End If
    End Sub
    Private Sub getDatasuggest(ByVal dataCollection As AutoCompleteStringCollection)
        Dim connectionforsuggest As SqlConnection
        Dim commandforsuggest As SqlCommand
        Dim adapterforsuggest As New SqlDataAdapter()
        Dim dsforsuggest As New DataSet()
        Dim sChars As String = " "
        Dim sqlforsuggest As String = "SELECT DISTINCT [Office] FROM [ResponsibilityCenter]"
        connectionforsuggest = sqlCon
        Try
            connectionforsuggest.Open()
            commandforsuggest = New SqlCommand(sqlforsuggest, connectionforsuggest)
            adapterforsuggest.SelectCommand = commandforsuggest
            adapterforsuggest.Fill(dsforsuggest)
            adapterforsuggest.Dispose()
            commandforsuggest.Dispose()
            connectionforsuggest.Close()

            For Each row As DataRow In dsforsuggest.Tables(0).Rows
                dataCollection.Add(row(0).ToString.TrimEnd(sChars))
            Next
        Catch ex As Exception
            MessageBox.Show("Can not open autosuggest connection!")
        End Try
    End Sub
    Sub SuggestOffice()
        Dim textbox As TextBox
        textbox.AutoCompleteMode = AutoCompleteMode.Suggest
        textbox.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim DataCollection As New AutoCompleteStringCollection()
        getDatasuggest(DataCollection)
        textbox.AutoCompleteCustomSource = DataCollection
    End Sub
    Public Sub ShowResponsibilityCenter()
        cmbOffice.DataSource = ClsConn.LoadData("SELECT RCNumber, Office from ResponsibilityCenter order by RCID asc").DefaultView
        cmbOffice.ValueMember = "RCNumber"
        'cmbOffice.DisplayMember = "RCNumber"
        cmbOffice.DisplayMember = "RCNumber"
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Try

        'If String.IsNullOrEmpty(txtPurpose.Text) Then
        '    MessageBox.Show("Please fill up required fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Exit Sub
        'End If
        If btnSave.Text = "Save" Then
            mode = 1

        Else

            mode = 2
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

                Select Case mode
                    Case Modes.add

                        Dim txtautoID = autoID("SELECT TOP 1 ID FROM ARO ORDER BY ID DESC")
                        .ID = txtautoID.txtID
                        .AROID = txtautoID.txtNo
                        .EntryDate = Now().ToString("MM/dd/yyyy")
                        .FY = Now.Year
                        .Office = cmbOffice.Text
                        .Purpose = txtPurpose.Text
                        .FundCode = txtFundCode.Text
                        '.Description = txtContact.Text
                        '.AccountCode = Now().ToString("yyyy-MM-dd HH:mm:ss")
                        '.Appropriation = txtContact.Text
                        .ForLaterRelease = "0"
                        .PreviouslyRelease = "0"
                        .Allotment = "0"
                        ' ARODGV.Columns.Remove("btnDelRow")
                        .saveAppro(ARODGV)
                        customSnackbar(Me, "Record Successfully Saved", "Ok")
                        'DashBoard.btnAddStudent.Enabled = False
                        btnSave.Enabled = False

                    Case Modes.edit

                    .ID = id
                    .AROID = aroid
                    .Office = cmbOffice.Text
                        .FundCode = txtFundCode.Text
                        .updateAppro(ARODGV)
                        customSnackbar(Me, "Record Successfully Updated", "Ok")
                        '    SnackBarMessage.Show(Me)
                        '    btnSave.Text = "SAVE"
                        '    MaterialLabel1.Text = "Add Student"
                        '    mode = Modes.add
                        '    txtID.Enabled = True

                End Select
                'Initial_State()
            End With
        'DashBoard.ShowRegistration()
        'ClearTextbox(Me)
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub
    Public id, aroid, entrydate, fy, office, purpose, fundcode As String

    Private Sub btnOption_Click(sender As Object, e As EventArgs) Handles btnOption.Click
        frmARO_Option.ShowDialog()
    End Sub

    Private Sub btnGetData_Click(sender As Object, e As EventArgs) Handles btnGetData.Click
        'frmARO_OtherDetails.Size = New System.Drawing.Size(1117, 525)
        mode = 2
        action = 1
        frmARO_OtherDetails.FormStyle = FormStyles.ActionBar_40
        frmARO_OtherDetails.TopLevel = True
        frmARO_OtherDetails.ARODGV.AllowUserToAddRows = False
        frmARO_OtherDetails.ARODGV.AllowUserToResizeColumns = False
        frmARO_OtherDetails.ARODGV.AllowUserToResizeRows = False
        frmARO_OtherDetails.ARODGV.AllowUserToDeleteRows = False
        frmARO_OtherDetails.ARODGV.AllowUserToResizeColumns = False
        frmARO_OtherDetails.ShowDialog()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

    End Sub

    Private Sub cmbOffice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOffice.SelectedIndexChanged
        cmbOffice.ValueMember = "Office"
        txtOffice.Text = cmbOffice.SelectedValue.ToString
        cmbOffice.ValueMember = "RCNumber"
    End Sub
    Private Sub ARODGV_KeyDown(sender As Object, e As KeyEventArgs) Handles ARODGV.KeyDown
        If e.KeyCode = Keys.F1 Then
            frmChartofAccounts.Size = New System.Drawing.Size(1117, 525)
            frmChartofAccounts.FormStyle = FormStyles.ActionBar_40
            frmChartofAccounts.TopLevel = True
            frmChartofAccounts.COADGV.AllowUserToAddRows = False
            frmChartofAccounts.COADGV.AllowUserToResizeColumns = False
            frmChartofAccounts.COADGV.AllowUserToResizeRows = False
            frmChartofAccounts.COADGV.AllowUserToDeleteRows = False
            frmChartofAccounts.COADGV.AllowUserToResizeColumns = False
            frmChartofAccounts.COAsearchString = txtFundCode.Text.Remove(0, 1)
            frmChartofAccounts.ShowDialog()

        End If

        If e.KeyCode = Keys.Delete Then
            If mode = 2 Then

                Dim message As String = "Are you sure you want to delete this item?" & vbCrLf & vbCrLf & "" & vbCrLf & vbCrLf & "This action cannot be undone."
            Dim title As String = "Confirmation"
            Dim buttons As MessageBoxButtons = MessageBoxButtons.OKCancel

            Dim result As DialogResult = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

            If result = DialogResult.OK Then
                ' User clicked OK, perform the action
                Dim ARODeleteAppro As New ClsARO
                With ARODeleteAppro
                    .deleteAppropriationID(ARODGV.CurrentRow.Cells(3).Value.ToString())
                    Dim SnackBarMessage1 As MaterialSkin.Controls.MaterialSnackBar
                    SnackBarMessage1 = New MaterialSkin.Controls.MaterialSnackBar("Record Successfully deleted", "Ok", True)
                    SnackBarMessage1.Show(Me)
                End With
            Else
                e.Handled = True ' Cancel the Delete key down event
            End If

            End If
        End If
    End Sub


    Private Sub ARODGV_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles ARODGV.UserDeletingRow
        Try
            If mode = 2 Then
                Dim deletedValue As Decimal
                If Decimal.TryParse(e.Row.Cells("Allotment").Value.ToString(), deletedValue) Then
                    ' Recalculate the total amount
                    Dim runningTotal As Decimal = 0
                    For i As Integer = 0 To ARODGV.Rows.Count - 1
                        If Not ARODGV.Rows(i).IsNewRow Then
                            Dim cellValue As Decimal
                            If Decimal.TryParse(ARODGV.Rows(i).Cells("Allotment").Value.ToString(), cellValue) Then
                                runningTotal += cellValue
                                If ARODGV.RowCount = 0 Then
                                    runningTotal = 0.00
                                Else

                                End If
                            Else
                                ' Handle invalid input

                            End If
                        End If
                    Next
                    ' Update the value in the last row

                    ARODGV.Rows(ARODGV.Rows.Count - 1).Cells("Allotment").Value = String.Format("{0:N2}", runningTotal)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ARODGV_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles ARODGV.CellFormatting
        'If e.ColumnIndex = 2 AndAlso e.Value Is Nothing Then
        '    e.Value = "0.00"
        '    e.FormattingApplied = True
        'End If
    End Sub

    Private Sub ARODGV_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles ARODGV.CellValueChanged
        Try


            If ARODGV.Columns(e.ColumnIndex).Name = "Appropriation" Then
                Dim runningTotal As Decimal = 0
                For i As Integer = 0 To ARODGV.Rows.Count - 1
                    If Not ARODGV.Rows(i).IsNewRow Then
                        Dim cellValue As Decimal
                        If Decimal.TryParse(ARODGV.Rows(i).Cells("Appropriation").Value.ToString(), cellValue) Then
                            runningTotal += cellValue
                        Else
                            ' Handle invalid input
                        End If

                    End If
                Next
                ARODGV.Rows(ARODGV.Rows.Count - 1).Cells("Appropriation").Value = String.Format("{0:N2}", runningTotal)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click

        ARODGV.DataSource = Nothing
        ARODGV.Rows.Clear()
        btnSave.Enabled = False
        btnSave.Enabled = True
        btnSave.Text = "Save"
    End Sub



End Class