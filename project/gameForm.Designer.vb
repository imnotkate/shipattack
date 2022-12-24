<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class gameForm
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
        Me.namePnl = New System.Windows.Forms.Panel()
        Me.enterBtn = New System.Windows.Forms.Button()
        Me.txtbox = New System.Windows.Forms.RichTextBox()
        Me.enterLbl = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.returnBtn = New System.Windows.Forms.Button()
        Me.namePnl.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'namePnl
        '
        Me.namePnl.Controls.Add(Me.enterBtn)
        Me.namePnl.Controls.Add(Me.txtbox)
        Me.namePnl.Controls.Add(Me.enterLbl)
        Me.namePnl.Controls.Add(Me.PictureBox1)
        Me.namePnl.Location = New System.Drawing.Point(0, 0)
        Me.namePnl.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.namePnl.Name = "namePnl"
        Me.namePnl.Size = New System.Drawing.Size(1284, 669)
        Me.namePnl.TabIndex = 1
        '
        'enterBtn
        '
        Me.enterBtn.BackColor = System.Drawing.Color.Gray
        Me.enterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.enterBtn.Location = New System.Drawing.Point(852, 320)
        Me.enterBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.enterBtn.Name = "enterBtn"
        Me.enterBtn.Size = New System.Drawing.Size(198, 92)
        Me.enterBtn.TabIndex = 3
        Me.enterBtn.Text = "ENTER"
        Me.enterBtn.UseVisualStyleBackColor = False
        '
        'txtbox
        '
        Me.txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox.Location = New System.Drawing.Point(204, 331)
        Me.txtbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbox.Name = "txtbox"
        Me.txtbox.Size = New System.Drawing.Size(596, 66)
        Me.txtbox.TabIndex = 2
        Me.txtbox.Text = ""
        '
        'enterLbl
        '
        Me.enterLbl.AutoSize = True
        Me.enterLbl.Font = New System.Drawing.Font("Stencil", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enterLbl.ForeColor = System.Drawing.Color.Silver
        Me.enterLbl.Location = New System.Drawing.Point(195, 255)
        Me.enterLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.enterLbl.Name = "enterLbl"
        Me.enterLbl.Size = New System.Drawing.Size(435, 48)
        Me.enterLbl.TabIndex = 1
        Me.enterLbl.Text = "PLEASE ENTER NAME:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.project.My.Resources.Resources.LOGO
        Me.PictureBox1.Location = New System.Drawing.Point(132, 18)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(998, 168)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'returnBtn
        '
        Me.returnBtn.BackColor = System.Drawing.Color.Gray
        Me.returnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.returnBtn.Location = New System.Drawing.Point(18, 678)
        Me.returnBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.returnBtn.Name = "returnBtn"
        Me.returnBtn.Size = New System.Drawing.Size(195, 89)
        Me.returnBtn.TabIndex = 0
        Me.returnBtn.Text = "RETURN"
        Me.returnBtn.UseVisualStyleBackColor = False
        '
        'gameForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkBlue
        Me.ClientSize = New System.Drawing.Size(1284, 944)
        Me.Controls.Add(Me.namePnl)
        Me.Controls.Add(Me.returnBtn)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "gameForm"
        Me.Text = "game"
        Me.namePnl.ResumeLayout(False)
        Me.namePnl.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents returnBtn As Button
    Friend WithEvents namePnl As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents enterBtn As Button
    Friend WithEvents txtbox As RichTextBox
    Friend WithEvents enterLbl As Label
End Class
