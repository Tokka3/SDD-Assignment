Public Class ViewBookings
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        WelcomeScreen.Show()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles grpBookings.Enter

    End Sub
    Private Sub Delete_Record(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Dim booking_to_delete As Booking = BookingRecord(GetBookingIdxByID(btn.AccessibleDescription))
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete " & booking_to_delete.strBookingFirstName & "'s booking?", "Warning", MessageBoxButtons.YesNoCancel)

        If result = DialogResult.Yes Then

            ClearBookingFile()
            Dim writeFile As System.IO.StreamWriter 'Open stream to file
            writeFile = System.IO.File.AppendText("Bookings.txt")

            For Each booking In BookingRecord

                If booking.intBookingID = booking_to_delete.intBookingID Then
                    Continue For
                End If

                Dim strField As String = ""
                strField &= (booking.intBookingID.ToString() & "-")
                strField &= (booking.intTotal.ToString() & "-")
                strField &= (booking.strBookingFirstName & "-")
                strField &= (booking.strBookingLastName & "-")
                strField &= (booking.strDOB & "-")
                strField &= (Join(booking.arrSeatsBooked, ",") & "-")
                strField &= (booking.strFilm)
                If strField = "0-0-----" Then
                    Continue For
                End If
                writeFile.WriteLine(strField)




            Next

            writeFile.Close()

            UpdateBookingRecordArray()

            Booking_Refresh()

        End If
    End Sub

    Private Sub Edit_Record(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub Booking_Refresh()
        grpBookings.Controls.Clear()
        Dim container As New Panel With {.Dock = DockStyle.Fill, .AutoScroll = True, .Name = "displayPanel"}

        grpBookings.Controls.Add(container) ' Assume grpBookings is your GroupBox

        Dim yPos As Integer = 0 ' Initial vertical position for the first Panel

        For i As Integer = 0 To BookingRecord.Length - 1
            ' Create a new Panel for the record
            If String.IsNullOrEmpty(BookingRecord(i).strBookingFirstName) Then
                Continue For
            End If
            Dim recordPanel As New Panel With {.Width = 705, .Height = 40, .Top = yPos, .Left = 5, .BackColor = SystemColors.Highlight}
            container.Controls.Add(recordPanel)

            ' Create Labels and add them to the record's Panel
            Dim lblID As New Label With {.Text = BookingRecord(i).intBookingID.ToString(), .Top = 10, .Width = 30, .Left = 5, .ForeColor = Color.White}
            lblID.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            recordPanel.Controls.Add(lblID)

            Dim lblFirstName As New Label With {.Text = BookingRecord(i).strBookingFirstName, .Top = 10, .Width = 95, .Left = 45, .ForeColor = Color.White}
            lblFirstName.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            recordPanel.Controls.Add(lblFirstName)

            Dim lblLastName As New Label With {.Text = BookingRecord(i).strBookingLastName, .Top = 10, .Left = 140, .Width = 100, .ForeColor = Color.White}
            lblLastName.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            recordPanel.Controls.Add(lblLastName)

            Dim lblFilm As New Label With {.Text = BookingRecord(i).strFilm, .Top = 10, .Left = 235, .Width = 106, .ForeColor = Color.White}
            lblFilm.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            recordPanel.Controls.Add(lblFilm)

            Dim txtSeats As New TextBox With {.Text = String.Join(",", BookingRecord(i).arrSeatsBooked), .Top = 8, .Left = 342, .Width = 140, .ForeColor = SystemColors.HotTrack}
            txtSeats.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            recordPanel.Controls.Add(txtSeats)

            Dim lblPrice As New Label With {.Text = "$" & BookingRecord(i).intTotal.ToString(), .Top = 10, .Left = 512, .Width = 55, .ForeColor = Color.White}
            lblPrice.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            recordPanel.Controls.Add(lblPrice)

            Dim btnEdit As New Button With {.FlatStyle = FlatStyle.Flat, .Width = 50, .Height = 28, .Top = 6, .ForeColor = Color.White, .Left = 567, .Text = "Edit", .BackColor = SystemColors.HotTrack}
            btnEdit.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            btnEdit.AccessibleDescription = BookingRecord(i).intBookingID.ToString()
            recordPanel.Controls.Add(btnEdit)
            AddHandler btnEdit.Click, AddressOf Edit_Record

            Dim btnDelete As New Button With {.FlatStyle = FlatStyle.Flat, .Width = 70, .Height = 28, .Top = 6, .ForeColor = Color.White, .Left = 627, .Text = "Delete", .BackColor = Color.OrangeRed}
            btnDelete.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            btnDelete.AccessibleDescription = BookingRecord(i).intBookingID.ToString()
            AddHandler btnDelete.Click, AddressOf Delete_Record
            recordPanel.Controls.Add(btnDelete)
            ' ... create more Labels for the other pieces of data

            ' Increase the vertical position for the next Panel
            yPos += 50
        Next
    End Sub
    Private Sub ViewBookings_Load(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        Booking_Refresh()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub ViewBookings_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Booking_Refresh()

    End Sub
End Class