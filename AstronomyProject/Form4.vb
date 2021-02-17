Public Class Form4
    Dim score As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBox1.Top -= 5
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        If PictureBox1.Location.Y < -60 Then
            Me.Dispose()
            MsgBox("Game Over")
            StartingForm.Show()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        score += 1
        PictureBox1.Location = New Point(200, 400)
        ScoreLabel.Text = score
    End Sub

    Private Sub ToStartingForm_Click(sender As Object, e As EventArgs) Handles ToStartingForm.Click
        StartingForm.Show()
        Me.Hide()
    End Sub
End Class

'Public Class Form4
'    Dim score As Integer
'    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
'        PictureBox1.Top -= 5
'    End Sub

'    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

'        If PictureBox1.Location.Y < -60 Then
'            Me.Dispose()
'            MsgBox("Game Over")
'            StartingForm.Show()
'        End If
'    End Sub

'    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
'        score += 1
'        PictureBox1.Location = New Point(200, 400)
'        ScoreLabel.Text = score
'    End Sub

'    Private Sub ToStartingForm_Click(sender As Object, e As EventArgs) Handles ToStartingForm.Click
'        StartingForm.Show()
'        Me.Hide()
'    End Sub
'End Class