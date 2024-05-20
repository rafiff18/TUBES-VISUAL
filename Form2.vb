Public Class Form2
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtKeterangan.TextChanged

    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        DataGridView1.DataSource = getViewAnggota(txtnonggota.Text)
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        hapus_menu2(txtnoanggota.Text)
        DataGridView1.DataSource = getTabelAnggota()
    End Sub

    Private Sub btnkembali_Click(sender As Object, e As EventArgs) Handles btnkembali.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bukaDB()
        DataGridView1.DataSource = getTabelAnggota()
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        Try
            tambah_menu2(txtnoanggota.Text, txtnama.Text, txtnim.Text, txtalamat.Text, txtkota.Text, txttelepon.Text, txtKeterangan.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Isi data dengan benar", MsgBoxStyle.Critical, "Message")
        End Try

        DataGridView1.DataSource = getTabelAnggota()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Try
            ubah_menu2(txtnoanggota.Text, txtnama.Text, txtnim.Text, txtalamat.Text, txtkota.Text, Integer.Parse(txttelepon.Text), txtKeterangan.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Isi data dengan benar", MsgBoxStyle.Critical, "Message")
        End Try

        DataGridView1.DataSource = getTabelAnggota()
    End Sub
End Class