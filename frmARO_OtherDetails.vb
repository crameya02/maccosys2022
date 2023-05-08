Imports Bunifu.UI.WinForms
Imports CrystalDecisions.[Shared].Json
Imports Microsoft.Office.Interop.Excel
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Security.Cryptography
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Imports System.Data
Imports System.Data.DbType
Imports System.IO
Imports DataTable = System.Data.DataTable

Public Class frmARO_OtherDetails
    'Public Sub ShowAppro()
    '    'ARODGV.DataSource = ClsConn.LoadData("SELECT ARO.UID as UID, ARO.AROID as [ARO ID], ARO.FY as [Calendar Year], ARO.Office as Office," _
    '    '                                     & "ARO.FundCode as [Fund Code] from ARO order by UID desc").DefaultView
    '    ARODGV.DataSource = ClsConn.LoadData("SELECT ARO.ID as ID, ARO.AROID as [ARO ID], ARO.FY as [Calendar Year], ARO.Office as Office," _
    '                                         & "ARO.FundCode as [Fund Code] from ARO order by UID desc").DefaultView
    'End Sub

    Public Sub ShowAppro(dgv As DataGridView)
        Select Case action


            Case Actions.appropriation
                dgv.Invoke(Sub() dgv.DataSource = ClsConn.LoadDataWithDateBetween("SELECT  ARO.ID as ID, ARO.AROID as [ARO ID], ARO.FY as [Calendar Year], ARO.Office as Office,
ARO.FundCode as [Fund Code] from ARO inner join ARO_Appropriation on aro.id = ARO_Appropriation.id
 LEFT JOIN ARO_Allotment
ON ARO_Appropriation.UID = ARO_Allotment.ID  
where ARO.FY BETWEEN @datefrom and @dateto
group by 
ARO.ID, ARO.AROID,ARO.FY,ARO.Office,ARO.FundCode,ARO.UID order by aro.UID desc", readWorkingYear, Now.Year.ToString).DefaultView)

            Case Actions.allotment

                'ARODGV.DataSource = ClsConn.LoadData("SELECT ARO.UID as UID, ARO.AROID as [ARO ID], ARO.FY as [Calendar Year], ARO.Office as Office," _
                '                                     & "ARO.FundCode as [Fund Code] from ARO order by UID desc").DefaultView
                dgv.Invoke(Sub() dgv.DataSource = ClsConn.LoadDataWithDateBetween("SELECT  ARO.ID as ID, ARO.AROID as [ARO ID], ARO.FY as [Calendar Year], ARO.Office as Office,
ARO.FundCode as [Fund Code], ARO_Allotment.Purpose as [Purpose] from ARO inner join ARO_Appropriation on aro.id = ARO_Appropriation.id
 LEFT JOIN ARO_Allotment
ON ARO_Appropriation.UID = ARO_Allotment.ID
where ARO.FY BETWEEN @datefrom and @dateto
group by 
ARO.ID, ARO.AROID,ARO.FY,ARO.Office,ARO.FundCode,ARO_Allotment.Purpose,ARO.UID order by Office,FundCode,Purpose asc", readWorkingYear, Now.Year.ToString).DefaultView)

                'Case Actions.adjustment
                '    ARODGV.DataSource = ClsConn.LoadData("SELECT  ARO.ID as ID, ARO.AROID as [ARO ID], ARO.FY as [Calendar Year], ARO.Office as Office,
                '    ARO.FundCode as [Fund Code], ARO_Augmentation.Amount as [Augmentation],ARO_Reversion.Amount as [Reversion],ARO_SupplementalBudget.Amount as [Supplemental Budget] from ARO inner join ARO_Appropriation on aro.id = ARO_Appropriation.id
                '     LEFT JOIN ARO_Augmentation
                '    ON ARO_Appropriation.UID = ARO_Augmentation.ID LEFT JOIN ARO_Reversion
                '    ON ARO_Appropriation.UID = ARO_Reversion.ID LEFT JOIN ARO_SupplementalBudget
                '    ON ARO_Appropriation.UID = ARO_SupplementalBudget.ID group by 
                '    ARO.ID, ARO.AROID,ARO.FY,ARO.Office,ARO.FundCode,ARO.UID,ARO_Augmentation.Amount,ARO_Reversion.Amount,ARO_SupplementalBudget.Amount order by aro.UID desc").DefaultView
            Case Actions.adjustment
                dgv.Invoke(Sub() dgv.DataSource = ClsConn.LoadDataWithDateBetween("SELECT ARO.ID as ID, ARO.AROID as [ARO ID], ARO.FY as [Calendar Year], ARO.Office as Office,
       ARO.FundCode as [Fund Code], 

	   

       CASE WHEN ISNULL(AugmentationSum.SumAmount, 0) = 0 THEN NULL ELSE  ISNULL(AugmentationSum.SumAmount, 0) END as [Augmentation], 
       CASE WHEN ISNULL(ReversionSum.SumAmount, 0) = 0 THEN NULL ELSE  ISNULL(ReversionSum.SumAmount, 0) END as [Reversion], 
       CASE WHEN ISNULL(SupplementalBudgetSum.SumAmount, 0) = 0 THEN NULL ELSE  ISNULL(SupplementalBudgetSum.SumAmount, 0) END as [Supplemental Budget] 
FROM ARO 
INNER JOIN ARO_Appropriation ON ARO.ID = ARO_Appropriation.ID
LEFT JOIN (
    SELECT 
        ARO_Augmentation.ID, 
        SUM(ISNULL(ARO_Augmentation.Amount, 0)) AS SumAmount 
    FROM ARO_Augmentation 
    GROUP BY ARO_Augmentation.ID
) AS AugmentationSum ON ARO_Appropriation.UID = AugmentationSum.ID
LEFT JOIN (
    SELECT 
        ARO_Reversion.ID, 
        SUM(ISNULL(ARO_Reversion.Amount, 0)) AS SumAmount 
    FROM ARO_Reversion 
    GROUP BY ARO_Reversion.ID
) AS ReversionSum ON ARO_Appropriation.UID = ReversionSum.ID
LEFT JOIN (
    SELECT 
        ARO_SupplementalBudget.ID, 
        SUM(ISNULL(ARO_SupplementalBudget.Amount, 0)) AS SumAmount 
    FROM ARO_SupplementalBudget 
    GROUP BY ARO_SupplementalBudget.ID
) AS SupplementalBudgetSum ON ARO_Appropriation.UID = SupplementalBudgetSum.ID

where ARO.FY BETWEEN @datefrom and @dateto

GROUP BY ARO.ID, ARO.AROID, ARO.FY, ARO.Office, ARO.FundCode, ARO.UID,AugmentationSum.SumAmount,ReversionSum.SumAmount,SupplementalBudgetSum.SumAmount
ORDER BY
  CASE 
    WHEN SUM(ISNULL(AugmentationSum.SumAmount, 0)) <> 0 
         OR SUM(ISNULL(ReversionSum.SumAmount, 0)) <> 0 
         OR SUM(ISNULL(SupplementalBudgetSum.SumAmount, 0)) <> 0 
      THEN 0
    ELSE 1 
  END,
  ARO.UID Desc


", readWorkingYear, Now.Year.ToString).DefaultView)


        End Select
    End Sub


    Private Sub frmARO_OtherDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        theme.myCustomSkinDark(Me)
        BackgroundWorker1.WorkerReportsProgress = True
        BackgroundWorker1.WorkerSupportsCancellation = True


        ShowAppro(ARODGV)

        'BackgroundWorker1.RunWorkerAsync()

    End Sub
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Me.Invoke(Sub() ARODGV.Visible = False)
        Me.Invoke(Sub() BunifuCircleProgress1.Visible = True)

        ' Check for cancellation
        If BackgroundWorker1.CancellationPending = True Then
            e.Cancel = True
            Exit Sub
        End If



        Dim data As DataTable = ClsConn.LoadDatatest("SELECT ARO.ID as ID, ARO.AROID as [ARO ID], ARO.FY as [Calendar Year], ARO.Office as Office,
       ARO.FundCode as [Fund Code], 

	   

       CASE WHEN ISNULL(AugmentationSum.SumAmount, 0) = 0 THEN NULL ELSE  ISNULL(AugmentationSum.SumAmount, 0) END as [Augmentation], 
       CASE WHEN ISNULL(ReversionSum.SumAmount, 0) = 0 THEN NULL ELSE  ISNULL(ReversionSum.SumAmount, 0) END as [Reversion], 
       CASE WHEN ISNULL(SupplementalBudgetSum.SumAmount, 0) = 0 THEN NULL ELSE  ISNULL(SupplementalBudgetSum.SumAmount, 0) END as [Supplemental Budget] 
FROM ARO 
INNER JOIN ARO_Appropriation ON ARO.ID = ARO_Appropriation.ID
LEFT JOIN (
    SELECT 
        ARO_Augmentation.ID, 
        SUM(ISNULL(ARO_Augmentation.Amount, 0)) AS SumAmount 
    FROM ARO_Augmentation 
    GROUP BY ARO_Augmentation.ID
) AS AugmentationSum ON ARO_Appropriation.UID = AugmentationSum.ID
LEFT JOIN (
    SELECT 
        ARO_Reversion.ID, 
        SUM(ISNULL(ARO_Reversion.Amount, 0)) AS SumAmount 
    FROM ARO_Reversion 
    GROUP BY ARO_Reversion.ID
) AS ReversionSum ON ARO_Appropriation.UID = ReversionSum.ID
LEFT JOIN (
    SELECT 
        ARO_SupplementalBudget.ID, 
        SUM(ISNULL(ARO_SupplementalBudget.Amount, 0)) AS SumAmount 
    FROM ARO_SupplementalBudget 
    GROUP BY ARO_SupplementalBudget.ID
) AS SupplementalBudgetSum ON ARO_Appropriation.UID = SupplementalBudgetSum.ID
GROUP BY ARO.ID, ARO.AROID, ARO.FY, ARO.Office, ARO.FundCode, ARO.UID,AugmentationSum.SumAmount,ReversionSum.SumAmount,SupplementalBudgetSum.SumAmount
ORDER BY
  CASE 
    WHEN SUM(ISNULL(AugmentationSum.SumAmount, 0)) <> 0 
         OR SUM(ISNULL(ReversionSum.SumAmount, 0)) <> 0 
         OR SUM(ISNULL(SupplementalBudgetSum.SumAmount, 0)) <> 0 
      THEN 0
    ELSE 1 
  END,
  ARO.UID Desc


")


        ' Wait for 5 milliseconds before continuing
        Threading.Thread.Sleep(5)
        ' Set the result of the background operation
        e.Result = data




    End Sub

    Private Sub LoadDataProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
        ' Update the progress bar with the current progress value
        BunifuCircleProgress1.Value = e.ProgressPercentage
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ' Update the progress bar control
        Me.Invoke(Sub() BunifuCircleProgress1.Value = e.ProgressPercentage)
    End Sub
    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        If e.Error IsNot Nothing Then
            ' An error occurred in the background task.
            MessageBox.Show("Error: " & e.Error.Message)
        ElseIf e.Cancelled Then
            ' The background task was cancelled by the user.
        Else
            ' The background task completed successfully.
            'Dim data As DataTable = DirectCast(e.Result, DataTable)
            'MyDataGridView.DataSource = data
            ARODGV.Visible = True
            ARODGV.DataSource = Nothing
            ARODGV.Rows.Clear()
            ' Display the loaded data in the DataGridView
            Dim data As DataTable = CType(e.Result, DataTable)
            ARODGV.DataSource = data.DefaultView
            ARODGV.Columns(0).Visible = False
        End If

        ' Hide the progress bar.
        BunifuCircleProgress1.Visible = False
    End Sub



    'Private Sub txtSearchCOA_TextChanged(sender As Object, e As EventArgs) Handles txtSearchARO.TextChanged
    '    Dim searchString As String = txtSearchARO.Text
    '    Dim str As String = String.Format("SELECT ARO.ID as ID, ARO.AROID as [ARO ID], ARO.FY as [Calendar Year], ARO.Office as Office," _
    '                                         & "ARO.FundCode as [Fund Code] from ARO WHERE AROID like '%{0}%' OR FY like '%{0}%' OR Office like '%{0}%'  OR FundCode like '%{0}%' order by UID desc", searchString)
    '    ARODGV.DataSource = ClsConn.LoadData(str).DefaultView
    '    'ARODGV.Columns(0).Visible = False
    'End Sub


    Private Sub txtSearchCOA_TextChanged(sender As Object, e As EventArgs) Handles txtSearchARO.TextChanged
        Select Case action

            Case Actions.appropriation
                Dim searchString As String = txtSearchARO.Text
                Dim str As String = String.Format("SELECT  ARO.ID as ID, ARO.AROID as [ARO ID], ARO.FY as [Calendar Year], ARO.Office as Office,
    ARO.FundCode as [Fund Code] from ARO inner join ARO_Appropriation on aro.id = ARO_Appropriation.id
     LEFT JOIN ARO_Allotment
    ON ARO_Appropriation.UID = ARO_Allotment.ID where (AROID like '%{0}%' OR FY like '%{0}%' OR Office like '%{0}%'  OR FundCode like '%{0}%') and 
 ARO.FY BETWEEN @datefrom and @dateto
group by 
    ARO.ID, ARO.AROID,ARO.FY,ARO.Office,ARO.FundCode,ARO.UID order by aro.UID desc", searchString)
                'use load data when using like statement
                'ARODGV.DataSource = ClsConn.LoadData(str).DefaultView

                ARODGV.DataSource = ClsConn.LoadDataWithDateBetween(str, readWorkingYear, Now.Year.ToString).DefaultView
            Case Actions.allotment
                Dim searchString As String = txtSearchARO.Text
                Dim str As String = String.Format("SELECT  ARO.ID as ID, ARO.AROID as [ARO ID], ARO.FY as [Calendar Year], ARO.Office as Office,
    ARO.FundCode as [Fund Code], ARO_Allotment.Purpose as [Purpose] from ARO inner join ARO_Appropriation on aro.id = ARO_Appropriation.id
     LEFT JOIN ARO_Allotment
    ON ARO_Appropriation.UID = ARO_Allotment.ID where (AROID like '%{0}%' OR FY like '%{0}%' OR Office like '%{0}%'  OR FundCode like '%{0}%') and  ARO.FY BETWEEN @datefrom and @dateto  group by 
    ARO.ID, ARO.AROID,ARO.FY,ARO.Office,ARO.FundCode,ARO_Allotment.Purpose,ARO.UID order by Office,FundCode,Purpose asc", searchString)
                ARODGV.DataSource = ClsConn.LoadDataWithDateBetween(str, readWorkingYear, Now.Year.ToString).DefaultView
                    'ARODGV.Columns(0).Visible = False
                    '            Case Actions.adjustment
                    '                Dim searchString As String = txtSearchARO.Text
                    '                Dim str As String = String.Format("SELECT  ARO.ID as ID, ARO.AROID as [ARO ID], ARO.FY as [Calendar Year], ARO.Office as Office,
                    'ARO.FundCode as [Fund Code], ARO_Augmentation.Amount as [Augmentation],ARO_Reversion.Amount as [Reversion],ARO_SupplementalBudget.Amount as [Supplemental Budget] from ARO inner join ARO_Appropriation on aro.id = ARO_Appropriation.id
                    ' LEFT JOIN ARO_Augmentation
                    'ON ARO_Appropriation.UID = ARO_Augmentation.ID LEFT JOIN ARO_Reversion
                    'ON ARO_Appropriation.UID = ARO_Reversion.ID LEFT JOIN ARO_SupplementalBudget
                    'ON ARO_Appropriation.UID = ARO_SupplementalBudget.ID where AROID like '%{0}%' OR FY like '%{0}%' OR Office like '%{0}%'  OR FundCode like '%{0}%'  group by 
                    'ARO.ID, ARO.AROID,ARO.FY,ARO.Office,ARO.FundCode,ARO.UID,ARO_Augmentation.Amount,ARO_Reversion.Amount,ARO_SupplementalBudget.Amount order by aro.UID desc", searchString)
                    '                ARODGV.DataSource = ClsConn.LoadData(str).DefaultView

            Case Actions.adjustment
                Dim searchString As String = txtSearchARO.Text
                Dim str As String = String.Format("SELECT ARO.ID as ID, ARO.AROID as [ARO ID], ARO.FY as [Calendar Year], ARO.Office as Office,
           ARO.FundCode as [Fund Code], 



           CASE WHEN ISNULL(AugmentationSum.SumAmount, 0) = 0 THEN NULL ELSE  ISNULL(AugmentationSum.SumAmount, 0) END as [Augmentation], 
           CASE WHEN ISNULL(ReversionSum.SumAmount, 0) = 0 THEN NULL ELSE  ISNULL(ReversionSum.SumAmount, 0) END as [Reversion], 
           CASE WHEN ISNULL(SupplementalBudgetSum.SumAmount, 0) = 0 THEN NULL ELSE  ISNULL(SupplementalBudgetSum.SumAmount, 0) END as [Supplemental Budget] 
    FROM ARO 
    INNER JOIN ARO_Appropriation ON ARO.ID = ARO_Appropriation.ID
    LEFT JOIN (
        SELECT 
            ARO_Augmentation.ID, 
            SUM(ISNULL(ARO_Augmentation.Amount, 0)) AS SumAmount 
        FROM ARO_Augmentation 
        GROUP BY ARO_Augmentation.ID
    ) AS AugmentationSum ON ARO_Appropriation.UID = AugmentationSum.ID
    LEFT JOIN (
        SELECT 
            ARO_Reversion.ID, 
            SUM(ISNULL(ARO_Reversion.Amount, 0)) AS SumAmount 
        FROM ARO_Reversion 
        GROUP BY ARO_Reversion.ID
    ) AS ReversionSum ON ARO_Appropriation.UID = ReversionSum.ID
    LEFT JOIN (
        SELECT 
            ARO_SupplementalBudget.ID, 
            SUM(ISNULL(ARO_SupplementalBudget.Amount, 0)) AS SumAmount 
        FROM ARO_SupplementalBudget 
        GROUP BY ARO_SupplementalBudget.ID
    ) AS SupplementalBudgetSum ON ARO_Appropriation.UID = SupplementalBudgetSum.ID

       where (AROID like '%{0}%' OR FY like '%{0}%' OR Office like '%{0}%'  OR FundCode like '%{0}%' OR AugmentationSum.SumAmount like '%{0}%' OR ReversionSum.SumAmount like '%{0}%' OR SupplementalBudgetSum.SumAmount like '%{0}%') and  ARO.FY BETWEEN @datefrom and @dateto

    GROUP BY ARO.ID, ARO.AROID, ARO.FY, ARO.Office, ARO.FundCode, ARO.UID,AugmentationSum.SumAmount,ReversionSum.SumAmount,SupplementalBudgetSum.SumAmount
    ORDER BY
      CASE 
        WHEN SUM(ISNULL(AugmentationSum.SumAmount, 0)) <> 0 
             OR SUM(ISNULL(ReversionSum.SumAmount, 0)) <> 0 
             OR SUM(ISNULL(SupplementalBudgetSum.SumAmount, 0)) <> 0 
          THEN 0
        ELSE 1 
      END,
      ARO.UID Desc


    ", searchString)
                ARODGV.DataSource = ClsConn.LoadDataWithDateBetween(str, readWorkingYear, Now.Year.ToString).DefaultView

        End Select
    End Sub
    Private Async Sub SomeMethod()
        frmARO_Allotment.cmbOffice.Enabled = True
        Await Task.Delay(2)
        frmARO_Allotment.cmbOffice.Enabled = False
    End Sub

    Private Sub ARODGV_MouseClick(sender As Object, e As MouseEventArgs) Handles ARODGV.MouseClick
        Try
            If ARODGV.Rows.Count > 0 Then
                If action = 3 Then
                    Dim dr As DataGridViewRow = ARODGV.SelectedRows(0)
                    frmARO_Adjustments.id = dr.Cells(0).Value.ToString()
                    frmARO_Adjustments.aroid = dr.Cells(1).Value.ToString()
                    ' frmARO_Allotment.entrydate = Now().ToString("MM/dd/yyyy")
                    frmARO_Adjustments.fy = dr.Cells(2).Value.ToString()
                    frmARO_Adjustments.office = dr.Cells(3).Value.ToString()
                    'frmARO_Allotment.purpose = dr.Cells(4).Value.ToString()
                    frmARO_Adjustments.fundcode = dr.Cells(4).Value.ToString()



                    Dim fundCode As String = dr.Cells(4).Value.ToString()
                    'frmARO_Allotment.txtPurpose.Text = dr.Cells(4).Value.ToString()
                    frmARO_Adjustments.txtFundCode.SelectedItem = dr.Cells(4).Value.ToString()
                    frmARO_Adjustments.txtFundCode.Enabled = True
                    frmARO_Adjustments.txtFundCode.Enabled = False
                    frmARO_Adjustments.cmbOffice.SelectedValue = dr.Cells(3).Value.ToString()
                    frmARO_Adjustments.btnUpdate.Enabled = True


                    frmARO_Adjustments.cmbOffice.Enabled = True

                    frmARO_Adjustments.cmbOffice.Enabled = False


                    ' Fetch the latest ID from the database
                    If (ClsConn.OpenConnection() = True) Then

                        '                    Dim sql As String = "
                        'Select 
                        'RTRIM(ARO.ID), 
                        'RTRIM(ARO_Appropriation.AccountCode),
                        'RTRIM(ARO_Appropriation.Description),
                        'RTRIM(ARO_Appropriation.Amount),
                        'RTRIM(ARO_Appropriation.UID),
                        'RTRIM(ISNULL(ARO_Augmentation.Amount, 0)),
                        'RTRIM(ARO_Augmentation.UID),
                        'RTRIM(ARO_Augmentation.Remarks),
                        'RTRIM(ISNULL(ARO_Reversion.Amount, 0)),
                        'RTRIM(ARO_Reversion.UID),
                        'RTRIM(ARO_Reversion.Remarks),
                        'RTRIM(ISNULL(ARO_SupplementalBudget.Amount, 0)),
                        'RTRIM(ARO_SupplementalBudget.UID),
                        'RTRIM(ARO_SupplementalBudget.Remarks)
                        'from ARO 
                        'inner join ARO_Appropriation on aro.id = ARO_Appropriation.id
                        'LEFT JOIN ARO_Augmentation
                        'ON ARO_Appropriation.UID = ARO_Augmentation.ID LEFT JOIN ARO_Reversion
                        'ON ARO_Appropriation.UID = ARO_Reversion.ID LEFT JOIN ARO_SupplementalBudget
                        'ON ARO_Appropriation.UID = ARO_SupplementalBudget.ID where ARO.ID=@ID order by ARO_Appropriation.UID asc"

                        Dim sql As String = "SELECT 
    ARO.ID, 
    ARO_Appropriation.AccountCode,
    ARO_Appropriation.Description,
    ARO_Appropriation.Amount,
    ARO_Appropriation.UID,
    ISNULL(AugmentationSum.SumAmount, 0) AS Augmentation,
    ISNULL(ReversionSum.SumAmount, 0) AS Reversion,
    ISNULL(SupplementalBudgetSum.SumAmount, 0) AS SupplementalBudget
FROM ARO 
INNER JOIN ARO_Appropriation ON ARO.ID = ARO_Appropriation.ID
LEFT JOIN (
    SELECT 
        ARO_Augmentation.ID, 
        SUM(ISNULL(ARO_Augmentation.Amount, 0)) AS SumAmount 
    FROM ARO_Augmentation 
    GROUP BY ARO_Augmentation.ID
) AS AugmentationSum ON ARO_Appropriation.UID = AugmentationSum.ID
LEFT JOIN (
    SELECT 
        ARO_Reversion.ID, 
        SUM(ISNULL(ARO_Reversion.Amount, 0)) AS SumAmount 
    FROM ARO_Reversion 
    GROUP BY ARO_Reversion.ID
) AS ReversionSum ON ARO_Appropriation.UID = ReversionSum.ID
LEFT JOIN (
    SELECT 
        ARO_SupplementalBudget.ID, 
        SUM(ISNULL(ARO_SupplementalBudget.Amount, 0)) AS SumAmount 
    FROM ARO_SupplementalBudget 
    GROUP BY ARO_SupplementalBudget.ID
) AS SupplementalBudgetSum ON ARO_Appropriation.UID = SupplementalBudgetSum.ID
WHERE ARO.ID = @ID
GROUP BY 
    ARO.ID, 
    ARO_Appropriation.AccountCode,
    ARO_Appropriation.Description,
    ARO_Appropriation.Amount,
    ARO_Appropriation.UID,AugmentationSum.SumAmount,ReversionSum.SumAmount,SupplementalBudgetSum.SumAmount order by ARO_Appropriation.AccountCode asc
"
                        cmd = New SqlCommand(sql, sqlCon)
                        cmd.Parameters.AddWithValue("@ID", dr.Cells(0).Value)
                        frmARO_Adjustments.ARODGV.DataSource = Nothing
                        frmARO_Adjustments.ARODGV.Rows.Clear()
                        rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                        While (rdr.Read() = True)
                            frmARO_Adjustments.ARODGV.Rows.Add(
                                rdr(1),
                                rdr(2),
                                Convert.ToDouble(rdr(3)).ToString("N2", CultureInfo.InvariantCulture),
                                rdr(4),
                                Convert.ToDouble(rdr(5)).ToString("N2", CultureInfo.InvariantCulture),
                                Convert.ToDouble(rdr(6)).ToString("N2", CultureInfo.InvariantCulture),
                                Convert.ToDouble(rdr(7)).ToString("N2", CultureInfo.InvariantCulture)
                             )
                        End While
                        'Format Cellvalues to Decimal of Appropriation Column
                        If frmARO_Adjustments.ARODGV.Columns(2).Name = "Appropriation" Then
                            Dim runningTotal As Decimal = 0
                            For i As Integer = 0 To frmARO_Adjustments.ARODGV.Rows.Count - 1
                                If Not frmARO_Adjustments.ARODGV.Rows(i).IsNewRow Then
                                    Dim cellValue As Decimal
                                    If Decimal.TryParse(frmARO_Adjustments.ARODGV.Rows(i).Cells("Appropriation").Value.ToString(), cellValue) Then
                                        runningTotal += cellValue
                                    Else
                                        ' Handle invalid input
                                    End If

                                End If
                            Next
                            frmARO_Adjustments.ARODGV.Rows(frmARO_Adjustments.ARODGV.Rows.Count - 1).Cells("Appropriation").Value = String.Format("{0:N2}", runningTotal)
                        End If


                        'Format Cellvalues to Decimal of Allotment Column
                        If frmARO_Adjustments.ARODGV.Columns(4).Name = "Augmentation" Then
                            Dim runningTotal As Decimal = 0
                            For i As Integer = 0 To frmARO_Adjustments.ARODGV.Rows.Count - 1
                                If Not frmARO_Adjustments.ARODGV.Rows(i).IsNewRow Then
                                    Dim cellValue As Decimal
                                    If Decimal.TryParse(frmARO_Adjustments.ARODGV.Rows(i).Cells("Augmentation").Value.ToString(), cellValue) Then
                                        runningTotal += cellValue
                                    Else
                                        ' Handle invalid input
                                    End If

                                End If
                            Next
                            frmARO_Adjustments.ARODGV.Rows(frmARO_Adjustments.ARODGV.Rows.Count - 1).Cells("Augmentation").Value = String.Format("{0:N2}", runningTotal)
                        End If
                        If frmARO_Adjustments.ARODGV.Columns(5).Name = "Reversion" Then
                            Dim runningTotal As Decimal = 0
                            For i As Integer = 0 To frmARO_Adjustments.ARODGV.Rows.Count - 1
                                If Not frmARO_Adjustments.ARODGV.Rows(i).IsNewRow Then
                                    Dim cellValue As Decimal
                                    If Decimal.TryParse(frmARO_Adjustments.ARODGV.Rows(i).Cells("Reversion").Value.ToString(), cellValue) Then
                                        runningTotal += cellValue
                                    Else
                                        ' Handle invalid input
                                    End If

                                End If
                            Next
                            frmARO_Adjustments.ARODGV.Rows(frmARO_Adjustments.ARODGV.Rows.Count - 1).Cells("Reversion").Value = String.Format("{0:N2}", runningTotal)
                        End If
                        If frmARO_Adjustments.ARODGV.Columns(6).Name = "SupplementalBudget" Then
                            Dim runningTotal As Decimal = 0
                            For i As Integer = 0 To frmARO_Adjustments.ARODGV.Rows.Count - 1
                                If Not frmARO_Adjustments.ARODGV.Rows(i).IsNewRow Then
                                    Dim cellValue As Decimal
                                    If Decimal.TryParse(frmARO_Adjustments.ARODGV.Rows(i).Cells("SupplementalBudget").Value.ToString(), cellValue) Then
                                        runningTotal += cellValue
                                    Else
                                        ' Handle invalid input
                                    End If

                                End If
                            Next
                            frmARO_Adjustments.ARODGV.Rows(frmARO_Adjustments.ARODGV.Rows.Count - 1).Cells("SupplementalBudget").Value = String.Format("{0:N2}", runningTotal)
                        End If
                        frmARO_Adjustments.ARODGV.Enabled = True
                        frmARO_Adjustments.ARODGV.Columns(0).ReadOnly = True
                        frmARO_Adjustments.ARODGV.Columns(1).ReadOnly = True
                        frmARO_Adjustments.ARODGV.Columns(2).ReadOnly = True
                        frmARO_Adjustments.ARODGV(3, frmARO_Adjustments.ARODGV.Rows.Count - 1).ReadOnly = True
                        ClsConn.CloseConnection()

                    End If


                    Me.Hide()
                    Exit Sub

                End If
                Select Case mode
                    Case Modes.add 'For Allotment
                        frmARO_Allotment.cmbPurpose.Enabled = True
                        Dim dr As DataGridViewRow = ARODGV.SelectedRows(0)
                        frmARO_Allotment.id = dr.Cells(0).Value.ToString()
                        frmARO_Allotment.aroid = dr.Cells(1).Value.ToString()
                        ' frmARO_Allotment.entrydate = Now().ToString("MM/dd/yyyy")
                        frmARO_Allotment.fy = dr.Cells(2).Value.ToString()
                        frmARO_Allotment.office = dr.Cells(3).Value.ToString()
                        'frmARO_Allotment.purpose = dr.Cells(4).Value.ToString()
                        frmARO_Allotment.fundcode = dr.Cells(4).Value.ToString()



                        Dim fundCode As String = dr.Cells(4).Value.ToString()
                        'frmARO_Allotment.txtPurpose.Text = dr.Cells(4).Value.ToString()
                        frmARO_Allotment.txtFundCode.SelectedItem = dr.Cells(4).Value.ToString()
                        frmARO_Allotment.txtFundCode.Enabled = True
                        frmARO_Allotment.txtFundCode.Enabled = False
                        frmARO_Allotment.cmbOffice.SelectedValue = dr.Cells(3).Value.ToString()
                        SomeMethod()


                        'frmAdvice.btnSave.Enabled = False
                        'frmAdvice.btnDelete.Enabled = True
                        'frmAdvice.btnUpdate.Enabled = True
                        'frmAdvice.btnPrint.Enabled = True
                        'frmAdvice.btnRemove.Enabled = False
                        'frmAdvice.save.Enabled = False

                        ' Fetch the latest ID from the database
                        If (ClsConn.OpenConnection() = True) Then

                            Dim sql As String = "
                        Select
                        RTRIM(ARO.ID),
                        RTRIM(ARO_Appropriation.AccountCode),
                        RTRIM(ARO_Appropriation.Description),
                        RTRIM(ARO_Appropriation.Amount),
                        RTRIM(ISNULL(ARO_Allotment.Amount, 0)),
                        RTRIM(ARO_Appropriation.UID),
                        RTRIM(ARO_Allotment.Purpose),
                        RTRIM(ARO_Allotment.UID),
                        RTRIM(ARO_Allotment.EntryDate)
                        from ARO 
                        inner join ARO_Appropriation on aro.id = ARO_Appropriation.id
                        LEFT JOIN ARO_Allotment
                        ON ARO_Appropriation.UID = ARO_Allotment.ID where ARO.ID=@ID and 
                        (@Purpose IS NULL OR ARO_Allotment.Purpose = @Purpose) 
                        order by ARO_Appropriation.AccountCode asc"
                            cmd = New SqlCommand(sql, sqlCon)
                            cmd.Parameters.AddWithValue("@ID", dr.Cells(0).Value)
                            cmd.Parameters.AddWithValue("@Purpose", dr.Cells(5).Value)
                            frmARO_Allotment.ARODGV.DataSource = Nothing
                            frmARO_Allotment.ARODGV.Rows.Clear()
                            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                            While (rdr.Read() = True)
                                Dim value3 As Double = rdr(3)
                                Dim formattedValue3 As String = value3.ToString("N2", CultureInfo.InvariantCulture)
                                Dim value4 As Double = rdr(4)
                                Dim formattedValue4 As String = value4.ToString("N2", CultureInfo.InvariantCulture)
                                frmARO_Allotment.ARODGV.Rows.Add(rdr(1), rdr(2), formattedValue3, formattedValue4, rdr(5), rdr(7), "", rdr(6))
                                'frmARO_Allotment.txtPurpose.Text = rdr(6).ToString()
                                frmARO_Allotment.cmbPurpose.Text = rdr(6).ToString()
                                frmARO_Allotment.cmbPurpose.Enabled = False
                                frmARO_Allotment.cmbPurpose.Enabled = True
                                frmARO_Allotment.entrydate = rdr(8).ToString
                                If rdr(6).ToString() Is Nothing Or rdr(6).ToString() = "" Then
                                    frmARO_Allotment.btnUpdate.Enabled = False
                                    frmARO_Allotment.btnSave.Enabled = True
                                Else
                                    frmARO_Allotment.btnUpdate.Enabled = True
                                    frmARO_Allotment.btnSave.Enabled = False
                                End If
                            End While

                            'for showing previous allotment

                            If frmARO_Allotment.cmbPurpose.Text = "2nd Quarter Release" Or frmARO_Allotment.cmbPurpose.Text = "3rd Quarter Release" Or frmARO_Allotment.cmbPurpose.Text = "4th Quarter Release" Then
                                Dim sql1 As String = "
with
Original_ARO_Allotment_1 as (
Select RTRIM(ISNULL(ARO_Allotment.Amount, 0)) AS Allotment1,ARO_Allotment.ID,ARO_Appropriation.AccountCode AS AccountCode from ARO 
                            inner join ARO_Appropriation on aro.id = ARO_Appropriation.id
                            LEFT JOIN ARO_Allotment
                            ON ARO_Appropriation.UID = ARO_Allotment.ID where ARO.ID=@ID and ( ARO_Allotment.Purpose = '1st Quarter Release' ) 
						
),
Original_ARO_Allotment_2 as (
Select RTRIM(ISNULL(ARO_Allotment.Amount, 0)) AS Allotment2,ARO_Allotment.ID from ARO 
                            inner join ARO_Appropriation on aro.id = ARO_Appropriation.id
                            LEFT JOIN ARO_Allotment
                            ON ARO_Appropriation.UID = ARO_Allotment.ID where ARO.ID=@ID and ( ARO_Allotment.Purpose = '2nd Quarter Release' ) 
							
),
Original_ARO_Allotment_3 as (
Select RTRIM(ISNULL(ARO_Allotment.Amount, 0)) AS Allotment3,ARO_Allotment.ID from ARO 
                            inner join ARO_Appropriation on aro.id = ARO_Appropriation.id
                            LEFT JOIN ARO_Allotment
                            ON ARO_Appropriation.UID = ARO_Allotment.ID where ARO.ID=@ID and ( ARO_Allotment.Purpose = '3rd Quarter Release' ) 
							
),
Original_ARO_Allotment_4 as (
Select RTRIM(ISNULL(ARO_Allotment.Amount, 0)) AS Allotment4,ARO_Allotment.ID from ARO 
                            inner join ARO_Appropriation on aro.id = ARO_Appropriation.id
                            LEFT JOIN ARO_Allotment
                            ON ARO_Appropriation.UID = ARO_Allotment.ID where ARO.ID=@ID and ( ARO_Allotment.Purpose = '4th Quarter Release' ) 
							
),
alldata as (
SELECT AccountCode,Allotment1,Allotment2,Allotment3,Allotment4 FROM
Original_ARO_Allotment_1 OAA1 
LEFT JOIN Original_ARO_Allotment_2 OAA2 ON OAA1.ID = OAA2.ID
LEFT JOIN Original_ARO_Allotment_3 OAA3 ON OAA2.ID = OAA3.ID
LEFT JOIN Original_ARO_Allotment_4 OAA4 ON OAA3.ID = OAA4.ID
	
),

result as ( 
SELECT AccountCode,
    CASE
        WHEN @var = '2nd Quarter Release' THEN ISNULL(CAST(Allotment1 AS decimal(18,2)), 0)
        WHEN @var = '3rd Quarter Release' THEN ISNULL(CAST(Allotment1 AS decimal(18,2)), 0) + ISNULL(CAST(Allotment2 AS decimal(18,2)), 0)
		WHEN @var = '4th Quarter Release' THEN ISNULL(CAST(Allotment1 AS decimal(18,2)), 0) + ISNULL(CAST(Allotment2 AS decimal(18,2)), 0) +
		ISNULL(CAST(Allotment3 AS decimal(18,2)), 0)
        ELSE 0
    END as PreviousAllotment
FROM alldata
)


SELECT PreviousAllotment FROM result order by AccountCode asc"
                                cmd = New SqlCommand(sql1, sqlCon)
                                cmd.Parameters.AddWithValue("@ID", dr.Cells(0).Value)
                                cmd.Parameters.AddWithValue("@var", frmARO_Allotment.cmbPurpose.Text)
                                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

                                Dim i As Integer = 0
                                While (rdr.Read() = True)
                                    Dim value As Double = rdr(0)
                                    Dim formattedValue As String = value.ToString("N2", CultureInfo.InvariantCulture)
                                    frmARO_Allotment.ARODGV.Rows(i).Cells(6).Value = formattedValue
                                    i += 1
                                    'MsgBox(formattedValue)

                                End While

                            End If


                            Dim allNull As Boolean = True
                            Dim allNonNull As Boolean = True

                            For Each row As DataGridViewRow In frmARO_Allotment.ARODGV.Rows
                                If Not row.IsNewRow Then
                                    Dim value As Object = row.Cells("UUID").Value
                                    If Not IsDBNull(value) AndAlso value IsNot Nothing Then
                                        allNull = False
                                    Else
                                        allNonNull = False
                                    End If
                                End If
                            Next

                            If Not allNull AndAlso Not allNonNull Then

                                frmARO_Allotment.btnUpdate.Enabled = True
                                frmARO_Allotment.btnSave.Enabled = False
                            End If

                            'Format Cellvalues to Decimal of prevAllot Column
                            If frmARO_Allotment.ARODGV.Columns(6).Name = "prevAllot" Then
                                Dim runningTotal As Decimal = 0
                                For i As Integer = 0 To frmARO_Allotment.ARODGV.Rows.Count - 1
                                    If Not frmARO_Allotment.ARODGV.Rows(i).IsNewRow Then
                                        Dim cellValue As Decimal
                                        If Not String.IsNullOrEmpty(frmARO_Allotment.ARODGV.Rows(i).Cells("prevAllot").Value?.ToString()) AndAlso Decimal.TryParse(frmARO_Allotment.ARODGV.Rows(i).Cells("prevAllot").Value.ToString(), cellValue) Then
                                            runningTotal += cellValue
                                        Else
                                            frmARO_Allotment.ARODGV.Rows(i).Cells("prevAllot").Value = "0.00"
                                        End If

                                    End If
                                Next
                                frmARO_Allotment.ARODGV.Rows(frmARO_Allotment.ARODGV.Rows.Count - 1).Cells("prevAllot").Value = String.Format("{0:N2}", runningTotal)
                            End If

                            'Format Cellvalues to Decimal of Appropriation Column
                            If frmARO_Allotment.ARODGV.Columns(2).Name = "Appropriation" Then
                                Dim runningTotal As Decimal = 0
                                For i As Integer = 0 To frmARO_Allotment.ARODGV.Rows.Count - 1
                                    If Not frmARO_Allotment.ARODGV.Rows(i).IsNewRow Then
                                        Dim cellValue As Decimal
                                        If Decimal.TryParse(frmARO_Allotment.ARODGV.Rows(i).Cells("Appropriation").Value.ToString(), cellValue) Then
                                            runningTotal += cellValue
                                        Else
                                            ' Handle invalid input
                                        End If

                                    End If
                                Next
                                frmARO_Allotment.ARODGV.Rows(frmARO_Allotment.ARODGV.Rows.Count - 1).Cells("Appropriation").Value = String.Format("{0:N2}", runningTotal)
                            End If


                            'Format Cellvalues to Decimal of Allotment Column
                            If frmARO_Allotment.ARODGV.Columns(3).Name = "Allotment" Then
                                Dim runningTotal As Decimal = 0
                                For i As Integer = 0 To frmARO_Allotment.ARODGV.Rows.Count - 1
                                    If Not frmARO_Allotment.ARODGV.Rows(i).IsNewRow Then
                                        Dim cellValue As Decimal
                                        If Decimal.TryParse(frmARO_Allotment.ARODGV.Rows(i).Cells("Allotment").Value.ToString(), cellValue) Then
                                            runningTotal += cellValue
                                        Else
                                            ' Handle invalid input
                                        End If

                                    End If
                                Next
                                frmARO_Allotment.ARODGV.Rows(frmARO_Allotment.ARODGV.Rows.Count - 1).Cells("Allotment").Value = String.Format("{0:N2}", runningTotal)
                            End If
                            frmARO_Allotment.ARODGV.Enabled = True
                            frmARO_Allotment.ARODGV.Columns(0).ReadOnly = True
                            frmARO_Allotment.ARODGV.Columns(1).ReadOnly = True
                            frmARO_Allotment.ARODGV.Columns(2).ReadOnly = True
                            frmARO_Allotment.ARODGV(3, frmARO_Allotment.ARODGV.Rows.Count - 1).ReadOnly = True
                            ClsConn.CloseConnection()

                            If (ClsConn.OpenConnection() = True) Then
                                Dim sqlquery As String = "SELECT  ARO.ID as ID, ARO.AROID as [ARO ID], ARO.FY as [Calendar Year], ARO.Office as Office,
ARO.FundCode as [Fund Code], ARO_Allotment.Purpose as [Purpose] from ARO inner join ARO_Appropriation on aro.id = ARO_Appropriation.id
 LEFT JOIN ARO_Allotment
ON ARO_Appropriation.UID = ARO_Allotment.ID
where ARO.FY = @year and office =@office and FundCode=@fundcode and purpose=@purpose
group by 
ARO.ID, ARO.AROID,ARO.FY,ARO.Office,ARO.FundCode,ARO_Allotment.Purpose,ARO.UID order by Office,FundCode,Purpose asc"
                                cmd = New SqlCommand(sqlquery, sqlCon)
                                cmd.Parameters.AddWithValue("@year", ReadWorkingYear)
                                cmd.Parameters.AddWithValue("@office", frmARO_Allotment.cmbOffice.Text)
                                cmd.Parameters.AddWithValue("@fundcode", frmARO_Allotment.txtFundCode.Text)
                                cmd.Parameters.AddWithValue("@purpose", frmARO_Allotment.cmbPurpose.Text)
                                Dim currentpurpose As String = frmARO_Allotment.cmbPurpose.Text

                                Dim result As Integer
                                    Using rdr As SqlDataReader = cmd.ExecuteReader()
                                        If rdr.Read() Then
                                        result = Convert.ToInt32(rdr(0))
                                    End If
                                    End Using
                                If result = 0 Then

                                    'MessageBox.Show(cmbPurpose.Text & " for FY: " & ReadWorkingYear() & " of " & cmbOffice.Text & "(" & txtFundCode.Text & ") already exists. This will result on duplicate of rows in the database. Please select another release description")



                                    Dim resultdialog As DialogResult = MessageBox.Show(frmARO_Allotment.cmbPurpose.Text & " for FY: " & ReadWorkingYear() & " of " & frmARO_Allotment.cmbOffice.Text & "(" & frmARO_Allotment.txtFundCode.Text & ") already exists. If you added new item in the Appropriation then fill up the fields then update. e.g 1st Qtr > Update > new > 2nd qtr save .... Create backup for safety measure", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Question)

                                    If resultdialog = DialogResult.OK Then
                                        ' Perform an action when the user clicks Yes
                                        DashBoard.Backup()
                                        Dim columnIndex As Integer = 7 ' Set the column index to Column of PurposeAllot
                                        Dim desiredText As String = frmARO_Allotment.cmbPurpose.SelectedIndex = 0

                                        For rowIndex = frmARO_Allotment.ARODGV.RowCount - 1 To 0 Step -1
                                            Dim cellValue As Object = frmARO_Allotment.ARODGV(columnIndex, rowIndex).Value
                                            If cellValue IsNot Nothing AndAlso Not String.IsNullOrEmpty(cellValue.ToString()) AndAlso cellValue.ToString() <> desiredText Then
                                                frmARO_Allotment.ARODGV.Rows.RemoveAt(rowIndex)
                                            End If
                                        Next

                                    ElseIf resultdialog = DialogResult.No Then

                                        'frmARO_Allotment.BunifuButton1.PerformClick()
                                    End If

                                    'customSnackbar(Me, cmbPurpose.Text & " for FY: " & ReadWorkingYear() & " of " & cmbOffice.Text & "(" & txtFundCode.Text & ") already exists. This will result on duplicate of rows in the database. Please select another release description", "OK")
                                End If

                            End If


                            ClsConn.CloseConnection()

                            Me.Close()
                        End If

                    Case Modes.edit ' for Appropriation


                        frmARO.btnSave.Text = "UPDATE"
                        frmARO.btnSave.Enabled = False
                        frmARO.btnSave.Enabled = True
                        Dim dr As DataGridViewRow = ARODGV.SelectedRows(0)
                        frmARO.id = dr.Cells(0).Value.ToString()
                        frmARO.aroid = dr.Cells(1).Value.ToString()
                        ' frmARO_Allotment.entrydate = Now().ToString("MM/dd/yyyy")
                        frmARO.fy = dr.Cells(2).Value.ToString()
                        frmARO.office = dr.Cells(3).Value.ToString()
                        'frmARO_Allotment.purpose = dr.Cells(4).Value.ToString()
                        frmARO.fundcode = dr.Cells(4).Value.ToString()
                        Dim fundCode As String = dr.Cells(4).Value.ToString()
                        'frmARO_Allotment.txtPurpose.Text = dr.Cells(4).Value.ToString()
                        frmARO.txtFundCode.SelectedItem = dr.Cells(4).Value.ToString()
                        frmARO.txtFundCode.Enabled = False
                        frmARO.txtFundCode.Enabled = True
                        frmARO.cmbOffice.SelectedValue = dr.Cells(3).Value.ToString()
                        frmARO.cmbOffice.Enabled = False
                        frmARO.cmbOffice.Enabled = True
                        ' Fetch the latest ID from the database
                        If (ClsConn.OpenConnection() = True) Then
                            Dim sql As String = "Select RTRIM(ARO.ID),RTRIM(ARO_Appropriation.AccountCode),RTRIM(ARO_Appropriation.Description),RTRIM(ARO_Appropriation.Amount)
,RTRIM(ARO_Appropriation.UID)  from ARO 
inner join ARO_Appropriation on aro.id = ARO_Appropriation.id
 where ARO.ID=" & dr.Cells(0).Value & " order by ARO_Appropriation.AccountCode asc"
                            cmd = New SqlCommand(sql, sqlCon)
                            frmARO.ARODGV.DataSource = Nothing
                            frmARO.ARODGV.Rows.Clear()
                            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
                            While (rdr.Read() = True)
                                Dim value3 As Double = rdr(3)
                                Dim formattedValue3 As String = value3.ToString("N2", CultureInfo.InvariantCulture)
                                frmARO.ARODGV.Rows.Add(rdr(1), rdr(2), formattedValue3, rdr(4))

                            End While
                            If frmARO.ARODGV.Columns(2).Name = "Appropriation" Then
                                Dim runningTotal As Decimal = 0
                                For i As Integer = 0 To frmARO.ARODGV.Rows.Count - 1
                                    If Not frmARO.ARODGV.Rows(i).IsNewRow Then
                                        Dim cellValue As Decimal
                                        If Decimal.TryParse(frmARO.ARODGV.Rows(i).Cells("Appropriation").Value.ToString(), cellValue) Then
                                            runningTotal += cellValue
                                        Else
                                            ' Handle invalid input
                                        End If

                                    End If
                                Next
                                frmARO.ARODGV.Rows(frmARO.ARODGV.Rows.Count - 1).Cells("Appropriation").Value = String.Format("{0:N2}", runningTotal)
                            End If

                            frmARO.ARODGV.Enabled = True


                            ClsConn.CloseConnection()
                            Me.Close()
                        End If
                End Select

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub ARODGV_KeyDown(sender As Object, e As KeyEventArgs) Handles ARODGV.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim mouseArgs As New MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0)
            ARODGV_MouseClick(sender, mouseArgs)
        End If
    End Sub

    Private Sub txtSearchARO_Click(sender As Object, e As EventArgs) Handles txtSearchARO.Click

    End Sub

    Private Sub ARODGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ARODGV.CellContentClick

    End Sub

    Private Sub ARODGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ARODGV.CellClick

    End Sub
End Class