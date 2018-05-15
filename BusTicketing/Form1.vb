Imports BusTicketing.Utilities
Public Class FrmLogin
    Dim Model As New Utilities

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Username As String
        Username = TxtUsername.Text
        Dim Password As String
        Password = TxtPassword.Text
        Try
            If Username = "" Then
                MessageBox.Show("Enter Username")
                Return
            ElseIf Password = "" Then
                MessageBox.Show("Enter Password")
                Return
            ElseIf (Model.Login(Username, Password) = True) Then
                MessageBox.Show("Correct Credentials")

            Else
                    MessageBox.Show("InCorrect Credentials")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (ChkPassword.Checked = False) Then
            ' TxtPassword.
        End If
    End Sub
End Class
