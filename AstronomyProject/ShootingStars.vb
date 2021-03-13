Public Class ShootingStars
    Dim score As Integer
    Dim x As Integer
    Dim y As Integer
    Dim i As Integer
    Dim j As Integer
    Dim a As Integer
    Dim b As Integer
    Private Sub ShootingStars_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
        Timer2.Enabled = False
        Explosion.Visible = False
        x = Rocket.Location.X()
        y = Rocket.Location.Y()
        a = GoodPlanet.Location.X()
        b = GoodPlanet.Location.Y()
        i = 1
        Rocket.Enabled = False
        My.Computer.Audio.Stop()
    End Sub
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        Timer1.Enabled = True
        Timer2.Enabled = True
        Rocket.Enabled = True
        StartButton.Enabled = False
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Rocket.Top -= 3
        i += 1
        'Rocket.Left = Math.Sin(i) + x
        Rocket.Left = i
        Rocket.Top = -15 * Math.Sqrt(i) + 500
        'Add in rotation here

        GoodPlanet.Left = a + Math.Cos(i) * 25
        GoodPlanet.Top = b + Math.Sin(i) * 25
        Explosion.Left = a + Math.Cos(i) * 25
        Explosion.Top = b + Math.Sin(i) * 25

        'x := originX + cos(angle)*radius;
        'y := originY + sin(angle)*radius;
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Rocket.Location.Y < GoodPlanet.Location.Y + GoodPlanet.Height - 0 Then
            GoodPlanet.Visible = False
            Explosion.Visible = True
            Rocket.Visible = False
            My.Computer.Audio.Play("C:\Users\Colton\Downloads\explosion-01.wav")
            Timer1.Enabled = False
            Timer2.Enabled = False
            'Me.Dispose()
            'Quizzes.Show()
            'MsgBox("Game Over")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles Rocket.Click
        score += 1
        Rocket.Location = New Point(x, y)
        ScoreLabel.Text = score
    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Home.Show()
        My.Computer.Audio.Stop()
        Me.Dispose()
    End Sub
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Dispose()
        Quizzes.Show()
    End Sub
End Class