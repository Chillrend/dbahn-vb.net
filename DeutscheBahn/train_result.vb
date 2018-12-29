Imports MySql.Data.MySqlClient

Public Class train_result
    Public from_stat, to_stat, from_text, to_text, adult, infants, date_departure As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub train_result_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        from_stat = book_form.from_stat
        to_stat = book_form.to_stat
        adult = book_form.adult
        infants = book_form.infants
        date_departure = book_form.date_departure
        from_text = book_form.from_text
        to_text = book_form.to_text

        Call showTrainTable()
    End Sub

    Sub showTrainTable()
        Dim dt As New DataTable
        Dim dc As New DataColumn



        dc = New DataColumn
        dc.DataType = System.Type.GetType("System.String")
        dc.ColumnName = "ID"
        dt.Columns.Add(dc)

        dc = New DataColumn
        dc.DataType = System.Type.GetType("System.String")
        dc.ColumnName = "Train Name"
        dt.Columns.Add(dc)

        dc = New DataColumn
        dc.DataType = System.Type.GetType("System.String")
        dc.ColumnName = "Departure Station"
        dt.Columns.Add(dc)

        dc = New DataColumn
        dc.DataType = System.Type.GetType("System.String")
        dc.ColumnName = "Arrival Station"
        dt.Columns.Add(dc)

        dc = New DataColumn
        dc.DataType = System.Type.GetType("System.String")
        dc.ColumnName = "Departure Date and Time"
        dt.Columns.Add(dc)

        dc = New DataColumn
        dc.DataType = System.Type.GetType("System.String")
        dc.ColumnName = "Price"
        dt.Columns.Add(dc)

        Call connect()

        Dim sql As String
        sql = "select * from ticket where std_id=" + from_stat + " and sta_id=" + to_stat + " and date_depart='" + date_departure + "';"
        '"select * from ticket where std_id=" + from_stat + " and sta_id=" + to_stat + " and date_depart='" + date_departure + "';"
        cmd = New MySqlCommand(sql, conn)

        rd = cmd.ExecuteReader

        If rd.HasRows Then
            While rd.Read
                Dim R As DataRow = dt.NewRow
                R("ID") = rd("tkt_id")

                Call connect2()
                Dim cmd2 As MySqlCommand
                Dim sequel As String
                sequel = "SELECT name FROM series WHERE id=" + rd.GetString("tr_id")
                cmd2 = New MySqlCommand(sequel, conn2)
                rd2 = cmd2.ExecuteReader
                If rd2.HasRows Then
                    While rd2.Read
                        R("Train name") = rd2.GetString("name")
                    End While
                End If
                cmd2.Dispose()
                conn2.Close()

                R("Departure Station") = from_text
                R("Arrival Station") = to_text
                R("Departure Date and Time") = rd.GetString("date_depart") + ", " + rd.GetString("time_depart")
                R("Price") = rd.GetString("price")

                dt.Rows.Add(R)
            End While
        End If

        traintbl.DataSource = dt

    End Sub
End Class