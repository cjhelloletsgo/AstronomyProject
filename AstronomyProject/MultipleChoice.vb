Public Class MultipleChoice
    Dim blink As Boolean
    Dim count As Integer
    Dim Word1 As String
    Dim Word2 As String
    Dim Word3 As String
    Dim Timer2Length As Integer
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Wrong.Visible = False
        FireworksGif.Visible = False
        Timer2.Enabled = False
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Home.Show()
        Me.Dispose()
    End Sub

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        Timer1.Interval = 750
        Me.BackColor = Color.Black
        blink = True
        count = 0
        Wrong.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer2.Enabled = True
        Timer2.Interval = 1000
        Timer2Length = 0
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If (Timer2Length < 3) Then
            FireworksGif.Visible = True
            Timer2Length += 1
        Else
            FireworksGif.Visible = False
        End If
    End Sub
End Class