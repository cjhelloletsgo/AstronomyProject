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
        Dim maxnum As Integer
        maxnum = myds.Tables("Student").Rows.Count

        Dim i As Integer
        'This will 100% give you cancer, but I'm running out of time

        Try
            i = 0
            Label1.Text = myds.Tables("Student").Rows(0).Item(0)
            Label2.Text = $"{Math.Round(myds.Tables("Student").Rows(0).Item(1), 2) * 100}%"
            Label3.Text = $"{Math.Round(myds.Tables("Student").Rows(0).Item(2), 2) * 100}%"
            Label4.Text = $"{Math.Round(myds.Tables("Student").Rows(0).Item(3), 2) * 100}%"

            i = 1
            Label9.Text = myds.Tables("Student").Rows(1).Item(0)
            Label10.Text = $"{Math.Round(myds.Tables("Student").Rows(1).Item(1), 2) * 100}%"
            Label11.Text = $"{Math.Round(myds.Tables("Student").Rows(1).Item(2), 2) * 100}%"
            Label12.Text = $"{Math.Round(myds.Tables("Student").Rows(1).Item(3), 2) * 100}%"

            i = 2
            Label13.Text = myds.Tables("Student").Rows(2).Item(0)
            Label14.Text = $"{Math.Round(myds.Tables("Student").Rows(2).Item(1), 2) * 100}%"
            Label15.Text = $"{Math.Round(myds.Tables("Student").Rows(2).Item(2), 2) * 100}%"
            Label16.Text = $"{Math.Round(myds.Tables("Student").Rows(2).Item(3), 2) * 100}%"

            i = 3
            Label17.Text = myds.Tables("Student").Rows(3).Item(0)
            Label18.Text = $"{Math.Round(myds.Tables("Student").Rows(2).Item(1), 2) * 100}%"
            Label19.Text = $"{Math.Round(myds.Tables("Student").Rows(2).Item(2), 2) * 100}%"
            Label20.Text = $"{Math.Round(myds.Tables("Student").Rows(2).Item(3), 2) * 100}%"

            i = 4
            Label21.Text = myds.Tables("Student").Rows(2).Item(0)
            Label22.Text = $"{Math.Round(myds.Tables("Student").Rows(2).Item(1), 2) * 100}%"
            Label23.Text = $"{Math.Round(myds.Tables("Student").Rows(2).Item(2), 2) * 100}%"
            Label24.Text = $"{Math.Round(myds.Tables("Student").Rows(2).Item(3), 2) * 100}%"

            i = 5
            Label25.Text = myds.Tables("Student").Rows(2).Item(0)
            Label26.Text = $"{Math.Round(myds.Tables("Student").Rows(2).Item(1), 2) * 100}%"
            Label27.Text = $"{Math.Round(myds.Tables("Student").Rows(2).Item(2), 2) * 100}%"
            Label28.Text = $"{Math.Round(myds.Tables("Student").Rows(2).Item(3), 2) * 100}%"

            i = 6
            Label29.Text = myds.Tables("Student").Rows(2).Item(0)
            Label30.Text = $"{Math.Round(myds.Tables("Student").Rows(2).Item(1), 2) * 100}%"
            Label31.Text = $"{Math.Round(myds.Tables("Student").Rows(2).Item(2), 2) * 100}%"
            Label32.Text = $"{Math.Round(myds.Tables("Student").Rows(2).Item(3), 2) * 100}%"

            i = 7
        Catch ex As Exception

        End Try


        If i = 3 Then
            Label17.Text = ""
            Label18.Text = ""
            Label19.Text = ""
            Label20.Text = ""

            Label21.Text = ""
            Label22.Text = ""
            Label23.Text = ""
            Label24.Text = ""

            Label25.Text = ""
            Label26.Text = ""
            Label27.Text = ""
            Label28.Text = ""

            Label29.Text = ""
            Label30.Text = ""
            Label31.Text = ""
            Label32.Text = ""
        End If

        If i = 4 Then

            Label21.Text = ""
            Label22.Text = ""
            Label23.Text = ""
            Label24.Text = ""

            Label25.Text = ""
            Label26.Text = ""
            Label27.Text = ""
            Label28.Text = ""

            Label29.Text = ""
            Label30.Text = ""
            Label31.Text = ""
            Label32.Text = ""
        End If

        If i = 5 Then

            Label25.Text = ""
            Label26.Text = ""
            Label27.Text = ""
            Label28.Text = ""

            Label29.Text = ""
            Label30.Text = ""
            Label31.Text = ""
            Label32.Text = ""
        End If

        If i = 6 Then
            Label29.Text = ""
            Label30.Text = ""
            Label31.Text = ""
            Label32.Text = ""
        End If


    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        Teacher.Dispose()
        Me.Dispose()
        Home.Show()
    End Sub
End Class