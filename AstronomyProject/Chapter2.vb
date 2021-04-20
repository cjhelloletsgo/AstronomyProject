Public Class Chapter2
    Private Sub Chapter2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet1.Query3' table. You can move, or remove it, as needed.
        Me.Query3TableAdapter.Fill(Me.Database1DataSet1.Query3)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Teacher.Show()
        Me.Hide()
    End Sub
End Class