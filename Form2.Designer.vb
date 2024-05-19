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
        TextBox4 = New TextBox()
        ComboBox1 = New ComboBox()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label6 = New Label()
        TextBox3 = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        TextBox5 = New TextBox()
        Label9 = New Label()
        TextBox6 = New TextBox()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        Label3 = New Label()
        btnkembali = New Button()
        btncari = New Button()
        btnhapus = New Button()
        btnedit = New Button()
        btntambah = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(373, 122)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(68, 19)
        Label4.TabIndex = 6
        Label4.Text = "Status"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(87), CByte(123), CByte(141))
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.GridColor = Color.FromArgb(CByte(87), CByte(166), CByte(161))
        DataGridView1.Location = New Point(43, 318)
        DataGridView1.Margin = New Padding(4, 4, 4, 4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(747, 190)
        DataGridView1.TabIndex = 8
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(TextBox5)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(TextBox6)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Location = New Point(43, 23)
        GroupBox1.Margin = New Padding(4, 4, 4, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 4, 4, 4)
        GroupBox1.Size = New Size(747, 220)
        GroupBox1.TabIndex = 11
        GroupBox1.TabStop = False
        GroupBox1.Text = "data laptop"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(477, 81)
        TextBox4.Margin = New Padding(4, 4, 4, 4)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(188, 26)
        TextBox4.TabIndex = 25
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Tersedia", "Dipinjam"})
        ComboBox1.Location = New Point(477, 118)
        ComboBox1.Margin = New Padding(4, 4, 4, 4)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(188, 27)
        ComboBox1.TabIndex = 24
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(370, 87)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 19)
        Label2.TabIndex = 13
        Label2.Text = "Harga Sewa"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(477, 41)
        TextBox2.Margin = New Padding(4, 4, 4, 4)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(188, 26)
        TextBox2.TabIndex = 22
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(373, 44)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 19)
        Label1.TabIndex = 21
        Label1.Text = "Keterangan"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(180, 160)
        TextBox1.Margin = New Padding(4, 4, 4, 4)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(141, 26)
        TextBox1.TabIndex = 20
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(120, 160)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(44, 19)
        Label6.TabIndex = 19
        Label6.Text = "tipe"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(180, 114)
        TextBox3.Margin = New Padding(4, 4, 4, 4)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(141, 26)
        TextBox3.TabIndex = 18
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(107, 114)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(62, 19)
        Label7.TabIndex = 17
        Label7.Text = "series"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(101, 81)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(63, 19)
        Label8.TabIndex = 16
        Label8.Text = "Merek"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(180, 77)
        TextBox5.Margin = New Padding(4, 4, 4, 4)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(141, 26)
        TextBox5.TabIndex = 15
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(76, 41)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(93, 19)
        Label9.TabIndex = 14
        Label9.Text = "no laptop"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(180, 41)
        TextBox6.Margin = New Padding(4, 4, 4, 4)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(141, 26)
        TextBox6.TabIndex = 13
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
        Label3.Size = New Size(59, 19)
        Label3.TabIndex = 18
        Label3.Text = "anjay"
        ' 
        ' btnkembali
        ' 
        btnkembali.Location = New Point(647, 266)
        btnkembali.Margin = New Padding(4, 4, 4, 4)
        btnkembali.Name = "btnkembali"
        btnkembali.Size = New Size(143, 38)
        btnkembali.TabIndex = 37
        btnkembali.Text = "Kembali"
        btnkembali.UseVisualStyleBackColor = True
        ' 
        ' btncari
        ' 
        btncari.Location = New Point(344, 266)
        btncari.Margin = New Padding(4, 4, 4, 4)
        btncari.Name = "btncari"
        btncari.Size = New Size(143, 38)
        btncari.TabIndex = 36
        btncari.Text = "Cari"
        btncari.UseVisualStyleBackColor = True
        ' 
        ' btnhapus
        ' 
        btnhapus.Location = New Point(496, 266)
        btnhapus.Margin = New Padding(4, 4, 4, 4)
        btnhapus.Name = "btnhapus"
        btnhapus.Size = New Size(143, 38)
        btnhapus.TabIndex = 35
        btnhapus.Text = "Hapus"
        btnhapus.UseVisualStyleBackColor = True
        ' 
        ' btnedit
        ' 
        btnedit.Location = New Point(193, 266)
        btnedit.Margin = New Padding(4, 4, 4, 4)
        btnedit.Name = "btnedit"
        btnedit.Size = New Size(143, 38)
        btnedit.TabIndex = 34
        btnedit.Text = "Edit"
        btnedit.UseVisualStyleBackColor = True
        ' 
        ' btntambah
        ' 
        btntambah.Location = New Point(41, 266)
        btntambah.Margin = New Padding(4, 4, 4, 4)
        btntambah.Name = "btntambah"
        btntambah.Size = New Size(143, 38)
        btntambah.TabIndex = 33
        btntambah.Text = "tambah"
        btntambah.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(52), CByte(76), CByte(100))
        ClientSize = New Size(833, 570)
        Controls.Add(btnkembali)
        Controls.Add(btncari)
        Controls.Add(btnhapus)
        Controls.Add(btnedit)
        Controls.Add(btntambah)
        Controls.Add(Label3)
        Controls.Add(GroupBox1)
        Controls.Add(DataGridView1)
        Font = New Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.FromArgb(CByte(87), CByte(166), CByte(161))
        Margin = New Padding(4, 4, 4, 4)
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
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label3 As Label
    Friend WithEvents btnkembali As Button
    Friend WithEvents btncari As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btntambah As Button
End Class
