Public Class EditBooking
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ViewBookings.Hide()

        CreateBookings.cbxMovieSelection.Text = cbxMovieSelection.Text
        CreateBookings.Show()
        CreateBookings.Refresh()
        CreateBookings.EditBookingRequest()
        CreateBookings.lblEditMode.Visible = True
        CreateBookings.gbCreateBooking.Visible = False
        bEditMode = True
    End Sub

    Private Sub EditBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnConfirmEdit_Click(sender As Object, e As EventArgs) Handles btnConfirmEdit.Click

        BookingRecord(idxBookingToEdit).strBookingFirstName = txtFirstName.Text

        BookingRecord(idxBookingToEdit).strBookingLastName = txtLastName.Text

        BookingRecord(idxBookingToEdit).strDOB = txtDOB.Text

        BookingRecord(idxBookingToEdit).arrSeatsBooked = Split(txtSeats.Text, ",")

        Dim totalSeats As Integer = BookingRecord(idxBookingToEdit).arrSeatsBooked.Length

        BookingRecord(idxBookingToEdit).intTotal = totalSeats * 20

        BookingRecord(idxBookingToEdit).strFilm = cbxMovieSelection.Text

        Array.Clear(selectedSeats, 0, selectedSeats.Length)

        ReDim selectedSeats(0 To -1)

        WriteBookingRecordArrayToFile()

        CreateBookings.PaymentSuccess()

        CreateBookings.gbCreateBooking.Visible = True

        CreateBookings.rtbSelectedSeats.Clear()

        bEditMode = False

        CreateBookings.lblEditMode.Visible = False

        MessageBox.Show("Booking has been successfully edited")

        ViewBookings.Enabled = True

        Me.Hide()
        CreateBookings.Hide()
        ViewBookings.Booking_Refresh()
        ViewBookings.Show()
    End Sub

    Private Sub btnExitButton_Click(sender As Object, e As EventArgs) Handles btnExitButton.Click

        Array.Clear(selectedSeats, 0, selectedSeats.Length)

        ReDim selectedSeats(0 To -1)

        CreateBookings.gbCreateBooking.Visible = True

        CreateBookings.rtbSelectedSeats.Clear()

        bEditMode = False

        CreateBookings.lblEditMode.Visible = False

        Me.Hide()

        ViewBookings.Enabled = True

        CreateBookings.Hide()

        ViewBookings.Show()
    End Sub
End Class