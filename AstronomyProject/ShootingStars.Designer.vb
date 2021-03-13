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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.BurningPlanet = New System.Windows.Forms.PictureBox()
        Me.GoodPlanet = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BurningPlanet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GoodPlanet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(168, 534)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(68, 136)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'HomeButton
        '
        Me.HomeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.HomeButton.Location = New System.Drawing.Point(860, 571)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(158, 47)
        Me.HomeButton.TabIndex = 2
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'ScoreLabel
        '
        Me.ScoreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ScoreLabel.Location = New System.Drawing.Point(688, 153)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(146, 30)
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
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-202, -36)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1486, 715)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'StartButton
        '
        Me.StartButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.StartButton.Location = New System.Drawing.Point(666, 571)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(158, 47)
        Me.StartButton.TabIndex = 5
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'BurningPlanet
        '
        Me.BurningPlanet.Image = CType(resources.GetObject("BurningPlanet.Image"), System.Drawing.Image)
        Me.BurningPlanet.Location = New System.Drawing.Point(26, 33)
        Me.BurningPlanet.Name = "BurningPlanet"
        Me.BurningPlanet.Size = New System.Drawing.Size(428, 247)
        Me.BurningPlanet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BurningPlanet.TabIndex = 6
        Me.BurningPlanet.TabStop = False
        '
        'GoodPlanet
        '
        Me.GoodPlanet.Image = CType(resources.GetObject("GoodPlanet.Image"), System.Drawing.Image)
        Me.GoodPlanet.Location = New System.Drawing.Point(40, 12)
        Me.GoodPlanet.Name = "GoodPlanet"
        Me.GoodPlanet.Size = New System.Drawing.Size(284, 268)
        Me.GoodPlanet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.GoodPlanet.TabIndex = 7
        Me.GoodPlanet.TabStop = False
        '
        'ShootingStars
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 667)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GoodPlanet)
        Me.Controls.Add(Me.BurningPlanet)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.ScoreLabel)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "ShootingStars"
        Me.Text = "Form4"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BurningPlanet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GoodPlanet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents HomeButton As Button
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents StartButton As Button
    Friend WithEvents BurningPlanet As PictureBox
    Friend WithEvents GoodPlanet As PictureBox
End Class
