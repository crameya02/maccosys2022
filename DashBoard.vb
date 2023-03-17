Imports System.IO
Imports Bunifu.UI.WinForms
Imports MaterialSkin.Controls
Public Class DashBoard

    Private Sub DashBoardTabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DashBoardTabControl.SelectedIndexChanged
        If DashBoardTabControl.SelectedIndex = 7 Then
            'frmChartofAccountsV2.WindowState = FormWindowState.Maximized
            ''frmChartofAccounts.COADGV.Columns(0).Visible = True
            'frmChartofAccountsV2.FormStyle = FormStyles.StatusAndActionBar_None
            FormToDisplay(frmChartofAccountsV2, FlowLayoutPanel6)
        End If
        If DashBoardTabControl.SelectedIndex = 6 Then
            frmResponsibilityCenter.WindowState = FormWindowState.Maximized
            frmResponsibilityCenter.RCDGV.Columns(0).Visible = True
            frmResponsibilityCenter.FormStyle = FormStyles.StatusAndActionBar_None
            FormToDisplay(frmResponsibilityCenter, FlowLayoutPanel5)

        End If
        If DashBoardTabControl.SelectedIndex = 1 Then
            frmARO_Option.ShowDialog()
        End If
        If DashBoardTabControl.SelectedIndex = 2 Then
            FlowLayoutPanel1.Controls.Clear()
            'frmOBRE.WindowState = FormWindowState.Maximized
            'frmOBRE.ARODGV.Columns(0).Visible = True
            'frmOBRE.FormStyle = FormStyles.StatusAndActionBar_None
            FormToDisplay(frmOBRE, FlowLayoutPanel1)
        End If
        If DashBoardTabControl.SelectedIndex = 3 Then
            FlowLayoutPanel2.Controls.Clear()
            'frmOBRE.WindowState = FormWindowState.Maximized
            'frmOBRE.ARODGV.Columns(0).Visible = True
            'frmOBRE.FormStyle = FormStyles.StatusAndActionBar_None
            FormToDisplay(frmSAAOB, FlowLayoutPanel2)
        End If
    End Sub
    Private Sub DashBoard_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        frmARO.Size = FlowLayoutPanel0.Size
        frmARO_Allotment.Size = FlowLayoutPanel0.Size
        frmARO_Adjustments.Size = FlowLayoutPanel0.Size
        frmOBRE.Size = FlowLayoutPanel1.Size
        frmChartofAccountsV2.Size = FlowLayoutPanel6.Size
        frmSAAOB.Size = FlowLayoutPanel2.Size
        frmReport.Size = frmSAAOB.FlowLayoutPanel1.Size
    End Sub
    Private Sub DashBoard_Load(sender As Object, e As EventArgs) Handles Me.Load
        theme.myCustomSkinDark(Me)
        Me.Size = New Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height)

    End Sub

End Class