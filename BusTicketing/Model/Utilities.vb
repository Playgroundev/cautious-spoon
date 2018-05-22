Imports MySql.Data.MySqlClient
Public Class Utilities
    Public Connection As MySqlConnection
    Public Command As MySqlCommand
    Public Reader As MySqlDataReader
    Public Counter As Integer = 0

    Public Function ConnectToDatabase() As Boolean
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
    Public Function Login(ByVal Username As String, ByVal Password As String) As Boolean
        Dim Success As Boolean = False
        Dim Query As String
        Command = New MySqlCommand
        Try
            ConnectToDatabase()
            Query = "select * from Visual.Users_Table where Username = '" & Username & "' AND Password = '" & Password & "' "
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
    Public Function RegisterUser(ByVal firstName As String, ByVal SecondName As String, ByVal Username As String, ByVal Password As String) As Boolean
        Dim Success As Boolean
        Dim Query As String
        Try
            ConnectToDatabase()
            Query = "insert into Visual.Users_Table(FirstName,SecondName,Username,Password) values('" & firstName & "', '" & SecondName & "','" & Username & "','" & Password & "')"
            Command = New MySqlCommand(Query, Connection)
            Reader = Command.ExecuteReader
            'MessageBox.Show("User Added Success, Login With Credentials To Continue")
            Success = True
        Catch ex As Exception
            MessageBox.Show("Error Processing Request, Please Try Again " + ex.Message)
            Success = False
        Finally
            CloseConnection()
        End Try
        Return Success
    End Function
    Public Function checkIfUserNameExist(ByVal Username As String) As Boolean
        Dim Found As Boolean = True
        Dim Query As String
        Try
            ConnectToDatabase()
            Query = "select * from Visual.Users_Table Where Username = '" & Username & "'"
            Command = New MySqlCommand(Query, Connection)
            Reader = Command.ExecuteReader
            While Reader.Read
                Counter = Counter + 1
            End While
            If Counter = 1 Then
                Found = True
            Else
                Found = False
            End If
        Catch ex As Exception
        Finally
            CloseConnection()
        End Try
        Return Found
    End Function
End Class
