Public Class PassCheck
    Dim datalocation As String
    Dim myds As New DataSet
    Dim sql As String
    Dim newname As String
    Dim information = My.Computer.FileSystem.GetFileInfo("Database1.mdb")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = NewUser.passwordTextbox.Text Then
            Try

                datalocation = information.FullName.Substring(0, information.FullName.Length - 40) + "Database1.mdb"
                Using connection As New OleDb.OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0; 
                                      Data Source = {datalocation};
                                      Persist Security Info=False;")
                    Dim myda As New OleDb.OleDbDataAdapter
                    sql = "Select * From Students"

                    myda = New OleDb.OleDbDataAdapter(sql, connection)
                    myda.Fill(myds, "StudentQuestions")

                    Using command As New OleDb.OleDbCommand($"INSERT INTO Students (username,pass,studentid) VALUES (@username,@pass,@studentid)", connection)

                        command.Parameters.AddWithValue("@username", NewUser.usernameTextbox.Text)
                        command.Parameters.AddWithValue("@pass", NewUser.passwordTextbox.Text)
                        command.Parameters.AddWithValue("@studentid", CLng(NewUser.StudentIdTextBox.Text))

                        connection.Open()
                        command.ExecuteNonQuery()
                        newname = NewUser.usernameTextbox.Text
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error - " & ex.Message & vbNewLine & "Failed to add new user.")
            End Try

        Else
            MsgBox("passwords do not match!")
        End If

        Try
            Using connection As New OleDb.OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0; 
                                      Data Source = {datalocation};
                                      Persist Security Info=False;")
                Dim myda As New OleDb.OleDbDataAdapter

                Dim studentid, table As String
                table = "StudentQuestions1"
                studentid = NewUser.StudentIdTextBox.Text
                sql = $"Select  * 
                       From {table}"

                myda = New OleDb.OleDbDataAdapter(sql, connection)
                myda.Fill(myds, "StudentQuestions")

                Using command As New OleDb.OleDbCommand($"INSERT INTO {table} (StudentID,Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q8,Q9,Q10,Q11,Q12,Q13,Q14,Q15,Score,Grade) VALUES (@StudentID, @Q1, @Q2, @Q3, @Q4, @Q5, @Q6, @Q7, @Q8, @Q9, @Q10, @Q11, @Q12,
                                                                           @Q13, @Q14, @Q15, @Score, @Grade)", connection)

                    command.Parameters.AddWithValue("@StudentID", NewUser.StudentIdTextBox.Text)
                    command.Parameters.AddWithValue("@Q1", 0)
                    command.Parameters.AddWithValue("@Q2", 0)
                    command.Parameters.AddWithValue("@Q3", 0)
                    command.Parameters.AddWithValue("@Q4", 0)
                    command.Parameters.AddWithValue("@Q5", 0)
                    command.Parameters.AddWithValue("@Q6", 0)
                    command.Parameters.AddWithValue("@Q7", 0)
                    command.Parameters.AddWithValue("@Q8", 0)
                    command.Parameters.AddWithValue("@Q9", 0)
                    command.Parameters.AddWithValue("@Q10", 0)
                    command.Parameters.AddWithValue("@Q11", 0)
                    command.Parameters.AddWithValue("@Q12", 0)
                    command.Parameters.AddWithValue("@Q13", 0)
                    command.Parameters.AddWithValue("@Q14", 0)
                    command.Parameters.AddWithValue("@Q15", 0)
                    command.Parameters.AddWithValue("@Score", 0)
                    command.Parameters.AddWithValue("@Grade", 0)
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error - " & ex.Message & vbNewLine & "Error in Table 1.")
        End Try

        Try
            Using connection As New OleDb.OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0; 
                                      Data Source = {datalocation};
                                      Persist Security Info=False;")
                Dim myda As New OleDb.OleDbDataAdapter

                Dim studentid, table As String
                table = "StudentQuestions2"
                studentid = NewUser.StudentIdTextBox.Text
                sql = $"Select  * 
                       From {table}"

                myda = New OleDb.OleDbDataAdapter(sql, connection)
                myda.Fill(myds, "StudentQuestions")

                Using command As New OleDb.OleDbCommand($"INSERT INTO {table} (StudentID,Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q8,Q9,Q10,Q11,Q12,Q13,Q14,Q15,Score,Grade) VALUES (@StudentID, @Q1, @Q2, @Q3, @Q4, @Q5, @Q6, @Q7, @Q8, @Q9, @Q10, @Q11, @Q12,
                                                                           @Q13, @Q14, @Q15, @Score, @Grade)", connection)

                    command.Parameters.AddWithValue("@StudentID", NewUser.StudentIdTextBox.Text)
                    command.Parameters.AddWithValue("@Q1", 0)
                    command.Parameters.AddWithValue("@Q2", 0)
                    command.Parameters.AddWithValue("@Q3", 0)
                    command.Parameters.AddWithValue("@Q4", 0)
                    command.Parameters.AddWithValue("@Q5", 0)
                    command.Parameters.AddWithValue("@Q6", 0)
                    command.Parameters.AddWithValue("@Q7", 0)
                    command.Parameters.AddWithValue("@Q8", 0)
                    command.Parameters.AddWithValue("@Q9", 0)
                    command.Parameters.AddWithValue("@Q10", 0)
                    command.Parameters.AddWithValue("@Q11", 0)
                    command.Parameters.AddWithValue("@Q12", 0)
                    command.Parameters.AddWithValue("@Q13", 0)
                    command.Parameters.AddWithValue("@Q14", 0)
                    command.Parameters.AddWithValue("@Q15", 0)
                    command.Parameters.AddWithValue("@Score", 0)
                    command.Parameters.AddWithValue("@Grade", 0)
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error - " & ex.Message & vbNewLine & "Error in Table 2.")
        End Try

        Try
            Using connection As New OleDb.OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0; 
                                      Data Source = {datalocation};
                                      Persist Security Info=False;")
                Dim myda As New OleDb.OleDbDataAdapter

                Dim studentid, table As String
                table = "StudentQuestions3"
                studentid = NewUser.StudentIdTextBox.Text
                sql = $"Select  * 
                       From {table}"

                myda = New OleDb.OleDbDataAdapter(sql, connection)
                myda.Fill(myds, "StudentQuestions")

                Using command As New OleDb.OleDbCommand($"INSERT INTO {table} (StudentID,Q1,Q2,Q3,Q4,Q5,Q6,Q7,Q8,Q9,Q10,Q11,Q12,Q13,Q14,Q15,Score,Grade) VALUES (@StudentID, @Q1, @Q2, @Q3, @Q4, @Q5, @Q6, @Q7, @Q8, @Q9, @Q10, @Q11, @Q12,
                                                                           @Q13, @Q14, @Q15, @Score, @Grade)", connection)

                    command.Parameters.AddWithValue("@StudentID", NewUser.StudentIdTextBox.Text)
                    command.Parameters.AddWithValue("@Q1", 0)
                    command.Parameters.AddWithValue("@Q2", 0)
                    command.Parameters.AddWithValue("@Q3", 0)
                    command.Parameters.AddWithValue("@Q4", 0)
                    command.Parameters.AddWithValue("@Q5", 0)
                    command.Parameters.AddWithValue("@Q6", 0)
                    command.Parameters.AddWithValue("@Q7", 0)
                    command.Parameters.AddWithValue("@Q8", 0)
                    command.Parameters.AddWithValue("@Q9", 0)
                    command.Parameters.AddWithValue("@Q10", 0)
                    command.Parameters.AddWithValue("@Q11", 0)
                    command.Parameters.AddWithValue("@Q12", 0)
                    command.Parameters.AddWithValue("@Q13", 0)
                    command.Parameters.AddWithValue("@Q14", 0)
                    command.Parameters.AddWithValue("@Q15", 0)
                    command.Parameters.AddWithValue("@Score", 0)
                    command.Parameters.AddWithValue("@Grade", 0)
                    connection.Open()
                    command.ExecuteNonQuery()
                    MsgBox($"{newname} has been added successfully")

                    Home.usernameTextbox.Text = NewUser.usernameTextbox.Text
                    Home.passwordTextbox.Text = NewUser.passwordTextbox.Text
                End Using
            End Using
            NewUser.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error - " & ex.Message & vbNewLine & "Error in Table 3.")
        End Try

        Me.Hide()
    End Sub

    Private Sub PassCheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class