Module FileManager

    Public Sub UpdateBookingRecord()

        Dim filePath As String = "Bookings.txt"

        Dim counter As Integer = 0

        Dim readFile As System.IO.StreamReader

        readFile = New System.IO.StreamReader("Bookings.txt")

        While Not readFile.EndOfStream And counter < 100

            Dim line As String = readFile.ReadLine()

            Dim parts() As String = line.Split("-"c)

            If parts.Length >= 6 Then

                BookingRecord(counter).intBookingID = Integer.Parse(parts(0))

                BookingRecord(counter).intTotal = Integer.Parse(parts(1))

                BookingRecord(counter).strBookingFirstName = parts(2)

                BookingRecord(counter).strBookingLastName = parts(3)

                BookingRecord(counter).strDOB = parts(4)

                BookingRecord(counter).arrSeatsBooked = parts(5).Split(","c)

            End If

            counter += 1
        End While
        readFile.Close()
    End Sub
End Module
