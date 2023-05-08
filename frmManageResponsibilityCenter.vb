Imports System.Security.Cryptography
Imports Microsoft.SqlServer.Management.Smo

Public Class frmManageResponsibilityCenter

    Private Sub addDefaultColumnstoDGV()
        RCDGV.Columns.Clear()
        ' Add the ID column
        Dim idColumn As New DataGridViewTextBoxColumn()
        idColumn.HeaderText = "NO"
        idColumn.Name = "RCID"
        RCDGV.Columns.Add(idColumn)

        Dim rcNumberColumn As New DataGridViewTextBoxColumn()
        rcNumberColumn.HeaderText = "Office Code"
        rcNumberColumn.Name = "RCNumber"
        RCDGV.Columns.Add(rcNumberColumn)

        Dim officeColumn As New DataGridViewTextBoxColumn()
        officeColumn.HeaderText = "Office Code"
        officeColumn.Name = "Office"
        RCDGV.Columns.Add(officeColumn)

        Dim officeGroupColumn As New DataGridViewTextBoxColumn()
        officeGroupColumn.HeaderText = "Group"
        officeGroupColumn.Name = "OfficeGroup"
        RCDGV.Columns.Add(officeGroupColumn)

        Dim uidColumn As New DataGridViewTextBoxColumn()
        uidColumn.HeaderText = "UID"
        uidColumn.Name = "UID"
        RCDGV.Columns.Add(uidColumn)

    End Sub

    Private Sub loadResponsibilityCenter()
        Try
            With RCDGV
                addDefaultColumnstoDGV()
                RCDGV.Rows.Clear() ' Clear all existing rows before adding new ones

                Dim str As String = String.Format("SELECT RCID as NO, RCNumber as [Office Code], Office as [Office Name], OfficeGroup as [Group], UID FROM ResponsibilityCenter ORDER BY RCID ASC")
                Dim dt As DataTable = ClsConn.LoadData(str)

                For Each row As DataRow In dt.Rows
                    Dim index As Integer = .Rows.Add()
                    .Rows(index).Cells(0).Value = row("NO")
                    .Rows(index).Cells(1).Value = row("Office Code")
                    .Rows(index).Cells(2).Value = row("Office Name")
                    .Rows(index).Cells(3).Value = row("Group")
                    .Rows(index).Cells(4).Value = row("UID")
                Next
                .Columns(4).Visible = False
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub frmManageResponsibilityCenter_Load(sender As Object, e As EventArgs) Handles Me.Load
        theme.myCustomSkinDark(Me)
        loadResponsibilityCenter()


    End Sub

    Private Sub RCDGV_MouseDown(sender As Object, e As MouseEventArgs) Handles RCDGV.MouseDown
        If e.Button = MouseButtons.Right Then ' Check if right mouse button is clicked
            Dim hti As DataGridView.HitTestInfo = RCDGV.HitTest(e.X, e.Y) ' Get the info of clicked cell
            If hti.RowIndex >= 0 Then ' Check if a row is clicked
                RCDGV.ClearSelection() ' Clear any previously selected rows
                RCDGV.Rows(hti.RowIndex).Selected = True ' Select the clicked row
                ContextMenuStrip1.Show(RCDGV, e.Location) ' Show the context menu at the clicked location
            End If
        End If
    End Sub

    Private Sub InsertRowAboveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertRowAboveToolStripMenuItem.Click
        Dim selectedRowIndex As Integer = RCDGV.SelectedRows(0).Index ' Get the index of the selected row
        RCDGV.Rows.Insert(selectedRowIndex, 1) ' Insert a new row above the selected row

        For i As Integer = 0 To RCDGV.Rows.Count - 2 ' Update the IDs of the rows below the new row
            RCDGV.Rows(i).Cells("RCID").Value = i + 1
        Next

    End Sub

    Private Sub InsertRowBelowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertRowBelowToolStripMenuItem.Click
        Dim selectedRowIndex As Integer = RCDGV.SelectedRows(0).Index ' Get the index of the selected row
        RCDGV.Rows.Insert(selectedRowIndex + 1, 1) ' Insert a new row below the selected row

        For i As Integer = 0 To RCDGV.Rows.Count - 2 ' Update the IDs of the rows below the new row
            RCDGV.Rows(i).Cells("RCID").Value = i + 1
        Next

    End Sub

    Private Sub RCDGV_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles RCDGV.UserDeletedRow
        Try
            For i As Integer = 0 To RCDGV.Rows.Count - 2 ' Update the IDs of the rows below the new row
                RCDGV.Rows(i).Cells("RCID").Value = i + 1
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try



            If RCDGV.Rows.Count = 1 Then
                RCDGV.AllowUserToAddRows = False
                If RCDGV.Rows.Count = 0 Then
                    MessageBox.Show("Sorry no data added to grid", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    RCDGV.AllowUserToAddRows = True
                    Exit Sub
                End If
                RCDGV.AllowUserToAddRows = True
            End If
            If RCDGV.Rows.Count = 0 Then
                MessageBox.Show("Sorry no data added to grid", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If


            Dim resCenter As New ClsResponsibilityCenter
            With resCenter
                .updateResponsilibityCenter(RCDGV)
                customSnackbar(Me, "Record Successfully Updated", "Ok")
                loadResponsibilityCenter()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RCDGV_KeyDown(sender As Object, e As KeyEventArgs) Handles RCDGV.KeyDown
        If e.KeyCode = Keys.Delete Then


            Dim message As String = "Are you sure you want to delete this item?" & vbCrLf & vbCrLf & "" & vbCrLf & vbCrLf & "This action cannot be undone."
            Dim title As String = "Confirmation"
            Dim buttons As MessageBoxButtons = MessageBoxButtons.OKCancel

            Dim result As DialogResult = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

            If result = DialogResult.OK Then
                ' User clicked OK, perform the action
                If RCDGV.CurrentRow.Cells(4).Value Is Nothing Then
                    'automatically remove the row
                    Exit Sub
                Else
                    Dim rcDeleteOffice As New ClsResponsibilityCenter
                    With rcDeleteOffice
                        .deleteResponsibilityCenter(RCDGV.CurrentRow.Cells(4).Value.ToString())
                        Dim SnackBarMessage1 As MaterialSkin.Controls.MaterialSnackBar
                        SnackBarMessage1 = New MaterialSkin.Controls.MaterialSnackBar("Record Successfully deleted", "Ok", True)
                        SnackBarMessage1.Show(Me)
                        loadResponsibilityCenter()
                    End With

                End If

            Else
                e.Handled = True ' Cancel the Delete key down event
            End If


        End If
        If e.KeyCode = Keys.F AndAlso e.Control Then ' check if ctrl+f is pressed
            e.SuppressKeyPress = True ' suppress the default behavior of ctrl+f
            Dim input As String = InputBox("Enter search text") ' show input box
            If Not String.IsNullOrEmpty(input) Then ' check if input is not empty
                Dim cell As DataGridViewCell = RCDGV.Rows.Cast(Of DataGridViewRow).SelectMany(Function(row) row.Cells.Cast(Of DataGridViewCell)).FirstOrDefault(Function(c) c.Value IsNot Nothing AndAlso c.Value.ToString().Contains(input)) ' find the cell containing the input
                If cell IsNot Nothing Then ' check if cell is found
                    RCDGV.CurrentCell = cell ' set the current cell to the found cell
                    RCDGV.Focus() ' focus the datagridview
                Else
                    MessageBox.Show($"Text '{input}' not found") ' show message box if text is not found
                End If
            End If
        End If
    End Sub


    Private Sub txtSearchRC_TextChanged(sender As Object, e As EventArgs) Handles txtSearchRC.TextChanged
        Try
            With RCDGV
                addDefaultColumnstoDGV()
                RCDGV.Rows.Clear() ' Clear all existing rows before adding new ones
                Dim str As String = String.Format("SELECT RCID as NO, RCNumber as [Office Code], Office as [Office Name], OfficeGroup as [Group], UID FROM ResponsibilityCenter WHERE (RCNumber LIKE '{0}%') OR (Office LIKE '{0}%') ORDER BY RCID ASC", txtSearchRC.Text)
                Dim dt As DataTable = ClsConn.LoadData(str)


                For Each row As DataRow In dt.Rows
                    Dim index As Integer = .Rows.Add()
                    .Rows(index).Cells(0).Value = row("NO")
                    .Rows(index).Cells(1).Value = row("Office Code")
                    .Rows(index).Cells(2).Value = row("Office Name")
                    .Rows(index).Cells(3).Value = row("Group")
                    .Rows(index).Cells(4).Value = row("UID")
                Next
                .Columns(4).Visible = False
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RCDGV_DoubleClick(sender As Object, e As EventArgs) Handles RCDGV.DoubleClick
        Try

            'exact search
            Dim input As String = RCDGV.CurrentRow.Cells(0).Value.ToString
            txtSearchRC.Clear()

            If Not String.IsNullOrEmpty(input) Then ' check if input is not empty
                Dim cell As DataGridViewCell = RCDGV.Rows.Cast(Of DataGridViewRow).SelectMany(Function(row) row.Cells.Cast(Of DataGridViewCell)).FirstOrDefault(Function(c) c.Value IsNot Nothing AndAlso String.Equals(c.Value.ToString(), input, StringComparison.Ordinal)) ' find the cell containing the input
                If cell IsNot Nothing Then ' check if cell is found
                    RCDGV.CurrentCell = cell ' set the current cell to the found cell
                    RCDGV.Focus() ' focus the datagridview
                Else
                    MessageBox.Show($"Text '{input}' not found") ' show message box if text is not found
                End If
            End If

        Catch ex As Exception
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If txtSearchRC.Text = "" Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If
    End Sub
End Class