Imports System.IO
Imports System.Xml

Public Class Setup

    'File managing
    Dim saved As Boolean = False
    Dim savedAs As Boolean = False
    Dim savedIn As String = ""
    Dim fileXML As String


    'lists
    Public rules As New List(Of List(Of String))
    Dim playlist As New List(Of List(Of String))

    'conditions
    Dim compiled As Boolean = False

    Function GetRules()

        Return rules

    End Function


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load



        For i = 0 To 100

            cmbTSMin.Items.Add(i)

        Next

        cmbTSMin.Text = 4

        For i = 0 To 128

            If (i = 1 Or i = 2 Or i = 4 Or i = 8 Or i = 16 Or i = 32 Or i = 64 Or i = 128) Then
                cmbTSMax.Items.Add(i)
            End If

        Next

        cmbTSMax.Text = 4

        txtName.Text = "NewRule"
        txtTempo.Text = 120
        txtDuration.Text = 4

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles checkWholeSong.CheckedChanged

        txtDuration.Enabled = Not checkWholeSong.Checked


    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click

        Dim n As String = txtName.Text

        For i = 0 To rules.Count - 1
            If (rules(i)(0) = n) Then
                MessageBox.Show("There is already a rule named '" & n & "'! Please remove it or rename this rule to continue!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
        Next

        If (n.Contains(";")) Then
            MessageBox.Show("Semicolon (;) is a reserved key character! You cannot use it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        Dim tempo As Integer = Integer.Parse(txtTempo.Text)
        Dim signature As String = cmbTSMin.Text & "/" & cmbTSMax.Text
        Dim duration As Integer = Integer.Parse(txtDuration.Text)

        Dim r As New List(Of String)
        r.Add(n)

        RuleBox1.Items.Add(n)

        r.Add(tempo)
        r.Add(signature)
        r.Add(duration)

        rules.Add(r)

    End Sub

    Private Sub liExit_Click(sender As System.Object, e As System.EventArgs) Handles liExit.Click

        If (saved) Then

            Dim res As DialogResult = MessageBox.Show("Exit?", "Exit?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If (res = Windows.Forms.DialogResult.OK) Then

                Application.Exit()

            End If


        Else


            Dim res As DialogResult = MessageBox.Show("You haven't saved your latest changes! Do you want to save them before exiting?", "Exit?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)

            If (res = Windows.Forms.DialogResult.Yes) Then


                Dim writer As StreamWriter

                If (savedAs) Then

                    writer = New StreamWriter(savedIn)
                    writer.WriteLine(fileXML)
                    writer.Close()

                Else

                    If (SaveAs()) Then
                        Application.Exit()
                    End If


                End If


            ElseIf (res = Windows.Forms.DialogResult.No) Then

                Application.Exit()

            End If

        End If

    End Sub






    Private Sub liSaveAs_Click(sender As System.Object, e As System.EventArgs) Handles liSaveAs.Click

        SaveAs()

    End Sub

    Private Sub liSave_Click(sender As System.Object, e As System.EventArgs) Handles liSave.Click

        Save()

    End Sub


    '======================================================================

    Public Function SaveAs()

        Dim saver As New SaveFileDialog
        saver.Title = "Save As..."
        If (saver.ShowDialog) Then


            Try

                assembleXML(saver.FileName)
                Return True

            Catch ex As Exception

                MsgBox(ex.ToString)
                Return False

            End Try

        Else
            Return False
        End If

    End Function

    Public Sub Save()

        If (Not savedAs) Then
            SaveAs()
        Else

            assembleXML(savedIn)
           

        End If

    End Sub


    '======================================================================

    Public Sub assembleXML(ByVal path As String)

        Dim rule(rules.Count - 1) As MetronomeRule

        For i = 0 To rules.Count - 1

            rule(i) = New MetronomeRule(i, rules(i)(0), rules(i)(1), rules(i)(2), rules(i)(3))

        Next

        Dim settings As New XmlWriterSettings()
        settings.Indent = True

        Using writer As XmlWriter = XmlWriter.Create(path)

            writer.WriteStartDocument()
            writer.WriteStartElement("rules")
            writer.WriteAttributeString("playlist", txtPlaylist.Text)

            For Each r As MetronomeRule In rule

                writer.WriteStartElement("rule")
                writer.WriteAttributeString("index", r._index)
                writer.WriteAttributeString("name", r._name)
                writer.WriteAttributeString("tempo", r._tempo)
                writer.WriteAttributeString("timesignature", r._timeSignature)
                writer.WriteAttributeString("duration", r._duration)
                writer.WriteEndElement()


            Next


            writer.WriteEndElement()

        End Using


    End Sub



    Private Sub RuleBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)




    End Sub

    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click

        Dim index As Integer = RuleBox1.SelectedIndex

        If (index >= 0) Then
            Dim searchFor As String = RuleBox1.Items(index)

            For i = 0 To rules.Count - 1

                If (rules(i)(0) = searchFor) Then

                    rules.Remove(rules(i))
                    RuleBox1.Items.Remove(searchFor)
                    RuleBox1.Refresh()

                End If

            Next

        End If

        Compile(True)

    End Sub



    Private Sub RuleBox1_SelectedIndexChanged_1(sender As System.Object, e As System.EventArgs) Handles RuleBox1.SelectedIndexChanged

        If (RuleBox1.SelectedIndex >= 0) Then
            Dim index As Integer = RuleBox1.SelectedIndex
            Dim searchFor As String = RuleBox1.Items(index)

            For i = 0 To rules.Count - 1

                If (rules(i)(0) = searchFor) Then

                    lblName.Text = rules(i)(0)
                    infoTempo.Text = rules(i)(1)
                    infoTimeSign.Text = rules(i)(2)
                    infoDuration.Text = rules(i)(3) & " bars"

                End If

            Next
        End If

    End Sub

    Private Sub RuleBox1_DoubleClick(sender As System.Object, e As System.EventArgs) Handles RuleBox1.DoubleClick

        If (RuleBox1.SelectedIndex >= 0) Then
            Dim index As Integer = RuleBox1.SelectedIndex
            Dim searchFor As String = RuleBox1.Items(index)

            For i = 0 To rules.Count - 1

                If (rules(i)(0) = searchFor) Then

                    txtPlaylist.Text += searchFor & ";"

                End If

            Next
        End If

    End Sub

    Private Sub btnCompile_Click(sender As System.Object, e As System.EventArgs) Handles btnCompile.Click



        Compile(False)




    End Sub


    Public Sub Compile(ByVal silent As Boolean)

        Dim errors As Integer = 0

        If (rules.Count > 0) Then

            If (txtPlaylist.TextLength > 0) Then
                Dim txtCompile As String = txtPlaylist.Text
                txtPlaylist.Text = ""

                If (txtCompile.Contains(";")) Then

                    Dim givenRules As String() = txtCompile.Split(";")
                    Dim requiredRules As New List(Of String)

                    For x = 0 To rules.Count - 1

                        requiredRules.Add(rules(x)(0))

                    Next

                    For Each s As String In givenRules

                        If (s.Length = 0) Then
                            Continue For
                        End If

                        If (requiredRules.Contains(s)) Then

                            'MsgBox(s & " passed")
                            txtPlaylist.Text += s & ";"

                        Else

                            'MsgBox(s & " did not pass")
                            errors += 1


                        End If

                    Next

                    btnCompile.Enabled = False
                    compiled = True

                    If (Not silent) Then
                        MessageBox.Show("Compilation was successfull! " & errors & " invalid rule(s) were removed.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If


                Else



                    For i = 0 To rules.Count - 1

                        If (rules(i)(0).Contains(txtCompile) = False) Then

                            'MessageBox.Show(txtCompile & " was not wound from the rules list.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            errors += 1
                        Else
                            'MsgBox("Compile successfull!")
                        End If


                    Next

                    btnCompile.Enabled = False
                    compiled = True
                    If (Not silent) Then
                        MessageBox.Show("Compilation was successfull! " & errors & " invalid rule(s) were removed.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If


                End If
            Else

                MsgBox("Playlist is not written")

            End If


        Else
            txtPlaylist.Text = ""
        End If


    End Sub


    Private Sub txtPlaylist_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPlaylist.TextChanged

        btnCompile.Enabled = True
        compiled = False


    End Sub

    Private Sub btnPause_Click(sender As System.Object, e As System.EventArgs)



    End Sub

    Private Sub btnPlay_Click(sender As System.Object, e As System.EventArgs) Handles btnPlay.Click

        If (compiled) Then
            MsgBox("Ready to play!")

            Player.Show()



        End If

    End Sub

    Private Sub liOpen_Click(sender As System.Object, e As System.EventArgs) Handles liOpen.Click

        Dim ofd As New OpenFileDialog

        ofd.Title = "Open..."
        ofd.InitialDirectory = "C:\Users\"
        ofd.Filter = "XML Documents (*.xml)|*.xml"

        If (ofd.ShowDialog = Windows.Forms.DialogResult.OK) Then

            'If (saved) Then

            StartNew(ofd.FileName)

            'Else

            'If (savedAs) Then
            '    Save()
            'Else
            '    SaveAs()
            'End If

            'End If

        Else



        End If

    End Sub


    Public Sub ClearAll()

        txtName.Text = ""
        txtTempo.Text = ""
        cmbTSMin.Text = 4
        cmbTSMax.Text = 4
        txtDuration.Text = ""

        For i = 0 To rules.Count - 1

            RuleBox1.Items.Remove(RuleBox1.Items.Item(i))
            RuleBox1.Refresh()


        Next

        rules.Clear()

        infoTempo.Text = "0"
        infoTimeSign.Text = "-/-"
        infoDuration.Text = "0 bars"
        lblName.Text = "Name"

        txtPlaylist.Text = ""
        compiled = False

    End Sub

    Public Sub StartNew(ByVal path As String)

        ClearAll()

        Dim temp_list As New List(Of String)(3)


        Using reader As XmlReader = XmlReader.Create(path)

            While reader.Read()
                If (reader.IsStartElement) Then

                    If (reader.Name = "rules") Then

                        txtPlaylist.Text = reader.GetAttribute("playlist")

                    End If

                    If (reader.Name = "rule") Then

                        temp_list.Add(reader.GetAttribute("name"))
                        temp_list.Add(reader.GetAttribute("tempo"))
                        temp_list.Add(reader.GetAttribute("timesignature"))
                        temp_list.Add(reader.GetAttribute("duration"))

                        rules.Add(temp_list)

                        MsgBox(temp_list.Count)
                        temp_list.Clear()
                        MsgBox(temp_list.Count)

                    End If


                ElseIf (reader.Name = "playlist") Then

                    MsgBox("")

                End If


            End While


        End Using

        For Each l As List(Of String) In rules

            MsgBox(l.Count)

        Next



    End Sub

End Class
