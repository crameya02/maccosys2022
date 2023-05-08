Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.DbType
Imports System.IO
Imports System.ComponentModel
Imports System.Globalization

Public Class ClsConn

    Public Shared Sub Initialize()
        'default for testing
        'Dim server As String = "localhost"
        'Dim database As String = "conferencedb" 'name ng database mo
        'Dim username As String = "root"
        'Dim passowrd As String = "" 'password ng database mo
        'cnString = String.Format("server={0};port=3306;username={1};password={2};database={3};
        'Allow User Variables=true", server, username, password, database)
        'sqlCon = New MySqlConnection(cnString)

        'modified to allow user to change setting
        'Dim defaultAppPath As String = Path.Combine(Directory.GetCurrentDirectory(), "Setting")
        'Dim backUpPath As String = defaultAppPath
        'Dim mySettings As String = backUpPath & "\Settings.ini"
        'Dim objIniFile As New ClsIni(mySettings)
        'If (Not System.IO.Directory.Exists(backUpPath)) Then
        '    System.IO.Directory.CreateDirectory(backUpPath)
        'End If
        'If Not System.IO.File.Exists(mySettings) Then
        '    System.IO.File.Create(mySettings).Dispose()
        'End If
        'Dim readServer As String = objIniFile.GetString("Database", "server", "")
        'Dim readDBName As String = objIniFile.GetString("Database", "name", "")
        'Dim readUsername As String = objIniFile.GetString("Database", "username", "")
        'Dim readPassword As String = objIniFile.GetString("Database", "password", "")
        'If readServer = "" Or readDBName = "" Or readUsername = "" Then
        '    objIniFile.WriteString("Database", "server", "localhost")
        '    objIniFile.WriteString("Database", "name", "conferencedb")
        '    objIniFile.WriteString("Database", "username", "root")
        '    objIniFile.WriteString("Database", "password", "")
        '    readServer = objIniFile.GetString("Database", "server", "")
        '    readDBName = objIniFile.GetString("Database", "name", "")
        '    readUsername = objIniFile.GetString("Database", "username", "")
        '    readPassword = objIniFile.GetString("Database", "password", "")
        'End If
        'cnString = String.Format("server={0};port=3306;username={1};password={2};database={3};Allow User Variables=true", readServer, readUsername, Decrypt(readPassword), readDBName)
        ''Dim cnString As String
        ''Using sr As StreamReader = New StreamReader(Application.StartupPath & "\SQLSettings.dat")
        ''    cnString = sr.ReadLine()
        ''End Using
        sqlCon = New SqlConnection(cs)
    End Sub
    Public Shared Function OpenConnection() As Boolean
        Initialize()
        Try
            sqlCon.Open()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Public Shared Function CloseConnection() As Boolean
        Try
            sqlCon.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    'gamitin pag populate ng data sa datagridview
    Public Shared Function LoadData(ByVal str As String) As DataTable
        OpenConnection()
        Dim query As String = str
        Dim table = New DataTable
        Dim da = New SqlDataAdapter()
        Dim cmd = New SqlCommand(query, sqlCon)

        da.SelectCommand = cmd
        da.Fill(table)

        CloseConnection()
        Return table
    End Function
    Public Shared Function LoadDataWithDateBetween(ByVal str As String, datefrom As String, dateto As String) As DataTable
        OpenConnection()
        Dim query As String = str
        Dim table = New DataTable
        Dim da = New SqlDataAdapter()
        Dim cmd = New SqlCommand(query, sqlCon)
        cmd.Parameters.AddWithValue("@datefrom", datefrom)
        cmd.Parameters.AddWithValue("@dateto", dateto)
        da.SelectCommand = cmd
        da.Fill(table)

        CloseConnection()
        Return table
    End Function
    Public Shared Function LoadDatatest(ByVal str As String) As DataTable
        OpenConnection()

        Dim query As String = str
        Dim table = New DataTable
        Dim da = New SqlDataAdapter()
        Dim cmd = New SqlCommand(query, sqlCon)
        da.SelectCommand = cmd
        ' worker.ReportProgress(0)
        da.Fill(table)
        ' worker.ReportProgress(100)
        CloseConnection()
        Return table
    End Function

    Public Shared Function LoadDataWithSearch(ByVal str As String, strStart As String, inputString As String) As DataTable
        OpenConnection()
        Dim strSearch As String = strStart & "-" & inputString
        Dim query As String = str
        Dim table = New DataTable
        Dim da = New SqlDataAdapter()
        Dim cmd = New SqlCommand(query, sqlCon)
        cmd.Parameters.AddWithValue("@search", strSearch & "%")
        da.SelectCommand = cmd
        da.Fill(table)

        CloseConnection()
        Return table
    End Function
    Public Shared Function LoadExactData(ByVal str As String, search As String) As DataTable
        OpenConnection()

        Dim query As String = str
        Dim table = New DataTable
        Dim da = New SqlDataAdapter()
        Dim cmd = New SqlCommand(query, sqlCon)
        cmd.Parameters.AddWithValue("@search", search)
        da.SelectCommand = cmd
        da.Fill(table)

        CloseConnection()
        Return table
    End Function
    'Public Shared Function LoadData(ByVal str As String) As DataTable
    '    OpenConnection()
    '    Dim query As String = str
    '    Dim table = New DataTable
    '    Dim da = New MySqlDataAdapter()
    '    Dim ds As DataSet
    '    Dim cmd = New MySqlCommand(query, sqlCon)
    '    ds = New DataSet
    '    da.Fill(ds, "Table")

    '    CloseConnection()
    '    Return table
    'End Function

    'gamitin pag count ng rows ng query, pero kung galing sa dtgv pde na ung datagridview1.rows.count
    Public Shared Function CountRec(ByVal str As String) As Integer
        OpenConnection()
        Dim query As String = str
        Dim da = New SqlDataAdapter()
        Dim cmd = New SqlCommand(query, sqlCon)
        da.SelectCommand = cmd
        Dim id As Integer = CInt(cmd.ExecuteScalar)

        CloseConnection()
        Return id
    End Function
    Public Shared Function CountRecWithDate(ByVal str As String, datefrom As String, dateto As String) As Integer
        OpenConnection()
        Dim query As String = str
        Dim da = New SqlDataAdapter()
        Dim cmd = New SqlCommand(query, sqlCon)
        cmd.Parameters.AddWithValue("@datefrom", datefrom)
        cmd.Parameters.AddWithValue("@dateto", dateto)
        da.SelectCommand = cmd
        Dim id As Integer = CInt(cmd.ExecuteScalar)

        CloseConnection()
        Return id
    End Function
    'gagamitin pag kukunin id usually sa FK
    Public Shared Function GetId(ByVal query As String) As Integer
        OpenConnection()
        Dim q As String = query
        Dim da = New SqlDataAdapter()
        Dim cmd = New SqlCommand(query, sqlCon)
        da.SelectCommand = cmd
        Dim id As Integer = CInt(cmd.ExecuteScalar)
        CloseConnection()
        Return id
    End Function

    'gamitin para autoincrement ung id, you can set it naman sa db pero pag may nabura na tau di na un mapapalitan ng AI lang sa db.
    Public Shared Function Generateid(ByVal query As String) As Integer
        OpenConnection()
        Dim list As New List(Of Integer)
        Dim genid As Integer = 0
        Dim cmd = New SqlCommand(query, sqlCon)
        cmd = New SqlCommand(query, sqlCon)
        Dim reader As SqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            list.Add(reader(0))
        End While

        Dim squares As IEnumerable(Of Integer) = Enumerable.Range(1, list.Count + 1).Except(list)

        Dim missing As Integer
        For Each missing In squares
            genid = missing
            Exit For
        Next

        Return genid

        CloseConnection()
    End Function
    Public Shared Function GetParticipantID(ByVal query As String) As String
        OpenConnection()
        Dim q As String = query
        Dim da = New SqlDataAdapter()
        Dim cmd = New SqlCommand(query, sqlCon)
        da.SelectCommand = cmd
        Dim id As String = CStr(cmd.ExecuteScalar)
        CloseConnection()
        Return id
    End Function
    Public Shared Function getSAAOB_Balances(datefrom As String, dateto As String) As (GrandTotalAppro As String, GrandTotalAllot As String, GrandTotalObli As String, GrandTotalUnobli As String)
        Dim GrandTotalAppro As String = ""
        Dim GrandTotalAllot As String = ""
        Dim GrandTotalObli As String = ""
        Dim GrandTotalUnobli As String = ""
        ' Fetch the latest ID from the database
        If (ClsConn.OpenConnection() = True) Then

            Dim sql As String = "WITH 
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
	WHERE  ARO_Reversion.DateModified Between  @datefrom and @dateto
    GROUP BY ARO_Appropriation.UID 
),
ARO_SupplementalBudget_Summary AS (
    SELECT ARO_Appropriation.UID, SUM(ISNULL(ARO_SupplementalBudget.Amount, 0)) AS SupplementalBudget
    FROM ARO_Appropriation
    LEFT JOIN ARO_SupplementalBudget ON ARO_Appropriation.UID = ARO_SupplementalBudget.ID
	WHERE  ARO_SupplementalBudget.DateModified Between  @datefrom and @dateto
    GROUP BY ARO_Appropriation.UID 
),
AAO AS (
     SELECT ARO.ID, ARO_Appropriation.UID, ARO.FundCode, 
       ARO.Office, ARO_Appropriation.Description, 
       ARO_Appropriation.AccountCode, ARO_Appropriation.Amount AS Appropriation,
       SUM(ISNULL(ARO_Allotment.Amount, 0)) AS Allotment,
	   ISNULL(AAS.Augmentation, 0) AS Augmentation,
	   ISNULL(ARS.Reversion, 0) AS Reversion,
	   ISNULL(ASBS.SupplementalBudget, 0) AS SupplementalBudget
	   
	  
FROM ARO 
INNER JOIN ARO_Appropriation 
    ON ARO.ID = ARO_Appropriation.ID
LEFT JOIN ARO_Allotment
    ON ARO_Appropriation.UID = ARO_Allotment.ID
	LEFT JOIN ARO_Augmentation_Summary as AAS
    ON ARO_Appropriation.UID = AAS.UID
	LEFT JOIN ARO_Reversion_Summary as ARS
    ON ARO_Appropriation.UID = ARS.UID
	LEFT JOIN ARO_SupplementalBudget_Summary as ASBS
    ON ARO_Appropriation.UID = ASBS.UID

   WHERE
	 (ARO_Allotment.EntryDate Between  @datefrom and @dateto)
AND (ARO.EntryDate Between  @datefrom and @dateto)
GROUP BY ARO.ID, ARO_Appropriation.UID,ARO.FundCode, 
         ARO.Office, ARO_Appropriation.Description, 
         ARO_Appropriation.AccountCode, ARO_Appropriation.Amount,Augmentation,Reversion,SupplementalBudget
		
),
Balances AS (
    SELECT ResCenter AS Office, AccountCode, SUM(Amount) AS Obligations
    FROM OBRE_OtherDetails
   WHERE
         (EntryDate BETWEEN  @datefrom and @dateto)
       
    GROUP BY AccountCode, ResCenter 
),
AllData AS (
SELECT AAO.Description, AAO.AccountCode, 

CAST(AAO.Appropriation AS decimal(18,2)) + 
CAST(AAO.Augmentation AS decimal(18,2)) + 
CAST(AAO.Reversion AS decimal(18,2)) +
CAST(AAO.SupplementalBudget AS decimal(18,2))
	 AS Appropriation, 

CAST(AAO.Augmentation AS decimal(18,2))+
CAST(AAO.Reversion AS decimal(18,2)) +
CAST(AAO.SupplementalBudget AS decimal(18,2)) + 
CAST(AAO.Allotment AS decimal(18,2)) as Allotment, 

CAST(Balances.Obligations AS decimal(18,2))
    as Obligations,

CAST(AAO.Augmentation AS decimal(18,2))+
CAST(AAO.Reversion AS decimal(18,2)) +
CAST(AAO.SupplementalBudget AS decimal(18,2)) + 
CAST(AAO.Allotment AS decimal(18,2)) -
CAST(Balances.Obligations AS decimal(18,2)) 
    AS Unobligated_Balance,AAO.Office,UID,AAO.FundCode
    FROM AAO 
    LEFT JOIN Balances 
        ON AAO.Office = Balances.Office 
        AND Balances.AccountCode = AAO.AccountCode
    
),
Result AS (
    SELECT Description, AccountCode, Appropriation, Allotment, ISNULL(Obligations, 0) AS Obligations, ISNULL(Unobligated_Balance,Allotment) as Unobligated_Balance
    , OFFICE, UID, FundCode FROM AllData 
),
Totals AS (
    SELECT 
        CAST(SUM(Appropriation) AS decimal(18,2)) AS Appropriation,
        CAST(SUM(Allotment) AS decimal(18,2)) AS Allotment, 
	    CAST(SUM(Obligations) AS decimal(18,2)) AS Obligations, 
	    CAST(SUM(Unobligated_Balance) AS decimal(18,2)) AS Unobligated_Balance
			
    FROM Result
)
SELECT 
Totals.Appropriation AS GrandTotalAppro,
    Totals.Allotment AS GrandTotalAllot,
    Totals.Obligations AS GrandTotalObli,
    Totals.Unobligated_Balance AS GrandTotalUnobli
FROM Totals

"
            cmd = New SqlCommand(sql, sqlCon)
            cmd.Parameters.AddWithValue("@datefrom", datefrom)
            cmd.Parameters.AddWithValue("@dateto", dateto)

            rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While (rdr.Read() = True)
                GrandTotalAppro = If(IsDBNull(rdr(0)), "0.00", Convert.ToDouble(rdr(0)).ToString("N2", CultureInfo.InvariantCulture))
                GrandTotalAllot = If(IsDBNull(rdr(1)), "0.00", Convert.ToDouble(rdr(1)).ToString("N2", CultureInfo.InvariantCulture))
                GrandTotalObli = If(IsDBNull(rdr(2)), "0.00", Convert.ToDouble(rdr(2)).ToString("N2", CultureInfo.InvariantCulture))
                GrandTotalUnobli = If(IsDBNull(rdr(3)), "0.00", Convert.ToDouble(rdr(3)).ToString("N2", CultureInfo.InvariantCulture))
            End While


            ClsConn.CloseConnection()

        End If

        Return (GrandTotalAppro, GrandTotalAllot, GrandTotalObli, GrandTotalUnobli)
    End Function

End Class
