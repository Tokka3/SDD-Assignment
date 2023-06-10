Public Class EditBookingTutorial
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Tutorial.Show()
    End Sub

    Private Sub btnEditTutorial_Click(sender As Object, e As EventArgs) Handles btnEditTutorial.Click
        Me.Hide()
        EditBookingTutorial2.Show()
    End Sub
End Class