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
        Me.TabRegister = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ChkPassword = New System.Windows.Forms.CheckBox()
        Me.TabLogin.SuspendLayout()
        Me.TabLog.SuspendLayout()
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
        'TabRegister
        '
        Me.TabRegister.Location = New System.Drawing.Point(4, 22)
        Me.TabRegister.Name = "TabRegister"
        Me.TabRegister.Padding = New System.Windows.Forms.Padding(3)
        Me.TabRegister.Size = New System.Drawing.Size(354, 270)
        Me.TabRegister.TabIndex = 1
        Me.TabRegister.Text = "Register"
        Me.TabRegister.UseVisualStyleBackColor = True
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
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(68, 20)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(163, 20)
        Me.TxtUsername.TabIndex = 1
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
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(68, 66)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(163, 20)
        Me.TxtPassword.TabIndex = 3
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
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(156, 153)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "EXIT"
        Me.Button2.UseVisualStyleBackColor = True
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
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 320)
        Me.Controls.Add(Me.TabLogin)
        Me.Name = "FrmLogin"
        Me.Text = "Bus Ticketing"
        Me.TabLogin.ResumeLayout(False)
        Me.TabLog.ResumeLayout(False)
        Me.TabLog.PerformLayout()
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
End Class
