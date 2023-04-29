Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Me.Hide()
        WelcomeScreen.Show()
    End Sub

    Private Sub iconEye_Click(sender As Object, e As EventArgs) Handles iconEye.Click
        'MessageBox.Show(iconEye.IconChar)
        If iconEye.IconChar.ToString = "EyeSlash" Then
            txtPassword.PasswordChar = ""
            'Set icon to visible eye
            iconEye.IconChar = iconEye.IconChar.Eye
            iconEye.IconSize = 32
            Dim pPos As Point
            pPos.X = 471
            pPos.Y = 291

            iconEye.Location = pPos
        Else

            txtPassword.PasswordChar = "●"
            'Set icon to eye slash
            iconEye.IconChar = iconEye.IconChar.EyeSlash
            iconEye.IconSize = 34
            Dim pPos As Point
            pPos.X = 470
            pPos.Y = 291
            iconEye.Location = pPos
        End If
    End Sub



    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub
End Class
