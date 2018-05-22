Imports BusTicketing.BookModel
Imports BusTicketing.Utilities
Imports MySql.Data.MySqlClient

Public Class AdminConsole
    Dim baseModel As New BookModel
    Dim datSet As New DataTable
    Dim datSet2 As New DataTable
    Dim Utils As Utilities
    Private Sub AdminConsole_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        baseModel.PopulateTable(datSet, DataGridClients)
        baseModel.PopulateClientTable(datSet2, DtaClients)
    End Sub

    Private Sub ClientViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientViewToolStripMenuItem.Click
        Me.Hide()
        Booking.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        Dim Dv As New DataView(datSet)

        Dv.RowFilter = String.Format("Username Like '%{0}%'", TxtSearch.Text)
        DataGridClients.DataSource = Dv
    End Sub
End Class