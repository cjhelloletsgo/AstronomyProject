﻿Public Class Quizzes
    Dim rs As New Resizer
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

    Private Sub Quizzes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs.FindAllControls(Me)
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub Quizzes_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub
End Class