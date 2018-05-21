Imports System.Text
Public Class MapsController
    Dim WebQuery As New StringBuilder
    Public Function GenerateMaps(ByVal Destination As String) As String
        Try
            WebQuery.Append("http://maps.google.com/maps?q=")
            If Destination <> String.Empty Then
                WebQuery.Append(Destination + "," & "+")
            Else
                MessageBox.Show("Destination Cannot be Empty")
            End If
        Catch ex As Exception
            MessageBox.Show("Error Rendering Your Destination " + ex.Message)
        End Try
        Return WebQuery.ToString
    End Function
End Class
