Imports System.Data.SqlClient

Public Class Login
    Dim maxnum As Integer
    Dim savelocation As String
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim information = My.Computer.FileSystem.GetFileInfo("Database1.mdb")
        savelocation = information.FullName.Substring(0, information.FullName.Length - 40) + "Database1.mdb"
        Dim mycon As New OleDb.OleDbConnection
        Dim myds As New DataSet

        Try
            mycon.ConnectionString = $"Provider=Microsoft.ACE.OLEDB.12.0; 
                                      Data Source = {savelocation};
                                      Persist Security Info=False;"
            mycon.Open()
        Catch ex As Exception
            MessageBox.Show("Error - " & ex.Message & vbNewLine & "can not connect to database")
        End Try
        'MsgBox("A Connection is now open!")
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

        For index = 0 To maxnum - 1
            If usernameAttempt = myds.Tables("MyStudents").Rows(index).Item(0) Then
                If passwordAttempt = myds.Tables("MyStudents").Rows(index).Item(1) Then
                    'Label3.Text = "login successful"
                    'Label1.Text = myds.Tables("MyStudents").Rows(index).Item(0)
                    'Label2.Text = myds.Tables("MyStudents").Rows(index).Item(1)
                    Me.Hide()
                    Home.Show()
                    mycon.Close()
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

    Private Sub usernameTextbox_TextChanged(sender As Object, e As EventArgs) Handles usernameTextbox.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub passwordTextbox_TextChanged(sender As Object, e As EventArgs) Handles passwordTextbox.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class