<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tutorial
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
        Me.btnBack = New FontAwesome.Sharp.IconPictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLearnMoreEdit = New FontAwesome.Sharp.IconButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnLearnMoreCreate = New FontAwesome.Sharp.IconButton()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.btnBack.Location = New System.Drawing.Point(13, 15)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(46, 41)
        Me.btnBack.TabIndex = 13
        Me.btnBack.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(65, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(918, 78)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Tutorial"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(65, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(918, 39)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "What would you like help with?"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel3.Controls.Add(Me.IconPictureBox2)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.btnLearnMoreEdit)
        Me.Panel3.Location = New System.Drawing.Point(545, 172)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(248, 408)
        Me.Panel3.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 10.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(4, 265)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(225, 91)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Learn how to easily edit or delete an existing booking."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(3, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 30)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Editing A Booking"
        '
        'btnLearnMoreEdit
        '
        Me.btnLearnMoreEdit.BackColor = System.Drawing.Color.White
        Me.btnLearnMoreEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLearnMoreEdit.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLearnMoreEdit.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnLearnMoreEdit.IconChar = FontAwesome.Sharp.IconChar.ArrowRight
        Me.btnLearnMoreEdit.IconColor = System.Drawing.SystemColors.Highlight
        Me.btnLearnMoreEdit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLearnMoreEdit.IconSize = 20
        Me.btnLearnMoreEdit.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnLearnMoreEdit.Location = New System.Drawing.Point(8, 361)
        Me.btnLearnMoreEdit.Name = "btnLearnMoreEdit"
        Me.btnLearnMoreEdit.Size = New System.Drawing.Size(226, 34)
        Me.btnLearnMoreEdit.TabIndex = 17
        Me.btnLearnMoreEdit.Text = "Learn More"
        Me.btnLearnMoreEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLearnMoreEdit.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel2.Controls.Add(Me.IconPictureBox1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.btnLearnMoreCreate)
        Me.Panel2.Location = New System.Drawing.Point(251, 172)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(248, 408)
        Me.Panel2.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(4, 265)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(225, 91)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Learn how to easily create new bookings."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(3, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 30)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Creating A Booking"
        '
        'btnLearnMoreCreate
        '
        Me.btnLearnMoreCreate.BackColor = System.Drawing.Color.White
        Me.btnLearnMoreCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLearnMoreCreate.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLearnMoreCreate.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnLearnMoreCreate.IconChar = FontAwesome.Sharp.IconChar.ArrowRight
        Me.btnLearnMoreCreate.IconColor = System.Drawing.SystemColors.Highlight
        Me.btnLearnMoreCreate.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLearnMoreCreate.IconSize = 20
        Me.btnLearnMoreCreate.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnLearnMoreCreate.Location = New System.Drawing.Point(8, 362)
        Me.btnLearnMoreCreate.Name = "btnLearnMoreCreate"
        Me.btnLearnMoreCreate.Size = New System.Drawing.Size(225, 34)
        Me.btnLearnMoreCreate.TabIndex = 18
        Me.btnLearnMoreCreate.Text = "Learn More"
        Me.btnLearnMoreCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLearnMoreCreate.UseVisualStyleBackColor = False
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.SystemColors.Highlight
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.IconPictureBox1.IconColor = System.Drawing.Color.White
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 181
        Me.IconPictureBox1.Location = New System.Drawing.Point(34, 37)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(181, 190)
        Me.IconPictureBox1.TabIndex = 23
        Me.IconPictureBox1.TabStop = False
        '
        'IconPictureBox2
        '
        Me.IconPictureBox2.BackColor = System.Drawing.SystemColors.Highlight
        Me.IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.PenToSquare
        Me.IconPictureBox2.IconColor = System.Drawing.Color.White
        Me.IconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox2.IconSize = 175
        Me.IconPictureBox2.Location = New System.Drawing.Point(45, 37)
        Me.IconPictureBox2.Name = "IconPictureBox2"
        Me.IconPictureBox2.Size = New System.Drawing.Size(175, 177)
        Me.IconPictureBox2.TabIndex = 24
        Me.IconPictureBox2.TabStop = False
        '
        'Tutorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1021, 653)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Tutorial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tutorial"
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub


    Friend WithEvents btnBack As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLearnMoreEdit As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnLearnMoreCreate As FontAwesome.Sharp.IconButton
End Class
