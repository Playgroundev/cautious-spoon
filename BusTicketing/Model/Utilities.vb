Imports MySql.Data.MySqlClient
Public Class Utilities
    Dim Connection As MySqlConnection
    Dim Command As MySqlCommand
    Dim Reader As MySqlDataReader
    Dim Counter As Integer = 0

    Public Function ConnectToDabase() As Boolean
        Dim Success As Boolean = False
        Try
            Connection = New MySqlConnection
            Connection.ConnectionString = "server=localhost;userid=root;password=wamatu;database=visual"
            Connection.Open()
            Success = True
        Catch ex As Exception
            MessageBox.Show("Exception Encountered Opening Connection" + ex.Message)
            Success = False
        End Try
        Return Success
    End Function
    Public Function CloseConnection() As Boolean
        Dim Success As Boolean = False
        Try
            Connection.Close()
            Success = True
        Catch ex As Exception
            Success = False
            MessageBox.Show("" + ex.Message())
        End Try
        Return Success
    End Function
    Function Login(ByVal Username As String, ByVal Password As String) As Boolean
        Dim Success As Boolean = False
        Dim Query As String
        Command = New MySqlCommand
        Try
            ConnectToDabase()
            Query = "select * from Visual.users where username = '" & Username & "' AND password = '" & Password & "' "
            Command = New MySqlCommand(Query, Connection)
            Reader = Command.ExecuteReader
            While Reader.Read
                Counter = Counter + 1
            End While
            If Counter = 1 Then
                Success = True
                Counter = 0
            Else
                Success = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Success = False
        Finally
            CloseConnection()
        End Try
        Return Success
    End Function
    Function RegisterUser(ByVal firstName As String, ByVal SeconName As String, ByVal Username As String, ByVal Password As String) As Boolean
        Try

        Catch ex As Exception

        End Try
        Return True
    End Function
End Class
