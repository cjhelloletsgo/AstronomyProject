Public Class Students
    Dim datalocation As String
    Dim myds As New DataSet
    Dim rs As New Resizer
    Dim chapter As Integer
    Private Sub StartingForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub
    Private Sub Students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        'For each student
        sql = "Select Distinct S1.StudentID, S1.Grade As quiz1Grade, S2.Grade As quiz2Grade, S3.Grade As quiz3Grade
        From StudentQuestions1 As S1, StudentQuestions2 As S2, StudentQuestions3 As S3"

        myda = New OleDb.OleDbDataAdapter(sql, mycon)
        myda.Fill(myds, "Student")
        mycon.Close()

        Label1.Text = myds.Tables("Student").Rows(0).Item(0)
        Label2.Text = $"{Math.Round(myds.Tables("Student").Rows(0).Item(1), 2) * 100}%"
        Label3.Text = $"{Math.Round(myds.Tables("Student").Rows(0).Item(2), 2) * 100}%"
        Label4.Text = $"{Math.Round(myds.Tables("Student").Rows(0).Item(3), 2) * 100}%"

        Label9.Text = myds.Tables("Student").Rows(0).Item(0)
        Label10.Text = $"{Math.Round(myds.Tables("Student").Rows(1).Item(1), 2) * 100}%"
        Label11.Text = $"{Math.Round(myds.Tables("Student").Rows(1).Item(2), 2) * 100}%"
        Label12.Text = $"{Math.Round(myds.Tables("Student").Rows(1).Item(3), 2) * 100}%"

        Label13.Text = myds.Tables("Student").Rows(0).Item(0)
        Label14.Text = $"{Math.Round(myds.Tables("Student").Rows(2).Item(1), 2) * 100}%"
        Label15.Text = $"{Math.Round(myds.Tables("Student").Rows(2).Item(2), 2) * 100}%"
        Label16.Text = $"{Math.Round(myds.Tables("Student").Rows(2).Item(3), 2) * 100}%"

    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Me.Dispose()
        Home.Show()
    End Sub
End Class