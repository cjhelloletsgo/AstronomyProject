﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.AstronoMeLabel = New System.Windows.Forms.Label()
        Me.QuizzesButton = New System.Windows.Forms.Button()
        Me.LessonsButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.passwordTextbox = New System.Windows.Forms.TextBox()
        Me.usernameTextbox = New System.Windows.Forms.TextBox()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.skip = New System.Windows.Forms.Button()
        Me.quitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AstronoMeLabel
        '
        Me.AstronoMeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AstronoMeLabel.BackColor = System.Drawing.Color.DarkSlateGray
        Me.AstronoMeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.0!)
        Me.AstronoMeLabel.ForeColor = System.Drawing.Color.White
        Me.AstronoMeLabel.Location = New System.Drawing.Point(403, 60)
        Me.AstronoMeLabel.Name = "AstronoMeLabel"
        Me.AstronoMeLabel.Size = New System.Drawing.Size(275, 60)
        Me.AstronoMeLabel.TabIndex = 3
        Me.AstronoMeLabel.Text = "AstronoMe"
        Me.AstronoMeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'QuizzesButton
        '
        Me.QuizzesButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.QuizzesButton.BackColor = System.Drawing.Color.DarkSlateGray
        Me.QuizzesButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.QuizzesButton.ForeColor = System.Drawing.Color.White
        Me.QuizzesButton.Location = New System.Drawing.Point(294, 621)
        Me.QuizzesButton.Margin = New System.Windows.Forms.Padding(0)
        Me.QuizzesButton.Name = "QuizzesButton"
        Me.QuizzesButton.Size = New System.Drawing.Size(205, 36)
        Me.QuizzesButton.TabIndex = 6
        Me.QuizzesButton.Text = "Quizzes"
        Me.QuizzesButton.UseVisualStyleBackColor = False
        '
        'LessonsButton
        '
        Me.LessonsButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LessonsButton.BackColor = System.Drawing.Color.DarkSlateGray
        Me.LessonsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LessonsButton.ForeColor = System.Drawing.Color.White
        Me.LessonsButton.Location = New System.Drawing.Point(581, 621)
        Me.LessonsButton.Name = "LessonsButton"
        Me.LessonsButton.Size = New System.Drawing.Size(205, 36)
        Me.LessonsButton.TabIndex = 7
        Me.LessonsButton.Text = "Lessons"
        Me.LessonsButton.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(629, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(205, 36)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Password"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(246, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(205, 36)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Username"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'passwordTextbox
        '
        Me.passwordTextbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.passwordTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.passwordTextbox.Location = New System.Drawing.Point(632, 317)
        Me.passwordTextbox.Name = "passwordTextbox"
        Me.passwordTextbox.Size = New System.Drawing.Size(205, 30)
        Me.passwordTextbox.TabIndex = 11
        '
        'usernameTextbox
        '
        Me.usernameTextbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.usernameTextbox.Location = New System.Drawing.Point(244, 317)
        Me.usernameTextbox.Name = "usernameTextbox"
        Me.usernameTextbox.Size = New System.Drawing.Size(205, 30)
        Me.usernameTextbox.TabIndex = 10
        '
        'LoginButton
        '
        Me.LoginButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LoginButton.BackColor = System.Drawing.Color.DarkSlateGray
        Me.LoginButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LoginButton.ForeColor = System.Drawing.Color.White
        Me.LoginButton.Location = New System.Drawing.Point(468, 394)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(149, 40)
        Me.LoginButton.TabIndex = 9
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = False
        '
        'skip
        '
        Me.skip.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.skip.Location = New System.Drawing.Point(461, 476)
        Me.skip.Name = "skip"
        Me.skip.Size = New System.Drawing.Size(75, 23)
        Me.skip.TabIndex = 14
        Me.skip.Text = "Skip"
        Me.skip.UseVisualStyleBackColor = True
        '
        'quitButton
        '
        Me.quitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.quitButton.BackColor = System.Drawing.Color.DarkSlateGray
        Me.quitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.quitButton.ForeColor = System.Drawing.Color.White
        Me.quitButton.Location = New System.Drawing.Point(910, 677)
        Me.quitButton.Name = "quitButton"
        Me.quitButton.Size = New System.Drawing.Size(158, 47)
        Me.quitButton.TabIndex = 17
        Me.quitButton.Text = "Quit"
        Me.quitButton.UseVisualStyleBackColor = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 736)
        Me.Controls.Add(Me.quitButton)
        Me.Controls.Add(Me.skip)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.passwordTextbox)
        Me.Controls.Add(Me.usernameTextbox)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.LessonsButton)
        Me.Controls.Add(Me.QuizzesButton)
        Me.Controls.Add(Me.AstronoMeLabel)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Home"
        Me.Text = "AstronoMe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AstronoMeLabel As Label
    Friend WithEvents QuizzesButton As Button
    Friend WithEvents LessonsButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents passwordTextbox As TextBox
    Friend WithEvents usernameTextbox As TextBox
    Friend WithEvents LoginButton As Button
    Friend WithEvents skip As Button
    Friend WithEvents quitButton As Button
End Class
