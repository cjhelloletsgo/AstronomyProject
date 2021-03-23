Public Class Home
    Dim datalocation As String
    Dim maxnum As Integer
    Public savelocation As String
    Private Sub StartingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim information = My.Computer.FileSystem.GetFileInfo("AstronomyProject\sounds\space1.wav")
        savelocation = information.FullName.Substring(0, information.FullName.Length - 61) + "sounds\"
        My.Computer.Audio.Play(savelocation + "space1.wav")
        QuizzesButton.Visible = False
        LessonsButton.Visible = False
        QuizzesButton.FlatStyle = FlatStyle.Flat
        QuizzesButton.FlatAppearance.BorderSize = 0
        LessonsButton.FlatStyle = FlatStyle.Flat
        LessonsButton.FlatAppearance.BorderSize = 0
        LoginButton.FlatStyle = FlatStyle.Flat
        LoginButton.FlatAppearance.BorderSize = 0
        QuizzesButton.Enabled = False
        LessonsButton.Enabled = False
    End Sub
    Private Sub QuizzesButton_Click(sender As Object, e As EventArgs) Handles QuizzesButton.Click
        Quizzes.Show()
        Me.Hide()
    End Sub
    Private Sub LessonsButton_Click(sender As Object, e As EventArgs) Handles LessonsButton.Click
        Lessons.Show()
        Me.Hide()
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim information = My.Computer.FileSystem.GetFileInfo("Database1.mdb")
        datalocation = information.FullName.Substring(0, information.FullName.Length - 40) + "Database1.mdb"
        Dim mycon As New OleDb.OleDbConnection
        Dim myds As New DataSet

        Try
            mycon.ConnectionString = $"Provider=Microsoft.ACE.OLEDB.12.0; 
                                      Data Source = {datalocation};
                                      Persist Security Info=False;"
            mycon.Open()
            Dim myda As New OleDb.OleDbDataAdapter
            Dim sql As String
            sql = "Select * From Students"
            myda = New OleDb.OleDbDataAdapter(sql, mycon)
            myda.Fill(myds, "MyStudents")
            maxnum = myds.Tables("MyStudents").Rows.Count

            Dim passwordAttempt As String
            Dim usernameAttempt As String
            passwordAttempt = passwordTextbox.Text
            usernameAttempt = usernameTextbox.Text
            MsgBox(datalocation)
            For index = 0 To maxnum - 1
                If usernameAttempt = myds.Tables("MyStudents").Rows(index).Item(0) Then
                    If passwordAttempt = myds.Tables("MyStudents").Rows(index).Item(1) Then
                        Label4.Visible = False
                        Label5.Visible = False
                        usernameTextbox.Visible = False
                        passwordTextbox.Visible = False
                        QuizzesButton.Visible = True
                        LessonsButton.Visible = True
                        QuizzesButton.Enabled = True
                        LessonsButton.Enabled = True
                        mycon.Close()
                    Else
                        MsgBox(datalocation)
                        MsgBox("Login Failed, please try again")
                    End If
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Error - " & ex.Message & vbNewLine & "can not connect to database")
        End Try
    End Sub
End Class