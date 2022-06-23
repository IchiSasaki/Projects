Imports MySql.Data.MySqlClient
Module Module1

    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public adapter As New MySqlDataAdapter
    Public dataB As New DataSet
    Public DTable As New DataTable
    Public DTable2 As New DataTable
    Public DReader As MySqlDataReader

    Sub openCon()
        con.ConnectionString = "server=localhost;username=root;password=;database=firstdatabase"
        con.Open()
    End Sub

End Module
