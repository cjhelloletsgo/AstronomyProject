<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MultipleChoice
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MultipleChoice))
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.EarthRotatingGif = New System.Windows.Forms.PictureBox()
        Me.RevolutionLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Wrong = New System.Windows.Forms.Label()
        Me.FireworksGif = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.EarthRotatingGif, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FireworksGif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HomeButton
        '
        Me.HomeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.HomeButton.Location = New System.Drawing.Point(865, 638)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(173, 47)
        Me.HomeButton.TabIndex = 0
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'EarthRotatingGif
        '
        Me.EarthRotatingGif.Image = CType(resources.GetObject("EarthRotatingGif.Image"), System.Drawing.Image)
        Me.EarthRotatingGif.Location = New System.Drawing.Point(179, 304)
        Me.EarthRotatingGif.Name = "EarthRotatingGif"
        Me.EarthRotatingGif.Size = New System.Drawing.Size(510, 270)
        Me.EarthRotatingGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.EarthRotatingGif.TabIndex = 1
        Me.EarthRotatingGif.TabStop = False
        '
        'RevolutionLabel
        '
        Me.RevolutionLabel.AutoSize = True
        Me.RevolutionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.RevolutionLabel.Location = New System.Drawing.Point(172, 127)
        Me.RevolutionLabel.Name = "RevolutionLabel"
        Me.RevolutionLabel.Size = New System.Drawing.Size(584, 36)
        Me.RevolutionLabel.TabIndex = 3
        Me.RevolutionLabel.Text = "Is this an example of rotation or revolution?"
        '
        'Timer1
        '
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button1.Location = New System.Drawing.Point(241, 264)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 34)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Revolution"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button2.Location = New System.Drawing.Point(535, 264)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(161, 34)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Rotation"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Wrong
        '
        Me.Wrong.AutoSize = True
        Me.Wrong.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Wrong.Location = New System.Drawing.Point(358, 196)
        Me.Wrong.Name = "Wrong"
        Me.Wrong.Size = New System.Drawing.Size(109, 25)
        Me.Wrong.TabIndex = 9
        Me.Wrong.Text = "For Shame"
        '
        'FireworksGif
        '
        Me.FireworksGif.Image = CType(resources.GetObject("FireworksGif.Image"), System.Drawing.Image)
        Me.FireworksGif.Location = New System.Drawing.Point(3, -3)
        Me.FireworksGif.Name = "FireworksGif"
        Me.FireworksGif.Size = New System.Drawing.Size(1088, 715)
        Me.FireworksGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FireworksGif.TabIndex = 10
        Me.FireworksGif.TabStop = False
        '
        'Timer2
        '
        '
        'MultipleChoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1301, 790)
        Me.Controls.Add(Me.Wrong)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RevolutionLabel)
        Me.Controls.Add(Me.EarthRotatingGif)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.FireworksGif)
        Me.Name = "MultipleChoice"
        Me.Text = "Form2"
        CType(Me.EarthRotatingGif, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FireworksGif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HomeButton As Button
    Friend WithEvents EarthRotatingGif As PictureBox
    Friend WithEvents RevolutionLabel As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Wrong As Label
    Friend WithEvents FireworksGif As PictureBox
    Friend WithEvents Timer2 As Timer
End Class
