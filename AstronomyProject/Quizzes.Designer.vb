﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Quizzes
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
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.ShootingStarsButton = New System.Windows.Forms.Button()
        Me.QuizzesLabel = New System.Windows.Forms.Label()
        Me.Chapter2 = New System.Windows.Forms.Button()
        Me.Chapter3 = New System.Windows.Forms.Button()
        Me.quitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'HomeButton
        '
        Me.HomeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.HomeButton.BackColor = System.Drawing.Color.DarkSlateGray
        Me.HomeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.HomeButton.ForeColor = System.Drawing.Color.White
        Me.HomeButton.Location = New System.Drawing.Point(12, 796)
        Me.HomeButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(157, 47)
        Me.HomeButton.TabIndex = 0
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseVisualStyleBackColor = False
        '
        'ShootingStarsButton
        '
        Me.ShootingStarsButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ShootingStarsButton.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ShootingStarsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ShootingStarsButton.ForeColor = System.Drawing.Color.White
        Me.ShootingStarsButton.Location = New System.Drawing.Point(446, 211)
        Me.ShootingStarsButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ShootingStarsButton.Name = "ShootingStarsButton"
        Me.ShootingStarsButton.Size = New System.Drawing.Size(226, 75)
        Me.ShootingStarsButton.TabIndex = 1
        Me.ShootingStarsButton.Text = "Chapter 1"
        Me.ShootingStarsButton.UseVisualStyleBackColor = False
        '
        'QuizzesLabel
        '
        Me.QuizzesLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.QuizzesLabel.BackColor = System.Drawing.Color.DarkSlateGray
        Me.QuizzesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.0!)
        Me.QuizzesLabel.ForeColor = System.Drawing.Color.White
        Me.QuizzesLabel.Location = New System.Drawing.Point(705, 60)
        Me.QuizzesLabel.Name = "QuizzesLabel"
        Me.QuizzesLabel.Size = New System.Drawing.Size(275, 60)
        Me.QuizzesLabel.TabIndex = 2
        Me.QuizzesLabel.Text = "Quizzes"
        Me.QuizzesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Chapter2
        '
        Me.Chapter2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chapter2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Chapter2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Chapter2.ForeColor = System.Drawing.Color.White
        Me.Chapter2.Location = New System.Drawing.Point(729, 211)
        Me.Chapter2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Chapter2.Name = "Chapter2"
        Me.Chapter2.Size = New System.Drawing.Size(226, 75)
        Me.Chapter2.TabIndex = 4
        Me.Chapter2.Text = "Chapter 2"
        Me.Chapter2.UseVisualStyleBackColor = False
        '
        'Chapter3
        '
        Me.Chapter3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chapter3.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Chapter3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Chapter3.ForeColor = System.Drawing.Color.White
        Me.Chapter3.Location = New System.Drawing.Point(1013, 211)
        Me.Chapter3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Chapter3.Name = "Chapter3"
        Me.Chapter3.Size = New System.Drawing.Size(226, 75)
        Me.Chapter3.TabIndex = 5
        Me.Chapter3.Text = "Chapter 3"
        Me.Chapter3.UseVisualStyleBackColor = False
        '
        'quitButton
        '
        Me.quitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.quitButton.BackColor = System.Drawing.Color.DarkSlateGray
        Me.quitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.quitButton.ForeColor = System.Drawing.Color.White
        Me.quitButton.Location = New System.Drawing.Point(1515, 796)
        Me.quitButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.quitButton.Name = "quitButton"
        Me.quitButton.Size = New System.Drawing.Size(157, 47)
        Me.quitButton.TabIndex = 17
        Me.quitButton.Text = "Quit"
        Me.quitButton.UseVisualStyleBackColor = False
        '
        'Quizzes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1685, 855)
        Me.Controls.Add(Me.quitButton)
        Me.Controls.Add(Me.Chapter3)
        Me.Controls.Add(Me.Chapter2)
        Me.Controls.Add(Me.QuizzesLabel)
        Me.Controls.Add(Me.ShootingStarsButton)
        Me.Controls.Add(Me.HomeButton)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Quizzes"
        Me.Text = "Quizzes"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HomeButton As Button
    Friend WithEvents ShootingStarsButton As Button
    Friend WithEvents QuizzesLabel As Label
    Friend WithEvents Chapter2 As Button
    Friend WithEvents Chapter3 As Button
    Friend WithEvents quitButton As Button
End Class
