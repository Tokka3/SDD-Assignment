﻿Public Class WelcomeScreen
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnEditBookings_Click(sender As Object, e As EventArgs) Handles btnEditBookings.Click
        Me.Hide()
        EditBookings.Show()
    End Sub


    Private Sub btnViewBooking_Click(sender As Object, e As EventArgs) Handles btnViewBooking.Click
        Me.Hide()
        ViewBookings.Show()
    End Sub

    Private Sub btnViewTutorial_Click(sender As Object, e As EventArgs) Handles btnViewTutorial.Click
        Me.Hide()
        Tutorial.Show()
    End Sub
End Class