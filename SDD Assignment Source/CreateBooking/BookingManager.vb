Public Module BookingManager
    Public selectedSeats() As String

    Public Structure Booking
        Public intBookingID As Integer
        Public strBookingFirstName As String
        Public strBookingLastName As String
        Public strDOB As String
        Public arrSeatsBooked() As String
        Public strFilm As String
        Public intTotal As Integer 'Total cost of booking
    End Structure

    Public BookingRecord(100) As Booking
    Public intBookingCount As Integer = 1
    Public strSelectedFilm As String
    Public Function RemoveElementFromArray(arr As String(), element As String) As String()
        Dim index As Integer
        index = Array.IndexOf(arr, element)
        If index < 0 Then
            'The element doesn't exist in the array, so return the original array
            Return arr
        Else
            'The element exists in the array, so remove it
            Dim newArray() As String
            ReDim newArray(UBound(arr) - 1) 'The new array should be the one size less than the original because we are removing an element.
            Array.Copy(arr, 0, newArray, 0, index) 'Copy the lower half
            Array.Copy(arr, index + 1, newArray, index, UBound(arr) - index) 'Copy the upper half
            Return newArray
        End If
    End Function



    Public Function CalculateSeatCost(ByVal strSeat As String) As Integer

        Dim seatAsciiValue = Asc(strSeat(0)) 'Convert the first letter of the seat string to ascii, eg. "A1" would generate 65 because A = 65. 
        Dim asciiValueForA = 65 'A represents the seat row at the very back of the cinema, so this could be considered the "worst seat".
        Dim seatCost As Integer = (seatAsciiValue - asciiValueForA) * 2 + 20 'The closer we get to the cinema screen, the more expensive seats get. 

        'Seats will have a minimum price of $20, hence the + 20.
        'But every row that's closer to the TV screen, will increase seat price by $2.

        'The row at the very back is A, represented by an Ascii value of 65
        'So we subtract A's ascii value from the seat's (that we want to find the cost of) ascii value to find out how many rows infront of A the seat is.
        'We then multiply the difference by two so that each row closer to the screen will cost an additional $2. 

        Return seatCost
    End Function

    Public Function CalculateTotalSeatCost(ByVal seats As String()) As Integer
        Dim intTotal As Integer = 0
        For index = 0 To seats.Length - 1 'Loop through the seats array
            If Not String.IsNullOrEmpty(seats(index)) Then 'Check if the seat is empty (seats should never be empty but this is a safety measure)
                Dim seatPrice As Integer = 0
                seatPrice = CalculateSeatCost(seats(index)) 'Calculate the price of the seat
                intTotal += seatPrice 'Add it to the total
            End If
        Next

        Return intTotal
    End Function

    Public Sub ExitProgram() 'Procedure for exiting the program.
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you want to exit the program? All changes are automatically saved.", "Warning", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            End
        End If

    End Sub
End Module
