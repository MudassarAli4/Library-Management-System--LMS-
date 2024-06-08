<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BReturns
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(BReturns))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        ToolStripTextBox1 = New ToolStripTextBox()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        IssueDate = New DateTimePicker()
        ResetBtn = New Button()
        Label1 = New Label()
        Panel1 = New Panel()
        Label8 = New Label()
        StIdCb = New ComboBox()
        Label6 = New Label()
        Label2 = New Label()
        StNameTb = New TextBox()
        Label4 = New Label()
        BookNameTb = New TextBox()
        Label5 = New Label()
        ReturnBtn = New Button()
        BIdCb = New ComboBox()
        Label7 = New Label()
        Panel2 = New Panel()
        CalBtn = New Button()
        Label11 = New Label()
        FineTb = New TextBox()
        ReturnDate = New DateTimePicker()
        Label10 = New Label()
        ContextMenuStrip2 = New ContextMenuStrip(components)
        BackBtn = New Button()
        Label9 = New Label()
        IssueDGV = New DataGridView()
        ReturnedBooks = New DataGridView()
        Button2 = New Button()
        ContextMenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(IssueDGV, ComponentModel.ISupportInitialize).BeginInit()
        CType(ReturnedBooks, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripTextBox1})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(161, 29)
        ' 
        ' ToolStripTextBox1
        ' 
        ToolStripTextBox1.Name = "ToolStripTextBox1"
        ToolStripTextBox1.Size = New Size(100, 23)
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(51, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(128, 22)
        Label3.TabIndex = 9
        Label3.Text = "Return Books"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(42, 38)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(914, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(42, 38)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 11
        PictureBox2.TabStop = False
        ' 
        ' IssueDate
        ' 
        IssueDate.Format = DateTimePickerFormat.Short
        IssueDate.Location = New Point(486, 108)
        IssueDate.Name = "IssueDate"
        IssueDate.Size = New Size(103, 23)
        IssueDate.TabIndex = 27
        ' 
        ' ResetBtn
        ' 
        ResetBtn.BackColor = Color.Gainsboro
        ResetBtn.FlatAppearance.BorderSize = 0
        ResetBtn.FlatStyle = FlatStyle.Flat
        ResetBtn.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ResetBtn.ForeColor = Color.Crimson
        ResetBtn.Location = New Point(436, 151)
        ResetBtn.Name = "ResetBtn"
        ResetBtn.Size = New Size(159, 29)
        ResetBtn.TabIndex = 23
        ResetBtn.Text = "Reset"
        ResetBtn.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Crimson
        Label1.Location = New Point(110, 82)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 23)
        Label1.TabIndex = 9
        Label1.Text = "Name"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Crimson
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(956, 39)
        Panel1.TabIndex = 33
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = Color.Crimson
        Label8.Location = New Point(3, 82)
        Label8.Name = "Label8"
        Label8.Size = New Size(102, 23)
        Label8.TabIndex = 25
        Label8.Text = "Student ID"
        ' 
        ' StIdCb
        ' 
        StIdCb.FormattingEnabled = True
        StIdCb.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        StIdCb.Location = New Point(3, 108)
        StIdCb.Name = "StIdCb"
        StIdCb.Size = New Size(94, 23)
        StIdCb.TabIndex = 26
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Crimson
        Label6.Location = New Point(343, 30)
        Label6.Name = "Label6"
        Label6.Size = New Size(149, 25)
        Label6.TabIndex = 24
        Label6.Text = "Return Details"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Crimson
        Label2.Location = New Point(235, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 23)
        Label2.TabIndex = 13
        Label2.Text = "Book ID"
        ' 
        ' StNameTb
        ' 
        StNameTb.Location = New Point(110, 108)
        StNameTb.Name = "StNameTb"
        StNameTb.Size = New Size(112, 23)
        StNameTb.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Crimson
        Label4.Location = New Point(330, 82)
        Label4.Name = "Label4"
        Label4.Size = New Size(118, 23)
        Label4.TabIndex = 15
        Label4.Text = "Book Name"
        ' 
        ' BookNameTb
        ' 
        BookNameTb.Location = New Point(330, 108)
        BookNameTb.Name = "BookNameTb"
        BookNameTb.Size = New Size(139, 23)
        BookNameTb.TabIndex = 16
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.Crimson
        Label5.Location = New Point(486, 82)
        Label5.Name = "Label5"
        Label5.Size = New Size(103, 23)
        Label5.TabIndex = 17
        Label5.Text = "Issue Date"
        ' 
        ' ReturnBtn
        ' 
        ReturnBtn.BackColor = Color.Gainsboro
        ReturnBtn.FlatAppearance.BorderSize = 0
        ReturnBtn.FlatStyle = FlatStyle.Flat
        ReturnBtn.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ReturnBtn.ForeColor = Color.Crimson
        ReturnBtn.Location = New Point(235, 151)
        ReturnBtn.Name = "ReturnBtn"
        ReturnBtn.Size = New Size(159, 29)
        ReturnBtn.TabIndex = 20
        ReturnBtn.Text = "Return"
        ReturnBtn.UseVisualStyleBackColor = False
        ' 
        ' BIdCb
        ' 
        BIdCb.FormattingEnabled = True
        BIdCb.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        BIdCb.Location = New Point(235, 108)
        BIdCb.Name = "BIdCb"
        BIdCb.Size = New Size(79, 23)
        BIdCb.TabIndex = 19
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.Crimson
        Label7.Location = New Point(631, 277)
        Label7.Name = "Label7"
        Label7.Size = New Size(168, 25)
        Label7.TabIndex = 35
        Label7.Text = "Books Returned"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(CalBtn)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(FineTb)
        Panel2.Controls.Add(ReturnDate)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(IssueDate)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(StIdCb)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(ResetBtn)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(StNameTb)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(BookNameTb)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(ReturnBtn)
        Panel2.Controls.Add(BIdCb)
        Panel2.Location = New Point(51, 54)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(857, 206)
        Panel2.TabIndex = 34
        ' 
        ' CalBtn
        ' 
        CalBtn.BackColor = Color.Gainsboro
        CalBtn.FlatAppearance.BorderSize = 0
        CalBtn.FlatStyle = FlatStyle.Flat
        CalBtn.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CalBtn.ForeColor = Color.Crimson
        CalBtn.Location = New Point(742, 137)
        CalBtn.Name = "CalBtn"
        CalBtn.Size = New Size(106, 29)
        CalBtn.TabIndex = 32
        CalBtn.Text = "Calculate"
        CalBtn.UseVisualStyleBackColor = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.ForeColor = Color.Crimson
        Label11.Location = New Point(742, 82)
        Label11.Name = "Label11"
        Label11.Size = New Size(47, 23)
        Label11.TabIndex = 30
        Label11.Text = "Fine"
        ' 
        ' FineTb
        ' 
        FineTb.Location = New Point(742, 108)
        FineTb.Name = "FineTb"
        FineTb.Size = New Size(106, 23)
        FineTb.TabIndex = 31
        ' 
        ' ReturnDate
        ' 
        ReturnDate.Format = DateTimePickerFormat.Short
        ReturnDate.Location = New Point(606, 108)
        ReturnDate.Name = "ReturnDate"
        ReturnDate.Size = New Size(116, 23)
        ReturnDate.TabIndex = 29
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.ForeColor = Color.Crimson
        Label10.Location = New Point(606, 82)
        Label10.Name = "Label10"
        Label10.Size = New Size(116, 23)
        Label10.TabIndex = 28
        Label10.Text = "Return Date"
        ' 
        ' ContextMenuStrip2
        ' 
        ContextMenuStrip2.Name = "ContextMenuStrip2"
        ContextMenuStrip2.Size = New Size(61, 4)
        ' 
        ' BackBtn
        ' 
        BackBtn.BackColor = Color.Gainsboro
        BackBtn.FlatAppearance.BorderSize = 0
        BackBtn.FlatStyle = FlatStyle.Flat
        BackBtn.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BackBtn.ForeColor = Color.Crimson
        BackBtn.Location = New Point(405, 534)
        BackBtn.Name = "BackBtn"
        BackBtn.Size = New Size(159, 29)
        BackBtn.TabIndex = 37
        BackBtn.Text = "Back"
        BackBtn.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = Color.Crimson
        Label9.Location = New Point(175, 277)
        Label9.Name = "Label9"
        Label9.Size = New Size(141, 25)
        Label9.TabIndex = 38
        Label9.Text = "Books Issued"
        ' 
        ' IssueDGV
        ' 
        IssueDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        IssueDGV.Location = New Point(30, 316)
        IssueDGV.Name = "IssueDGV"
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Gainsboro
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        IssueDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        IssueDGV.RowTemplate.Height = 25
        IssueDGV.Size = New Size(431, 196)
        IssueDGV.TabIndex = 39
        ' 
        ' ReturnedBooks
        ' 
        ReturnedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ReturnedBooks.Location = New Point(487, 316)
        ReturnedBooks.Name = "ReturnedBooks"
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.Gainsboro
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        ReturnedBooks.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        ReturnedBooks.RowTemplate.Height = 25
        ReturnedBooks.Size = New Size(431, 196)
        ReturnedBooks.TabIndex = 40
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Gainsboro
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.ForeColor = Color.Crimson
        Button2.Location = New Point(12, 525)
        Button2.Name = "Button2"
        Button2.Size = New Size(126, 29)
        Button2.TabIndex = 42
        Button2.Text = "View_Check"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' BReturns
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MistyRose
        ClientSize = New Size(956, 566)
        Controls.Add(Button2)
        Controls.Add(ReturnedBooks)
        Controls.Add(IssueDGV)
        Controls.Add(Label9)
        Controls.Add(Panel1)
        Controls.Add(Label7)
        Controls.Add(Panel2)
        Controls.Add(BackBtn)
        FormBorderStyle = FormBorderStyle.None
        Name = "BReturns"
        StartPosition = FormStartPosition.CenterScreen
        Text = "BReturns"
        ContextMenuStrip1.ResumeLayout(False)
        ContextMenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(IssueDGV, ComponentModel.ISupportInitialize).EndInit()
        CType(ReturnedBooks, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents IssueDate As DateTimePicker
    Friend WithEvents ResetBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents StIdCb As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents StNameTb As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BookNameTb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ReturnBtn As Button
    Friend WithEvents BIdCb As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents BackBtn As Button
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents FineTb As TextBox
    Friend WithEvents ReturnDate As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents IssueDGV As DataGridView
    Friend WithEvents ReturnedBooks As DataGridView
    Friend WithEvents CalBtn As Button
    Friend WithEvents Button2 As Button
End Class
