<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pelanggan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label3 = New Label()
        GroupBox1 = New GroupBox()
        txtemail = New TextBox()
        Label1 = New Label()
        txttelp = New TextBox()
        Label6 = New Label()
        txtalamat = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        txtnama = New TextBox()
        Label9 = New Label()
        txtnopel = New TextBox()
        DataGridView1 = New DataGridView()
        btnkembali = New Button()
        btncari = New Button()
        btnhapus = New Button()
        btnedit = New Button()
        btntambah = New Button()
        Button1 = New Button()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(510, 532)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 19)
        Label3.TabIndex = 26
        Label3.Text = "anjay"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtemail)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txttelp)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(txtalamat)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(txtnama)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(txtnopel)
        GroupBox1.Location = New Point(67, 20)
        GroupBox1.Margin = New Padding(4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4)
        GroupBox1.Size = New Size(747, 176)
        GroupBox1.TabIndex = 20
        GroupBox1.TabStop = False
        GroupBox1.Text = "data Pelanggan"
        ' 
        ' txtemail
        ' 
        txtemail.Location = New Point(496, 81)
        txtemail.Margin = New Padding(4)
        txtemail.Name = "txtemail"
        txtemail.Size = New Size(205, 26)
        txtemail.TabIndex = 22
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(421, 81)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 19)
        Label1.TabIndex = 21
        Label1.Text = "Email"
        ' 
        ' txttelp
        ' 
        txttelp.Location = New Point(496, 41)
        txttelp.Margin = New Padding(4)
        txttelp.Name = "txttelp"
        txttelp.Size = New Size(205, 26)
        txttelp.TabIndex = 20
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(406, 41)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(72, 19)
        Label6.TabIndex = 19
        Label6.Text = "No Telp"
        ' 
        ' txtalamat
        ' 
        txtalamat.Location = New Point(194, 114)
        txtalamat.Margin = New Padding(4)
        txtalamat.Name = "txtalamat"
        txtalamat.Size = New Size(205, 26)
        txtalamat.TabIndex = 18
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(46, 114)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(71, 19)
        Label7.TabIndex = 17
        Label7.Text = "Alamat"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(46, 81)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(147, 19)
        Label8.TabIndex = 16
        Label8.Text = "Nama Pelanggan"
        ' 
        ' txtnama
        ' 
        txtnama.Location = New Point(194, 77)
        txtnama.Margin = New Padding(4)
        txtnama.Name = "txtnama"
        txtnama.Size = New Size(205, 26)
        txtnama.TabIndex = 15
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(46, 41)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(119, 19)
        Label9.TabIndex = 14
        Label9.Text = "ID Pelanggan"
        ' 
        ' txtnopel
        ' 
        txtnopel.Location = New Point(194, 41)
        txtnopel.Margin = New Padding(4)
        txtnopel.Name = "txtnopel"
        txtnopel.Size = New Size(205, 26)
        txtnopel.TabIndex = 13
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(87), CByte(166), CByte(161))
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(67, 274)
        DataGridView1.Margin = New Padding(4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(747, 190)
        DataGridView1.TabIndex = 19
        ' 
        ' btnkembali
        ' 
        btnkembali.Location = New Point(673, 215)
        btnkembali.Margin = New Padding(4)
        btnkembali.Name = "btnkembali"
        btnkembali.Size = New Size(143, 38)
        btnkembali.TabIndex = 37
        btnkembali.Text = "Kembali"
        btnkembali.UseVisualStyleBackColor = True
        ' 
        ' btncari
        ' 
        btncari.Location = New Point(370, 215)
        btncari.Margin = New Padding(4)
        btncari.Name = "btncari"
        btncari.Size = New Size(143, 38)
        btncari.TabIndex = 36
        btncari.Text = "Cari"
        btncari.UseVisualStyleBackColor = True
        ' 
        ' btnhapus
        ' 
        btnhapus.Location = New Point(521, 215)
        btnhapus.Margin = New Padding(4)
        btnhapus.Name = "btnhapus"
        btnhapus.Size = New Size(143, 38)
        btnhapus.TabIndex = 35
        btnhapus.Text = "Hapus"
        btnhapus.UseVisualStyleBackColor = True
        ' 
        ' btnedit
        ' 
        btnedit.Location = New Point(219, 215)
        btnedit.Margin = New Padding(4)
        btnedit.Name = "btnedit"
        btnedit.Size = New Size(143, 38)
        btnedit.TabIndex = 34
        btnedit.Text = "Edit"
        btnedit.UseVisualStyleBackColor = True
        ' 
        ' btntambah
        ' 
        btntambah.Location = New Point(67, 215)
        btntambah.Margin = New Padding(4)
        btntambah.Name = "btntambah"
        btntambah.Size = New Size(143, 38)
        btntambah.TabIndex = 33
        btntambah.Text = "tambah"
        btntambah.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(719, 466)
        Button1.Name = "Button1"
        Button1.Size = New Size(95, 33)
        Button1.TabIndex = 38
        Button1.Text = "Clear"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' pelanggan
        ' 
        AutoScaleDimensions = New SizeF(10F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(52), CByte(76), CByte(100))
        ClientSize = New Size(887, 524)
        Controls.Add(Button1)
        Controls.Add(btnkembali)
        Controls.Add(btncari)
        Controls.Add(btnhapus)
        Controls.Add(btnedit)
        Controls.Add(btntambah)
        Controls.Add(Label3)
        Controls.Add(GroupBox1)
        Controls.Add(DataGridView1)
        Font = New Font("Stencil", 12F)
        ForeColor = Color.FromArgb(CByte(87), CByte(166), CByte(161))
        Margin = New Padding(4)
        Name = "pelanggan"
        Text = "pelanggan"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txttelp As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtalamat As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtnama As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtnopel As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnkembali As Button
    Friend WithEvents btncari As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btntambah As Button
    Friend WithEvents Button1 As Button
End Class
