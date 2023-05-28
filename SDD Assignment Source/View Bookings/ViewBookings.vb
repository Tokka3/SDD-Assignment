Public Class ViewBookings
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        WelcomeScreen.Show()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles grpBookings.Enter

    End Sub

    Private Sub ViewBookings_Load(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        Dim container As New Panel With {.Dock = DockStyle.Fill, .AutoScroll = True}
        grpBookings.Controls.Add(container) ' Assume grpBookings is your GroupBox

        Dim yPos As Integer = 10 ' Initial vertical position for the first Panel

        For i As Integer = 0 To BookingRecord.Length - 1
            ' Create a new Panel for the record
            If String.IsNullOrEmpty(BookingRecord(i).strBookingFirstName) Then
                Continue For
            End If
            Dim recordPanel As New Panel With {.Width = 603, .Height = 40, .Top = yPos, .Left = 5, .BackColor = SystemColors.Highlight}
            container.Controls.Add(recordPanel)

            ' Create Labels and add them to the record's Panel
            Dim lblID As New Label With {.Text = i.ToString(), .Top = 10, .Width = 30, .Left = 5, .ForeColor = Color.White}
            lblID.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            recordPanel.Controls.Add(lblID)

            Dim lblFirstName As New Label With {.Text = BookingRecord(i).strBookingFirstName, .Top = 10, .Width = 95, .Left = 45, .ForeColor = Color.White}
            lblFirstName.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            recordPanel.Controls.Add(lblFirstName)

            Dim lblLastName As New Label With {.Text = BookingRecord(i).strBookingLastName, .Top = 10, .Left = 140, .Width = 135, .ForeColor = Color.White}
            lblLastName.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            recordPanel.Controls.Add(lblLastName)

            Dim txtSeats As New TextBox With {.Text = String.Join(",", BookingRecord(i).arrSeatsBooked), .Top = 8, .Left = 275, .Width = 100}
            txtSeats.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            recordPanel.Controls.Add(txtSeats)

            Dim lblPrice As New Label With {.Text = "$" & BookingRecord(i).intTotal.ToString(), .Top = 10, .Left = 405, .Width = 55, .ForeColor = Color.White}
            lblPrice.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            recordPanel.Controls.Add(lblPrice)

            Dim btnEdit As New Button With {.FlatStyle = FlatStyle.Flat, .Width = 50, .Height = 28, .Top = 6, .ForeColor = Color.White, .Left = 460, .Text = "Edit", .BackColor = SystemColors.HotTrack}
            btnEdit.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            recordPanel.Controls.Add(btnEdit)

            Dim btnDelete As New Button With {.FlatStyle = FlatStyle.Flat, .Width = 70, .Height = 28, .Top = 6, .ForeColor = Color.White, .Left = 520, .Text = "Delete", .BackColor = Color.OrangeRed}
            btnDelete.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            recordPanel.Controls.Add(btnDelete)
            ' ... create more Labels for the other pieces of data

            ' Increase the vertical position for the next Panel
            yPos += 50
        Next
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub ViewBookings_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class