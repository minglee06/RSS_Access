Imports System.Data.OleDb
Public Class Access_Connection
    Public Shared Property ConnStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\RSS_Access\bin\App_Data\RSS_Access.mdb"
    Public Shared Property Connection As New OleDbConnection(ConnStr)
    Public Shared Property ImagePath As String = "C:\RSS_Access\bin\Commodity_Image\"
    Public Shared Property ImageRawPath As String = "C:\RSS_Access\bin\Commodity_RAW_Image\"
    Public Shared Function GetData(ByVal CommandText As String) As DataTable
        Connection.Open()
        Dim command As New OleDbCommand(CommandText, Connection)
        Dim myAdapter As New OleDbDataAdapter(command)
        Dim table As New DataTable
        myAdapter.Fill(table)
        Connection.Close()
        Return table
    End Function



End Class
