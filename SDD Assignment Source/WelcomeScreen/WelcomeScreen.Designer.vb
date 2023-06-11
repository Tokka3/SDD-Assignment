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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEditBookings = New FontAwesome.Sharp.IconButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnViewInsights = New FontAwesome.Sharp.IconButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.IconPictureBox3 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnViewTutorial = New FontAwesome.Sharp.IconButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnExit = New FontAwesome.Sharp.IconButton()
        Me.Panel2.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel2.Controls.Add(Me.IconPictureBox1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnEditBookings)
        Me.Panel2.Location = New System.Drawing.Point(66, 148)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(288, 442)
        Me.Panel2.TabIndex = 14
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.SystemColors.Highlight
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.IconPictureBox1.IconColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 228
        Me.IconPictureBox1.Location = New System.Drawing.Point(26, 27)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(241, 228)
        Me.IconPictureBox1.TabIndex = 24
        Me.IconPictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(22, 300)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(225, 91)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Create a new booking in seconds. View unavailable seats and manage different film" &
    "s."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(49, 269)
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
        Me.btnEditBookings.Location = New System.Drawing.Point(101, 394)
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
        Me.Panel3.Controls.Add(Me.IconPictureBox2)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.btnViewInsights)
        Me.Panel3.Location = New System.Drawing.Point(372, 148)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(288, 442)
        Me.Panel3.TabIndex = 15
        '
        'IconPictureBox2
        '
        Me.IconPictureBox2.BackColor = System.Drawing.SystemColors.Highlight
        Me.IconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.PenToSquare
        Me.IconPictureBox2.IconColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox2.IconSize = 213
        Me.IconPictureBox2.Location = New System.Drawing.Point(49, 27)
        Me.IconPictureBox2.Name = "IconPictureBox2"
        Me.IconPictureBox2.Size = New System.Drawing.Size(214, 213)
        Me.IconPictureBox2.TabIndex = 25
        Me.IconPictureBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 10.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(21, 299)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(237, 92)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "In this form, you may search, sort and filter your bookings. Bookings can easily " &
    "be edited and deleted."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(47, 269)
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
        Me.btnViewInsights.Location = New System.Drawing.Point(100, 394)
        Me.btnViewInsights.Name = "btnViewInsights"
        Me.btnViewInsights.Size = New System.Drawing.Size(82, 34)
        Me.btnViewInsights.TabIndex = 17
        Me.btnViewInsights.Text = "View"
        Me.btnViewInsights.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewInsights.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel5.Controls.Add(Me.IconPictureBox3)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.btnViewTutorial)
        Me.Panel5.Location = New System.Drawing.Point(679, 149)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(288, 441)
        Me.Panel5.TabIndex = 16
        '
        'IconPictureBox3
        '
        Me.IconPictureBox3.BackColor = System.Drawing.SystemColors.Highlight
        Me.IconPictureBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle
        Me.IconPictureBox3.IconColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.IconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox3.IconSize = 213
        Me.IconPictureBox3.Location = New System.Drawing.Point(40, 41)
        Me.IconPictureBox3.Name = "IconPictureBox3"
        Me.IconPictureBox3.Size = New System.Drawing.Size(214, 213)
        Me.IconPictureBox3.TabIndex = 26
        Me.IconPictureBox3.TabStop = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 10.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(3, 299)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(282, 77)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Quickly learn how to operate your booking system with ease."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(68, 269)
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
        Me.btnViewTutorial.Location = New System.Drawing.Point(103, 393)
        Me.btnViewTutorial.Name = "btnViewTutorial"
        Me.btnViewTutorial.Size = New System.Drawing.Size(82, 34)
        Me.btnViewTutorial.TabIndex = 16
        Me.btnViewTutorial.Text = "View"
        Me.btnViewTutorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewTutorial.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(61, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(918, 58)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Where would you like to go?"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark
        Me.btnExit.IconColor = System.Drawing.Color.White
        Me.btnExit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnExit.IconSize = 22
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExit.Location = New System.Drawing.Point(930, 611)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(79, 30)
        Me.btnExit.TabIndex = 29
        Me.btnExit.Text = "EXIT"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'WelcomeScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1021, 653)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "WelcomeScreen"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WelcomeScreen"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnViewTutorial As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnViewInsights As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnEditBookings As FontAwesome.Sharp.IconButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox3 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnExit As FontAwesome.Sharp.IconButton
End Class
