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
        ComboBox1 = New ComboBox()
        TextBox4 = New TextBox()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Label3 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(261, 96)
        Label4.Name = "Label4"
        Label4.Size = New Size(39, 15)
        Label4.TabIndex = 6
        Label4.Text = "Status"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(30, 251)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(523, 150)
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
        GroupBox1.Location = New Point(30, 18)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(523, 174)
        GroupBox1.TabIndex = 11
        GroupBox1.TabStop = False
        GroupBox1.Text = "data laptop"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(259, 69)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 15)
        Label2.TabIndex = 13
        Label2.Text = "Harga Sewa"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(334, 32)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(133, 23)
        TextBox2.TabIndex = 22
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(261, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 15)
        Label1.TabIndex = 21
        Label1.Text = "Keterangan"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(126, 126)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 20
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(84, 126)
        Label6.Name = "Label6"
        Label6.Size = New Size(27, 15)
        Label6.TabIndex = 19
        Label6.Text = "tipe"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(126, 90)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 18
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(75, 90)
        Label7.Name = "Label7"
        Label7.Size = New Size(36, 15)
        Label7.TabIndex = 17
        Label7.Text = "series"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(71, 64)
        Label8.Name = "Label8"
        Label8.Size = New Size(40, 15)
        Label8.TabIndex = 16
        Label8.Text = "Merek"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(126, 61)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 15
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(53, 32)
        Label9.Name = "Label9"
        Label9.Size = New Size(58, 15)
        Label9.TabIndex = 14
        Label9.Text = "no laptop"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(126, 32)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(100, 23)
        TextBox6.TabIndex = 13
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Tersedia", "Dipinjam"})
        ComboBox1.Location = New Point(334, 93)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(133, 23)
        ComboBox1.TabIndex = 24
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(334, 64)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(133, 23)
        TextBox4.TabIndex = 25
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(29, 203)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 30)
        Button1.TabIndex = 13
        Button1.Text = "tambah"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(135, 203)
        Button2.Name = "Button2"
        Button2.Size = New Size(100, 30)
        Button2.TabIndex = 14
        Button2.Text = "Edit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(347, 203)
        Button3.Name = "Button3"
        Button3.Size = New Size(100, 30)
        Button3.TabIndex = 15
        Button3.Text = "Hapus"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(241, 203)
        Button4.Name = "Button4"
        Button4.Size = New Size(100, 30)
        Button4.TabIndex = 16
        Button4.Text = "Cari"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(453, 203)
        Button5.Name = "Button5"
        Button5.Size = New Size(100, 30)
        Button5.TabIndex = 17
        Button5.Text = "Kembali"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(248, 422)
        Label3.Name = "Label3"
        Label3.Size = New Size(35, 15)
        Label3.TabIndex = 18
        Label3.Text = "anjay"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(583, 450)
        Controls.Add(Label3)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(GroupBox1)
        Controls.Add(DataGridView1)
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label3 As Label
End Class
