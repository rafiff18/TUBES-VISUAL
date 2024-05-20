Public Class peminjaman
    Private Sub peminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bukaDB()
        DataGridView1.DataSource = getTabelPinjam()
    End Sub
    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        DataGridView1.DataSource = getViewPinjam(txtpinjam.Text)
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        hapus_menu_pinjam(txtpinjam.Text)
        DataGridView1.DataSource = getTabelPinjam()
    End Sub

    Private Sub btnkembali_Click(sender As Object, e As EventArgs) Handles btnkembali.Click
        Me.Close()
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        Try
            tambah_menu_pinjam(txtpinjam.Text, txtnopel.Text, txtnolaptop.Text, txtlamapinjam.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Isi data dengan benar", MsgBoxStyle.Critical, "Message")
        End Try

        DataGridView1.DataSource = getTabelPinjam()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Try
            ubah_menu_peminjaman(txtpinjam.Text, txtnopel.Text, txtnolaptop.Text, txtlamapinjam.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(ex, MsgBoxStyle.Critical, "Message")
        End Try

        DataGridView1.DataSource = getTabelPinjam()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        txtpinjam.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString
        txtnopel.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value.ToString
        txtnolaptop.Text = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value.ToString
        txtlamapinjam.Text = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        bersih_menu_peminjaman()
        DataGridView1.DataSource = getTabelPinjam()
    End Sub
End Class