Public Class PriceController

    Public Function GeneratePrice() As Integer
        Dim RandomPrice As Integer
        Try
            RandomPrice = CInt(Math.Ceiling(Rnd() * 500)) + 1
        Catch ex As Exception
            MessageBox.Show("Exception Generating Price " + ex.Message)
        End Try
        Return RandomPrice
    End Function
    Public Function GeneratePriceTest() As Integer
        Return 2500
    End Function
End Class
