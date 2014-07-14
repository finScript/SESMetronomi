<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Setup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Setup))
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.RuleDetails1 = New System.Windows.Forms.GroupBox()
        Me.infoDuration = New System.Windows.Forms.Label()
        Me.infoTimeSign = New System.Windows.Forms.Label()
        Me.infoTempo = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.lblTimeSign = New System.Windows.Forms.Label()
        Me.lblTempo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.checkWholeSong = New System.Windows.Forms.CheckBox()
        Me.cmbTSMax = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbTSMin = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.txtTempo = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.liSong = New System.Windows.Forms.ToolStripMenuItem()
        Me.liRule = New System.Windows.Forms.ToolStripMenuItem()
        Me.liOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.liSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.liSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.liExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.RuleBox1 = New System.Windows.Forms.ListBox()
        Me.lblPlaylist = New System.Windows.Forms.Label()
        Me.txtPlaylist = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCompile = New System.Windows.Forms.Button()
        Me.RuleDetails1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(450, 527)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(427, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add Rule"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'RuleDetails1
        '
        Me.RuleDetails1.Controls.Add(Me.infoDuration)
        Me.RuleDetails1.Controls.Add(Me.infoTimeSign)
        Me.RuleDetails1.Controls.Add(Me.infoTempo)
        Me.RuleDetails1.Controls.Add(Me.lblName)
        Me.RuleDetails1.Controls.Add(Me.lblDuration)
        Me.RuleDetails1.Controls.Add(Me.lblTimeSign)
        Me.RuleDetails1.Controls.Add(Me.lblTempo)
        Me.RuleDetails1.Location = New System.Drawing.Point(12, 315)
        Me.RuleDetails1.Name = "RuleDetails1"
        Me.RuleDetails1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RuleDetails1.Size = New System.Drawing.Size(432, 206)
        Me.RuleDetails1.TabIndex = 2
        Me.RuleDetails1.TabStop = False
        Me.RuleDetails1.Text = "Rule Details"
        '
        'infoDuration
        '
        Me.infoDuration.AutoSize = True
        Me.infoDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.infoDuration.Location = New System.Drawing.Point(372, 92)
        Me.infoDuration.Margin = New System.Windows.Forms.Padding(5)
        Me.infoDuration.Name = "infoDuration"
        Me.infoDuration.Size = New System.Drawing.Size(43, 13)
        Me.infoDuration.TabIndex = 6
        Me.infoDuration.Text = "-- bars"
        '
        'infoTimeSign
        '
        Me.infoTimeSign.AutoSize = True
        Me.infoTimeSign.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.infoTimeSign.Location = New System.Drawing.Point(372, 69)
        Me.infoTimeSign.Margin = New System.Windows.Forms.Padding(5)
        Me.infoTimeSign.Name = "infoTimeSign"
        Me.infoTimeSign.Size = New System.Drawing.Size(21, 13)
        Me.infoTimeSign.TabIndex = 5
        Me.infoTimeSign.Text = "-/-"
        '
        'infoTempo
        '
        Me.infoTempo.AutoSize = True
        Me.infoTempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.infoTempo.Location = New System.Drawing.Point(372, 46)
        Me.infoTempo.Margin = New System.Windows.Forms.Padding(5)
        Me.infoTempo.Name = "infoTempo"
        Me.infoTempo.Size = New System.Drawing.Size(14, 13)
        Me.infoTempo.TabIndex = 4
        Me.infoTempo.Text = "0"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblName.Location = New System.Drawing.Point(6, 16)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(64, 25)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Name"
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Location = New System.Drawing.Point(8, 92)
        Me.lblDuration.Margin = New System.Windows.Forms.Padding(5)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(50, 13)
        Me.lblDuration.TabIndex = 2
        Me.lblDuration.Text = "Duration:"
        '
        'lblTimeSign
        '
        Me.lblTimeSign.AutoSize = True
        Me.lblTimeSign.Location = New System.Drawing.Point(8, 69)
        Me.lblTimeSign.Margin = New System.Windows.Forms.Padding(5)
        Me.lblTimeSign.Name = "lblTimeSign"
        Me.lblTimeSign.Size = New System.Drawing.Size(81, 13)
        Me.lblTimeSign.TabIndex = 1
        Me.lblTimeSign.Text = "Time Signature:"
        '
        'lblTempo
        '
        Me.lblTempo.AutoSize = True
        Me.lblTempo.Location = New System.Drawing.Point(8, 46)
        Me.lblTempo.Margin = New System.Windows.Forms.Padding(5)
        Me.lblTempo.Name = "lblTempo"
        Me.lblTempo.Size = New System.Drawing.Size(43, 13)
        Me.lblTempo.TabIndex = 0
        Me.lblTempo.Text = "Tempo:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.checkWholeSong)
        Me.GroupBox1.Controls.Add(Me.cmbTSMax)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbTSMin)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDuration)
        Me.GroupBox1.Controls.Add(Me.txtTempo)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(450, 315)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(427, 206)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = resources.GetString("GroupBox1.Text")
        '
        'checkWholeSong
        '
        Me.checkWholeSong.AutoSize = True
        Me.checkWholeSong.Location = New System.Drawing.Point(174, 115)
        Me.checkWholeSong.Name = "checkWholeSong"
        Me.checkWholeSong.Size = New System.Drawing.Size(85, 17)
        Me.checkWholeSong.TabIndex = 15
        Me.checkWholeSong.Text = "Whole Song"
        Me.checkWholeSong.UseVisualStyleBackColor = True
        '
        'cmbTSMax
        '
        Me.cmbTSMax.FormattingEnabled = True
        Me.cmbTSMax.Location = New System.Drawing.Point(308, 66)
        Me.cmbTSMax.Name = "cmbTSMax"
        Me.cmbTSMax.Size = New System.Drawing.Size(113, 21)
        Me.cmbTSMax.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(293, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "/"
        '
        'cmbTSMin
        '
        Me.cmbTSMin.FormattingEnabled = True
        Me.cmbTSMin.Location = New System.Drawing.Point(174, 66)
        Me.cmbTSMin.Name = "cmbTSMin"
        Me.cmbTSMin.Size = New System.Drawing.Size(113, 21)
        Me.cmbTSMin.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(394, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "bars"
        '
        'txtDuration
        '
        Me.txtDuration.Location = New System.Drawing.Point(174, 89)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(214, 20)
        Me.txtDuration.TabIndex = 10
        '
        'txtTempo
        '
        Me.txtTempo.Location = New System.Drawing.Point(174, 43)
        Me.txtTempo.Name = "txtTempo"
        Me.txtTempo.Size = New System.Drawing.Size(247, 20)
        Me.txtTempo.TabIndex = 8
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(174, 21)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(247, 20)
        Me.txtName.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 25)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 92)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Duration:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 69)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Time Signature:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 46)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Tempo:"
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(12, 527)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(432, 23)
        Me.btnRemove.TabIndex = 4
        Me.btnRemove.Text = "Remove Rule"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(891, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.liOpen, Me.liSave, Me.liSaveAs, Me.liExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.liSong, Me.liRule})
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'liSong
        '
        Me.liSong.Name = "liSong"
        Me.liSong.Size = New System.Drawing.Size(101, 22)
        Me.liSong.Text = "Song"
        '
        'liRule
        '
        Me.liRule.Name = "liRule"
        Me.liRule.Size = New System.Drawing.Size(101, 22)
        Me.liRule.Text = "Rule"
        '
        'liOpen
        '
        Me.liOpen.Name = "liOpen"
        Me.liOpen.Size = New System.Drawing.Size(152, 22)
        Me.liOpen.Text = "Open"
        '
        'liSave
        '
        Me.liSave.Name = "liSave"
        Me.liSave.Size = New System.Drawing.Size(152, 22)
        Me.liSave.Text = "Save"
        '
        'liSaveAs
        '
        Me.liSaveAs.Name = "liSaveAs"
        Me.liSaveAs.Size = New System.Drawing.Size(152, 22)
        Me.liSaveAs.Text = "Save As"
        '
        'liExit
        '
        Me.liExit.Name = "liExit"
        Me.liExit.Size = New System.Drawing.Size(152, 22)
        Me.liExit.Text = "Exit"
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.White
        Me.btnPlay.Image = CType(resources.GetObject("btnPlay.Image"), System.Drawing.Image)
        Me.btnPlay.Location = New System.Drawing.Point(12, 553)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(50, 149)
        Me.btnPlay.TabIndex = 6
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'RuleBox1
        '
        Me.RuleBox1.FormattingEnabled = True
        Me.RuleBox1.Location = New System.Drawing.Point(12, 27)
        Me.RuleBox1.Name = "RuleBox1"
        Me.RuleBox1.Size = New System.Drawing.Size(865, 277)
        Me.RuleBox1.TabIndex = 7
        '
        'lblPlaylist
        '
        Me.lblPlaylist.AutoSize = True
        Me.lblPlaylist.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblPlaylist.Location = New System.Drawing.Point(68, 553)
        Me.lblPlaylist.Name = "lblPlaylist"
        Me.lblPlaylist.Size = New System.Drawing.Size(56, 17)
        Me.lblPlaylist.TabIndex = 8
        Me.lblPlaylist.Text = "Playlist:"
        '
        'txtPlaylist
        '
        Me.txtPlaylist.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtPlaylist.Location = New System.Drawing.Point(71, 573)
        Me.txtPlaylist.Name = "txtPlaylist"
        Me.txtPlaylist.Size = New System.Drawing.Size(806, 129)
        Me.txtPlaylist.TabIndex = 9
        Me.txtPlaylist.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(534, 557)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(343, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Separate rules with ; (semicolon) Example: Rule01;Rule02"
        '
        'btnCompile
        '
        Me.btnCompile.Location = New System.Drawing.Point(11, 708)
        Me.btnCompile.Name = "btnCompile"
        Me.btnCompile.Size = New System.Drawing.Size(866, 23)
        Me.btnCompile.TabIndex = 15
        Me.btnCompile.Text = "Compile Playlist"
        Me.btnCompile.UseVisualStyleBackColor = True
        '
        'Setup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 738)
        Me.Controls.Add(Me.btnCompile)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPlaylist)
        Me.Controls.Add(Me.lblPlaylist)
        Me.Controls.Add(Me.RuleBox1)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.RuleDetails1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Setup"
        Me.Text = "SES Metronome"
        Me.RuleDetails1.ResumeLayout(False)
        Me.RuleDetails1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents RuleDetails1 As System.Windows.Forms.GroupBox
    Friend WithEvents infoDuration As System.Windows.Forms.Label
    Friend WithEvents infoTimeSign As System.Windows.Forms.Label
    Friend WithEvents infoTempo As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblDuration As System.Windows.Forms.Label
    Friend WithEvents lblTimeSign As System.Windows.Forms.Label
    Friend WithEvents lblTempo As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbTSMax As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbTSMin As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDuration As System.Windows.Forms.TextBox
    Friend WithEvents txtTempo As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents checkWholeSong As System.Windows.Forms.CheckBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents liSong As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents liRule As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents liSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents liSaveAs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents liExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents liOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents RuleBox1 As System.Windows.Forms.ListBox
    Friend WithEvents lblPlaylist As System.Windows.Forms.Label
    Friend WithEvents txtPlaylist As System.Windows.Forms.RichTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCompile As System.Windows.Forms.Button

End Class
