<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IssueBooks
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(IssueBooks))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Button5 = New Button()
        Label7 = New Label()
        Label6 = New Label()
        Panel2 = New Panel()
        IssueDate = New DateTimePicker()
        Label8 = New Label()
        StIdCb = New ComboBox()
        Label2 = New Label()
        ResetBtn = New Button()
        Label1 = New Label()
        StNameTb = New TextBox()
        EditBtn = New Button()
        Label4 = New Label()
        BookNameTb = New TextBox()
        Label5 = New Label()
        IssueBtn = New Button()
        BIdCb = New ComboBox()
        ContextMenuStrip2 = New ContextMenuStrip(components)
        ContextMenuStrip1 = New ContextMenuStrip(components)
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        IssueDGV = New DataGridView()
        Button1 = New Button()
        SerchBtn = New Button()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(IssueDGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Gainsboro
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.ForeColor = Color.Crimson
        Button5.Location = New Point(405, 531)
        Button5.Name = "Button5"
        Button5.Size = New Size(159, 29)
        Button5.TabIndex = 32
        Button5.Text = "Back"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.Crimson
        Label7.Location = New Point(417, 277)
        Label7.Name = "Label7"
        Label7.Size = New Size(141, 25)
        Label7.TabIndex = 30
        Label7.Text = "Books Issued"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Crimson
        Label6.Location = New Point(343, 30)
        Label6.Name = "Label6"
        Label6.Size = New Size(135, 25)
        Label6.TabIndex = 24
        Label6.Text = "Issue Details"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(IssueDate)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(StIdCb)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(ResetBtn)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(StNameTb)
        Panel2.Controls.Add(EditBtn)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(BookNameTb)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(IssueBtn)
        Panel2.Controls.Add(BIdCb)
        Panel2.Location = New Point(51, 51)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(857, 206)
        Panel2.TabIndex = 29
        ' 
        ' IssueDate
        ' 
        IssueDate.Format = DateTimePickerFormat.Short
        IssueDate.Location = New Point(677, 108)
        IssueDate.Name = "IssueDate"
        IssueDate.Size = New Size(104, 23)
        IssueDate.TabIndex = 27
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = Color.Crimson
        Label8.Location = New Point(34, 82)
        Label8.Name = "Label8"
        Label8.Size = New Size(102, 23)
        Label8.TabIndex = 25
        Label8.Text = "Student ID"
        ' 
        ' StIdCb
        ' 
        StIdCb.FormattingEnabled = True
        StIdCb.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        StIdCb.Location = New Point(34, 108)
        StIdCb.Name = "StIdCb"
        StIdCb.Size = New Size(102, 23)
        StIdCb.TabIndex = 26
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Crimson
        Label2.Location = New Point(354, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 23)
        Label2.TabIndex = 13
        Label2.Text = "Book ID"
        ' 
        ' ResetBtn
        ' 
        ResetBtn.BackColor = Color.Gainsboro
        ResetBtn.FlatAppearance.BorderSize = 0
        ResetBtn.FlatStyle = FlatStyle.Flat
        ResetBtn.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ResetBtn.ForeColor = Color.Crimson
        ResetBtn.Location = New Point(536, 151)
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
        Label1.Location = New Point(172, 82)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 23)
        Label1.TabIndex = 9
        Label1.Text = "Name"
        ' 
        ' StNameTb
        ' 
        StNameTb.Enabled = False
        StNameTb.Location = New Point(172, 108)
        StNameTb.Name = "StNameTb"
        StNameTb.Size = New Size(143, 23)
        StNameTb.TabIndex = 12
        ' 
        ' EditBtn
        ' 
        EditBtn.BackColor = Color.Gainsboro
        EditBtn.FlatAppearance.BorderSize = 0
        EditBtn.FlatStyle = FlatStyle.Flat
        EditBtn.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        EditBtn.ForeColor = Color.Crimson
        EditBtn.Location = New Point(354, 151)
        EditBtn.Name = "EditBtn"
        EditBtn.Size = New Size(159, 29)
        EditBtn.TabIndex = 21
        EditBtn.Text = "Edit"
        EditBtn.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Crimson
        Label4.Location = New Point(488, 82)
        Label4.Name = "Label4"
        Label4.Size = New Size(118, 23)
        Label4.TabIndex = 15
        Label4.Text = "Book Name"
        ' 
        ' BookNameTb
        ' 
        BookNameTb.Enabled = False
        BookNameTb.Location = New Point(488, 108)
        BookNameTb.Name = "BookNameTb"
        BookNameTb.Size = New Size(150, 23)
        BookNameTb.TabIndex = 16
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.Crimson
        Label5.Location = New Point(677, 82)
        Label5.Name = "Label5"
        Label5.Size = New Size(103, 23)
        Label5.TabIndex = 17
        Label5.Text = "Issue Date"
        ' 
        ' IssueBtn
        ' 
        IssueBtn.BackColor = Color.Gainsboro
        IssueBtn.FlatAppearance.BorderSize = 0
        IssueBtn.FlatStyle = FlatStyle.Flat
        IssueBtn.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        IssueBtn.ForeColor = Color.Crimson
        IssueBtn.Location = New Point(172, 151)
        IssueBtn.Name = "IssueBtn"
        IssueBtn.Size = New Size(159, 29)
        IssueBtn.TabIndex = 20
        IssueBtn.Text = "Submit"
        IssueBtn.UseVisualStyleBackColor = False
        ' 
        ' BIdCb
        ' 
        BIdCb.FormattingEnabled = True
        BIdCb.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        BIdCb.Location = New Point(354, 108)
        BIdCb.Name = "BIdCb"
        BIdCb.Size = New Size(94, 23)
        BIdCb.TabIndex = 19
        ' 
        ' ContextMenuStrip2
        ' 
        ContextMenuStrip2.Name = "ContextMenuStrip2"
        ContextMenuStrip2.Size = New Size(61, 4)
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(51, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 22)
        Label3.TabIndex = 9
        Label3.Text = "Issue Books"
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
        Panel1.TabIndex = 28
        ' 
        ' IssueDGV
        ' 
        IssueDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        IssueDGV.Location = New Point(166, 305)
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
        IssueDGV.Size = New Size(645, 196)
        IssueDGV.TabIndex = 33
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Gainsboro
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = Color.Crimson
        Button1.Location = New Point(821, 531)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 29)
        Button1.TabIndex = 34
        Button1.Text = "Log_Check"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' SerchBtn
        ' 
        SerchBtn.BackColor = Color.Gainsboro
        SerchBtn.FlatAppearance.BorderSize = 0
        SerchBtn.FlatStyle = FlatStyle.Flat
        SerchBtn.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        SerchBtn.ForeColor = Color.Crimson
        SerchBtn.Location = New Point(22, 531)
        SerchBtn.Name = "SerchBtn"
        SerchBtn.Size = New Size(121, 29)
        SerchBtn.TabIndex = 35
        SerchBtn.Text = "Search_Book"
        SerchBtn.UseVisualStyleBackColor = False
        ' 
        ' IssueBooks
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MistyRose
        ClientSize = New Size(956, 566)
        Controls.Add(SerchBtn)
        Controls.Add(Button1)
        Controls.Add(IssueDGV)
        Controls.Add(Button5)
        Controls.Add(Label7)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "IssueBooks"
        StartPosition = FormStartPosition.CenterScreen
        Text = "IssueBooks"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(IssueDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button5 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents IssueDate As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents StIdCb As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ResetBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents StNameTb As TextBox
    Friend WithEvents EditBtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents BookNameTb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents IssueBtn As Button
    Friend WithEvents BIdCb As ComboBox
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents IssueDGV As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents SerchBtn As Button
End Class
