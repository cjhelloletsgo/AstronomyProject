Public Class Teacher
    Dim datalocation As String
    Dim myds As New DataSet
    Dim rs As New Resizer
    Dim chapter As Integer
    Private Sub StartingForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub
    Private Sub Teacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs.FindAllControls(Me)
        Me.WindowState = FormWindowState.Maximized


    End Sub

    Private Sub getdata()
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
        sql = ""
        If chapter = 1 Then
            sql = "Select Abs((Avg(Q1))), Abs(Avg(Q2)), Abs((Avg(Q3))), Abs((Avg(Q3))), Abs((Avg(Q4))), Abs((Avg(Q5))),  Abs((Avg(Q6))),  Abs((Avg(Q7))),  Abs((Avg(Q8))),  Abs((Avg(Q9))),  Abs((Avg(Q10))),  Abs((Avg(Q11))),  Abs((Avg(Q12))),  Abs((Avg(Q13))),  Abs((Avg(Q14))), Abs((Avg(Q15)))
        From StudentQuestions1"
        ElseIf chapter = 2 Then
            sql = "Select Abs((Avg(Q1))), Abs(Avg(Q2)), Abs((Avg(Q3))), Abs((Avg(Q3))), Abs((Avg(Q4))), Abs((Avg(Q5))),  Abs((Avg(Q6))),  Abs((Avg(Q7))),  Abs((Avg(Q8))),  Abs((Avg(Q9))),  Abs((Avg(Q10))),  Abs((Avg(Q11))),  Abs((Avg(Q12))),  Abs((Avg(Q13))),  Abs((Avg(Q14))), Abs((Avg(Q15)))
        From StudentQuestions2"
        ElseIf chapter = 3 Then
            sql = "Select Abs((Avg(Q1))), Abs(Avg(Q2)), Abs((Avg(Q3))), Abs((Avg(Q3))), Abs((Avg(Q4))), Abs((Avg(Q5))),  Abs((Avg(Q6))),  Abs((Avg(Q7))),  Abs((Avg(Q8))),  Abs((Avg(Q9))),  Abs((Avg(Q10))),  Abs((Avg(Q11))),  Abs((Avg(Q12))),  Abs((Avg(Q13))),  Abs((Avg(Q14))), Abs((Avg(Q15)))
        From StudentQuestions3"
        End If

        myda = New OleDb.OleDbDataAdapter(sql, mycon)
        myda.Fill(myds, "Teacher")

        Label1.Text = $" Question 1: {(Math.Round(myds.Tables("Teacher").Rows(0).Item(0), 2)) * 100 }%"
        Label2.Text = $" Question 2: {(Math.Round(myds.Tables("Teacher").Rows(0).Item(1), 2)) * 100 }%"
        Label3.Text = $" Question 3: {(Math.Round(myds.Tables("Teacher").Rows(0).Item(2), 2)) * 100 }%"
        Label4.Text = $" Question 4: {(Math.Round(myds.Tables("Teacher").Rows(0).Item(3), 2)) * 100 }%"
        Label5.Text = $" Question 5: {(Math.Round(myds.Tables("Teacher").Rows(0).Item(4), 2)) * 100 }%"
        Label6.Text = $" Question 6: {(Math.Round(myds.Tables("Teacher").Rows(0).Item(5), 2)) * 100 }%"
        Label7.Text = $" Question 7: {(Math.Round(myds.Tables("Teacher").Rows(0).Item(6), 2)) * 100 }%"
        Label8.Text = $" Question 8: {(Math.Round(myds.Tables("Teacher").Rows(0).Item(7), 2)) * 100 }%"
        Label9.Text = $" Question 9: {(Math.Round(myds.Tables("Teacher").Rows(0).Item(8), 2)) * 100 }%"
        Label10.Text = $" Question 10: {(Math.Round(myds.Tables("Teacher").Rows(0).Item(9), 2)) * 100 }%"
        Label11.Text = $" Question 11: {(Math.Round(myds.Tables("Teacher").Rows(0).Item(10), 2)) * 100 }%"
        Label12.Text = $" Question 12: {(Math.Round(myds.Tables("Teacher").Rows(0).Item(11), 2)) * 100 }%"
        Label13.Text = $" Question 13: {(Math.Round(myds.Tables("Teacher").Rows(0).Item(12), 2)) * 100 }%"
        Label14.Text = $" Question 14: {(Math.Round(myds.Tables("Teacher").Rows(0).Item(13), 2)) * 100 }%"
        Label15.Text = $" Question 15: {(Math.Round(myds.Tables("Teacher").Rows(0).Item(14), 2)) * 100 }%"

        mycon.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        chapter = 1
        getdata()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        chapter = 2
        getdata()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        chapter = 3
        getdata()
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Home.Show()
        Me.Hide()
    End Sub
End Class