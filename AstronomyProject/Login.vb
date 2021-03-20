Imports System.Data.SqlClient

Public Class Login
    Dim maxnum As Integer
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim mycon As New OleDb.OleDbConnection
        Dim myds As New DataSet
        mycon.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; 
                                      Data Source = C:\Users\Colton\Documents\Database1.mdb;
                                      Persist Security Info=False;"
        mycon.Open()

        Dim myda As New OleDb.OleDbDataAdapter
        Dim sql As String
        sql = "Select * From Students"
        myda = New OleDb.OleDbDataAdapter(Sql, mycon)
        myda.Fill(myds, "MyStudents")
        maxnum = myds.Tables("MyStudents").Rows.Count

        Dim passwordAttempt As String
        Dim usernameAttempt As String
        passwordAttempt = passwordTextbox.Text
        usernameAttempt = usernameTextbox.Text

        For index = 0 To maxnum - 1
            If usernameAttempt = myds.Tables("MyStudents").Rows(index).Item(0) Then
                If passwordAttempt = myds.Tables("MyStudents").Rows(index).Item(1) Then
                    'Label3.Text = "login successful"
                    'Label1.Text = myds.Tables("MyStudents").Rows(index).Item(0)
                    'Label2.Text = myds.Tables("MyStudents").Rows(index).Item(1)
                    Me.Hide()
                    Home.Show()
                End If
            End If
        Next
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Home.Show()
        Me.Hide()
    End Sub
End Class