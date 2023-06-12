<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PaymentScreen
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExitButton = New FontAwesome.Sharp.IconPictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.txtCCNo = New System.Windows.Forms.TextBox()
        Me.txtExpiryDate = New System.Windows.Forms.TextBox()
        Me.txtCCV = New System.Windows.Forms.TextBox()
        Me.btnPayment = New FontAwesome.Sharp.IconButton()
        Me.pValidFirstName = New System.Windows.Forms.Panel()
        Me.pValidLastName = New System.Windows.Forms.Panel()
        Me.pValidCCNo = New System.Windows.Forms.Panel()
        Me.pValidExpDate = New System.Windows.Forms.Panel()
        Me.pValidCVV = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.btnExitButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Open Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(7, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 28)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Last Name:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Open Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(7, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 28)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "First Name:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Open Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(7, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(293, 28)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Credit Card No. (No Spaces)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Open Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(9, 279)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(257, 28)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Expiry Date (MM/YY)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Open Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(225, 279)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 28)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "CVV"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Open Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(12, 361)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(141, 28)
        Me.lblTotal.TabIndex = 34
        Me.lblTotal.Text = "Total:"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.btnExitButton)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(351, 45)
        Me.Panel1.TabIndex = 37
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
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(7, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(327, 39)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Payment"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFirstname
        '
        Me.txtFirstname.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.txtFirstname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.txtFirstname.Location = New System.Drawing.Point(12, 90)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.ReadOnly = True
        Me.txtFirstname.Size = New System.Drawing.Size(312, 33)
        Me.txtFirstname.TabIndex = 39
        '
        'txtLastname
        '
        Me.txtLastname.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.txtLastname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.txtLastname.Location = New System.Drawing.Point(12, 163)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.ReadOnly = True
        Me.txtLastname.Size = New System.Drawing.Size(312, 33)
        Me.txtLastname.TabIndex = 40
        '
        'txtCCNo
        '
        Me.txtCCNo.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.txtCCNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.txtCCNo.Location = New System.Drawing.Point(14, 238)
        Me.txtCCNo.Name = "txtCCNo"
        Me.txtCCNo.Size = New System.Drawing.Size(310, 33)
        Me.txtCCNo.TabIndex = 41
        '
        'txtExpiryDate
        '
        Me.txtExpiryDate.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.txtExpiryDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.txtExpiryDate.Location = New System.Drawing.Point(12, 310)
        Me.txtExpiryDate.Name = "txtExpiryDate"
        Me.txtExpiryDate.Size = New System.Drawing.Size(185, 33)
        Me.txtExpiryDate.TabIndex = 42
        '
        'txtCCV
        '
        Me.txtCCV.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.txtCCV.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.txtCCV.Location = New System.Drawing.Point(230, 310)
        Me.txtCCV.Name = "txtCCV"
        Me.txtCCV.Size = New System.Drawing.Size(94, 33)
        Me.txtCCV.TabIndex = 43
        '
        'btnPayment
        '
        Me.btnPayment.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnPayment.Enabled = False
        Me.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPayment.Font = New System.Drawing.Font("Segoe UI Semibold", 13.25!, System.Drawing.FontStyle.Bold)
        Me.btnPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPayment.IconChar = FontAwesome.Sharp.IconChar.CcVisa
        Me.btnPayment.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPayment.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPayment.IconSize = 34
        Me.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPayment.Location = New System.Drawing.Point(14, 391)
        Me.btnPayment.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(323, 38)
        Me.btnPayment.TabIndex = 35
        Me.btnPayment.Text = "Complete Payment"
        Me.btnPayment.UseVisualStyleBackColor = False
        '
        'pValidFirstName
        '
        Me.pValidFirstName.BackColor = System.Drawing.Color.YellowGreen
        Me.pValidFirstName.Location = New System.Drawing.Point(324, 90)
        Me.pValidFirstName.Name = "pValidFirstName"
        Me.pValidFirstName.Size = New System.Drawing.Size(10, 33)
        Me.pValidFirstName.TabIndex = 166
        '
        'pValidLastName
        '
        Me.pValidLastName.BackColor = System.Drawing.Color.YellowGreen
        Me.pValidLastName.Location = New System.Drawing.Point(324, 163)
        Me.pValidLastName.Name = "pValidLastName"
        Me.pValidLastName.Size = New System.Drawing.Size(10, 33)
        Me.pValidLastName.TabIndex = 167
        '
        'pValidCCNo
        '
        Me.pValidCCNo.BackColor = System.Drawing.Color.LightCoral
        Me.pValidCCNo.Location = New System.Drawing.Point(324, 238)
        Me.pValidCCNo.Name = "pValidCCNo"
        Me.pValidCCNo.Size = New System.Drawing.Size(10, 33)
        Me.pValidCCNo.TabIndex = 168
        '
        'pValidExpDate
        '
        Me.pValidExpDate.BackColor = System.Drawing.Color.LightCoral
        Me.pValidExpDate.Location = New System.Drawing.Point(196, 310)
        Me.pValidExpDate.Name = "pValidExpDate"
        Me.pValidExpDate.Size = New System.Drawing.Size(10, 33)
        Me.pValidExpDate.TabIndex = 169
        '
        'pValidCVV
        '
        Me.pValidCVV.BackColor = System.Drawing.Color.LightCoral
        Me.pValidCVV.Location = New System.Drawing.Point(324, 310)
        Me.pValidCVV.Name = "pValidCVV"
        Me.pValidCVV.Size = New System.Drawing.Size(10, 33)
        Me.pValidCVV.TabIndex = 170
        '
        'PaymentScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(351, 442)
        Me.ControlBox = False
        Me.Controls.Add(Me.pValidCVV)
        Me.Controls.Add(Me.pValidExpDate)
        Me.Controls.Add(Me.pValidCCNo)
        Me.Controls.Add(Me.pValidLastName)
        Me.Controls.Add(Me.pValidFirstName)
        Me.Controls.Add(Me.txtCCV)
        Me.Controls.Add(Me.txtExpiryDate)
        Me.Controls.Add(Me.txtCCNo)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.txtFirstname)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnPayment)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "PaymentScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PaymentScreen"
        Me.Panel1.ResumeLayout(False)
        CType(Me.btnExitButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnPayment As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExitButton As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents txtLastname As TextBox
    Friend WithEvents txtCCNo As TextBox
    Friend WithEvents txtExpiryDate As TextBox
    Friend WithEvents txtCCV As TextBox
    Friend WithEvents pValidFirstName As Panel
    Friend WithEvents pValidLastName As Panel
    Friend WithEvents pValidCCNo As Panel
    Friend WithEvents pValidExpDate As Panel
    Friend WithEvents pValidCVV As Panel
End Class
