Imports CrystalDecisions.[Shared].Json
Imports Microsoft.Office.Interop.Excel
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Security.Cryptography

Public Class frmARO_OtherDetails
    'Public Sub ShowAppro()
    '    'ARODGV.DataSource = ClsConn.LoadData("SELECT ARO.UID as UID, ARO.AROID as [ARO ID], ARO.FY as [Calendar Year], ARO.Office as Office," _
    '    '                                     & "ARO.FundCode as [Fund Code] from ARO order by UID desc").DefaultView
    '    ARODGV.DataSource = ClsConn.LoadData("SELECT ARO.ID as ID, ARO.AROID as [ARO ID], ARO.FY as [Calendar Year], ARO.Office as Office," _
    '                                         & "ARO.FundCode as [Fund Code] from ARO order by UID desc").DefaultView
    'End Sub
    Public Sub ShowAppro()
        Select Case action

            Case Actions.appropriation
                ARODGV.DataSource = ClsConn.LoadData("SELECT  ARO.ID as ID, ARO.AROID as [ARO ID], ARO.FY as [Calendar Year], ARO.Office as Office,
ARO.FundCode as [Fund Code] from ARO inner join ARO_Appropriation on aro.id = ARO_Appropriation.id
 LEFT JOIN ARO_Allotment
ON ARO_Appropriation.UID = ARO_Allotment.ID  group by 
ARO.ID, ARO.AROID,ARO.FY,ARO.Office,ARO.FundCode,ARO.UID order by aro.UID desc").DefaultView

            Case Actions.allotment

                'ARODGV.DataSource = ClsConn.LoadData("SELECT ARO.UID as UID, ARO.AROID as [ARO ID], ARO.FY as [Calendar Year], ARO.Office as Office," _
                '                                     & "ARO.FundCode as [Fund Code] from ARO order by UID desc").DefaultView
                ARODGV.DataSource = ClsConn.LoadData("SELECT  ARO.ID as ID, ARO.AROID as [ARO ID], ARO.FY as [Calendar Year], ARO.Office as Office,
ARO.FundCode as [Fund Code], ARO_Allotment.Purpose as [Purpose] from ARO inner join ARO_Appropriation on aro.id = ARO_Appropriation.id
 LEFT JOIN ARO_Allotment
ON ARO_Appropriation.UID = ARO_Allotment.ID  group by 
ARO.ID, ARO.AROID,ARO.FY,ARO.Office,ARO.FundCode,ARO_Allotment.Purpose,ARO.UID order by aro.UID desc").DefaultView

                'Case Actions.adjustment
                '    ARODGV.DataSource = ClsConn.LoadData("SELECT  ARO.ID as ID, ARO.AROID as [ARO ID], ARO.FY as [Calendar Year], ARO.Office as Office,
                '    ARO.FundCode as [Fund Code], ARO_Augmentation.Amount as [Augmentation],ARO_Reversion.Amount as [Reversion],ARO_SupplementalBudget.Amount as [Supplemental Budget] from ARO inner join ARO_Appropriation on aro.id = ARO_Appropriation.id
                '     LEFT JOIN ARO_Augmentation
                '    ON ARO_Appropriation.UID = ARO_Augmentation.ID LEFT JOIN ARO_Reversion
                '    ON ARO_Appropriation.UID = ARO_Reversion.ID LEFT JOIN ARO_SupplementalBudget
                '    ON ARO_Appropriation.UID = ARO_SupplementalBudget.ID group by 
                '    ARO.ID, ARO.AROID,ARO.FY,ARO.Office,ARO.FundCode,ARO.UID,ARO_Augmentation.Amount,ARO_Reversion.Amount,ARO_SupplementalBudget.Amount order by aro.UID desc").DefaultView
            Case Actions.adjustment
                ARODGV.DataSource = ClsConn.LoadData("SELECT ARO.ID as ID, ARO.AROID as [ARO ID], ARO.FY as [Calendar Year], ARO.Office as Office,
       ARO.FundCode as [Fund Code], 
       CASE WHEN SUM(ISNULL(ARO_Augmentation.Amount, 0)) = 0 THEN NULL ELSE SUM(ISNULL(ARO_Augmentation.Amount, 0)) END as [Augmentation], 
       CASE WHEN SUM(ISNULL(ARO_Reversion.Amount, 0)) = 0 THEN NULL ELSE SUM(ISNULL(ARO_Reversion.Amount, 0)) END as [Reversion], 
       CASE WHEN SUM(ISNULL(ARO_SupplementalBudget.Amount, 0)) = 0 THEN NULL ELSE SUM(ISNULL(ARO_SupplementalBudget.Amount, 0)) END as [Supplemental Budget] 
FROM ARO 
INNER JOIN ARO_Appropriation ON ARO.ID = ARO_Appropriation.id
LEFT JOIN ARO_Augmentation ON ARO_Appropriation.UID = ARO_Augmentation.ID 
LEFT JOIN ARO_Reversion ON ARO_Appropriation.UID = ARO_Reversion.ID 
LEFT JOIN ARO_SupplementalBudget ON ARO_Appropriation.UID = ARO_SupplementalBudget.ID 
GROUP BY ARO.ID, ARO.AROID, ARO.FY, ARO.Office, ARO.FundCode, ARO.UID
ORDER BY ARO.UID DESC

").DefaultView


        End Select
    End Sub

    Private Sub frmARO_OtherDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        theme.myCustomSkinDark(Me)
        ShowAppro()
        ARODGV.Columns(0).Visible = False

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
ON ARO_Appropriation.UID = ARO_Allotment.ID where AROID like '%{0}%' OR FY like '%{0}%' OR Office like '%{0}%'  OR FundCode like '%{0}%'  group by 
ARO.ID, ARO.AROID,ARO.FY,ARO.Office,ARO.FundCode,ARO.UID order by aro.UID desc", searchString)
                ARODGV.DataSource = ClsConn.LoadData(str).DefaultView
            Case Actions.allotment
                Dim searchString As String = txtSearchARO.Text
                Dim str As String = String.Format("SELECT  ARO.ID as ID, ARO.AROID as [ARO ID], ARO.FY as [Calendar Year], ARO.Office as Office,
ARO.FundCode as [Fund Code], ARO_Allotment.Purpose as [Purpose] from ARO inner join ARO_Appropriation on aro.id = ARO_Appropriation.id
 LEFT JOIN ARO_Allotment
ON ARO_Appropriation.UID = ARO_Allotment.ID where AROID like '%{0}%' OR FY like '%{0}%' OR Office like '%{0}%'  OR FundCode like '%{0}%'  group by 
ARO.ID, ARO.AROID,ARO.FY,ARO.Office,ARO.FundCode,ARO_Allotment.Purpose,ARO.UID order by aro.UID desc", searchString)
                ARODGV.DataSource = ClsConn.LoadData(str).DefaultView
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
       CASE WHEN SUM(ISNULL(ARO_Augmentation.Amount, 0)) = 0 THEN NULL ELSE SUM(ISNULL(ARO_Augmentation.Amount, 0)) END as [Augmentation], 
       CASE WHEN SUM(ISNULL(ARO_Reversion.Amount, 0)) = 0 THEN NULL ELSE SUM(ISNULL(ARO_Reversion.Amount, 0)) END as [Reversion], 
       CASE WHEN SUM(ISNULL(ARO_SupplementalBudget.Amount, 0)) = 0 THEN NULL ELSE SUM(ISNULL(ARO_SupplementalBudget.Amount, 0)) END as [Supplemental Budget] 
FROM ARO 
INNER JOIN ARO_Appropriation ON ARO.ID = ARO_Appropriation.id
LEFT JOIN ARO_Augmentation ON ARO_Appropriation.UID = ARO_Augmentation.ID 
LEFT JOIN ARO_Reversion ON ARO_Appropriation.UID = ARO_Reversion.ID 
LEFT JOIN ARO_SupplementalBudget ON ARO_Appropriation.UID = ARO_SupplementalBudget.ID   where AROID like '%{0}%' OR FY like '%{0}%' OR Office like '%{0}%'  OR FundCode like '%{0}%' OR ARO_Augmentation.Amount like '%{0}%' OR ARO_Reversion.Amount like '%{0}%' OR ARO_SupplementalBudget.Amount like '%{0}%' 
GROUP BY ARO.ID, ARO.AROID, ARO.FY, ARO.Office, ARO.FundCode, ARO.UID
ORDER BY ARO.UID DESC", searchString)
                ARODGV.DataSource = ClsConn.LoadData(str).DefaultView

        End Select
    End Sub
    Private Async Sub SomeMethod()
        frmARO_Allotment.cmbOffice.Enabled = True
        Await Task.Delay(2)
        frmARO_Allotment.cmbOffice.Enabled = False
    End Sub

    Private Sub ARODGV_MouseClick(sender As Object, e As MouseEventArgs) Handles ARODGV.MouseClick
        ' Try
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


                ' Fetch the latest ID from the database
                If (ClsConn.OpenConnection() = True) Then

                    Dim sql As String = "
Select 
RTRIM(ARO.ID), 
RTRIM(ARO_Appropriation.AccountCode),
RTRIM(ARO_Appropriation.Description),
RTRIM(ARO_Appropriation.Amount),
RTRIM(ARO_Appropriation.UID),
RTRIM(ISNULL(ARO_Augmentation.Amount, 0)),
RTRIM(ARO_Augmentation.UID),
RTRIM(ARO_Augmentation.Remarks),
RTRIM(ISNULL(ARO_Reversion.Amount, 0)),
RTRIM(ARO_Reversion.UID),
RTRIM(ARO_Reversion.Remarks),
RTRIM(ISNULL(ARO_SupplementalBudget.Amount, 0)),
RTRIM(ARO_SupplementalBudget.UID),
RTRIM(ARO_SupplementalBudget.Remarks)
from ARO 
inner join ARO_Appropriation on aro.id = ARO_Appropriation.id
LEFT JOIN ARO_Augmentation
ON ARO_Appropriation.UID = ARO_Augmentation.ID LEFT JOIN ARO_Reversion
ON ARO_Appropriation.UID = ARO_Reversion.ID LEFT JOIN ARO_SupplementalBudget
ON ARO_Appropriation.UID = ARO_SupplementalBudget.ID where ARO.ID=@ID order by ARO_Appropriation.UID asc"
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
                            rdr(6),
                            rdr(7),
                            Convert.ToDouble(rdr(8)).ToString("N2", CultureInfo.InvariantCulture),
                            rdr(9),
                            rdr(10),
                            Convert.ToDouble(rdr(11)).ToString("N2", CultureInfo.InvariantCulture),
                            rdr(12),
                            rdr(13)
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
                    If frmARO_Adjustments.ARODGV.Columns(7).Name = "Reversion" Then
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
                    If frmARO_Adjustments.ARODGV.Columns(10).Name = "SupplementalBudget" Then
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

                Me.Close()
                Exit Sub

            End If
            Select Case mode
                Case Modes.add 'For Allotment
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
Select RTRIM(ARO.ID),RTRIM(ARO_Appropriation.AccountCode),RTRIM(ARO_Appropriation.Description),RTRIM(ARO_Appropriation.Amount)
, RTRIM(ISNULL(ARO_Allotment.Amount, 0)),RTRIM(ARO_Appropriation.UID),RTRIM(ARO_Allotment.Purpose),RTRIM(ARO_Allotment.UID),RTRIM(ARO_Allotment.EntryDate)    from ARO 
inner join ARO_Appropriation on aro.id = ARO_Appropriation.id
LEFT JOIN ARO_Allotment
ON ARO_Appropriation.UID = ARO_Allotment.ID where ARO.ID=@ID and (@Purpose IS NULL OR ARO_Allotment.Purpose = @Purpose) order by ARO_Appropriation.UID asc"
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
                            frmARO_Allotment.ARODGV.Rows.Add(rdr(1), rdr(2), formattedValue3, formattedValue4, rdr(5), rdr(7))
                            frmARO_Allotment.txtPurpose.Text = rdr(6).ToString()
                            frmARO_Allotment.entrydate = rdr(8).ToString
                            If rdr(6).ToString() Is Nothing Or rdr(6).ToString() = "" Then
                                frmARO_Allotment.btnUpdate.Enabled = False
                                frmARO_Allotment.btnSave.Enabled = True
                            Else
                                frmARO_Allotment.btnUpdate.Enabled = True
                                frmARO_Allotment.btnSave.Enabled = False
                            End If

                        End While
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
 where ARO.ID=" & dr.Cells(0).Value & ""
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
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub
End Class