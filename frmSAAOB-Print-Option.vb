Imports System.Data.SqlClient
Imports System.Globalization
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportAppServer.Controllers
Imports CrystalDecisions.Shared
Imports Microsoft
Imports Newtonsoft.Json.Linq

Public Class frmSAAOB_Print_Option
    Public Sub ShowResponsibilityCenter()
        cmbOffice.DataSource = ClsConn.LoadData("SELECT RCNumber, Office from ResponsibilityCenter order by RCID asc").DefaultView
        cmbOffice.ValueMember = "RCNumber"
        'cmbOffice.DisplayMember = "RCNumber"
        cmbOffice.DisplayMember = "RCNumber"
    End Sub
    Private Sub frmSAAOB_Print_Option_Load(sender As Object, e As EventArgs) Handles Me.Load
        theme.myCustomSkinDark(Me)
        ShowResponsibilityCenter()
        txtDateFrom.Text = "01/01/2023"
        txtDateTo.Text = Now.ToShortDateString
    End Sub
    Private Sub cmbOffice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOffice.SelectedIndexChanged
        cmbOffice.ValueMember = "Office"
        txtOffice.Text = cmbOffice.SelectedValue.ToString
        cmbOffice.ValueMember = "RCNumber"
    End Sub
    Private Sub dtpDateFrom_DropDown(sender As Object, e As EventArgs) Handles dtpDateFrom.DropDown
        Using form As New Form
            form.FormBorderStyle = FormBorderStyle.None
            form.StartPosition = FormStartPosition.Manual
            form.Location = Cursor.Position
            form.ShowInTaskbar = False
            Dim calendarControl As New ClsCalendarControl
            AddHandler calendarControl.DateSelected, AddressOf CalendarControl_DateSelectedFrom
            form.Controls.Add(calendarControl)
            form.ClientSize = New Size(calendarControl._calendar.Size.Width + 49, calendarControl._calendar.Size.Height + 7)
            calendarControl.Dock = DockStyle.Fill

            form.ShowDialog()
        End Using
    End Sub
    Private Sub CalendarControl_DateSelectedFrom(sender As Object, e As EventArgs)
        Dim calendarControl = DirectCast(sender, ClsCalendarControl)
        'MessageBox.Show("Selected date: " & calendarControl.SelectedDate.ToShortDateString())
        txtDateFrom.Text = calendarControl.SelectedDate.ToShortDateString()
        calendarControl.FindForm().Close()
        SendKeys.Send("{TAB}")
    End Sub
    Private Sub dtpDateTo_DropDown(sender As Object, e As EventArgs) Handles dtpDateTo.DropDown
        Using formcalendar As New Form()
            formcalendar.FormBorderStyle = FormBorderStyle.None
            formcalendar.StartPosition = FormStartPosition.Manual
            formcalendar.Location = Cursor.Position
            formcalendar.ShowInTaskbar = False

            Dim calendarControl As New ClsCalendarControl
            AddHandler calendarControl.DateSelected, AddressOf CalendarControl_DateSelectedTo
            formcalendar.Controls.Add(calendarControl)
            formcalendar.ClientSize = New Size(calendarControl._calendar.Size.Width + 49, calendarControl._calendar.Size.Height + 7)
            calendarControl.Dock = DockStyle.Fill


            formcalendar.ShowDialog()


        End Using

    End Sub
    Private Sub CalendarControl_DateSelectedTo(sender As Object, e As EventArgs)
        Dim calendarControl = DirectCast(sender, ClsCalendarControl)
        'MessageBox.Show("Selected date: " & calendarControl.SelectedDate.ToShortDateString())
        txtDateTo.Text = calendarControl.SelectedDate.ToShortDateString()
        calendarControl.FindForm().Close()
        SendKeys.Send("{TAB}")
    End Sub



    Sub Print()
        Try
            Dim reportdocument As New rptSAAOB
            reportdocument.SetDatabaseLogon("sa", "xxx", "localhost", "0218_DB")
            'reportdocument.SetParameterValue("office", "1011") this is the normal setting of parameter
            Dim OfficeNameStr As String = ""
            If (ClsConn.OpenConnection() = True) Then
                Dim sql As String = "SELECT Office from ResponsibilityCenter WHERE RCNumber=@RCNUMBER"
                cmd = New SqlCommand(sql, sqlCon)
                Dim param As New SqlParameter("@RCNUMBER", cmbOffice.Text)
                cmd.Parameters.Add(param)

                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                While (rdr.Read())
                    OfficeNameStr = rdr(0).ToString
                End While
                ClsConn.CloseConnection()
            End If

            'For 5-02 Report where there are multiple offices 
            Dim GroupOffices As String()() = New String(3)() {}

            GroupOffices(0) = New String() {"1011-3", "1011-3.a", "1011-3.b", "1011-3.c", "1011-3.d"} 'MENRO
            GroupOffices(1) = New String() {"1011-6", "1011-6.a", "1011-6.b", "1011-6.c", "1011-6.d", "1011-6.e", "1011-6.f", "1011-6.g", "1011-6.h", "1011-6.i", "1011-6.j"} 'TOURISM
            GroupOffices(2) = New String() {"1051", "1051-CRM", "1051-MR"} 'MCR
            GroupOffices(3) = New String() {"9999-1", "9999-2.a", "9999-2.b", "9999-2.c", "9999-2.d", "9999-2.e", "9999-2.f", "9999-2.g", "9999-2.h", "9999-2.i", "9999-3", "9999-3-PRAISE", "9999-3-EMPREC", "9999-3-RTRMNT", "9999-3-INHOUSE", "9999-3-EMPDAY", "9999-3-CSCCEL", "9999-3-SCHOLAR", "9999-4.a", "9999-4.b", "9999-4.c", "9999-4.d", "9999-4.e", "9999-4.f", "9999-5.a", "9999-5.b", "9999-5.c", "9999-5.d", "9999-5.e", "9999-5.f", "9999-5.g", "9999-6.a", "9999-6.b", "9999-6.c", "9999-6.d", "9999-6.e", "9999-6.f", "9999-6.g", "9999-6.h", "9999-7.a", "9999-7.b", "9999-7.c", "9999-8.a", "9999-8.b", "9999-8.c", "9999-8.c-KBTAAN", "9999-8.c-KLGTSN", "9999-8.c-LDRSHP", "9999-8.c-PDJEP", "9999-8.c-PSCAA", "9999-8.c-SKDRG", "9999-9", "9999-10", "9999-10.a", "9999-10.b", "9999-10.c", "9999-10.d", "9999-10.e", "9999-10.f", "9999-10.g", "9999-10.h", "9999-10.i", "9999-10.j", "9999-10.k", "9999-10.l", "9999-10.m", "9999-10.n", "9999-10.o"} 'NON-OFFICE

            Dim searchoffice As String = cmbOffice.Text
            'MsgBox(searchoffice)
            'Dim foundIndex As Integer = 1 'initialize to -1 if office is not found

            'For i As Integer = 0 To GroupOffices.Length - 1 'loop through each sub-array

            '    If Array.IndexOf(GroupOffices(i), searchoffice) >= 0 Then 'check if office is found in sub-array
            '        foundIndex = i 'set found index to current sub-array index
            '        Exit For 'exit loop if office is found
            '    End If
            'Next
            Dim foundIndex As Integer = -1

            For i As Integer = 0 To GroupOffices.Length - 1 'loop through each sub-array
                If Array.IndexOf(GroupOffices(i), searchoffice) >= 0 Then 'check if office is found in sub-array
                    foundIndex = i 'set found index to current sub-array index
                    Exit For 'exit loop if office is found
                End If
            Next

            If foundIndex >= 0 Then 'office is found
                If foundIndex = 3 Then 'office is belongs to 9999
                    'MsgBox(searchoffice & " found in group " & foundIndex + 1)
                    Dim reportdocumentnonoffice As New rptSAAOBnonOffice
                    reportdocumentnonoffice.SetDatabaseLogon("sa", "xxx", "localhost", "0218_DB")
                    Dim dateString1 As String = txtDateFrom.Text
                    Dim dateObj1 As DateTime = DateTime.Parse(dateString1)
                    Dim startOfYear1 As New DateTime(dateObj1.Year, 1, 1)
                    Dim newDateString1 As String = startOfYear1.ToString("MM/dd/yyyy")

                    Dim inputDateStr1 As String = txtDateTo.Text
                    Dim inputFormatStr1 As String = "MM/dd/yyyy"
                    Dim outputFormatStr1 As String = "MMMM dd, yyyy"

                    Dim inputDate1 As DateTime = DateTime.ParseExact(inputDateStr1, inputFormatStr1, CultureInfo.InvariantCulture)
                    Dim outputDateStr1 As String = inputDate1.ToString(outputFormatStr1)
                    Dim rptDateString1 = "As of " + outputDateStr1
                    reportdocumentnonoffice.SetParameterValue("asOfDate", rptDateString1, "rptSAAOB502107nonOffice.rpt")
                    reportdocumentnonoffice.SetParameterValue("asOfDate", rptDateString1)

                    reportdocumentnonoffice.SetParameterValue("office", GroupOffices(foundIndex), "rptSAAOB502107nonOffice.rpt")
                    'this is for custom total for non office groups
                    Dim CustomGroupOfficesHR() As String = {"9999-3", "9999-3-PRAISE", "9999-3-EMPREC", "9999-3-RTRMNT", "9999-3-INHOUSE", "9999-3-EMPDAY", "9999-3-CSCCEL", "9999-3-SCHOLAR"} 'hr

                    reportdocumentnonoffice.SetParameterValue("officefortotalHR", CustomGroupOfficesHR, "rptSAAOB502107nonOffice.rpt")
                    'this is for custom total for non office groups
                    Dim CustomGroupOfficesYouth() As String = {"9999-8.c", "9999-8.c-KBTAAN", "9999-8.c-KLGTSN", "9999-8.c-LDRSHP", "9999-8.c-PDJEP", "9999-8.c-PSCAA", "9999-8.c-SKDRG"} 'youth

                    reportdocumentnonoffice.SetParameterValue("officefortotalYouth", CustomGroupOfficesYouth, "rptSAAOB502107nonOffice.rpt")


                    reportdocumentnonoffice.SetParameterValue("datefromAROAllot", newDateString1, "rptSAAOB502107nonOffice.rpt")
                    reportdocumentnonoffice.SetParameterValue("datefrom", txtDateFrom.Text, "rptSAAOB502107nonOffice.rpt")
                    reportdocumentnonoffice.SetParameterValue("dateto", txtDateTo.Text, "rptSAAOB502107nonOffice.rpt")









                    frmReport.CrystalReportViewer1.ReportSource = reportdocumentnonoffice

                    frmSAAOB.FlowLayoutPanel1.Controls.Clear()
                    FormToDisplay(frmReport, frmSAAOB.FlowLayoutPanel1)
                    frmReport.Size = frmSAAOB.FlowLayoutPanel1.Size
                    Exit Sub
                Else 'when office belongs to other group , use the same report as when office in not found, but the office parameter in crystal uses multiple offices found in the groupOffices(foundindex)
                    ' MsgBox(searchoffice & " found in group " & foundIndex + 1)
                    reportdocument.SetParameterValue("office", GroupOffices(foundIndex), "rptSAAOB502.rpt")
                    reportdocument.SetParameterValue("office", GroupOffices(foundIndex), "rptSAAOBGrandTotal.rpt")
                End If

            Else 'if office is not found
                ' MsgBox(searchoffice & " not found")
                reportdocument.SetParameterValue("office", searchoffice, "rptSAAOB502.rpt")
                reportdocument.SetParameterValue("office", searchoffice, "rptSAAOBGrandTotal.rpt")

            End If
            Dim inputDateStr As String = txtDateTo.Text
            Dim inputFormatStr As String = "MM/dd/yyyy"
            Dim outputFormatStr As String = "MMMM dd, yyyy"

            Dim inputDate As DateTime = DateTime.ParseExact(inputDateStr, inputFormatStr, CultureInfo.InvariantCulture)
            Dim outputDateStr As String = inputDate.ToString(outputFormatStr)
            Dim rptDateString = "As of " + outputDateStr
            reportdocument.SetParameterValue("asOfDate", rptDateString)
            reportdocument.SetParameterValue("office", cmbOffice.Text)

            'Dim offices As String() = {"1011-3", "1011-3.a", "1011-3.b", "1011-3.c", "1011-3.d"}
            reportdocument.SetParameterValue("office", cmbOffice.Text, "rptSAAOB501.rpt")
            'this part is for the persisting data like Appropriation and ALlotment where it always gets all the available value of starting to the selected end date
            Dim dateString As String = txtDateFrom.Text
            Dim dateObj As DateTime = DateTime.Parse(dateString)
            Dim startOfYear As New DateTime(dateObj.Year, 1, 1)
            Dim newDateString As String = startOfYear.ToString("MM/dd/yyyy")

            reportdocument.SetParameterValue("datefromAROAllot", newDateString, "rptSAAOB501.rpt")
            reportdocument.SetParameterValue("datefrom", txtDateFrom.Text, "rptSAAOB501.rpt")
            reportdocument.SetParameterValue("dateto", txtDateTo.Text, "rptSAAOB501.rpt")
            reportdocument.SetParameterValue("Office_Name", OfficeNameStr, "rptSAAOB501.rpt")

            'reportdocument.SetParameterValue("office", offices, "rptSAAOB502.rpt")
            reportdocument.SetParameterValue("datefromAROAllot", newDateString, "rptSAAOB502.rpt")
            reportdocument.SetParameterValue("datefrom", txtDateFrom.Text, "rptSAAOB502.rpt")
            reportdocument.SetParameterValue("dateto", txtDateTo.Text, "rptSAAOB502.rpt")

            reportdocument.SetParameterValue("datefromAROAllot", newDateString, "rptSAAOB107.rpt")
            reportdocument.SetParameterValue("office", cmbOffice.Text, "rptSAAOB107.rpt")
            reportdocument.SetParameterValue("datefrom", txtDateFrom.Text, "rptSAAOB107.rpt")
            reportdocument.SetParameterValue("dateto", txtDateTo.Text, "rptSAAOB107.rpt")
            If cmbOffice.Text = "1091" Then
                reportdocument.SetParameterValue("title", "4. Property, Plant and Equipment", "rptSAAOB107.rpt")
            Else
                reportdocument.SetParameterValue("title", "3. Property, Plant and Equipment", "rptSAAOB107.rpt")
            End If

            reportdocument.SetParameterValue("datefromAROAllot", newDateString, "rptSAAOB503.rpt")
            reportdocument.SetParameterValue("office", cmbOffice.Text, "rptSAAOB503.rpt")
            reportdocument.SetParameterValue("datefrom", txtDateFrom.Text, "rptSAAOB503.rpt")
            reportdocument.SetParameterValue("dateto", txtDateTo.Text, "rptSAAOB503.rpt")

            'reportdocument.SetParameterValue("office", cmbOffice.Text, "rptSAAOBGrandTotal.rpt")
            reportdocument.SetParameterValue("datefromAROAllot", newDateString, "rptSAAOBGrandTotal.rpt")
            reportdocument.SetParameterValue("datefrom", txtDateFrom.Text, "rptSAAOBGrandTotal.rpt")
            reportdocument.SetParameterValue("dateto", txtDateTo.Text, "rptSAAOBGrandTotal.rpt")

            frmReport.CrystalReportViewer1.ReportSource = reportdocument

            frmSAAOB.FlowLayoutPanel1.Controls.Clear()
            FormToDisplay(frmReport, frmSAAOB.FlowLayoutPanel1)
            frmReport.Size = frmSAAOB.FlowLayoutPanel1.Size
            '' frmReport.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        Me.Hide()
        Print()
        Me.Close()

    End Sub
End Class