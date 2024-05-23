Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Module mdFungsiUmum
#Region "Database"
    Public str As String = "server=localhost;user id=root;password=;database=rentallaptop;"
    Public db As New MySqlConnection(str)
    Public myCommand As MySqlCommand
    Public myAdapter As MySqlDataAdapter
    Public myDataset As DataSet
    Public myReader As MySqlDataReader

    Public Sub bukaDB()
        Try
            tutupDB()
            db.Open()
            'MessageBox.Show("Connection Successfully", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As MySqlException
            MessageBox.Show("Caution!" & ex.Message, "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Sub tutupDB()
        If db.State = ConnectionState.Open Then
            db.Close()
        End If
    End Sub
#End Region

#Region "Login"
    Public Function AuthenticateUser(ByVal username As String, ByVal password As String) As String
        Try
            If db.State <> ConnectionState.Open Then
                db.Open()
            End If

            Dim query As String = "SELECT * FROM Users WHERE username=@username AND password=@password"
            Using cmd As New MySqlCommand(query, db)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@password", password)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    reader.Read()
                    Return reader("role").ToString()
                Else
                    Return ""
                End If
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            Return ""
        Finally
            tutupDB()
        End Try
    End Function
#End Region

#Region "Laptop"
    Public Function getTabelLaptop() As DataTable
        Dim myDataTable As DataTable

        Try
            bukaDB()
            myCommand = New MySqlCommand("SELECT * FROM laptop ORDER BY noLaptop", db)
            myAdapter = New MySqlDataAdapter(myCommand)
            myDataset = New DataSet

            myAdapter.Fill(myDataset, "noLaptop")
            myDataTable = myDataset.Tables(0)
            Return (myDataTable)

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        Finally
            tutupDB()

        End Try
    End Function

    Public Function getViewLaptop(ByVal merkLaptop As String) As DataTable
        Dim myViewTable As DataTable

        Try
            bukaDB()
            myCommand = New MySqlCommand("SELECT * FROM laptop WHERE merkLaptop = @merkLaptop", db)
            myCommand.Parameters.AddWithValue("@merkLaptop", merkLaptop)
            myAdapter = New MySqlDataAdapter(myCommand)
            myDataset = New DataSet

            myAdapter.Fill(myDataset, "merkLaptop")
            myViewTable = myDataset.Tables(0)
            Return (myViewTable)

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        Finally
            tutupDB()

        End Try
    End Function

    Public Sub tambah_menu_laptop(ByVal noLaptop As String, ByVal merkLaptop As String, ByVal seriLaptop As String, ByVal tipeLaptop As String, ByVal hargaSewa As String, ByVal statusLaptop As String, ByVal keteranganLaptop As String)
        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "INSERT INTO laptop (noLaptop, merkLaptop, seriLaptop, tipeLaptop, hargaSewa, statusLaptop,keteranganLaptop) VALUES (@noLaptop, @merkLaptop, @seriLaptop, @tipeLaptop,@hargaSewa, @statusLaptop, @keteranganLaptop)"
        myCommand.Parameters.AddWithValue("@noLaptop", noLaptop)
        myCommand.Parameters.AddWithValue("@merkLaptop", merkLaptop)
        myCommand.Parameters.AddWithValue("@seriLaptop", seriLaptop)
        myCommand.Parameters.AddWithValue("@tipeLaptop", tipeLaptop)
        myCommand.Parameters.AddWithValue("@hargaSewa", hargaSewa)
        myCommand.Parameters.AddWithValue("@statusLaptop", statusLaptop)
        myCommand.Parameters.AddWithValue("@keteranganLaptop", keteranganLaptop)

        Try
            bukaDB()
            myCommand.ExecuteNonQuery()
            MsgBox("Data berhasil di simpan")
            tutupDB()

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal dalam menyimpan data")

        Finally
            tutupDB()

        End Try
    End Sub

    Public Sub hapus_menu_laptop(ByVal noLaptop As String)
        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "DELETE FROM laptop WHERE noLaptop = @noLaptop"
        myCommand.Parameters.AddWithValue("@noLaptop", noLaptop)

        Try
            bukaDB()
            myCommand.ExecuteNonQuery()
            MsgBox("Data berhasil di hapus")
            bersih_menu()
            tutupDB()

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal menghapus data")

        Finally
            tutupDB()

        End Try
    End Sub

    Public Sub bersih_menu()
        With Form2
            .txtNoLaptop.Text = ""
            .txtMerk.Text = ""
            .txtSeries.Text = ""
            .txtTipe.Text = ""
            .txtKeterangan.Text = ""
            .txtHargaSewa.Text = ""
            .cbStatus.Text = ""
        End With
    End Sub

    Public Sub ubah_menu_laptop(ByVal noLaptop As String, ByVal merkLaptop As String, ByVal seriLaptop As String, ByVal tipeLaptop As String, ByVal hargaSewa As String, ByVal statusLaptop As String, ByVal keteranganLaptop As String)
        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "UPDATE laptop SET merkLaptop = @merkLaptop, seriLaptop = @seriLaptop, tipeLaptop = @tipeLaptop, hargaSewa = @hargaSewa, statusLaptop = @statusLaptop,keteranganLaptop = @keteranganLaptop WHERE noLaptop = @noLaptop"
        myCommand.Parameters.AddWithValue("@noLaptop", noLaptop)
        myCommand.Parameters.AddWithValue("@merkLaptop", merkLaptop)
        myCommand.Parameters.AddWithValue("@seriLaptop", seriLaptop)
        myCommand.Parameters.AddWithValue("@tipeLaptop", tipeLaptop)
        myCommand.Parameters.AddWithValue("@hargaSewa", hargaSewa)
        myCommand.Parameters.AddWithValue("@statusLaptop", statusLaptop)
        myCommand.Parameters.AddWithValue("@keteranganLaptop", keteranganLaptop)

        Try
            bukaDB()
            myCommand.ExecuteNonQuery()
            MsgBox("Data berhasil di ubah")
            tutupDB()

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal dalam menyimpan data")

        Finally
            tutupDB()

        End Try
    End Sub
#End Region

#Region "pelanggan"
    Public Function getTabelPelanggan() As DataTable
        Dim myDataTable As DataTable

        Try
            bukaDB()
            myCommand = New MySqlCommand("SELECT * FROM pelanggan ORDER BY noPelanggan", db)
            myAdapter = New MySqlDataAdapter(myCommand)
            myDataset = New DataSet

            myAdapter.Fill(myDataset, "noPelanggan")
            myDataTable = myDataset.Tables(0)
            Return (myDataTable)

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        Finally
            tutupDB()

        End Try
    End Function

    Public Function getViewPelanggan(ByVal namaPelanggan As String) As DataTable
        Dim myViewTable As DataTable

        Try
            bukaDB()
            myCommand = New MySqlCommand("SELECT * FROM pelanggan WHERE namaPelanggan = @namaPelanggan", db)
            myCommand.Parameters.AddWithValue("@namaPelanggan", namaPelanggan)
            myAdapter = New MySqlDataAdapter(myCommand)
            myDataset = New DataSet

            myAdapter.Fill(myDataset, "noPelanggan")
            myViewTable = myDataset.Tables(0)
            Return (myViewTable)

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        Finally
            tutupDB()

        End Try
    End Function

    Public Sub tambah_menu_pelanggan(ByVal noPelanggan As String, ByVal namaPelanggan As String, ByVal alamatPelanggan As String, ByVal noTelpPelanggan As String, ByVal emailPelanggan As String)
        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "INSERT INTO pelanggan (noPelanggan, namaPelanggan, alamatPelanggan, noTelpPelanggan, emailPelanggan) 
                                    VALUES (@noPelanggan, @namaPelanggan, @alamatPelanggan, @noTelpPelanggan, @emailPelanggan)"
        myCommand.Parameters.AddWithValue("@noPelanggan", noPelanggan)
        myCommand.Parameters.AddWithValue("@namaPelanggan", namaPelanggan)
        myCommand.Parameters.AddWithValue("@alamatPelanggan", alamatPelanggan)
        myCommand.Parameters.AddWithValue("@noTelpPelanggan", noTelpPelanggan)
        myCommand.Parameters.AddWithValue("@emailPelanggan", emailPelanggan)

        Try
            bukaDB()
            myCommand.ExecuteNonQuery()
            MsgBox("Data berhasil di simpan")
            tutupDB()

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal dalam menyimpan data")

        Finally
            tutupDB()

        End Try
    End Sub

    Public Sub hapus_menu_pelanggan(ByVal noPelanggan As String)
        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "DELETE FROM pelanggan WHERE noPelanggan = @noPelanggan"
        myCommand.Parameters.AddWithValue("@noPelanggan", noPelanggan)

        Try
            bukaDB()
            myCommand.ExecuteNonQuery()
            MsgBox("Data berhasil di hapus")
            tutupDB()

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal menghapus data")

        Finally
            tutupDB()

        End Try
    End Sub

    Public Sub bersih_menu_pelanggan()
        With pelanggan
            .txtnopel.Text = ""
            .txtnama.Text = ""
            .txtalamat.Text = ""
            .txttelp.Text = ""
            .txtemail.Text = ""
        End With
    End Sub

    Public Sub ubah_menu_pelanggan(ByVal noPelanggan As String, ByVal namaPelanggan As String, ByVal alamatPelanggan As String, ByVal noTelpPelanggan As String, ByVal emailPelanggan As String)
        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "UPDATE pelanggan SET namaPelanggan = @namaPelanggan, alamatPelanggan = @alamatPelanggan, noTelpPelanggan = @noTelpPelanggan, emailPelanggan = @emailPelanggan WHERE noPelanggan = @noPelanggan"
        myCommand.Parameters.AddWithValue("@noPelanggan", noPelanggan)
        myCommand.Parameters.AddWithValue("@namaPelanggan", namaPelanggan)
        myCommand.Parameters.AddWithValue("@alamatPelanggan", alamatPelanggan)
        myCommand.Parameters.AddWithValue("@noTelpPelanggan", noTelpPelanggan)
        myCommand.Parameters.AddWithValue("@emailPelanggan", emailPelanggan)

        Try
            bukaDB()
            myCommand.ExecuteNonQuery()
            MsgBox("Data berhasil di ubah")
            tutupDB()

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal dalam menyimpan data")

        Finally
            tutupDB()

        End Try
    End Sub
#End Region

#Region "Pinjam"
    Public Function getTabelPinjam() As DataTable
        Dim myDataTable As DataTable

        Try
            bukaDB()
            myCommand = New MySqlCommand("SELECT p.noPeminjaman, a.namaPelanggan, b.merkLaptop, p.lamaMeminjam, p.totalHarga FROM peminjaman p, pelanggan a, laptop b WHERE a.noPelanggan = p.noPelanggan AND b.noLaptop = p.noLaptop ORDER BY p.noPeminjaman", db)
            myAdapter = New MySqlDataAdapter(myCommand)
            myAdapter = New MySqlDataAdapter(myCommand)
            myDataset = New DataSet

            myAdapter.Fill(myDataset, "noPeminjaman")
            myDataTable = myDataset.Tables(0)
            Return (myDataTable)

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        Finally
            tutupDB()

        End Try
    End Function

    Public Function getViewPinjam(ByVal noPeminjaman As String) As DataTable
        Dim myViewTable As DataTable

        Try
            bukaDB()

            myCommand = New MySqlCommand("SELECT p.noPeminjaman, a.namaPelanggan, b.merkLaptop , p.lamaMeminjam, p.totalHarga FROM peminjaman p, pelanggan a, laptop b WHERE b.noLaptop = p.noLaptop AND a.noPelanggan = p.noPelanggan AND noPeminjaman = @noPeminjaman", db)
            myCommand.Parameters.AddWithValue("@noPeminjaman", noPeminjaman)
            myAdapter = New MySqlDataAdapter(myCommand)
            myDataset = New DataSet

            myAdapter.Fill(myDataset, "noPeminjaman")
            myViewTable = myDataset.Tables(0)
            Return (myViewTable)

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        Finally
            tutupDB()

        End Try
    End Function

    Public Sub hapus_menu_pinjam(ByVal noPeminjaman As String)
        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "DELETE FROM peminjaman WHERE noPeminjaman = @noPeminjaman"
        myCommand.Parameters.AddWithValue("@noPeminjaman", noPeminjaman)

        Try
            bukaDB()
            myCommand.ExecuteNonQuery()
            MsgBox("Data berhasil di hapus")
            tutupDB()

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal menghapus data")

        Finally
            tutupDB()

        End Try
    End Sub

    Public Sub bersih_menu_peminjaman()
        With peminjaman
            .txtpinjam.Text = ""
            .txtnopel.Text = ""
            .txtnolaptop.Text = ""
            .txtlamapinjam.Text = ""
        End With
    End Sub

    Public Sub ubah_menu_peminjaman(ByVal noPeminjaman As String, ByVal noPelanggan As String, ByVal noLaptop As String, ByVal lamaMeminjam As String)
        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "UPDATE peminjaman SET  noPelanggan = @noPelanggan, noLaptop = @noLaptop, lamaMeminjam = @lamaMeminjam WHERE noPeminjaman = @noPeminjaman"
        myCommand.Parameters.AddWithValue("@noPeminjaman", noPeminjaman)
        myCommand.Parameters.AddWithValue("@noPelanggan", noPelanggan)
        myCommand.Parameters.AddWithValue("@noLaptop", noLaptop)
        myCommand.Parameters.AddWithValue("@lamaMeminjam", lamaMeminjam)

        Try
            bukaDB()
            myCommand.ExecuteNonQuery()
            MsgBox("Data berhasil di ubah")
            tutupDB()

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal dalam menyimpan data")

        Finally
            tutupDB()

        End Try
    End Sub

    Public Function HitungTotalHarga(ByVal noLaptop As String, ByVal lamaMeminjam As Integer) As Decimal
        Dim hargaSewa As Decimal

        Try
            bukaDB()
            myCommand = New MySqlCommand("SELECT hargaSewa FROM laptop WHERE noLaptop = @noLaptop", db)
            myCommand.Parameters.AddWithValue("@noLaptop", noLaptop)
            myReader = myCommand.ExecuteReader()

            If myReader.Read() Then
                hargaSewa = Convert.ToDecimal(myReader("hargaSewa"))
            Else
                Throw New Exception("Laptop tidak ditemukan")
            End If

            myReader.Close()
            Return hargaSewa * lamaMeminjam

        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0

        Finally
            tutupDB()

        End Try
    End Function
#End Region

End Module

