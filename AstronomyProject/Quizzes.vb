Public Class Quizzes
    Dim rs As New Resizer
    Public chapter As Integer
    Private Sub StartingForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub
    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Home.Show()
        Me.Dispose()
    End Sub
    Private Sub MultipleChoiceButton_Click(sender As Object, e As EventArgs)
        MultipleChoice.Show()
        Me.Dispose()
    End Sub

    Private Sub Quizzes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs.FindAllControls(Me)
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub ShootingStarsButton_Click(sender As Object, e As EventArgs) Handles ShootingStarsButton.Click
        chapter = 1
        ShootingStars.Show()
        Me.Hide()
    End Sub
    Private Sub Chapter2_Click(sender As Object, e As EventArgs) Handles Chapter2.Click
        chapter = 2
        ShootingStars.Show()
        Me.Hide()
    End Sub

    Private Sub Chapter3_Click(sender As Object, e As EventArgs) Handles Chapter3.Click
        chapter = 3
        ShootingStars.Show()
        Me.Hide()
    End Sub

    Private Sub quitButton_Click(sender As Object, e As EventArgs) Handles quitButton.Click
        Application.Exit()
    End Sub
    Private Sub ShootingStarsButton_MouseHover(sender As Object, e As EventArgs) Handles ShootingStarsButton.MouseHover
        ToolTip1.SetToolTip(ShootingStarsButton, "Check your knowledge of the chapter lesson to play the game (and show that you learned something)")
    End Sub

    Private Sub Chapter2_MouseHover(sender As Object, e As EventArgs) Handles Chapter2.MouseHover
        ToolTip2.SetToolTip(Chapter2, "Check your knowledge of the chapter lesson to play the game (and show that you learned something)")
    End Sub

    Private Sub Chapter3_MouseHover(sender As Object, e As EventArgs) Handles Chapter3.MouseHover
        ToolTip3.SetToolTip(Chapter3, "Check your knowledge of the chapter lesson to play the game (and show that you learned something)")
    End Sub
End Class