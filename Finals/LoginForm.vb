Public Class LoginForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If UserTextBox.Text = "user" And PassTextBox.Text = "123" Then
            UserTextBox.Text = ""
            PassTextBox.Text = ""
            MsgBox("You login successfully")
            MainForm.Show()
            Me.Hide()

        Else
            MsgBox("Invalid Username or Password")
            UserTextBox.Text = ""
            PassTextBox.Text = ""
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class