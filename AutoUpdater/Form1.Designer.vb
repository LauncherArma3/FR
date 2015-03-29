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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DownloadButton = New System.Windows.Forms.Button()
        Me.MyVersionL = New System.Windows.Forms.Label()
        Me.LatestVersionL = New System.Windows.Forms.Label()
        Me.loadingbar = New System.Windows.Forms.ProgressBar()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(206, 51)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Settings"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(22, 29)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(158, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Check for update on startup"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Launcher Version : " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Update Version : "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DownloadButton)
        Me.GroupBox2.Controls.Add(Me.MyVersionL)
        Me.GroupBox2.Controls.Add(Me.LatestVersionL)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 97)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(206, 78)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Version information"
        '
        'DownloadButton
        '
        Me.DownloadButton.Location = New System.Drawing.Point(22, 55)
        Me.DownloadButton.Name = "DownloadButton"
        Me.DownloadButton.Size = New System.Drawing.Size(134, 23)
        Me.DownloadButton.TabIndex = 4
        Me.DownloadButton.Text = "Download"
        Me.DownloadButton.UseVisualStyleBackColor = True
        Me.DownloadButton.Visible = False
        '
        'MyVersionL
        '
        Me.MyVersionL.AutoSize = True
        Me.MyVersionL.Location = New System.Drawing.Point(105, 38)
        Me.MyVersionL.Name = "MyVersionL"
        Me.MyVersionL.Size = New System.Drawing.Size(48, 13)
        Me.MyVersionL.TabIndex = 3
        Me.MyVersionL.Text = "LATEST"
        '
        'LatestVersionL
        '
        Me.LatestVersionL.AutoSize = True
        Me.LatestVersionL.Location = New System.Drawing.Point(114, 25)
        Me.LatestVersionL.Name = "LatestVersionL"
        Me.LatestVersionL.Size = New System.Drawing.Size(48, 13)
        Me.LatestVersionL.TabIndex = 2
        Me.LatestVersionL.Text = "LATEST"
        '
        'loadingbar
        '
        Me.loadingbar.Location = New System.Drawing.Point(12, 69)
        Me.loadingbar.Name = "loadingbar"
        Me.loadingbar.Size = New System.Drawing.Size(206, 23)
        Me.loadingbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.loadingbar.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(227, 197)
        Me.Controls.Add(Me.loadingbar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auto Updating"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents MyVersionL As System.Windows.Forms.Label
    Friend WithEvents LatestVersionL As System.Windows.Forms.Label
    Friend WithEvents DownloadButton As System.Windows.Forms.Button
    Friend WithEvents loadingbar As System.Windows.Forms.ProgressBar

End Class
