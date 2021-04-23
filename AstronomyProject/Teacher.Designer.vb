<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Teacher
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Teacher))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Query2TableAdapter = New AstronomyProject.Database1DataSet1TableAdapters.Query2TableAdapter()
        Me.Query3TableAdapter = New AstronomyProject.Database1DataSet1TableAdapters.Query3TableAdapter()
        Me.Query2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet1 = New AstronomyProject.Database1DataSet1()
        Me.Query3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Query2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Query3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(189, 278)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Chapter 1 Average"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(323, 278)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Chapter 2 Average"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(480, 278)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Chapter 3 Average"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1059, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(238, 184)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Query2TableAdapter
        '
        Me.Query2TableAdapter.ClearBeforeFill = True
        '
        'Query3TableAdapter
        '
        Me.Query3TableAdapter.ClearBeforeFill = True
        '
        'Query2BindingSource
        '
        Me.Query2BindingSource.DataMember = "Query2"
        Me.Query2BindingSource.DataSource = Me.Database1DataSet1BindingSource
        '
        'Database1DataSet1BindingSource
        '
        Me.Database1DataSet1BindingSource.DataSource = Me.Database1DataSet1
        Me.Database1DataSet1BindingSource.Position = 0
        '
        'Database1DataSet1
        '
        Me.Database1DataSet1.DataSetName = "Database1DataSet1"
        Me.Database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HomeButton
        '
        Me.HomeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.HomeButton.BackColor = System.Drawing.Color.DarkSlateGray
        Me.HomeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.HomeButton.ForeColor = System.Drawing.Color.White
        Me.HomeButton.Location = New System.Drawing.Point(1157, 487)
        Me.HomeButton.Margin = New System.Windows.Forms.Padding(2)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(118, 38)
        Me.HomeButton.TabIndex = 20
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(658, 471)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 13)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "Label15"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(658, 449)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "Label14"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(658, 427)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Label13"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(658, 405)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Label12"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(658, 383)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Label11"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(658, 361)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Label10"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(658, 339)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Label9"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(658, 317)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Label8"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(658, 295)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Label7"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(658, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Label2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(658, 273)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Label6"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(658, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Label3"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(658, 251)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Label5"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(658, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Label1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(658, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Label4"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(658, 129)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 13)
        Me.Label16.TabIndex = 46
        Me.Label16.Text = "Score/Question"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(189, 496)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 47
        Me.Button4.Text = "Students"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Teacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1361, 646)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Teacher"
        Me.Text = "Teacher"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Query2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Query3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Query2TableAdapter As Database1DataSet1TableAdapters.Query2TableAdapter
    Friend WithEvents Query3BindingSource As BindingSource
    Friend WithEvents Query3TableAdapter As Database1DataSet1TableAdapters.Query3TableAdapter
    Friend WithEvents Query2BindingSource As BindingSource
    Friend WithEvents Database1DataSet1BindingSource As BindingSource
    Friend WithEvents Database1DataSet1 As Database1DataSet1
    Friend WithEvents HomeButton As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Button4 As Button
End Class
