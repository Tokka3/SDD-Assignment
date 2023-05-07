<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExitButton
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.btnExitButton = New FontAwesome.Sharp.IconPictureBox()
        CType(Me.btnExitButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExitButton
        '
        Me.btnExitButton.BackColor = System.Drawing.Color.Transparent
        Me.btnExitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExitButton.IconChar = FontAwesome.Sharp.IconChar.Xmark
        Me.btnExitButton.IconColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExitButton.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnExitButton.IconSize = 42
        Me.btnExitButton.Location = New System.Drawing.Point(3, 3)
        Me.btnExitButton.Name = "btnExitButton"
        Me.btnExitButton.Size = New System.Drawing.Size(43, 42)
        Me.btnExitButton.TabIndex = 0
        Me.btnExitButton.TabStop = False
        '
        'ExitButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.btnExitButton)
        Me.Name = "ExitButton"
        Me.Size = New System.Drawing.Size(43, 42)
        CType(Me.btnExitButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExitButton As FontAwesome.Sharp.IconPictureBox
End Class
