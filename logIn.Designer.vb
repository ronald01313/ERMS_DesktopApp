<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class logIn
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(logIn))
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        txt_adminPass = New TextBox()
        txt_adminUser = New TextBox()
        btn_adminLogin = New Button()
        PictureBox4 = New PictureBox()
        Panel3 = New Panel()
        Label1 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SkyBlue
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(278, 295)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(12, 45)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(251, 188)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.LightBlue
        Panel2.Controls.Add(PictureBox3)
        Panel2.Controls.Add(PictureBox4)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(txt_adminPass)
        Panel2.Controls.Add(txt_adminUser)
        Panel2.Location = New Point(284, 62)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(359, 144)
        Panel2.TabIndex = 1
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox3.Location = New Point(84, 90)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(40, 35)
        PictureBox3.TabIndex = 3
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(84, 22)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(40, 33)
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' txt_adminPass
        ' 
        txt_adminPass.Font = New Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        txt_adminPass.Location = New Point(107, 90)
        txt_adminPass.Name = "txt_adminPass"
        txt_adminPass.PasswordChar = "*"c
        txt_adminPass.PlaceholderText = "Password"
        txt_adminPass.Size = New Size(245, 33)
        txt_adminPass.TabIndex = 1
        txt_adminPass.TextAlign = HorizontalAlignment.Center
        ' 
        ' txt_adminUser
        ' 
        txt_adminUser.Font = New Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        txt_adminUser.Location = New Point(107, 22)
        txt_adminUser.Name = "txt_adminUser"
        txt_adminUser.PlaceholderText = "Email/username"
        txt_adminUser.Size = New Size(245, 33)
        txt_adminUser.TabIndex = 0
        txt_adminUser.TextAlign = HorizontalAlignment.Center
        ' 
        ' btn_adminLogin
        ' 
        btn_adminLogin.BackColor = Color.SkyBlue
        btn_adminLogin.FlatAppearance.BorderSize = 0
        btn_adminLogin.FlatStyle = FlatStyle.Flat
        btn_adminLogin.Font = New Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_adminLogin.ForeColor = Color.Navy
        btn_adminLogin.Location = New Point(284, 221)
        btn_adminLogin.Name = "btn_adminLogin"
        btn_adminLogin.Size = New Size(359, 62)
        btn_adminLogin.TabIndex = 2
        btn_adminLogin.Text = "Log in"
        btn_adminLogin.UseVisualStyleBackColor = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox4.Location = New Point(14, 22)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(64, 103)
        PictureBox4.TabIndex = 3
        PictureBox4.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Silver
        Panel3.Controls.Add(Label1)
        Panel3.Location = New Point(284, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(359, 56)
        Panel3.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.HotTrack
        Label1.Location = New Point(84, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(220, 36)
        Label1.TabIndex = 4
        Label1.Text = "ADMINISTRATOR"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' logIn
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSlateGray
        ClientSize = New Size(651, 295)
        Controls.Add(Panel3)
        Controls.Add(btn_adminLogin)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "logIn"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Admin Login"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_adminUser As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents txt_adminPass As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btn_adminLogin As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
End Class
