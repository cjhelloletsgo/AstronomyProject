﻿Public Class Lessons
    Dim rs As New Resizer
    Private Sub StartingForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub
    Private Sub StartingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs.FindAllControls(Me)
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Home.Show()
        Me.Dispose()
    End Sub
    Private Sub Quizzes_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub

    Private Sub quitButton_Click(sender As Object, e As EventArgs) Handles quitButton.Click
        Application.Exit()
    End Sub

    Private Sub Lesson1Button_Click(sender As Object, e As EventArgs) Handles Lesson1Button.Click
        pg1Lesson1.Show()
        Me.Dispose()
    End Sub

    Private Sub Lesson2Button_Click(sender As Object, e As EventArgs) Handles Lesson2Button.Click
        pg1Lesson2.Show()
        Me.Dispose()
    End Sub
    Private Sub Lesson3Button_Click(sender As Object, e As EventArgs) Handles Lesson3Button.Click
        pg1lesson3.Show()
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub
End Class