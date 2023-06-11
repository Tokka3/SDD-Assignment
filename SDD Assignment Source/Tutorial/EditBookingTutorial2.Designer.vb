<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditBookingTutorial2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditBookingTutorial2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnNavigateTutorial = New FontAwesome.Sharp.IconButton()
        Me.btnEditTutorial = New FontAwesome.Sharp.IconButton()
        Me.btnDeleteTutorial = New FontAwesome.Sharp.IconButton()
        Me.btnClose = New FontAwesome.Sharp.IconPictureBox()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(69, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(918, 78)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Edit/Delete Existing Bookings Tutorial"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.PictureBox4)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Font = New System.Drawing.Font("Open Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(523, 369)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(478, 259)
        Me.GroupBox4.TabIndex = 41
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Step 4"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.SDD_Assignment_Source.My.Resources.Resources.EditSuccessful
        Me.PictureBox4.Location = New System.Drawing.Point(230, 35)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(230, 156)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(6, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(218, 207)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = resources.GetString("Label5.Text")
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.PictureBox2)
        Me.GroupBox3.Font = New System.Drawing.Font("Open Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(523, 124)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(478, 239)
        Me.GroupBox3.TabIndex = 39
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Step 3 (Seat Booking window)"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(7, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 188)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "You can now edit the booking's existing seats by selecting/deselecting the green " &
    "seat icons. The red seats represent the occupied seats."
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SDD_Assignment_Source.My.Resources.Resources.EditMode
        Me.PictureBox2.Location = New System.Drawing.Point(182, 32)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(290, 188)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Font = New System.Drawing.Font("Open Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(19, 369)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(478, 259)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Step 2"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(17, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(246, 221)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "You may then edit the user's fields (except for the user ID). To edit the user's " &
    "seats bookings, press the edit button next to the ""Seats"" textbox, and the Seat " &
    "Booking window will appear. "
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.SDD_Assignment_Source.My.Resources.Resources.EditBookingWindow
        Me.PictureBox3.Location = New System.Drawing.Point(269, 21)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(203, 221)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Open Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(19, 124)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(478, 239)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Step 1"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Open Sans", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(13, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(459, 117)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Once you have identified the record you would like to edit, simply press the edit" &
    " button."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SDD_Assignment_Source.My.Resources.Resources.EditRecord
        Me.PictureBox1.Location = New System.Drawing.Point(11, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(461, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnNavigateTutorial
        '
        Me.btnNavigateTutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavigateTutorial.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNavigateTutorial.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnNavigateTutorial.IconColor = System.Drawing.Color.Black
        Me.btnNavigateTutorial.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnNavigateTutorial.Location = New System.Drawing.Point(675, 88)
        Me.btnNavigateTutorial.Name = "btnNavigateTutorial"
        Me.btnNavigateTutorial.Size = New System.Drawing.Size(320, 37)
        Me.btnNavigateTutorial.TabIndex = 26
        Me.btnNavigateTutorial.Text = "How to navigate bookings"
        Me.btnNavigateTutorial.UseVisualStyleBackColor = True
        '
        'btnEditTutorial
        '
        Me.btnEditTutorial.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnEditTutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditTutorial.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditTutorial.ForeColor = System.Drawing.Color.White
        Me.btnEditTutorial.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnEditTutorial.IconColor = System.Drawing.Color.Black
        Me.btnEditTutorial.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEditTutorial.Location = New System.Drawing.Point(359, 88)
        Me.btnEditTutorial.Name = "btnEditTutorial"
        Me.btnEditTutorial.Size = New System.Drawing.Size(315, 37)
        Me.btnEditTutorial.TabIndex = 25
        Me.btnEditTutorial.Text = "How to edit a booking"
        Me.btnEditTutorial.UseVisualStyleBackColor = False
        '
        'btnDeleteTutorial
        '
        Me.btnDeleteTutorial.BackColor = System.Drawing.Color.White
        Me.btnDeleteTutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteTutorial.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteTutorial.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDeleteTutorial.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnDeleteTutorial.IconColor = System.Drawing.Color.Black
        Me.btnDeleteTutorial.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDeleteTutorial.Location = New System.Drawing.Point(36, 88)
        Me.btnDeleteTutorial.Name = "btnDeleteTutorial"
        Me.btnDeleteTutorial.Size = New System.Drawing.Size(317, 37)
        Me.btnDeleteTutorial.TabIndex = 24
        Me.btnDeleteTutorial.Text = "How to delete a booking"
        Me.btnDeleteTutorial.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark
        Me.btnClose.IconColor = System.Drawing.SystemColors.Highlight
        Me.btnClose.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnClose.IconSize = 41
        Me.btnClose.Location = New System.Drawing.Point(976, -1)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(46, 41)
        Me.btnClose.TabIndex = 42
        Me.btnClose.TabStop = False
        '
        'EditBookingTutorial2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1021, 653)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnNavigateTutorial)
        Me.Controls.Add(Me.btnEditTutorial)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnDeleteTutorial)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditBookingTutorial2"
        Me.Text = "EditBookingTutorial2"
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnNavigateTutorial As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEditTutorial As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDeleteTutorial As FontAwesome.Sharp.IconButton
    Friend WithEvents btnClose As FontAwesome.Sharp.IconPictureBox
End Class
