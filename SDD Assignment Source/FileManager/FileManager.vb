Module FileManager

    Function GetBookingIdxByID(ByVal intBookingID As Integer) As Integer
        Dim idx As Integer = 0

        For idx = 0 To 100 Step 1 'Loop through all customer records

            If BookingRecord(idx).intBookingID = Nothing Then
                Continue For
            End If

            If (BookingRecord(idx).intBookingID = intBookingID) Then 'If BookingID is found, return index in array
                Return idx
            End If
        Next
        Return -1 'Booking ID Could not be found
    End Function

    Public Sub ClearBookingFile()
        System.IO.File.WriteAllText("Bookings.Txt", String.Empty) 'Clear the booking file completely
    End Sub
    Public Sub UpdateBookingRecordArray() 'Populates the BookingRecord array by reading Bookings.txt file


        Array.Clear(BookingRecord, 0, BookingRecord.Length) 'Clear the array

        intBookingCount = 0 'Reset the booking count

        Dim filePath As String = "Bookings.txt"

        Dim counter As Integer = 0

        Dim readFile As System.IO.StreamReader

        readFile = New System.IO.StreamReader("Bookings.txt")

        While Not readFile.EndOfStream And counter < 100 'Loop through the file

            Dim line As String = readFile.ReadLine()

            Dim parts() As String = line.Split("-") 'Split the booking into it's individual parts.

            If parts.Length >= 6 Then

                BookingRecord(counter).intBookingID = Integer.Parse(parts(0)) 'Copy all the information from the line to the array at index "counter".

                BookingRecord(counter).intTotal = Integer.Parse(parts(1))

                BookingRecord(counter).strBookingFirstName = parts(2)

                BookingRecord(counter).strBookingLastName = parts(3)

                BookingRecord(counter).strDOB = parts(4)

                BookingRecord(counter).arrSeatsBooked = parts(5).Split(","c)

                BookingRecord(counter).strFilm = parts(6)

                If BookingRecord(counter).intBookingID > intBookingCount Then 'When we create a new booking we need to find out what the next booking ID is

                    intBookingCount = BookingRecord(counter).intBookingID 'intBookingCount will now store the latest booking ID 

                End If

            End If

            counter += 1
        End While
        'Debug.WriteLine("Booking count: " & intBookingCount)
        readFile.Close()
    End Sub


    Public Sub WriteBookingRecordArrayToFile()

        ClearBookingFile()
        Dim writeFile As System.IO.StreamWriter 'Open stream to file
        writeFile = System.IO.File.AppendText("Bookings.txt")

        For Each booking In BookingRecord 'Loop through booking record array

            Dim strField As String = ""

            strField &= (booking.intBookingID.ToString() & "-") 'Combine the booking information into one string, separated by delimiter "-"

            strField &= (booking.intTotal.ToString() & "-")

            strField &= (booking.strBookingFirstName & "-")

            strField &= (booking.strBookingLastName & "-")

            strField &= (booking.strDOB & "-")

            strField &= (Join(booking.arrSeatsBooked, ",") & "-")

            strField &= (booking.strFilm)

            If strField = "0-0-----" Then 'If the booking is empty don't write it to file.
                Continue For
            End If
            writeFile.WriteLine(strField)
        Next

        writeFile.Close()

        UpdateBookingRecordArray()

    End Sub
End Module
