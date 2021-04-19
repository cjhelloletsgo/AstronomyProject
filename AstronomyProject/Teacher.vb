Public Class Teacher
    Dim datalocation As String
    Dim myds As New DataSet
    Private Sub Teacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        ''For eace student
        'sql = "Select Distinct Case S1.StudentID, S1.Grade As quiz1Grade, S2.Grade As quiz2Grade, S3.Grade As quiz3Grade
        'From StudentQuestions1 As S1, StudentQuestions2 As S2, StudentQuestions3 As S3"

        'Average score per question
        sql = "Select Abs((Avg(Q1))), Abs(Avg(Q2)), Abs((Avg(Q3))), Abs((Avg(Q3))), Abs((Avg(Q4))), Abs((Avg(Q5))),  Abs((Avg(Q6))),  Abs((Avg(Q7))),  Abs((Avg(Q8))),  Abs((Avg(Q9))),  Abs((Avg(Q10))),  Abs((Avg(Q11))),  Abs((Avg(Q12))),  Abs((Avg(Q13))),  Abs((Avg(Q14))), Abs((Avg(Q15)))
        From StudentQuestions1"
        myda = New OleDb.OleDbDataAdapter(sql, mycon)
        myda.Fill(myds, "Teacher")

        Label1.Text = myds.Tables("Teacher").Rows(0).Item(0)
        Label2.Text = myds.Tables("Teacher").Rows(0).Item(1)
        Label3.Text = myds.Tables("Teacher").Rows(0).Item(2)

        mycon.Close()
    End Sub
End Class