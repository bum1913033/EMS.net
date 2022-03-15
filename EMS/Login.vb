Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Clear Text Fields
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UidTb.Clear()
        PassTb.Clear()
    End Sub

    'Login Button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If UidTb.Text = "" Or PassTb.Text = "" Then
            MsgBox("Missing Fields!")
        ElseIf UidTb.Text = "admin" And PassTb.Text = "admin" Then
            Me.Hide()
            Dim mainForm = New MainForm
            mainForm.Show()
        Else
            MsgBox("Invalid Login Credentials!")
        End If
    End Sub

    'Exit Application
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Application.Exit()
    End Sub
End Class