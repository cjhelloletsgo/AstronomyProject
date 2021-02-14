Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToStartingForm_Click(sender As Object, e As EventArgs) Handles ToStartingForm.Click
        StartingForm.Show()
        Me.Hide()
    End Sub
End Class