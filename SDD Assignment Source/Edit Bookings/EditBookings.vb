Public Class EditBookings

    Dim button_row_num As Integer = 3
    Dim button_column_num As Integer = 7
    Dim booking_counter As Integer = 0 'every time the admin presses save, this will increase
    Dim seat_counter As Integer = 0 'every time a seat is clicked, this will increase or decrease
    Dim button_names(10 * 10) As String


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        WelcomeScreen.Show()
    End Sub
    Sub add_button(ByVal x_position As Integer, ByVal y_position As Integer, ByVal label As String)

        Dim dynamicButton As New FontAwesome.Sharp.IconPictureBox
        Dim dynamicLabel As New Label

        dynamicLabel.Location = New Point(x_position + 13, y_position + 50)
        dynamicLabel.Text = label
        dynamicLabel.ForeColor = Color.FromArgb(255, 30, 30, 30)
        dynamicLabel.Width = 30
        dynamicLabel.Height = 15
        dynamicLabel.Font = New Font("Segoe UI", 8.5)


        dynamicButton.Location = New Point(x_position, y_position)
        dynamicButton.Size = New Drawing.Point(50, 63)
        dynamicButton.IconSize = 50
        dynamicButton.SizeMode = PictureBoxSizeMode.StretchImage
        dynamicButton.Name = label + "id"
        dynamicButton.IconColor = SystemColors.Highlight
        dynamicButton.IconChar = dynamicButton.IconChar.Couch
        dynamicButton.Cursor = Cursors.Hand
        AddHandler dynamicButton.Click, AddressOf DynamicButton_Click
        AddHandler dynamicButton.MouseEnter, AddressOf DynamicButton_Hover
        AddHandler dynamicButton.MouseLeave, AddressOf DynamicButton_MouseLeave
        Controls.Add(dynamicLabel)
        Controls.Add(dynamicButton)

    End Sub

    Private Sub DynamicButton_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim btn As FontAwesome.Sharp.IconPictureBox = DirectCast(sender, FontAwesome.Sharp.IconPictureBox)

        'if we click on a button, highlight it.
        Select Case (btn.IconColor)
            'Select/Deselect empty seat
            Case Color.CornflowerBlue
                btn.IconColor = Color.LightGreen
            Case Color.LightGreen
                btn.IconColor = Color.CornflowerBlue

        End Select



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

    Private Sub EditBookings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Dynamically Load Buttons Upon load
        'Specified dimensions
        Dim form_width As Integer = Me.Width - 300
        Dim buttons_width As Integer = (button_row_num + 1) * 75

        'Grid buttons
        Dim counter As Byte = 0
        For idx = 0 To 8 - 1 Step 1
            For idx_2 = 0 To 7 - 1 Step 1

                button_names(counter) = (idx + 1).ToString + Chr(idx_2 + 65) + "Lid"
                add_button(50 + idx * 70, 120 + idx_2 * 70, (idx + 1).ToString + Chr(idx_2 + 65))
                counter += 1
            Next
        Next


    End Sub

End Class