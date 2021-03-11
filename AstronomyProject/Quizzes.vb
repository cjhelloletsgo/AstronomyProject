Public Class Quizzes
    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub ShootingStarsButton_Click(sender As Object, e As EventArgs) Handles ShootingStarsButton.Click
        ShootingStars.Show()
        Me.Hide()
    End Sub
End Class