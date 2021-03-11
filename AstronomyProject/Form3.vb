Public Class Form3
    Private Sub ToStartingForm_Click(sender As Object, e As EventArgs) Handles ToStartingForm.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Wrong.Visible = False
        FireworksGif.Visible = False
    End Sub
    Dim blink As Boolean
    Dim count As Integer
    Dim Word1 As String
    Dim Word2 As String
    Dim Word3 As String
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Word1 = "Kid"
        Word2 = "You"
        Word3 = "Suck"
        If (count <= 6) Then
            Select Case count
                Case "0"
                    Wrong.ForeColor = Color.Black
                    Wrong.Text = Word1
                Case "1"
                    Wrong.ForeColor = Color.White
                    Wrong.Text = Word2
                Case "2"
                    Wrong.ForeColor = Color.Black
                    Wrong.Text = Word3
                Case Else
                    Wrong.Visible = False
            End Select

            If (blink) Then
                Me.BackColor = Color.White
                blink = False
                Application.DoEvents()
            Else
                Me.BackColor = Color.Black
                blink = True
                Application.DoEvents()
            End If
            count += 1
        Else
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub RotationButton_Click(sender As Object, e As EventArgs) Handles RotationButton.Click
        Timer1.Enabled = True
        Timer1.Interval = 750
        Me.BackColor = Color.Black
        blink = True
        count = 0
        Wrong.Visible = True
    End Sub

    Private Sub RevolutionButton_Click(sender As Object, e As EventArgs) Handles RevolutionButton.Click
        FireworksGif.Visible = True
    End Sub
End Class