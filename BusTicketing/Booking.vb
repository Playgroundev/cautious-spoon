Public Class Booking
    Private Sub Booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbDepature.Items.Add("05:00AM")
        CmbDepature.Items.Add("07:00AM")
        CmbDepature.Items.Add("11:00AM")
        CmbDepature.Items.Add("03:30PM")
        CmbDepature.Items.Add("05:00PM")
        CmbDepature.Items.Add("07:00PM")
    End Sub
End Class