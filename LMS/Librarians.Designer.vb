<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Librarians
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Librarians))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        BackBtn = New Button()
        Label7 = New Label()
        Label6 = New Label()
        Panel2 = New Panel()
        Label4 = New Label()
        PasswordTb = New TextBox()
        ResetBtn = New Button()
        Label1 = New Label()
        DeleteBtn = New Button()
        LibNameTb = New TextBox()
        EditBtn = New Button()
        Label5 = New Label()
        SaveBtn = New Button()
        PhoneTb = New TextBox()
        ContextMenuStrip2 = New ContextMenuStrip(components)
        ContextMenuStrip1 = New ContextMenuStrip(components)
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        LibrariansDGV = New DataGridView()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(LibrariansDGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BackBtn
        ' 
        BackBtn.BackColor = Color.Gainsboro
        BackBtn.FlatAppearance.BorderSize = 0
        BackBtn.FlatStyle = FlatStyle.Flat
        BackBtn.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BackBtn.ForeColor = Color.Crimson
        BackBtn.Location = New Point(405, 531)
        BackBtn.Name = "BackBtn"
        BackBtn.Size = New Size(159, 29)
        BackBtn.TabIndex = 32
        BackBtn.Text = "Back"
        BackBtn.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.Crimson
        Label7.Location = New Point(417, 277)
        Label7.Name = "Label7"
        Label7.Size = New Size(144, 25)
        Label7.TabIndex = 30
        Label7.Text = "Librarians List"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Crimson
        Label6.Location = New Point(343, 30)
        Label6.Name = "Label6"
        Label6.Size = New Size(182, 25)
        Label6.TabIndex = 24
        Label6.Text = "Librarians Details"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(PasswordTb)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(ResetBtn)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(DeleteBtn)
        Panel2.Controls.Add(LibNameTb)
        Panel2.Controls.Add(EditBtn)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(SaveBtn)
        Panel2.Controls.Add(PhoneTb)
        Panel2.Location = New Point(51, 51)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(857, 206)
        Panel2.TabIndex = 29
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Crimson
        Label4.Location = New Point(575, 82)
        Label4.Name = "Label4"
        Label4.Size = New Size(96, 23)
        Label4.TabIndex = 25
        Label4.Text = "Password"
        ' 
        ' PasswordTb
        ' 
        PasswordTb.Location = New Point(575, 108)
        PasswordTb.Name = "PasswordTb"
        PasswordTb.Size = New Size(150, 23)
        PasswordTb.TabIndex = 26
        ' 
        ' ResetBtn
        ' 
        ResetBtn.BackColor = Color.Gainsboro
        ResetBtn.FlatAppearance.BorderSize = 0
        ResetBtn.FlatStyle = FlatStyle.Flat
        ResetBtn.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ResetBtn.ForeColor = Color.Crimson
        ResetBtn.Location = New Point(601, 151)
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
        Label1.Location = New Point(151, 82)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 23)
        Label1.TabIndex = 9
        Label1.Text = "Name"
        ' 
        ' DeleteBtn
        ' 
        DeleteBtn.BackColor = Color.Gainsboro
        DeleteBtn.FlatAppearance.BorderSize = 0
        DeleteBtn.FlatStyle = FlatStyle.Flat
        DeleteBtn.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DeleteBtn.ForeColor = Color.Crimson
        DeleteBtn.Location = New Point(436, 151)
        DeleteBtn.Name = "DeleteBtn"
        DeleteBtn.Size = New Size(159, 29)
        DeleteBtn.TabIndex = 22
        DeleteBtn.Text = "Delete"
        DeleteBtn.UseVisualStyleBackColor = False
        ' 
        ' LibNameTb
        ' 
        LibNameTb.Location = New Point(151, 108)
        LibNameTb.Name = "LibNameTb"
        LibNameTb.Size = New Size(143, 23)
        LibNameTb.TabIndex = 12
        ' 
        ' EditBtn
        ' 
        EditBtn.BackColor = Color.Gainsboro
        EditBtn.FlatAppearance.BorderSize = 0
        EditBtn.FlatStyle = FlatStyle.Flat
        EditBtn.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        EditBtn.ForeColor = Color.Crimson
        EditBtn.Location = New Point(271, 151)
        EditBtn.Name = "EditBtn"
        EditBtn.Size = New Size(159, 29)
        EditBtn.TabIndex = 21
        EditBtn.Text = "Edit"
        EditBtn.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.Crimson
        Label5.Location = New Point(366, 82)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 23)
        Label5.TabIndex = 17
        Label5.Text = "Phone"
        ' 
        ' SaveBtn
        ' 
        SaveBtn.BackColor = Color.Gainsboro
        SaveBtn.FlatAppearance.BorderSize = 0
        SaveBtn.FlatStyle = FlatStyle.Flat
        SaveBtn.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        SaveBtn.ForeColor = Color.Crimson
        SaveBtn.Location = New Point(106, 151)
        SaveBtn.Name = "SaveBtn"
        SaveBtn.Size = New Size(159, 29)
        SaveBtn.TabIndex = 20
        SaveBtn.Text = "Save"
        SaveBtn.UseVisualStyleBackColor = False
        ' 
        ' PhoneTb
        ' 
        PhoneTb.Location = New Point(366, 108)
        PhoneTb.Name = "PhoneTb"
        PhoneTb.Size = New Size(144, 23)
        PhoneTb.TabIndex = 18
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
        Label3.Size = New Size(95, 22)
        Label3.TabIndex = 9
        Label3.Text = "Librarians"
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
        ' LibrariansDGV
        ' 
        LibrariansDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        LibrariansDGV.Location = New Point(242, 305)
        LibrariansDGV.Name = "LibrariansDGV"
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Gainsboro
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        LibrariansDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        LibrariansDGV.RowTemplate.Height = 25
        LibrariansDGV.Size = New Size(443, 196)
        LibrariansDGV.TabIndex = 33
        ' 
        ' Librarians
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MistyRose
        ClientSize = New Size(956, 566)
        Controls.Add(LibrariansDGV)
        Controls.Add(BackBtn)
        Controls.Add(Label7)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Librarians"
        StartPosition = FormStartPosition.CenterScreen
        Text = " "
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(LibrariansDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BackBtn As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ResetBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents LibNameTb As TextBox
    Friend WithEvents EditBtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents SaveBtn As Button
    Friend WithEvents PhoneTb As TextBox
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LibrariansDGV As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents PasswordTb As TextBox
End Class
