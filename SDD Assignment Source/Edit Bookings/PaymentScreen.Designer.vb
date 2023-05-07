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
        Me.components = New System.ComponentModel.Container()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExitButton = New FontAwesome.Sharp.IconPictureBox()
        Me.Guna2GradientPanel1.SuspendLayout()
        CType(Me.btnExitButton, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.AutoRoundedCorners = True
        Me.Guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel1.Controls.Add(Me.btnExitButton)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2GradientPanel1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2GradientPanel1.CustomizableEdges.BottomLeft = False
        Me.Guna2GradientPanel1.CustomizableEdges.BottomRight = False
        Me.Guna2GradientPanel1.CustomizableEdges.TopLeft = False
        Me.Guna2GradientPanel1.CustomizableEdges.TopRight = False
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel1.FillColor = System.Drawing.SystemColors.Highlight
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.RoyalBlue
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(468, 59)
        Me.Guna2GradientPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(16, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(436, 48)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Payment"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExitButton
        '
        Me.btnExitButton.BackColor = System.Drawing.Color.Transparent
        Me.btnExitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExitButton.IconChar = FontAwesome.Sharp.IconChar.Xmark
        Me.btnExitButton.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExitButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnExitButton.IconSize = 36
        Me.btnExitButton.Location = New System.Drawing.Point(422, 15)
        Me.btnExitButton.Name = "btnExitButton"
        Me.btnExitButton.Size = New System.Drawing.Size(43, 42)
        Me.btnExitButton.TabIndex = 1
        Me.btnExitButton.TabStop = False
        '
        'PaymentScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(468, 593)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "PaymentScreen"
        Me.Text = "PaymentScreen"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        CType(Me.btnExitButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExitButton As FontAwesome.Sharp.IconPictureBox
End Class
