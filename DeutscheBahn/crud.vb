Imports MySql.Data.MySqlClient


Public Class crud
    Sub showStatTable()
        Dim ada As New MySqlDataAdapter()
        Dim ds As New DataSet

        Call connect()

        ada = New MySqlDataAdapter("SELECT * FROM station", conn)

        ada.Fill(ds)
        stationTable.DataSource = ds.Tables(0)

        ds.Dispose()
        ada.Dispose()
        conn.Close()
    End Sub
    Sub showInvTable()
        Dim ada As New MySqlDataAdapter()
        Dim ds As New DataSet

        Call connect()

        ada = New MySqlDataAdapter("SELECT * FROM invoice", conn)

        ada.Fill(ds)
        inv_table.DataSource = ds.Tables(0)

        ds.Dispose()
        ada.Dispose()
        conn.Close()
    End Sub
    Sub showTrainTable()
        Dim ada As New MySqlDataAdapter()
        Dim ds As New DataSet

        Call connect()

        ada = New MySqlDataAdapter("SELECT * FROM series", conn)

        ada.Fill(ds)
        tbl_train.DataSource = ds.Tables(0)

        ds.Dispose()
        ada.Dispose()
        conn.Close()
    End Sub
    Sub KodongkanData()
        idBox.Text = ""
        nameBox.Text = ""
        routeidBox.Text = ""
        locidBox.Text = ""
    End Sub
    Sub clearInvForms()
        invo_id.Text = ""
        passgr_name.Text = ""
        tickets.Text = ""
        identification.Text = ""
        seat_id.Text = ""
    End Sub
    Sub clearTrainForms()
        train_id_box.Text = ""
        name_box.Text = ""
    End Sub

    Private Sub crud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call showStatTable()
        Call showInvTable()
        Call showTrainTable()
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


    Private Sub idBox_Leave(sender As Object, e As EventArgs) Handles idBox.Leave
        Call connect()
        cmd = New MySqlCommand("SELECT * FROM station WHERE id='" & idBox.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            MsgBox("ID Not Found, make sure the ID is correct")
        Else
            nameBox.Text = rd.Item("name")
            locidBox.Text = rd.Item("loc_id")
            routeidBox.Text = rd.Item("route_id")
            nameBox.Focus()
        End If
        rd.Close()
        rd.Dispose()
        conn.Close()
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

    Sub updateTable(sqls As String)
        Call connect()
        Dim edit As String = sqls
        cmd = New MySqlCommand(edit, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Successfully Updated")

        cmd.Dispose()
        conn.Close()
    End Sub
    Sub deleteEntries(sqls As String)
        Call connect()
        Dim hapus As String = sqls
        cmd = New MySqlCommand(hapus, conn)
        cmd.ExecuteNonQuery()

        cmd.Dispose()
        conn.Close()
    End Sub
    Sub addEntries(sqls As String)
        Call connect()

        Dim insertSql As String = sqls

        cmd = New MySqlCommand(insertSql, conn)
        cmd.ExecuteNonQuery()

        MsgBox("Input Data Berhasil")

        cmd.Dispose()
        conn.Close()
    End Sub

    'INVOICE TABLE UPDATE
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim sqls As String = "UPDATE invoice SET ticket_id='" & tickets.Text & "',name='" & passgr_name.Text & "',identification='" & identification.Text & "',seat_id='" & seat_id.Text & "' WHERE invoice_id='" & invo_id.Text & "'"
        Call updateTable(sqls)
        Call showInvTable()
        Call clearInvForms()
    End Sub

    Private Sub invo_id_Leave(sender As Object, e As EventArgs) Handles invo_id.Leave
        Call connect()
        cmd = New MySqlCommand("SELECT * FROM invoice WHERE invoice_id='" & invo_id.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            MsgBox("Invoice Not Found, make sure the ID is correct")
        Else
            tickets.Text = rd.Item("ticket_id")
            passgr_name.Text = rd.Item("name")
            identification.Text = rd.Item("identification")
            seat_id.Text = rd.Item("seat_id")
            tickets.Focus()
        End If
        rd.Close()
        rd.Dispose()
        conn.Close()
    End Sub

    'DELETE INVOICE ENTRIES
    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If invo_id.Text = "" Then
            MsgBox("Please Fill Invoice ID")
        Else
            If MessageBox.Show("Are you sure to delete this data ?", "", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                Dim sqls As String = "DELETE FROM invoice  WHERE invoice_id='" & invo_id.Text & "'"
                Call deleteEntries(sqls)
                Call showInvTable()
                Call clearInvForms()
            End If
        End If
    End Sub

    'INSERT INTO INVOICE TABLE
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If invo_id.Text = "" Or tickets.Text = "" Or passgr_name.Text = "" Or identification.Text = "" Or seat_id.Text = "" Then
            MessageBox.Show("Please Fill All Forms")
        Else

            Dim insertSql As String = "INSERT INTO invoice values ('" & invo_id.Text & "','" & tickets.Text & "','" & passgr_name.Text & "','" & identification.Text & "','" & seat_id.Text & "','" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & "')"
            Call addEntries(insertSql)
            Call showInvTable()
            Call clearInvForms()

        End If
    End Sub

    Private Sub train_id_box_Leave(sender As Object, e As EventArgs) Handles train_id_box.Leave
        Call connect()
        cmd = New MySqlCommand("SELECT * FROM series WHERE id='" & train_id_box.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            MsgBox("Train Not Found, make sure the ID is correct")
        Else
            name_box.Text = rd.Item("name")
            nameBox.Focus()
        End If
        rd.Close()
        rd.Dispose()
        conn.Close()
    End Sub

    'EDIT TRAIN ENTRIES
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Dim sqls As String = "UPDATE series SET name='" & name_box.Text & "' WHERE id=" & train_id_box.Text
        Call updateTable(sqls)
        Call showTrainTable()
        Call clearTrainForms()
    End Sub

    'DELETE TRAIN ENTRIES
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If train_id_box.Text = "" Then
            MsgBox("Please Fill Train ID")
        Else
            If MessageBox.Show("Are you sure to delete this data ?", "", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                Dim sqls As String = "DELETE FROM series WHERE id='" & train_id_box.Text & "'"
                Call deleteEntries(sqls)
                Call showTrainTable()
                Call clearTrainForms()
            End If
        End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If train_id_box.Text = "" Or name_box.Text = "" Then
            MessageBox.Show("Please Fill All Forms")
        Else
            Dim insertSql As String = "INSERT INTO series VALUES ('" & train_id_box.Text & "','" & name_box.Text & "')"
            Call addEntries(insertSql)
            Call showTrainTable()
            Call clearTrainForms()
        End If
    End Sub
End Class