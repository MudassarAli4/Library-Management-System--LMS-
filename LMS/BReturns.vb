Imports System.Data.SqlClient

Public Class BReturns
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
    Private Sub DisplayReturnedBook()
        Con.Open()
        Dim query = "select * from ReturnTbl"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        ReturnedBooks.DataSource = ds.Tables(0)
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

    Private Sub BReturns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayBook()
        FillStudent()
        FillBook()
        DisplayReturnedBook()
    End Sub
    Private Sub StIdCb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles StIdCb.SelectionChangeCommitted
        GetStudentName()
    End Sub
    Private Sub BIdCb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles BIdCb.SelectionChangeCommitted
        GetBookName()
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub
    Dim key = 0
    Private Sub IssueDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles IssueDGV.CellMouseClick
        Dim row As DataGridViewRow = IssueDGV.Rows(e.RowIndex)
        StIdCb.Text = row.Cells(1).Value.ToString
        StNameTb.Text = row.Cells(2).Value.ToString
        BIdCb.Text = row.Cells(3).Value.ToString
        BookNameTb.Text = row.Cells(4).Value.ToString
        IssueDate.Text = row.Cells(5).Value.ToString
        If StNameTb.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub
    Dim Fine As Integer
    Private Sub CalBtn_Click(sender As Object, e As EventArgs) Handles CalBtn.Click
        Dim Dif As TimeSpan

        Dif = ReturnDate.Value.Date - IssueDate.Value.Date
        Dim Days = Dif.Days
        If Days < 15 Then
            Fine = 0
            FineTb.Text = "No Fine"
        Else
            Fine = (Days - 15) * 10
            FineTb.Text = "Rs " + Convert.ToString(Fine)
        End If
    End Sub
    Private Sub RemoveFromIssue()
        Try
            Con.Open()
            Dim query = "delete from IssueTbl where INum=" & key & " "
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            If cmd.ExecuteNonQuery() = 0 Then
                MsgBox("Book Not Found")
            Else
                MsgBox("Book Removed From Issued")
            End If
            Con.Close()
            DisplayBook()
            Reset()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ReturnBtn_Click(sender As Object, e As EventArgs) Handles ReturnBtn.Click
        If StIdCb.Text = "" Or BIdCb.Text = "" Or StNameTb.Text = "" Or BookNameTb.Text = "" Or FineTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Try
                Con.Open()
                Dim query = "insert into ReturnTbl values(" & StIdCb.Text & ",'" & StNameTb.Text & "'," & BIdCb.Text & ",'" & BookNameTb.Text & "','" & IssueDate.Value.Date & "','" & ReturnDate.Value.Date & "'," & Fine & ")"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, Con)
                cmd.ExecuteNonQuery()

                Dim updateQuery = "UPDATE BookTbl SET BQty = BQty + 1 WHERE BId = " & BIdCb.SelectedValue.ToString()
                Dim updateCmd As SqlCommand
                updateCmd = New SqlCommand(updateQuery, Con)
                updateCmd.ExecuteNonQuery()

                MsgBox("Book Returned")
                Con.Close()
                RemoveFromIssue()
                DisplayReturnedBook()
                DisplayBook()
                Reset()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub
    Private Sub Reset()
        StIdCb.SelectedIndex = -1
        BIdCb.SelectedIndex = -1
        StNameTb.Text = ""
        BookNameTb.Text = ""
        FineTb.Text = ""
        key = 0
    End Sub
    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Dim Obj = New MainForm
        Obj.Show()
        Me.Hide()
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim Obj = New Log1
    '    Obj.Show()
    '    Me.Hide()
    'End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Obj = New View
        Obj.Show()
        Me.Hide()
    End Sub
End Class