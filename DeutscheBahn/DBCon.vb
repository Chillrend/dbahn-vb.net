Imports MySql.Data.MySqlClient
Module DBCon

    Public conn, conn2, conn3, conn4, conn5 As MySqlConnection
    Public cmd As MySqlCommand
    Public rd, rd2, rd3, rd4, rd5 As MySqlDataReader
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

    Sub connect2()
        Try
            Dim str As String
            str = "server=127.0.0.1;" _
            & "uid=akar;" _
            & "pwd=akarpohon;" _
            & "database=trendb"

            conn = New MySqlConnection(str)

            If conn2.State = ConnectionState.Closed Then
                conn2.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub connect3()
        Try
            Dim str As String
            str = "server=127.0.0.1;" _
            & "uid=akar;" _
            & "pwd=akarpohon;" _
            & "database=trendb"

            conn = New MySqlConnection(str)

            If conn3.State = ConnectionState.Closed Then
                conn3.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub connect4()
        Try
            Dim str As String
            str = "server=127.0.0.1;" _
            & "uid=akar;" _
            & "pwd=akarpohon;" _
            & "database=trendb"

            conn = New MySqlConnection(str)

            If conn4.State = ConnectionState.Closed Then
                conn4.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub connect5()
        Try
            Dim str As String
            str = "server=127.0.0.1;" _
            & "uid=akar;" _
            & "pwd=akarpohon;" _
            & "database=trendb"

            conn = New MySqlConnection(str)

            If conn5.State = ConnectionState.Closed Then
                conn5.Open()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Module
