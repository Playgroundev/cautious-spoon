Imports BusTicketing.PriceController
Imports BusTicketing.BookModel
Public Class Receipt
    Dim priceC As New PriceController
    Dim baseModel As New BookModel
    Private Sub Receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Price As Integer
        Try
            TxtConfirmDestination.Text = Booking.GetDestination()
            TxtConfirmFrom.Text = Booking.GetFrom()
            TxtDepatureTime.Text = Booking.GetDepatureTime()
            TxtConfirmUsername.Text = Booking.GetUsername()
            Price = priceC.GeneratePrice()
            TxtPrice.Text = Price
        Catch ex As Exception
            MessageBox.Show("Error Loading" + ex.Message)
        End Try
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Hide()
        Booking.Show()
    End Sub
    Private Sub BtnFinish_Click(sender As Object, e As EventArgs) Handles BtnFinish.Click
        Dim Username, Destination, StartLocale, deptime As String
        Dim Cost As Integer
        Try
            Username = TxtConfirmUsername.Text
            StartLocale = TxtConfirmFrom.Text
            Destination = TxtConfirmDestination.Text
            deptime = TxtDepatureTime.Text
            Cost = Val(TxtPrice.Text)
            If baseModel.makeBooking(Username, StartLocale, Destination, Cost, deptime) = True Then
                MessageBox.Show("Bus Booked Success")
                Close()

            Else
                MessageBox.Show("Error Processing Booking Request")
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class