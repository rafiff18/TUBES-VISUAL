Imports MySql.Data.MySqlClient

Public Class customer

    Private connectionString As String = "server=localhost;user id=root;password=;database=rentallaptop;"
    Private selectedLaptopId As String = String.Empty
    Public noPelanggan As String ' Akan diatur saat login

    Private Sub CustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load laptops into DataGridView
        LoadLaptops()
    End Sub

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
            MessageBox.Show($"Selected Laptop: {selectedRow.Cells("merkLaptop").Value} {selectedRow.Cells("seriLaptop").Value} {selectedRow.Cells("tipeLaptop").Value}")
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If String.IsNullOrEmpty(selectedLaptopId) Then
            MsgBox("Please select a laptop by double-clicking a row in the table.")
            Return
        End If

        Dim duration As String = numDuration.Value.ToString()

        ' Calculate total price
        Dim totalPrice As Decimal = CalculateTotalPrice(selectedLaptopId, duration)

        ' Process the borrowing (e.g., save to database, show confirmation, etc.)
        ProcessBorrowing(selectedLaptopId, duration, totalPrice)
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

    Private Sub ProcessBorrowing(laptopId As String, duration As String, totalPrice As Decimal)
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
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub customer_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        login.Show()
    End Sub
End Class