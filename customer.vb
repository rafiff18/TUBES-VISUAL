Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient

Public Class customer

    Private connectionString As String = "server=localhost;user id=root;password=;database=rentallaptop;"
    Private selectedLaptopId As String = String.Empty
    Private namaPelanggan As String = String.Empty ' Menambahkan variabel namaPelanggan
    Public noPelanggan As String ' Akan diatur saat login

    Private Sub CustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load laptops into DataGridView
        LoadLaptops()
    End Sub
    Public Sub RefreshDataGridView()
        LoadLaptops()
    End Sub

    ' Mengambil status laptop dari database
    Private Function GetLaptopStatus(laptopId As String) As String
        Dim status As String = ""

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT statusLaptop FROM laptop WHERE noLaptop=@noLaptop"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@noLaptop", laptopId)
                    status = Convert.ToString(cmd.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

        Return status
    End Function

    Private Function GetNamaPelanggan(noPelanggan As String) As String
        Dim namaPelanggan As String = ""

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT namaPelanggan FROM pelanggan WHERE noPelanggan=@noPelanggan"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@noPelanggan", noPelanggan)
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        namaPelanggan = Convert.ToString(result)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

        Return namaPelanggan
    End Function

    Private Sub LoadLaptops()
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT noLaptop, merkLaptop, seriLaptop, tipeLaptop, hargaSewa, statusLaptop, keteranganLaptop FROM laptop ORDER BY merkLaptop, seriLaptop, tipeLaptop"
                Using cmd As New MySqlCommand(query, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        dgvLaptops.DataSource = table
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvLaptops_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLaptops.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dgvLaptops.Rows(e.RowIndex)
            selectedLaptopId = selectedRow.Cells("noLaptop").Value.ToString()
            MessageBox.Show($"Pilihan anda: {selectedRow.Cells("merkLaptop").Value} {selectedRow.Cells("seriLaptop").Value} {selectedRow.Cells("tipeLaptop").Value}")
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If String.IsNullOrEmpty(selectedLaptopId) Then
            MsgBox("Klik 2x pada tabel untuk memilih.")
            Return
        End If

        Dim duration As String = numDuration.Value.ToString()

        ' Mendapatkan nama pelanggan
        namaPelanggan = GetNamaPelanggan(noPelanggan)

        ' Calculate total price
        Dim totalPrice As Decimal = CalculateTotalPrice(selectedLaptopId, duration)

        ' Process the borrowing (e.g., save to database, show confirmation, etc.)
        ProcessBorrowing(selectedLaptopId, duration, totalPrice, namaPelanggan)

        ' Memperbarui status langsung di DataGridView
        UpdateDataGridViewStatus(selectedLaptopId)

        ' Memanggil fungsi untuk memperbarui status laptop menjadi "Dipinjam"
        UpdateStatusLaptopDipinjam(selectedLaptopId)
        ShowNota()
    End Sub

    Private Sub ShowNota()
        Try
            ' Persiapkan isi nota
            Dim notaContent As String =
            $"Rental Laptop Bang Joy
             (Laptop Gaming Harga Miring)
             Jl. Mulawarman Sel. Dalam I, Kramas, Kec. Tembalang, Kota Semarang
             ===========================================================
             
             Detail Peminjaman:
             Nama Pelanggan: {namaPelanggan}
             No Pelanggan: {noPelanggan}
             No Laptop: {selectedLaptopId}
             Lama Meminjam: {numDuration.Value} hari
             Total Harga: {CalculateTotalPrice(selectedLaptopId, numDuration.Value.ToString())}
             
             =========================================================
             Terima kasih sudah meminjam.
             * Jangan lupa dikembalikan"

            ' Tampilkan nota menggunakan PrintPreviewDialog
            Dim printPreview As New PrintPreviewDialog()
            Dim notaDocument As New Printing.PrintDocument()
            notaDocument.DocumentName = "Nota Peminjaman"

            AddHandler notaDocument.PrintPage, Sub(sender As Object, e As Printing.PrintPageEventArgs)
                                                   ' Hitung lebar dan tinggi area cetak
                                                   Dim printAreaWidth As Integer = e.MarginBounds.Width
                                                   Dim printAreaHeight As Integer = e.MarginBounds.Height

                                                   ' Tentukan font untuk teks
                                                   Dim fontNota As New Font("Times New Roman", 16)

                                                   ' Persiapkan posisi awal teks
                                                   Dim xPos As Single = e.MarginBounds.Left
                                                   Dim yPos As Single = e.MarginBounds.Top

                                                   ' Gambar teks ke area cetak
                                                   e.Graphics.DrawString(notaContent, fontNota, Brushes.Black, xPos, yPos)

                                                   ' Hitung tinggi teks yang telah digambar
                                                   Dim textHeight As Single = e.Graphics.MeasureString(notaContent, fontNota, printAreaWidth).Height

                                                   ' Cek apakah ada teks yang masih harus digambar
                                                   If textHeight < printAreaHeight Then
                                                       e.HasMorePages = False ' Semua teks telah digambar
                                                   Else
                                                       e.HasMorePages = True ' Ada teks yang masih harus digambar di halaman berikutnya
                                                   End If
                                               End Sub

            printPreview.Document = notaDocument
            printPreview.ShowDialog()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub



    Private Function CalculateTotalPrice(laptopId As String, duration As String) As Decimal
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT hargaSewa FROM laptop WHERE noLaptop=@noLaptop"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@noLaptop", laptopId)
                    Dim hargaSewa As Decimal = Convert.ToDecimal(cmd.ExecuteScalar())
                    Return hargaSewa * Convert.ToDecimal(duration)
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            Return 0
        End Try
    End Function

    Private Sub ProcessBorrowing(laptopId As String, duration As String, totalPrice As Decimal, namaPelanggan As String)
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "INSERT INTO peminjaman (noPeminjaman, noPelanggan, noLaptop, lamaMeminjam, totalHarga) VALUES (@noPeminjaman, @noPelanggan, @noLaptop, @lamaMeminjam, @totalHarga)"
                Using cmd As New MySqlCommand(query, conn)
                    Dim noPeminjaman As String = Guid.NewGuid().ToString().Substring(0, 3) ' Generate a unique identifier
                    cmd.Parameters.AddWithValue("@noPeminjaman", noPeminjaman)
                    cmd.Parameters.AddWithValue("@noPelanggan", noPelanggan)
                    cmd.Parameters.AddWithValue("@noLaptop", laptopId)
                    cmd.Parameters.AddWithValue("@lamaMeminjam", duration)
                    cmd.Parameters.AddWithValue("@totalHarga", totalPrice)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MsgBox("Borrowing successfully processed!")
            ' Panggil fungsi cetak nota
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub UpdateStatusLaptopDipinjam(laptopId As String)
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "UPDATE laptop SET statusLaptop='Dipinjam' WHERE noLaptop=@noLaptop"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@noLaptop", laptopId)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub customer_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        login.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        login.Show()
    End Sub
    Private Sub UpdateDataGridViewStatus(selectedLaptopId As String)
        For Each row As DataGridViewRow In dgvLaptops.Rows
            If row.Cells("noLaptop").Value.ToString() = selectedLaptopId Then
                ' Mengambil nilai status dari database
                Dim status As String = GetLaptopStatus(selectedLaptopId)

                ' Ubah nilai status menjadi "Dipinjam" jika sebelumnya tersedia
                If status = "Tersedia" Then
                    row.Cells("statusLaptop").Value = "Dipinjam"
                End If
                Exit For
            End If
        Next
    End Sub
End Class
