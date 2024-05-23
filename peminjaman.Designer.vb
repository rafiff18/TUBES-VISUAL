<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class peminjaman
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnkembali = New Button()
        btncari = New Button()
        btnhapus = New Button()
        btnedit = New Button()
        btntambah = New Button()
        GroupBox1 = New GroupBox()
        lblHarga = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtlamapinjam = New TextBox()
        txtnolaptop = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        txtnopel = New TextBox()
        Label9 = New Label()
        txtpinjam = New TextBox()
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnkembali
        ' 
        btnkembali.Location = New Point(730, 253)
        btnkembali.Margin = New Padding(4)
        btnkembali.Name = "btnkembali"
        btnkembali.Size = New Size(143, 38)
        btnkembali.TabIndex = 32
        btnkembali.Text = "Kembali"
        btnkembali.UseVisualStyleBackColor = True
        ' 
        ' btncari
        ' 
        btncari.Location = New Point(427, 253)
        btncari.Margin = New Padding(4)
        btncari.Name = "btncari"
        btncari.Size = New Size(143, 38)
        btncari.TabIndex = 31
        btncari.Text = "Cari"
        btncari.UseVisualStyleBackColor = True
        ' 
        ' btnhapus
        ' 
        btnhapus.Location = New Point(579, 253)
        btnhapus.Margin = New Padding(4)
        btnhapus.Name = "btnhapus"
        btnhapus.Size = New Size(143, 38)
        btnhapus.TabIndex = 30
        btnhapus.Text = "Hapus"
        btnhapus.UseVisualStyleBackColor = True
        ' 
        ' btnedit
        ' 
        btnedit.Location = New Point(276, 253)
        btnedit.Margin = New Padding(4)
        btnedit.Name = "btnedit"
        btnedit.Size = New Size(143, 38)
        btnedit.TabIndex = 29
        btnedit.Text = "Edit"
        btnedit.UseVisualStyleBackColor = True
        ' 
        ' btntambah
        ' 
        btntambah.Location = New Point(124, 253)
        btntambah.Margin = New Padding(4)
        btntambah.Name = "btntambah"
        btntambah.Size = New Size(143, 38)
        btntambah.TabIndex = 28
        btntambah.Text = "tambah"
        btntambah.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lblHarga)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtlamapinjam)
        GroupBox1.Controls.Add(txtnolaptop)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(txtnopel)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(txtpinjam)
        GroupBox1.Location = New Point(74, 61)
        GroupBox1.Margin = New Padding(4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4)
        GroupBox1.Size = New Size(799, 176)
        GroupBox1.TabIndex = 27
        GroupBox1.TabStop = False
        GroupBox1.Text = "data Peminjaman"
        ' 
        ' lblHarga
        ' 
        lblHarga.AutoSize = True
        lblHarga.Location = New Point(403, 134)
        lblHarga.Margin = New Padding(4, 0, 4, 0)
        lblHarga.Name = "lblHarga"
        lblHarga.Size = New Size(57, 20)
        lblHarga.TabIndex = 22
        lblHarga.Text = "Label3"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(271, 134)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 20)
        Label2.TabIndex = 21
        Label2.Text = "Total Harga :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(411, 87)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(125, 20)
        Label1.TabIndex = 20
        Label1.Text = "Lama Meminjam"
        ' 
        ' txtlamapinjam
        ' 
        txtlamapinjam.Location = New Point(559, 84)
        txtlamapinjam.Margin = New Padding(4)
        txtlamapinjam.Name = "txtlamapinjam"
        txtlamapinjam.Size = New Size(205, 26)
        txtlamapinjam.TabIndex = 19
        ' 
        ' txtnolaptop
        ' 
        txtnolaptop.Location = New Point(550, 43)
        txtnolaptop.Margin = New Padding(4)
        txtnolaptop.Name = "txtnolaptop"
        txtnolaptop.Size = New Size(205, 26)
        txtnolaptop.TabIndex = 18
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(430, 47)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(83, 20)
        Label7.TabIndex = 17
        Label7.Text = "No Laptop"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(47, 87)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(109, 20)
        Label8.TabIndex = 16
        Label8.Text = "No Pelanggan"
        ' 
        ' txtnopel
        ' 
        txtnopel.Location = New Point(196, 84)
        txtnopel.Margin = New Padding(4)
        txtnopel.Name = "txtnopel"
        txtnopel.Size = New Size(205, 26)
        txtnopel.TabIndex = 15
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(47, 47)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(120, 20)
        Label9.TabIndex = 14
        Label9.Text = "No Peminjaman"
        ' 
        ' txtpinjam
        ' 
        txtpinjam.Location = New Point(196, 47)
        txtpinjam.Margin = New Padding(4)
        txtpinjam.Name = "txtpinjam"
        txtpinjam.Size = New Size(205, 26)
        txtpinjam.TabIndex = 13
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(74, 310)
        DataGridView1.Margin = New Padding(4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(799, 190)
        DataGridView1.TabIndex = 26
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(707, 524)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 33
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' peminjaman
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(52), CByte(76), CByte(100))
        ClientSize = New Size(949, 570)
        Controls.Add(Button1)
        Controls.Add(btnkembali)
        Controls.Add(btncari)
        Controls.Add(btnhapus)
        Controls.Add(btnedit)
        Controls.Add(btntambah)
        Controls.Add(GroupBox1)
        Controls.Add(DataGridView1)
        Font = New Font("Microsoft Sans Serif", 12F)
        ForeColor = Color.FromArgb(CByte(87), CByte(166), CByte(161))
        Margin = New Padding(4)
        Name = "peminjaman"
        Text = "peminjaman"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnkembali As Button
    Friend WithEvents btncari As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btntambah As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblHarga As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtlamapinjam As TextBox
    Friend WithEvents txtnolaptop As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtnopel As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtpinjam As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
End Class
