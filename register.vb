Imports MySql.Data.MySqlClient

Public Class register
    Private connectionString As String = "server=localhost;user id=root;password=;database=rentallaptop;"

    Private Sub regUser_TextChanged(sender As Object, e As EventArgs) Handles regUser.TextChanged
        ' Kosongkan atau tambahkan logika yang diperlukan
    End Sub

    Private Sub regPass_TextChanged(sender As Object, e As EventArgs) Handles regPass.TextChanged
        ' Kosongkan atau tambahkan logika yang diperlukan
    End Sub

    Private Sub btnreg_Click(sender As Object, e As EventArgs) Handles btnreg.Click
        Dim username As String = regUser.Text
        Dim password As String = regPass.Text

        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
            MsgBox("Nama pengguna dan kata sandi tidak boleh kosong.")
            Return
        End If

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "INSERT INTO Users (username, password, role) VALUES (@username, @password, 'customer')"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Registrasi berhasil! Akun Anda telah dibuat dan data telah masuk ke database dengan peran customer.", "Registrasi Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide() ' Menutup form setelah registrasi berhasil
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Registrasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
