Imports MySql.Data.MySqlClient

Public Class train_result
    Public from_stat, to_stat, adult, infants, date_departure As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub train_result_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        from_stat = book_form.from_stat
        to_stat = book_form.to_stat
        adult = book_form.adult
        infants = book_form.infants
        date_departure = book_form.date_departure


    End Sub

    Sub showTrainable()
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
        sql = "SELECT * FROM station"

        cmd = New MySqlCommand(sql, conn)

        rd = cmd.ExecuteReader

        If rd.HasRows Then
            While rd.Read
                Dim R As DataRow = dt.NewRow
                R("ID") = rd("id")
                dt.Rows.Add(R)
            End While
        End If

        traintbl.DataSource = ds.Tables(0)

    End Sub
End Class