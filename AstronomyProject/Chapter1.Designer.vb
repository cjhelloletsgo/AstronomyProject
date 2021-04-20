<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chapter1
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Database1DataSet1 = New AstronomyProject.Database1DataSet1()
        Me.Query1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Query1TableAdapter = New AstronomyProject.Database1DataSet1TableAdapters.Query1TableAdapter()
        Me.Expr1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expr2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expr3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expr4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expr5DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expr6DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expr7DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expr8DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expr9DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expr10DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expr11DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expr12DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expr13DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expr14DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expr15DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expr16DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Query1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Expr1DataGridViewTextBoxColumn, Me.Expr2DataGridViewTextBoxColumn, Me.Expr3DataGridViewTextBoxColumn, Me.Expr4DataGridViewTextBoxColumn, Me.Expr5DataGridViewTextBoxColumn, Me.Expr6DataGridViewTextBoxColumn, Me.Expr7DataGridViewTextBoxColumn, Me.Expr8DataGridViewTextBoxColumn, Me.Expr9DataGridViewTextBoxColumn, Me.Expr10DataGridViewTextBoxColumn, Me.Expr11DataGridViewTextBoxColumn, Me.Expr12DataGridViewTextBoxColumn, Me.Expr13DataGridViewTextBoxColumn, Me.Expr14DataGridViewTextBoxColumn, Me.Expr15DataGridViewTextBoxColumn, Me.Expr16DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Query1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 181)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(735, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'Database1DataSet1
        '
        Me.Database1DataSet1.DataSetName = "Database1DataSet1"
        Me.Database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Query1BindingSource
        '
        Me.Query1BindingSource.DataMember = "Query1"
        Me.Query1BindingSource.DataSource = Me.Database1DataSet1
        '
        'Query1TableAdapter
        '
        Me.Query1TableAdapter.ClearBeforeFill = True
        '
        'Expr1DataGridViewTextBoxColumn
        '
        Me.Expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1"
        Me.Expr1DataGridViewTextBoxColumn.HeaderText = "Expr1"
        Me.Expr1DataGridViewTextBoxColumn.Name = "Expr1DataGridViewTextBoxColumn"
        Me.Expr1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Expr2DataGridViewTextBoxColumn
        '
        Me.Expr2DataGridViewTextBoxColumn.DataPropertyName = "Expr2"
        Me.Expr2DataGridViewTextBoxColumn.HeaderText = "Expr2"
        Me.Expr2DataGridViewTextBoxColumn.Name = "Expr2DataGridViewTextBoxColumn"
        Me.Expr2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Expr3DataGridViewTextBoxColumn
        '
        Me.Expr3DataGridViewTextBoxColumn.DataPropertyName = "Expr3"
        Me.Expr3DataGridViewTextBoxColumn.HeaderText = "Expr3"
        Me.Expr3DataGridViewTextBoxColumn.Name = "Expr3DataGridViewTextBoxColumn"
        Me.Expr3DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Expr4DataGridViewTextBoxColumn
        '
        Me.Expr4DataGridViewTextBoxColumn.DataPropertyName = "Expr4"
        Me.Expr4DataGridViewTextBoxColumn.HeaderText = "Expr4"
        Me.Expr4DataGridViewTextBoxColumn.Name = "Expr4DataGridViewTextBoxColumn"
        Me.Expr4DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Expr5DataGridViewTextBoxColumn
        '
        Me.Expr5DataGridViewTextBoxColumn.DataPropertyName = "Expr5"
        Me.Expr5DataGridViewTextBoxColumn.HeaderText = "Expr5"
        Me.Expr5DataGridViewTextBoxColumn.Name = "Expr5DataGridViewTextBoxColumn"
        Me.Expr5DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Expr6DataGridViewTextBoxColumn
        '
        Me.Expr6DataGridViewTextBoxColumn.DataPropertyName = "Expr6"
        Me.Expr6DataGridViewTextBoxColumn.HeaderText = "Expr6"
        Me.Expr6DataGridViewTextBoxColumn.Name = "Expr6DataGridViewTextBoxColumn"
        Me.Expr6DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Expr7DataGridViewTextBoxColumn
        '
        Me.Expr7DataGridViewTextBoxColumn.DataPropertyName = "Expr7"
        Me.Expr7DataGridViewTextBoxColumn.HeaderText = "Expr7"
        Me.Expr7DataGridViewTextBoxColumn.Name = "Expr7DataGridViewTextBoxColumn"
        Me.Expr7DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Expr8DataGridViewTextBoxColumn
        '
        Me.Expr8DataGridViewTextBoxColumn.DataPropertyName = "Expr8"
        Me.Expr8DataGridViewTextBoxColumn.HeaderText = "Expr8"
        Me.Expr8DataGridViewTextBoxColumn.Name = "Expr8DataGridViewTextBoxColumn"
        Me.Expr8DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Expr9DataGridViewTextBoxColumn
        '
        Me.Expr9DataGridViewTextBoxColumn.DataPropertyName = "Expr9"
        Me.Expr9DataGridViewTextBoxColumn.HeaderText = "Expr9"
        Me.Expr9DataGridViewTextBoxColumn.Name = "Expr9DataGridViewTextBoxColumn"
        Me.Expr9DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Expr10DataGridViewTextBoxColumn
        '
        Me.Expr10DataGridViewTextBoxColumn.DataPropertyName = "Expr10"
        Me.Expr10DataGridViewTextBoxColumn.HeaderText = "Expr10"
        Me.Expr10DataGridViewTextBoxColumn.Name = "Expr10DataGridViewTextBoxColumn"
        Me.Expr10DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Expr11DataGridViewTextBoxColumn
        '
        Me.Expr11DataGridViewTextBoxColumn.DataPropertyName = "Expr11"
        Me.Expr11DataGridViewTextBoxColumn.HeaderText = "Expr11"
        Me.Expr11DataGridViewTextBoxColumn.Name = "Expr11DataGridViewTextBoxColumn"
        Me.Expr11DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Expr12DataGridViewTextBoxColumn
        '
        Me.Expr12DataGridViewTextBoxColumn.DataPropertyName = "Expr12"
        Me.Expr12DataGridViewTextBoxColumn.HeaderText = "Expr12"
        Me.Expr12DataGridViewTextBoxColumn.Name = "Expr12DataGridViewTextBoxColumn"
        Me.Expr12DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Expr13DataGridViewTextBoxColumn
        '
        Me.Expr13DataGridViewTextBoxColumn.DataPropertyName = "Expr13"
        Me.Expr13DataGridViewTextBoxColumn.HeaderText = "Expr13"
        Me.Expr13DataGridViewTextBoxColumn.Name = "Expr13DataGridViewTextBoxColumn"
        Me.Expr13DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Expr14DataGridViewTextBoxColumn
        '
        Me.Expr14DataGridViewTextBoxColumn.DataPropertyName = "Expr14"
        Me.Expr14DataGridViewTextBoxColumn.HeaderText = "Expr14"
        Me.Expr14DataGridViewTextBoxColumn.Name = "Expr14DataGridViewTextBoxColumn"
        Me.Expr14DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Expr15DataGridViewTextBoxColumn
        '
        Me.Expr15DataGridViewTextBoxColumn.DataPropertyName = "Expr15"
        Me.Expr15DataGridViewTextBoxColumn.HeaderText = "Expr15"
        Me.Expr15DataGridViewTextBoxColumn.Name = "Expr15DataGridViewTextBoxColumn"
        Me.Expr15DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Expr16DataGridViewTextBoxColumn
        '
        Me.Expr16DataGridViewTextBoxColumn.DataPropertyName = "Expr16"
        Me.Expr16DataGridViewTextBoxColumn.HeaderText = "Expr16"
        Me.Expr16DataGridViewTextBoxColumn.Name = "Expr16DataGridViewTextBoxColumn"
        Me.Expr16DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(230, 106)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Chapter1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Chapter1"
        Me.Text = "Chapter1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Query1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Database1DataSet1 As Database1DataSet1
    Friend WithEvents Query1BindingSource As BindingSource
    Friend WithEvents Query1TableAdapter As Database1DataSet1TableAdapters.Query1TableAdapter
    Friend WithEvents Expr1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr4DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr5DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr6DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr7DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr8DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr9DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr10DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr11DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr12DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr13DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr14DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr15DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Expr16DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
