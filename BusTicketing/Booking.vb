Imports BusTicketing.MapsController
Public Class Booking
    Dim mapsController As New MapsController
    Private Sub Booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbDepature.Items.Add("05:00AM")
        CmbDepature.Items.Add("07:00AM")
        CmbDepature.Items.Add("11:00AM")
        CmbDepature.Items.Add("03:30PM")
        CmbDepature.Items.Add("05:00PM")
        CmbDepature.Items.Add("07:00PM")
    End Sub

    Private Sub BtnBook_Click(sender As Object, e As EventArgs) Handles BtnBook.Click
        Dim Destination As String
        Destination = TxtDestination.Text
        Try
            WebMaps.Navigate(mapsController.GenerateMaps(Destination))
        Catch ex As Exception
            MessageBox.Show("Error in Click, Rendering Maps" + ex.Message)
        End Try
    End Sub
End Class