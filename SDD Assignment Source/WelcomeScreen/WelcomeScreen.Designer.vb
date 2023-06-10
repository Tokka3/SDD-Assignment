<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WelcomeScreen
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.btnBack = New FontAwesome.Sharp.IconPictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEditBookings = New FontAwesome.Sharp.IconButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnViewInsights = New FontAwesome.Sharp.IconButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnViewTutorial = New FontAwesome.Sharp.IconButton()
        Me.Panel6 = New System.Windows.Forms.Panel()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(60, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(918, 78)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Welcome"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconPictureBox1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Gear
        Me.IconPictureBox1.IconColor = System.Drawing.SystemColors.Highlight
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 41
        Me.IconPictureBox1.Location = New System.Drawing.Point(975, 15)
        Me.IconPictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(46, 41)
        Me.IconPictureBox1.TabIndex = 3
        Me.IconPictureBox1.TabStop = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft
        Me.btnBack.IconColor = System.Drawing.SystemColors.Highlight
        Me.btnBack.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnBack.IconSize = 41
        Me.btnBack.Location = New System.Drawing.Point(12, 15)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(46, 41)
        Me.btnBack.TabIndex = 12
        Me.btnBack.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Panel1.BackgroundImage = Global.SDD_Assignment_Source.My.Resources.Resources._360_F_407087550_7PVnCAGviw1xZ9IIaB498s9Pm95LdlPb
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(246, 232)
        Me.Panel1.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnEditBookings)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(84, 156)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(248, 408)
        Me.Panel2.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(4, 265)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(225, 91)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Create, update and delete bookings."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(3, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 30)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Create Bookings"
        '
        'btnEditBookings
        '
        Me.btnEditBookings.BackColor = System.Drawing.Color.White
        Me.btnEditBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditBookings.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditBookings.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnEditBookings.IconChar = FontAwesome.Sharp.IconChar.ArrowRight
        Me.btnEditBookings.IconColor = System.Drawing.SystemColors.Highlight
        Me.btnEditBookings.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEditBookings.IconSize = 20
        Me.btnEditBookings.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnEditBookings.Location = New System.Drawing.Point(151, 362)
        Me.btnEditBookings.Name = "btnEditBookings"
        Me.btnEditBookings.Size = New System.Drawing.Size(82, 34)
        Me.btnEditBookings.TabIndex = 18
        Me.btnEditBookings.Text = "View"
        Me.btnEditBookings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditBookings.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.btnViewInsights)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(378, 156)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(248, 408)
        Me.Panel3.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 10.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(4, 265)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(225, 91)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Create, update and delete bookings."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(3, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(199, 30)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "View/Edit Bookings"
        '
        'btnViewInsights
        '
        Me.btnViewInsights.BackColor = System.Drawing.Color.White
        Me.btnViewInsights.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewInsights.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewInsights.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnViewInsights.IconChar = FontAwesome.Sharp.IconChar.ArrowRight
        Me.btnViewInsights.IconColor = System.Drawing.SystemColors.Highlight
        Me.btnViewInsights.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnViewInsights.IconSize = 20
        Me.btnViewInsights.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnViewInsights.Location = New System.Drawing.Point(152, 361)
        Me.btnViewInsights.Name = "btnViewInsights"
        Me.btnViewInsights.Size = New System.Drawing.Size(82, 34)
        Me.btnViewInsights.TabIndex = 17
        Me.btnViewInsights.Text = "View"
        Me.btnViewInsights.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewInsights.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Panel4.BackgroundImage = Global.SDD_Assignment_Source.My.Resources.Resources.insight
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Location = New System.Drawing.Point(1, 1)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(246, 232)
        Me.Panel4.TabIndex = 13
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.btnViewTutorial)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Location = New System.Drawing.Point(672, 156)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(248, 408)
        Me.Panel5.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 10.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(3, 265)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(225, 91)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Create, update and delete bookings."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(3, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 30)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "View Tutorial"
        '
        'btnViewTutorial
        '
        Me.btnViewTutorial.BackColor = System.Drawing.Color.White
        Me.btnViewTutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewTutorial.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewTutorial.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnViewTutorial.IconChar = FontAwesome.Sharp.IconChar.ArrowRight
        Me.btnViewTutorial.IconColor = System.Drawing.SystemColors.Highlight
        Me.btnViewTutorial.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnViewTutorial.IconSize = 20
        Me.btnViewTutorial.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnViewTutorial.Location = New System.Drawing.Point(151, 361)
        Me.btnViewTutorial.Name = "btnViewTutorial"
        Me.btnViewTutorial.Size = New System.Drawing.Size(82, 34)
        Me.btnViewTutorial.TabIndex = 16
        Me.btnViewTutorial.Text = "View"
        Me.btnViewTutorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewTutorial.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Panel6.BackgroundImage = Global.SDD_Assignment_Source.My.Resources.Resources.tutorial
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel6.Location = New System.Drawing.Point(1, 1)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(246, 232)
        Me.Panel6.TabIndex = 13
        '
        'WelcomeScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1021, 653)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.IconPictureBox1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "WelcomeScreen"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WelcomeScreen"
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label

    Friend WithEvents btnBack As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnViewTutorial As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnViewInsights As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnEditBookings As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
End Class
