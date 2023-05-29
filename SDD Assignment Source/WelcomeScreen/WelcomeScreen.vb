Public Class WelcomeScreen
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnEditBookings_Click(sender As Object, e As EventArgs) Handles btnEditBookings.Click
        Me.Hide()
        EditBookings.Show()
        EditBookings.ColourBookedSeats()
    End Sub


    Private Sub btnViewBooking_Click(sender As Object, e As EventArgs) Handles btnViewInsights.Click
        Me.Hide()
        ViewBookings.Show()
    End Sub

    Private Sub btnViewTutorial_Click(sender As Object, e As EventArgs) Handles btnViewTutorial.Click
        Me.Hide()
        Tutorial.Show()
    End Sub

    Private Sub WelcomeScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateBookingRecordArray()
    End Sub
End Class