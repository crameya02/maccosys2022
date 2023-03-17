Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.DbType
Imports System.IO

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


End Class
