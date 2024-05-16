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
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        GroupBox1 = New GroupBox()
        TextBox3 = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        TextBox5 = New TextBox()
        Label9 = New Label()
        TextBox6 = New TextBox()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(511, 200)
        Button5.Name = "Button5"
        Button5.Size = New Size(100, 30)
        Button5.TabIndex = 32
        Button5.Text = "Kembali"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(299, 200)
        Button4.Name = "Button4"
        Button4.Size = New Size(100, 30)
        Button4.TabIndex = 31
        Button4.Text = "Cari"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(405, 200)
        Button3.Name = "Button3"
        Button3.Size = New Size(100, 30)
        Button3.TabIndex = 30
        Button3.Text = "Hapus"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(193, 200)
        Button2.Name = "Button2"
        Button2.Size = New Size(100, 30)
        Button2.TabIndex = 29
        Button2.Text = "Edit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(87, 200)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 30)
        Button1.TabIndex = 28
        Button1.Text = "tambah"
        Button1.UseVisualStyleBackColor = True
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
        GroupBox1.Location = New Point(52, 48)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(559, 139)
        GroupBox1.TabIndex = 27
        GroupBox1.TabStop = False
        GroupBox1.Text = "data Peminjaman"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(385, 34)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(145, 23)
        TextBox3.TabIndex = 18
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(301, 37)
        Label7.Name = "Label7"
        Label7.Size = New Size(63, 15)
        Label7.TabIndex = 17
        Label7.Text = "No Laptop"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(33, 69)
        Label8.Name = "Label8"
        Label8.Size = New Size(82, 15)
        Label8.TabIndex = 16
        Label8.Text = "No Pelanggan"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(137, 66)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(145, 23)
        TextBox5.TabIndex = 15
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(33, 37)
        Label9.Name = "Label9"
        Label9.Size = New Size(93, 15)
        Label9.TabIndex = 14
        Label9.Text = "No Peminjaman"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(137, 37)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(145, 23)
        TextBox6.TabIndex = 13
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(52, 245)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(559, 150)
        DataGridView1.TabIndex = 26
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(288, 69)
        Label1.Name = "Label1"
        Label1.Size = New Size(97, 15)
        Label1.TabIndex = 20
        Label1.Text = "Lama Meminjam"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(391, 66)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(145, 23)
        TextBox1.TabIndex = 19
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(190, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 15)
        Label2.TabIndex = 21
        Label2.Text = "Total Harga :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(269, 106)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 22
        Label3.Text = "Label3"
        ' 
        ' peminjaman
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(664, 450)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(GroupBox1)
        Controls.Add(DataGridView1)
        Name = "peminjaman"
        Text = "peminjaman"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
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
