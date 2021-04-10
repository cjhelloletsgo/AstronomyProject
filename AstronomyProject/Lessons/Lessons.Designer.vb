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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lessons))
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.LessonsLabel = New System.Windows.Forms.Label()
        Me.Lesson1Button = New System.Windows.Forms.Button()
        Me.Lesson2Button = New System.Windows.Forms.Button()
        Me.Lesson3Button = New System.Windows.Forms.Button()
        Me.quitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'HomeButton
        '
        Me.HomeButton.BackColor = System.Drawing.Color.DarkSlateGray
        Me.HomeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.HomeButton.ForeColor = System.Drawing.Color.White
        Me.HomeButton.Location = New System.Drawing.Point(15, 795)
        Me.HomeButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(157, 47)
        Me.HomeButton.TabIndex = 0
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseVisualStyleBackColor = False
        '
        'LessonsLabel
        '
        Me.LessonsLabel.BackColor = System.Drawing.Color.DarkSlateGray
        Me.LessonsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.0!)
        Me.LessonsLabel.ForeColor = System.Drawing.Color.White
        Me.LessonsLabel.Location = New System.Drawing.Point(-8, -1)
        Me.LessonsLabel.Name = "LessonsLabel"
        Me.LessonsLabel.Size = New System.Drawing.Size(1703, 60)
        Me.LessonsLabel.TabIndex = 1
        Me.LessonsLabel.Text = "Lessons"
        Me.LessonsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lesson1Button
        '
        Me.Lesson1Button.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Lesson1Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lesson1Button.ForeColor = System.Drawing.Color.White
        Me.Lesson1Button.Location = New System.Drawing.Point(283, 305)
        Me.Lesson1Button.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Lesson1Button.Name = "Lesson1Button"
        Me.Lesson1Button.Size = New System.Drawing.Size(315, 44)
        Me.Lesson1Button.TabIndex = 2
        Me.Lesson1Button.Text = "Lesson 1: The Inner Ring"
        Me.Lesson1Button.UseVisualStyleBackColor = False
        '
        'Lesson2Button
        '
        Me.Lesson2Button.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Lesson2Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lesson2Button.ForeColor = System.Drawing.Color.White
        Me.Lesson2Button.Location = New System.Drawing.Point(692, 305)
        Me.Lesson2Button.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Lesson2Button.Name = "Lesson2Button"
        Me.Lesson2Button.Size = New System.Drawing.Size(315, 44)
        Me.Lesson2Button.TabIndex = 3
        Me.Lesson2Button.Text = "Lesson 2: The Gas Giants"
        Me.Lesson2Button.UseVisualStyleBackColor = False
        '
        'Lesson3Button
        '
        Me.Lesson3Button.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Lesson3Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lesson3Button.ForeColor = System.Drawing.Color.White
        Me.Lesson3Button.Location = New System.Drawing.Point(1095, 305)
        Me.Lesson3Button.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Lesson3Button.Name = "Lesson3Button"
        Me.Lesson3Button.Size = New System.Drawing.Size(315, 44)
        Me.Lesson3Button.TabIndex = 4
        Me.Lesson3Button.Text = "Lesson 3: Cosmic Bodies"
        Me.Lesson3Button.UseVisualStyleBackColor = False
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
        Me.quitButton.TabIndex = 18
        Me.quitButton.Text = "Quit"
        Me.quitButton.UseVisualStyleBackColor = False
        '
        'Lessons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1685, 855)
        Me.Controls.Add(Me.quitButton)
        Me.Controls.Add(Me.Lesson3Button)
        Me.Controls.Add(Me.Lesson2Button)
        Me.Controls.Add(Me.Lesson1Button)
        Me.Controls.Add(Me.LessonsLabel)
        Me.Controls.Add(Me.HomeButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Lessons"
        Me.Text = "Lessons"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HomeButton As Button
    Friend WithEvents LessonsLabel As Label
    Friend WithEvents Lesson1Button As Button
    Friend WithEvents Lesson2Button As Button
    Friend WithEvents Lesson3Button As Button
    Friend WithEvents quitButton As Button
End Class
