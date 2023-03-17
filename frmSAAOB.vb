Imports System.Data.SqlClient
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports CrystalDecisions
Imports CrystalDecisions.Shared
Imports System.Data
Imports System.Configuration
Imports CrystalDecisions.CrystalReports.Engine
Imports System

Imports Microsoft.Office.Interop.Excel
Imports System.Globalization
Imports Microsoft.SqlServer.Management.Smo
Imports MaterialSkin.Controls
Imports CrystalDecisions.ReportAppServer.DataDefModel
Imports System.Windows.Interop

Public Class frmSAAOB
    Public Sub ShowSAAOB502()
        SAAOBDGV502.DataSource = Nothing
        SAAOBDGV502.Columns.Clear()
        SAAOBDGV502.DataSource = ClsConn.LoadData("WITH AAO AS (
    SELECT ARO.ID, ARO_Appropriation.UID, ARO.FundCode, ARO_Allotment.Purpose, ARO.Office, 
           ARO_Appropriation.Description, ARO_Appropriation.AccountCode, ARO_Appropriation.Amount AS Appropriation,
           RTRIM(ISNULL(ARO_Allotment.Amount, 0)) AS Allotment
    FROM ARO 
    INNER JOIN ARO_Appropriation 
        ON ARO.ID = ARO_Appropriation.ID
    LEFT JOIN ARO_Allotment
        ON ARO_Appropriation.UID = ARO_Allotment.ID
    WHERE ARO.Office = '1011' 
        AND Purpose = '1st Quarter Release' 
        AND ARO.FundCode = '05-02'
),
Balances AS (
    SELECT ResCenter AS Office, AccountCode, SUM(Amount) AS Obligations
    FROM OBRE_OtherDetails
    WHERE ResCenter = '1011' 
        AND EntryDate BETWEEN '01/01/2023' AND '01/31/2023'
        AND AccountCode LIKE '5-02%'
    GROUP BY AccountCode, ResCenter 
),
AllData AS (
    SELECT AAO.Description, AAO.AccountCode, AAO.Appropriation, CAST(AAO.Allotment AS decimal(18,2)) as Allotment, CAST(Balances.Obligations AS decimal(18,2)) as Obligations,
           CAST(AAO.Allotment AS decimal(18,2)) - CAST(Balances.Obligations AS decimal(18,2)) AS Unobligated_Balance
    FROM AAO 
    LEFT JOIN Balances 
        ON AAO.Office = Balances.Office 
        AND Balances.AccountCode = AAO.AccountCode
    WHERE AAO.FundCode = '05-02'
        AND AAO.AccountCode LIKE '5-02%'
),
Result AS (
    SELECT Description, AccountCode, Appropriation, Allotment, ISNULL(Obligations, 0) AS Obligations, ISNULL(Unobligated_Balance,Allotment) as Unobligated_Balance
    FROM AllData
),
Totals AS (
    SELECT 
        CAST(SUM(Appropriation) AS decimal(18,2)) AS Appropriation,
        CAST(SUM(Allotment) AS decimal(18,2)) AS Allotment, 
	    CAST(SUM(Obligations) AS decimal(18,2)) AS Obligations, 
	    CAST(SUM(Unobligated_Balance) AS decimal(18,2)) AS Unobligated_Balance
    FROM Result
)
SELECT Description, AccountCode,  Appropriation,  Allotment,   Obligations,  Unobligated_Balance
FROM Result 
UNION ALL
SELECT 'Total' AS Description, '' AS AccountCode, 
       Appropriation, Allotment, Obligations, Unobligated_Balance
FROM Totals;
").DefaultView
    End Sub
    Public Sub ShowSAAOB501()
        SAAOBDGV501.DataSource = Nothing
        SAAOBDGV501.Columns.Clear()
        SAAOBDGV501.DataSource = ClsConn.LoadData("WITH AAO AS (
    SELECT ARO.ID, ARO_Appropriation.UID, ARO.FundCode, ARO_Allotment.Purpose, ARO.Office, 
           ARO_Appropriation.Description, ARO_Appropriation.AccountCode, ARO_Appropriation.Amount AS Appropriation,
           RTRIM(ISNULL(ARO_Allotment.Amount, 0)) AS Allotment
    FROM ARO 
    INNER JOIN ARO_Appropriation 
        ON ARO.ID = ARO_Appropriation.ID
    LEFT JOIN ARO_Allotment
        ON ARO_Appropriation.UID = ARO_Allotment.ID
    WHERE ARO.Office = '1011' 
        AND Purpose = '1st Quarter Release' 
        AND ARO.FundCode = '05-01'
),
Balances AS (
    SELECT ResCenter AS Office, AccountCode, SUM(Amount) AS Obligations
    FROM OBRE_OtherDetails
    WHERE ResCenter = '1011' 
        AND EntryDate BETWEEN '01/01/2023' AND '01/31/2023'
        AND AccountCode LIKE '5-01%'
    GROUP BY AccountCode, ResCenter 
),
AllData AS (
    SELECT AAO.Description, AAO.AccountCode, AAO.Appropriation, CAST(AAO.Allotment AS decimal(18,2)) as Allotment, CAST(Balances.Obligations AS decimal(18,2)) as Obligations,
           CAST(AAO.Allotment AS decimal(18,2)) - CAST(Balances.Obligations AS decimal(18,2)) AS Unobligated_Balance
    FROM AAO 
    LEFT JOIN Balances 
        ON AAO.Office = Balances.Office 
        AND Balances.AccountCode = AAO.AccountCode
    WHERE AAO.FundCode = '05-01'
        AND AAO.AccountCode LIKE '5-01%'
),
Result AS (
    SELECT Description, AccountCode, Appropriation, Allotment, ISNULL(Obligations, 0) AS Obligations, ISNULL(Unobligated_Balance,Allotment) as Unobligated_Balance
    FROM AllData
),
Totals AS (
    SELECT 
        CAST(SUM(Appropriation) AS decimal(18,2)) AS Appropriation,
        CAST(SUM(Allotment) AS decimal(18,2)) AS Allotment, 
	    CAST(SUM(Obligations) AS decimal(18,2)) AS Obligations, 
	    CAST(SUM(Unobligated_Balance) AS decimal(18,2)) AS Unobligated_Balance
    FROM Result
)
SELECT Description, AccountCode,  Appropriation,  Allotment,   Obligations,  Unobligated_Balance
FROM Result 
UNION ALL
SELECT 'Total' AS Description, '' AS AccountCode, 
       Appropriation, Allotment, Obligations, Unobligated_Balance
FROM Totals;
").DefaultView

    End Sub

    Public Sub ShowSAAOB107()
        SAAOBDGV107.DataSource = Nothing
        SAAOBDGV107.Columns.Clear()
        SAAOBDGV107.DataSource = ClsConn.LoadData("WITH AAO AS (
    SELECT ARO.ID, ARO_Appropriation.UID, ARO.FundCode, ARO_Allotment.Purpose, ARO.Office, 
           ARO_Appropriation.Description, ARO_Appropriation.AccountCode, ARO_Appropriation.Amount AS Appropriation,
           RTRIM(ISNULL(ARO_Allotment.Amount, 0)) AS Allotment
    FROM ARO 
    INNER JOIN ARO_Appropriation 
        ON ARO.ID = ARO_Appropriation.ID
    LEFT JOIN ARO_Allotment
        ON ARO_Appropriation.UID = ARO_Allotment.ID
    WHERE ARO.Office = '1011' 
        AND Purpose = '1st Quarter Release' 
        AND ARO.FundCode = '01-07'
),
Balances AS (
    SELECT ResCenter AS Office, AccountCode, SUM(Amount) AS Obligations
    FROM OBRE_OtherDetails
    WHERE ResCenter = '1011' 
        AND EntryDate BETWEEN '01/01/2023' AND '01/31/2023'
        AND AccountCode LIKE '1-07%'
    GROUP BY AccountCode, ResCenter 
),
AllData AS (
    SELECT AAO.Description, AAO.AccountCode, AAO.Appropriation, CAST(AAO.Allotment AS decimal(18,2)) as Allotment, CAST(Balances.Obligations AS decimal(18,2)) as Obligations,
           CAST(AAO.Allotment AS decimal(18,2)) - CAST(Balances.Obligations AS decimal(18,2)) AS Unobligated_Balance
    FROM AAO 
    LEFT JOIN Balances 
        ON AAO.Office = Balances.Office 
        AND Balances.AccountCode = AAO.AccountCode
    WHERE AAO.FundCode = '01-07'
        AND AAO.AccountCode LIKE '1-07%'
),
Result AS (
    SELECT Description, AccountCode, Appropriation, Allotment, ISNULL(Obligations, 0) AS Obligations, ISNULL(Unobligated_Balance,Allotment) as Unobligated_Balance
    FROM AllData
),
Totals AS (
    SELECT 
        CAST(SUM(Appropriation) AS decimal(18,2)) AS Appropriation,
        CAST(SUM(Allotment) AS decimal(18,2)) AS Allotment, 
	    CAST(SUM(Obligations) AS decimal(18,2)) AS Obligations, 
	    CAST(SUM(Unobligated_Balance) AS decimal(18,2)) AS Unobligated_Balance
    FROM Result
)
SELECT Description, AccountCode,  Appropriation,  Allotment,   Obligations,  Unobligated_Balance
FROM Result 
UNION ALL
SELECT 'Total' AS Description, '' AS AccountCode, 
       Appropriation, Allotment, Obligations, Unobligated_Balance
FROM Totals;
").DefaultView

    End Sub

    Private Sub SetDataGridViewColumnSize(DGW As DataGridView)
        Dim totalWidth As Integer = DGW.Width - DGW.RowHeadersWidth

        ' Calculate the desired percentage widths of each column
        Dim columnWidths() As Integer = {25, 15, 15, 15, 15, 15}

        ' Set the width of each column based on the percentage
        For i As Integer = 0 To DGW.Columns.Count - 1
            Dim percentageWidth As Integer = CInt((columnWidths(i) / 100) * totalWidth)
            DGW.Columns(i).Width = percentageWidth
        Next
    End Sub
    Private Sub SetDataGridViewHeightandWidth(DGW As DataGridView)
        If DGW.RowCount > 0 Then
            Dim rowHeight As Integer = DGW.Rows(0).Height
            Dim headerHeight As Integer = DGW.ColumnHeadersHeight
            Dim totalRowsHeight As Integer = (DGW.Rows.Count * rowHeight) + headerHeight
            DGW.Width = FlowLayoutPanel1.Width - 20
            DGW.Height = totalRowsHeight
        Else
            DGW.Visible = False
        End If
    End Sub
    Private Sub FormatColumnToDecimal(DGW As DataGridView)
        Try
            For Each column As DataGridViewColumn In DGW.Columns
                column.DefaultCellStyle.Format = "N2"
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub frmSAAOB_Load(sender As Object, e As EventArgs) Handles Me.Load
        theme.myCustomSkinDark(Me)
        Me.Size = DashBoard.FlowLayoutPanel2.Size
        'ShowSAAOB501()
        'ShowSAAOB502()
        'ShowSAAOB107()
        'SetDataGridViewHeightandWidth(SAAOBDGV501)
        'SetDataGridViewHeightandWidth(SAAOBDGV502)
        'SetDataGridViewHeightandWidth(SAAOBDGV107)
        'SetDataGridViewColumnSize(SAAOBDGV501)
        'SetDataGridViewColumnSize(SAAOBDGV502)
        'SetDataGridViewColumnSize(SAAOBDGV107)
        'FormatColumnToDecimal(SAAOBDGV501)
        'FormatColumnToDecimal(SAAOBDGV502)
        'FormatColumnToDecimal(SAAOBDGV107)

        ''populateListView()
        'SetListViewHeightAndWidth(MaterialListView1)
        'SetListViewColumnSize(MaterialListView1)



    End Sub

    Private Sub SetListViewColumnSize(LV As ListView)
        Dim totalWidth As Integer = LV.Width

        ' Calculate the desired percentage widths of each column
        Dim columnWidths() As Integer = {25, 15, 15, 15, 15, 15}

        ' Set the width of each column based on the percentage
        For i As Integer = 0 To LV.Columns.Count - 1
            Dim percentageWidth As Integer = CInt((columnWidths(i) / 100) * totalWidth)
            LV.Columns(i).Width = percentageWidth
        Next
    End Sub

    'Private Sub seedListView()
    '    ' Define
    '    Dim data = {
    '    New String() {"Lollipop", "392", "0.2", "0"},
    '    New String() {"KitKat", "518", "26.0", "7"},
    '    New String() {"Ice cream sandwich", "237", "9.0", "4.3"},
    '    New String() {"Jelly Bean", "375", "0.0", "0.0"},
    '    New String() {"Honeycomb", "408", "3.2", "6.5"}
    '    }
    '    For Each version As String() In data
    '        Dim item = New ListViewItem(version)
    '        MaterialListView1.Items.Add(item)
    '    Next
    'End Sub
    Private Sub populateListView()
        If (ClsConn.OpenConnection() = True) Then
            Dim sql As String = "WITH AAO AS (
    SELECT ARO.ID, ARO_Appropriation.UID, ARO.FundCode, ARO_Allotment.Purpose, ARO.Office, 
           ARO_Appropriation.Description, ARO_Appropriation.AccountCode, ARO_Appropriation.Amount AS Appropriation,
           RTRIM(ISNULL(ARO_Allotment.Amount, 0)) AS Allotment
    FROM ARO 
    INNER JOIN ARO_Appropriation 
        ON ARO.ID = ARO_Appropriation.ID
    LEFT JOIN ARO_Allotment
        ON ARO_Appropriation.UID = ARO_Allotment.ID
    WHERE ARO.Office = '1011' 
        AND Purpose = '1st Quarter Release' 
        AND ARO.FundCode = '05-01'
),
Balances AS (
    SELECT ResCenter AS Office, AccountCode, SUM(Amount) AS Obligations
    FROM OBRE_OtherDetails
    WHERE ResCenter = '1011' 
        AND EntryDate BETWEEN '01/01/2023' AND '01/31/2023'
        AND AccountCode LIKE '5-01%'
    GROUP BY AccountCode, ResCenter 
),
AllData AS (
    SELECT AAO.Description, AAO.AccountCode, AAO.Appropriation, CAST(AAO.Allotment AS decimal(18,2)) as Allotment, CAST(Balances.Obligations AS decimal(18,2)) as Obligations,
           CAST(AAO.Allotment AS decimal(18,2)) - CAST(Balances.Obligations AS decimal(18,2)) AS Unobligated_Balance
    FROM AAO 
    LEFT JOIN Balances 
        ON AAO.Office = Balances.Office 
        AND Balances.AccountCode = AAO.AccountCode
    WHERE AAO.FundCode = '05-01'
        AND AAO.AccountCode LIKE '5-01%'
),
Result AS (
    SELECT Description, AccountCode, Appropriation, Allotment, ISNULL(Obligations, 0) AS Obligations, ISNULL(Unobligated_Balance,Allotment) as Unobligated_Balance
    FROM AllData
),
Totals AS (
    SELECT 
        CAST(SUM(Appropriation) AS decimal(18,2)) AS Appropriation,
        CAST(SUM(Allotment) AS decimal(18,2)) AS Allotment, 
	    CAST(SUM(Obligations) AS decimal(18,2)) AS Obligations, 
	    CAST(SUM(Unobligated_Balance) AS decimal(18,2)) AS Unobligated_Balance
    FROM Result
)
SELECT Description, AccountCode,  Appropriation,  Allotment,   Obligations,  Unobligated_Balance
FROM Result 
UNION ALL
SELECT 'Total' AS Description, '' AS AccountCode, 
       Appropriation, Allotment, Obligations, Unobligated_Balance
FROM Totals;"
            cmd = New SqlCommand(sql, sqlCon)
            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            While (rdr.Read())
                Dim value2 As Double = rdr(2)
                Dim formattedValue2 As String = value2.ToString("N2", CultureInfo.InvariantCulture)
                Dim value3 As Double = rdr(3)
                Dim formattedValue3 As String = value3.ToString("N2", CultureInfo.InvariantCulture)
                Dim value4 As Double = rdr(4)
                Dim formattedValue4 As String = value4.ToString("N2", CultureInfo.InvariantCulture)
                Dim value5 As Double = rdr(5)
                Dim formattedValue5 As String = value5.ToString("N2", CultureInfo.InvariantCulture)
                Dim item As New ListViewItem(
                    rdr(0).ToString())
                item.SubItems.Add(rdr(1).ToString())
                item.SubItems.Add(formattedValue2)
                item.SubItems.Add(formattedValue3)
                item.SubItems.Add(formattedValue4)
                item.SubItems.Add(formattedValue5)
                MaterialListView1.Items.Add(item)
            End While



            ClsConn.CloseConnection()

        End If
    End Sub

    Private Sub SetListViewHeightAndWidth(LV As ListView)
        If LV.Items.Count > 0 Then
            Dim itemHeight As Integer = LV.Items(0).Bounds.Height
            Dim headerHeight As Integer = LV.Font.Height + 6 ' 6 is a magic number for padding
            Dim totalRowsHeight As Integer = (LV.Items.Count * itemHeight) + headerHeight
            LV.Width = FlowLayoutPanel1.Width - 20
            LV.Height = totalRowsHeight
        Else
            LV.Visible = False
        End If
    End Sub



    'Private Sub FormatColumnToDecimal(DGW As DataGridView)
    '    Try
    '        For Each column As DataGridViewColumn In DGW.Columns
    '            column.DefaultCellStyle.Format = "N2"
    '        Next
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub frmSAAOB_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'SetDataGridViewHeightandWidth(SAAOBDGV501)
        'SetDataGridViewHeightandWidth(SAAOBDGV502)
        'SetDataGridViewHeightandWidth(SAAOBDGV107)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        frmSAAOB_Print_Option.ShowDialog()
    End Sub

    Private Sub MaterialListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnOption_Click(sender As Object, e As EventArgs) Handles btnOption.Click
        Dim GroupOffices As String()() = New String(3)() {}

        GroupOffices(0) = New String() {"1011-3", "1011-3.a", "1011-3.b", "1011-3.c", "1011-3.d"} 'MENRO
        GroupOffices(1) = New String() {"1011-6", "1011-6.a", "1011-6.b", "1011-6.c", "1011-6.d", "1011-6.e", "1011-6.f", "1011-6.g", "1011-6.h", "1011-6.i", "1011-6.j"} 'TOURISM
        GroupOffices(2) = New String() {"1051", "1051-CRM", "1051-MR"} 'MCR
        GroupOffices(3) = New String() {"9999-1", "9999-2.a", "9999-2.b", "9999-2.c", "9999-2.d", "9999-2.e", "9999-2.f", "9999-2.g", "9999-2.h", "9999-2.i", "9999-3", "9999-3-PRAISE", "9999-3-EMPREC", "9999-3-RTRMNT", "9999-3-INHOUSE", "9999-3-EMPDAY", "9999-3-CSCCEL", "9999-3-SCHOLAR", "9999-4.a", "9999-4.b", "9999-4.c", "9999-4.d", "9999-4.e", "9999-4.f", "9999-5.a", "9999-5.b", "9999-5.c", "9999-5.d", "9999-5.e", "9999-5.f", "9999-5.g", "9999-6.a", "9999-6.b", "9999-6.c", "9999-6.d", "9999-6.e", "9999-6.f", "9999-6.g", "9999-6.h", "9999-7.a", "9999-7.b", "9999-7.c", "9999-8.a", "9999-8.b", "9999-8.c", "9999-8.c-KBTAAN", "9999-8.c-KLGTSN", "9999-8.c-LDRSHP", "9999-8.c-PDJEP", "9999-8.c-PSCAA", "9999-8.c-SKDRG", "9999-9", "9999-10", "9999-10.a", "9999-10.b", "9999-10.c", "9999-10.d", "9999-10.e", "9999-10.f", "9999-10.g", "9999-10.h", "9999-10.i", "9999-10.j", "9999-10.k", "9999-10.l", "9999-10.m", "9999-10.n", "9999-10.o"}

        Dim searchoffice As String = frmSAAOB_Print_Option.cmbOffice.Text
        Dim foundIndex As Integer = -1

        For i As Integer = 0 To GroupOffices.Length - 1
            If Array.IndexOf(GroupOffices(i), searchoffice) >= 0 Then
                foundIndex = i
                Exit For
            End If
        Next

        If foundIndex >= 0 Then
            If foundIndex = 2 Then
                MsgBox(searchoffice & " found in group " & foundIndex + 1)
                Exit Sub
            End If
            'MsgBox(searchoffice & " found in group " & foundIndex + 1)
        Else
                MsgBox(searchoffice & " not found")
        End If

        'Dim GroupColors As String()() = New String(1)() {}

        'GroupColors(0) = New String() {"red", "orange", "yellow"}
        'GroupColors(1) = New String() {"green", "blue", "purple"}

        'Dim searchString As String = "re"
        'Dim foundIndex As Integer = -1 'initialize to -1 if color is not found

        'For i As Integer = 0 To GroupColors.Length - 1 'loop through each sub-array

        '    If Array.IndexOf(GroupColors(i), searchString) >= 0 Then 'check if color is found in sub-array
        '        foundIndex = i 'set found index to current sub-array index
        '        Exit For 'exit loop if color is found
        '    End If
        'Next

        'If foundIndex >= 0 Then 'if color is found
        '    MsgBox(searchString & " found in group " & foundIndex + 1)
        'Else 'if color is not found
        '    MsgBox(searchString & " not found")
        'End If

    End Sub
End Class