Imports MySql.Data.MySqlClient

Public Class register
    Private connectionString As String = "server=localhost;user id=root;password=;database=rentallaptop;"

    Private Sub btnreg_Click(sender As Object, e As EventArgs) Handles btnreg.Click
        Dim username As String = regUser.Text
        Dim password As String = regPass.Text

        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
            MsgBox("Nama pengguna dan kata sandi tidak boleh kosong.")
            Return
        End If

        Try
            Dim noPelanggan As String = GenerateNoPelanggan() ' Generate nomor pelanggan baru
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "INSERT INTO pelanggan (noPelanggan, namaPelanggan, alamatPelanggan, telpPelanggan, emailPelanggan) VALUES (@noPelanggan, @namaPelanggan, '', '', '')"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@noPelanggan", noPelanggan)
                    cmd.Parameters.AddWithValue("@namaPelanggan", username)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "INSERT INTO Users (username, password, role, noPelanggan) VALUES (@username, @password, 'customer', @noPelanggan)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)
                    cmd.Parameters.AddWithValue("@noPelanggan", noPelanggan)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Registrasi berhasil! Akun Anda telah dibuat dan data telah masuk ke database dengan peran customer.", "Registrasi Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide() ' Menutup form setelah registrasi berhasil
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Registrasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Fungsi untuk menghasilkan nomor pelanggan baru
    Private Function GenerateNoPelanggan() As String
        Dim noPelanggan As String = ""
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM pelanggan"
                Using cmd As New MySqlCommand(query, conn)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar()) + 1
                    noPelanggan = "P" & count.ToString("000")
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
        Return noPelanggan
    End Function
End Class
