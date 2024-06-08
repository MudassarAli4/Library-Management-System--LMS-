Public Class AdminLogin
    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If PassTb.Text = "" Then
            MsgBox("Enter the Admin Password")
        ElseIf PassTb.Text = "Admin" Then
            Dim Obj = New Librarians
            Obj.Show()
            Me.Hide()
        Else
            MsgBox("Wrong Password")
            PassTb.Text = ""
        End If
    End Sub

    Private Sub LBackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Dim Obj = New Login
        Obj.Show()
        Me.Hide()
    End Sub
End Class