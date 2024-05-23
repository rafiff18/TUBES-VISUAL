Imports MySql.Data.MySqlClient

Public Class login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text
        Dim role As String = AuthenticateUser(username, password)
        Dim noPelanggan As String = GetNoPelanggan(username)

        If role <> "" Then
            If role = "customer" Then
                MessageBox.Show("Costumer login berhasil")
                customer.noPelanggan = noPelanggan
                customer.Show()
                Me.Hide()

            ElseIf role = "admin" Then
                MessageBox.Show("Admin login berhasil")
                Me.Hide()
                Form1.Show()
            End If
        Else
            MessageBox.Show("Username atau Password salah")
        End If
    End Sub

    Private Function GetNoPelanggan(username As String) As String
        Try
            Using conn As New MySqlConnection("server=localhost;user id=root;password=;database=rentallaptop;")
                conn.Open()
                Dim query As String = "SELECT noPelanggan FROM users WHERE username=@username"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        Return result.ToString()
                    Else
                        Return String.Empty
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            Return String.Empty
        End Try
    End Function

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class