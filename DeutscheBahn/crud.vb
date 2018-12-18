Imports MySql.Data.MySqlClient


Public Class crud
    Sub showStatTable()
        Dim ada As New MySqlDataAdapter()
        Dim ds As New DataSet

        Call connect()

        ada = New MySqlDataAdapter("SELECT * FROM station", conn)

        ada.Fill(ds)
        stationTable.DataSource = ds.Tables(0)

    End Sub

    Private Sub crud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call showStatTable()

    End Sub
End Class