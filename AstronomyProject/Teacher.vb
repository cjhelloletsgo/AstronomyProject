Public Class Teacher
    Dim datalocation As String
    Dim myds As New DataSet
    Dim rs As New Resizer
    Dim chapter As Integer
    Private Sub StartingForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub
    Public Sub Teacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs.FindAllControls(Me)
        Me.WindowState = FormWindowState.Maximized

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

        ''For each student
        'sql = "Select Distinct Case S1.StudentID, S1.Grade As quiz1Grade, S2.Grade As quiz2Grade, S3.Grade As quiz3Grade
        'From StudentQuestions1 As S1, StudentQuestions2 As S2, StudentQuestions3 As S3"

        'Average score per question

        '        sql = "Select Abs((Avg(SQ1.Q1))) AS Q1Begin, Abs(Avg(SQ1.Q2)), Abs((Avg(SQ1.Q3))), Abs((Avg(SQ1.Q3))), Abs((Avg(SQ1.Q4))), Abs((Avg(SQ1.Q5))),  Abs((Avg(SQ1.Q6))),  Abs((Avg(SQ1.Q7))),  Abs((Avg(SQ1.Q8))),  Abs((Avg(SQ1.Q9))),  Abs((Avg(SQ1.Q10))),  Abs((Avg(SQ1.Q11))),  Abs((Avg(SQ1.Q12))),  Abs((Avg(SQ1.Q13))),  Abs((Avg(SQ1.Q14))), Abs((Avg(SQ1.Q15))), Abs((Avg(SQ2.Q1))) AS Q2begin
        'From StudentQuestions1 AS SQ1, StudentQuestions1 AS SQ2"

        sql = "SELECT Abs((Avg(SQ1.Q1))) AS SQ1Q1, Abs(Avg(SQ1.Q2)) AS SQ1Q2, Abs((Avg(SQ1.Q3))) AS SQ1Q3, Abs((Avg(SQ1.Q4))) AS SQ1Q4, Abs((Avg(SQ1.Q5))) AS SQ1Q5, Abs((Avg(SQ1.Q6))) AS SQ1Q6, Abs((Avg(SQ1.Q7))) AS SQ1Q7, Abs((Avg(SQ1.Q8))) AS SQ1Q8, Abs((Avg(SQ1.Q9))) AS SQ1Q9, Abs((Avg(SQ1.Q10))) AS SQ1Q10, Abs((Avg(SQ1.Q11))) AS SQ1Q11, Abs((Avg(SQ1.Q12))) AS SQ1Q12, Abs((Avg(SQ1.Q13))) AS SQ1Q13, Abs((Avg(SQ1.Q14))) AS SQ1Q14, Abs((Avg(SQ1.Q15))) AS SQ1Q15,
                      Abs((Avg(SQ2.Q1))) AS SQ2Q1, Abs(Avg(SQ2.Q2)) AS SQ2Q2, Abs((Avg(SQ2.Q3))) AS SQ2Q3, Abs((Avg(SQ2.Q4))) AS SQ2Q4, Abs((Avg(SQ2.Q5))) AS SQ2Q5, Abs((Avg(SQ2.Q6))) AS SQ2Q6, Abs((Avg(SQ2.Q7))) AS SQ2Q7, Abs((Avg(SQ2.Q8))) AS SQ2Q8, Abs((Avg(SQ2.Q9))) AS SQ2Q9, Abs((Avg(SQ2.Q10))) AS SQ2Q10, Abs((Avg(SQ2.Q11))) AS SQ2Q11, Abs((Avg(SQ2.Q12))) AS SQ2Q12, Abs((Avg(SQ2.Q13))) AS SQ2Q13, Abs((Avg(SQ2.Q14))) AS SQ2Q14, Abs((Avg(SQ2.Q15))) AS SQ2Q15, 
                      Abs((Avg(SQ3.Q1))) AS SQ3Q1, Abs(Avg(SQ3.Q2)) AS SQ3Q2, Abs((Avg(SQ3.Q3))) AS SQ3Q3, Abs((Avg(SQ3.Q4))) AS SQ3Q4, Abs((Avg(SQ3.Q5))) AS SQ3Q5, Abs((Avg(SQ3.Q6))) AS SQ3Q6, Abs((Avg(SQ3.Q7))) AS SQ3Q7, Abs((Avg(SQ3.Q8))) AS SQ3Q8, Abs((Avg(SQ3.Q9))) AS SQ3Q9, Abs((Avg(SQ3.Q10))) AS SQ3Q10, Abs((Avg(SQ3.Q11))) AS SQ3Q11, Abs((Avg(SQ3.Q12))) AS SQ3Q12, Abs((Avg(SQ3.Q13))) AS SQ3Q13, Abs((Avg(SQ3.Q14))) AS SQ3Q14, Abs((Avg(SQ3.Q15))) AS SQ3Q15
               FROM StudentQuestions1 AS SQ1, StudentQuestions2 AS SQ2, StudentQuestions3 AS SQ3;"

        myda = New OleDb.OleDbDataAdapter(sql, mycon)
        myda.Fill(myds, "Teacher")
        mycon.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = $" Question 1: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ1Q1"), 2)) * 100 }%"
        Label2.Text = $" Question 2: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ1Q2"), 2)) * 100 }%"
        Label3.Text = $" Question 3: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ1Q3"), 2)) * 100 }%"
        Label4.Text = $" Question 4: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ1Q4"), 2)) * 100 }%"
        Label5.Text = $" Question 5: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ1Q5"), 2)) * 100 }%"
        Label6.Text = $" Question 6: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ1Q6"), 2)) * 100 }%"
        Label7.Text = $" Question 7: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ1Q7"), 2)) * 100 }%"
        Label8.Text = $" Question 8: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ1Q8"), 2)) * 100 }%"
        Label9.Text = $" Question 9: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ1Q9"), 2)) * 100 }%"
        Label10.Text = $" Question 10: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ1Q10"), 2)) * 100 }%"
        Label11.Text = $" Question 11: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ1Q11"), 2)) * 100 }%"
        Label12.Text = $" Question 12: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ1Q12"), 2)) * 100 }%"
        Label13.Text = $" Question 13: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ1Q13"), 2)) * 100 }%"
        Label14.Text = $" Question 14: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ1Q14"), 2)) * 100 }%"
        Label15.Text = $" Question 15: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ1Q15"), 2)) * 100 }%"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Text = $" Question 1: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ2Q1"), 2)) * 100 }%"
        Label2.Text = $" Question 2: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ2Q2"), 2)) * 100 }%"
        Label3.Text = $" Question 3: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ2Q3"), 2)) * 100 }%"
        Label4.Text = $" Question 4: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ2Q4"), 2)) * 100 }%"
        Label5.Text = $" Question 5: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ2Q5"), 2)) * 100 }%"
        Label6.Text = $" Question 6: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ2Q6"), 2)) * 100 }%"
        Label7.Text = $" Question 7: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ2Q7"), 2)) * 100 }%"
        Label8.Text = $" Question 8: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ2Q8"), 2)) * 100 }%"
        Label9.Text = $" Question 9: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ2Q9"), 2)) * 100 }%"
        Label10.Text = $" Question 10: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ2Q10"), 2)) * 100 }%"
        Label11.Text = $" Question 11: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ2Q11"), 2)) * 100 }%"
        Label12.Text = $" Question 12: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ2Q12"), 2)) * 100 }%"
        Label13.Text = $" Question 13: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ2Q13"), 2)) * 100 }%"
        Label14.Text = $" Question 14: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ2Q14"), 2)) * 100 }%"
        Label15.Text = $" Question 15: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ2Q15"), 2)) * 100 }%"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label1.Text = $" Question 1: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ3Q1"), 2)) * 100 }%"
        Label2.Text = $" Question 2: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ3Q2"), 2)) * 100 }%"
        Label3.Text = $" Question 3: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ3Q3"), 2)) * 100 }%"
        Label4.Text = $" Question 4: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ3Q4"), 2)) * 100 }%"
        Label5.Text = $" Question 5: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ3Q5"), 2)) * 100 }%"
        Label6.Text = $" Question 6: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ3Q6"), 2)) * 100 }%"
        Label7.Text = $" Question 7: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ3Q7"), 2)) * 100 }%"
        Label8.Text = $" Question 8: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ3Q8"), 2)) * 100 }%"
        Label9.Text = $" Question 9: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ3Q9"), 2)) * 100 }%"
        Label10.Text = $" Question 10: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ3Q10"), 2)) * 100 }%"
        Label11.Text = $" Question 11: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ3Q11"), 2)) * 100 }%"
        Label12.Text = $" Question 12: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ3Q12"), 2)) * 100 }%"
        Label13.Text = $" Question 13: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ3Q13"), 2)) * 100 }%"
        Label14.Text = $" Question 14: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ3Q14"), 2)) * 100 }%"
        Label15.Text = $" Question 15: {(Math.Round(myds.Tables("Teacher").Rows(0).Item("SQ3Q15"), 2)) * 100 }%"
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Home.Show()
        Me.Dispose()
    End Sub
End Class