Public Class Quizzes
    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Home.Show()
        Me.Dispose()
    End Sub

    Private Sub ShootingStarsButton_Click(sender As Object, e As EventArgs) Handles ShootingStarsButton.Click
        ShootingStars.Show()
        Me.Dispose()
    End Sub

    Private Sub MultipleChoiceButton_Click(sender As Object, e As EventArgs) Handles MultipleChoiceButton.Click
        MultipleChoice.Show()
        Me.Dispose()
    End Sub
End Class