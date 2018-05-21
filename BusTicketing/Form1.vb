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
    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Dim fname, lname, Username, Password, PswdConfirm As String
        fname = TxtFirstName.Text
        lname = TxtSecondName.Text
        Username = TxtUserN.Text
        Password = TxtPasswordN.Text
        PswdConfirm = TxtConfirmPassword.Text
        Try
            If fname = "" Then
                MessageBox.Show("Please Enter First Name")
                Return
            ElseIf lname = "" Then
                MessageBox.Show("Please Enter Second Name")
                Return
            ElseIf Username = "" Then
                MessageBox.Show("Please Enter Username to Continue")
                Return
            ElseIf Password = "" Then
                MessageBox.Show("Please Enter Password To Continue")
                Return
            ElseIf PswdConfirm = "" Then
                MessageBox.Show("Please Confirm Your Password To Continue")
                Return
            ElseIf Password <> PswdConfirm Then
                MessageBox.Show("Your Passwords Do NOT Match, Please Try Again To Continue")
                Return
            ElseIf Model.checkIfUserNameExist(Username) = True Then
                MessageBox.Show("Username Already Taken Please Try Another Username")
                TxtUsername.Text = ""
                Return
            Else
                Model.RegisterUser(fname, lname, Username, Password)
                MessageBox.Show("User '" & Username & "' Added Successfully")
            End If
        Catch ex As Exception
            MessageBox.Show("Error Processing Request" + ex.Message)
        End Try
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class
