<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.MultipleChoiceButton = New System.Windows.Forms.Button()
        Me.Chapter2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'HomeButton
        '
        Me.HomeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.HomeButton.Location = New System.Drawing.Point(961, 679)
        Me.HomeButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(107, 46)
        Me.HomeButton.TabIndex = 0
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'ShootingStarsButton
        '
        Me.ShootingStarsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ShootingStarsButton.Location = New System.Drawing.Point(617, 466)
        Me.ShootingStarsButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ShootingStarsButton.Name = "ShootingStarsButton"
        Me.ShootingStarsButton.Size = New System.Drawing.Size(185, 38)
        Me.ShootingStarsButton.TabIndex = 1
        Me.ShootingStarsButton.Text = "Shooting Stars"
        Me.ShootingStarsButton.UseVisualStyleBackColor = True
        '
        'QuizzesLabel
        '
        Me.QuizzesLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.QuizzesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.0!)
        Me.QuizzesLabel.Location = New System.Drawing.Point(412, 28)
        Me.QuizzesLabel.Name = "QuizzesLabel"
        Me.QuizzesLabel.Size = New System.Drawing.Size(257, 52)
        Me.QuizzesLabel.TabIndex = 2
        Me.QuizzesLabel.Text = "Quizzes"
        Me.QuizzesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MultipleChoiceButton
        '
        Me.MultipleChoiceButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.MultipleChoiceButton.Location = New System.Drawing.Point(279, 466)
        Me.MultipleChoiceButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MultipleChoiceButton.Name = "MultipleChoiceButton"
        Me.MultipleChoiceButton.Size = New System.Drawing.Size(185, 38)
        Me.MultipleChoiceButton.TabIndex = 3
        Me.MultipleChoiceButton.Text = "Multiple Choice"
        Me.MultipleChoiceButton.UseVisualStyleBackColor = True
        '
        'Chapter2
        '
        Me.Chapter2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Chapter2.Location = New System.Drawing.Point(617, 508)
        Me.Chapter2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Chapter2.Name = "Chapter2"
        Me.Chapter2.Size = New System.Drawing.Size(185, 38)
        Me.Chapter2.TabIndex = 4
        Me.Chapter2.Text = "Chapter 2"
        Me.Chapter2.UseVisualStyleBackColor = True
        '
        'Quizzes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 736)
        Me.Controls.Add(Me.Chapter2)
        Me.Controls.Add(Me.MultipleChoiceButton)
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
    Friend WithEvents MultipleChoiceButton As Button
    Friend WithEvents Chapter2 As Button
End Class
