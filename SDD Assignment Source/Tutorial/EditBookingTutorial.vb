Public Class EditBookingTutorial
    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Tutorial.Show()
    End Sub

    Private Sub btnEditTutorial_Click(sender As Object, e As EventArgs) Handles btnEditTutorial.Click
        Me.Hide()
        EditBookingTutorial2.Show()
    End Sub

    Private Sub btnTryDelete_Click(sender As Object, e As EventArgs) Handles btnTryDelete.Click
        Me.Hide()
        ViewBookings.Show()
    End Sub

    Private Sub btnNavigateTutorial_Click(sender As Object, e As EventArgs) Handles btnNavigateTutorial.Click
        Me.Hide()
        EditBookingTutorial3.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub
End Class