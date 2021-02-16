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
        Me.ToForm4Button = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(148, 147)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(748, 453)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ToForm2
        '
        Me.ToForm2.Location = New System.Drawing.Point(311, 691)
        Me.ToForm2.Name = "ToForm2"
        Me.ToForm2.Size = New System.Drawing.Size(130, 45)
        Me.ToForm2.TabIndex = 1
        Me.ToForm2.Text = "ToForm2"
        Me.ToForm2.UseVisualStyleBackColor = True
        '
        'ToForm3
        '
        Me.ToForm3.Location = New System.Drawing.Point(676, 691)
        Me.ToForm3.Name = "ToForm3"
        Me.ToForm3.Size = New System.Drawing.Size(121, 45)
        Me.ToForm3.TabIndex = 2
        Me.ToForm3.Text = "ToForm3"
        Me.ToForm3.UseVisualStyleBackColor = True
        '
        'AstronoMeLabel
        '
        Me.AstronoMeLabel.AutoSize = True
        Me.AstronoMeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.0!)
        Me.AstronoMeLabel.Location = New System.Drawing.Point(394, 9)
        Me.AstronoMeLabel.Name = "AstronoMeLabel"
        Me.AstronoMeLabel.Size = New System.Drawing.Size(241, 52)
        Me.AstronoMeLabel.TabIndex = 3
        Me.AstronoMeLabel.Text = "AstronoMe"
        '
        'ToForm4Button
        '
        Me.ToForm4Button.Location = New System.Drawing.Point(483, 691)
        Me.ToForm4Button.Name = "ToForm4Button"
        Me.ToForm4Button.Size = New System.Drawing.Size(133, 45)
        Me.ToForm4Button.TabIndex = 4
        Me.ToForm4Button.Text = "ToForm4"
        Me.ToForm4Button.UseVisualStyleBackColor = True
        '
        'StartingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1308, 783)
        Me.Controls.Add(Me.ToForm4Button)
        Me.Controls.Add(Me.AstronoMeLabel)
        Me.Controls.Add(Me.ToForm3)
        Me.Controls.Add(Me.ToForm2)
        Me.Controls.Add(Me.PictureBox1)
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
    Friend WithEvents ToForm4Button As Button
End Class
