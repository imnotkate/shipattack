<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuForm
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
        Me.startBtn = New System.Windows.Forms.Button()
        Me.leaderboardBtn = New System.Windows.Forms.Button()
        Me.instructionsBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'startBtn
        '
        Me.startBtn.BackColor = System.Drawing.Color.Gray
        Me.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.startBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startBtn.Location = New System.Drawing.Point(284, 152)
        Me.startBtn.Name = "startBtn"
        Me.startBtn.Size = New System.Drawing.Size(268, 95)
        Me.startBtn.TabIndex = 1
        Me.startBtn.Text = "START GAME"
        Me.startBtn.UseVisualStyleBackColor = False
        '
        'leaderboardBtn
        '
        Me.leaderboardBtn.BackColor = System.Drawing.Color.Gray
        Me.leaderboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.leaderboardBtn.Location = New System.Drawing.Point(284, 265)
        Me.leaderboardBtn.Name = "leaderboardBtn"
        Me.leaderboardBtn.Size = New System.Drawing.Size(268, 95)
        Me.leaderboardBtn.TabIndex = 2
        Me.leaderboardBtn.Text = "LEADERBOARD"
        Me.leaderboardBtn.UseVisualStyleBackColor = False
        '
        'instructionsBtn
        '
        Me.instructionsBtn.BackColor = System.Drawing.Color.Gray
        Me.instructionsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.instructionsBtn.Location = New System.Drawing.Point(284, 380)
        Me.instructionsBtn.Name = "instructionsBtn"
        Me.instructionsBtn.Size = New System.Drawing.Size(268, 95)
        Me.instructionsBtn.TabIndex = 3
        Me.instructionsBtn.Text = "INSTRUCTIONS"
        Me.instructionsBtn.UseVisualStyleBackColor = False
        '
        'exitBtn
        '
        Me.exitBtn.BackColor = System.Drawing.Color.Gray
        Me.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.exitBtn.Location = New System.Drawing.Point(686, 419)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(158, 80)
        Me.exitBtn.TabIndex = 4
        Me.exitBtn.Text = "EXIT"
        Me.exitBtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.project.My.Resources.Resources.LOGO
        Me.PictureBox1.Location = New System.Drawing.Point(88, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(665, 109)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'menuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkBlue
        Me.ClientSize = New System.Drawing.Size(856, 511)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.instructionsBtn)
        Me.Controls.Add(Me.leaderboardBtn)
        Me.Controls.Add(Me.startBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "menuForm"
        Me.Text = "menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents startBtn As Button
    Friend WithEvents leaderboardBtn As Button
    Friend WithEvents instructionsBtn As Button
    Friend WithEvents exitBtn As Button
End Class
