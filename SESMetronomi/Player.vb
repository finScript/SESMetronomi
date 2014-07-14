Imports System.Diagnostics
Public Class Player

    Dim playlist As List(Of String) = GetPlaylist()
    Dim rules As List(Of List(Of String)) = Setup.GetRules()


    Dim tBars As Integer = 0

    Dim gTimer As New Timer


    Private Sub Player_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        tBars = CalculateBars()

        InitPlayer()


    End Sub

    Public Sub InitPlayer()

        lblBarsPlayedTotalBig.Text = "0/" & tBars
        lblTimeBig.Text = CalculateDuration()


    End Sub

    Function GetPlaylist()

        Dim temp_playlist As New List(Of String)
        Dim p As String() = Setup.txtPlaylist.Text.Split(";")

        For i = 0 To p.Count - 1

            If (p(i).Length = 0) Then
                Continue For
            End If

            temp_playlist.Add(p(i))

        Next

        Return temp_playlist

    End Function

    Function CalculateBars()

        Dim totalBars As Integer = 0
        For i = 0 To playlist.Count - 1

            Dim section As String

            For Each section In playlist

                Dim examinelist As List(Of String)

                For u = 0 To rules.Count - 1

                    If (rules(u).Contains(section)) Then

                        examinelist = rules(u)

                        Exit For


                    ElseIf (u = rules.Count - 1 And rules(u).Contains(section) = False) Then

                        Return "failed"

                    End If

                Next

                totalBars += Integer.Parse(examinelist(3))

            Next

        Next

        Return totalBars / playlist.Count


    End Function

    Function CalculateDuration()

        Dim d As Double

        For Each section As String In playlist

            For i = 0 To rules.Count - 1

                If (rules(i).Contains(section)) Then

                    Dim interval As Integer = GetInterval(Integer.Parse(rules(i)(1)), rules(i)(2)) * Integer.Parse(rules(i)(3))


                    d += interval

                    Exit For

                End If

            Next

        Next

        Return d / 1000

    End Function

    Function GetInterval(ByVal tempo As Integer, ByVal signature As String)

        Dim i As Integer
        Dim persecond As Double = tempo / 60
        i = 1000 / persecond

        Dim parts As Integer = Integer.Parse(signature.Split("/")(1))
        Dim notes As Integer = Integer.Parse(signature.Split("/")(0))

        i /= (parts / 4)

        Return i * notes

    End Function

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        MsgBox(GetInterval(Integer.Parse(TextBox1.Text), TextBox2.Text))

    End Sub

    Private Sub btnPlay_Click(sender As System.Object, e As System.EventArgs) Handles btnPlay.Click

        gTimer.Interval = GetInterval(rules(0)(1), rules(0)(2)) / rules(0)(2).Split("/")(0)

        AddHandler gTimer.Tick, AddressOf MetronomeTick

        gTimer.Enabled = True


    End Sub

    Dim tickCount As Integer
    Dim barCount As Integer = 1
    Dim ruleCount As Integer = 0

    Public Sub MetronomeTick()

        Dim cRule As List(Of String) = rules(ruleCount)

        gTimer.Interval = GetInterval(cRule(1), cRule(2)) / cRule(2).Split("/")(0)


        lblName.Text = cRule(0)
        lblRuleNameHeader.Text = lblName.Text

        lblRuleNODebug.Text = ruleCount
        lblBarsDebug.Text = barCount


        lblTempo.Text = cRule(1)
        lblSignature.Text = cRule(2)
        lblDuration.Text = cRule(3)

        If (Integer.Parse(cRule(3).Split("/")(0)) = tickCount) Then

            tickCount = 0
            barCount += 1

            If (barCount = cRule(3)) Then

                ruleCount += 1

            End If

        End If

        If (tickCount = 0) Then
            My.Computer.Audio.Play(My.Resources.b02, AudioPlayMode.Background)
        Else
            My.Computer.Audio.Play(My.Resources.b01, AudioPlayMode.Background)
        End If



        tickCount += 1
        lblTickCount.Text = "t=" & tickCount

    End Sub

End Class