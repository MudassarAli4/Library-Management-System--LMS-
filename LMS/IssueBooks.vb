Imports System.Data.SqlClient
Imports System.Linq.Expressions

Public Class IssueBooks
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\hp\OneDrive\Documents\LibraryvbDB.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub DisplayBook()
        Con.Open()
        Dim query = "select * from IssueTbl"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        IssueDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub FillStudent()
        Con.Open()
        Dim query = "select * from StudentTbl"
        Dim cmd As New SqlCommand(query, Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        StIdCb.DataSource = Tbl
        StIdCb.DisplayMember = "StId"
        StIdCb.ValueMember = "StId"
        Con.Close()
    End Sub
    Private Sub GetStudentName()
        Con.Open()
        Dim query = "select * from StudentTbl where StId=" & StIdCb.SelectedValue.ToString() & ""
        Dim cmd = New SqlCommand(query, Con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            StNameTb.Text = "" + reader(1).ToString()
        End While
        Con.Close()
    End Sub
    Private Sub GetBookName()
        Con.Open()
        Dim query = "select * from BookTbl where BId=" & BIdCb.SelectedValue.ToString() & ""
        Dim cmd = New SqlCommand(query, Con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            BookNameTb.Text = "" + reader(1).ToString()
        End While
        Con.Close()
    End Sub
    Private Sub FillBook()
        Con.Open()
        Dim query = "select * from BookTbl"
        Dim cmd As New SqlCommand(query, Con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        BIdCb.DataSource = Tbl
        BIdCb.DisplayMember = "BId"
        BIdCb.ValueMember = "BId"
        Con.Close()
    End Sub
    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If StNameTb.Text = "" Or BookNameTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Con.Open()
            Dim query = "update IssueTbl set StId=" & StIdCb.SelectedValue.ToString() & ",StName='" & StNameTb.Text & "',BookId=" & BIdCb.SelectedValue.ToString() & ",BookName='" & BookNameTb.Text & "',IssueDate='" & IssueDate.Value.Date & "' where INum=" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Issue Edited")
            Con.Close()
            DisplayBook()
            Reset()
        End If
    End Sub

    Private Sub IssueBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayBook()
        FillStudent()
        FillBook()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub StIdCb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles StIdCb.SelectionChangeCommitted
        GetStudentName()
    End Sub

    Private Sub BIdCb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles BIdCb.SelectionChangeCommitted
        GetBookName()
    End Sub
    Dim Num = 0
    Private Sub CountBook()
        Try
            Con.Open()
            Dim query = "select Count(*) from IssueTbl where StId=" & StIdCb.SelectedValue.ToString() & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            Num = cmd.ExecuteScalar
            Con.Close()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub IssueBtn_Click(sender As Object, e As EventArgs) Handles IssueBtn.Click
        CountBook()
        If StNameTb.Text = "" Or BookNameTb.Text = "" Or StIdCb.SelectedIndex = -1 Or BIdCb.SelectedIndex = -1 Then
            MsgBox("Missing Information")
        ElseIf Num = 5 Then
            MsgBox("Cannot Issue More than 5 Books")
        Else
            Try
                Con.Open()
                Dim checkQuery = "SELECT BQty FROM BookTbl WHERE BId = " & BIdCb.SelectedValue.ToString()
                Dim checkCmd As SqlCommand
                checkCmd = New SqlCommand(checkQuery, Con)
                Dim bQty As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

                If bQty = 0 Then

                    Dim deleteQuery = "DELETE FROM BookTbl WHERE BId = " & BIdCb.SelectedValue.ToString()
                    Dim deleteCmd As SqlCommand
                    deleteCmd = New SqlCommand(deleteQuery, Con)
                    deleteCmd.ExecuteNonQuery()

                    MsgBox("Book Not Found. Book Deleted.")
                Else
                    Dim query = "insert into IssueTbl values(" & StIdCb.SelectedValue.ToString() & ",'" & StNameTb.Text & "'," & BIdCb.SelectedValue.ToString() & ",'" & BookNameTb.Text & "','" & IssueDate.Value.Date & "')"
                    Dim cmd As SqlCommand
                    cmd = New SqlCommand(query, Con)
                    cmd.ExecuteNonQuery()

                    Dim updateQuery = "UPDATE BookTbl SET BQty = BQty - 1 WHERE BId = " & BIdCb.SelectedValue.ToString()
                    Dim updateCmd As SqlCommand
                    updateCmd = New SqlCommand(updateQuery, Con)
                    updateCmd.ExecuteNonQuery()
                    MsgBox("Book Issued")
                End If

                Con.Close()
                DisplayBook()
                Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub Reset()
        BookNameTb.Text = ""
        StNameTb.Text = ""
        StIdCb.SelectedIndex = -1
        BIdCb.SelectedIndex = -1
    End Sub
    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Obj = New MainForm
        Obj.Show()
        Me.Hide()
    End Sub
    Dim key = 0
    Private Sub IssueDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles IssueDGV.CellMouseClick
        Dim row As DataGridViewRow = IssueDGV.Rows(e.RowIndex)
        StIdCb.SelectedValue = row.Cells(1).Value.ToString
        StNameTb.Text = row.Cells(2).Value.ToString
        BIdCb.SelectedValue = row.Cells(3).Value.ToString
        BookNameTb.Text = row.Cells(4).Value.ToString
        IssueDate.Text = row.Cells(5).Value.ToString
        If StNameTb.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Obj = New Log
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub SerchBtn_Click(sender As Object, e As EventArgs) Handles SerchBtn.Click
        Dim Obj = New Search
        Obj.Show()
        Me.Hide()
    End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    Dim Obj = New View
    '    Obj.Show()
    '    Me.Hide()
    'End Sub

End Class