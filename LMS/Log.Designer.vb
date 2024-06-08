<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Log
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Log))
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        LogDGV = New DataGridView()
        BackBtn = New Button()
        Label9 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(LogDGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        Panel1.Size = New Size(523, 39)
        Panel1.TabIndex = 1
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(481, 2)
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
        ' LogDGV
        ' 
        LogDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        LogDGV.Location = New Point(12, 81)
        LogDGV.Name = "LogDGV"
        LogDGV.RowTemplate.Height = 25
        LogDGV.Size = New Size(499, 159)
        LogDGV.TabIndex = 2
        ' 
        ' BackBtn
        ' 
        BackBtn.BackColor = Color.Gainsboro
        BackBtn.FlatAppearance.BorderSize = 0
        BackBtn.FlatStyle = FlatStyle.Flat
        BackBtn.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BackBtn.ForeColor = Color.Crimson
        BackBtn.Location = New Point(179, 246)
        BackBtn.Name = "BackBtn"
        BackBtn.Size = New Size(159, 29)
        BackBtn.TabIndex = 38
        BackBtn.Text = "Back"
        BackBtn.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = Color.Crimson
        Label9.Location = New Point(179, 46)
        Label9.Name = "Label9"
        Label9.Size = New Size(179, 25)
        Label9.TabIndex = 39
        Label9.Text = "Transactions Log"
        ' 
        ' Log
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MistyRose
        ClientSize = New Size(523, 287)
        Controls.Add(Label9)
        Controls.Add(BackBtn)
        Controls.Add(LogDGV)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Log"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Log"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(LogDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LogDGV As DataGridView
    Friend WithEvents BackBtn As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
