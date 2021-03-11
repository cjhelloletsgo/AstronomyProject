<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AstronoMeLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.QuizzesButton = New System.Windows.Forms.Button()
        Me.LessonsButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(148, 146)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(748, 453)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'AstronoMeLabel
        '
        Me.AstronoMeLabel.AutoSize = True
        Me.AstronoMeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.0!)
        Me.AstronoMeLabel.Location = New System.Drawing.Point(395, 9)
        Me.AstronoMeLabel.Name = "AstronoMeLabel"
        Me.AstronoMeLabel.Size = New System.Drawing.Size(241, 52)
        Me.AstronoMeLabel.TabIndex = 3
        Me.AstronoMeLabel.Text = "AstronoMe"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(943, 68)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "blsadflkjsa;ldkm"
        '
        'QuizzesButton
        '
        Me.QuizzesButton.Location = New System.Drawing.Point(936, 312)
        Me.QuizzesButton.Name = "QuizzesButton"
        Me.QuizzesButton.Size = New System.Drawing.Size(75, 23)
        Me.QuizzesButton.TabIndex = 6
        Me.QuizzesButton.Text = "Quizzes"
        Me.QuizzesButton.UseVisualStyleBackColor = True
        '
        'LessonsButton
        '
        Me.LessonsButton.Location = New System.Drawing.Point(945, 405)
        Me.LessonsButton.Name = "LessonsButton"
        Me.LessonsButton.Size = New System.Drawing.Size(75, 23)
        Me.LessonsButton.TabIndex = 7
        Me.LessonsButton.Text = "Lessons"
        Me.LessonsButton.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1308, 750)
        Me.Controls.Add(Me.LessonsButton)
        Me.Controls.Add(Me.QuizzesButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AstronoMeLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Home"
        Me.Text = "AstronoMe"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AstronoMeLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents QuizzesButton As Button
    Friend WithEvents LessonsButton As Button
End Class
