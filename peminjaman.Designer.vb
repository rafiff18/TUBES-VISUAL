﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        GroupBox1 = New GroupBox()
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
        btnkembali.Location = New Point(612, 210)
        btnkembali.Margin = New Padding(4)
        btnkembali.Name = "btnkembali"
        btnkembali.Size = New Size(159, 36)
        btnkembali.TabIndex = 32
        btnkembali.Text = "Kembali"
        btnkembali.UseVisualStyleBackColor = True
        ' 
        ' btncari
        ' 
        btncari.Location = New Point(278, 210)
        btncari.Margin = New Padding(4)
        btncari.Name = "btncari"
        btncari.Size = New Size(159, 36)
        btncari.TabIndex = 31
        btncari.Text = "Cari"
        btncari.UseVisualStyleBackColor = True
        ' 
        ' btnhapus
        ' 
        btnhapus.Location = New Point(445, 210)
        btnhapus.Margin = New Padding(4)
        btnhapus.Name = "btnhapus"
        btnhapus.Size = New Size(159, 36)
        btnhapus.TabIndex = 30
        btnhapus.Text = "Hapus"
        btnhapus.UseVisualStyleBackColor = True
        ' 
        ' btnedit
        ' 
        btnedit.Location = New Point(111, 210)
        btnedit.Margin = New Padding(4)
        btnedit.Name = "btnedit"
        btnedit.Size = New Size(159, 36)
        btnedit.TabIndex = 29
        btnedit.Text = "Edit"
        btnedit.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtlamapinjam)
        GroupBox1.Controls.Add(txtnolaptop)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(txtnopel)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(txtpinjam)
        GroupBox1.Location = New Point(82, 58)
        GroupBox1.Margin = New Padding(4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4)
        GroupBox1.Size = New Size(888, 131)
        GroupBox1.TabIndex = 27
        GroupBox1.TabStop = False
        GroupBox1.Text = "data Peminjaman"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(457, 83)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(139, 19)
        Label1.TabIndex = 20
        Label1.Text = "Lama Meminjam"
        ' 
        ' txtlamapinjam
        ' 
        txtlamapinjam.Location = New Point(611, 80)
        txtlamapinjam.Margin = New Padding(4)
        txtlamapinjam.Name = "txtlamapinjam"
        txtlamapinjam.Size = New Size(227, 26)
        txtlamapinjam.TabIndex = 19
        ' 
        ' txtnolaptop
        ' 
        txtnolaptop.Location = New Point(611, 41)
        txtnolaptop.Margin = New Padding(4)
        txtnolaptop.Name = "txtnolaptop"
        txtnolaptop.Size = New Size(227, 26)
        txtnolaptop.TabIndex = 18
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(457, 44)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(93, 19)
        Label7.TabIndex = 17
        Label7.Text = "No Laptop"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(52, 83)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(124, 19)
        Label8.TabIndex = 16
        Label8.Text = "No Pelanggan"
        ' 
        ' txtnopel
        ' 
        txtnopel.Location = New Point(218, 80)
        txtnopel.Margin = New Padding(4)
        txtnopel.Name = "txtnopel"
        txtnopel.Size = New Size(227, 26)
        txtnopel.TabIndex = 15
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(52, 45)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(136, 19)
        Label9.TabIndex = 14
        Label9.Text = "No Peminjaman"
        ' 
        ' txtpinjam
        ' 
        txtpinjam.Location = New Point(218, 45)
        txtpinjam.Margin = New Padding(4)
        txtpinjam.Name = "txtpinjam"
        txtpinjam.Size = New Size(227, 26)
        txtpinjam.TabIndex = 13
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(87), CByte(166), CByte(161))
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(82, 271)
        DataGridView1.Margin = New Padding(4)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(888, 180)
        DataGridView1.TabIndex = 26
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Stencil", 12F)
        Button1.Location = New Point(778, 210)
        Button1.Name = "Button1"
        Button1.Size = New Size(159, 36)
        Button1.TabIndex = 33
        Button1.Text = "Clear"
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
        AutoScaleDimensions = New SizeF(10F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(52), CByte(76), CByte(100))
        ClientSize = New Size(1054, 488)
        Controls.Add(Button1)
        Controls.Add(btnkembali)
        Controls.Add(btncari)
        Controls.Add(btnhapus)
        Controls.Add(btnedit)
        Controls.Add(GroupBox1)
        Controls.Add(DataGridView1)
        Font = New Font("Stencil", 12F)
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
    Friend WithEvents GroupBox1 As GroupBox
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
