﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditBookingTutorial
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEditTutorial = New FontAwesome.Sharp.IconButton()
        Me.btnDeleteTutorial = New FontAwesome.Sharp.IconButton()
        Me.btnTryDelete = New FontAwesome.Sharp.IconButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBack = New FontAwesome.Sharp.IconPictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(69, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(918, 78)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Edit/Delete Existing Bookings Tutorial"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnTryDelete)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(964, 510)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Open Sans", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(656, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(277, 264)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Deleting an existing booking is very quick and straight forward. Simply press the" &
    " red ""Delete"" button, and if you are sure you want to delete the record, confirm" &
    " the request on the warning box."
        '
        'btnEditTutorial
        '
        Me.btnEditTutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditTutorial.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditTutorial.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnEditTutorial.IconColor = System.Drawing.Color.Black
        Me.btnEditTutorial.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEditTutorial.Location = New System.Drawing.Point(515, 85)
        Me.btnEditTutorial.Name = "btnEditTutorial"
        Me.btnEditTutorial.Size = New System.Drawing.Size(482, 37)
        Me.btnEditTutorial.TabIndex = 19
        Me.btnEditTutorial.Text = "How to edit a booking"
        Me.btnEditTutorial.UseVisualStyleBackColor = True
        '
        'btnDeleteTutorial
        '
        Me.btnDeleteTutorial.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnDeleteTutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteTutorial.Font = New System.Drawing.Font("Segoe UI Semibold", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteTutorial.ForeColor = System.Drawing.Color.White
        Me.btnDeleteTutorial.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnDeleteTutorial.IconColor = System.Drawing.Color.Black
        Me.btnDeleteTutorial.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnDeleteTutorial.Location = New System.Drawing.Point(33, 85)
        Me.btnDeleteTutorial.Name = "btnDeleteTutorial"
        Me.btnDeleteTutorial.Size = New System.Drawing.Size(482, 37)
        Me.btnDeleteTutorial.TabIndex = 18
        Me.btnDeleteTutorial.Text = "How to delete a booking"
        Me.btnDeleteTutorial.UseVisualStyleBackColor = False
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
        Me.btnTryDelete.Location = New System.Drawing.Point(641, 459)
        Me.btnTryDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTryDelete.Name = "btnTryDelete"
        Me.btnTryDelete.Size = New System.Drawing.Size(313, 38)
        Me.btnTryDelete.TabIndex = 36
        Me.btnTryDelete.Text = "Try Now"
        Me.btnTryDelete.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SDD_Assignment_Source.My.Resources.Resources.EditViewBookings
        Me.PictureBox1.Location = New System.Drawing.Point(16, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(618, 469)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
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
        Me.btnBack.Location = New System.Drawing.Point(17, 15)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(46, 41)
        Me.btnBack.TabIndex = 15
        Me.btnBack.TabStop = False
        '
        'EditBookingTutorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1021, 653)
        Me.Controls.Add(Me.btnEditTutorial)
        Me.Controls.Add(Me.btnDeleteTutorial)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "EditBookingTutorial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditBookingTutorial"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnDeleteTutorial As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEditTutorial As FontAwesome.Sharp.IconButton
    Friend WithEvents btnTryDelete As FontAwesome.Sharp.IconButton
End Class