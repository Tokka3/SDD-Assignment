<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditBooking
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
        Me.txtDOB = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbxMovieSelection = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSeats = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExitButton = New FontAwesome.Sharp.IconPictureBox()
        Me.btnEdit = New FontAwesome.Sharp.IconButton()
        Me.btnConfirmEdit = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
        CType(Me.btnExitButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDOB
        '
        Me.txtDOB.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtDOB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.txtDOB.Location = New System.Drawing.Point(12, 203)
        Me.txtDOB.Multiline = True
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(326, 32)
        Me.txtDOB.TabIndex = 169
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtLastName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.txtLastName.Location = New System.Drawing.Point(13, 141)
        Me.txtLastName.Multiline = True
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(326, 32)
        Me.txtLastName.TabIndex = 168
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.txtFirstName.Location = New System.Drawing.Point(12, 79)
        Me.txtFirstName.Multiline = True
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(326, 32)
        Me.txtFirstName.TabIndex = 167
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Open Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(7, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(279, 28)
        Me.Label7.TabIndex = 166
        Me.Label7.Text = "Date of Birth (DD/MM/YYYY):"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Open Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(8, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(158, 28)
        Me.Label8.TabIndex = 165
        Me.Label8.Text = "Last Name:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Open Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(8, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(158, 28)
        Me.Label9.TabIndex = 164
        Me.Label9.Text = "First Name:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbxMovieSelection
        '
        Me.cbxMovieSelection.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.cbxMovieSelection.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cbxMovieSelection.FormattingEnabled = True
        Me.cbxMovieSelection.Items.AddRange(New Object() {"Good Will Hunting", "The Lion King", "Forrest Gump"})
        Me.cbxMovieSelection.Location = New System.Drawing.Point(14, 333)
        Me.cbxMovieSelection.Name = "cbxMovieSelection"
        Me.cbxMovieSelection.Size = New System.Drawing.Size(325, 33)
        Me.cbxMovieSelection.TabIndex = 170
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Open Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(10, 302)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 28)
        Me.Label1.TabIndex = 171
        Me.Label1.Text = "Film:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSeats
        '
        Me.txtSeats.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.txtSeats.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.txtSeats.Location = New System.Drawing.Point(12, 268)
        Me.txtSeats.Multiline = True
        Me.txtSeats.Name = "txtSeats"
        Me.txtSeats.Size = New System.Drawing.Size(225, 32)
        Me.txtSeats.TabIndex = 175
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Open Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(8, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 28)
        Me.Label3.TabIndex = 174
        Me.Label3.Text = "Seats"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(7, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(327, 39)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Edit Booking"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.btnExitButton)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 45)
        Me.Panel1.TabIndex = 177
        '
        'btnExitButton
        '
        Me.btnExitButton.BackColor = System.Drawing.Color.Transparent
        Me.btnExitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExitButton.IconChar = FontAwesome.Sharp.IconChar.Xmark
        Me.btnExitButton.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExitButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnExitButton.Location = New System.Drawing.Point(311, 9)
        Me.btnExitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExitButton.Name = "btnExitButton"
        Me.btnExitButton.Size = New System.Drawing.Size(32, 34)
        Me.btnExitButton.TabIndex = 17
        Me.btnExitButton.TabStop = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEdit.Font = New System.Drawing.Font("Segoe UI Semibold", 13.25!, System.Drawing.FontStyle.Bold)
        Me.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEdit.IconChar = FontAwesome.Sharp.IconChar.PenToSquare
        Me.btnEdit.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEdit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEdit.IconSize = 30
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEdit.Location = New System.Drawing.Point(244, 267)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnEdit.Size = New System.Drawing.Size(90, 32)
        Me.btnEdit.TabIndex = 176
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnConfirmEdit
        '
        Me.btnConfirmEdit.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnConfirmEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmEdit.Font = New System.Drawing.Font("Segoe UI Semibold", 13.25!, System.Drawing.FontStyle.Bold)
        Me.btnConfirmEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConfirmEdit.IconChar = FontAwesome.Sharp.IconChar.Upload
        Me.btnConfirmEdit.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConfirmEdit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnConfirmEdit.IconSize = 34
        Me.btnConfirmEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConfirmEdit.Location = New System.Drawing.Point(88, 382)
        Me.btnConfirmEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConfirmEdit.Name = "btnConfirmEdit"
        Me.btnConfirmEdit.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnConfirmEdit.Size = New System.Drawing.Size(177, 38)
        Me.btnConfirmEdit.TabIndex = 172
        Me.btnConfirmEdit.Text = "Confirm Edit"
        Me.btnConfirmEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfirmEdit.UseVisualStyleBackColor = False
        '
        'EditBooking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(350, 443)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.txtSeats)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnConfirmEdit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxMovieSelection)
        Me.Controls.Add(Me.txtDOB)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Name = "EditBooking"
        Me.Text = "EditBooking"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        CType(Me.btnExitButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDOB As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbxMovieSelection As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnConfirmEdit As FontAwesome.Sharp.IconButton
    Friend WithEvents txtSeats As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEdit As FontAwesome.Sharp.IconButton
    Friend WithEvents btnExitButton As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
End Class
