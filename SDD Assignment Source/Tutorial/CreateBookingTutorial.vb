Public Class CreateBookingTutorial
    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Tutorial.Show()
    End Sub

    Private Sub btnTryNow_Click(sender As Object, e As EventArgs) Handles btnTryNow.Click
        Me.Hide()
        CreateBookings.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub
End Class