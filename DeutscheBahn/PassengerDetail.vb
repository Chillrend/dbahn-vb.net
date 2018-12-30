Imports MySql.Data.MySqlClient
Public Class PassengerDetail
    Dim adult_counter As Integer = 1
    Public glo_array_inv_code, glo_array_passgr_name, glo_array_passgr_id, glo_array_seat As New ArrayList

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If adult_counter < Convert.ToInt32(train_result.adult) Then
            Call add_invoice()
            adult_counter = adult_counter + 1
            FormCounter.Text = adult_counter.ToString
            passgr_name.Text = ""
            passgr_id.Text = ""
        Else
            Call add_invoice()
            adult_counter = 1
            'Showing Details Here
            MsgBox("Counter Ends")
        End If
    End Sub

    Private Sub PassengerDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        passgr_id.Text = ""
        passgr_name.Text = ""

        FormCounter.Text = adult_counter
    End Sub
    Sub add_invoice()
        Dim seat, inv_id, name, identification As String

        Call connect()
        cmd = New MySqlCommand("SELECT * FROM seat WHERE tr_id = " & train_result.selected_train & " AND occupied=0 LIMIT 1", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            MsgBox("No Seat Left!")
        Else
            seat = rd.GetString("seat_id")
            glo_array_seat.Add(rd.GetString("seatseries") & rd.GetString("seatnum"))

            inv_id = System.Guid.NewGuid.ToString
            glo_array_inv_code.Add(inv_id)

            name = passgr_name.Text
            glo_array_passgr_name.Add(name)
            identification = passgr_id.Text
            glo_array_passgr_id.Add(identification)

            Dim date_issued As String = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")

            Call connect2()

            Dim insert_sql As String = "INSERT INTO invoice VALUES('" & inv_id & "', '" & train_result.selected_schedule & "', '" & name & "', '" & identification & "', '" & seat & "', '" & date_issued & "')"
            Dim cmd2 As New MySqlCommand
            cmd2 = New MySqlCommand(insert_sql, conn2)
            cmd2.ExecuteNonQuery()

            Call connect3()
            Dim update_sql As String = "UPDATE seat SET occupied = 1 WHERE seat_id='" & seat & "'"
            Dim cmd3 As New MySqlCommand
            cmd3 = New MySqlCommand(update_sql, conn3)
            cmd3.ExecuteNonQuery()

            cmd.Dispose()
            conn.Close()

            cmd2.Dispose()
            conn2.Close()

            cmd3.Dispose()
            conn3.Close()

            MsgBox("Success!, Proceed to Fill Another Passenger Details if Any")
        End If
    End Sub
End Class