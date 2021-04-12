Imports System.Data.OleDb

Public Class ShootingStars
    Dim score As Integer
    Dim x As Integer
    Dim y As Integer
    Dim i As Integer
    Dim j As Integer
    Dim a As Integer
    Dim b As Integer
    Dim Savelocation = Home.savelocation
    Dim datalocation As String
    Dim launch = False
    Dim maxnum As Integer
    Dim correctAns As Char
    Dim clickedButton As Char
    Dim index As Integer
    Dim myds As New DataSet
    Dim rs As New Resizer
    Public questions = New Boolean() {False, False, False, False, False, False, False, False, False, False, False, False, False, False, False}

    Private Sub handleSelection()
        ButtonA.Enabled = False
        ButtonB.Enabled = False
        ButtonC.Enabled = False
        ButtonD.Enabled = False
        If correctAns = clickedButton Then
            questions(index) = True
            Label1.Text = "Right"
            If j > 30 Then
                j = j - 30
            Else j = 0
            End If
            score += 1
            ScoreLabel.Text = $"score: {score}"
        Else
            Label1.Text = "Wrong"
            questions(index) = False
        End If
        'saveResults()
        index += 1
        runGame()
    End Sub
    Private Sub ShootingStars_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs.FindAllControls(Me)
        Me.WindowState = FormWindowState.Maximized
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
        ButtonA.FlatStyle = FlatStyle.Flat
        ButtonA.FlatAppearance.BorderSize = 0
        ButtonB.FlatStyle = FlatStyle.Flat
        ButtonB.FlatAppearance.BorderSize = 0
        ButtonC.FlatStyle = FlatStyle.Flat
        ButtonC.FlatAppearance.BorderSize = 0
        ButtonD.FlatStyle = FlatStyle.Flat
        ButtonD.FlatAppearance.BorderSize = 0
        launch = False
        QuestionLabel.Visible = False
        fireworksPictureBox.Visible = False

        ButtonA.Enabled = False
        ButtonB.Enabled = False
        ButtonC.Enabled = False
        ButtonD.Enabled = False
    End Sub
    Private Sub ShootingStars_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub
    Public Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        StartButton.Visible = False
        Dim information = My.Computer.FileSystem.GetFileInfo("Database1.mdb")
        datalocation = information.FullName.Substring(0, information.FullName.Length - 40) + "Database1.mdb"
        Dim mycon As New OleDb.OleDbConnection

        Try
            mycon.ConnectionString = $"Provider=Microsoft.ACE.OLEDB.12.0; 
                                      Data Source = {datalocation};
                                      Persist Security Info=False;"
            mycon.Open()
        Catch ex As Exception
            MessageBox.Show("Error - " & ex.Message & vbNewLine & "can not connect to database")
        End Try

        Dim myda As New OleDb.OleDbDataAdapter
        Dim sql As String
        sql = ""
        If Quizzes.chapter = 1 Then
            sql = "Select * From lesson1Questions"
        ElseIf Quizzes.chapter = 2 Then
            sql = "Select * From lesson2Questions"
        ElseIf Quizzes.chapter = 3 Then
            sql = "Select * From lesson3Questions"
        End If

        myda = New OleDb.OleDbDataAdapter(sql, mycon)
        myda.Fill(myds, "MyQuestions")
        maxnum = myds.Tables("MyQuestions").Rows.Count
        Timer1.Enabled = True
        Timer2.Enabled = True
        Rocket.Enabled = True
        StartButton.Enabled = False
        ButtonA.Enabled = True
        ButtonB.Enabled = True
        ButtonC.Enabled = True
        ButtonD.Enabled = True
        index = 0
        mycon.Close()
        runGame()
    End Sub
    Private Sub endGame()
        Dim myds As New DataSet
        Dim percent As Double
        percent = score / maxnum
        Dim information = My.Computer.FileSystem.GetFileInfo("Database1.mdb")
        datalocation = information.FullName.Substring(0, information.FullName.Length - 40) + "Database1.mdb"
        Using connection As New OleDb.OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0; 
                                      Data Source = {datalocation};
                                      Persist Security Info=False;")
            Dim myda As New OleDb.OleDbDataAdapter
            Dim sql, table As String
            sql = ""
            table = ""
            If Quizzes.chapter = 1 Then
                sql = "Select * From StudentQuestions1"
                table = "StudentQuestions1"
            ElseIf Quizzes.chapter = 2 Then
                sql = "Select * From StudentQuestions2"
                table = "StudentQuestions2"
            ElseIf Quizzes.chapter = 3 Then
                sql = "Select * From StudentQuestions3"
                table = "StudentQuestions3"
            End If

            myda = New OleDb.OleDbDataAdapter(sql, connection)
            myda.Fill(myds, "StudentQuestions")

            Using command As New OleDb.OleDbCommand($"Delete From {table} where StudentID = @StudentID", connection)
                command.Parameters.AddWithValue("@StudentID", Home.currentuser)
                connection.Open()
                command.ExecuteNonQuery()
            End Using

            Using command As New OleDb.OleDbCommand($"INSERT INTO {table} (StudentID,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,Score) VALUES (@StudentID, @1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12,
                                                                           @13, @14, @15, @Score)", connection)

                command.Parameters.AddWithValue("@StudentID", Home.currentuser)
                command.Parameters.AddWithValue("@1", questions(0))
                command.Parameters.AddWithValue("@2", questions(1))
                command.Parameters.AddWithValue("@3", questions(2))
                command.Parameters.AddWithValue("@4", questions(3))
                command.Parameters.AddWithValue("@5", questions(4))
                command.Parameters.AddWithValue("@6", questions(5))
                command.Parameters.AddWithValue("@7", questions(6))
                command.Parameters.AddWithValue("@8", questions(7))
                command.Parameters.AddWithValue("@9", questions(8))
                command.Parameters.AddWithValue("@10", questions(9))
                command.Parameters.AddWithValue("@11", questions(10))
                command.Parameters.AddWithValue("@12", questions(11))
                command.Parameters.AddWithValue("@13", questions(12))
                command.Parameters.AddWithValue("@14", questions(13))
                command.Parameters.AddWithValue("@15", questions(14))
                command.Parameters.AddWithValue("@Score", score)
                'connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using

        If score / maxnum >= 0.8 Then
            launch = True
            fireworksPictureBox.Visible = True
        End If
        MsgBox("game over")
    End Sub
    Private Sub runGame()
        QuestionLabel.Visible = True
        If index >= maxnum Then
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
            Rocket.Left = x + 2 * j / 2
            Rocket.Top = -15 * Math.Sqrt(j) + y
            'Add in rotation here
        Else
            Rocket.Top -= 3
            If Rocket.Top + Rocket.Height < Me.Top Then
                SnakeForm.Show()
                Me.Hide()
            End If
        End If
        'divisor Controls speed
        GoodPlanet.Left = a + Math.Cos(i / 12) * 50
        GoodPlanet.Top = b + Math.Sin(i / 12) * 50
        Explosion.Left = a + Math.Cos(i / 12) * 50
        Explosion.Top = b + Math.Sin(i / 12) * 50
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
    Private Sub Home_Click(sender As Object, e As EventArgs)
        Home.Show()
        My.Computer.Audio.Stop()
        Me.Dispose()
    End Sub
    Private Sub BackButton_Click(sender As Object, e As EventArgs)
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

    Private Sub quitButton_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub
    Dim wait As Integer
End Class