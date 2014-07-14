<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Player
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Player))
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.lblRuleNameHeader = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblTickCount = New System.Windows.Forms.Label()
        Me.lblBarsPlayedTotalBig = New SESMetronomi.LabelBig()
        Me.lblTimeBig = New SESMetronomi.LabelBig()
        Me.lblTime = New SESMetronomi.LabelBig()
        Me.lblBarsPlayedCurrent = New SESMetronomi.LabelBig()
        Me.lblBarsPlayedTotal = New SESMetronomi.LabelBig()
        Me.lblDuration = New SESMetronomi.LabelBig()
        Me.lblSignature = New SESMetronomi.LabelBig()
        Me.lblTempo = New SESMetronomi.LabelBig()
        Me.lblName = New SESMetronomi.LabelBig()
        Me.lblBarsDebug = New System.Windows.Forms.Label()
        Me.lblRuleNODebug = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPlay
        '
        Me.btnPlay.Image = CType(resources.GetObject("btnPlay.Image"), System.Drawing.Image)
        Me.btnPlay.Location = New System.Drawing.Point(12, 12)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(50, 50)
        Me.btnPlay.TabIndex = 0
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnPause
        '
        Me.btnPause.Image = CType(resources.GetObject("btnPause.Image"), System.Drawing.Image)
        Me.btnPause.Location = New System.Drawing.Point(68, 12)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(50, 50)
        Me.btnPause.TabIndex = 1
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'lblRuleNameHeader
        '
        Me.lblRuleNameHeader.AutoSize = True
        Me.lblRuleNameHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!)
        Me.lblRuleNameHeader.Location = New System.Drawing.Point(181, 9)
        Me.lblRuleNameHeader.Name = "lblRuleNameHeader"
        Me.lblRuleNameHeader.Size = New System.Drawing.Size(297, 63)
        Me.lblRuleNameHeader.TabIndex = 2
        Me.lblRuleNameHeader.Text = "Rule Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Now playing:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "RuleName:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(6, 49)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tempo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(174, 16)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Time Signature:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(174, 49)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Duration:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTime)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblBarsPlayedCurrent)
        Me.GroupBox1.Controls.Add(Me.lblBarsPlayedTotal)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblDuration)
        Me.GroupBox1.Controls.Add(Me.lblSignature)
        Me.GroupBox1.Controls.Add(Me.lblTempo)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(803, 110)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Details"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(371, 66)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Time:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(371, 16)
        Me.Label7.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Bars played:"
        '
        'btnStop
        '
        Me.btnStop.Image = CType(resources.GetObject("btnStop.Image"), System.Drawing.Image)
        Me.btnStop.Location = New System.Drawing.Point(124, 12)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(50, 50)
        Me.btnStop.TabIndex = 11
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 201)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(228, 199)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(121, 201)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 14
        '
        'lblTickCount
        '
        Me.lblTickCount.AutoSize = True
        Me.lblTickCount.Location = New System.Drawing.Point(12, 268)
        Me.lblTickCount.Name = "lblTickCount"
        Me.lblTickCount.Size = New System.Drawing.Size(33, 13)
        Me.lblTickCount.TabIndex = 15
        Me.lblTickCount.Text = "Ticks"
        '
        'lblBarsPlayedTotalBig
        '
        Me.lblBarsPlayedTotalBig.AutoSize = True
        Me.lblBarsPlayedTotalBig.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblBarsPlayedTotalBig.Location = New System.Drawing.Point(698, 52)
        Me.lblBarsPlayedTotalBig.Name = "lblBarsPlayedTotalBig"
        Me.lblBarsPlayedTotalBig.Size = New System.Drawing.Size(40, 31)
        Me.lblBarsPlayedTotalBig.TabIndex = 10
        Me.lblBarsPlayedTotalBig.Text = "-/-"
        '
        'lblTimeBig
        '
        Me.lblTimeBig.AutoSize = True
        Me.lblTimeBig.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblTimeBig.Location = New System.Drawing.Point(698, 9)
        Me.lblTimeBig.Name = "lblTimeBig"
        Me.lblTimeBig.Size = New System.Drawing.Size(120, 31)
        Me.lblTimeBig.TabIndex = 9
        Me.lblTimeBig.Text = "00:00:00"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblTime.Location = New System.Drawing.Point(371, 79)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(64, 17)
        Me.lblTime.TabIndex = 21
        Me.lblTime.Text = "00:00:00"
        '
        'lblBarsPlayedCurrent
        '
        Me.lblBarsPlayedCurrent.AutoSize = True
        Me.lblBarsPlayedCurrent.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblBarsPlayedCurrent.Location = New System.Drawing.Point(371, 46)
        Me.lblBarsPlayedCurrent.Name = "lblBarsPlayedCurrent"
        Me.lblBarsPlayedCurrent.Size = New System.Drawing.Size(143, 17)
        Me.lblBarsPlayedCurrent.TabIndex = 19
        Me.lblBarsPlayedCurrent.Text = "<BarsPlayedCurrent>"
        '
        'lblBarsPlayedTotal
        '
        Me.lblBarsPlayedTotal.AutoSize = True
        Me.lblBarsPlayedTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblBarsPlayedTotal.Location = New System.Drawing.Point(371, 29)
        Me.lblBarsPlayedTotal.Name = "lblBarsPlayedTotal"
        Me.lblBarsPlayedTotal.Size = New System.Drawing.Size(128, 17)
        Me.lblBarsPlayedTotal.TabIndex = 17
        Me.lblBarsPlayedTotal.Text = "<BarsPlayedTotal>"
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblDuration.Location = New System.Drawing.Point(174, 62)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(107, 17)
        Me.lblDuration.TabIndex = 13
        Me.lblDuration.Text = "<RuleDuration>"
        '
        'lblSignature
        '
        Me.lblSignature.AutoSize = True
        Me.lblSignature.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblSignature.Location = New System.Drawing.Point(174, 29)
        Me.lblSignature.Name = "lblSignature"
        Me.lblSignature.Size = New System.Drawing.Size(114, 17)
        Me.lblSignature.TabIndex = 12
        Me.lblSignature.Text = "<RuleSignature>"
        '
        'lblTempo
        '
        Me.lblTempo.AutoSize = True
        Me.lblTempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblTempo.Location = New System.Drawing.Point(6, 62)
        Me.lblTempo.Name = "lblTempo"
        Me.lblTempo.Size = New System.Drawing.Size(97, 17)
        Me.lblTempo.TabIndex = 11
        Me.lblTempo.Text = "<RuleTempo>"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblName.Location = New System.Drawing.Point(6, 29)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(90, 17)
        Me.lblName.TabIndex = 10
        Me.lblName.Text = "<RuleName>"
        '
        'lblBarsDebug
        '
        Me.lblBarsDebug.AutoSize = True
        Me.lblBarsDebug.Location = New System.Drawing.Point(118, 268)
        Me.lblBarsDebug.Name = "lblBarsDebug"
        Me.lblBarsDebug.Size = New System.Drawing.Size(28, 13)
        Me.lblBarsDebug.TabIndex = 16
        Me.lblBarsDebug.Text = "Bars"
        '
        'lblRuleNODebug
        '
        Me.lblRuleNODebug.AutoSize = True
        Me.lblRuleNODebug.Location = New System.Drawing.Point(225, 268)
        Me.lblRuleNODebug.Name = "lblRuleNODebug"
        Me.lblRuleNODebug.Size = New System.Drawing.Size(29, 13)
        Me.lblRuleNODebug.TabIndex = 17
        Me.lblRuleNODebug.Text = "Rule"
        '
        'Player
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 290)
        Me.Controls.Add(Me.lblRuleNODebug)
        Me.Controls.Add(Me.lblBarsDebug)
        Me.Controls.Add(Me.lblTickCount)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.lblBarsPlayedTotalBig)
        Me.Controls.Add(Me.lblTimeBig)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblRuleNameHeader)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.btnPlay)
        Me.Name = "Player"
        Me.Text = "Player"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents btnPause As System.Windows.Forms.Button
    Friend WithEvents lblRuleNameHeader As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblDuration As SESMetronomi.LabelBig
    Friend WithEvents lblSignature As SESMetronomi.LabelBig
    Friend WithEvents lblTempo As SESMetronomi.LabelBig
    Friend WithEvents lblName As SESMetronomi.LabelBig
    Friend WithEvents lblTime As SESMetronomi.LabelBig
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblBarsPlayedCurrent As SESMetronomi.LabelBig
    Friend WithEvents lblBarsPlayedTotal As SESMetronomi.LabelBig
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblTimeBig As SESMetronomi.LabelBig
    Friend WithEvents lblBarsPlayedTotalBig As SESMetronomi.LabelBig
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents lblTickCount As System.Windows.Forms.Label
    Friend WithEvents lblBarsDebug As System.Windows.Forms.Label
    Friend WithEvents lblRuleNODebug As System.Windows.Forms.Label
End Class
