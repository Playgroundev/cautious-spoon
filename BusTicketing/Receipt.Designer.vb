<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Receipt
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtConfirmUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtConfirmFrom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtConfirmDestination = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPrice = New System.Windows.Forms.TextBox()
        Me.BtnFinish = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtDepatureTime = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtDepatureTime)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.BtnCancel)
        Me.GroupBox1.Controls.Add(Me.BtnFinish)
        Me.GroupBox1.Controls.Add(Me.TxtPrice)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtConfirmDestination)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtConfirmFrom)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtConfirmUsername)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(358, 327)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Comfirm Details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'TxtConfirmUsername
        '
        Me.TxtConfirmUsername.Location = New System.Drawing.Point(111, 42)
        Me.TxtConfirmUsername.Name = "TxtConfirmUsername"
        Me.TxtConfirmUsername.Size = New System.Drawing.Size(174, 22)
        Me.TxtConfirmUsername.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "From"
        '
        'TxtConfirmFrom
        '
        Me.TxtConfirmFrom.Location = New System.Drawing.Point(111, 94)
        Me.TxtConfirmFrom.Name = "TxtConfirmFrom"
        Me.TxtConfirmFrom.Size = New System.Drawing.Size(174, 22)
        Me.TxtConfirmFrom.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Destination"
        '
        'TxtConfirmDestination
        '
        Me.TxtConfirmDestination.Location = New System.Drawing.Point(111, 148)
        Me.TxtConfirmDestination.Name = "TxtConfirmDestination"
        Me.TxtConfirmDestination.Size = New System.Drawing.Size(174, 22)
        Me.TxtConfirmDestination.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Price"
        '
        'TxtPrice
        '
        Me.TxtPrice.Location = New System.Drawing.Point(111, 196)
        Me.TxtPrice.Name = "TxtPrice"
        Me.TxtPrice.Size = New System.Drawing.Size(102, 22)
        Me.TxtPrice.TabIndex = 7
        '
        'BtnFinish
        '
        Me.BtnFinish.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnFinish.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFinish.Location = New System.Drawing.Point(10, 289)
        Me.BtnFinish.Name = "BtnFinish"
        Me.BtnFinish.Size = New System.Drawing.Size(142, 32)
        Me.BtnFinish.TabIndex = 8
        Me.BtnFinish.Text = "Finish"
        Me.BtnFinish.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnCancel.Font = New System.Drawing.Font("Ubuntu", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnCancel.Location = New System.Drawing.Point(210, 289)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(142, 32)
        Me.BtnCancel.TabIndex = 9
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Depature"
        '
        'TxtDepatureTime
        '
        Me.TxtDepatureTime.Location = New System.Drawing.Point(111, 244)
        Me.TxtDepatureTime.Name = "TxtDepatureTime"
        Me.TxtDepatureTime.Size = New System.Drawing.Size(102, 22)
        Me.TxtDepatureTime.TabIndex = 11
        '
        'Receipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 352)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Receipt"
        Me.Text = "Receipt"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnFinish As Button
    Friend WithEvents TxtPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtConfirmDestination As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtConfirmFrom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtConfirmUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtDepatureTime As TextBox
    Friend WithEvents Label5 As Label
End Class
