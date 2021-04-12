<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pg1Lesson2
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
        Me.LessonsLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LessonsLabel
        '
        Me.LessonsLabel.BackColor = System.Drawing.Color.DarkSlateGray
        Me.LessonsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LessonsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LessonsLabel.ForeColor = System.Drawing.Color.White
        Me.LessonsLabel.Location = New System.Drawing.Point(-7, 0)
        Me.LessonsLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LessonsLabel.Name = "LessonsLabel"
        Me.LessonsLabel.Size = New System.Drawing.Size(1277, 55)
        Me.LessonsLabel.TabIndex = 23
        Me.LessonsLabel.Text = "The Gas Giants"
        Me.LessonsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pg1Lesson2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 695)
        Me.Controls.Add(Me.LessonsLabel)
        Me.Name = "pg1Lesson2"
        Me.Text = "pg1Lesson2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LessonsLabel As Label
End Class
