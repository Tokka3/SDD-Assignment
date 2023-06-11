Public Class PaymentScreen
    Private Sub btnExitButton_Click(sender As Object, e As EventArgs) Handles btnExitButton.Click
        Me.Hide()
        CreateBookings.Enabled = True
        CreateBookings.Activate()
    End Sub

    Sub InitialiseTextBoxes()
        txtFirstname.Text = strFirstName
        txtLastname.Text = strLastName
        txtCCNo.Focus()
    End Sub
    Private Sub PaymentScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        MessageBox.Show("Thanks " & strFirstName & ", you're booking is complete")
        Me.Hide()
        intBookingCount += 1
        Dim Booking As Object = BookingRecord(intBookingCount)


        MessageBox.Show("Seat Cost: " & Booking.intTotal.ToString())
        Booking.strBookingFirstName = txtFirstname.Text
        Booking.strBookingLastName = txtLastName.Text
        Booking.intBookingID = intBookingCount
        Booking.strDOB = CreateBookings.txtDOB.Text
        Booking.arrSeatsBooked = selectedSeats
        Booking.intTotal = CalculateTotalSeatCost(Booking.arrSeatsBooked)
        Booking.strFilm = strSelectedFilm

        Dim strField As String = "" 'Prepare string so we can write to file
        strField &= (Booking.intBookingID.ToString() & "-")
        strField &= (Booking.intTotal.ToString() & "-")
        strField &= (Booking.strBookingFirstName & "-")
        strField &= (Booking.strBookingLastName & "-")
        strField &= (Booking.strDOB & "-")
        strField &= (Join(Booking.arrSeatsBooked, ",") & "-")
        strField &= (Booking.strFilm)

        MessageBox.Show(strField)

        Dim writeFile As System.IO.StreamWriter 'Open stream to file
        writeFile = System.IO.File.AppendText("Bookings.txt")

        writeFile.WriteLine(strField)

        writeFile.Close()



        Array.Clear(selectedSeats, 0, selectedSeats.Length)
        ReDim selectedSeats(0 To -1)
        CreateBookings.Enabled = True
        CreateBookings.txtFirstName.Clear()
        CreateBookings.txtLastName.Clear()
        CreateBookings.rtbSelectedSeats.Clear()
        CreateBookings.txtDOB.Clear()
        CreateBookings.Activate()
        CreateBookings.PaymentSuccess()

        UpdateBookingRecordArray()
    End Sub

    Private Sub btnExitButton_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtCCNo_TextChanged(sender As Object, e As EventArgs) Handles txtCCNo.TextChanged

    End Sub
End Class