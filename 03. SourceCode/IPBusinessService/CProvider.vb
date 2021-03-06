Option Explicit On 
Option Strict On

Public Class CProvider

    Private Const C_HAS_NOT_BEEN_READ_FROM_CONFIG_FILE As String = "NOT LOADED"
    Private Shared m_strConnectionStringCurrent As String = C_HAS_NOT_BEEN_READ_FROM_CONFIG_FILE
    Private Shared m_strConnectionStringCreateFromAppConfig As String = C_HAS_NOT_BEEN_READ_FROM_CONFIG_FILE
    Private Shared m_strDBname As String = ""
    Private Shared m_strDBnameAdmin As String = ""

#Region "Public interface"
    Public Shared Sub changeDataBase(ByVal i_str_db_name As String)
        m_strConnectionStringCurrent = getDBConnectionString(i_str_db_name)
    End Sub
    Public Shared Function getDBname() As String
        Return m_strDBname
    End Function
    Public Shared Sub refreshDBSettings()
        readConnectionString()
    End Sub
#End Region
    Shared Function getConnection() As SqlClient.SqlConnection
        Dim cn As New SqlClient.SqlConnection
        If m_strConnectionStringCurrent = C_HAS_NOT_BEEN_READ_FROM_CONFIG_FILE Then
            m_strConnectionStringCurrent = readConnectionString()
            m_strConnectionStringCreateFromAppConfig = m_strConnectionStringCurrent
        End If
        cn.ConnectionString = m_strConnectionStringCurrent '"data source=ACBNT;initial catalog=eSchool;user id=eSchool;password=eSchool"
        Return cn
    End Function
    Private Shared Function getDBConnectionString(ByVal i_str_db_name As String) As String
        Dim service As New LicenseManager.LicenseManager()
        Dim output As LicenseManager.DB_ISALARY = service.getInfoServer(ISCommon.ISCommon.getMac())
        Dim v_strServerName As String = "103.48.80.60\SQLEXPRESS"
        Dim v_strDatabase As String = output.DBNAME
        Dim v_strUser As String = output.USERNAME
        Dim v_strPwd As String = output.PASSWORD
        Dim v_strDatabaseAccessMode As String = "USER_AND_PASSWORD"


        Dim v_strConnectionString As String
        v_strConnectionString = "data source=" & v_strServerName & ";"
        v_strConnectionString &= "initial catalog= " & i_str_db_name & ";"
        Select Case v_strDatabaseAccessMode
            Case "NO_USER_AND_PASSWORD"
                v_strConnectionString &= "Persist Security Info=True;"
            Case "USER_AND_PASSWORD"
                v_strConnectionString &= "user id=" & v_strUser & ";"
                v_strConnectionString &= "password=" & v_strPwd
        End Select
        m_strDBname = i_str_db_name
        v_strConnectionString &= " ;Connection Timeout=30"
        Return v_strConnectionString
    End Function
    Shared Function getAdapter() As SqlClient.SqlDataAdapter
        Dim da As New SqlClient.SqlDataAdapter
        Return da
    End Function
    Private Shared Function readConnectionString() As String

        Dim service As New LicenseManager.LicenseManager()
        Dim output As LicenseManager.DB_ISALARY = service.getInfoServer(ISCommon.ISCommon.getMac())
        Dim v_strServerName As String = "103.48.80.60\SQLEXPRESS"
        Dim v_strDatabase As String = output.DBNAME
        Dim v_strUser As String = output.USERNAME
        Dim v_strPwd As String = output.PASSWORD
        Dim v_strDatabaseAccessMode As String = "USER_AND_PASSWORD"


        'Dim v_configReader As New System.Configuration.AppSettingsReader
        'Dim v_strServerName As String = v_configReader.GetValue("SERVER", System.Type.GetType("System.String")).ToString()
        'Dim v_strDatabase As String = v_configReader.GetValue("INITIAL_DATABASE", System.Type.GetType("System.String")).ToString()
        'Dim v_strUser As String = v_configReader.GetValue("INITIAL_USER", System.Type.GetType("System.String")).ToString()
        'Dim v_strPwd As String = v_configReader.GetValue("PASS_WORD", System.Type.GetType("System.String")).ToString()
        'Dim v_strDatabaseAccessMode As String = v_configReader.GetValue("DATABASE_ACCESS_MODE", System.Type.GetType("System.String")).ToString()
        'v_configReader = Nothing

        Dim v_strConnectionString As String
        v_strConnectionString = "data source=" & v_strServerName & ";"
        v_strConnectionString &= "initial catalog=" & v_strDatabase & ";"
        Select Case v_strDatabaseAccessMode
            Case "NO_USER_AND_PASSWORD"
                v_strConnectionString &= "Persist Security Info=True;"
            Case "USER_AND_PASSWORD"
                v_strConnectionString &= "user id=" & v_strUser & ";"
                v_strConnectionString &= "password=" & v_strPwd
        End Select
        m_strDBname = v_strDatabase
        m_strDBnameAdmin = v_strDatabase
        'v_strConnectionString &= " ;Connection Timeout=0"
        Return v_strConnectionString
    End Function


End Class
