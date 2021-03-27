Public Class Home
    Dim datalocation As String
    Dim maxnum As Integer
    Public savelocation As String
    Public userScore As Double
    Public currentuser As String
    Dim rs As New Resizer

    '-------------------------------------------------------------------------------
    ' Resizer
    ' This class is used to dynamically resize and reposition all controls on a form.
    ' Container controls are processed recursively so that all controls on the form
    ' are handled.
    '
    ' Usage:
    '  Resizing functionality requires only three lines of code on a form:
    '
    '  1. Create a form-level reference to the Resize class:
    '     Dim myResizer as Resizer
    '
    '  2. In the Form_Load event, call the  Resizer class FIndAllControls method:
    '     myResizer.FindAllControls(Me)
    '
    '  3. In the Form_Resize event, call the  Resizer class ResizeAllControls method:
    '     myResizer.ResizeAllControls(Me)
    '
    '-------------------------------------------------------------------------------
    Public Class Resizer

        '----------------------------------------------------------
        ' ControlInfo
        ' Structure of original state of all processed controls
        '----------------------------------------------------------
        Private Structure ControlInfo
            Public name As String
            Public parentName As String
            Public leftOffsetPercent As Double
            Public topOffsetPercent As Double
            Public heightPercent As Double
            Public originalHeight As Integer
            Public originalWidth As Integer
            Public widthPercent As Double
            Public originalFontSize As Single
        End Structure

        '-------------------------------------------------------------------------
        ' ctrlDict
        ' Dictionary of (control name, control info) for all processed controls
        '-------------------------------------------------------------------------
        Private ctrlDict As Dictionary(Of String, ControlInfo) = New Dictionary(Of String, ControlInfo)

        '----------------------------------------------------------------------------------------
        ' FindAllControls
        ' Recursive function to process all controls contained in the initially passed
        ' control container and store it in the Control dictionary
        '----------------------------------------------------------------------------------------
        Public Sub FindAllControls(thisCtrl As Control)

            '-- If the current control has a parent, store all original relative position
            '-- and size information in the dictionary.
            '-- Recursively call FindAllControls for each control contained in the
            '-- current Control
            For Each ctl As Control In thisCtrl.Controls
                Try
                    If Not IsNothing(ctl.Parent) Then
                        Dim parentHeight = ctl.Parent.Height
                        Dim parentWidth = ctl.Parent.Width

                        Dim c As New ControlInfo
                        c.name = ctl.Name
                        c.parentName = ctl.Parent.Name
                        c.topOffsetPercent = Convert.ToDouble(ctl.Top) / Convert.ToDouble(parentHeight)
                        c.leftOffsetPercent = Convert.ToDouble(ctl.Left) / Convert.ToDouble(parentWidth)
                        c.heightPercent = Convert.ToDouble(ctl.Height) / Convert.ToDouble(parentHeight)
                        c.widthPercent = Convert.ToDouble(ctl.Width) / Convert.ToDouble(parentWidth)
                        c.originalFontSize = ctl.Font.Size
                        c.originalHeight = ctl.Height
                        c.originalWidth = ctl.Width
                        ctrlDict.Add(c.name, c)
                    End If

                Catch ex As Exception
                    Debug.Print(ex.Message)
                End Try

                If ctl.Controls.Count > 0 Then
                    FindAllControls(ctl)
                End If

            Next '-- For Each

        End Sub

        '----------------------------------------------------------------------------------------
        ' ResizeAllControls
        ' Recursive function to resize and reposition all controls contained in the Control
        ' dictionary
        '----------------------------------------------------------------------------------------
        Public Sub ResizeAllControls(thisCtrl As Control)

            Dim fontRatioW As Single
            Dim fontRatioH As Single
            Dim fontRatio As Single
            Dim f As Font

            '-- Resize and reposition all controls in the passed control
            For Each ctl As Control In thisCtrl.Controls
                Try
                    If Not IsNothing(ctl.Parent) Then
                        Dim parentHeight = ctl.Parent.Height
                        Dim parentWidth = ctl.Parent.Width

                        Dim c As New ControlInfo

                        Dim ret As Boolean = False
                        Try
                            '-- Get the current control's info from the control info dictionary
                            ret = ctrlDict.TryGetValue(ctl.Name, c)

                            '-- If found, adjust the current control based on control relative
                            '-- size and position information stored in the dictionary
                            If (ret) Then
                                '-- Size
                                ctl.Width = Int(parentWidth * c.widthPercent)
                                ctl.Height = Int(parentHeight * c.heightPercent)

                                '-- Position
                                ctl.Top = Int(parentHeight * c.topOffsetPercent)
                                ctl.Left = Int(parentWidth * c.leftOffsetPercent)

                                '-- Font
                                f = ctl.Font
                                fontRatioW = ctl.Width / c.originalWidth
                                fontRatioH = ctl.Height / c.originalHeight
                                fontRatio = (fontRatioW +
                            fontRatioH) / 2 '-- average change in control Height and Width
                                ctl.Font = New Font(f.FontFamily,
                            c.originalFontSize * fontRatio, f.Style)

                            End If
                        Catch
                        End Try
                    End If
                Catch ex As Exception
                End Try

                '-- Recursive call for controls contained in the current control
                If ctl.Controls.Count > 0 Then
                    ResizeAllControls(ctl)
                End If

            Next '-- For Each
        End Sub

    End Class
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs.FindAllControls(Me)

    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub
    Private Sub StartingForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Dim information = My.Computer.FileSystem.GetFileInfo("AstronomyProject\sounds\space1.wav")
        savelocation = information.FullName.Substring(0, information.FullName.Length - 61) + "sounds\"
        My.Computer.Audio.Play(savelocation + "space1.wav")
        QuizzesButton.Visible = False
        LessonsButton.Visible = False
        QuizzesButton.FlatStyle = FlatStyle.Flat
        QuizzesButton.FlatAppearance.BorderSize = 0
        LessonsButton.FlatStyle = FlatStyle.Flat
        LessonsButton.FlatAppearance.BorderSize = 0
        LoginButton.FlatStyle = FlatStyle.Flat
        LoginButton.FlatAppearance.BorderSize = 0
        QuizzesButton.Enabled = False
        LessonsButton.Enabled = False



    End Sub

    Private Sub QuizzesButton_Click(sender As Object, e As EventArgs) Handles QuizzesButton.Click
        Quizzes.Show()
        Me.Hide()
    End Sub
    Private Sub LessonsButton_Click(sender As Object, e As EventArgs) Handles LessonsButton.Click
        Lessons.Show()
        Me.Hide()
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim information = My.Computer.FileSystem.GetFileInfo("Database1.mdb")
        datalocation = information.FullName.Substring(0, information.FullName.Length - 40) + "Database1.mdb"
        Dim mycon As New OleDb.OleDbConnection
        Dim myds As New DataSet

        Try
            mycon.ConnectionString = $"Provider=Microsoft.ACE.OLEDB.12.0; 
                                      Data Source = {datalocation};
                                      Persist Security Info=False;"
            mycon.Open()
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
                        Label4.Visible = False
                        Label5.Visible = False
                        usernameTextbox.Visible = False
                        passwordTextbox.Visible = False
                        QuizzesButton.Visible = True
                        LessonsButton.Visible = True
                        QuizzesButton.Enabled = True
                        LessonsButton.Enabled = True
                        currentuser = myds.Tables("MyStudents").Rows(index).Item(0)
                        mycon.Close()
                    Else
                        MsgBox("Login Failed, please try again")
                    End If
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error - " & ex.Message & vbNewLine & "can not connect to database")
        End Try
    End Sub

    Private Sub skip_Click(sender As Object, e As EventArgs) Handles skip.Click
        Me.Hide()
        ShootingStars.Show()
    End Sub
End Class