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
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TextBox1 = New TextBox()
        TextBox3 = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        TextBox5 = New TextBox()
        Label9 = New Label()
        TextBox6 = New TextBox()
        DataGridView1 = New DataGridView()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnkembali
        ' 
        btnkembali.Location = New Point(730, 253)
        btnkembali.Margin = New Padding(4, 4, 4, 4)
        btnkembali.Name = "btnkembali"
        btnkembali.Size = New Size(143, 38)
        btnkembali.TabIndex = 32
        btnkembali.Text = "Kembali"
        btnkembali.UseVisualStyleBackColor = True
        ' 
        ' btncari
        ' 
        btncari.Location = New Point(427, 253)
        btncari.Margin = New Padding(4, 4, 4, 4)
        btncari.Name = "btncari"
        btncari.Size = New Size(143, 38)
        btncari.TabIndex = 31
        btncari.Text = "Cari"
        btncari.UseVisualStyleBackColor = True
        ' 
        ' btnhapus
        ' 
        btnhapus.Location = New Point(579, 253)
        btnhapus.Margin = New Padding(4, 4, 4, 4)
        btnhapus.Name = "btnhapus"
        btnhapus.Size = New Size(143, 38)
        btnhapus.TabIndex = 30
        btnhapus.Text = "Hapus"
        btnhapus.UseVisualStyleBackColor = True
        ' 
        ' btnedit
        ' 
        btnedit.Location = New Point(276, 253)
        btnedit.Margin = New Padding(4, 4, 4, 4)
        btnedit.Name = "btnedit"
        btnedit.Size = New Size(143, 38)
        btnedit.TabIndex = 29
        btnedit.Text = "Edit"
        btnedit.UseVisualStyleBackColor = True
        ' 
        ' btntambah
        ' 
        btntambah.Location = New Point(124, 253)
        btntambah.Margin = New Padding(4, 4, 4, 4)
        btntambah.Name = "btntambah"
        btntambah.Size = New Size(143, 38)
        btntambah.TabIndex = 28
        btntambah.Text = "tambah"
        btntambah.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(TextBox5)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(TextBox6)
        GroupBox1.Location = New Point(74, 61)
        GroupBox1.Margin = New Padding(4, 4, 4, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 4, 4, 4)
        GroupBox1.Size = New Size(799, 176)
        GroupBox1.TabIndex = 27
        GroupBox1.TabStop = False
        GroupBox1.Text = "data Peminjaman"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(384, 134)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 19)
        Label3.TabIndex = 22
        Label3.Text = "Label3"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(271, 134)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(124, 19)
        Label2.TabIndex = 21
        Label2.Text = "Total Harga :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(411, 87)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(139, 19)
        Label1.TabIndex = 20
        Label1.Text = "Lama Meminjam"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(559, 84)
        TextBox1.Margin = New Padding(4, 4, 4, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(205, 26)
        TextBox1.TabIndex = 19
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(550, 43)
        TextBox3.Margin = New Padding(4, 4, 4, 4)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(205, 26)
        TextBox3.TabIndex = 18
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(430, 47)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(93, 19)
        Label7.TabIndex = 17
        Label7.Text = "No Laptop"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(47, 87)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(124, 19)
        Label8.TabIndex = 16
        Label8.Text = "No Pelanggan"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(196, 84)
        TextBox5.Margin = New Padding(4, 4, 4, 4)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(205, 26)
        TextBox5.TabIndex = 15
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(47, 47)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(136, 19)
        Label9.TabIndex = 14
        Label9.Text = "No Peminjaman"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(196, 47)
        TextBox6.Margin = New Padding(4, 4, 4, 4)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(205, 26)
        TextBox6.TabIndex = 13
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(74, 310)
        DataGridView1.Margin = New Padding(4, 4, 4, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(799, 190)
        DataGridView1.TabIndex = 26
        ' 
        ' peminjaman
        ' 
        AutoScaleDimensions = New SizeF(10F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(52), CByte(76), CByte(100))
        ClientSize = New Size(949, 570)
        Controls.Add(btnkembali)
        Controls.Add(btncari)
        Controls.Add(btnhapus)
        Controls.Add(btnedit)
        Controls.Add(btntambah)
        Controls.Add(GroupBox1)
        Controls.Add(DataGridView1)
        Font = New Font("Stencil", 12F)
        ForeColor = Color.FromArgb(CByte(87), CByte(166), CByte(161))
        Margin = New Padding(4, 4, 4, 4)
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
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
