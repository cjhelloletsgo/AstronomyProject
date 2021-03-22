﻿Public Class ShootingStars
    Dim score As Integer
    Dim x As Integer
    Dim y As Integer
    Dim i As Integer
    Dim j As Integer
    Dim a As Integer
    Dim b As Integer
    Dim Savelocation = Home.Savelocation
    Dim launch = False
    Dim maxnum As Integer
    Dim correctAns As Char
    Dim clickedButton As Char
    Dim correctAnsSelected As Boolean
    Dim index As Integer
    Dim myds As New DataSet

    Private Sub handleSelection()
        ButtonA.Enabled = False
        ButtonB.Enabled = False
        ButtonC.Enabled = False
        ButtonD.Enabled = False
        If correctAns = clickedButton Then
            Label1.Text = "Right"
            correctAnsSelected = True
            If j > 10 Then
                j = j - 10
            Else j = 0
            End If
            score += 1
            ScoreLabel.Text = score
        Else Label1.Text = "Wrong"
            correctAnsSelected = False
        End If
        index += 1
        runGame()
    End Sub
    Private Sub ShootingStars_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
        Timer2.Enabled = False
        Explosion.Visible = False
        x = Rocket.Location.X()
        y = Rocket.Location.Y()
        a = GoodPlanet.Location.X()
        b = GoodPlanet.Location.Y()
        i = 1
        j = 1
        Rocket.Enabled = False
        My.Computer.Audio.Stop()
        StartButton.FlatStyle = FlatStyle.Flat
        StartButton.FlatAppearance.BorderSize = 0
        BackButton.FlatStyle = FlatStyle.Flat
        BackButton.FlatAppearance.BorderSize = 0
        HomeButton.FlatStyle = FlatStyle.Flat
        HomeButton.FlatAppearance.BorderSize = 0
        ButtonA.FlatStyle = FlatStyle.Flat
        ButtonA.FlatAppearance.BorderSize = 0
        ButtonB.FlatStyle = FlatStyle.Flat
        ButtonB.FlatAppearance.BorderSize = 0
        ButtonC.FlatStyle = FlatStyle.Flat
        ButtonC.FlatAppearance.BorderSize = 0
        ButtonD.FlatStyle = FlatStyle.Flat
        ButtonD.FlatAppearance.BorderSize = 0
        launch = False
    End Sub
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        Dim information = My.Computer.FileSystem.GetFileInfo("Database1.mdb")
        Savelocation = information.FullName.Substring(0, information.FullName.Length - 40) + "Database1.mdb"
        Dim mycon As New OleDb.OleDbConnection


        Try
            mycon.ConnectionString = $"Provider=Microsoft.ACE.OLEDB.12.0; 
                                      Data Source = {Savelocation};
                                      Persist Security Info=False;"
            mycon.Open()
        Catch ex As Exception
            MessageBox.Show("Error - " & ex.Message & vbNewLine & "can not connect to database")
        End Try

        Dim myda As New OleDb.OleDbDataAdapter
        Dim sql As String
        sql = "Select * From Questions"
        myda = New OleDb.OleDbDataAdapter(sql, mycon)
        myda.Fill(myds, "MyQuestions")
        maxnum = myds.Tables("MyQuestions").Rows.Count
        Timer1.Enabled = True
        Timer2.Enabled = True
        Rocket.Enabled = True
        StartButton.Enabled = False
        index = 0
        runGame()
    End Sub
    Private Sub endGame()
        MsgBox("game over")
    End Sub
    Private Sub runGame()
        If index >= myds.Tables("MyQuestions").Rows.Count Then
            endGame()
        Else
            QuestionLabel.Text = myds.Tables("MyQuestions").Rows(index).Item(0)
            ButtonA.Text = myds.Tables("MyQuestions").Rows(index).Item(1)
            ButtonB.Text = myds.Tables("MyQuestions").Rows(index).Item(2)
            ButtonC.Text = myds.Tables("MyQuestions").Rows(index).Item(3)
            ButtonD.Text = myds.Tables("MyQuestions").Rows(index).Item(4)
            correctAns = myds.Tables("MyQuestions").Rows(index).Item(5)
            ButtonA.Enabled = True
            ButtonB.Enabled = True
            ButtonC.Enabled = True
            ButtonD.Enabled = True
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        i += 1
        j += 1
        If launch = False Then
            Rocket.Left = x + 2 * j
            Rocket.Top = -15 * Math.Sqrt(j) + y
            'Add in rotation here
        Else
            Rocket.Top -= 3
        End If
        GoodPlanet.Left = a + Math.Cos(i / 5) * 50
        GoodPlanet.Top = b + Math.Sin(i / 5) * 50
        Explosion.Left = a + Math.Cos(i / 5) * 50
        Explosion.Top = b + Math.Sin(i / 5) * 50
        'x = originX + cos(angle)*radius;
        'y = originY + sin(angle)*radius;
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Rocket.Location.Y < GoodPlanet.Location.Y + GoodPlanet.Height - 0 And
            Rocket.Location.X + Rocket.Width > GoodPlanet.Location.X Then
            GoodPlanet.Visible = False
            Explosion.Visible = True
            Rocket.Visible = False
            My.Computer.Audio.Play(Savelocation + "explosion-01.wav")
            Timer1.Enabled = False
            Timer2.Enabled = False
            'MsgBox("Game Over")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles Rocket.Click
        score += 1
        launch = True
        'Return to start
        'j = 1
        'Rocket.Location = New Point(x, y)
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
    Private Sub ButtonA_Click(sender As Object, e As EventArgs) Handles ButtonA.Click
        clickedButton = "A"
        handleSelection()
    End Sub

    Private Sub ButtonB_Click(sender As Object, e As EventArgs) Handles ButtonB.Click
        clickedButton = "B"
        handleSelection()
    End Sub

    Private Sub ButtonC_Click(sender As Object, e As EventArgs) Handles ButtonC.Click
        clickedButton = "C"
        handleSelection()
    End Sub

    Private Sub ButtonD_Click(sender As Object, e As EventArgs) Handles ButtonD.Click
        clickedButton = "D"
        handleSelection()
    End Sub
End Class