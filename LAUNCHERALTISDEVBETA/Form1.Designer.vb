<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PositronButton4 = New AltisDEV.PositronButton()
        Me.PositronButton3 = New AltisDEV.PositronButton()
        Me.PositronButton2 = New AltisDEV.PositronButton()
        Me.PositronGroupBox2 = New AltisDEV.PositronGroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.PositronGroupBox1 = New AltisDEV.PositronGroupBox()
        Me.PositronCheckBox1 = New AltisDEV.PositronCheckBox()
        Me.PositronLabel2 = New AltisDEV.PositronLabel()
        Me.PositronLabel1 = New AltisDEV.PositronLabel()
        Me.PositronTextBox2 = New AltisDEV.PositronTextBox()
        Me.PositronTextBox1 = New AltisDEV.PositronTextBox()
        Me.PositronButton1 = New AltisDEV.PositronButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.DownloadUpdateLauncher = New System.ComponentModel.BackgroundWorker()
        Me.updatelauncher = New System.ComponentModel.BackgroundWorker()
        Me.Form1Load = New System.ComponentModel.BackgroundWorker()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PositronGroupBox2.SuspendLayout()
        Me.PositronGroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.AltisDEV.My.Resources.Resources.nitrado
        Me.PictureBox1.Location = New System.Drawing.Point(648, 379)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(639, 375)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Partenaire"
        '
        'PositronButton4
        '
        Me.PositronButton4.Customization = "3Nzc/8jIyP9kZGT/lpaW/8jIyP/S0tL/"
        Me.PositronButton4.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.PositronButton4.Image = Nothing
        Me.PositronButton4.Location = New System.Drawing.Point(539, 214)
        Me.PositronButton4.Name = "PositronButton4"
        Me.PositronButton4.NoRounding = False
        Me.PositronButton4.Size = New System.Drawing.Size(100, 30)
        Me.PositronButton4.TabIndex = 6
        Me.PositronButton4.Text = "S'enregistrer"
        Me.PositronButton4.Transparent = False
        '
        'PositronButton3
        '
        Me.PositronButton3.Customization = "3Nzc/8jIyP9kZGT/lpaW/8jIyP/S0tL/"
        Me.PositronButton3.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.PositronButton3.Image = Nothing
        Me.PositronButton3.Location = New System.Drawing.Point(202, 214)
        Me.PositronButton3.Name = "PositronButton3"
        Me.PositronButton3.NoRounding = False
        Me.PositronButton3.Size = New System.Drawing.Size(142, 30)
        Me.PositronButton3.TabIndex = 5
        Me.PositronButton3.Text = "Mot de passe oublié?"
        Me.PositronButton3.Transparent = False
        '
        'PositronButton2
        '
        Me.PositronButton2.Customization = "3Nzc/8jIyP9kZGT/lpaW/8jIyP/S0tL/"
        Me.PositronButton2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.PositronButton2.Image = Nothing
        Me.PositronButton2.Location = New System.Drawing.Point(85, 214)
        Me.PositronButton2.Name = "PositronButton2"
        Me.PositronButton2.NoRounding = False
        Me.PositronButton2.Size = New System.Drawing.Size(100, 30)
        Me.PositronButton2.TabIndex = 4
        Me.PositronButton2.Text = "Entrer"
        Me.PositronButton2.Transparent = False
        '
        'PositronGroupBox2
        '
        Me.PositronGroupBox2.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.PositronGroupBox2.Controls.Add(Me.ListView1)
        Me.PositronGroupBox2.Customization = "lpaW/2RkZP/Q0ND/yMjI/w=="
        Me.PositronGroupBox2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.PositronGroupBox2.Image = Nothing
        Me.PositronGroupBox2.Location = New System.Drawing.Point(85, 250)
        Me.PositronGroupBox2.Movable = True
        Me.PositronGroupBox2.Name = "PositronGroupBox2"
        Me.PositronGroupBox2.NoRounding = False
        Me.PositronGroupBox2.Sizable = True
        Me.PositronGroupBox2.Size = New System.Drawing.Size(554, 167)
        Me.PositronGroupBox2.SmartBounds = True
        Me.PositronGroupBox2.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.PositronGroupBox2.TabIndex = 2
        Me.PositronGroupBox2.Text = "Annonces du serveur"
        Me.PositronGroupBox2.TransparencyKey = System.Drawing.Color.Empty
        Me.PositronGroupBox2.Transparent = False
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Location = New System.Drawing.Point(8, 25)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(535, 134)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'PositronGroupBox1
        '
        Me.PositronGroupBox1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.PositronGroupBox1.Controls.Add(Me.PositronCheckBox1)
        Me.PositronGroupBox1.Controls.Add(Me.PositronLabel2)
        Me.PositronGroupBox1.Controls.Add(Me.PositronLabel1)
        Me.PositronGroupBox1.Controls.Add(Me.PositronTextBox2)
        Me.PositronGroupBox1.Controls.Add(Me.PositronTextBox1)
        Me.PositronGroupBox1.Customization = "lpaW/2RkZP/Q0ND/yMjI/w=="
        Me.PositronGroupBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.PositronGroupBox1.Image = Nothing
        Me.PositronGroupBox1.Location = New System.Drawing.Point(85, 98)
        Me.PositronGroupBox1.Movable = True
        Me.PositronGroupBox1.Name = "PositronGroupBox1"
        Me.PositronGroupBox1.NoRounding = False
        Me.PositronGroupBox1.Sizable = True
        Me.PositronGroupBox1.Size = New System.Drawing.Size(554, 110)
        Me.PositronGroupBox1.SmartBounds = True
        Me.PositronGroupBox1.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.PositronGroupBox1.TabIndex = 1
        Me.PositronGroupBox1.Text = "Connexion Launcher"
        Me.PositronGroupBox1.TransparencyKey = System.Drawing.Color.Empty
        Me.PositronGroupBox1.Transparent = False
        '
        'PositronCheckBox1
        '
        Me.PositronCheckBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.PositronCheckBox1.Checked = False
        Me.PositronCheckBox1.Customization = "8PDw/2RkZP+vr6//yMjI/5aWlv8="
        Me.PositronCheckBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.PositronCheckBox1.Image = Nothing
        Me.PositronCheckBox1.Location = New System.Drawing.Point(100, 85)
        Me.PositronCheckBox1.Name = "PositronCheckBox1"
        Me.PositronCheckBox1.NoRounding = False
        Me.PositronCheckBox1.Size = New System.Drawing.Size(159, 22)
        Me.PositronCheckBox1.TabIndex = 4
        Me.PositronCheckBox1.Text = "Se souvenir de moi"
        Me.PositronCheckBox1.Transparent = False
        '
        'PositronLabel2
        '
        Me.PositronLabel2.AutoSize = True
        Me.PositronLabel2.BackColor = System.Drawing.Color.Transparent
        Me.PositronLabel2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.PositronLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.PositronLabel2.Location = New System.Drawing.Point(10, 66)
        Me.PositronLabel2.Name = "PositronLabel2"
        Me.PositronLabel2.Size = New System.Drawing.Size(87, 13)
        Me.PositronLabel2.TabIndex = 3
        Me.PositronLabel2.Text = "Mot de passe:"
        '
        'PositronLabel1
        '
        Me.PositronLabel1.AutoSize = True
        Me.PositronLabel1.BackColor = System.Drawing.Color.Transparent
        Me.PositronLabel1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.PositronLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.PositronLabel1.Location = New System.Drawing.Point(28, 33)
        Me.PositronLabel1.Name = "PositronLabel1"
        Me.PositronLabel1.Size = New System.Drawing.Size(69, 13)
        Me.PositronLabel1.TabIndex = 2
        Me.PositronLabel1.Text = "Utilisateur:"
        '
        'PositronTextBox2
        '
        Me.PositronTextBox2.Customization = "0tLS/8jIyP+Wlpb/"
        Me.PositronTextBox2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.PositronTextBox2.Image = Nothing
        Me.PositronTextBox2.Location = New System.Drawing.Point(100, 59)
        Me.PositronTextBox2.MaxLength = 32767
        Me.PositronTextBox2.Multiline = False
        Me.PositronTextBox2.Name = "PositronTextBox2"
        Me.PositronTextBox2.NoRounding = False
        Me.PositronTextBox2.ReadOnly = False
        Me.PositronTextBox2.Size = New System.Drawing.Size(443, 24)
        Me.PositronTextBox2.TabIndex = 1
        Me.PositronTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.PositronTextBox2.Transparent = False
        Me.PositronTextBox2.UseSystemPasswordChar = True
        '
        'PositronTextBox1
        '
        Me.PositronTextBox1.Customization = "0tLS/8jIyP+Wlpb/"
        Me.PositronTextBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.PositronTextBox1.Image = Nothing
        Me.PositronTextBox1.Location = New System.Drawing.Point(100, 29)
        Me.PositronTextBox1.MaxLength = 32767
        Me.PositronTextBox1.Multiline = False
        Me.PositronTextBox1.Name = "PositronTextBox1"
        Me.PositronTextBox1.NoRounding = False
        Me.PositronTextBox1.ReadOnly = False
        Me.PositronTextBox1.Size = New System.Drawing.Size(443, 24)
        Me.PositronTextBox1.TabIndex = 0
        Me.PositronTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.PositronTextBox1.Transparent = False
        Me.PositronTextBox1.UseSystemPasswordChar = False
        '
        'PositronButton1
        '
        Me.PositronButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PositronButton1.Customization = "3Nzc/8jIyP9kZGT/lpaW/8jIyP/S0tL/"
        Me.PositronButton1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.PositronButton1.Image = Nothing
        Me.PositronButton1.Location = New System.Drawing.Point(678, 4)
        Me.PositronButton1.Name = "PositronButton1"
        Me.PositronButton1.NoRounding = False
        Me.PositronButton1.Size = New System.Drawing.Size(18, 20)
        Me.PositronButton1.TabIndex = 0
        Me.PositronButton1.Text = "X"
        Me.PositronButton1.Transparent = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.AltisDEV.My.Resources.Resources.facebook_active
        Me.PictureBox2.Location = New System.Drawing.Point(664, 98)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.AltisDEV.My.Resources.Resources.twitter_active
        Me.PictureBox3.Location = New System.Drawing.Point(664, 139)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = Global.AltisDEV.My.Resources.Resources.youtube_active
        Me.PictureBox4.Location = New System.Drawing.Point(664, 180)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = Global.AltisDEV.My.Resources.Resources.blog_active
        Me.PictureBox5.Location = New System.Drawing.Point(664, 218)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 12
        Me.PictureBox5.TabStop = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipText = "Bem vindo!"
        Me.NotifyIcon1.BalloonTipTitle = "Launcher Arma 3"
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Launcher"
        Me.NotifyIcon1.Visible = True
        '
        'DownloadUpdateLauncher
        '
        '
        'updatelauncher
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(702, 429)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PositronButton4)
        Me.Controls.Add(Me.PositronButton3)
        Me.Controls.Add(Me.PositronButton2)
        Me.Controls.Add(Me.PositronGroupBox2)
        Me.Controls.Add(Me.PositronGroupBox1)
        Me.Controls.Add(Me.PositronButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Launcher"
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PositronGroupBox2.ResumeLayout(False)
        Me.PositronGroupBox1.ResumeLayout(False)
        Me.PositronGroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PositronButton1 As AltisDEV.PositronButton
    Friend WithEvents PositronGroupBox1 As AltisDEV.PositronGroupBox
    Friend WithEvents PositronGroupBox2 As AltisDEV.PositronGroupBox
    Friend WithEvents PositronLabel2 As AltisDEV.PositronLabel
    Friend WithEvents PositronLabel1 As AltisDEV.PositronLabel
    Friend WithEvents PositronTextBox2 As AltisDEV.PositronTextBox
    Friend WithEvents PositronTextBox1 As AltisDEV.PositronTextBox
    Friend WithEvents PositronButton2 As AltisDEV.PositronButton
    Friend WithEvents PositronButton3 As AltisDEV.PositronButton
    Friend WithEvents PositronButton4 As AltisDEV.PositronButton
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PositronCheckBox1 As AltisDEV.PositronCheckBox
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents DownloadUpdateLauncher As System.ComponentModel.BackgroundWorker
    Friend WithEvents updatelauncher As System.ComponentModel.BackgroundWorker
    Friend WithEvents Form1Load As System.ComponentModel.BackgroundWorker

End Class
