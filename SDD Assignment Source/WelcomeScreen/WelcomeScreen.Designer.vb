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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Login = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2GradientPanel5 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel6 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2GradientPanel3 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel4 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnEditBookings = New FontAwesome.Sharp.IconButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2ContextMenuStrip2 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.btnBack = New FontAwesome.Sharp.IconPictureBox()
        Me.btnViewBooking = New FontAwesome.Sharp.IconButton()
        Me.btnViewTutorial = New FontAwesome.Sharp.IconButton()
        Me.Login.SuspendLayout()
        Me.Guna2GradientPanel5.SuspendLayout()
        Me.Guna2GradientPanel3.SuspendLayout()
        Me.Guna2GradientPanel2.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 10
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.ResizeForm = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Login
        '
        Me.Login.BorderColor = System.Drawing.SystemColors.Highlight
        Me.Login.Controls.Add(Me.Guna2GradientPanel5)
        Me.Login.Controls.Add(Me.Guna2GradientPanel6)
        Me.Login.Controls.Add(Me.Guna2GradientPanel3)
        Me.Login.Controls.Add(Me.Guna2GradientPanel4)
        Me.Login.Controls.Add(Me.Guna2GradientPanel2)
        Me.Login.Controls.Add(Me.Guna2GradientPanel1)
        Me.Login.CustomBorderColor = System.Drawing.SystemColors.Highlight
        Me.Login.Font = New System.Drawing.Font("Segoe UI Semibold", 12.25!, System.Drawing.FontStyle.Bold)
        Me.Login.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Login.Location = New System.Drawing.Point(51, 92)
        Me.Login.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(927, 505)
        Me.Login.TabIndex = 11
        Me.Login.Text = "Select Actions"
        '
        'Guna2GradientPanel5
        '
        Me.Guna2GradientPanel5.BackColor = System.Drawing.SystemColors.Highlight
        Me.Guna2GradientPanel5.BorderRadius = 5
        Me.Guna2GradientPanel5.Controls.Add(Me.btnViewTutorial)
        Me.Guna2GradientPanel5.Controls.Add(Me.Label6)
        Me.Guna2GradientPanel5.Controls.Add(Me.Label7)
        Me.Guna2GradientPanel5.Location = New System.Drawing.Point(626, 288)
        Me.Guna2GradientPanel5.Name = "Guna2GradientPanel5"
        Me.Guna2GradientPanel5.Size = New System.Drawing.Size(262, 177)
        Me.Guna2GradientPanel5.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(7, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(237, 85)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Learn how to operate this system with ease."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 13.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(6, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 25)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Tutorial"
        '
        'Guna2GradientPanel6
        '
        Me.Guna2GradientPanel6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Guna2GradientPanel6.BackgroundImage = Global.SDD_Assignment_Source.My.Resources.Resources.tutorial
        Me.Guna2GradientPanel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Guna2GradientPanel6.BorderColor = System.Drawing.SystemColors.Highlight
        Me.Guna2GradientPanel6.BorderRadius = 5
        Me.Guna2GradientPanel6.BorderThickness = 1
        Me.Guna2GradientPanel6.Location = New System.Drawing.Point(626, 75)
        Me.Guna2GradientPanel6.Name = "Guna2GradientPanel6"
        Me.Guna2GradientPanel6.Size = New System.Drawing.Size(262, 246)
        Me.Guna2GradientPanel6.TabIndex = 3
        '
        'Guna2GradientPanel3
        '
        Me.Guna2GradientPanel3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Guna2GradientPanel3.BorderRadius = 5
        Me.Guna2GradientPanel3.Controls.Add(Me.btnViewBooking)
        Me.Guna2GradientPanel3.Controls.Add(Me.Label4)
        Me.Guna2GradientPanel3.Controls.Add(Me.Label5)
        Me.Guna2GradientPanel3.Location = New System.Drawing.Point(330, 288)
        Me.Guna2GradientPanel3.Name = "Guna2GradientPanel3"
        Me.Guna2GradientPanel3.Size = New System.Drawing.Size(262, 177)
        Me.Guna2GradientPanel3.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(7, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(237, 85)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "View bookings, analytics and insights."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 13.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(6, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 25)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "View Bookings"
        '
        'Guna2GradientPanel4
        '
        Me.Guna2GradientPanel4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Guna2GradientPanel4.BackgroundImage = Global.SDD_Assignment_Source.My.Resources.Resources.insight
        Me.Guna2GradientPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Guna2GradientPanel4.BorderColor = System.Drawing.SystemColors.Highlight
        Me.Guna2GradientPanel4.BorderRadius = 5
        Me.Guna2GradientPanel4.BorderThickness = 1
        Me.Guna2GradientPanel4.Location = New System.Drawing.Point(330, 75)
        Me.Guna2GradientPanel4.Name = "Guna2GradientPanel4"
        Me.Guna2GradientPanel4.Size = New System.Drawing.Size(262, 246)
        Me.Guna2GradientPanel4.TabIndex = 3
        '
        'Guna2GradientPanel2
        '
        Me.Guna2GradientPanel2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Guna2GradientPanel2.BorderRadius = 5
        Me.Guna2GradientPanel2.Controls.Add(Me.btnEditBookings)
        Me.Guna2GradientPanel2.Controls.Add(Me.Label3)
        Me.Guna2GradientPanel2.Controls.Add(Me.Label2)
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(35, 288)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(262, 177)
        Me.Guna2GradientPanel2.TabIndex = 1
        '
        'btnEditBookings
        '
        Me.btnEditBookings.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEditBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditBookings.Font = New System.Drawing.Font("Segoe UI Semibold", 13.25!, System.Drawing.FontStyle.Bold)
        Me.btnEditBookings.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnEditBookings.IconChar = FontAwesome.Sharp.IconChar.ArrowRight
        Me.btnEditBookings.IconColor = System.Drawing.SystemColors.Highlight
        Me.btnEditBookings.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEditBookings.IconSize = 24
        Me.btnEditBookings.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnEditBookings.Location = New System.Drawing.Point(131, 129)
        Me.btnEditBookings.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEditBookings.Name = "btnEditBookings"
        Me.btnEditBookings.Size = New System.Drawing.Size(112, 36)
        Me.btnEditBookings.TabIndex = 3
        Me.btnEditBookings.Text = "View"
        Me.btnEditBookings.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(7, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(237, 85)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Using our booking system, you may update, edit, or delete bookings instantly."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(6, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Edit Bookings"
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Guna2GradientPanel1.BackgroundImage = Global.SDD_Assignment_Source.My.Resources.Resources._360_F_407087550_7PVnCAGviw1xZ9IIaB498s9Pm95LdlPb
        Me.Guna2GradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Guna2GradientPanel1.BorderColor = System.Drawing.SystemColors.Highlight
        Me.Guna2GradientPanel1.BorderRadius = 5
        Me.Guna2GradientPanel1.BorderThickness = 1
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(35, 75)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(262, 246)
        Me.Guna2GradientPanel1.TabIndex = 0
        '
        'Guna2ContextMenuStrip2
        '
        Me.Guna2ContextMenuStrip2.Name = "Guna2ContextMenuStrip2"
        Me.Guna2ContextMenuStrip2.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip2.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip2.RenderStyle.ColorTable = Nothing
        Me.Guna2ContextMenuStrip2.RenderStyle.RoundedEdges = True
        Me.Guna2ContextMenuStrip2.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip2.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip2.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip2.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip2.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Guna2ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
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
        Me.IconPictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        'btnViewBooking
        '
        Me.btnViewBooking.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnViewBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewBooking.Font = New System.Drawing.Font("Segoe UI Semibold", 13.25!, System.Drawing.FontStyle.Bold)
        Me.btnViewBooking.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnViewBooking.IconChar = FontAwesome.Sharp.IconChar.ArrowRight
        Me.btnViewBooking.IconColor = System.Drawing.SystemColors.Highlight
        Me.btnViewBooking.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnViewBooking.IconSize = 24
        Me.btnViewBooking.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnViewBooking.Location = New System.Drawing.Point(132, 124)
        Me.btnViewBooking.Margin = New System.Windows.Forms.Padding(2)
        Me.btnViewBooking.Name = "btnViewBooking"
        Me.btnViewBooking.Size = New System.Drawing.Size(112, 36)
        Me.btnViewBooking.TabIndex = 4
        Me.btnViewBooking.Text = "View"
        Me.btnViewBooking.UseVisualStyleBackColor = False
        '
        'btnViewTutorial
        '
        Me.btnViewTutorial.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnViewTutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewTutorial.Font = New System.Drawing.Font("Segoe UI Semibold", 13.25!, System.Drawing.FontStyle.Bold)
        Me.btnViewTutorial.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnViewTutorial.IconChar = FontAwesome.Sharp.IconChar.ArrowRight
        Me.btnViewTutorial.IconColor = System.Drawing.SystemColors.Highlight
        Me.btnViewTutorial.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnViewTutorial.IconSize = 24
        Me.btnViewTutorial.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.btnViewTutorial.Location = New System.Drawing.Point(132, 124)
        Me.btnViewTutorial.Margin = New System.Windows.Forms.Padding(2)
        Me.btnViewTutorial.Name = "btnViewTutorial"
        Me.btnViewTutorial.Size = New System.Drawing.Size(112, 36)
        Me.btnViewTutorial.TabIndex = 5
        Me.btnViewTutorial.Text = "View"
        Me.btnViewTutorial.UseVisualStyleBackColor = False
        '
        'WelcomeScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1021, 653)
        Me.Controls.Add(Me.IconPictureBox1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Login)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "WelcomeScreen"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WelcomeScreen"
        Me.Login.ResumeLayout(False)
        Me.Guna2GradientPanel5.ResumeLayout(False)
        Me.Guna2GradientPanel5.PerformLayout()
        Me.Guna2GradientPanel3.ResumeLayout(False)
        Me.Guna2GradientPanel3.PerformLayout()
        Me.Guna2GradientPanel2.ResumeLayout(False)
        Me.Guna2GradientPanel2.PerformLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Login As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2GradientPanel5 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Guna2GradientPanel6 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2GradientPanel3 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2GradientPanel4 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2ContextMenuStrip2 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btnBack As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btnEditBookings As FontAwesome.Sharp.IconButton
    Friend WithEvents btnViewBooking As FontAwesome.Sharp.IconButton
    Friend WithEvents btnViewTutorial As FontAwesome.Sharp.IconButton
End Class
