Imports BusTicketing.Utilities
Imports MySql.Data.MySqlClient

Public Class BookModel
    Inherits Utilities
    Dim utils As New Utilities

    Public Function makeBooking(ByVal Username As String, ByVal StartLocale As String,
                                ByVal DestLocale As String, ByVal Price As Integer,
                                ByVal deptTime As String) As Boolean
        Dim Success As Boolean
        Dim Query As String
        Try

            ConnectToDatabase()
            Query = "insert into Visual.booking_table(Username,StartLocale,DestinationLocale,Price,depature_time) values('" & Username & "', '" & StartLocale & "','" & DestLocale & "','" & Price & "','" & deptTime & "')"
            Command = New MySqlCommand(Query, Connection)
            Reader = Command.ExecuteReader
            'MessageBox.Show("User Added Success, Login With Credentials To Continue")
            Success = True

        Catch ex As Exception
            MessageBox.Show("Exception Inserting Booking Record" + ex.Message)
        Finally
            CloseConnection()
        End Try
        Return True
    End Function
End Class
