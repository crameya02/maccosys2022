Public Class frmARO_Option
    Private Sub frmARO_Option_Load(sender As Object, e As EventArgs) Handles Me.Load
        theme.myCustomSkinDark(Me)
        DashBoard.FlowLayoutPanel0.Controls.Clear()
    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        If mrbAppro.Checked Then
            FormToDisplay(frmARO, DashBoard.FlowLayoutPanel0)
            Me.Close()
        End If
        If mrbAllot.Checked Then
            FormToDisplay(frmARO_Allotment, DashBoard.FlowLayoutPanel0)
            Me.Close()
        End If
        If mrbAdj.Checked Then
            FormToDisplay(frmARO_Adjustments, DashBoard.FlowLayoutPanel0)
            Me.Close()
        End If
    End Sub
End Class