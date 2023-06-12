Public Class EditBooking
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click 'This button is used to edit the seats of a booking.

        If cbxMovieSelection.Text <> BookingToEdit.strFilm Then
            bFilmChanged = True
        End If
        ViewBookings.Hide()
        MessageBox.Show(bFilmChanged)
        'Display the Seat Editing Window, named "CreateBookings", however this window has an "Edit Mode"
        CreateBookings.cbxMovieSelection.Text = cbxMovieSelection.Text
        CreateBookings.Show()
        CreateBookings.Refresh()
        CreateBookings.EditBookingRequest() 'Send a request to edit a booking.
        CreateBookings.gbFilmSelection.Enabled = False 'Disable the other controls because we're not creating a new booking, we are editing one.
        CreateBookings.lblEditMode.Visible = True
        CreateBookings.gbCreateBooking.Enabled = False

        cbxMovieSelection.Enabled = False
        bEditMode = True 'Initiate edit mode
    End Sub

    Private Sub EditBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnConfirmEdit_Click(sender As Object, e As EventArgs) Handles btnConfirmEdit.Click

        'Update the BookingRecord array to store the edited booking.
        BookingRecord(idxBookingToEdit).strBookingFirstName = txtFirstName.Text

        BookingRecord(idxBookingToEdit).strBookingLastName = txtLastName.Text

        BookingRecord(idxBookingToEdit).strDOB = txtDOB.Text

        BookingRecord(idxBookingToEdit).arrSeatsBooked = Split(txtSeats.Text, ",")

        BookingRecord(idxBookingToEdit).intTotal = CalculateTotalSeatCost(BookingRecord(idxBookingToEdit).arrSeatsBooked)

        BookingRecord(idxBookingToEdit).strFilm = cbxMovieSelection.Text

        If IsNothing(selectedSeats) = False Then 'Clear the selected seats array now that we're done with it.
            Array.Clear(selectedSeats, 0, selectedSeats.Length)
        End If

        ReDim selectedSeats(0 To -1) 'Remove the array's size.

        WriteBookingRecordArrayToFile() 'Update the file with the edited booking record.

        CreateBookings.PaymentSuccess() 'Colour the edited seats red again.

        CreateBookings.gbCreateBooking.Enabled = True 'Enable the controls on "Create Booking" window because we're no longer editing.

        CreateBookings.gbFilmSelection.Enabled = True

        CreateBookings.rtbSelectedSeats.Clear()

        bEditMode = False 'No longer in edit mode.

        CreateBookings.lblEditMode.Visible = False

        MessageBox.Show("Booking has been successfully edited") 'Confirmation

        ViewBookings.Enabled = True

        cbxMovieSelection.Enabled = True

        Me.Hide()
        CreateBookings.Hide()
        ViewBookings.Booking_Refresh()
        ViewBookings.Show()
    End Sub

    Private Sub btnExitButton_Click(sender As Object, e As EventArgs) Handles btnExitButton.Click

        'Get out of edit mode then go back to the View Bookings Window


        If IsNothing(selectedSeats) = False Then
            Array.Clear(selectedSeats, 0, selectedSeats.Length)
        End If


        ReDim selectedSeats(0 To -1)
        BookingRecord(idxBookingToEdit).arrSeatsBooked = Split(txtSeats.Text, ",")

        CreateBookings.gbCreateBooking.Enabled = True

        CreateBookings.gbFilmSelection.Enabled = True

        CreateBookings.rtbSelectedSeats.Clear()

        bEditMode = False

        bFilmChanged = False

        CreateBookings.lblEditMode.Visible = False

        Me.Hide()

        ViewBookings.Enabled = True

        cbxMovieSelection.Enabled = True

        CreateBookings.Hide()

        ViewBookings.Show()
    End Sub

    Private Sub cbxMovieSelection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxMovieSelection.SelectedIndexChanged


    End Sub
End Class