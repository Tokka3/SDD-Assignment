Public Class PaymentScreen
    Private Sub btnExitButton_Click(sender As Object, e As EventArgs) Handles btnExitButton.Click
        Me.Hide()
        CreateBookings.Enabled = True
        CreateBookings.Activate()
    End Sub

    Sub InitialiseTextBoxes()
        txtFirstname.Text = strFirstName
        txtLastname.Text = strLastName
        lblTotal.Text = "Total: $" & CalculateTotalSeatCost(selectedSeats).ToString()
        txtCCNo.Focus()
    End Sub
    Private Sub PaymentScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Function ValidateInputs() As Boolean
        Dim dateDummyVar As Date
        Dim bValid As Boolean = True

        If txtCCNo.Text.Length <> 16 Then 'If Credit Card Number length != 16, it is not valid
            bValid = False
            pValidCCNo.BackColor = Color.LightCoral
        Else
            If IsNumeric(txtCCNo.Text) = False Then 'If Credit Card is not numeric, it is not valid
                pValidCCNo.BackColor = Color.LightCoral
                bValid = False
            Else
                pValidCCNo.BackColor = Color.YellowGreen

            End If
        End If

        If txtCCV.Text.Length <> 3 Then 'If CVV number length != 3, it is not valid
            bValid = False
            pValidCVV.BackColor = Color.LightCoral
        Else
            If IsNumeric(txtCCV.Text) = False Then 'If CVV is not numeric, it is not valid
                pValidCVV.BackColor = Color.LightCoral
                bValid = False
            Else
                pValidCVV.BackColor = Color.YellowGreen

            End If
        End If

        If txtExpiryDate.Text.Length <> 5 Then 'If the expiry date length is not 5, it is not valid.
            bValid = False
            pValidExpDate.BackColor = Color.LightCoral
        Else
            If txtExpiryDate.Text(2) <> "/" Then 'Expiry date must have a slash in the 2nd index (MM/YY)
                pValidExpDate.BackColor = Color.LightCoral
                bValid = False
            Else
                pValidExpDate.BackColor = Color.YellowGreen
            End If
        End If

        Return bValid
    End Function
    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        MessageBox.Show("Thanks " & strFirstName & ", you're booking is complete")

        Me.Hide()

        intBookingCount += 1 'Increment booking count by one

        Dim Booking As Object = BookingRecord(intBookingCount)

        ' MessageBox.Show("Seat Cost: " & Booking.intTotal.ToString())

        Booking.strBookingFirstName = txtFirstname.Text 'Populate the BookingRecord Array with the next booking
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

        Dim writeFile As System.IO.StreamWriter 'Open stream to file
        writeFile = System.IO.File.AppendText("Bookings.txt")

        writeFile.WriteLine(strField)

        writeFile.Close()


        'Clear the array "selectedSeats" for a new booking.
        Array.Clear(selectedSeats, 0, selectedSeats.Length)
        ReDim selectedSeats(0 To -1)

        'Set focus onto the CreateBookings form again.
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

    Private Sub txtCCNo_TextChanged(sender As Object, e As EventArgs) Handles txtCCNo.TextChanged, txtExpiryDate.TextChanged, txtCCV.TextChanged
        btnPayment.Enabled = ValidateInputs() 'If all the inputs are valid, enable the payment button.
    End Sub
End Class