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
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quiz1GradeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quiz2GradeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quiz3GradeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Query2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet1 = New AstronomyProject.Database1DataSet1()
        Me.Query3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(543, 201)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentIDDataGridViewTextBoxColumn, Me.Quiz1GradeDataGridViewTextBoxColumn, Me.Quiz2GradeDataGridViewTextBoxColumn, Me.Quiz3GradeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Query2BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(289, 321)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(445, 150)
        Me.DataGridView1.TabIndex = 16
        '
        'StudentIDDataGridViewTextBoxColumn
        '
        Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
        '
        'Quiz1GradeDataGridViewTextBoxColumn
        '
        Me.Quiz1GradeDataGridViewTextBoxColumn.DataPropertyName = "quiz1Grade"
        Me.Quiz1GradeDataGridViewTextBoxColumn.HeaderText = "quiz1Grade"
        Me.Quiz1GradeDataGridViewTextBoxColumn.Name = "Quiz1GradeDataGridViewTextBoxColumn"
        '
        'Quiz2GradeDataGridViewTextBoxColumn
        '
        Me.Quiz2GradeDataGridViewTextBoxColumn.DataPropertyName = "quiz2Grade"
        Me.Quiz2GradeDataGridViewTextBoxColumn.HeaderText = "quiz2Grade"
        Me.Quiz2GradeDataGridViewTextBoxColumn.Name = "Quiz2GradeDataGridViewTextBoxColumn"
        '
        'Quiz3GradeDataGridViewTextBoxColumn
        '
        Me.Quiz3GradeDataGridViewTextBoxColumn.DataPropertyName = "quiz3Grade"
        Me.Quiz3GradeDataGridViewTextBoxColumn.HeaderText = "quiz3Grade"
        Me.Quiz3GradeDataGridViewTextBoxColumn.Name = "Quiz3GradeDataGridViewTextBoxColumn"
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
        'Teacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1361, 646)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Teacher"
        Me.Text = "Teacher"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Query2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Query3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Query2TableAdapter As Database1DataSet1TableAdapters.Query2TableAdapter
    Friend WithEvents Query3BindingSource As BindingSource
    Friend WithEvents Query3TableAdapter As Database1DataSet1TableAdapters.Query3TableAdapter
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Quiz1GradeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Quiz2GradeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Quiz3GradeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Query2BindingSource As BindingSource
    Friend WithEvents Database1DataSet1BindingSource As BindingSource
    Friend WithEvents Database1DataSet1 As Database1DataSet1
End Class
