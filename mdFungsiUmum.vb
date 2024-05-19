Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Module mdFungsiUmum
    Public str As String = "server=localhost;user id=root;password=;database=rentallaptop;"
    Public db As New MySqlConnection(str)
    Public myCommand As MySqlCommand
    Public myAdapter As MySqlDataAdapter
    Public myDataset As DataSet
    Public myReader As MySqlDataReader

#Region "Database"
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

    Public Function getViewTable(ByVal noLaptop As String) As DataTable
        Dim myViewTable As DataTable

        Try
            bukaDB()
            myCommand = New MySqlCommand("SELECT * FROM laptop WHERE noLaptop = @noLaptop", db)
            myCommand.Parameters.AddWithValue("@noLaptop", noLaptop)
            myAdapter = New MySqlDataAdapter(myCommand)
            myDataset = New DataSet

            myAdapter.Fill(myDataset, "noLaptop")
            myViewTable = myDataset.Tables(0)
            Return (myViewTable)

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        Finally
            tutupDB()

        End Try
    End Function

    Public Sub tambah_menu(ByVal laptop As String, ByVal noLaptop As String, ByVal merkLaptop As String, ByVal seriLaptop As String, ByVal tipeLaptop As String, ByVal hargaSewa As String, ByVal statusLaptop As String, ByVal keteranganLaptop As String)
        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "INSERT INTO buku (noLaptop, merkLaptop, seriLaptop, tipeLaptop, hargaSewa, statusLaptop, keteranganLaptop) VALUES (@noLaptop, @merkLaptop, @, @seriLaptop, @tipeLaptop, @hargaSewa, @statusLaptop, @keteranganLaptop)"
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

    Public Sub hapus_menu(ByVal noLaptop As String)
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

    Public Sub ubah_menu(ByVal laptop As String, ByVal noLaptop As String, ByVal merkLaptop As String, ByVal seriLaptop As String, ByVal tipeLaptop As String, ByVal hargaSewa As String, ByVal statusLaptop As String, ByVal keteranganLaptop As String)
        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "UPDATE laptop SET merkLaptop = @merkLaptop, seriLaptop = @seriLaptop, tipeLaptop = @tipeLaptop, hargaSewa = @hargaSewa, statusLaptop = @statusLaptop WHERE noLaptop = @noLaptop"
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

#Region "Anggota"
    Public Function getTabelAnggota() As DataTable
        Dim myDataTable As DataTable

        Try
            bukaDB()
            myCommand = New MySqlCommand("SELECT * FROM anggota ORDER BY noanggota", db)
            myAdapter = New MySqlDataAdapter(myCommand)
            myDataset = New DataSet

            myAdapter.Fill(myDataset, "noanggota")
            myDataTable = myDataset.Tables(0)
            Return (myDataTable)

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        Finally
            tutupDB()

        End Try
    End Function

    Public Function getViewAnggota(ByVal nama As String) As DataTable
        Dim myViewTable As DataTable

        Try
            bukaDB()
            myCommand = New MySqlCommand("SELECT * FROM anggota WHERE nama = @nama", db)
            myCommand.Parameters.AddWithValue("@nama", nama)
            myAdapter = New MySqlDataAdapter(myCommand)
            myDataset = New DataSet

            myAdapter.Fill(myDataset, "noanggota")
            myViewTable = myDataset.Tables(0)
            Return (myViewTable)

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        Finally
            tutupDB()

        End Try
    End Function

    Public Sub tambah_menu2(ByVal nama As String, ByVal nim As String, ByVal alamat As String, ByVal kota As String, ByVal telepon As String, ByVal keterangan As String)
        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "INSERT INTO anggota (nama, nim, alamat, kota, telepon, keterangan) VALUES (@nama, @nim, @alamat, @kota, @telepon, @keterangan)"
        myCommand.Parameters.AddWithValue("@nama", nama)
        myCommand.Parameters.AddWithValue("@nim", nim)
        myCommand.Parameters.AddWithValue("@alamat", alamat)
        myCommand.Parameters.AddWithValue("@kota", kota)
        myCommand.Parameters.AddWithValue("@telepon", telepon)
        myCommand.Parameters.AddWithValue("@keterangan", keterangan)

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

    Public Sub hapus_menu2(ByVal nama As String)
        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "DELETE FROM anggota WHERE nama = @nama"
        myCommand.Parameters.AddWithValue("@nama", nama)

        Try
            bukaDB()
            myCommand.ExecuteNonQuery()
            MsgBox("Data berhasil di hapus")
            bersih_menu2()
            tutupDB()

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal menghapus data")

        Finally
            tutupDB()

        End Try
    End Sub

    Public Sub bersih_menu2()
        'With laptop
        '.LabelAnggota.Text = "0"
        '.txtNama.Text = ""
        '.txtNim.Text = ""
        '.txtAlamat.Text = ""
        '.txtKota.Text = ""
        '.txtTelepon.Text = ""
        '.txtKeterangan.Text = ""
        'End With
    End Sub

    Public Sub ubah_menu2(ByVal noanggota As Integer, ByVal nama As String, ByVal nim As String, ByVal alamat As String, ByVal kota As String, ByVal telepon As String, ByVal keterangan As String)
        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "UPDATE anggota SET nama = @nama, nim = @nim, alamat = @alamat, kota = @kota, telepon = @telepon, keterangan = @keterangan WHERE noanggota = @noanggota"
        myCommand.Parameters.AddWithValue("@noanggota", noanggota)
        myCommand.Parameters.AddWithValue("@nama", nama)
        myCommand.Parameters.AddWithValue("@nim", nim)
        myCommand.Parameters.AddWithValue("@alamat", alamat)
        myCommand.Parameters.AddWithValue("@kota", kota)
        myCommand.Parameters.AddWithValue("@telepon", telepon)
        myCommand.Parameters.AddWithValue("@keterangan", keterangan)

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
            myCommand = New MySqlCommand("SELECT p.notransaksi, a.nama, b.judul, p.tanggalpinjam FROM peminjaman p, anggota a, buku b WHERE a.noanggota = p.noanggota AND b.nobuku = p.nobuku ORDER BY notransaksi", db)
            myAdapter = New MySqlDataAdapter(myCommand)
            myDataset = New DataSet

            myAdapter.Fill(myDataset, "notransaksi")
            myDataTable = myDataset.Tables(0)
            Return (myDataTable)

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        Finally
            tutupDB()

        End Try
    End Function

    Public Function getViewPinjam(ByVal notransaksi As String) As DataTable
        Dim myViewTable As DataTable

        Try
            bukaDB()

            myCommand = New MySqlCommand("p.notransaksi, a.nama, b.nama, p.tanggalpinjam, p.keterangan FROM peminjaman p, anggota a, buku b WHERE b.nobuku = p.nobuku AND a.noanggota = p.noanggota AND notransaksi = @notransaksi", db)
            myCommand.Parameters.AddWithValue("@notransaksi", notransaksi)
            myAdapter = New MySqlDataAdapter(myCommand)
            myDataset = New DataSet

            myAdapter.Fill(myDataset, "notransaksi")
            myViewTable = myDataset.Tables(0)
            Return (myViewTable)

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        Finally
            tutupDB()

        End Try
    End Function

    Public Sub tambah_menu3(ByVal notransaksi As String, ByVal noanggota As String, ByVal nobuku As String, ByVal tanggalpinjam As Date)
        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "INSERT INTO peminjaman (notransaksi, noanggota, nobuku, tanggalpinjam) VALUES (@notransaksi, @noanggota, @nobuku, @tanggalpinjam)"
        myCommand.Parameters.AddWithValue("@notransaksi", notransaksi)
        myCommand.Parameters.AddWithValue("@noanggota", noanggota)
        myCommand.Parameters.AddWithValue("@tanggalpinjam", tanggalpinjam)
        myCommand.Parameters.AddWithValue("@nobuku", nobuku)

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

    Public Sub hapus_menu3(ByVal notransaksi As String)
        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "DELETE FROM peminjaman WHERE notransaksi = @notransaksi"
        myCommand.Parameters.AddWithValue("@notransaksi", notransaksi)

        Try
            bukaDB()
            myCommand.ExecuteNonQuery()
            MsgBox("Data berhasil di hapus")
            bersih_menu2()
            tutupDB()

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal menghapus data")

        Finally
            tutupDB()

        End Try
    End Sub

    Public Sub bersih_menu3()
        'With MPinjam
        '.txt'NoTransaksi.Text = ""
        '.tx'tAnggota.Text = ""
        '.txt'Buku.Text = ""
        'End With
    End Sub

    Public Sub ubah_menu3(ByVal notransaksi As String, ByVal noanggota As String, ByVal nobuku As String, ByVal tanggalpinjam As Date)
        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "UPDATE peminjaman SET noanggota = @noanggota, nobuku = @nobuku, tanggalpinjam = @tanggalpinjam WHERE notransaksi = @notransaksi"
        myCommand.Parameters.AddWithValue("@notransaksi", notransaksi)
        myCommand.Parameters.AddWithValue("@noanggota", noanggota)
        myCommand.Parameters.AddWithValue("@tanggalpinjam", tanggalpinjam)
        myCommand.Parameters.AddWithValue("@nobuku", nobuku)

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

End Module

