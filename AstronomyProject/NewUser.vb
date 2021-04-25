Public Class NewUser
    Dim datalocation As String

    Private Sub NewUserButton_Click(sender As Object, e As EventArgs) Handles EnterButton.Click
        PassCheck.Dispose()
        PassCheck.Show()
    End Sub
End Class