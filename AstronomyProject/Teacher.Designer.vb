<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Teacher
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
        Me.quiz1Label = New System.Windows.Forms.Label()
        Me.quiz2Label = New System.Windows.Forms.Label()
        Me.quiz3Label = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.quiz1Result = New System.Windows.Forms.Label()
        Me.quiz2Result = New System.Windows.Forms.Label()
        Me.quiz3Result = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'quiz1Label
        '
        Me.quiz1Label.AutoSize = True
        Me.quiz1Label.Location = New System.Drawing.Point(145, 99)
        Me.quiz1Label.Name = "quiz1Label"
        Me.quiz1Label.Size = New System.Drawing.Size(37, 13)
        Me.quiz1Label.TabIndex = 0
        Me.quiz1Label.Text = "Quiz 1"
        '
        'quiz2Label
        '
        Me.quiz2Label.AutoSize = True
        Me.quiz2Label.Location = New System.Drawing.Point(331, 99)
        Me.quiz2Label.Name = "quiz2Label"
        Me.quiz2Label.Size = New System.Drawing.Size(37, 13)
        Me.quiz2Label.TabIndex = 1
        Me.quiz2Label.Text = "Quiz 2"
        '
        'quiz3Label
        '
        Me.quiz3Label.AutoSize = True
        Me.quiz3Label.Location = New System.Drawing.Point(454, 98)
        Me.quiz3Label.Name = "quiz3Label"
        Me.quiz3Label.Size = New System.Drawing.Size(37, 13)
        Me.quiz3Label.TabIndex = 2
        Me.quiz3Label.Text = "Quiz 3"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(174, 329)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(334, 329)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(474, 329)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(669, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'quiz1Result
        '
        Me.quiz1Result.AutoSize = True
        Me.quiz1Result.Location = New System.Drawing.Point(149, 147)
        Me.quiz1Result.Name = "quiz1Result"
        Me.quiz1Result.Size = New System.Drawing.Size(33, 13)
        Me.quiz1Result.TabIndex = 7
        Me.quiz1Result.Text = "blank"
        '
        'quiz2Result
        '
        Me.quiz2Result.AutoSize = True
        Me.quiz2Result.Location = New System.Drawing.Point(302, 147)
        Me.quiz2Result.Name = "quiz2Result"
        Me.quiz2Result.Size = New System.Drawing.Size(33, 13)
        Me.quiz2Result.TabIndex = 8
        Me.quiz2Result.Text = "blank"
        '
        'quiz3Result
        '
        Me.quiz3Result.AutoSize = True
        Me.quiz3Result.Location = New System.Drawing.Point(445, 147)
        Me.quiz3Result.Name = "quiz3Result"
        Me.quiz3Result.Size = New System.Drawing.Size(33, 13)
        Me.quiz3Result.TabIndex = 9
        Me.quiz3Result.Text = "blank"
        '
        'Teacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.quiz3Result)
        Me.Controls.Add(Me.quiz2Result)
        Me.Controls.Add(Me.quiz1Result)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.quiz3Label)
        Me.Controls.Add(Me.quiz2Label)
        Me.Controls.Add(Me.quiz1Label)
        Me.Name = "Teacher"
        Me.Text = "Teacher"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents quiz1Label As Label
    Friend WithEvents quiz2Label As Label
    Friend WithEvents quiz3Label As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents quiz1Result As Label
    Friend WithEvents quiz2Result As Label
    Friend WithEvents quiz3Result As Label
End Class
