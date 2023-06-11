Public Class WelcomeScreen
    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnEditBookings_Click(sender As Object, e As EventArgs) Handles btnEditBookings.Click
        Me.Hide()
        CreateBookings.Show()
        CreateBookings.ColourBookedSeats()
    End Sub


    Private Sub btnViewBooking_Click(sender As Object, e As EventArgs) Handles btnViewInsights.Click
        Me.Hide()
        ViewBookings.Show()
    End Sub

    Private Sub btnViewTutorial_Click(sender As Object, e As EventArgs) Handles btnViewTutorial.Click

        Tutorial.Show()
    End Sub

    Private Sub WelcomeScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateBookingRecordArray()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ExitProgram()
    End Sub
End Class