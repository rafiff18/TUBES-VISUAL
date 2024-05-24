Public Class Form2
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtKeterangan.TextChanged

    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        DataGridView1.DataSource = getViewLaptop(txtMerk.Text)
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        hapus_menu_laptop(txtNoLaptop.Text)
        DataGridView1.DataSource = getTabelLaptop()
    End Sub

    Private Sub btnkembali_Click(sender As Object, e As EventArgs) Handles btnkembali.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bukaDB()
        DataGridView1.DataSource = getTabelLaptop()
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        Try
            tambah_menu_laptop(txtNoLaptop.Text, txtMerk.Text, txtSeries.Text, txtTipe.Text, txtHargaSewa.Text, cbStatus.Text, txtKeterangan.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Isi data dengan benar", MsgBoxStyle.Critical, "Message")
        End Try

        DataGridView1.DataSource = getTabelLaptop()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Try
            ubah_menu_laptop(txtNoLaptop.Text, txtMerk.Text, txtSeries.Text, txtTipe.Text, txtHargaSewa.Text, cbStatus.Text, txtKeterangan.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(ex, MsgBoxStyle.Critical, "Message")
        End Try

        DataGridView1.DataSource = getTabelLaptop()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        txtNoLaptop.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString
        txtMerk.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value.ToString
        txtSeries.Text = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value.ToString
        txtTipe.Text = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value.ToString
        txtKeterangan.Text = DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value.ToString
        txtHargaSewa.Text = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value.ToString
        cbStatus.Text = DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        bersih_menu()
        DataGridView1.DataSource = getTabelLaptop()
    End Sub

    Private Sub cbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStatus.SelectedIndexChanged

    End Sub
End Class