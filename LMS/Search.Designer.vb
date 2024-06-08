<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Search))
        SearchDGV = New DataGridView()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        BackBtn = New Button()
        Label2 = New Label()
        BNameTb = New TextBox()
        SearchBtn = New Button()
        CType(SearchDGV, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SearchDGV
        ' 
        SearchDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        SearchDGV.Location = New Point(12, 126)
        SearchDGV.Name = "SearchDGV"
        SearchDGV.RowTemplate.Height = 25
        SearchDGV.Size = New Size(517, 83)
        SearchDGV.TabIndex = 45
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Crimson
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(541, 39)
        Panel1.TabIndex = 44
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(499, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(39, 34)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 40
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(111, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(300, 25)
        Label1.TabIndex = 12
        Label1.Text = "Welcome to Library Software"
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
        ' BackBtn
        ' 
        BackBtn.BackColor = Color.Gainsboro
        BackBtn.FlatAppearance.BorderSize = 0
        BackBtn.FlatStyle = FlatStyle.Flat
        BackBtn.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BackBtn.ForeColor = Color.Crimson
        BackBtn.Location = New Point(191, 234)
        BackBtn.Name = "BackBtn"
        BackBtn.Size = New Size(159, 29)
        BackBtn.TabIndex = 46
        BackBtn.Text = "Back"
        BackBtn.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Crimson
        Label2.Location = New Point(12, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(137, 25)
        Label2.TabIndex = 48
        Label2.Text = "Book Name:"
        ' 
        ' BNameTb
        ' 
        BNameTb.Location = New Point(157, 73)
        BNameTb.Name = "BNameTb"
        BNameTb.Size = New Size(166, 23)
        BNameTb.TabIndex = 49
        ' 
        ' SearchBtn
        ' 
        SearchBtn.BackColor = Color.Gainsboro
        SearchBtn.FlatAppearance.BorderSize = 0
        SearchBtn.FlatStyle = FlatStyle.Flat
        SearchBtn.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        SearchBtn.ForeColor = Color.Crimson
        SearchBtn.Location = New Point(383, 70)
        SearchBtn.Name = "SearchBtn"
        SearchBtn.Size = New Size(146, 29)
        SearchBtn.TabIndex = 50
        SearchBtn.Text = "Search"
        SearchBtn.UseVisualStyleBackColor = False
        ' 
        ' Search
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(541, 304)
        Controls.Add(SearchBtn)
        Controls.Add(BNameTb)
        Controls.Add(Label2)
        Controls.Add(SearchDGV)
        Controls.Add(Panel1)
        Controls.Add(BackBtn)
        FormBorderStyle = FormBorderStyle.None
        Name = "Search"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Search"
        CType(SearchDGV, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents SearchDGV As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BackBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents BNameTb As TextBox
    Friend WithEvents SearchBtn As Button
End Class
