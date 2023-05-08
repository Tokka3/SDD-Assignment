Public Class PaymentScreen
    Private Sub btnExitButton_Click(sender As Object, e As EventArgs) Handles btnExitButton.Click
        Me.Hide()
        EditBookings.Enabled = True
        EditBookings.Activate()
    End Sub

    Private Sub PaymentScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFirstname.Text = strFirstName
        txtLastName.Text = strLastName
        txtCCNo.Focus()
    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        MessageBox.Show("Thanks " & strFirstName & ", you're booking is complete")
        Me.Hide()
        EditBookings.Enabled = True
        EditBookings.Activate()
    End Sub
End Class