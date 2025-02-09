Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = TxtUsername.Text
        Dim password As String = TxtPassword.Text


        If username = "admin" And password = "password123" Then
            Main.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
