<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShootingStars
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ShootingStars))
        Me.Rocket = New System.Windows.Forms.PictureBox()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.StartButton = New System.Windows.Forms.Button()
        Me.Explosion = New System.Windows.Forms.PictureBox()
        Me.GoodPlanet = New System.Windows.Forms.PictureBox()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.ButtonA = New System.Windows.Forms.Button()
        Me.ButtonB = New System.Windows.Forms.Button()
        Me.ButtonC = New System.Windows.Forms.Button()
        Me.ButtonD = New System.Windows.Forms.Button()
        Me.QuestionLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.quitButton = New System.Windows.Forms.Button()
        Me.fireworksPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.Rocket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Explosion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GoodPlanet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fireworksPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Rocket
        '
        Me.Rocket.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Rocket.BackColor = System.Drawing.Color.Transparent
        Me.Rocket.Image = CType(resources.GetObject("Rocket.Image"), System.Drawing.Image)
        Me.Rocket.Location = New System.Drawing.Point(14, 482)
        Me.Rocket.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Rocket.Name = "Rocket"
        Me.Rocket.Size = New System.Drawing.Size(50, 102)
        Me.Rocket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Rocket.TabIndex = 1
        Me.Rocket.TabStop = False
        '
        'HomeButton
        '
        Me.HomeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.HomeButton.BackColor = System.Drawing.Color.DarkSlateGray
        Me.HomeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.HomeButton.ForeColor = System.Drawing.Color.White
        Me.HomeButton.Location = New System.Drawing.Point(10, 650)
        Me.HomeButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(126, 38)
        Me.HomeButton.TabIndex = 2
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseVisualStyleBackColor = False
        '
        'ScoreLabel
        '
        Me.ScoreLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ScoreLabel.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ScoreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ScoreLabel.ForeColor = System.Drawing.Color.White
        Me.ScoreLabel.Location = New System.Drawing.Point(10, 597)
        Me.ScoreLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(126, 38)
        Me.ScoreLabel.TabIndex = 3
        Me.ScoreLabel.Text = "Score"
        Me.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1
        '
        'StartButton
        '
        Me.StartButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.StartButton.BackColor = System.Drawing.Color.DarkSlateGray
        Me.StartButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.StartButton.ForeColor = System.Drawing.Color.White
        Me.StartButton.Location = New System.Drawing.Point(155, 597)
        Me.StartButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(126, 38)
        Me.StartButton.TabIndex = 5
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = False
        '
        'Explosion
        '
        Me.Explosion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Explosion.Image = CType(resources.GetObject("Explosion.Image"), System.Drawing.Image)
        Me.Explosion.Location = New System.Drawing.Point(1026, 54)
        Me.Explosion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Explosion.Name = "Explosion"
        Me.Explosion.Size = New System.Drawing.Size(204, 154)
        Me.Explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Explosion.TabIndex = 6
        Me.Explosion.TabStop = False
        '
        'GoodPlanet
        '
        Me.GoodPlanet.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GoodPlanet.Image = CType(resources.GetObject("GoodPlanet.Image"), System.Drawing.Image)
        Me.GoodPlanet.Location = New System.Drawing.Point(1047, 46)
        Me.GoodPlanet.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GoodPlanet.Name = "GoodPlanet"
        Me.GoodPlanet.Size = New System.Drawing.Size(131, 136)
        Me.GoodPlanet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GoodPlanet.TabIndex = 7
        Me.GoodPlanet.TabStop = False
        '
        'BackButton
        '
        Me.BackButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BackButton.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BackButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BackButton.ForeColor = System.Drawing.Color.White
        Me.BackButton.Location = New System.Drawing.Point(155, 650)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(126, 38)
        Me.BackButton.TabIndex = 8
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'ButtonA
        '
        Me.ButtonA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonA.AutoSize = True
        Me.ButtonA.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ButtonA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ButtonA.ForeColor = System.Drawing.Color.White
        Me.ButtonA.Location = New System.Drawing.Point(481, 531)
        Me.ButtonA.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonA.Name = "ButtonA"
        Me.ButtonA.Size = New System.Drawing.Size(380, 76)
        Me.ButtonA.TabIndex = 10
        Me.ButtonA.Text = "A"
        Me.ButtonA.UseVisualStyleBackColor = False
        '
        'ButtonB
        '
        Me.ButtonB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonB.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ButtonB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ButtonB.ForeColor = System.Drawing.Color.White
        Me.ButtonB.Location = New System.Drawing.Point(481, 611)
        Me.ButtonB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonB.Name = "ButtonB"
        Me.ButtonB.Size = New System.Drawing.Size(380, 76)
        Me.ButtonB.TabIndex = 11
        Me.ButtonB.Text = "B"
        Me.ButtonB.UseVisualStyleBackColor = False
        '
        'ButtonC
        '
        Me.ButtonC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonC.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ButtonC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ButtonC.ForeColor = System.Drawing.Color.White
        Me.ButtonC.Location = New System.Drawing.Point(874, 531)
        Me.ButtonC.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonC.Name = "ButtonC"
        Me.ButtonC.Size = New System.Drawing.Size(380, 76)
        Me.ButtonC.TabIndex = 12
        Me.ButtonC.Text = "C"
        Me.ButtonC.UseVisualStyleBackColor = False
        '
        'ButtonD
        '
        Me.ButtonD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonD.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ButtonD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ButtonD.ForeColor = System.Drawing.Color.White
        Me.ButtonD.Location = New System.Drawing.Point(874, 611)
        Me.ButtonD.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonD.Name = "ButtonD"
        Me.ButtonD.Size = New System.Drawing.Size(380, 76)
        Me.ButtonD.TabIndex = 13
        Me.ButtonD.Text = "D"
        Me.ButtonD.UseVisualStyleBackColor = False
        '
        'QuestionLabel
        '
        Me.QuestionLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QuestionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.QuestionLabel.ForeColor = System.Drawing.Color.White
        Me.QuestionLabel.Location = New System.Drawing.Point(477, 473)
        Me.QuestionLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.QuestionLabel.Name = "QuestionLabel"
        Me.QuestionLabel.Size = New System.Drawing.Size(780, 55)
        Me.QuestionLabel.TabIndex = 14
        Me.QuestionLabel.Text = "Question Goes Here"
        Me.QuestionLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(19, 87)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Label1"
        '
        'quitButton
        '
        Me.quitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.quitButton.BackColor = System.Drawing.Color.DarkSlateGray
        Me.quitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.quitButton.ForeColor = System.Drawing.Color.White
        Me.quitButton.Location = New System.Drawing.Point(155, 597)
        Me.quitButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.quitButton.Name = "quitButton"
        Me.quitButton.Size = New System.Drawing.Size(126, 38)
        Me.quitButton.TabIndex = 16
        Me.quitButton.Text = "Quit"
        Me.quitButton.UseVisualStyleBackColor = False
        '
        'fireworksPictureBox
        '
        Me.fireworksPictureBox.Image = CType(resources.GetObject("fireworksPictureBox.Image"), System.Drawing.Image)
        Me.fireworksPictureBox.Location = New System.Drawing.Point(142, 26)
        Me.fireworksPictureBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.fireworksPictureBox.Name = "fireworksPictureBox"
        Me.fireworksPictureBox.Size = New System.Drawing.Size(105, 112)
        Me.fireworksPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.fireworksPictureBox.TabIndex = 17
        Me.fireworksPictureBox.TabStop = False
        '
        'ShootingStars
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1264, 695)
        Me.Controls.Add(Me.fireworksPictureBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.QuestionLabel)
        Me.Controls.Add(Me.ButtonD)
        Me.Controls.Add(Me.ButtonC)
        Me.Controls.Add(Me.ButtonB)
        Me.Controls.Add(Me.ButtonA)
        Me.Controls.Add(Me.ScoreLabel)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.GoodPlanet)
        Me.Controls.Add(Me.Explosion)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.Rocket)
        Me.Controls.Add(Me.quitButton)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "ShootingStars"
        CType(Me.Rocket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Explosion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GoodPlanet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fireworksPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Rocket As PictureBox
    Friend WithEvents HomeButton As Button
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents StartButton As Button
    Friend WithEvents Explosion As PictureBox
    Friend WithEvents GoodPlanet As PictureBox
    Friend WithEvents BackButton As Button
    Friend WithEvents ButtonA As Button
    Friend WithEvents ButtonB As Button
    Friend WithEvents ButtonC As Button
    Friend WithEvents ButtonD As Button
    Friend WithEvents QuestionLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents quitButton As Button
    Friend WithEvents fireworksPictureBox As PictureBox
End Class
