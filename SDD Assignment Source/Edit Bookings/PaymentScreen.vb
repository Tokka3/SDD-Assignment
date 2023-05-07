Public Class PaymentScreen
    Private Sub btnExitButton_Click(sender As Object, e As EventArgs) Handles btnExitButton.Click
        Me.Hide()
        EditBookings.Enabled = True
        EditBookings.Activate()
    End Sub

    Private Sub PaymentScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class