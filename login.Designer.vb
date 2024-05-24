<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        txtUsername = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        txtPassword = New TextBox()
        btnLogin = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("STFangsong", 15.75F)
        txtUsername.Location = New Point(233, 63)
        txtUsername.Margin = New Padding(4)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(141, 35)
        txtUsername.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("STFangsong", 15.75F)
        Label1.Location = New Point(105, 66)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 23)
        Label1.TabIndex = 1
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("STFangsong", 15.75F)
        Label2.Location = New Point(104, 123)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 23)
        Label2.TabIndex = 3
        Label2.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("STFangsong", 15.75F)
        txtPassword.Location = New Point(233, 120)
        txtPassword.Margin = New Padding(4)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(141, 35)
        txtPassword.TabIndex = 2
        ' 
        ' btnLogin
        ' 
        btnLogin.Font = New Font("STFangsong", 15.75F)
        btnLogin.Location = New Point(119, 185)
        btnLogin.Margin = New Padding(4)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(107, 31)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("STFangsong", 15.75F)
        Button2.Location = New Point(234, 185)
        Button2.Margin = New Padding(4)
        Button2.Name = "Button2"
        Button2.Size = New Size(107, 31)
        Button2.TabIndex = 13
        Button2.Text = "register"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(10F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(87), CByte(123), CByte(141))
        ClientSize = New Size(445, 273)
        Controls.Add(Button2)
        Controls.Add(btnLogin)
        Controls.Add(Label2)
        Controls.Add(txtPassword)
        Controls.Add(Label1)
        Controls.Add(txtUsername)
        Font = New Font("Stencil", 12F)
        Margin = New Padding(4)
        Name = "login"
        Text = "login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Button2 As Button
End Class
