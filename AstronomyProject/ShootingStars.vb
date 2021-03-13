Public Class ShootingStars
    Dim score As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.Top -= 5
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If PictureBox1.Location.Y < GoodPlanet.Location.Y + GoodPlanet.Height - 20 Then
            GoodPlanet.Visible = False
            BurningPlanet.Visible = True
            PictureBox1.Visible = False
            'Me.Dispose()
            'Quizzes.Show()
            'MsgBox("Game Over")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        score += 1
        PictureBox1.Location = New Point(200, 400)
        ScoreLabel.Text = score
    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Timer1.Enabled = False
        Timer2.Enabled = False
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub ShootingStars_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
        Timer2.Enabled = False
        BurningPlanet.Visible = False
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub
End Class