Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "zidan" And txtPassword.Text = "037" Then
            Form2.Show()
            Me.Hide()
        Else
            MessageBox.Show("Login gagal!")
        End If
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
