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
            ' The element doesn't exist in the array, so return the original array
            Return arr
        Else
            ' The element exists in the array, so remove it
            Dim newArray() As String
            ReDim newArray(UBound(arr) - 1)
            Array.Copy(arr, 0, newArray, 0, index)
            Array.Copy(arr, index + 1, newArray, index, UBound(arr) - index)
            Return newArray
        End If
    End Function

    Public Function CalculateSeatCost(ByVal strSeat As String) As Integer
        Dim seatAsciiValue = Asc(strSeat(0))
        Dim asciiValueForA = 65

        Dim seatCost As Integer = (seatAsciiValue - asciiValueForA) * 2 + 20
        'Seats will have a minimum price of $20, hence the + 20.
        'But every row that's closer to the TV screen, will increase seat price by $2.

        'The row at the very back is A, represented by an Ascii value of 65
        'So we subtract A's ascii value from the seat's (that we want to find the cost of) ascii value to find out how many rows infront of A the seat is.
        'We then multiply the difference by two so that each row closer to the screen will cost an additional $2. 

        Return seatCost
    End Function

    Public Function CalculateTotalSeatCost(ByVal seats As String()) As Integer
        Dim intTotal As Integer = 0
        For index = 0 To seats.Length - 1

            If Not String.IsNullOrEmpty(seats(index)) Then

                Dim seatPrice As Integer = 0

                seatPrice = CalculateSeatCost(seats(index))

                intTotal += seatPrice

            End If

        Next

        Return intTotal
    End Function
End Module
