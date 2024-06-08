Imports System.Data.SqlClient

Public Class Log1
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\OneDrive\Documents\LibraryvbDB.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub DisplayLog()
        Con.Open()
        Dim query = "select * from ReturnedBooksData"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        Log1DGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim Obj = New Login()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Log1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayLog()
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Dim Obj = New MainForm()
        Obj.Show()
        Me.Hide()
    End Sub
End Class