Public Class CreateBookings

    Dim button_row_num As Integer = 3
    Dim button_column_num As Integer = 7
    Dim booking_counter As Integer = 0 'every time the admin presses save, this will increase
    Dim seat_counter As Integer = 0 'every time a seat is clicked, this will increase or decrease
    Dim button_names(10 * 10) As String


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        WelcomeScreen.Show()
    End Sub

    Public Sub EditBookingRequest()

        ColourBookedSeats()

        If bFilmChanged <> True Then 'If the admin edits the film in the Edit Booking window, then reset the seats. Otherwise keep the original ones.
            selectedSeats = BookingToEdit.arrSeatsBooked
        End If

        For Each seat In selectedSeats 'loop through the users booked seats they want to edit. 
            Dim btnSeat As FontAwesome.Sharp.IconPictureBox = DirectCast(Controls(seat), FontAwesome.Sharp.IconPictureBox) 'convert the seat string to a button object
            If btnSeat IsNot Nothing Then
                btnSeat.IconColor = Color.LimeGreen 'Colour the users seats green so they can now edit them again.
            End If
        Next
    End Sub

    Private Sub DynamicButton_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        If String.IsNullOrEmpty(cbxMovieSelection.Text) Then
            MessageBox.Show("Please select a film before selecting a seat.")
            Return
        End If
        Dim btn As FontAwesome.Sharp.IconPictureBox = DirectCast(sender, FontAwesome.Sharp.IconPictureBox)

        If btn.IconColor = Color.Red Then 'We can't book red seats as they are already occupied.
            Return
        End If


        If bFilmChanged Then 'If the Film Has been changed in the Edit Bookings window, then we remove the old seats.
            EditBooking.txtSeats.Clear()
            bFilmChanged = False
        End If

        If Array.IndexOf(selectedSeats, btn.Name) >= 0 Then 'Add the seat to an array or remove it.

            'The string already exists in the array, so remove it
            selectedSeats = RemoveElementFromArray(selectedSeats, btn.Name)
        Else
            'The string doesn't exist in the array, so add it
            ReDim Preserve selectedSeats(UBound(selectedSeats) + 1)
            selectedSeats(UBound(selectedSeats)) = btn.Name
        End If
        If bEditMode = True Then
            EditBooking.txtSeats.Text = Join(selectedSeats, ",")
        End If


        'Display the selected seats in the rich text box.
        rtbSelectedSeats.Clear()

        If selectedSeats.Length >= 1 Then
            rtbSelectedSeats.AppendText(Strings.Join(selectedSeats, ","))
        End If


        'if we click on a button, highlight it.
        Select Case (btn.IconColor)
            'Select/Deselect empty seat
            Case Color.CornflowerBlue 'If the button isn't selected, display it as the selected colour. 
                btn.IconColor = Color.LightGreen
            Case Color.LightGreen
                btn.IconColor = Color.CornflowerBlue 'If the button was selected, set it back to the default colour.

        End Select

        lblTotal.Text = "Total: $" & CalculateTotalSeatCost(selectedSeats).ToString()



    End Sub

    Private Sub DynamicButton_Hover(ByVal sender As Object, ByVal e As System.EventArgs)
        'When hovering over a seat, we show a hover over effect.

        Dim btn As FontAwesome.Sharp.IconPictureBox = DirectCast(sender, FontAwesome.Sharp.IconPictureBox)

        Select Case (btn.IconColor)
            'Select/Deselect empty seat
            Case SystemColors.Highlight
                btn.IconColor = Color.CornflowerBlue
            Case Color.LimeGreen
                btn.IconColor = Color.LightGreen


        End Select



    End Sub
    Private Sub DynamicButton_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)

        'When we stop hovering over a seat, remove the hover over effect. 

        Dim btn As FontAwesome.Sharp.IconPictureBox = DirectCast(sender, FontAwesome.Sharp.IconPictureBox)
        If btn.IconColor = Color.CornflowerBlue Then
            btn.IconColor = SystemColors.Highlight

        End If
        Select Case (btn.IconColor)
            Case Color.CornflowerBlue
                btn.IconColor = SystemColors.Highlight
            Case Color.LightGreen
                btn.IconColor = Color.LimeGreen
        End Select
    End Sub

    Sub ColourBookedSeats()

        For Each button As FontAwesome.Sharp.IconPictureBox In Controls.OfType(Of FontAwesome.Sharp.IconPictureBox)() 'Reset all buttons to the original colour.
            If button.Name = "btnBack" Then
                Continue For
            End If
            button.IconColor = SystemColors.Highlight
            button.Enabled = True
        Next

        For Each booking In BookingRecord 'Loop through all bookings in the Booking Record
            If booking.arrSeatsBooked IsNot Nothing And booking.strFilm = strSelectedFilm Then
                For Each seat In booking.arrSeatsBooked 'Loop through al the seats in each booking
                    Dim btnSeat As FontAwesome.Sharp.IconPictureBox = DirectCast(Controls(seat), FontAwesome.Sharp.IconPictureBox)
                    If btnSeat IsNot Nothing Then
                        btnSeat.IconColor = Color.Red 'Set the seat to red, indicating that it's occupied and it may not be booked again.
                    End If
                Next
            End If

        Next

        Dim strSelectedSeats As String() 'Seats that were selected for a booking need to be recoloured after exiting out the window. 
        strSelectedSeats = Split(rtbSelectedSeats.Text, ",") 'Read the seats from the "Selected Seats" textbox.
        For Each seat In strSelectedSeats
            Dim btnSeat As FontAwesome.Sharp.IconPictureBox = DirectCast(Controls(seat), FontAwesome.Sharp.IconPictureBox)
            If btnSeat IsNot Nothing Then
                btnSeat.IconColor = Color.LimeGreen 'Colour the seats green.
            End If
        Next
    End Sub

    Private Sub CreateBookings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReDim selectedSeats(0 To -1) ' Initialize with size 0

        ColourBookedSeats()


        For Each button As FontAwesome.Sharp.IconPictureBox In Controls.OfType(Of FontAwesome.Sharp.IconPictureBox)()
            If button.IconChar <> button.IconChar.Couch Then 'If the icon is not a couch/seat, don't add a handler.
                Continue For
            End If

            'Add handlers to all seats. These will be responsible for clicks, hovers and unhovering.
            AddHandler button.Click, AddressOf DynamicButton_Click
            AddHandler button.MouseEnter, AddressOf DynamicButton_Hover
            AddHandler button.MouseLeave, AddressOf DynamicButton_MouseLeave
        Next
    End Sub

    Public Sub PaymentSuccess()
        For Each button As FontAwesome.Sharp.IconPictureBox In Controls.OfType(Of FontAwesome.Sharp.IconPictureBox)()
            If button.IconColor = Color.LimeGreen Then 'All the selected seats (green seats) should now be coloured red because the booking was successful.
                button.IconColor = Color.Red
                button.Enabled = False
            End If
        Next
    End Sub
    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click

        'Initialise Payment Window
        strFirstName = txtFirstName.Text
        strLastName = txtLastName.Text
        PaymentScreen.Show()
        PaymentScreen.InitialiseTextBoxes()

        Me.Enabled = False
    End Sub


    Private Sub cbxMovieSelection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxMovieSelection.SelectedIndexChanged
        'Change the movie image when the combo box value is changed.
        Select Case cbxMovieSelection.Text
            Case "The Lion King"
                pbMovie.Image = My.Resources.LionKing
            Case "Forrest Gump"
                pbMovie.Image = My.Resources.ForrestGump
            Case "Good Will Hunting"
                pbMovie.Image = My.Resources.GoodWillHunting
        End Select

        strSelectedFilm = cbxMovieSelection.Text


        If IsNothing(selectedSeats) = False Then 'Clear the seats array if it's not empty
            Array.Clear(selectedSeats, 0, selectedSeats.Length)

            ReDim selectedSeats(0 To -1) 'Reset the selectedSeats array 

        End If
        rtbSelectedSeats.Clear()
        ColourBookedSeats()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        CreateBookingTutorial.Show()
    End Sub

    Private Sub txtDOB_TextChanged(sender As Object, e As EventArgs) Handles txtDOB.TextChanged

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ExitProgram()
    End Sub

    Function ValidateInputs() As Boolean
        Dim dateDummyVar As Date
        Dim bValid As Boolean = True

        'Validate DOB's
        If Not Date.TryParseExact(txtDOB.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, dateDummyVar) Then
            bValid = False
            pValidDOB.BackColor = Color.LightCoral
        Else
            pValidDOB.BackColor = Color.YellowGreen
        End If
        'Validate First Name Textbox
        If String.IsNullOrEmpty(txtFirstName.Text) Then
            bValid = False
            pValidFirstName.BackColor = Color.LightCoral

        Else
            pValidFirstName.BackColor = Color.YellowGreen

        End If
        'Validate Last Name Textbox
        If String.IsNullOrEmpty(txtLastName.Text) Then
            bValid = False
            pValidLastName.BackColor = Color.LightCoral
        Else
            pValidLastName.BackColor = Color.YellowGreen
        End If

        'Validate If Seats have been selected 
        If String.IsNullOrEmpty(rtbSelectedSeats.Text) Then
            bValid = False
            pValidSeats.BackColor = Color.LightCoral
        Else
            pValidSeats.BackColor = Color.YellowGreen
        End If
        Return bValid
    End Function
    Private Sub txtField_Changed(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged, txtLastName.TextChanged, txtDOB.TextChanged, rtbSelectedSeats.TextChanged
        btnPayment.Enabled = ValidateInputs() 'If all text fields are valid, enable the payment button.
    End Sub


End Class