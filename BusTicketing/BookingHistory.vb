Imports BusTicketing.BookModel
Imports BusTicketing.Booking
Public Class BookingHistory

    Dim booker As BookModel
    ' Dim bookingView As Booking
    Dim Username As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub BookingHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Username = Booking.GetUsername()
        booker.PopulateHistory(DataGridHistory, "admin")
    End Sub
End Class