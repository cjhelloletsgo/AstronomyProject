﻿Public Class Quizzes
    Dim rs As New Resizer
    Public chapter As Integer
    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Home.Show()
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
    Private Sub ShootingStarsButton_Click(sender As Object, e As EventArgs) Handles ShootingStarsButton.Click
        chapter = 1
        ShootingStars.Show()
        Me.Dispose()
    End Sub
    Private Sub Chapter2_Click(sender As Object, e As EventArgs) Handles Chapter2.Click
        chapter = 2
        ShootingStars.Show()
        Me.Dispose()
    End Sub
End Class