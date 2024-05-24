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
        Label4.Location = New Point(408, 73)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(68, 19)
        Label4.TabIndex = 6
        Label4.Text = "Status"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(87), CByte(166), CByte(161))
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.GridColor = Color.FromArgb(CByte(87), CByte(166), CByte(161))
        DataGridView1.Location = New Point(48, 302)
        DataGridView1.Margin = New Padding(4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(830, 180)
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
        GroupBox1.Location = New Point(48, 22)
        GroupBox1.Margin = New Padding(4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4)
        GroupBox1.Size = New Size(830, 209)
        GroupBox1.TabIndex = 11
        GroupBox1.TabStop = False
        GroupBox1.Text = "data laptop"
        ' 
        ' txtHargaSewa
        ' 
        txtHargaSewa.Location = New Point(523, 34)
        txtHargaSewa.Margin = New Padding(4)
        txtHargaSewa.Name = "txtHargaSewa"
        txtHargaSewa.Size = New Size(208, 26)
        txtHargaSewa.TabIndex = 25
        ' 
        ' cbStatus
        ' 
        cbStatus.FormattingEnabled = True
        cbStatus.Items.AddRange(New Object() {"Tersedia", "Dipinjam"})
        cbStatus.Location = New Point(523, 69)
        cbStatus.Margin = New Padding(4)
        cbStatus.Name = "cbStatus"
        cbStatus.Size = New Size(208, 27)
        cbStatus.TabIndex = 24
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(404, 40)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 19)
        Label2.TabIndex = 13
        Label2.Text = "Harga Sewa"
        ' 
        ' txtKeterangan
        ' 
        txtKeterangan.Location = New Point(523, 104)
        txtKeterangan.Margin = New Padding(4)
        txtKeterangan.Name = "txtKeterangan"
        txtKeterangan.Size = New Size(208, 26)
        txtKeterangan.TabIndex = 22
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(408, 106)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 19)
        Label1.TabIndex = 21
        Label1.Text = "Keterangan"
        ' 
        ' txtTipe
        ' 
        txtTipe.Location = New Point(200, 152)
        txtTipe.Margin = New Padding(4)
        txtTipe.Name = "txtTipe"
        txtTipe.Size = New Size(156, 26)
        txtTipe.TabIndex = 20
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(133, 152)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(44, 19)
        Label6.TabIndex = 19
        Label6.Text = "tipe"
        ' 
        ' txtSeries
        ' 
        txtSeries.Location = New Point(200, 108)
        txtSeries.Margin = New Padding(4)
        txtSeries.Name = "txtSeries"
        txtSeries.Size = New Size(156, 26)
        txtSeries.TabIndex = 18
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(119, 108)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(62, 19)
        Label7.TabIndex = 17
        Label7.Text = "series"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(112, 77)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(63, 19)
        Label8.TabIndex = 16
        Label8.Text = "Merek"
        ' 
        ' txtMerk
        ' 
        txtMerk.Location = New Point(200, 73)
        txtMerk.Margin = New Padding(4)
        txtMerk.Name = "txtMerk"
        txtMerk.Size = New Size(156, 26)
        txtMerk.TabIndex = 15
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(84, 39)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(93, 19)
        Label9.TabIndex = 14
        Label9.Text = "no laptop"
        ' 
        ' txtNoLaptop
        ' 
        txtNoLaptop.Location = New Point(200, 39)
        txtNoLaptop.Margin = New Padding(4)
        txtNoLaptop.Name = "txtNoLaptop"
        txtNoLaptop.Size = New Size(156, 26)
        txtNoLaptop.TabIndex = 13
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' btnkembali
        ' 
        btnkembali.Location = New Point(719, 253)
        btnkembali.Margin = New Padding(4)
        btnkembali.Name = "btnkembali"
        btnkembali.Size = New Size(159, 36)
        btnkembali.TabIndex = 37
        btnkembali.Text = "Kembali"
        btnkembali.UseVisualStyleBackColor = True
        ' 
        ' btncari
        ' 
        btncari.Location = New Point(382, 253)
        btncari.Margin = New Padding(4)
        btncari.Name = "btncari"
        btncari.Size = New Size(159, 36)
        btncari.TabIndex = 36
        btncari.Text = "Cari"
        btncari.UseVisualStyleBackColor = True
        ' 
        ' btnhapus
        ' 
        btnhapus.Location = New Point(551, 253)
        btnhapus.Margin = New Padding(4)
        btnhapus.Name = "btnhapus"
        btnhapus.Size = New Size(159, 36)
        btnhapus.TabIndex = 35
        btnhapus.Text = "Hapus"
        btnhapus.UseVisualStyleBackColor = True
        ' 
        ' btnedit
        ' 
        btnedit.Location = New Point(214, 253)
        btnedit.Margin = New Padding(4)
        btnedit.Name = "btnedit"
        btnedit.Size = New Size(159, 36)
        btnedit.TabIndex = 34
        btnedit.Text = "Edit"
        btnedit.UseVisualStyleBackColor = True
        ' 
        ' btntambah
        ' 
        btntambah.Location = New Point(46, 253)
        btntambah.Margin = New Padding(4)
        btntambah.Name = "btntambah"
        btntambah.Size = New Size(159, 36)
        btntambah.TabIndex = 33
        btntambah.Text = "tambah"
        btntambah.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(772, 489)
        Button1.Name = "Button1"
        Button1.Size = New Size(106, 33)
        Button1.TabIndex = 38
        Button1.Text = "Clear"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(52), CByte(76), CByte(100))
        ClientSize = New Size(926, 542)
        Controls.Add(Button1)
        Controls.Add(btnkembali)
        Controls.Add(btncari)
        Controls.Add(btnhapus)
        Controls.Add(btnedit)
        Controls.Add(btntambah)
        Controls.Add(GroupBox1)
        Controls.Add(DataGridView1)
        Font = New Font("Stencil", 12F)
        ForeColor = Color.FromArgb(CByte(87), CByte(166), CByte(161))
        Margin = New Padding(4)
        Name = "Form2"
        Text = "Form data laptop"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
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
    Friend WithEvents btnkembali As Button
    Friend WithEvents btncari As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btntambah As Button
    Friend WithEvents Button1 As Button
End Class
