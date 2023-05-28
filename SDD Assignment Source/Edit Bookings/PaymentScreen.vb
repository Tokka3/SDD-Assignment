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
        Dim Booking As Object = BookingRecord(intBookingCount)
        Booking.intTotal = selectedSeats.Length * 20
        Booking.strBookingFirstName = txtFirstname.Text
        Booking.strBookingLastName = txtLastName.Text
        Booking.intBookingID = intBookingCount
        Booking.arrSeatsBooked = selectedSeats

        Dim strField As String = ""
        strField &= (Booking.intBookingID.ToString() & "-")
        strField &= (Booking.intTotal.ToString() & "-")
        strField &= (Booking.strBookingFirstName & "-")
        strField &= (Booking.strBookingLastName & "-")

        strField &= (Join(Booking.arrSeatsBooked, ","))

        MessageBox.Show(strField)

        Dim writeFile As System.IO.StreamWriter 'Open stream to file
        writeFile = System.IO.File.AppendText("Bookings.txt")

        writeFile.WriteLine(strField)

        writeFile.Close()

        intBookingCount += 1

        Array.Clear(selectedSeats, 0, selectedSeats.Length)
        ReDim selectedSeats(0 To -1)
        EditBookings.Enabled = True
        EditBookings.Activate()
        EditBookings.PaymentSuccess()

    End Sub
End Class