Public Class Home
    Public Savelocation As String
    Private Sub StartingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim information = My.Computer.FileSystem.GetFileInfo("AstronomyProject\sounds\space1.wav")
        Savelocation = information.FullName.Substring(0, information.FullName.Length - 61) + "sounds\"
        My.Computer.Audio.Play(Savelocation + "space1.wav")
        QuizzesButton.FlatStyle = FlatStyle.Flat
        QuizzesButton.FlatAppearance.BorderSize = 0
        LessonsButton.FlatStyle = FlatStyle.Flat
        LessonsButton.FlatAppearance.BorderSize = 0
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