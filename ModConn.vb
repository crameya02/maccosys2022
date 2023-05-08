Imports System.Data.SqlClient
Imports System.IO


Module ModConn
    'declare mo dito lahat ng variable na feeling mo need mo sa lahat ng form para accessible sya
    Public sqlCon As New SqlConnection
    Public cmd As New SqlCommand
    Public rdr As SqlDataReader
    Public mode As Integer 'gagamitin to para sa kung add, edit, delete ung mode ng process mo.
    Public action As Integer
    Public cnString As String = ""
    Public query As String
    Dim st As String

    Public Function ReadCS() As String
        Using sr As StreamReader = New StreamReader(Application.StartupPath & "\SQLSettings.dat")
            st = sr.ReadLine()
        End Using
        Return st
    End Function
    Public ReadOnly cs As String = ReadCS()

    Public pivotattendance As String = <![CDATA[
    SET @sql_dynamic = (
    SELECT
		    GROUP_CONCAT(DISTINCT
			    CONCAT(
				    'SUM(IF(date(a.logdatetime) = '
				    , '"', date(a.logdatetime), '"'
				    ,',1,0)) as '
				    , '"', date_format(a.logdatetime,'%b %d %Y'),  '"'
			    )
		    )
            FROM  conferencedb.attendance a
		
    );

            SET @sql = CONCAT('SELECT p.IDPARTICIPANT, p.LASTNAME, p.FIRSTNAME, p.MIDDLENAME, ', 
					    @sql_dynamic, ' FROM conferencedb.participants p, conferencedb.attendance a WHERE p.idparticipant=a.participantid GROUP BY p.idparticipant ORDER BY p.lastname'
	               );
	 
    PREPARE stmt FROM @sql;
    EXECUTE stmt;
    DEALLOCATE PREPARE stmt;
  ]]>.Value()


    'to clear textboxes in form para di isa isa
    ' Public Sub ClearTextbox(ByVal x As Form)
    'Dim a As Control
    'For Each a In x.Controls
    '    MsgBox(a.ToString)
    '    If TypeOf a Is TextBox Then

    '        a.Text = Nothing
    '    End If
    'Next
    'End Sub

    'clear all materialtextbox In all tabs
    Public Sub ClearTextbox(parent As Control)


        For Each child As Control In parent.Controls
            ClearTextbox(child)
        Next

        If TryCast(parent, MaterialSkin.Controls.MaterialTextBox) IsNot Nothing Then
            TryCast(parent, MaterialSkin.Controls.MaterialTextBox).Text = String.Empty

        End If
        If TryCast(parent, MaterialSkin.Controls.MaterialTextBox2) IsNot Nothing Then
            TryCast(parent, MaterialSkin.Controls.MaterialTextBox2).Text = String.Empty

        End If
    End Sub

    Public Enum Modes
        add = 1
        edit = 2
        view = 3
    End Enum
    Public Enum Actions
        appropriation = 1
        allotment = 2
        adjustment = 3
    End Enum
End Module
