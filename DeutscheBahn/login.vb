Imports MySql.Data.MySqlClient

Public Class login
    Dim username, password As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        username = uname.Text
        password = pwd.Text

        Call verifyPwd()
    End Sub

    Sub verifyPwd()
        Call connect()

        Dim sql As String

        sql = "SELECT * FROM user WHERE username='" + username + "' AND password='" + password + "'"

        cmd = New MySqlCommand(sql, conn)

        rd = cmd.ExecuteReader

        If rd.HasRows Then
            Do While rd.Read
                MessageBox.Show("Access Granted!, Welcome " + rd("username"))
            Loop
        Else
            MessageBox.Show("Username or Password Wrong!")
        End If
    End Sub

End Class