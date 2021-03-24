<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lessons
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
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.LessonsLabel = New System.Windows.Forms.Label()
        Me.Lesson1Button = New System.Windows.Forms.Button()
        Me.Lesson2Button = New System.Windows.Forms.Button()
        Me.Lesson3Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'HomeButton
        '
        Me.HomeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.HomeButton.Location = New System.Drawing.Point(499, 330)
        Me.HomeButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(92, 32)
        Me.HomeButton.TabIndex = 0
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'LessonsLabel
        '
        Me.LessonsLabel.AutoSize = True
        Me.LessonsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.LessonsLabel.Location = New System.Drawing.Point(307, 9)
        Me.LessonsLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LessonsLabel.Name = "LessonsLabel"
        Me.LessonsLabel.Size = New System.Drawing.Size(103, 29)
        Me.LessonsLabel.TabIndex = 1
        Me.LessonsLabel.Text = "Lessons"
        '
        'Lesson1Button
        '
        Me.Lesson1Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Lesson1Button.Location = New System.Drawing.Point(106, 148)
        Me.Lesson1Button.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Lesson1Button.Name = "Lesson1Button"
        Me.Lesson1Button.Size = New System.Drawing.Size(92, 26)
        Me.Lesson1Button.TabIndex = 2
        Me.Lesson1Button.Text = "Lesson 1"
        Me.Lesson1Button.UseVisualStyleBackColor = True
        '
        'Lesson2Button
        '
        Me.Lesson2Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Lesson2Button.Location = New System.Drawing.Point(254, 148)
        Me.Lesson2Button.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Lesson2Button.Name = "Lesson2Button"
        Me.Lesson2Button.Size = New System.Drawing.Size(92, 26)
        Me.Lesson2Button.TabIndex = 3
        Me.Lesson2Button.Text = "Lesson 2"
        Me.Lesson2Button.UseVisualStyleBackColor = True
        '
        'Lesson3Button
        '
        Me.Lesson3Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Lesson3Button.Location = New System.Drawing.Point(402, 148)
        Me.Lesson3Button.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Lesson3Button.Name = "Lesson3Button"
        Me.Lesson3Button.Size = New System.Drawing.Size(92, 26)
        Me.Lesson3Button.TabIndex = 4
        Me.Lesson3Button.Text = "Lesson 3"
        Me.Lesson3Button.UseVisualStyleBackColor = True
        '
        'Lessons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 598)
        Me.Controls.Add(Me.Lesson3Button)
        Me.Controls.Add(Me.Lesson2Button)
        Me.Controls.Add(Me.Lesson1Button)
        Me.Controls.Add(Me.LessonsLabel)
        Me.Controls.Add(Me.HomeButton)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Lessons"
        Me.Text = "Lessons"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HomeButton As Button
    Friend WithEvents LessonsLabel As Label
    Friend WithEvents Lesson1Button As Button
    Friend WithEvents Lesson2Button As Button
    Friend WithEvents Lesson3Button As Button
End Class
