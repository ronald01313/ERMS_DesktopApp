<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dashBoard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(dashBoard))
        Panel1 = New Panel()
        Panel6 = New Panel()
        btn_main = New Button()
        Panel5 = New Panel()
        Panel4 = New Panel()
        btn_bookings = New Button()
        Panel3 = New Panel()
        PictureBox1 = New PictureBox()
        btn_events = New Button()
        Panel2 = New Panel()
        PictureBox2 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        Panel_main = New Panel()
        Panel_events = New Panel()
        Panel_bookings = New Panel()
        Label2 = New Label()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        Panel_main.SuspendLayout()
        Panel_events.SuspendLayout()
        Panel_bookings.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SkyBlue
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(btn_main)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(btn_bookings)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(btn_events)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(306, 633)
        Panel1.TabIndex = 0
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.DarkGray
        Panel6.Location = New Point(3, 359)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(10, 73)
        Panel6.TabIndex = 6
        ' 
        ' btn_main
        ' 
        btn_main.BackColor = Color.Transparent
        btn_main.FlatAppearance.BorderSize = 0
        btn_main.FlatStyle = FlatStyle.Flat
        btn_main.Font = New Font("Lucida Console", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_main.Image = CType(resources.GetObject("btn_main.Image"), Image)
        btn_main.Location = New Point(3, 359)
        btn_main.Name = "btn_main"
        btn_main.Size = New Size(303, 73)
        btn_main.TabIndex = 5
        btn_main.Text = "  Home"
        btn_main.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_main.UseVisualStyleBackColor = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.YellowGreen
        Panel5.Location = New Point(48, 168)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(200, 11)
        Panel5.TabIndex = 2
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.DarkGray
        Panel4.Location = New Point(3, 280)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(10, 73)
        Panel4.TabIndex = 4
        ' 
        ' btn_bookings
        ' 
        btn_bookings.BackColor = Color.Transparent
        btn_bookings.FlatAppearance.BorderSize = 0
        btn_bookings.FlatStyle = FlatStyle.Flat
        btn_bookings.Font = New Font("Lucida Console", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_bookings.Image = CType(resources.GetObject("btn_bookings.Image"), Image)
        btn_bookings.Location = New Point(0, 280)
        btn_bookings.Name = "btn_bookings"
        btn_bookings.Size = New Size(303, 73)
        btn_bookings.TabIndex = 3
        btn_bookings.Text = "  Bookings"
        btn_bookings.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_bookings.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.DarkGray
        Panel3.Location = New Point(3, 201)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(10, 73)
        Panel3.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Dock = DockStyle.Top
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(306, 162)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' btn_events
        ' 
        btn_events.BackColor = Color.Transparent
        btn_events.FlatAppearance.BorderSize = 0
        btn_events.FlatStyle = FlatStyle.Flat
        btn_events.Font = New Font("Lucida Console", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_events.Image = CType(resources.GetObject("btn_events.Image"), Image)
        btn_events.Location = New Point(0, 201)
        btn_events.Name = "btn_events"
        btn_events.Size = New Size(303, 73)
        btn_events.TabIndex = 0
        btn_events.Text = "  Events"
        btn_events.TextImageRelation = TextImageRelation.ImageBeforeText
        btn_events.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ButtonShadow
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(PictureBox6)
        Panel2.Controls.Add(PictureBox7)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(306, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(863, 36)
        Panel2.TabIndex = 1
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox2.Location = New Point(818, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(36, 39)
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.Transparent
        PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), Image)
        PictureBox6.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox6.Location = New Point(723, 0)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(40, 39)
        PictureBox6.TabIndex = 3
        PictureBox6.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.Transparent
        PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), Image)
        PictureBox7.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox7.Location = New Point(769, 0)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(43, 39)
        PictureBox7.TabIndex = 4
        PictureBox7.TabStop = False
        ' 
        ' Panel_main
        ' 
        Panel_main.BackColor = Color.White
        Panel_main.Controls.Add(Panel_events)
        Panel_main.Controls.Add(PictureBox4)
        Panel_main.Controls.Add(PictureBox3)
        Panel_main.Dock = DockStyle.Fill
        Panel_main.Location = New Point(306, 36)
        Panel_main.Name = "Panel_main"
        Panel_main.Size = New Size(863, 597)
        Panel_main.TabIndex = 2
        ' 
        ' Panel_events
        ' 
        Panel_events.BackColor = Color.LightGray
        Panel_events.Controls.Add(Panel_bookings)
        Panel_events.Dock = DockStyle.Fill
        Panel_events.Location = New Point(0, 0)
        Panel_events.Name = "Panel_events"
        Panel_events.Size = New Size(863, 597)
        Panel_events.TabIndex = 2
        ' 
        ' Panel_bookings
        ' 
        Panel_bookings.BackColor = Color.RosyBrown
        Panel_bookings.Controls.Add(Label2)
        Panel_bookings.Dock = DockStyle.Fill
        Panel_bookings.Location = New Point(0, 0)
        Panel_bookings.Name = "Panel_bookings"
        Panel_bookings.Size = New Size(863, 597)
        Panel_bookings.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(372, 132)
        Label2.Name = "Label2"
        Label2.Size = New Size(136, 33)
        Label2.TabIndex = 5
        Label2.Text = "BOOKINGS"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox4.Location = New Point(554, 159)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(164, 154)
        PictureBox4.TabIndex = 1
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox3.Location = New Point(136, 159)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(164, 154)
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' dashBoard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1169, 633)
        Controls.Add(Panel_main)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "dashBoard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        Panel_main.ResumeLayout(False)
        Panel_events.ResumeLayout(False)
        Panel_bookings.ResumeLayout(False)
        Panel_bookings.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_events As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btn_bookings As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel_main As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Panel_events As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btn_main As Button
    Friend WithEvents Panel_bookings As Panel
    Friend WithEvents Label2 As Label
End Class
