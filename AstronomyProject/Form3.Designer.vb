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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.ToStartingForm = New System.Windows.Forms.Button()
        Me.RevolutionLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToStartingForm
        '
        Me.ToStartingForm.Location = New System.Drawing.Point(346, 612)
        Me.ToStartingForm.Name = "ToStartingForm"
        Me.ToStartingForm.Size = New System.Drawing.Size(203, 47)
        Me.ToStartingForm.TabIndex = 1
        Me.ToStartingForm.Text = "ToStartingForm"
        Me.ToStartingForm.UseVisualStyleBackColor = True
        '
        'RevolutionLabel
        '
        Me.RevolutionLabel.AutoSize = True
        Me.RevolutionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.RevolutionLabel.Location = New System.Drawing.Point(379, 75)
        Me.RevolutionLabel.Name = "RevolutionLabel"
        Me.RevolutionLabel.Size = New System.Drawing.Size(179, 39)
        Me.RevolutionLabel.TabIndex = 2
        Me.RevolutionLabel.Text = "Revolution"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(154, 194)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(556, 339)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1186, 783)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RevolutionLabel)
        Me.Controls.Add(Me.ToStartingForm)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToStartingForm As Button
    Friend WithEvents RevolutionLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
