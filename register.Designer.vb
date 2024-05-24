<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register
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
        btnreg = New Button()
        Label2 = New Label()
        regPass = New TextBox()
        Label1 = New Label()
        regUser = New TextBox()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' btnreg
        ' 
        btnreg.Font = New Font("STHupo", 15.7499981F)
        btnreg.Location = New Point(123, 132)
        btnreg.Margin = New Padding(4)
        btnreg.Name = "btnreg"
        btnreg.Size = New Size(139, 28)
        btnreg.TabIndex = 11
        btnreg.Text = "register"
        btnreg.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("STHupo", 15.7499981F)
        Label2.Location = New Point(82, 98)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 22)
        Label2.TabIndex = 9
        Label2.Text = "Password"
        ' 
        ' regPass
        ' 
        regPass.Font = New Font("STKaiti", 15.75F)
        regPass.Location = New Point(198, 89)
        regPass.Margin = New Padding(4)
        regPass.Name = "regPass"
        regPass.PasswordChar = "*"c
        regPass.Size = New Size(127, 35)
        regPass.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("STHupo", 15.7499981F)
        Label1.Location = New Point(82, 47)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 22)
        Label1.TabIndex = 7
        Label1.Text = "Username"
        ' 
        ' regUser
        ' 
        regUser.Font = New Font("STKaiti", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        regUser.Location = New Point(198, 44)
        regUser.Margin = New Padding(4)
        regUser.Name = "regUser"
        regUser.Size = New Size(127, 35)
        regUser.TabIndex = 6
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("STHupo", 15.7499981F)
        Button2.Location = New Point(286, 187)
        Button2.Margin = New Padding(4)
        Button2.Name = "Button2"
        Button2.Size = New Size(96, 28)
        Button2.TabIndex = 12
        Button2.Text = "back"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' register
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(395, 228)
        Controls.Add(Button2)
        Controls.Add(btnreg)
        Controls.Add(Label2)
        Controls.Add(regPass)
        Controls.Add(Label1)
        Controls.Add(regUser)
        Name = "register"
        Text = "register"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnreg As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents regPass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents regUser As TextBox
    Friend WithEvents Button2 As Button
End Class
