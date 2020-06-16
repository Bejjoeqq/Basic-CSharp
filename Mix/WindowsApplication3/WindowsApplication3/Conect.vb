Imports System.Data
Imports System.Data.Odbc
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Module Connect
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public rd As MySqlDataReader
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public str As String


    Sub connectt()
        Try
            Dim str As String = "server=localhost;user id=root;password=;database=pegawai"
            conn = New MySqlConnection(str)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Module
