Public Class Lessons
    Dim rs As New Resizer
    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Home.Show()
        Me.Dispose()
    End Sub

    Private Sub Lessons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs.FindAllControls(Me)
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub Quizzes_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub

    Private Sub quitButton_Click(sender As Object, e As EventArgs) Handles quitButton.Click
        Application.Exit()
    End Sub
End Class