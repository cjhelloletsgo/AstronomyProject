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
                        MsgBox($"{newname} has been added successfully")
                        NewUser.Dispose()

                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error - " & ex.Message & vbNewLine & "Failed to add new user.")
            End Try

        Else
            MsgBox("passwords do not match!")
        End If
        Me.Hide()
    End Sub
End Class