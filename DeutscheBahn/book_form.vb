Imports MySql.Data.MySqlClient
Public Class book_form


    Sub loadCombo()
        Call connect()

        Dim str As String
        str = "SELECT * FROM station"

        cmd = New MySqlCommand(str, conn)

        rd = cmd.ExecuteReader

        If rd.HasRows Then
            Do While rd.Read
                from_st.Items.Add(rd("name"))
                to_st.Items.Add(rd("name"))
            Loop
        End If
    End Sub

    Private Sub book_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call loadCombo()

    End Sub
End Class