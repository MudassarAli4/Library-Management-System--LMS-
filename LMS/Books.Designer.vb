<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Books
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Books))
        BackBtn = New Button()
        Label7 = New Label()
        Label6 = New Label()
        Panel2 = New Panel()
        Label8 = New Label()
        QtyTb = New TextBox()
        BPublisherTb = New TextBox()
        Label2 = New Label()
        ResetBtn = New Button()
        Label1 = New Label()
        DeleteBtn = New Button()
        BNameTb = New TextBox()
        EditBtn = New Button()
        Label4 = New Label()
        BAuthorTb = New TextBox()
        Label5 = New Label()
        SaveBtn = New Button()
        BPriceTb = New TextBox()
        BooksDGV = New DataGridView()
        ContextMenuStrip2 = New ContextMenuStrip(components)
        ContextMenuStrip1 = New ContextMenuStrip(components)
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        Panel2.SuspendLayout()
        CType(BooksDGV, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
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
        Label7.Size = New Size(106, 25)
        Label7.TabIndex = 30
        Label7.Text = "Books List"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.Crimson
        Label6.Location = New Point(343, 30)
        Label6.Name = "Label6"
        Label6.Size = New Size(144, 25)
        Label6.TabIndex = 24
        Label6.Text = "Books Details"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(QtyTb)
        Panel2.Controls.Add(BPublisherTb)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(ResetBtn)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(DeleteBtn)
        Panel2.Controls.Add(BNameTb)
        Panel2.Controls.Add(EditBtn)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(BAuthorTb)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(SaveBtn)
        Panel2.Controls.Add(BPriceTb)
        Panel2.Location = New Point(51, 51)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(857, 206)
        Panel2.TabIndex = 29
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.ForeColor = Color.Crimson
        Label8.Location = New Point(728, 82)
        Label8.Name = "Label8"
        Label8.Size = New Size(89, 23)
        Label8.TabIndex = 26
        Label8.Text = "Quantity"
        ' 
        ' QtyTb
        ' 
        QtyTb.Location = New Point(728, 108)
        QtyTb.Name = "QtyTb"
        QtyTb.Size = New Size(87, 23)
        QtyTb.TabIndex = 27
        ' 
        ' BPublisherTb
        ' 
        BPublisherTb.Location = New Point(406, 108)
        BPublisherTb.Name = "BPublisherTb"
        BPublisherTb.Size = New Size(150, 23)
        BPublisherTb.TabIndex = 25
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Crimson
        Label2.Location = New Point(406, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 23)
        Label2.TabIndex = 13
        Label2.Text = "Publisher"
        ' 
        ' ResetBtn
        ' 
        ResetBtn.BackColor = Color.Gainsboro
        ResetBtn.FlatAppearance.BorderSize = 0
        ResetBtn.FlatStyle = FlatStyle.Flat
        ResetBtn.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ResetBtn.ForeColor = Color.Crimson
        ResetBtn.Location = New Point(595, 151)
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
        Label1.Location = New Point(41, 82)
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
        DeleteBtn.Location = New Point(430, 151)
        DeleteBtn.Name = "DeleteBtn"
        DeleteBtn.Size = New Size(159, 29)
        DeleteBtn.TabIndex = 22
        DeleteBtn.Text = "Delete"
        DeleteBtn.UseVisualStyleBackColor = False
        ' 
        ' BNameTb
        ' 
        BNameTb.Location = New Point(41, 108)
        BNameTb.Name = "BNameTb"
        BNameTb.Size = New Size(143, 23)
        BNameTb.TabIndex = 12
        ' 
        ' EditBtn
        ' 
        EditBtn.BackColor = Color.Gainsboro
        EditBtn.FlatAppearance.BorderSize = 0
        EditBtn.FlatStyle = FlatStyle.Flat
        EditBtn.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        EditBtn.ForeColor = Color.Crimson
        EditBtn.Location = New Point(265, 151)
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
        Label4.Location = New Point(219, 82)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 23)
        Label4.TabIndex = 15
        Label4.Text = "Author"
        ' 
        ' BAuthorTb
        ' 
        BAuthorTb.Location = New Point(219, 108)
        BAuthorTb.Name = "BAuthorTb"
        BAuthorTb.Size = New Size(150, 23)
        BAuthorTb.TabIndex = 16
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.Crimson
        Label5.Location = New Point(600, 82)
        Label5.Name = "Label5"
        Label5.Size = New Size(56, 23)
        Label5.TabIndex = 17
        Label5.Text = "Price"
        ' 
        ' SaveBtn
        ' 
        SaveBtn.BackColor = Color.Gainsboro
        SaveBtn.FlatAppearance.BorderSize = 0
        SaveBtn.FlatStyle = FlatStyle.Flat
        SaveBtn.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        SaveBtn.ForeColor = Color.Crimson
        SaveBtn.Location = New Point(100, 151)
        SaveBtn.Name = "SaveBtn"
        SaveBtn.Size = New Size(159, 29)
        SaveBtn.TabIndex = 20
        SaveBtn.Text = "Save"
        SaveBtn.UseVisualStyleBackColor = False
        ' 
        ' BPriceTb
        ' 
        BPriceTb.Location = New Point(600, 108)
        BPriceTb.Name = "BPriceTb"
        BPriceTb.Size = New Size(87, 23)
        BPriceTb.TabIndex = 18
        ' 
        ' BooksDGV
        ' 
        BooksDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        BooksDGV.Location = New Point(141, 305)
        BooksDGV.Name = "BooksDGV"
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Gainsboro
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        BooksDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        BooksDGV.RowTemplate.Height = 25
        BooksDGV.Size = New Size(664, 196)
        BooksDGV.TabIndex = 31
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
        Label3.Size = New Size(62, 22)
        Label3.TabIndex = 9
        Label3.Text = "Books"
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
        ' Books
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MistyRose
        ClientSize = New Size(956, 566)
        Controls.Add(BackBtn)
        Controls.Add(Label7)
        Controls.Add(Panel2)
        Controls.Add(BooksDGV)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Books"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Books"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(BooksDGV, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BackBtn As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents QtyTb As TextBox
    Friend WithEvents BPublisherTb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ResetBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents BNameTb As TextBox
    Friend WithEvents EditBtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents BAuthorTb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents SaveBtn As Button
    Friend WithEvents BPriceTb As TextBox
    Friend WithEvents BooksDGV As DataGridView
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
End Class
