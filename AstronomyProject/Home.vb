Public Class Home
    Private Sub StartingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub QuizzesButton_Click(sender As Object, e As EventArgs) Handles QuizzesButton.Click
        Quizzes.Show()
        Me.Hide()
    End Sub

    Private Sub LessonsButton_Click(sender As Object, e As EventArgs) Handles LessonsButton.Click
        Lessons.Show()
        Me.Hide()
    End Sub
End Class