Public Class Tutorial
    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        Me.Hide()
        WelcomeScreen.Show()
    End Sub

    Private Sub btnLearnMoreCreate_Click(sender As Object, e As EventArgs) Handles btnLearnMoreCreate.Click

        CreateBookingTutorial.Show()
    End Sub

    Private Sub btnLearnMoreEdit_Click(sender As Object, e As EventArgs) Handles btnLearnMoreEdit.Click

        EditBookingTutorial.Show()
    End Sub

    Private Sub btnLearnNavigateBookings_Click(sender As Object, e As EventArgs)
        Me.Hide()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub

    Private Sub Tutorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        ExitProgram()
    End Sub
End Class