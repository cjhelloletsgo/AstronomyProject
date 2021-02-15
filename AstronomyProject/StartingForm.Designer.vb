<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartingForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartingForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToForm2 = New System.Windows.Forms.Button()
        Me.ToForm3 = New System.Windows.Forms.Button()
        Me.AstronoMeLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(111, 119)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(561, 368)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ToForm2
        '
        Me.ToForm2.Location = New System.Drawing.Point(233, 561)
        Me.ToForm2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ToForm2.Name = "ToForm2"
        Me.ToForm2.Size = New System.Drawing.Size(98, 37)
        Me.ToForm2.TabIndex = 1
        Me.ToForm2.Text = "ToForm2"
        Me.ToForm2.UseVisualStyleBackColor = True
        '
        'ToForm3
        '
        Me.ToForm3.Location = New System.Drawing.Point(507, 561)
        Me.ToForm3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ToForm3.Name = "ToForm3"
        Me.ToForm3.Size = New System.Drawing.Size(91, 37)
        Me.ToForm3.TabIndex = 2
        Me.ToForm3.Text = "ToForm3"
        Me.ToForm3.UseVisualStyleBackColor = True
        '
        'AstronoMeLabel
        '
        Me.AstronoMeLabel.AutoSize = True
        Me.AstronoMeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.0!)
        Me.AstronoMeLabel.Location = New System.Drawing.Point(296, 7)
        Me.AstronoMeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.AstronoMeLabel.Name = "AstronoMeLabel"
        Me.AstronoMeLabel.Size = New System.Drawing.Size(191, 40)
        Me.AstronoMeLabel.TabIndex = 3
        Me.AstronoMeLabel.Text = "AstronoMe"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(707, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "blsadflkjsa;ldkm"
        '
        'StartingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 609)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AstronoMeLabel)
        Me.Controls.Add(Me.ToForm3)
        Me.Controls.Add(Me.ToForm2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "StartingForm"
        Me.Text = "AstronoMe"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToForm2 As Button
    Friend WithEvents ToForm3 As Button
    Friend WithEvents AstronoMeLabel As Label
    Friend WithEvents Label1 As Label
End Class
