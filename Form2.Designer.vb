<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        components = New ComponentModel.Container()
        Label4 = New Label()
        DataGridView1 = New DataGridView()
        GroupBox1 = New GroupBox()
        txtHargaSewa = New TextBox()
        cbStatus = New ComboBox()
        Label2 = New Label()
        txtKeterangan = New TextBox()
        Label1 = New Label()
        txtTipe = New TextBox()
        Label6 = New Label()
        txtSeries = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        txtMerk = New TextBox()
        Label9 = New Label()
        txtNoLaptop = New TextBox()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        Label3 = New Label()
        btnkembali = New Button()
        btncari = New Button()
        btnhapus = New Button()
        btnedit = New Button()
        btntambah = New Button()
        Button1 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(367, 77)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 20)
        Label4.TabIndex = 6
        Label4.Text = "Status"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(87), CByte(123), CByte(141))
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.GridColor = Color.FromArgb(CByte(87), CByte(166), CByte(161))
        DataGridView1.Location = New Point(43, 318)
        DataGridView1.Margin = New Padding(4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(747, 190)
        DataGridView1.TabIndex = 8
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtHargaSewa)
        GroupBox1.Controls.Add(cbStatus)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(txtKeterangan)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtTipe)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(txtSeries)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(txtMerk)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(txtNoLaptop)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Location = New Point(43, 23)
        GroupBox1.Margin = New Padding(4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4)
        GroupBox1.Size = New Size(747, 220)
        GroupBox1.TabIndex = 11
        GroupBox1.TabStop = False
        GroupBox1.Text = "data laptop"
        ' 
        ' txtHargaSewa
        ' 
        txtHargaSewa.Location = New Point(471, 36)
        txtHargaSewa.Margin = New Padding(4)
        txtHargaSewa.Name = "txtHargaSewa"
        txtHargaSewa.Size = New Size(188, 26)
        txtHargaSewa.TabIndex = 25
        ' 
        ' cbStatus
        ' 
        cbStatus.FormattingEnabled = True
        cbStatus.Items.AddRange(New Object() {"Tersedia", "Dipinjam"})
        cbStatus.Location = New Point(471, 73)
        cbStatus.Margin = New Padding(4)
        cbStatus.Name = "cbStatus"
        cbStatus.Size = New Size(188, 28)
        cbStatus.TabIndex = 24
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(364, 42)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 20)
        Label2.TabIndex = 13
        Label2.Text = "Harga Sewa"
        ' 
        ' txtKeterangan
        ' 
        txtKeterangan.Location = New Point(471, 109)
        txtKeterangan.Margin = New Padding(4)
        txtKeterangan.Name = "txtKeterangan"
        txtKeterangan.Size = New Size(188, 26)
        txtKeterangan.TabIndex = 22
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(367, 112)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 20)
        Label1.TabIndex = 21
        Label1.Text = "Keterangan"
        ' 
        ' txtTipe
        ' 
        txtTipe.Location = New Point(180, 160)
        txtTipe.Margin = New Padding(4)
        txtTipe.Name = "txtTipe"
        txtTipe.Size = New Size(141, 26)
        txtTipe.TabIndex = 20
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(120, 160)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(35, 20)
        Label6.TabIndex = 19
        Label6.Text = "tipe"
        ' 
        ' txtSeries
        ' 
        txtSeries.Location = New Point(180, 114)
        txtSeries.Margin = New Padding(4)
        txtSeries.Name = "txtSeries"
        txtSeries.Size = New Size(141, 26)
        txtSeries.TabIndex = 18
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(107, 114)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(51, 20)
        Label7.TabIndex = 17
        Label7.Text = "series"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(101, 81)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(53, 20)
        Label8.TabIndex = 16
        Label8.Text = "Merek"
        ' 
        ' txtMerk
        ' 
        txtMerk.Location = New Point(180, 77)
        txtMerk.Margin = New Padding(4)
        txtMerk.Name = "txtMerk"
        txtMerk.Size = New Size(141, 26)
        txtMerk.TabIndex = 15
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(76, 41)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(75, 20)
        Label9.TabIndex = 14
        Label9.Text = "no laptop"
        ' 
        ' txtNoLaptop
        ' 
        txtNoLaptop.Location = New Point(180, 41)
        txtNoLaptop.Margin = New Padding(4)
        txtNoLaptop.Name = "txtNoLaptop"
        txtNoLaptop.Size = New Size(141, 26)
        txtNoLaptop.TabIndex = 13
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(354, 535)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 20)
        Label3.TabIndex = 18
        Label3.Text = "anjay"
        ' 
        ' btnkembali
        ' 
        btnkembali.Location = New Point(647, 266)
        btnkembali.Margin = New Padding(4)
        btnkembali.Name = "btnkembali"
        btnkembali.Size = New Size(143, 38)
        btnkembali.TabIndex = 37
        btnkembali.Text = "Kembali"
        btnkembali.UseVisualStyleBackColor = True
        ' 
        ' btncari
        ' 
        btncari.Location = New Point(344, 266)
        btncari.Margin = New Padding(4)
        btncari.Name = "btncari"
        btncari.Size = New Size(143, 38)
        btncari.TabIndex = 36
        btncari.Text = "Cari"
        btncari.UseVisualStyleBackColor = True
        ' 
        ' btnhapus
        ' 
        btnhapus.Location = New Point(496, 266)
        btnhapus.Margin = New Padding(4)
        btnhapus.Name = "btnhapus"
        btnhapus.Size = New Size(143, 38)
        btnhapus.TabIndex = 35
        btnhapus.Text = "Hapus"
        btnhapus.UseVisualStyleBackColor = True
        ' 
        ' btnedit
        ' 
        btnedit.Location = New Point(193, 266)
        btnedit.Margin = New Padding(4)
        btnedit.Name = "btnedit"
        btnedit.Size = New Size(143, 38)
        btnedit.TabIndex = 34
        btnedit.Text = "Edit"
        btnedit.UseVisualStyleBackColor = True
        ' 
        ' btntambah
        ' 
        btntambah.Location = New Point(41, 266)
        btntambah.Margin = New Padding(4)
        btntambah.Name = "btntambah"
        btntambah.Size = New Size(143, 38)
        btntambah.TabIndex = 33
        btntambah.Text = "tambah"
        btntambah.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(544, 523)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 38
        Button1.Text = "hps"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(52), CByte(76), CByte(100))
        ClientSize = New Size(833, 570)
        Controls.Add(Button1)
        Controls.Add(btnkembali)
        Controls.Add(btncari)
        Controls.Add(btnhapus)
        Controls.Add(btnedit)
        Controls.Add(btntambah)
        Controls.Add(Label3)
        Controls.Add(GroupBox1)
        Controls.Add(DataGridView1)
        Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.FromArgb(CByte(87), CByte(166), CByte(161))
        Margin = New Padding(4)
        Name = "Form2"
        Text = "Form2"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTipe As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSeries As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtMerk As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNoLaptop As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHargaSewa As TextBox
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label3 As Label
    Friend WithEvents btnkembali As Button
    Friend WithEvents btncari As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btntambah As Button
    Friend WithEvents Button1 As Button
End Class
