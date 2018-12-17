Imports MySql.Data.MySqlClient
Module DBCon

    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public rd As MySqlDataReader
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public str As String

    Sub connect()
        Try
            Dim str As String
            str = "server=127.0.0.1;" _
            & "uid=akar;" _
            & "pwd=akarpohon;" _
            & "database=trendb"

            conn = New MySqlConnection(str)

            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Module
