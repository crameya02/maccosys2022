
Public Class frmReport
    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles Me.Load
        'HideReportTab(CrystalReportViewer1)


    End Sub
    Private Sub HideReportTab(ByVal crViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer)
        Dim control As Control
        Dim controlInPage As Control
        Dim tabs As TabControl

        For Each control In crViewer.Controls
            If TypeOf control Is CrystalDecisions.Windows.Forms.PageView Then
                For Each controlInPage In control.Controls
                    If TypeOf controlInPage Is TabControl Then
                        tabs = CType(controlInPage, TabControl)
                        tabs.ItemSize = New Size(0, 1)
                        tabs.SizeMode = TabSizeMode.Fixed
                        'MsgBox(tabs.Margin.ToString)
                        tabs.Margin = New Padding(0)

                    End If
                Next
            End If
        Next
    End Sub
End Class