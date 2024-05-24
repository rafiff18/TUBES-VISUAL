<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Stencil", 15.75F)
        Button1.ForeColor = Color.FromArgb(CByte(87), CByte(166), CByte(161))
        Button1.Location = New Point(114, 59)
        Button1.Margin = New Padding(4)
        Button1.Name = "Button1"
        Button1.Size = New Size(269, 29)
        Button1.TabIndex = 0
        Button1.Text = "Data pelanggan"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Stencil", 15.75F)
        Button2.ForeColor = Color.FromArgb(CByte(87), CByte(166), CByte(161))
        Button2.Location = New Point(112, 96)
        Button2.Margin = New Padding(4)
        Button2.Name = "Button2"
        Button2.Size = New Size(270, 29)
        Button2.TabIndex = 1
        Button2.Text = "data laptop"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Stencil", 15.75F)
        Button3.ForeColor = Color.FromArgb(CByte(87), CByte(166), CByte(161))
        Button3.Location = New Point(114, 132)
        Button3.Margin = New Padding(4)
        Button3.Name = "Button3"
        Button3.Size = New Size(269, 29)
        Button3.TabIndex = 2
        Button3.Text = "data peminjaman"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Stencil", 15.75F)
        Label1.ForeColor = Color.FromArgb(CByte(87), CByte(166), CByte(161))
        Label1.Location = New Point(170, 21)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(169, 25)
        Label1.TabIndex = 3
        Label1.Text = "Rental Laptop"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.laptop
        PictureBox1.Location = New Point(390, 156)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(95, 96)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.laptop
        PictureBox2.Location = New Point(12, 156)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(95, 96)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(52), CByte(76), CByte(100))
        ClientSize = New Size(497, 255)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Font = New Font("Stencil", 12F)
        ForeColor = Color.DarkSlateGray
        Margin = New Padding(4)
        Name = "Form1"
        Text = "menu utama Admin"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox

End Class
