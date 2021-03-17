Public Class Home
    Dim Savelocation As String
    Dim SoundFile As String
    Private Sub StartingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Savelocation = "C:\Users\Colton\Desktop\"
        SoundFile = "space1.wav"
        'My.Computer.Audio.Play("C:\Users\Colton\Desktop\space1.wav")
        My.Computer.Audio.Play(Savelocation + SoundFile)
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