<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtAdfly = New System.Windows.Forms.TextBox()
        Me.btnGetLink = New System.Windows.Forms.Button()
        Me.cbOpen = New System.Windows.Forms.CheckBox()
        Me.cbClipboard = New System.Windows.Forms.CheckBox()
        Me.linkYouTube = New System.Windows.Forms.LinkLabel()
        Me.linkWastedWolf = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(19, 13)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(448, 163)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'txtAdfly
        '
        Me.txtAdfly.Location = New System.Drawing.Point(19, 175)
        Me.txtAdfly.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtAdfly.Name = "txtAdfly"
        Me.txtAdfly.Size = New System.Drawing.Size(332, 25)
        Me.txtAdfly.TabIndex = 1
        Me.txtAdfly.Text = "Paste AdFly Link Here..."
        '
        'btnGetLink
        '
        Me.btnGetLink.Location = New System.Drawing.Point(357, 172)
        Me.btnGetLink.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnGetLink.Name = "btnGetLink"
        Me.btnGetLink.Size = New System.Drawing.Size(110, 30)
        Me.btnGetLink.TabIndex = 2
        Me.btnGetLink.Text = "GET LINK"
        Me.btnGetLink.UseVisualStyleBackColor = True
        '
        'cbOpen
        '
        Me.cbOpen.AutoSize = True
        Me.cbOpen.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.cbOpen.Location = New System.Drawing.Point(301, 208)
        Me.cbOpen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbOpen.Name = "cbOpen"
        Me.cbOpen.Size = New System.Drawing.Size(166, 21)
        Me.cbOpen.TabIndex = 3
        Me.cbOpen.Text = "O P E N   W E B P A G E"
        Me.cbOpen.UseVisualStyleBackColor = True
        '
        'cbClipboard
        '
        Me.cbClipboard.AutoSize = True
        Me.cbClipboard.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.cbClipboard.Location = New System.Drawing.Point(19, 208)
        Me.cbClipboard.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cbClipboard.Name = "cbClipboard"
        Me.cbClipboard.Size = New System.Drawing.Size(214, 21)
        Me.cbClipboard.TabIndex = 4
        Me.cbClipboard.Text = "C O P Y   T O   C L I P B O A R D"
        Me.cbClipboard.UseVisualStyleBackColor = True
        '
        'linkYouTube
        '
        Me.linkYouTube.AutoSize = True
        Me.linkYouTube.LinkColor = System.Drawing.Color.Black
        Me.linkYouTube.Location = New System.Drawing.Point(16, 244)
        Me.linkYouTube.Name = "linkYouTube"
        Me.linkYouTube.Size = New System.Drawing.Size(254, 17)
        Me.linkYouTube.TabIndex = 5
        Me.linkYouTube.TabStop = True
        Me.linkYouTube.Text = "Y O U T U B E . C O M / A R C A N E C F G"
        '
        'linkWastedWolf
        '
        Me.linkWastedWolf.AutoSize = True
        Me.linkWastedWolf.LinkColor = System.Drawing.Color.Black
        Me.linkWastedWolf.Location = New System.Drawing.Point(339, 244)
        Me.linkWastedWolf.Name = "linkWastedWolf"
        Me.linkWastedWolf.Size = New System.Drawing.Size(128, 17)
        Me.linkWastedWolf.TabIndex = 6
        Me.linkWastedWolf.TabStop = True
        Me.linkWastedWolf.Text = "W A S T E D W O L F"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(487, 270)
        Me.Controls.Add(Me.linkWastedWolf)
        Me.Controls.Add(Me.linkYouTube)
        Me.Controls.Add(Me.cbClipboard)
        Me.Controls.Add(Me.cbOpen)
        Me.Controls.Add(Me.btnGetLink)
        Me.Controls.Add(Me.txtAdfly)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Arcanecfg SkipFly"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtAdfly As System.Windows.Forms.TextBox
    Friend WithEvents btnGetLink As System.Windows.Forms.Button
    Friend WithEvents cbOpen As System.Windows.Forms.CheckBox
    Friend WithEvents cbClipboard As System.Windows.Forms.CheckBox
    Friend WithEvents linkYouTube As System.Windows.Forms.LinkLabel
    Friend WithEvents linkWastedWolf As System.Windows.Forms.LinkLabel

End Class
