Module BookingManager
    Public selectedSeats() As String

    Structure Booking
        Public intBookingID As Integer
        Public strBookingFirstName As String
        Public strBookingLastName As String
        Public arrSeatsBooked() As String
        Public intTotal As Integer 'Total cost of booking
    End Structure

    Public BookingRecord(100) As Booking
    Public intBookingCount As Integer = 1
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
End Module
