﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pg1_5Lesson1
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
        Me.previousButton = New System.Windows.Forms.Button()
        Me.nextButton = New System.Windows.Forms.Button()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.quitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LessonsLabel
        '
        Me.LessonsLabel.BackColor = System.Drawing.Color.DarkSlateGray
        Me.LessonsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LessonsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LessonsLabel.ForeColor = System.Drawing.Color.White
        Me.LessonsLabel.Location = New System.Drawing.Point(-6, -2)
        Me.LessonsLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LessonsLabel.Name = "LessonsLabel"
        Me.LessonsLabel.Size = New System.Drawing.Size(1277, 55)
        Me.LessonsLabel.TabIndex = 22
        Me.LessonsLabel.Text = "The Inner Circle"
        Me.LessonsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'previousButton
        '
        Me.previousButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.previousButton.BackColor = System.Drawing.Color.DarkSlateGray
        Me.previousButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.previousButton.ForeColor = System.Drawing.Color.White
        Me.previousButton.Location = New System.Drawing.Point(498, 646)
        Me.previousButton.Margin = New System.Windows.Forms.Padding(2)
        Me.previousButton.Name = "previousButton"
        Me.previousButton.Size = New System.Drawing.Size(118, 38)
        Me.previousButton.TabIndex = 29
        Me.previousButton.Text = "Previous"
        Me.previousButton.UseVisualStyleBackColor = False
        '
        'nextButton
        '
        Me.nextButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nextButton.BackColor = System.Drawing.Color.DarkSlateGray
        Me.nextButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nextButton.ForeColor = System.Drawing.Color.White
        Me.nextButton.Location = New System.Drawing.Point(647, 646)
        Me.nextButton.Margin = New System.Windows.Forms.Padding(2)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(118, 38)
        Me.nextButton.TabIndex = 28
        Me.nextButton.Text = "Next"
        Me.nextButton.UseVisualStyleBackColor = False
        '
        'HomeButton
        '
        Me.HomeButton.BackColor = System.Drawing.Color.DarkSlateGray
        Me.HomeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeButton.ForeColor = System.Drawing.Color.White
        Me.HomeButton.Location = New System.Drawing.Point(11, 646)
        Me.HomeButton.Margin = New System.Windows.Forms.Padding(2)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(118, 38)
        Me.HomeButton.TabIndex = 27
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseVisualStyleBackColor = False
        '
        'quitButton
        '
        Me.quitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.quitButton.BackColor = System.Drawing.Color.DarkSlateGray
        Me.quitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quitButton.ForeColor = System.Drawing.Color.White
        Me.quitButton.Location = New System.Drawing.Point(1135, 646)
        Me.quitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.quitButton.Name = "quitButton"
        Me.quitButton.Size = New System.Drawing.Size(118, 38)
        Me.quitButton.TabIndex = 26
        Me.quitButton.Text = "Quit"
        Me.quitButton.UseVisualStyleBackColor = False
        '
        'pg1_5Lesson1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 695)
        Me.Controls.Add(Me.previousButton)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.quitButton)
        Me.Controls.Add(Me.LessonsLabel)
        Me.Name = "pg1_5Lesson1"
        Me.Text = "pg1_5Lesson1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LessonsLabel As Label
    Friend WithEvents previousButton As Button
    Friend WithEvents nextButton As Button
    Friend WithEvents HomeButton As Button
    Friend WithEvents quitButton As Button
End Class