Public Class pg2Lesson1
    Dim rs As New Resizer
    Private Sub pg2Lesson1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs.FindAllControls(Me)
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub pg2Lesson1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub

    Private Sub quitButton_Click(sender As Object, e As EventArgs) Handles quitButton.Click
        Application.Exit()
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Home.Show()
        Me.Dispose()
    End Sub

    Private Sub previousButton_Click(sender As Object, e As EventArgs) Handles previousButton.Click
        pg1_5Lesson1.Show()
        Me.Dispose()
    End Sub

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        pg3Lesson1.Show()
        Me.Dispose()
    End Sub

End Class