<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.TabLogin = New System.Windows.Forms.TabControl()
        Me.TabLog = New System.Windows.Forms.TabPage()
        Me.ChkPassword = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabRegister = New System.Windows.Forms.TabPage()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnRegister = New System.Windows.Forms.Button()
        Me.TxtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtPasswordN = New System.Windows.Forms.TextBox()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.TxtUserN = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtSecondName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtFirstName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabLogin.SuspendLayout()
        Me.TabLog.SuspendLayout()
        Me.TabRegister.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabLogin
        '
        Me.TabLogin.Controls.Add(Me.TabLog)
        Me.TabLogin.Controls.Add(Me.TabRegister)
        Me.TabLogin.Location = New System.Drawing.Point(12, 12)
        Me.TabLogin.Name = "TabLogin"
        Me.TabLogin.SelectedIndex = 0
        Me.TabLogin.Size = New System.Drawing.Size(362, 296)
        Me.TabLogin.TabIndex = 0
        '
        'TabLog
        '
        Me.TabLog.BackgroundImage = CType(resources.GetObject("TabLog.BackgroundImage"), System.Drawing.Image)
        Me.TabLog.Controls.Add(Me.ChkPassword)
        Me.TabLog.Controls.Add(Me.Button2)
        Me.TabLog.Controls.Add(Me.Button1)
        Me.TabLog.Controls.Add(Me.TxtPassword)
        Me.TabLog.Controls.Add(Me.Label2)
        Me.TabLog.Controls.Add(Me.TxtUsername)
        Me.TabLog.Controls.Add(Me.Label1)
        Me.TabLog.Location = New System.Drawing.Point(4, 22)
        Me.TabLog.Name = "TabLog"
        Me.TabLog.Padding = New System.Windows.Forms.Padding(3)
        Me.TabLog.Size = New System.Drawing.Size(354, 270)
        Me.TabLog.TabIndex = 0
        Me.TabLog.Text = "Login"
        Me.TabLog.UseVisualStyleBackColor = True
        '
        'ChkPassword
        '
        Me.ChkPassword.AutoSize = True
        Me.ChkPassword.Location = New System.Drawing.Point(68, 103)
        Me.ChkPassword.Name = "ChkPassword"
        Me.ChkPassword.Size = New System.Drawing.Size(102, 17)
        Me.ChkPassword.TabIndex = 6
        Me.ChkPassword.Text = "Show Password"
        Me.ChkPassword.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(156, 153)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "EXIT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(68, 153)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "LOGIN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(68, 66)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(163, 20)
        Me.TxtPassword.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(68, 20)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(163, 20)
        Me.TxtUsername.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'TabRegister
        '
        Me.TabRegister.BackgroundImage = CType(resources.GetObject("TabRegister.BackgroundImage"), System.Drawing.Image)
        Me.TabRegister.Controls.Add(Me.BtnExit)
        Me.TabRegister.Controls.Add(Me.BtnRegister)
        Me.TabRegister.Controls.Add(Me.TxtConfirmPassword)
        Me.TabRegister.Controls.Add(Me.Label6)
        Me.TabRegister.Controls.Add(Me.TxtPasswordN)
        Me.TabRegister.Controls.Add(Me.LblPassword)
        Me.TabRegister.Controls.Add(Me.TxtUserN)
        Me.TabRegister.Controls.Add(Me.Label5)
        Me.TabRegister.Controls.Add(Me.TxtSecondName)
        Me.TabRegister.Controls.Add(Me.Label4)
        Me.TabRegister.Controls.Add(Me.TxtFirstName)
        Me.TabRegister.Controls.Add(Me.Label3)
        Me.TabRegister.Location = New System.Drawing.Point(4, 22)
        Me.TabRegister.Name = "TabRegister"
        Me.TabRegister.Padding = New System.Windows.Forms.Padding(3)
        Me.TabRegister.Size = New System.Drawing.Size(354, 270)
        Me.TabRegister.TabIndex = 1
        Me.TabRegister.Text = "Register"
        Me.TabRegister.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(200, 239)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 11
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnRegister
        '
        Me.BtnRegister.Location = New System.Drawing.Point(103, 239)
        Me.BtnRegister.Name = "BtnRegister"
        Me.BtnRegister.Size = New System.Drawing.Size(75, 23)
        Me.BtnRegister.TabIndex = 10
        Me.BtnRegister.Text = "Register"
        Me.BtnRegister.UseVisualStyleBackColor = True
        '
        'TxtConfirmPassword
        '
        Me.TxtConfirmPassword.Location = New System.Drawing.Point(103, 201)
        Me.TxtConfirmPassword.Name = "TxtConfirmPassword"
        Me.TxtConfirmPassword.Size = New System.Drawing.Size(172, 20)
        Me.TxtConfirmPassword.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Confirm Password"
        '
        'TxtPasswordN
        '
        Me.TxtPasswordN.Location = New System.Drawing.Point(103, 156)
        Me.TxtPasswordN.Name = "TxtPasswordN"
        Me.TxtPasswordN.Size = New System.Drawing.Size(172, 20)
        Me.TxtPasswordN.TabIndex = 7
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Location = New System.Drawing.Point(7, 159)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(53, 13)
        Me.LblPassword.TabIndex = 6
        Me.LblPassword.Text = "Password"
        '
        'TxtUserN
        '
        Me.TxtUserN.Location = New System.Drawing.Point(103, 112)
        Me.TxtUserN.Name = "TxtUserN"
        Me.TxtUserN.Size = New System.Drawing.Size(172, 20)
        Me.TxtUserN.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Username"
        '
        'TxtSecondName
        '
        Me.TxtSecondName.Location = New System.Drawing.Point(103, 63)
        Me.TxtSecondName.Name = "TxtSecondName"
        Me.TxtSecondName.Size = New System.Drawing.Size(172, 20)
        Me.TxtSecondName.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Second Name"
        '
        'TxtFirstName
        '
        Me.TxtFirstName.Location = New System.Drawing.Point(103, 14)
        Me.TxtFirstName.Name = "TxtFirstName"
        Me.TxtFirstName.Size = New System.Drawing.Size(172, 20)
        Me.TxtFirstName.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "First Name"
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 321)
        Me.Controls.Add(Me.TabLogin)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmLogin"
        Me.Text = "Bus Ticketing"
        Me.TabLogin.ResumeLayout(False)
        Me.TabLog.ResumeLayout(False)
        Me.TabLog.PerformLayout()
        Me.TabRegister.ResumeLayout(False)
        Me.TabRegister.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabLogin As TabControl
    Friend WithEvents TabLog As TabPage
    Friend WithEvents TabRegister As TabPage
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ChkPassword As CheckBox
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnRegister As Button
    Friend WithEvents TxtConfirmPassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtPasswordN As TextBox
    Friend WithEvents LblPassword As Label
    Friend WithEvents TxtUserN As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtSecondName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtFirstName As TextBox
    Friend WithEvents Label3 As Label
End Class
