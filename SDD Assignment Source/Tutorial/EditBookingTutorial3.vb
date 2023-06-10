Public Class EditBookingTutorial3
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Tutorial.Show()
    End Sub

    Private Sub btnTryDelete_Click(sender As Object, e As EventArgs) Handles btnTryDelete.Click
        Me.Hide()
        ViewBookings.Show()
    End Sub

    Private Sub btnEditTutorial_Click(sender As Object, e As EventArgs) Handles btnEditTutorial.Click
        Me.Hide()
        EditBookingTutorial2.Show()
    End Sub

    Private Sub btnDeleteTutorial_Click(sender As Object, e As EventArgs) Handles btnDeleteTutorial.Click
        Me.Hide()
        EditBookingTutorial.Show()
    End Sub
End Class