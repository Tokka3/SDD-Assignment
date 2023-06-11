Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Me.Hide()
        WelcomeScreen.Show()
    End Sub

    Private Sub iconEye_Click(sender As Object, e As EventArgs) Handles iconEye.Click
        'MessageBox.Show(iconEye.IconChar)
        '943, 344
        If iconEye.IconChar.ToString = "EyeSlash" Then
            txtPassword.PasswordChar = ""
            'Set icon to visible eye
            iconEye.IconChar = iconEye.IconChar.Eye
            iconEye.IconSize = 32
            Dim pPos As Point
            pPos.X = 944
            pPos.Y = 344

            iconEye.Location = pPos
        Else

            txtPassword.PasswordChar = "●"
            'Set icon to eye slash
            iconEye.IconChar = iconEye.IconChar.EyeSlash
            iconEye.IconSize = 34
            Dim pPos As Point
            pPos.X = 943
            pPos.Y = 344
            iconEye.Location = pPos
        End If
    End Sub



    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ExitProgram()
    End Sub
End Class
