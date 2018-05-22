Imports BusTicketing.MapsController
Public Class Booking
    Dim mapsController As New MapsController
    Dim Price As Double
    Private Sub Booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbDepature.Items.Add("05:00AM")
        CmbDepature.Items.Add("07:00AM")
        CmbDepature.Items.Add("11:00AM")
        CmbDepature.Items.Add("03:30PM")
        CmbDepature.Items.Add("05:00PM")
        CmbDepature.Items.Add("07:00PM")
        LblLogged.Text = FrmLogin.TxtUsername.Text
    End Sub

    Private Sub BtnBook_Click(sender As Object, e As EventArgs) Handles BtnBook.Click
        Dim Destination, FromLocale As String
        Destination = TxtDestination.Text
        FromLocale = TxtFrom.Text
        Try

            WebMaps.Navigate(mapsController.GenerateMaps(Destination))

            'MessageBox.Show("Please Enter All Required Fields")


        Catch ex As Exception
            MessageBox.Show("Error in Click, Rendering Maps" + ex.Message)
        End Try
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Close()
    End Sub
End Class