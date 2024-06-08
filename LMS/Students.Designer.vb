<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Students
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Students))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        ContextMenuStrip2 = New ContextMenuStrip(components)
        StNameTb = New TextBox()
        Label2 = New Label()
        DepartmentTb = New TextBox()
        Label4 = New Label()
        PhoneTb = New TextBox()
        Label5 = New Label()
        SemCb = New ComboBox()
        SaveBtn = New Button()
        EditBtn = New Button()
        DeleteBtn = New Button()
        ResetBtn = New Button()
        Panel2 = New Panel()
        Label6 = New Label()
        Label7 = New Label()
        BackBtn = New Button()
        StudentsDGV = New DataGridView()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(StudentsDGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        Panel1.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(51, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 22)
        Label3.TabIndex = 9
        Label3.Text = "Students"
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Crimson
        Label1.Location = New Point(41, 82)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 23)
        Label1.TabIndex = 9
        Label1.Text = "Name"
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' ContextMenuStrip2
        ' 
        ContextMenuStrip2.Name = "ContextMenuStrip2"
        ContextMenuStrip2.Size = New Size(61, 4)
        ' 
        ' StNameTb
        ' 
        StNameTb.Location = New Point(41, 108)
        StNameTb.Name = "StNameTb"
        StNameTb.Size = New Size(143, 23)
        StNameTb.TabIndex = 12
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Crimson
        Label2.Location = New Point(475, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 23)
        Label2.TabIndex = 13
        Label2.Text = "Semester"
        ' 
        ' DepartmentTb
        ' 
        DepartmentTb.Location = New Point(249, 108)
        DepartmentTb.Name = "DepartmentTb"
        DepartmentTb.Size = New Size(150, 23)
        DepartmentTb.TabIndex = 16
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Crimson
        Label4.Location = New Point(249, 82)
        Label4.Name = "Label4"
        Label4.Size = New Size(120, 23)
        Label4.TabIndex = 15
        Label4.Text = "Department"
        ' 
        ' PhoneTb
        ' 
        PhoneTb.Location = New Point(687, 108)
        PhoneTb.Name = "PhoneTb"
        PhoneTb.Size = New Size(144, 23)
        PhoneTb.TabIndex = 18
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.Crimson
        Label5.Location = New Point(687, 82)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 23)
        Label5.TabIndex = 17
        Label5.Text = "Phone"
        ' 
        ' SemCb
        ' 
        SemCb.FormattingEnabled = True
        SemCb.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        SemCb.Location = New Point(475, 108)
        SemCb.Name = "SemCb"
        SemCb.Size = New Size(143, 23)
        SemCb.TabIndex = 19
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
        ' Panel2
        ' 
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(ResetBtn)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(DeleteBtn)
        Panel2.Controls.Add(StNameTb)
        Panel2.Controls.Add(EditBtn)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(DepartmentTb)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(SaveBtn)
        Panel2.Controls.Add(PhoneTb)
        Panel2.Controls.Add(SemCb)
        Panel2.Location = New Point(51, 45)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(857, 206)
        Panel2.TabIndex = 24
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Crimson
        Label6.Location = New Point(343, 30)
        Label6.Name = "Label6"
        Label6.Size = New Size(170, 25)
        Label6.TabIndex = 24
        Label6.Text = "Students Details"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.Crimson
        Label7.Location = New Point(417, 271)
        Label7.Name = "Label7"
        Label7.Size = New Size(132, 25)
        Label7.TabIndex = 25
        Label7.Text = "Students List"
        ' 
        ' BackBtn
        ' 
        BackBtn.BackColor = Color.Gainsboro
        BackBtn.FlatAppearance.BorderSize = 0
        BackBtn.FlatStyle = FlatStyle.Flat
        BackBtn.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BackBtn.ForeColor = Color.Crimson
        BackBtn.Location = New Point(405, 525)
        BackBtn.Name = "BackBtn"
        BackBtn.Size = New Size(159, 29)
        BackBtn.TabIndex = 27
        BackBtn.Text = "Back"
        BackBtn.UseVisualStyleBackColor = False
        ' 
        ' StudentsDGV
        ' 
        StudentsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        StudentsDGV.Location = New Point(201, 299)
        StudentsDGV.Name = "StudentsDGV"
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Gainsboro
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        StudentsDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        StudentsDGV.RowTemplate.Height = 25
        StudentsDGV.Size = New Size(544, 196)
        StudentsDGV.TabIndex = 32
        ' 
        ' Students
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MistyRose
        ClientSize = New Size(956, 566)
        Controls.Add(StudentsDGV)
        Controls.Add(BackBtn)
        Controls.Add(Label7)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Students"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Students"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(StudentsDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents StNameTb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DepartmentTb As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PhoneTb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents SemCb As ComboBox
    Friend WithEvents SaveBtn As Button
    Friend WithEvents EditBtn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents ResetBtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents BackBtn As Button
    Friend WithEvents StudentsDGV As DataGridView
End Class
