<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminLogin
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
        Panel1 = New Panel()
        Label1 = New Label()
        BackBtn = New Label()
        LoginBtn = New Button()
        Label3 = New Label()
        PassTb = New TextBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Crimson
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(420, 41)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(130, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(157, 25)
        Label1.TabIndex = 4
        Label1.Text = "ADMIN LOGIN"
        ' 
        ' BackBtn
        ' 
        BackBtn.AutoSize = True
        BackBtn.Font = New Font("Century Gothic", 12F, FontStyle.Underline, GraphicsUnit.Point)
        BackBtn.ForeColor = Color.Crimson
        BackBtn.Location = New Point(184, 158)
        BackBtn.Name = "BackBtn"
        BackBtn.Size = New Size(48, 21)
        BackBtn.TabIndex = 13
        BackBtn.Text = "Back"
        ' 
        ' LoginBtn
        ' 
        LoginBtn.BackColor = Color.Gainsboro
        LoginBtn.FlatAppearance.BorderSize = 0
        LoginBtn.FlatStyle = FlatStyle.Flat
        LoginBtn.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LoginBtn.ForeColor = Color.Crimson
        LoginBtn.Location = New Point(130, 117)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(159, 29)
        LoginBtn.TabIndex = 12
        LoginBtn.Text = "Login"
        LoginBtn.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.Crimson
        Label3.Location = New Point(74, 79)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 22)
        Label3.TabIndex = 11
        Label3.Text = "Password"
        ' 
        ' PassTb
        ' 
        PassTb.Location = New Point(214, 79)
        PassTb.Name = "PassTb"
        PassTb.PasswordChar = "*"c
        PassTb.Size = New Size(152, 23)
        PassTb.TabIndex = 10
        ' 
        ' AdminLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MistyRose
        ClientSize = New Size(420, 194)
        Controls.Add(BackBtn)
        Controls.Add(LoginBtn)
        Controls.Add(Label3)
        Controls.Add(PassTb)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "AdminLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AdminLogin"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BackBtn As Label
    Friend WithEvents LoginBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PassTb As TextBox
End Class
