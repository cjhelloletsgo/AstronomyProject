<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.ToStartingForm = New System.Windows.Forms.Button()
        Me.EarthRotatingGif = New System.Windows.Forms.PictureBox()
        Me.RevolutionLabel = New System.Windows.Forms.Label()
        CType(Me.EarthRotatingGif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToStartingForm
        '
        Me.ToStartingForm.Location = New System.Drawing.Point(535, 601)
        Me.ToStartingForm.Name = "ToStartingForm"
        Me.ToStartingForm.Size = New System.Drawing.Size(203, 47)
        Me.ToStartingForm.TabIndex = 0
        Me.ToStartingForm.Text = "ToStartingForm"
        Me.ToStartingForm.UseVisualStyleBackColor = True
        '
        'EarthRotatingGif
        '
        Me.EarthRotatingGif.Image = CType(resources.GetObject("EarthRotatingGif.Image"), System.Drawing.Image)
        Me.EarthRotatingGif.Location = New System.Drawing.Point(261, 264)
        Me.EarthRotatingGif.Name = "EarthRotatingGif"
        Me.EarthRotatingGif.Size = New System.Drawing.Size(510, 270)
        Me.EarthRotatingGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.EarthRotatingGif.TabIndex = 1
        Me.EarthRotatingGif.TabStop = False
        '
        'RevolutionLabel
        '
        Me.RevolutionLabel.AutoSize = True
        Me.RevolutionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.RevolutionLabel.Location = New System.Drawing.Point(405, 81)
        Me.RevolutionLabel.Name = "RevolutionLabel"
        Me.RevolutionLabel.Size = New System.Drawing.Size(144, 39)
        Me.RevolutionLabel.TabIndex = 3
        Me.RevolutionLabel.Text = "Rotation"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1301, 790)
        Me.Controls.Add(Me.RevolutionLabel)
        Me.Controls.Add(Me.EarthRotatingGif)
        Me.Controls.Add(Me.ToStartingForm)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.EarthRotatingGif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToStartingForm As Button
    Friend WithEvents EarthRotatingGif As PictureBox
    Friend WithEvents RevolutionLabel As Label
End Class
