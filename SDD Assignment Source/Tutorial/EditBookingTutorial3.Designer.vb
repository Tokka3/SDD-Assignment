<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditBookingTutorial3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditBookingTutorial3))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnTryDelete = New FontAwesome.Sharp.IconButton()
        Me.btnBack = New FontAwesome.Sharp.IconPictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnNavigateTutorial = New FontAwesome.Sharp.IconButton()
        Me.btnEditTutorial = New FontAwesome.Sharp.IconButton()
        Me.btnDeleteTutorial = New FontAwesome.Sharp.IconButton()
        Me.GroupBox2.SuspendLayout()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(76, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(918, 78)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Navigate Bookings"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnTryDelete)
        Me.GroupBox2.Font = New System.Drawing.Font("Open Sans", 14.25!)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 110)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(961, 517)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(19, 315)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 40)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Filter:"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Open Sans", 14.75!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(20, 355)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(619, 90)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "You may filter the records by film. Such that, if you only want to view records w" &
    "ith a specific film, you may select the film in the combo box and press the ""Fil" &
    "ter"" button. "
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(19, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 40)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Sort:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Open Sans", 14.75!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(20, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(619, 101)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "You may sort the bookings in a variety of ways. For example: ID, First Name, Last" &
    " Name, Total Cost, etc. All these fields can be sorted in ascending or descendin" &
    "g order."
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(19, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 40)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Search:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Open Sans", 14.75!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(20, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(619, 123)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'btnTryDelete
        '
        Me.btnTryDelete.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnTryDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTryDelete.Font = New System.Drawing.Font("Segoe UI Semibold", 13.25!, System.Drawing.FontStyle.Bold)
        Me.btnTryDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnTryDelete.IconChar = FontAwesome.Sharp.IconChar.Eye
        Me.btnTryDelete.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnTryDelete.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnTryDelete.IconSize = 34
        Me.btnTryDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTryDelete.Location = New System.Drawing.Point(179, 463)
        Me.btnTryDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTryDelete.Name = "btnTryDelete"
        Me.btnTryDelete.Size = New System.Drawing.Size(313, 38)
        Me.btnTryDelete.TabIndex = 38
        Me.btnTryDelete.Text = "Try Now"
        Me.btnTryDelete.UseVisualStyleBackColor = False
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
        Me.btnBack.Location = New System.Drawing.Point(24, 24)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(46, 41)
        Me.btnBack.TabIndex = 17
        Me.btnBack.TabStop = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(251, 455)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(204, 41)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "THIS IS A PICTURE"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SDD_Assignment_Source.My.Resources.Resources.SearchSortFilterTut
        Me.PictureBox2.Location = New System.Drawing.Point(627, 57)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(246, 428)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 45
        Me.PictureBox2.TabStop = False
        '
        'btnNavigateTutorial
        '
        Me.btnNavigateTutorial.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnNavigateTutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavigateTutorial.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNavigateTutorial.ForeColor = System.Drawing.Color.White
        Me.btnNavigateTutorial.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnNavigateTutorial.IconColor = System.Drawing.Color.Black
        Me.btnNavigateTutorial.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnNavigateTutorial.Location = New System.Drawing.Point(666, 86)
        Me.btnNavigateTutorial.Name = "btnNavigateTutorial"
        Me.btnNavigateTutorial.Size = New System.Drawing.Size(321, 37)
        Me.btnNavigateTutorial.TabIndex = 23
        Me.btnNavigateTutorial.Text = "How to navigate bookings"
        Me.btnNavigateTutorial.UseVisualStyleBackColor = False
        '
        'btnEditTutorial
        '
        Me.btnEditTutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditTutorial.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditTutorial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnEditTutorial.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnEditTutorial.IconColor = System.Drawing.Color.Black
        Me.btnEditTutorial.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEditTutorial.Location = New System.Drawing.Point(350, 86)
        Me.btnEditTutorial.Name = "btnEditTutorial"
        Me.btnEditTutorial.Size = New System.Drawing.Size(310, 37)
        Me.btnEditTutorial.TabIndex = 22
        Me.btnEditTutorial.Text = "How to edit a booking"
        Me.btnEditTutorial.UseVisualStyleBackColor = True
        '
        'btnDeleteTutorial
        '
        Me.btnDeleteTutorial.BackColor = System.Drawing.Color.White
        Me.btnDeleteTutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteTutorial.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteTutorial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnDeleteTutorial.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnDeleteTutorial.IconColor = System.Drawing.Color.Black
        Me.btnDeleteTutorial.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDeleteTutorial.Location = New System.Drawing.Point(26, 86)
        Me.btnDeleteTutorial.Name = "btnDeleteTutorial"
        Me.btnDeleteTutorial.Size = New System.Drawing.Size(318, 37)
        Me.btnDeleteTutorial.TabIndex = 21
        Me.btnDeleteTutorial.Text = "How to delete a booking"
        Me.btnDeleteTutorial.UseVisualStyleBackColor = False
        '
        'EditBookingTutorial3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1021, 653)
        Me.Controls.Add(Me.btnNavigateTutorial)
        Me.Controls.Add(Me.btnEditTutorial)
        Me.Controls.Add(Me.btnDeleteTutorial)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "EditBookingTutorial3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewBookingsTutorial"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnTryDelete As FontAwesome.Sharp.IconButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnNavigateTutorial As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEditTutorial As FontAwesome.Sharp.IconButton
    Friend WithEvents btnDeleteTutorial As FontAwesome.Sharp.IconButton
End Class
