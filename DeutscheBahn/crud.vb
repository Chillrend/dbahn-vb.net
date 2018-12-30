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
    Sub KodongkanData()
        idBox.Text = ""
        nameBox.Text = ""
        routeidBox.Text = ""
        locidBox.Text = ""
    End Sub

    Private Sub crud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call showStatTable()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles addtodbBtn.Click
        If idBox.Text = "" Or nameBox.Text = "" Or locidBox.Text = "" Or routeidBox.Text = "" Then
            MessageBox.Show("Please Fill All Forms")
        Else
            Call connect()

            Dim insertSql As String = "INSERT INTO station values ('" & idBox.Text & "','" & nameBox.Text & "','" & locidBox.Text & "','" & routeidBox.Text & "')"

            cmd = New MySqlCommand(insertSql, conn)
            cmd.ExecuteNonQuery()

            MsgBox("Input Data Berhasil")

            Call showStatTable()
            Call KodongkanData()

        End If
    End Sub

    Private Sub deletefromtblBtn_Click(sender As Object, e As EventArgs) Handles deletefromtblBtn.Click
        If idBox.Text = "" Then
            MsgBox("Please Fill Station ID")
        Else
            If MessageBox.Show("Are you sure to delete this data ?", "", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                Call connect()
                Dim hapus As String = "DELETE FROM station  WHERE id='" & idBox.Text & "'"
                cmd = New MySqlCommand(hapus, conn)
                cmd.ExecuteNonQuery()
                Call showStatTable()
                Call KodongkanData()
            End If
        End If
    End Sub

    Private Sub idBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles idBox.KeyPress
        idBox.MaxLength = 3
        If e.KeyChar = Chr(13) Then
            Call connect()
            cmd = New MySqlCommand("SELECT * FROM station WHERE id='" & idBox.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                MsgBox("Station Not Found, make sure the ID is correct")
                idBox.Focus()
            Else
                nameBox.Text = rd.Item("name")
                locidBox.Text = rd.Item("loc_id")
                routeidBox.Text = rd.Item("route_id")
                nameBox.Focus()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call connect()
        Dim edit As String = "UPDATE station SET name='" & nameBox.Text & "',loc_id='" & locidBox.Text & "',route_id='" & routeidBox.Text & "' WHERE id='" & idBox.Text & "'"
        cmd = New MySqlCommand(edit, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Successfully Updated")
        Call showStatTable()
        Call KodongkanData()
    End Sub
End Class