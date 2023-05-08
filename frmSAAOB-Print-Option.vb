Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports System.Globalization
Imports System.IO
Imports System.Threading
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.ReportAppServer.Controllers
Imports CrystalDecisions.Shared
Imports Microsoft
Imports Microsoft.Office.Interop
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

        txtDateFrom.Text = "01/01/" & ReadWorkingYear()
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
        'Try
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
        GroupOffices(1) = New String() {"1011-6", "1011-6.a", "1011-6.b", "1011-6.c", "1011-6.d", "1011-6.e", "1011-6.f", "1011-6.g", "1011-6.h", "1011-6.i", "1011-6.j", "1011-6.k"} 'TOURISM
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
                'Dim newDateString1 As String = startOfYear1.ToString("MM/dd/yyyy")
                Dim newDateString1 As String = "01/01/" & ReadWorkingYear()

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
                'MsgBox(searchoffice & " found in group " & foundIndex + 1)
                reportdocument.SetParameterValue("office", GroupOffices(foundIndex), "rptSAAOB502.rpt")
                reportdocument.SetParameterValue("office", GroupOffices(foundIndex), "rptSAAOBGrandTotal.rpt")
            End If
        Else 'if office is not found
            'MsgBox(searchoffice & " not found")
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
        ' Dim newDateString As String = startOfYear.ToString("MM/dd/yyyy")
        Dim newDateString As String = "01/01/" & ReadWorkingYear()
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
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub
    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        Me.Hide()
        Print()
    End Sub
    Public Class SQLData
        Public Property SQLQuery As String
        Public Property DateFrom As String
        Public Property DateTo As String
    End Class

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Me.Hide()
        DashBoard.Hide()
        Loader.Show()
        Dim data As New SQLData()
        data.SQLQuery = "
WITH 


Original_ARO_Allotment_1 AS (
    SELECT ARO_Appropriation.UID, SUM(ISNULL(ARO_Allotment.Amount, 0)) AS Allotment,ARO_Allotment.ID
    FROM ARO_Appropriation
    LEFT JOIN ARO_Allotment ON ARO_Appropriation.UID = ARO_Allotment.ID
	 WHERE (ARO_Allotment.Purpose ='1st Quarter Release')
    GROUP BY ARO_Appropriation.UID ,ARO_Allotment.ID
),
Original_ARO_Allotment_2 AS (
    SELECT ARO_Appropriation.UID, SUM(ISNULL(ARO_Allotment.Amount, 0)) AS Allotment,ARO_Allotment.ID
    FROM ARO_Appropriation
    LEFT JOIN ARO_Allotment ON ARO_Appropriation.UID = ARO_Allotment.ID
	 WHERE  (ARO_Allotment.Purpose ='2nd Quarter Release')
    GROUP BY ARO_Appropriation.UID ,ARO_Allotment.ID
	),
Original_ARO_Allotment_3 AS (
    SELECT ARO_Appropriation.UID, SUM(ISNULL(ARO_Allotment.Amount, 0)) AS Allotment,ARO_Allotment.ID
    FROM ARO_Appropriation
    LEFT JOIN ARO_Allotment ON ARO_Appropriation.UID = ARO_Allotment.ID
	 WHERE  (ARO_Allotment.Purpose ='3rd Quarter Release')
    GROUP BY ARO_Appropriation.UID ,ARO_Allotment.ID
	),
Original_ARO_Allotment_4 AS (
    SELECT ARO_Appropriation.UID, SUM(ISNULL(ARO_Allotment.Amount, 0)) AS Allotment,ARO_Allotment.ID
    FROM ARO_Appropriation
    LEFT JOIN ARO_Allotment ON ARO_Appropriation.UID = ARO_Allotment.ID
	 WHERE  (ARO_Allotment.Purpose ='4th Quarter Release')
    GROUP BY ARO_Appropriation.UID ,ARO_Allotment.ID
	),
ARO_Augmentation_Summary AS (
    SELECT ARO_Appropriation.UID, SUM(ISNULL(ARO_Augmentation.Amount, 0)) AS Augmentation
    FROM ARO_Appropriation
    LEFT JOIN ARO_Augmentation ON ARO_Appropriation.UID = ARO_Augmentation.ID
	WHERE  ARO_Augmentation.DateModified Between @datefrom and @dateto
    GROUP BY ARO_Appropriation.UID 
),
ARO_Reversion_Summary AS (
    SELECT ARO_Appropriation.UID, SUM(ISNULL(ARO_Reversion.Amount, 0)) AS Reversion
    FROM ARO_Appropriation
    LEFT JOIN ARO_Reversion ON ARO_Appropriation.UID = ARO_Reversion.ID
	WHERE  ARO_Reversion.DateModified Between @datefrom and @dateto
    GROUP BY ARO_Appropriation.UID 
),
ARO_SupplementalBudget_Summary AS (
    SELECT ARO_Appropriation.UID, SUM(ISNULL(ARO_SupplementalBudget.Amount, 0)) AS SupplementalBudget
    FROM ARO_Appropriation
    LEFT JOIN ARO_SupplementalBudget ON ARO_Appropriation.UID = ARO_SupplementalBudget.ID
	WHERE  ARO_SupplementalBudget.DateModified Between @datefrom and @dateto
    GROUP BY ARO_Appropriation.UID 
),


AARA AS (
	SELECT ARO.ID, ARO_Appropriation.UID, ARO.FundCode, 
       ARO.Office, ARO_Appropriation.Description, 
       ARO_Appropriation.AccountCode, ARO_Appropriation.Amount AS Appropriation,
       ISNULL(Original_ARO_Allotment_1.Allotment, 0) AS Allotment1,
	   ISNULL(Original_ARO_Allotment_2.Allotment, 0) AS Allotment2,
	   ISNULL(Original_ARO_Allotment_3.Allotment, 0) AS Allotment3,
	   ISNULL(Original_ARO_Allotment_4.Allotment, 0) AS Allotment4,
	   ISNULL(AAS.Augmentation, 0) AS Augmentation,
	   ISNULL(ARS.Reversion, 0) AS Reversion,
	   ISNULL(ASBS.SupplementalBudget, 0) AS SupplementalBudget
	  
FROM ARO 
INNER JOIN ARO_Appropriation 
    ON ARO.ID = ARO_Appropriation.ID
LEFT JOIN Original_ARO_Allotment_1
    ON ARO_Appropriation.UID = Original_ARO_Allotment_1.ID
LEFT JOIN Original_ARO_Allotment_2
    ON ARO_Appropriation.UID = Original_ARO_Allotment_2.ID
LEFT JOIN Original_ARO_Allotment_3
    ON ARO_Appropriation.UID = Original_ARO_Allotment_3.ID
LEFT JOIN Original_ARO_Allotment_4
    ON ARO_Appropriation.UID = Original_ARO_Allotment_4.ID
	LEFT JOIN ARO_Augmentation_Summary as AAS
    ON ARO_Appropriation.UID = AAS.UID
	LEFT JOIN ARO_Reversion_Summary as ARS
    ON ARO_Appropriation.UID = ARS.UID
	LEFT JOIN ARO_SupplementalBudget_Summary as ASBS
    ON ARO_Appropriation.UID = ASBS.UID
	
  WHERE
               (ARO.EntryDate Between @datefrom and @dateto)
GROUP BY ARO.ID,
	ARO_Appropriation.UID,
	ARO.FundCode, 
         ARO.Office, 
		 ARO_Appropriation.Description,
         ARO_Appropriation.AccountCode,
		 ARO_Appropriation.Amount,
		 Original_ARO_Allotment_1.Allotment,
		 Original_ARO_Allotment_2.Allotment,
		 Original_ARO_Allotment_3.Allotment,
		 Original_ARO_Allotment_4.Allotment,
		 Augmentation,
		 Reversion,
		 SupplementalBudget
	),	
Balances AS (
    SELECT ResCenter AS Office, AccountCode, SUM(Amount) AS Obligations
    FROM OBRE_OtherDetails
   WHERE 
         (EntryDate BETWEEN @datefrom AND @dateto)
       
    GROUP BY AccountCode, ResCenter 
),
AllData as (
	SELECT ID,UID,FundCode,AARA.Office,Description,AARA.AccountCode,Appropriation,Allotment1
	,Allotment2,Allotment3,Allotment4,Augmentation,Reversion,SupplementalBudget,
	(CAST(AARA.Appropriation AS decimal(18,2)) + 
CAST(AARA.Augmentation AS decimal(18,2)) + 
CAST(AARA.Reversion AS decimal(18,2)) +
CAST(AARA.SupplementalBudget AS decimal(18,2)))
	 AS TotalAppropriation, 

(CAST(AARA.Augmentation AS decimal(18,2))+
CAST(AARA.Reversion AS decimal(18,2)) +
CAST(AARA.SupplementalBudget AS decimal(18,2)) + 
CAST(AARA.Allotment1 AS decimal(18,2))+
CAST(AARA.Allotment2 AS decimal(18,2))+
CAST(AARA.Allotment3 AS decimal(18,2))+
CAST(AARA.Allotment4 AS decimal(18,2)))  as TotalAllotment, 

CAST(Balances.Obligations AS decimal(18,2))
    as Obligations,

((CAST(AARA.Augmentation AS decimal(18,2))+
CAST(AARA.Reversion AS decimal(18,2)) +
CAST(AARA.SupplementalBudget AS decimal(18,2)) + 
CAST(AARA.Allotment1 AS decimal(18,2))+
CAST(AARA.Allotment2 AS decimal(18,2))+
CAST(AARA.Allotment3 AS decimal(18,2))+
CAST(AARA.Allotment4 AS decimal(18,2))) -
(CAST(Balances.Obligations AS decimal(18,2)))) 
    AS Unobligated_Balance
    FROM AARA 
    LEFT JOIN Balances 
        ON AARA.Office = Balances.Office 
        AND Balances.AccountCode = AARA.AccountCode
   

),
Result AS (
    SELECT ID,UID,FundCode,Office,DESCRIPTION,AccountCode,Appropriation,Allotment1,Allotment2,Allotment3,Allotment4,
	Augmentation,Reversion,SupplementalBudget,TotalAppropriation,TotalAllotment, ISNULL(Obligations, 0) AS Obligations
	 , ISNULL(Unobligated_Balance,TotalAllotment) as Unobligated_Balance
    FROM AllData 
),
Totals AS (
    SELECT 
        CAST(SUM(Appropriation) AS decimal(18,2)) AS Appropriation,
      
	    CAST(SUM(Obligations) AS decimal(18,2)) AS Obligations, 
	    CAST(SUM(Unobligated_Balance) AS decimal(18,2)) AS Unobligated_Balance
			
    FROM Result 
)
SELECT RC.OFFICE, RC.OfficeGroup, Description, Result.FundCode, AccountCode,  Result.Appropriation,
allotment1 as Allotment_Qtr1,
allotment2 as Allotment_Qtr2,
allotment3 as Allotment_Qtr3,
allotment4 as Allotment_Qtr4,
Augmentation as AugmentationSum,Reversion as ReversionSum,SupplementalBudget as SupplementalBudgetSum, TotalAppropriation,
Result.TotalAllotment,   Result.Obligations,  Result.Unobligated_Balance
FROM Result 
INNER JOIN Responsibilitycenter RC ON RC.RCNumber = Result.OFFICE  
order by RC.OfficeGroup,RC.RCID asc, Result.FundCode, Result.UID asc
"


        data.DateFrom = txtDateFrom.Text
        data.DateTo = txtDateTo.Text
        System.Threading.Thread.CurrentThread.SetApartmentState(System.Threading.ApartmentState.STA)
        ' Start the background worker
        bgwExport.RunWorkerAsync(data)

        ' Show a spinner or progress bar here
        Loader.BunifuCircleProgress1.Maximum = 100
        Loader.BunifuCircleProgress1.Minimum = 0
        Loader.BunifuCircleProgress1.Value = 0
        Loader.BunifuCircleProgress1.Visible = True

    End Sub
    Private Sub bgwExport_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwExport.DoWork
        bgwExport.WorkerReportsProgress = True
        ' Get the SQL query from the argument
        Dim data As SQLData = DirectCast(e.Argument, SQLData)
        Dim sql As String = data.SQLQuery
        Dim dateFrom As DateTime = data.DateFrom
        Dim dateTo As DateTime = data.DateTo
        ' Create a new thread with STA apartment state
        Dim t As New Thread(Sub()
                                ' Call the ExportToExcel function with the SQL query
                                ExportToExcel2(sql, dateFrom, dateTo)
                            End Sub)
        t.SetApartmentState(ApartmentState.STA)
        t.Start()
        t.Join() ' Wait for thread to complete
    End Sub
    Private Sub bgwExport_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwExport.RunWorkerCompleted
        Loader.BunifuCircleProgress1.Visible = False ' Hide spinner
        Loader.Close()
        Me.Show()
        DashBoard.Show()
    End Sub

    Private totalRows As Integer

    Private Sub ExportToExcel2(ByVal sql As String, ByVal datefrom As String, ByVal dateto As String)
        Try
            ' Set the thread to STA mode
            System.Threading.Thread.CurrentThread.SetApartmentState(System.Threading.ApartmentState.STA)

            'Create a new workbook and worksheet in Excel
            Dim excelApp As New Excel.Application
            Dim workbook As Excel.Workbook = excelApp.Workbooks.Add()
            Dim worksheet As Excel.Worksheet = workbook.Sheets("Sheet1")

            If (ClsConn.OpenConnection() = True) Then
                'Execute SQL query and load data into DataTable
                Dim cmd As New SqlCommand(sql, sqlCon)
                cmd.Parameters.AddWithValue("@datefrom", datefrom)
                cmd.Parameters.AddWithValue("@dateto", dateto)
                Dim adapter As New SqlDataAdapter(cmd)
                Dim dataTable As New DataTable
                adapter.Fill(dataTable)

                ' Set the total number of rows
                totalRows = dataTable.Rows.Count

                'Write column headers to Excel worksheet
                Dim colIndex As Integer = 0
                For Each dc As DataColumn In dataTable.Columns
                    colIndex += 1
                    worksheet.Cells(1, colIndex) = dc.ColumnName
                Next
                'Format all cells as text
                worksheet.Range("D:D").NumberFormat = "@"
                'Write row headers and data to Excel worksheet
                Dim rowIndex As Integer = 1
                For Each dr As DataRow In dataTable.Rows
                    rowIndex += 1
                    colIndex = 0
                    For Each dc As DataColumn In dataTable.Columns
                        colIndex += 1
                        worksheet.Cells(rowIndex, colIndex) = dr(dc.ColumnName)
                    Next

                    ' Report the progress of the background operation
                    Dim percentProgress = CInt(Math.Min(100, (rowIndex / totalRows) * 100))


                    bgwExport.ReportProgress(percentProgress)
                Next



                'Release objects from memory
                dataTable.Dispose()
                adapter.Dispose()
                cmd.Dispose()
                ClsConn.CloseConnection()

                'Save Excel workbook with user-specified filename
                Dim saveDialog As New SaveFileDialog()
                saveDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx"
                saveDialog.FileName = "SAAOB_RAW.xlsx"
                If saveDialog.ShowDialog() = DialogResult.OK Then
                    workbook.SaveAs(saveDialog.FileName)
                    MessageBox.Show("Export Successful!")
                End If

                'Close Excel application and release remaining objects from memory
                excelApp.Quit()
                releaseObject(worksheet)
                releaseObject(workbook)
                releaseObject(excelApp)
            End If
        Catch ex As Exception
            MessageBox.Show("Error exporting to Excel: " & ex.Message)
        End Try
    End Sub


    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub bgwExport_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgwExport.ProgressChanged
        ' Update the progress bar with the percentage of rows loaded
        Loader.BunifuCircleProgress1.Value = e.ProgressPercentage
    End Sub

    Private Sub btnExportOBRE_Click(sender As Object, e As EventArgs) Handles btnExportOBRE.Click
        Me.Hide()
        DashBoard.Hide()
        Loader.Show()
        Dim data As New SQLData()
        data.SQLQuery = "WITH
Balances AS (
    SELECT OBRE.ID AS ID,OBRE.payee as Payee, OBREO.entrydate  AS ObreEntry,OBREO.ResCenter,OBREMACCO_ID AS OBRE_ID,OBREO.Particulars, OBREO.AccountCode,  OBREO.Amount
    FROM OBRE_OtherDetails OBREO
	INNER JOIN OBRE ON obre.id=OBREO.id
   WHERE 
         (OBREO.entrydate BETWEEN @datefrom AND @dateto)
       
   
)
SELECT ID,RC.OFFICE,Payee, OBRE_ID, ObreEntry as entrydate,ResCenter, RC.OfficeGroup,COA.Account_Title,AccountCode,particulars,Amount FROM BALANCES
INNER JOIN Responsibilitycenter RC ON RC.RCNumber = BALANCES.ResCenter
LEFT JOIN ChartOfAccounts COA ON COA.Account_Code=Balances.AccountCode
order by OfficeGroup asc, ResCenter asc, accountcode asc "
        ' Set the thread to STA mode
        data.DateFrom = txtDateFrom.Text
        data.DateTo = txtDateTo.Text
        System.Threading.Thread.CurrentThread.SetApartmentState(System.Threading.ApartmentState.STA)
        ' Start the background worker
        bgwExport.RunWorkerAsync(data)

        ' Show a spinner or progress bar here
        Loader.BunifuCircleProgress1.Maximum = 100
        Loader.BunifuCircleProgress1.Minimum = 0
        Loader.BunifuCircleProgress1.Value = 0
        Loader.BunifuCircleProgress1.Visible = True
    End Sub

    Private Sub btnExportAug_Click(sender As Object, e As EventArgs) Handles btnExportAug.Click
        Me.Hide()
        DashBoard.Hide()
        Loader.Show()
        Dim data As New SQLData()
        data.SQLQuery = "WITH
aug AS (
select aro.id as AROAPPRO_ID, aro_augmentation.id as AUGID_APPRO_UID, 
aro_augmentation.datecreated as EntryDate,aro.office as Office,aro_augmentation.description,aro_augmentation.accountCode,aro_augmentation.amount,aro_augmentation.remarks
from aro inner join ARO_Appropriation on aro.id=ARO_Appropriation.ID 
inner join aro_augmentation on aro_augmentation.id = ARO_Appropriation.uid 
where aro_augmentation.datecreated between @datefrom and @dateto
)
select *  from aug

"
        ' Set the thread to STA mode
        data.DateFrom = txtDateFrom.Text
        data.DateTo = txtDateTo.Text
        System.Threading.Thread.CurrentThread.SetApartmentState(System.Threading.ApartmentState.STA)
        ' Start the background worker
        bgwExport.RunWorkerAsync(data)

        ' Show a spinner or progress bar here
        Loader.BunifuCircleProgress1.Maximum = 100
        Loader.BunifuCircleProgress1.Minimum = 0
        Loader.BunifuCircleProgress1.Value = 0
        Loader.BunifuCircleProgress1.Visible = True
    End Sub

    Private Sub btnExportRev_Click(sender As Object, e As EventArgs) Handles btnExportRev.Click
        Me.Hide()
        DashBoard.Hide()
        Loader.Show()
        Dim data As New SQLData()
        data.SQLQuery = "WITH
rev AS (
select aro.id as AROAPPRO_ID, aro_reversion.id as REVID_APPRO_UID, 
aro_reversion.datecreated as EntryDate,aro.office as Office,aro_reversion.description,aro_reversion.accountCode,aro_reversion.amount,aro_reversion.remarks
from aro inner join ARO_Appropriation on aro.id=ARO_Appropriation.ID 
inner join aro_reversion on aro_reversion.id = ARO_Appropriation.uid 
where aro_reversion.datecreated between @datefrom and @dateto
)
select *  from rev

"
        ' Set the thread to STA mode
        data.DateFrom = txtDateFrom.Text
        data.DateTo = txtDateTo.Text
        System.Threading.Thread.CurrentThread.SetApartmentState(System.Threading.ApartmentState.STA)
        ' Start the background worker
        bgwExport.RunWorkerAsync(data)

        ' Show a spinner or progress bar here
        Loader.BunifuCircleProgress1.Maximum = 100
        Loader.BunifuCircleProgress1.Minimum = 0
        Loader.BunifuCircleProgress1.Value = 0
        Loader.BunifuCircleProgress1.Visible = True
    End Sub

    Private Sub btnExportSB_Click(sender As Object, e As EventArgs) Handles btnExportSB.Click
        Me.Hide()
        DashBoard.Hide()
        Loader.Show()
        Dim data As New SQLData()
        data.SQLQuery = "WITH
SB AS (
select aro.id as AROAPPRO_ID, ARO_SupplementalBudget.id as SBID_APPRO_UID, 
ARO_SupplementalBudget.datecreated as EntryDate,aro.office as Office,ARO_SupplementalBudget.description,ARO_SupplementalBudget.accountCode,ARO_SupplementalBudget.amount,ARO_SupplementalBudget.remarks
from aro inner join ARO_Appropriation on aro.id=ARO_Appropriation.ID 
inner join ARO_SupplementalBudget on ARO_SupplementalBudget.id = ARO_Appropriation.uid 
where ARO_SupplementalBudget.datecreated between @datefrom and @dateto
)
select *  from sb


"
        ' Set the thread to STA mode
        data.DateFrom = txtDateFrom.Text
        data.DateTo = txtDateTo.Text
        System.Threading.Thread.CurrentThread.SetApartmentState(System.Threading.ApartmentState.STA)
        ' Start the background worker
        bgwExport.RunWorkerAsync(data)

        ' Show a spinner or progress bar here
        Loader.BunifuCircleProgress1.Maximum = 100
        Loader.BunifuCircleProgress1.Minimum = 0
        Loader.BunifuCircleProgress1.Value = 0
        Loader.BunifuCircleProgress1.Visible = True
    End Sub


    'Private Sub ExportToExcel(ByVal sql As String)
    '    Try
    '        If (ClsConn.OpenConnection() = True) Then
    '            Using cmd As New SqlCommand(sql, sqlCon)

    '                Dim dt As New DataTable()
    '                dt.Load(cmd.ExecuteReader())

    '                If dt.Rows.Count > 0 Then
    '                    Dim excelApp As New Excel.Application()
    '                    Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add()
    '                    Dim excelWorksheet As Excel.Worksheet = excelBook.ActiveSheet()

    '                    ' Format all cells as text
    '                    excelWorksheet.Cells.NumberFormat = "@"

    '                    ' Write the DataTable to the Excel worksheet
    '                    Dim i As Integer = 0
    '                    Dim j As Integer = 0
    '                    For Each row As DataRow In dt.Rows
    '                        For Each col As DataColumn In dt.Columns
    '                            excelWorksheet.Cells(i + 1, j + 1) = row(col.ColumnName)
    '                            j += 1
    '                        Next
    '                        i += 1
    '                        j = 0
    '                    Next



    '                    ' Prompt the user to save the file with a name of their choice
    '                    Dim saveFileDialog As New SaveFileDialog()
    '                    saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
    '                    saveFileDialog.FilterIndex = 2
    '                    saveFileDialog.RestoreDirectory = True

    '                    If saveFileDialog.ShowDialog() = DialogResult.OK Then
    '                        Dim fileName As String = saveFileDialog.FileName

    '                        ' Save the Excel file
    '                        excelBook.SaveAs(fileName)
    '                        excelBook.Close()
    '                        excelApp.Quit()
    '                    Else
    '                        excelBook.Close()
    '                        excelApp.Quit()
    '                    End If
    '                Else
    '                    MessageBox.Show("No records found.")
    '                End If
    '            End Using

    '            ClsConn.CloseConnection()
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show("Error exporting to Excel: " & ex.Message)
    '    End Try
    'End Sub
    'Private Sub ExportToExcel2(ByVal sql As String)
    '    Try
    '        'Create a new workbook and worksheet in Excel
    '        Dim excelApp As New Excel.Application
    '        Dim workbook As Excel.Workbook = excelApp.Workbooks.Add()
    '        Dim worksheet As Excel.Worksheet = workbook.Sheets("Sheet1")


    '        If (ClsConn.OpenConnection() = True) Then

    '            'Execute SQL query and load data into DataTable
    '            Dim cmd As New SqlCommand(sql, sqlCon)
    '            Dim adapter As New SqlDataAdapter(cmd)
    '            Dim dataTable As New DataTable
    '            adapter.Fill(dataTable)

    '            'Write column headers to Excel worksheet
    '            Dim colIndex As Integer = 0
    '            For Each dc As DataColumn In dataTable.Columns
    '                colIndex += 1
    '                worksheet.Cells(1, colIndex) = dc.ColumnName
    '            Next

    '            'Write row headers and data to Excel worksheet
    '            Dim rowIndex As Integer = 1
    '            For Each dr As DataRow In dataTable.Rows
    '                rowIndex += 1
    '                colIndex = 0
    '                For Each dc As DataColumn In dataTable.Columns
    '                    colIndex += 1
    '                    worksheet.Cells(rowIndex, colIndex) = dr(dc.ColumnName)
    '                Next
    '            Next

    '            'Release objects from memory
    '            dataTable.Dispose()
    '            adapter.Dispose()
    '            cmd.Dispose()
    '            ClsConn.CloseConnection()

    '            'Save Excel workbook with user-specifiedq filename
    '            Dim saveDialog As New SaveFileDialog()
    '            saveDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx"
    '            saveDialog.FileName = "SAAOB_RAW.xlsx"
    '            If saveDialog.ShowDialog() = DialogResult.OK Then
    '                workbook.SaveAs(saveDialog.FileName)
    '                MessageBox.Show("Export Successful!")
    '            End If

    '            'Close Excel application and release remaining objects from memory
    '            excelApp.Quit()
    '            releaseObject(worksheet)
    '            releaseObject(workbook)
    '            releaseObject(excelApp)

    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show("Error exporting to Excel: " & ex.Message)
    '    End Try
    'End Sub

    'Private Sub releaseObject(ByVal obj As Object)
    '    Try
    '        System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
    '        obj = Nothing
    '    Catch ex As Exception
    '        obj = Nothing
    '    Finally
    '        GC.Collect()
    '    End Try
    'End Sub

End Class