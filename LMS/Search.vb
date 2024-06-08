Imports System.Data.SqlClient

Public Class Search
    Dim Con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\OneDrive\Documents\LibraryvbDB.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub DisplayBook()
        Con.Open()
        Dim query As String = "SELECT * FROM BookTbl"
        Dim adapter As SqlDataAdapter = New SqlDataAdapter(query, Con)
        Dim builder As SqlCommandBuilder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet = New DataSet()
        adapter.Fill(ds)
        SearchDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        If BNameTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Con.Open()
            Dim query As String = "SELECT * FROM BookTbl WHERE BName = '" & BNameTb.Text & "'"
            Dim adapter As SqlDataAdapter = New SqlDataAdapter(query, Con)
            Dim ds As DataSet = New DataSet()
            adapter.Fill(ds)

            If ds.Tables(0).Rows.Count > 0 Then
                SearchDGV.DataSource = ds.Tables(0)
                MsgBox("Book Found")
            Else
                MsgBox("Book Not Found")
            End If

            Con.Close()
        End If
    End Sub

    Private Sub Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayBook()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Dim Obj = New MainForm
        Obj.Show()
        Me.Hide()
    End Sub

End Class
