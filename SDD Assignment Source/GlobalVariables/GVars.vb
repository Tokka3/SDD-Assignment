Module GVars

    Public strFirstName As String 'First name and last name for the booking that's actively being created.
    Public strLastName As String

    Public BookingToEdit As Booking 'Global variable for the booking that's being edited.
    Public idxBookingToEdit As Integer 'Global variable for the index of the booking that's being edited.
    Public bEditMode As Boolean 'Global Variable for editing a records seats, used in CreateBookings.vb and EditBookings.vb
    Public bFilmChanged As Boolean 'If the film is changed during edit mode, this is set to true
End Module
