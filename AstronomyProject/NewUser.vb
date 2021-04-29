Public Class NewUser
    Dim datalocation As String
    Dim Sql As String
    Dim information = My.Computer.FileSystem.GetFileInfo("Database1.mdb")
    Dim myds As New DataSet
    Dim count As Integer

    Private Sub NewUserButton_Click(sender As Object, e As EventArgs) Handles EnterButton.Click


        datalocation = Information.FullName.Substring(0, Information.FullName.Length - 40) + "Database1.mdb"
        Using connection As New OleDb.OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0; 
                                      Data Source = {datalocation};
                                      Persist Security Info=False;")
            Dim myda As New OleDb.OleDbDataAdapter
            Sql = "Select * From Students"

            myda = New OleDb.OleDbDataAdapter(Sql, connection)
            myda.Fill(myds, "StudentQuestions")

            count = 0
            For row As Integer = 0 To myds.Tables("StudentQuestions").Rows.Count - 1
                If StudentIdTextBox.Text = myds.Tables("StudentQuestions").Rows(row).Item(2) Then

                Else
                    count += 1
                End If
            Next
        End Using


        If count = myds.Tables("StudentQuestions").Rows.Count Then
            PassCheck.Dispose()
            PassCheck.Show()
        Else
            MsgBox("can not add new user, user is already in database")
        End If


    End Sub
End Class