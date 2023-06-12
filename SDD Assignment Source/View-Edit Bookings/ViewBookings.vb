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

            ClearBookingFile() 'Clear the booking file

            Dim writeFile As System.IO.StreamWriter 'Open stream to file
            writeFile = System.IO.File.AppendText("Bookings.txt")

            For Each booking In BookingRecord 'Rewrite all the bookings to the file except for the one we want to delete

                If booking.intBookingID = booking_to_delete.intBookingID Then 'Skip the booking we want to delete
                    Continue For
                End If

                Dim strField As String = "" 'Combine all the fields into one string
                strField &= (booking.intBookingID.ToString() & "-")
                strField &= (booking.intTotal.ToString() & "-")
                strField &= (booking.strBookingFirstName & "-")
                strField &= (booking.strBookingLastName & "-")
                strField &= (booking.strDOB & "-")
                strField &= (Join(booking.arrSeatsBooked, ",") & "-")
                strField &= (booking.strFilm)
                If strField = "0-0-----" Then 'Don't write empty records to file'
                    Continue For
                End If

                writeFile.WriteLine(strField)
            Next

            writeFile.Close()

            UpdateBookingRecordArray() 'Update the global array in the program by reading the file that has deleted the record.

            Booking_Refresh() 'Refresh the display of bookings

        End If
    End Sub

    Private Sub Edit_Record(ByVal sender As Object, ByVal e As System.EventArgs) 'Gets called when the edit button is clicked on a record in the "View Bookings" window
        Dim btn As Button = DirectCast(sender, Button)

        BookingToEdit = BookingRecord(GetBookingIdxByID(btn.AccessibleDescription)) 'Stores the booking that needs to be edited in a global variable

        idxBookingToEdit = GetBookingIdxByID(btn.AccessibleDescription) 'Stores the index of the booking to be edited in a global variable

        EditBooking.Show() 'Display the Edit Booking window


        'Automatically fill in all the booking details so you can simply edit what you want and not have to retype everything.
        EditBooking.txtFirstName.Text = BookingToEdit.strBookingFirstName
        EditBooking.txtLastName.Text = BookingToEdit.strBookingLastName
        EditBooking.txtDOB.Text = BookingToEdit.strDOB
        EditBooking.txtSeats.Text = String.Join(",", BookingToEdit.arrSeatsBooked)
        EditBooking.cbxMovieSelection.Text = BookingToEdit.strFilm
        Me.Enabled = False
    End Sub


    Function Filter_Record(ByVal booking As Booking) As Boolean 'Will check if the Record matches all filter options
        Dim validSearch As Boolean = True
        ' Filter the Films. If the combo box Is Set To All, all records will be displayed

        If booking.strFilm <> cbxMovieSelection.Text And cbxMovieSelection.Text <> "All" Then 'If the film equals the filter, return true, else return false
            Return False 'Records film doesn't match the filter, so return false
        End If

        If validSearch Then 'Now Check for Search queries

            If String.IsNullOrEmpty(txtSearch.Text) Then 'If nothing is in search bar, don't filter anything
                Return True
            End If
            If cbxSearchCategory.Text = "ID" Or cbxSearchCategory.Text = "All" Then
                If IsNumeric(txtSearch.Text) Then
                    Return (booking.intBookingID = CInt(txtSearch.Text)) 'If the booking ID matches search query, return true
                End If

            End If

            If cbxSearchCategory.Text = "First Name" Or cbxSearchCategory.Text = "All" Then
                Return (booking.strBookingFirstName = txtSearch.Text) 'If the booking first name matches search query, return true
            End If
            If cbxSearchCategory.Text = "Last Name" Or cbxSearchCategory.Text = "All" Then
                Return (booking.strBookingLastName = txtSearch.Text) 'If the booking last name matches search query, return true
            End If

        End If
        Return False

        '   If cbxMovieSelection.Text = booking.
    End Function

    Public Function CalculateTotalRevenueForMovie(ByVal movie As String) As Integer
        Dim totalRevenue As Integer = 0

        For Each booking As Booking In BookingRecord 'Loop through all the bookings and if the film matches the criteria, add the booking cost to the total
            If booking.strFilm = movie Or movie = "All" Then
                totalRevenue += booking.intTotal
            End If
        Next

        Return totalRevenue
    End Function

    Public Function CountBookingsForFilm(ByVal movie As String) As Integer
        Dim count As Integer = 0

        For Each booking As Booking In BookingRecord 'Loop through all the bookings and if the film matches the criteria, increase the count by 1
            If booking.strFilm = movie Or movie = "All" And String.IsNullOrEmpty(booking.strBookingFirstName) <> True Then
                count += 1
                Debug.WriteLine(count)
            End If
        Next

        Return count
    End Function

    Public Sub Booking_Refresh()

        grpBookings.Controls.Clear()
        Dim container As New Panel With {.Dock = DockStyle.Fill, .AutoScroll = True, .Name = "displayPanel"}

        grpBookings.Controls.Add(container) 'Add the elements to the group box.

        Dim yPos As Integer = 0 'Initial vertical position for the first Panel

        Dim BookingDisplay(100) As Booking 'The Bookings that will be displayed

        BookingDisplay = SortBookingRecord() 'Sort the Booking Records according to the sort combo box
        For i As Integer = 0 To BookingDisplay.Length - 1

            ' Create a new Panel for the record
            If String.IsNullOrEmpty(BookingDisplay(i).strBookingFirstName) Then 'If the booking does not have a first name, it's an empty element in the array
                Continue For
            End If

            If Filter_Record(BookingDisplay(i)) = False Then 'Check if the booking matches the search/sort/filter requirements, if it doesn't, iterate next.
                Continue For
            End If


            Dim recordPanel As New Panel With {.Width = 705, .Height = 40, .Top = yPos, .Left = 5, .BackColor = SystemColors.Highlight}
            container.Controls.Add(recordPanel)

            'DISPLAY RECORDS - THIS USES DYNAMIC ELEMENTS, ALL CONTROLS ARE CREATED AT RUNTIME

            'Create Labels and add them to the record's Panel
            Dim lblID As New Label With {.Text = BookingDisplay(i).intBookingID.ToString(), .Top = 10, .Width = 30, .Left = 5, .ForeColor = Color.White}
            lblID.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            recordPanel.Controls.Add(lblID)

            'Display the first name
            Dim lblFirstName As New Label With {.Text = BookingDisplay(i).strBookingFirstName, .Top = 10, .Width = 95, .Left = 45, .ForeColor = Color.White}
            lblFirstName.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            recordPanel.Controls.Add(lblFirstName)

            'Display the last name
            Dim lblLastName As New Label With {.Text = BookingDisplay(i).strBookingLastName, .Top = 10, .Left = 140, .Width = 100, .ForeColor = Color.White}
            lblLastName.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            recordPanel.Controls.Add(lblLastName)

            'Display the film
            Dim lblFilm As New Label With {.Text = BookingDisplay(i).strFilm, .Top = 10, .Left = 235, .Width = 106, .ForeColor = Color.White}
            lblFilm.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            recordPanel.Controls.Add(lblFilm)

            'Create a textbox to display the bookings seats
            Dim txtSeats As New TextBox With {.Text = String.Join(",", BookingDisplay(i).arrSeatsBooked), .Top = 8, .Left = 342, .Width = 140, .ForeColor = SystemColors.HotTrack, .[ReadOnly] = True}
            txtSeats.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            recordPanel.Controls.Add(txtSeats)
            'Display the total price
            Dim lblPrice As New Label With {.Text = "$" & BookingDisplay(i).intTotal.ToString(), .Top = 10, .Left = 512, .Width = 55, .ForeColor = Color.White}
            lblPrice.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            recordPanel.Controls.Add(lblPrice)
            'Display the Edit Button
            Dim btnEdit As New Button With {.FlatStyle = FlatStyle.Flat, .Width = 50, .Height = 28, .Top = 6, .ForeColor = Color.White, .Left = 567, .Text = "Edit", .BackColor = SystemColors.HotTrack}
            btnEdit.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            btnEdit.AccessibleDescription = BookingDisplay(i).intBookingID.ToString()
            recordPanel.Controls.Add(btnEdit)
            AddHandler btnEdit.Click, AddressOf Edit_Record 'Add a handler for the edit button when it's clicked.

            'Display the Delete Button
            Dim btnDelete As New Button With {.FlatStyle = FlatStyle.Flat, .Width = 70, .Height = 28, .Top = 6, .ForeColor = Color.White, .Left = 627, .Text = "Delete", .BackColor = Color.OrangeRed}
            btnDelete.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            btnDelete.AccessibleDescription = BookingDisplay(i).intBookingID.ToString()
            AddHandler btnDelete.Click, AddressOf Delete_Record 'Add a handler for the delete button when it's clicked.
            recordPanel.Controls.Add(btnDelete)

            'Increase the vertical position for the next Panel
            yPos += 50
        Next
    End Sub
    Private Sub ViewBookings_Load(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        Booking_Refresh()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub ViewBookings_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initialise Search/Filter Combo Boxes
        cbxMovieSelection.SelectedIndex = 0
        cbxSort.SelectedIndex = 0

        gpInsights.Text = "Insights - " & cbxMovieSelection.Text
        lblRevenue.Text = "Revenue: $" & CalculateTotalRevenueForMovie(cbxMovieSelection.Text)
        lblTotalBookings.Text = "Total Bookings: " & CountBookingsForFilm(cbxMovieSelection.Text)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Booking_Refresh()

    End Sub

    Private Sub btnSortFilterSearch_Click(sender As Object, e As EventArgs) Handles btnSort.Click, btnSearch.Click, btnFilter.Click
        gpInsights.Text = "Insights - " & cbxMovieSelection.Text
        lblRevenue.Text = "Revenue: $" & CalculateTotalRevenueForMovie(cbxMovieSelection.Text)
        lblTotalBookings.Text = "Total Bookings: " & CountBookingsForFilm(cbxMovieSelection.Text)
        Booking_Refresh()
    End Sub


    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click
        txtSearch.Clear()
        Booking_Refresh()

    End Sub

    Private Sub btnClearFilters_Click(sender As Object, e As EventArgs) Handles btnClearFilters.Click
        cbxMovieSelection.SelectedIndex = 0 'Set the Movie Filter to All
        Booking_Refresh()

        gpInsights.Text = "Insights - " & cbxMovieSelection.Text
        lblRevenue.Text = "Revenue: $" & CalculateTotalRevenueForMovie(cbxMovieSelection.Text)
        lblTotalBookings.Text = "Total Bookings: " & CountBookingsForFilm(cbxMovieSelection.Text)
    End Sub

    Private Sub btnClearSort_Click(sender As Object, e As EventArgs) Handles btnClearSort.Click
        cbxSort.SelectedIndex = 0
        Booking_Refresh()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        EditBookingTutorial.Show()
    End Sub

    Private Sub Exit_Button(sender As Object, e As EventArgs) Handles btnExit.Click
        ExitProgram()
    End Sub
End Class