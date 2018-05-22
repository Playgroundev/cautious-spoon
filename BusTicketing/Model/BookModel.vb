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
    Public Function PopulateTable(ByVal dataSet As DataTable, ByVal GridTable As DataGridView)
        Dim adapter As New MySqlDataAdapter
        ' Dim dataSet As New DataTable
        Dim bSource As New BindingSource
        Dim Query As String
        Try
            ConnectToDatabase()
            Query = "select * from visual.booking_table"
            Command = New MySqlCommand(Query, Connection)
            adapter.SelectCommand = Command
            adapter.Fill(dataSet)
            bSource.DataSource = dataSet
            GridTable.DataSource = bSource
            adapter.Update(dataSet)
        Catch ex As Exception
            MessageBox.Show("Error Populating Table: " + ex.Message)
        Finally
            CloseConnection()
        End Try
        Return Nothing
    End Function
    Public Function PopulateClientTable(ByVal dataSet As DataTable, ByVal GridTable As DataGridView)
        Dim adapter As New MySqlDataAdapter
        ' Dim dataSet As New DataTable
        Dim bSource As New BindingSource
        Dim Query As String
        Try
            ConnectToDatabase()
            Query = "select * from visual.users_table"
            Command = New MySqlCommand(Query, Connection)
            adapter.SelectCommand = Command
            adapter.Fill(dataSet)
            bSource.DataSource = dataSet
            GridTable.DataSource = bSource
            adapter.Update(dataSet)
        Catch ex As Exception
            MessageBox.Show("Exception Populating Client Table" + ex.Message)
        Finally
            CloseConnection()
        End Try
        Return Nothing
    End Function
    Public Function PopulateHistory(ByVal GridTable As DataGridView, ByVal Username As String)
        Dim adapter As New MySqlDataAdapter
        Dim dataSet As New DataTable
        Dim bSource As New BindingSource
        Command = New MySqlCommand

        Dim Query As String
        Try
            ConnectToDatabase()
            Query = "select * from Visual.Users_Table where Username = '" & Username & "'"
            Command = New MySqlCommand(Query, Connection)
            Reader = Command.ExecuteReader
            If Reader.Read Then
                adapter.SelectCommand = Command
                adapter.Fill(dataSet)
                bSource.DataSource = dataSet
                GridTable.DataSource = bSource
                adapter.Update(dataSet)
            Else
                MessageBox.Show("No Records Found")
            End If
        Catch ex As Exception
            MessageBox.Show("Error Rendering History")
        Finally
            CloseConnection()
        End Try
        Return Nothing
    End Function
End Class
