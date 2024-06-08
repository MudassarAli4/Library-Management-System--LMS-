<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Login))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        uNameTb = New TextBox()
        PassTb = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        LoginBtn = New Button()
        Label4 = New Label()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(42, 86)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(151, 140)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Crimson
        Label1.Location = New Point(179, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(302, 25)
        Label1.TabIndex = 3
        Label1.Text = "Library Management System"
        ' 
        ' uNameTb
        ' 
        uNameTb.Location = New Point(374, 124)
        uNameTb.Name = "uNameTb"
        uNameTb.Size = New Size(152, 23)
        uNameTb.TabIndex = 4
        ' 
        ' PassTb
        ' 
        PassTb.Location = New Point(374, 176)
        PassTb.Name = "PassTb"
        PassTb.PasswordChar = "*"c
        PassTb.Size = New Size(152, 23)
        PassTb.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.Crimson
        Label2.Location = New Point(234, 124)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 22)
        Label2.TabIndex = 6
        Label2.Text = "UserName"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.Crimson
        Label3.Location = New Point(234, 176)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 22)
        Label3.TabIndex = 7
        Label3.Text = "Password"
        ' 
        ' LoginBtn
        ' 
        LoginBtn.BackColor = Color.Gainsboro
        LoginBtn.FlatAppearance.BorderSize = 0
        LoginBtn.FlatStyle = FlatStyle.Flat
        LoginBtn.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LoginBtn.ForeColor = Color.Crimson
        LoginBtn.Location = New Point(272, 216)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(159, 29)
        LoginBtn.TabIndex = 8
        LoginBtn.Text = "Login"
        LoginBtn.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 12F, FontStyle.Underline, GraphicsUnit.Point)
        Label4.ForeColor = Color.Crimson
        Label4.Location = New Point(316, 248)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 21)
        Label4.TabIndex = 9
        Label4.Text = "Admin"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(531, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(42, 38)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 10
        PictureBox2.TabStop = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MistyRose
        ClientSize = New Size(573, 297)
        Controls.Add(PictureBox2)
        Controls.Add(Label4)
        Controls.Add(LoginBtn)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(PassTb)
        Controls.Add(uNameTb)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents uNameTb As TextBox
    Friend WithEvents PassTb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LoginBtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
