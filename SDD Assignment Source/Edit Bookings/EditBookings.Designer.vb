<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditBookings
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
        Me.components = New System.ComponentModel.Container()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLastName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPayment = New FontAwesome.Sharp.IconButton()
        Me.rtbSelectedSeats = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.Guna2ContextMenuStrip1 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.btnBack = New FontAwesome.Sharp.IconPictureBox()
        Me.IconSplitButton1 = New FontAwesome.Sharp.IconSplitButton()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 10
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.ResizeForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(62, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(900, 78)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Welcome"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderRadius = 7
        Me.Guna2GroupBox1.Controls.Add(Me.Label4)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2DateTimePicker1)
        Me.Guna2GroupBox1.Controls.Add(Me.Label2)
        Me.Guna2GroupBox1.Controls.Add(Me.txtLastName)
        Me.Guna2GroupBox1.Controls.Add(Me.Label5)
        Me.Guna2GroupBox1.Controls.Add(Me.txtFirstName)
        Me.Guna2GroupBox1.Controls.Add(Me.lblTotal)
        Me.Guna2GroupBox1.Controls.Add(Me.Label3)
        Me.Guna2GroupBox1.Controls.Add(Me.btnPayment)
        Me.Guna2GroupBox1.Controls.Add(Me.rtbSelectedSeats)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.SystemColors.Highlight
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(646, 124)
        Me.Guna2GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(351, 482)
        Me.Guna2GroupBox1.TabIndex = 16
        Me.Guna2GroupBox1.Text = "Edit Booking"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(9, 275)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 28)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Date of Birth:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2DateTimePicker1
        '
        Me.Guna2DateTimePicker1.Animated = True
        Me.Guna2DateTimePicker1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Guna2DateTimePicker1.BorderRadius = 3
        Me.Guna2DateTimePicker1.BorderThickness = 1
        Me.Guna2DateTimePicker1.Checked = True
        Me.Guna2DateTimePicker1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.Guna2DateTimePicker1.CheckedState.FillColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Guna2DateTimePicker1.CheckedState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Guna2DateTimePicker1.FillColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Guna2DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2DateTimePicker1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Guna2DateTimePicker1.Location = New System.Drawing.Point(14, 306)
        Me.Guna2DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.Name = "Guna2DateTimePicker1"
        Me.Guna2DateTimePicker1.Size = New System.Drawing.Size(323, 38)
        Me.Guna2DateTimePicker1.TabIndex = 24
        Me.Guna2DateTimePicker1.Value = New Date(2023, 5, 2, 9, 51, 5, 949)
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(9, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 28)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Last Name:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLastName
        '
        Me.txtLastName.Animated = True
        Me.txtLastName.BorderRadius = 3
        Me.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastName.DefaultText = ""
        Me.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLastName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLastName.Location = New System.Drawing.Point(14, 230)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastName.PlaceholderText = ""
        Me.txtLastName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLastName.SelectedText = ""
        Me.txtLastName.Size = New System.Drawing.Size(323, 38)
        Me.txtLastName.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(9, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 28)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "First Name:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFirstName
        '
        Me.txtFirstName.Animated = True
        Me.txtFirstName.BorderRadius = 3
        Me.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstName.DefaultText = ""
        Me.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstName.Location = New System.Drawing.Point(14, 155)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstName.PlaceholderText = ""
        Me.txtFirstName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFirstName.SelectedText = ""
        Me.txtFirstName.Size = New System.Drawing.Size(323, 38)
        Me.txtFirstName.TabIndex = 20
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(9, 402)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(141, 28)
        Me.lblTotal.TabIndex = 19
        Me.lblTotal.Text = "Total:"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(9, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 28)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Selected Seats:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnPayment
        '
        Me.btnPayment.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPayment.Font = New System.Drawing.Font("Segoe UI Semibold", 13.25!, System.Drawing.FontStyle.Bold)
        Me.btnPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPayment.IconChar = FontAwesome.Sharp.IconChar.CcVisa
        Me.btnPayment.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPayment.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPayment.IconSize = 34
        Me.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPayment.Location = New System.Drawing.Point(14, 432)
        Me.btnPayment.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(323, 38)
        Me.btnPayment.TabIndex = 5
        Me.btnPayment.Text = "Proceed To Payment"
        Me.btnPayment.UseVisualStyleBackColor = False
        '
        'rtbSelectedSeats
        '
        Me.rtbSelectedSeats.Animated = True
        Me.rtbSelectedSeats.BorderRadius = 3
        Me.rtbSelectedSeats.Cursor = System.Windows.Forms.Cursors.Default
        Me.rtbSelectedSeats.DefaultText = ""
        Me.rtbSelectedSeats.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.rtbSelectedSeats.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.rtbSelectedSeats.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.rtbSelectedSeats.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.rtbSelectedSeats.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rtbSelectedSeats.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.rtbSelectedSeats.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.rtbSelectedSeats.Location = New System.Drawing.Point(14, 81)
        Me.rtbSelectedSeats.Name = "rtbSelectedSeats"
        Me.rtbSelectedSeats.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.rtbSelectedSeats.PlaceholderText = ""
        Me.rtbSelectedSeats.ReadOnly = True
        Me.rtbSelectedSeats.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.rtbSelectedSeats.SelectedText = ""
        Me.rtbSelectedSeats.Size = New System.Drawing.Size(323, 36)
        Me.rtbSelectedSeats.TabIndex = 0
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.Tomato
        Me.lblMessage.Location = New System.Drawing.Point(95, 320)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(445, 25)
        Me.lblMessage.TabIndex = 17
        Me.lblMessage.Text = "SEATS ARE LOADED DYNAMICALLY AT RUNTIME"
        '
        'Guna2ContextMenuStrip1
        '
        Me.Guna2ContextMenuStrip1.Name = "Guna2ContextMenuStrip1"
        Me.Guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.ColorTable = Nothing
        Me.Guna2ContextMenuStrip1.RenderStyle.RoundedEdges = True
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Guna2ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 24
        Me.IconPictureBox1.Location = New System.Drawing.Point(-11, -12)
        Me.IconPictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(24, 26)
        Me.IconPictureBox1.TabIndex = 14
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
        Me.btnBack.Location = New System.Drawing.Point(10, 7)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(46, 41)
        Me.btnBack.TabIndex = 13
        Me.btnBack.TabStop = False
        '
        'IconSplitButton1
        '
        Me.IconSplitButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconSplitButton1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconSplitButton1.IconColor = System.Drawing.Color.Black
        Me.IconSplitButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconSplitButton1.IconSize = 48
        Me.IconSplitButton1.Name = "IconSplitButton1"
        Me.IconSplitButton1.Rotation = 0R
        Me.IconSplitButton1.Size = New System.Drawing.Size(23, 23)
        Me.IconSplitButton1.Text = "IconSplitButton1"
        '
        'EditBookings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1021, 653)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IconPictureBox1)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "EditBookings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditBookings"
        Me.Guna2GroupBox1.ResumeLayout(False)
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents btnBack As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents lblMessage As Label
    Friend WithEvents rtbSelectedSeats As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnPayment As FontAwesome.Sharp.IconButton
    Friend WithEvents IconSplitButton1 As FontAwesome.Sharp.IconSplitButton
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2ContextMenuStrip1 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLastName As Guna.UI2.WinForms.Guna2TextBox
End Class
