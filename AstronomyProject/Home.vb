﻿Public Class Home
    Dim datalocation As String
    Dim maxnum As Integer
    Public savelocation As String
    Public currentuser As Integer
    Dim rs As New Resizer
    Dim passwordAttempt As String
    Dim usernameAttempt As String
    Dim information = My.Computer.FileSystem.GetFileInfo("Database1.mdb")
    Dim dblocation As String
    Dim mycon As New OleDb.OleDbConnection
    Dim myds As New DataSet

    Private Sub StartingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs.FindAllControls(Me)
        Me.WindowState = FormWindowState.Maximized
        Dim information = My.Computer.FileSystem.GetFileInfo("AstronomyProject\sounds\space1.wav")
        savelocation = information.FullName.Substring(0, information.FullName.Length - 61) + "sounds\"
        'My.Computer.Audio.Play(savelocation + "space1.wav")
        QuizzesButton.Visible = False
        LessonsButton.Visible = False
        QuizzesButton.FlatStyle = FlatStyle.Flat
        QuizzesButton.FlatAppearance.BorderSize = 0
        LessonsButton.FlatStyle = FlatStyle.Flat
        LessonsButton.FlatAppearance.BorderSize = 0
        LoginButton.FlatStyle = FlatStyle.Flat
        LoginButton.FlatAppearance.BorderSize = 0
        NewUserButton.FlatStyle = FlatStyle.Flat
        NewUserButton.FlatAppearance.BorderSize = 0
        quitButton.FlatStyle = FlatStyle.Flat
        quitButton.FlatAppearance.BorderSize = 0
        teacherModeButton.FlatStyle = FlatStyle.Flat
        teacherModeButton.FlatAppearance.BorderSize = 0
        QuizzesButton.Enabled = False
        LessonsButton.Enabled = False
    End Sub
    Private Sub StartingForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub
    Private Sub QuizzesButton_Click(sender As Object, e As EventArgs) Handles QuizzesButton.Click
        Quizzes.Show()
        Me.Hide()
    End Sub
    Private Sub LessonsButton_Click(sender As Object, e As EventArgs) Handles LessonsButton.Click
        Lessons.Show()
        Me.Hide()
    End Sub

    Private Sub GamesButton_Click(sender As Object, e As EventArgs)
        SnakeForm.Show()
        Me.Close()
    End Sub


    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click

        dblocation = information.FullName.Substring(0, information.FullName.Length - 40) + "Database1.mdb"
        Try
            mycon.ConnectionString = $"Provider=Microsoft.ACE.OLEDB.12.0; 
                                      Data Source = {dblocation};
                                      Persist Security Info=False;"
            mycon.Open()
            Dim myda As New OleDb.OleDbDataAdapter
            Dim sql As String
            sql = "Select * From Students"
            myda = New OleDb.OleDbDataAdapter(sql, mycon)
            myda.Fill(myds, "MyStudents")
            maxnum = myds.Tables("MyStudents").Rows.Count


            passwordAttempt = passwordTextbox.Text
            usernameAttempt = usernameTextbox.Text

            For index = 0 To maxnum - 1
                If usernameAttempt = myds.Tables("MyStudents").Rows(index).Item(0) Then
                    If passwordAttempt = myds.Tables("MyStudents").Rows(index).Item(1) Then
                        Label4.Visible = False
                        Label5.Visible = False
                        LoginButton.Visible = False
                        usernameTextbox.Visible = False
                        passwordTextbox.Visible = False
                        NewUserButton.Visible = False
                        QuizzesButton.Visible = True
                        LessonsButton.Visible = True
                        QuizzesButton.Enabled = True
                        LessonsButton.Enabled = True

                        currentuser = myds.Tables("MyStudents").Rows(index).Item(2)
                        mycon.Close()
                    Else
                        MsgBox("Login Failed, please try again")
                    End If
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error - " & ex.Message & vbNewLine & "can not connect to database")
        End Try
    End Sub

    Private Sub skip_Click(sender As Object, e As EventArgs)
        Me.Hide()
        usernameAttempt = "colton"
        passwordAttempt = "1234"
        Lessons.Show()
    End Sub

    Private Sub quitButton_Click(sender As Object, e As EventArgs) Handles quitButton.Click
        Application.Exit()
    End Sub
    Private Sub QuizzesButton_MouseHover(sender As Object, e As EventArgs) Handles QuizzesButton.MouseHover
        ToolTip1.SetToolTip(QuizzesButton, "Check your knowledge!")
    End Sub

    Private Sub LessonsButton_MouseHover(sender As Object, e As EventArgs) Handles LessonsButton.MouseHover
        ToolTip2.SetToolTip(LessonsButton, "Learn about the subjects!")
    End Sub
    Private Sub teacherModeButton_Click(sender As Object, e As EventArgs)
        Teacher.Show()
        Me.Hide()
    End Sub

    Private Sub AddUserButton_Click(sender As Object, e As EventArgs) Handles NewUserButton.Click
        NewUser.Show()
    End Sub
    Private Sub teacherModeButton_Click_1(sender As Object, e As EventArgs) Handles teacherModeButton.Click
        Teacher.Show()
        Me.Hide()
    End Sub
End Class