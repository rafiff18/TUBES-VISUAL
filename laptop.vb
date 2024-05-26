﻿Public Class pelanggan
    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        DataGridView1.DataSource = getViewPelanggan(txtnama.Text)
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        hapus_menu_pelanggan(txtnopel.Text)
        DataGridView1.DataSource = getTabelPelanggan()
    End Sub

    Private Sub btnkembali_Click(sender As Object, e As EventArgs) Handles btnkembali.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bukaDB()
        DataGridView1.DataSource = getTabelPelanggan()
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        Try
            tambah_menu_pelanggan(txtnopel.Text, txtnama.Text, txtalamat.Text, txttelp.Text, txtemail.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Isi data dengan benar", MsgBoxStyle.Critical, "Message")
        End Try

        DataGridView1.DataSource = getTabelPelanggan()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Try
            ubah_menu_pelanggan(txtnopel.Text, txtnama.Text, txtalamat.Text, txttelp.Text, txtemail.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(ex, MsgBoxStyle.Critical, "Message")
        End Try

        DataGridView1.DataSource = getTabelPelanggan()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        txtnopel.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString
        txtnama.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value.ToString
        txtalamat.Text = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value.ToString
        txttelp.Text = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value.ToString
        txtemail.Text = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        bersih_menu_pelanggan()
        DataGridView1.DataSource = getTabelPelanggan()
    End Sub

End Class