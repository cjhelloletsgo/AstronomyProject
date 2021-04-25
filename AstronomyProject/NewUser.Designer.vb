<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewUser))
        Me.EnterButton = New System.Windows.Forms.Button()
        Me.StudentIDLabel = New System.Windows.Forms.Label()
        Me.StudentIdTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.passwordTextbox = New System.Windows.Forms.TextBox()
        Me.usernameTextbox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'EnterButton
        '
        Me.EnterButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.EnterButton.BackColor = System.Drawing.Color.DarkSlateGray
        Me.EnterButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.EnterButton.ForeColor = System.Drawing.Color.White
        Me.EnterButton.Location = New System.Drawing.Point(346, 228)
        Me.EnterButton.Margin = New System.Windows.Forms.Padding(2)
        Me.EnterButton.Name = "EnterButton"
        Me.EnterButton.Size = New System.Drawing.Size(112, 33)
        Me.EnterButton.TabIndex = 22
        Me.EnterButton.Text = "Enter"
        Me.EnterButton.UseVisualStyleBackColor = False
        '
        'StudentIDLabel
        '
        Me.StudentIDLabel.BackColor = System.Drawing.Color.DarkSlateGray
        Me.StudentIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.StudentIDLabel.ForeColor = System.Drawing.Color.White
        Me.StudentIDLabel.Location = New System.Drawing.Point(113, 121)
        Me.StudentIDLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.StudentIDLabel.Name = "StudentIDLabel"
        Me.StudentIDLabel.Size = New System.Drawing.Size(154, 29)
        Me.StudentIDLabel.TabIndex = 29
        Me.StudentIDLabel.Text = "Student ID"
        Me.StudentIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StudentIdTextBox
        '
        Me.StudentIdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.StudentIdTextBox.Location = New System.Drawing.Point(112, 177)
        Me.StudentIdTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.StudentIdTextBox.Name = "StudentIdTextBox"
        Me.StudentIdTextBox.Size = New System.Drawing.Size(155, 26)
        Me.StudentIdTextBox.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(533, 121)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 29)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Password"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(323, 121)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 29)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Username"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'passwordTextbox
        '
        Me.passwordTextbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.passwordTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.passwordTextbox.Location = New System.Drawing.Point(532, 177)
        Me.passwordTextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.passwordTextbox.Name = "passwordTextbox"
        Me.passwordTextbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordTextbox.Size = New System.Drawing.Size(155, 26)
        Me.passwordTextbox.TabIndex = 25
        '
        'usernameTextbox
        '
        Me.usernameTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.usernameTextbox.Location = New System.Drawing.Point(322, 177)
        Me.usernameTextbox.Margin = New System.Windows.Forms.Padding(2)
        Me.usernameTextbox.Name = "usernameTextbox"
        Me.usernameTextbox.Size = New System.Drawing.Size(155, 26)
        Me.usernameTextbox.TabIndex = 24
        '
        'NewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StudentIDLabel)
        Me.Controls.Add(Me.StudentIdTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.passwordTextbox)
        Me.Controls.Add(Me.usernameTextbox)
        Me.Controls.Add(Me.EnterButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NewUser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EnterButton As Button
    Friend WithEvents StudentIDLabel As Label
    Friend WithEvents StudentIdTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents passwordTextbox As TextBox
    Friend WithEvents usernameTextbox As TextBox
End Class
