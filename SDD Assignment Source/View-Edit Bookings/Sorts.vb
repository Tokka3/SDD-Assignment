Module Sorts

    'Bubble Sort is being used for all sorting algorithms. 

    Public Function SortBookingRecord() As Booking()

        Dim tempBookingRecord(100) As Booking

        ' Copying original array to temporary array
        For i As Integer = 0 To 100
            tempBookingRecord(i) = BookingRecord(i)
        Next

        ' Sorting temporary array
        Select Case ViewBookings.cbxSort.SelectedItem.ToString()



            Case "ID (Ascending) [Default]" 'default
                For i As Integer = 0 To 99
                    For j As Integer = 0 To 99 - i
                        If tempBookingRecord(j).intBookingID > tempBookingRecord(j + 1).intBookingID Then
                            Dim temp As Booking = tempBookingRecord(j)
                            tempBookingRecord(j) = tempBookingRecord(j + 1)
                            tempBookingRecord(j + 1) = temp
                        End If
                    Next
                Next

            Case "ID (Descending)"
                For i As Integer = 0 To 99
                    For j As Integer = 0 To 99 - i
                        If tempBookingRecord(j).intBookingID < tempBookingRecord(j + 1).intBookingID Then
                            Dim temp As Booking = tempBookingRecord(j)
                            tempBookingRecord(j) = tempBookingRecord(j + 1)
                            tempBookingRecord(j + 1) = temp
                        End If
                    Next
                Next

            Case "First Name (A-Z)"
                For i As Integer = 0 To 99
                    For j As Integer = 0 To 99 - i
                        If String.Compare(tempBookingRecord(j).strBookingFirstName, tempBookingRecord(j + 1).strBookingFirstName) > 0 Then
                            Dim temp As Booking = tempBookingRecord(j)
                            tempBookingRecord(j) = tempBookingRecord(j + 1)
                            tempBookingRecord(j + 1) = temp
                        End If
                    Next
                Next

            Case "First Name (Z-A)"
                For i As Integer = 0 To 99
                    For j As Integer = 0 To 99 - i
                        If String.Compare(tempBookingRecord(j).strBookingFirstName, tempBookingRecord(j + 1).strBookingFirstName) < 0 Then
                            Dim temp As Booking = tempBookingRecord(j)
                            tempBookingRecord(j) = tempBookingRecord(j + 1)
                            tempBookingRecord(j + 1) = temp
                        End If
                    Next
                Next

            Case "Last Name (A-Z)"
                For i As Integer = 0 To 99
                    For j As Integer = 0 To 99 - i
                        If String.Compare(tempBookingRecord(j).strBookingLastName, tempBookingRecord(j + 1).strBookingLastName) > 0 Then
                            Dim temp As Booking = tempBookingRecord(j)
                            tempBookingRecord(j) = tempBookingRecord(j + 1)
                            tempBookingRecord(j + 1) = temp
                        End If
                    Next
                Next

            Case "Last Name (Z-A)"
                For i As Integer = 0 To 99
                    For j As Integer = 0 To 99 - i
                        If String.Compare(tempBookingRecord(j).strBookingLastName, tempBookingRecord(j + 1).strBookingLastName) < 0 Then
                            Dim temp As Booking = tempBookingRecord(j)
                            tempBookingRecord(j) = tempBookingRecord(j + 1)
                            tempBookingRecord(j + 1) = temp
                        End If
                    Next
                Next

            Case "Price (Ascending)"
                For i As Integer = 0 To 99
                    For j As Integer = 0 To 99 - i
                        If tempBookingRecord(j).intTotal > tempBookingRecord(j + 1).intTotal Then
                            Dim temp As Booking = tempBookingRecord(j)
                            tempBookingRecord(j) = tempBookingRecord(j + 1)
                            tempBookingRecord(j + 1) = temp
                        End If
                    Next
                Next

            Case "Price (Descending)"
                For i As Integer = 0 To 99
                    For j As Integer = 0 To 99 - i
                        If tempBookingRecord(j).intTotal < tempBookingRecord(j + 1).intTotal Then
                            Dim temp As Booking = tempBookingRecord(j)
                            tempBookingRecord(j) = tempBookingRecord(j + 1)
                            tempBookingRecord(j + 1) = temp
                        End If
                    Next
                Next

        End Select
        Return tempBookingRecord
    End Function
End Module
