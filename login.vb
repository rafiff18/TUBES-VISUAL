Public Class login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim role As String = AuthenticateUser(txtUsername.Text, txtPassword.Text)
        If role <> "" Then
            If role = "customer" Then
                MessageBox.Show("Costumer login berhasil")
            ElseIf role = "admin" Then
                MessageBox.Show("Admin login berhasil")
                Me.Close()
                Dim Form1 As New Form1()
                Form1.Show()
                Form1.Focus()
            End If
        Else
            MessageBox.Show("Username atau Password salah")
        End If
    End Sub
End Class