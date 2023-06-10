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
        selectedSeats = BookingToEdit.arrSeatsBooked
        For Each seat In selectedSeats
            Dim btnSeat As FontAwesome.Sharp.IconPictureBox = DirectCast(Controls(seat), FontAwesome.Sharp.IconPictureBox)
            If btnSeat IsNot Nothing Then
                btnSeat.IconColor = Color.LimeGreen
            End If
        Next
    End Sub

    Private Sub DynamicButton_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim btn As FontAwesome.Sharp.IconPictureBox = DirectCast(sender, FontAwesome.Sharp.IconPictureBox)


        If Array.IndexOf(selectedSeats, btn.Name) >= 0 Then
            ' The string already exists in the array, so remove it
            selectedSeats = RemoveElementFromArray(selectedSeats, btn.Name)
        Else
            ' The string doesn't exist in the array, so add it
            ReDim Preserve selectedSeats(UBound(selectedSeats) + 1)
            selectedSeats(UBound(selectedSeats)) = btn.Name
        End If
        If bEditMode = True Then
            EditBooking.txtSeats.Text = Join(selectedSeats, ",")
        End If


        ' Function to remove an element from an array

        rtbSelectedSeats.Clear()
        If selectedSeats.Length >= 1 Then
            rtbSelectedSeats.AppendText(Strings.Join(selectedSeats, ","))
        End If

        'MessageBox.Show("seat: " & btn.Name)
        'if we click on a button, highlight it.
        Select Case (btn.IconColor)
            'Select/Deselect empty seat
            Case Color.CornflowerBlue
                btn.IconColor = Color.LightGreen
            Case Color.LightGreen
                btn.IconColor = Color.CornflowerBlue

        End Select

        lblTotal.Text = "Total: $" & CalculateTotalSeatCost(selectedSeats).ToString()



    End Sub

    Private Sub DynamicButton_Hover(ByVal sender As Object, ByVal e As System.EventArgs)

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

        For Each button As FontAwesome.Sharp.IconPictureBox In Controls.OfType(Of FontAwesome.Sharp.IconPictureBox)()
            If button.Name = "btnBack" Then
                Continue For
            End If
            button.IconColor = SystemColors.Highlight
            button.Enabled = True
        Next

        For Each booking In BookingRecord
            If booking.arrSeatsBooked IsNot Nothing And booking.strFilm = strSelectedFilm Then
                For Each seat In booking.arrSeatsBooked
                    Dim btnSeat As FontAwesome.Sharp.IconPictureBox = DirectCast(Controls(seat), FontAwesome.Sharp.IconPictureBox)
                    If btnSeat IsNot Nothing Then
                        btnSeat.IconColor = Color.Red
                    End If
                Next
            End If

        Next
    End Sub
    Private Sub CreateBookings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReDim selectedSeats(0 To -1) ' Initialize with size 0


        'Dynamically Load Buttons Upon load
        'Specified dimensions
        Dim form_width As Integer = Me.Width - 300
        Dim buttons_width As Integer = (button_row_num + 1) * 75

        'Grid buttons
        Dim counter As Byte = 0

        For Each button As FontAwesome.Sharp.IconPictureBox In Controls.OfType(Of FontAwesome.Sharp.IconPictureBox)()
            If button.Name = "btnBack" Then
                Continue For
            End If
            AddHandler button.Click, AddressOf DynamicButton_Click
            AddHandler button.MouseEnter, AddressOf DynamicButton_Hover
            AddHandler button.MouseLeave, AddressOf DynamicButton_MouseLeave
        Next


        ColourBookedSeats()

    End Sub

    Public Sub PaymentSuccess()
        For Each button As FontAwesome.Sharp.IconPictureBox In Controls.OfType(Of FontAwesome.Sharp.IconPictureBox)()
            If button.IconColor = Color.LimeGreen Then
                button.IconColor = Color.Red
                button.Enabled = False
            End If
        Next
    End Sub
    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        strFirstName = txtFirstName.Text
        strLastName = txtLastName.Text
        PaymentScreen.Show()
        PaymentScreen.InitialiseTextBoxes()
        Me.Enabled = False
    End Sub


    Private Sub cbxMovieSelection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxMovieSelection.SelectedIndexChanged
        Select Case cbxMovieSelection.Text
            Case "The Lion King"
                pbMovie.Image = My.Resources.LionKing
            Case "Forrest Gump"
                pbMovie.Image = My.Resources.ForrestGump
            Case "Good Will Hunting"
                pbMovie.Image = My.Resources.GoodWillHunting
        End Select

        strSelectedFilm = cbxMovieSelection.Text


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ColourBookedSeats()
    End Sub
End Class