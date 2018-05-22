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
        BtnConfirm.Enabled = False
    End Sub

    Private Sub BtnBook_Click(sender As Object, e As EventArgs) Handles BtnBook.Click
        Dim Destination, FromLocale As String
        Destination = TxtDestination.Text
        FromLocale = TxtFrom.Text
        Try
            If Destination = "" Then
                MessageBox.Show("Please Enter Your Destination")
                Return
            ElseIf FromLocale = "" Then
                MessageBox.Show("Please Enter Your From Location")
                Return
            ElseIf CmbDepature.SelectedItem.Equals("") Then
                MessageBox.Show("Please Select Your Depature Time")
                Return
            Else
                WebMaps.Navigate(mapsController.GenerateMaps(Destination))
                BtnConfirm.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error in Click, Rendering Maps" + ex.Message)
        End Try
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Close()
    End Sub

    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click
        Me.Hide()
        Receipt.Show()
    End Sub
    Public Function GetUsername() As String
        Return LblLogged.Text.ToString
    End Function
    Public Function GetDestination() As String
        Return TxtDestination.Text.ToString
    End Function
    Public Function GetFrom() As String
        Return TxtFrom.Text.ToString
    End Function
    Public Function GetDepatureTime() As String
        Return CmbDepature.SelectedItem.ToString
    End Function
End Class