<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quizzes
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
        Me.ShootingStarsButton = New System.Windows.Forms.Button()
        Me.QuizzesLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'HomeButton
        '
        Me.HomeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.HomeButton.Location = New System.Drawing.Point(682, 392)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(106, 46)
        Me.HomeButton.TabIndex = 0
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'ShootingStarsButton
        '
        Me.ShootingStarsButton.Location = New System.Drawing.Point(332, 234)
        Me.ShootingStarsButton.Name = "ShootingStarsButton"
        Me.ShootingStarsButton.Size = New System.Drawing.Size(121, 36)
        Me.ShootingStarsButton.TabIndex = 1
        Me.ShootingStarsButton.Text = "Shooting Stars"
        Me.ShootingStarsButton.UseVisualStyleBackColor = True
        '
        'QuizzesLabel
        '
        Me.QuizzesLabel.AutoSize = True
        Me.QuizzesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.QuizzesLabel.Location = New System.Drawing.Point(331, 22)
        Me.QuizzesLabel.Name = "QuizzesLabel"
        Me.QuizzesLabel.Size = New System.Drawing.Size(122, 36)
        Me.QuizzesLabel.TabIndex = 2
        Me.QuizzesLabel.Text = "Quizzes"
        '
        'Quizzes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.QuizzesLabel)
        Me.Controls.Add(Me.ShootingStarsButton)
        Me.Controls.Add(Me.HomeButton)
        Me.Name = "Quizzes"
        Me.Text = "Quizzes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HomeButton As Button
    Friend WithEvents ShootingStarsButton As Button
    Friend WithEvents QuizzesLabel As Label
End Class
