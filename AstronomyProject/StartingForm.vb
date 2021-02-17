Public Class StartingForm
    Private Sub StartingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToForm2_Click(sender As Object, e As EventArgs) Handles ToForm2.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub ToForm3_Click(sender As Object, e As EventArgs) Handles ToForm3.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub ToForm4Button_Click(sender As Object, e As EventArgs) Handles ToForm4Button.Click
        Form4.Show()
        Me.Hide()
    End Sub
End Class