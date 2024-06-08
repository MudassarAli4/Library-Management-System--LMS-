Imports System.Data.SqlClient

Public Class Login
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim Obj = New AdminLogin
        Obj.Show()
        Me.Hide()
    End Sub
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\OneDrive\Documents\LibraryvbDB.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If uNameTb.Text = "" Then
            MsgBox("Enter Librarian Name")
        ElseIf PassTb.Text = "" Then
            MsgBox("Enter Password")
        Else
            Con.Open()
            Dim query = "select * from LibrarianTbl where LibName ='" & uNameTb.Text & "' and LibPass='" & PassTb.Text & "'"
            Dim cmd = New SqlCommand(query, Con)
            Dim da = New SqlDataAdapter(cmd)
            Dim ds = New DataSet()
            da.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count
            If a = 0 Then
                MsgBox("Wrong UserName or Password")
            Else
                Dim Obj = New MainForm
                Obj.Show()
                Me.Hide()
            End If
            Con.Close()
        End If
    End Sub

End Class
