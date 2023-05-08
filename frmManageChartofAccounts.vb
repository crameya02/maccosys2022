Public Class frmManageChartofAccounts
    Private Sub addDefaultColumnstoDGV()
        COADGV.Columns.Clear()
        ' Add the ID column
        Dim idColumn As New DataGridViewTextBoxColumn()
        idColumn.HeaderText = "NO"
        idColumn.Name = "AID"
        COADGV.Columns.Add(idColumn)

        Dim rcNumberColumn As New DataGridViewTextBoxColumn()
        rcNumberColumn.HeaderText = "Account Code"
        rcNumberColumn.Name = "Account_Code"
        COADGV.Columns.Add(rcNumberColumn)

        Dim officeColumn As New DataGridViewTextBoxColumn()
        officeColumn.HeaderText = "Account Title"
        officeColumn.Name = "Account_Title"
        COADGV.Columns.Add(officeColumn)

        Dim uidColumn As New DataGridViewTextBoxColumn()
        uidColumn.HeaderText = "UID"
        uidColumn.Name = "UID"
        COADGV.Columns.Add(uidColumn)

    End Sub
    Private Sub loadChartofAccounts()
        Try
            With COADGV
                addDefaultColumnstoDGV()
                COADGV.Rows.Clear() ' Clear all existing rows before adding new ones

                Dim str As String = String.Format("SELECT AID as NO, Account_Code as [Account Code], Account_Title as [Account Title],  UID FROM ChartOfAccounts ORDER BY AID ASC")
                Dim dt As DataTable = ClsConn.LoadData(str)

                For Each row As DataRow In dt.Rows
                    Dim index As Integer = .Rows.Add()
                    .Rows(index).Cells(0).Value = row("NO")
                    .Rows(index).Cells(1).Value = row("Account Code")
                    .Rows(index).Cells(2).Value = row("Account Title")
                    .Rows(index).Cells(3).Value = row("UID")
                Next
                .Columns(3).Visible = False
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub frmManageChartofAccounts_Load(sender As Object, e As EventArgs) Handles Me.Load
        theme.myCustomSkinDark(Me)
        loadChartofAccounts()
    End Sub
    Private Sub COADGV_MouseDown(sender As Object, e As MouseEventArgs) Handles COADGV.MouseDown
        If e.Button = MouseButtons.Right Then ' Check if right mouse button is clicked
            Dim hti As DataGridView.HitTestInfo = COADGV.HitTest(e.X, e.Y) ' Get the info of clicked cell
            If hti.RowIndex >= 0 Then ' Check if a row is clicked
                COADGV.ClearSelection() ' Clear any previously selected rows
                COADGV.Rows(hti.RowIndex).Selected = True ' Select the clicked row
                ContextMenuStrip1.Show(COADGV, e.Location) ' Show the context menu at the clicked location
            End If
        End If
    End Sub

    Private Sub InsertRowAboveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertRowAboveToolStripMenuItem.Click
        Dim selectedRowIndex As Integer = COADGV.SelectedRows(0).Index ' Get the index of the selected row
        COADGV.Rows.Insert(selectedRowIndex, 1) ' Insert a new row above the selected row

        For i As Integer = 0 To COADGV.Rows.Count - 2 ' Update the IDs of the rows below the new row
            COADGV.Rows(i).Cells("AID").Value = i + 1
        Next

    End Sub

    Private Sub InsertRowBelowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InsertRowBelowToolStripMenuItem.Click
        Dim selectedRowIndex As Integer = COADGV.SelectedRows(0).Index ' Get the index of the selected row
        COADGV.Rows.Insert(selectedRowIndex + 1, 1) ' Insert a new row below the selected row

        For i As Integer = 0 To COADGV.Rows.Count - 2 ' Update the IDs of the rows below the new row
            COADGV.Rows(i).Cells("AID").Value = i + 1
        Next

    End Sub

    Private Sub COADGV_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles COADGV.UserDeletedRow
        Try


            For i As Integer = 0 To COADGV.Rows.Count - 2 ' Update the IDs of the rows below the new row
                COADGV.Rows(i).Cells("AID").Value = i + 1
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try



            If COADGV.Rows.Count = 1 Then
                COADGV.AllowUserToAddRows = False
                If COADGV.Rows.Count = 0 Then
                    MessageBox.Show("Sorry no data added to grid", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    COADGV.AllowUserToAddRows = True
                    Exit Sub
                End If
                COADGV.AllowUserToAddRows = True
            End If
            If COADGV.Rows.Count = 0 Then
                MessageBox.Show("Sorry no data added to grid", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If


            Dim charOfAccounts As New ClsChartOfAccounts
            With charOfAccounts
                .updateChartOfAccounts(COADGV)
                customSnackbar(Me, "Record Successfully Updated", "Ok")
                loadChartofAccounts()
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub COADGV_KeyDown(sender As Object, e As KeyEventArgs) Handles COADGV.KeyDown
        If e.KeyCode = Keys.Delete Then


            Dim message As String = "Are you sure you want to delete this item?" & vbCrLf & vbCrLf & "" & vbCrLf & vbCrLf & "This action cannot be undone."
            Dim title As String = "Confirmation"
            Dim buttons As MessageBoxButtons = MessageBoxButtons.OKCancel

            Dim result As DialogResult = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

            If result = DialogResult.OK Then
                ' User clicked OK, perform the action
                If COADGV.CurrentRow.Cells(3).Value Is Nothing Then
                    'automatically remove the row
                    Exit Sub
                Else
                    Dim rcDeleteCOA As New ClsChartOfAccounts
                    With rcDeleteCOA
                        .deleteChartOfAccounts(COADGV.CurrentRow.Cells(3).Value.ToString())
                        Dim SnackBarMessage1 As MaterialSkin.Controls.MaterialSnackBar
                        SnackBarMessage1 = New MaterialSkin.Controls.MaterialSnackBar("Record Successfully deleted", "Ok", True)
                        SnackBarMessage1.Show(Me)
                        loadChartofAccounts()
                    End With

                End If

            Else
                e.Handled = True ' Cancel the Delete key down event
            End If


        End If
    End Sub



    Private Sub txtSearchCOA_TextChanged(sender As Object, e As EventArgs) Handles txtSearchCOA.TextChanged
        Try
            With COADGV
                addDefaultColumnstoDGV()
                COADGV.Rows.Clear() ' Clear all existing rows before adding new ones

                Dim str As String = String.Format("SELECT AID as NO, Account_Code as [Account Code], Account_Title as [Account Title],  UID  FROM ChartOfAccounts WHERE (Account_Code LIKE '{0}%') OR (Account_Title LIKE '{0}%')  ORDER BY AID ASC", txtSearchCOA.Text)
                Dim dt As DataTable = ClsConn.LoadData(str)

                For Each row As DataRow In dt.Rows
                    Dim index As Integer = .Rows.Add()
                    .Rows(index).Cells(0).Value = row("NO")
                    .Rows(index).Cells(1).Value = row("Account Code")
                    .Rows(index).Cells(2).Value = row("Account Title")
                    .Rows(index).Cells(3).Value = row("UID")
                Next
                .Columns(3).Visible = False
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If txtSearchCOA.Text = "" Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If
    End Sub


    Private Sub COADGV_DoubleClick(sender As Object, e As EventArgs) Handles COADGV.DoubleClick
        Try

            'exact search
            Dim input As String = COADGV.CurrentRow.Cells(0).Value.ToString
            txtSearchCOA.Clear()

            If Not String.IsNullOrEmpty(input) Then ' check if input is not empty
                Dim cell As DataGridViewCell = COADGV.Rows.Cast(Of DataGridViewRow).SelectMany(Function(row) row.Cells.Cast(Of DataGridViewCell)).FirstOrDefault(Function(c) c.Value IsNot Nothing AndAlso String.Equals(c.Value.ToString(), input, StringComparison.Ordinal)) ' find the cell containing the input
                If cell IsNot Nothing Then ' check if cell is found
                    COADGV.CurrentCell = cell ' set the current cell to the found cell
                    COADGV.Focus() ' focus the datagridview
                    'scroll datagridview to current cell
                    ' get the selected cell
                    ' Dim selectedCell As DataGridViewCell = DataGridView1.SelectedCells(0)

                    ' scroll to the selected cell
                    COADGV.FirstDisplayedScrollingRowIndex = cell.RowIndex
                    COADGV.FirstDisplayedScrollingColumnIndex = cell.ColumnIndex


                Else
                    MessageBox.Show($"Text '{input}' not found") ' show message box if text is not found
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class