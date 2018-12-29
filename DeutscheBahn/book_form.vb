Imports MySql.Data.MySqlClient
Public Class book_form
    Public from_stat, to_stat, adult, infants, date_departure As String

    Sub loadCombo()

        depDate.Format = DateTimePickerFormat.Custom
        depDate.CustomFormat = "yyyy-MM-dd"

        Call connect()

        Dim str As String
        str = "SELECT * FROM station"

        cmd = New MySqlCommand(str, conn)

        rd = cmd.ExecuteReader

        If rd.HasRows Then
            Dim station As DataTable
            station = New DataTable()
            station.Load(rd)

            from_st.DataSource = station
            from_st.DisplayMember = "name"
            from_st.ValueMember = "id"

            to_st.DataSource = station
            to_st.DisplayMember = "name"
            to_st.ValueMember = "id"
        End If
    End Sub

    Private Sub book_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call loadCombo()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
        Form1.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If from_st.SelectedValue = to_st.SelectedValue Then
            from_stat = from_st.SelectedValue
            to_stat = to_st.SelectedValue
            adult = passgr_real.Text
            infants = passgr_fake.Text
            date_departure = depDate.Text
        End If

        train_result.Show()
    End Sub
End Class