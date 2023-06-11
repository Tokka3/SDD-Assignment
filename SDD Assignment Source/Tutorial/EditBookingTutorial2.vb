Public Class EditBookingTutorial2
    Private Sub btnDeleteTutorial_Click(sender As Object, e As EventArgs) Handles btnDeleteTutorial.Click
        Me.Hide()
        EditBookingTutorial.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Tutorial.Show()
    End Sub

    Private Sub btnNavigateTutorial_Click(sender As Object, e As EventArgs) Handles btnNavigateTutorial.Click
        Me.Hide()
        EditBookingTutorial3.Show()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub
End Class