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

        sql = "Select * From lesson1Questions"


        myda = New OleDb.OleDbDataAdapter(sql, mycon)
        myda.Fill(myds, "MyQuestions")

        mycon.Close()
    End Sub
End Class