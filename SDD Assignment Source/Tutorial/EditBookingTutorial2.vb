Public Class EditBookingTutorial2
    Private Sub btnDeleteTutorial_Click(sender As Object, e As EventArgs) Handles btnDeleteTutorial.Click
        Me.Hide()
        EditBookingTutorial.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Tutorial.Show()
    End Sub

    Private Sub btnNavigateTutorial_Click(sender As Object, e As EventArgs) Handles btnNavigateTutorial.Click
        Me.Hide()
        EditBookingTutorial3.Show()
    End Sub
End Class