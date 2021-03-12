<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.RevolutionLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RevolutionButton = New System.Windows.Forms.Button()
        Me.RotationButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Wrong = New System.Windows.Forms.Label()
        Me.FireworksGif = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FireworksGif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HomeButton
        '
        Me.HomeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.HomeButton.Location = New System.Drawing.Point(912, 599)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(160, 43)
        Me.HomeButton.TabIndex = 1
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'RevolutionLabel
        '
        Me.RevolutionLabel.AutoSize = True
        Me.RevolutionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.RevolutionLabel.Location = New System.Drawing.Point(379, 75)
        Me.RevolutionLabel.Name = "RevolutionLabel"
        Me.RevolutionLabel.Size = New System.Drawing.Size(158, 36)
        Me.RevolutionLabel.TabIndex = 2
        Me.RevolutionLabel.Text = "Revolution"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(228, 230)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(556, 339)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'RevolutionButton
        '
        Me.RevolutionButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.RevolutionButton.Location = New System.Drawing.Point(282, 141)
        Me.RevolutionButton.Name = "RevolutionButton"
        Me.RevolutionButton.Size = New System.Drawing.Size(137, 29)
        Me.RevolutionButton.TabIndex = 4
        Me.RevolutionButton.Text = "Revolution"
        Me.RevolutionButton.UseVisualStyleBackColor = True
        '
        'RotationButton
        '
        Me.RotationButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.RotationButton.Location = New System.Drawing.Point(482, 141)
        Me.RotationButton.Name = "RotationButton"
        Me.RotationButton.Size = New System.Drawing.Size(102, 29)
        Me.RotationButton.TabIndex = 5
        Me.RotationButton.Text = "Rotation"
        Me.RotationButton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Wrong
        '
        Me.Wrong.AutoSize = True
        Me.Wrong.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Wrong.Location = New System.Drawing.Point(624, 167)
        Me.Wrong.Name = "Wrong"
        Me.Wrong.Size = New System.Drawing.Size(160, 36)
        Me.Wrong.TabIndex = 10
        Me.Wrong.Text = "For Shame"
        '
        'FireworksGif
        '
        Me.FireworksGif.Image = CType(resources.GetObject("FireworksGif.Image"), System.Drawing.Image)
        Me.FireworksGif.Location = New System.Drawing.Point(12, 12)
        Me.FireworksGif.Name = "FireworksGif"
        Me.FireworksGif.Size = New System.Drawing.Size(1084, 703)
        Me.FireworksGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FireworksGif.TabIndex = 11
        Me.FireworksGif.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1186, 783)
        Me.Controls.Add(Me.Wrong)
        Me.Controls.Add(Me.RotationButton)
        Me.Controls.Add(Me.RevolutionButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RevolutionLabel)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.FireworksGif)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FireworksGif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HomeButton As Button
    Friend WithEvents RevolutionLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RevolutionButton As Button
    Friend WithEvents RotationButton As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Wrong As Label
    Friend WithEvents FireworksGif As PictureBox
End Class
