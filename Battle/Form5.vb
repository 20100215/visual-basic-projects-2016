Public Class Form5
    'stats
    Public maxlifeA As Double
    Public attackA As Double
    Public accA As Double
    Public maxlifeB As Double
    Public attackB As Double
    Public accB As Double
    Public name1 As String
    Public name2 As String
    'game interface
    Public movea As Integer
    Public moveb As Integer
    Public aa As Integer
    Public ab As Integer
    Public ba As Integer
    Public bb As Integer
    Public oppspecial As Integer
    Dim turn As Integer
    Dim opta1 As Integer
    Dim opta2 As Integer
    Dim opta3 As Integer
    Dim optb1 As Integer
    Dim optb2 As Integer
    Dim optb3 As Integer
    'HP changes
    Public minuslife1 As Double
    Public spval1 As Integer
    Public minuslife2 As Double
    Public spval2 As Integer
    Public accp1 As Double
    Public accp2 As Double
    Public lifep1 As Integer
    Public lifep2 As Integer
    Public total1 As Integer
    Public total2 As Integer
    Public spuse1 As Integer
    Public spuse2 As Integer
    'current life
    Public colora As System.Drawing.Color
    Public colorb As System.Drawing.Color

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'reset interface except HP
        p1turna.SelectedIndex = 0
        p1turnb.SelectedIndex = 0
        p1turnc.SelectedIndex = 0
        Playername1.Text = Form2.TextBox1.Text
        Playername2.Text = Form2.TextBox10.Text
        life1.Text = Form2.TextBox2.Text
        life2.Text = Form2.TextBox9.Text
        lifep1 = Form2.TextBox2.Text
        lifep2 = Form2.TextBox9.Text
        maxlifeA = Form2.TextBox2.Text
        maxlifeB = Form2.TextBox9.Text
        attackA = Form2.TextBox3.Text
        accA = Form2.TextBox5.Text
        accB = Form2.TextBox6.Text
        attackB = Form2.TextBox8.Text
        spval1 = 0
        spval2 = 0
        spuse1 = 0
        spuse2 = 0
        turn = 1
    End Sub

    Private Sub help_Click(sender As System.Object, e As System.EventArgs) Handles help.Click
        'help
        Dim MyForm As New Form3
        MyForm.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'reset values
        minuslife1 = 0
        minuslife2 = 0
        total1 = 0
        total2 = 0
        p1deduct.Visible = 1
        p2deduct.Visible = 1
        Button1.Enabled = 0

        If spuse1 = 1 Or spuse2 = 1 Then
            p1turna.SelectedIndex = 0
            p1turnb.SelectedIndex = 0
            p1turnc.SelectedIndex = 0
            p2turna.SelectedIndex = 0
            p2turnb.SelectedIndex = 0
            p2turnc.SelectedIndex = 0
            If spuse1 = 1 Then
                spuse1 = 0
                spval1 = 0
                Label3.Visible = 0
                p1special.ForeColor = Color.Black
                p1special.Text = "SP 0/3"
                p1turn1.BackColor = Color.Blue
                p1turn2.BackColor = Color.Blue
                p1turn3.BackColor = Color.Blue
                Label6.Visible = 1
                minuslife2 = attackA * 4 * accp1
            End If
            If spuse2 = 1 Then
                spuse2 = 0
                spval2 = 0
                Label4.Visible = 0
                p2special.ForeColor = Color.Black
                p2special.Text = "SP 0/3"
                p2turn1.BackColor = Color.Blue
                p2turn2.BackColor = Color.Blue
                p2turn3.BackColor = Color.Blue
                Label7.Visible = 1
                minuslife1 = attackB * 4 * accp2
            End If
            If spval1 >= 3 Then
                spval1 = 3
                p1special.Text = "SP 3/3"
                p1special.ForeColor = Color.Blue
                Label3.Visible = 1
            End If
            If spval2 >= 3 Then
                spval2 = 3
                p2special.Text = "SP 3/3"
                p2special.ForeColor = Color.Blue
                Label4.Visible = 1
            End If
            Threading.Thread.Sleep(500)
        Else
            'effects of moves (damage)
            If accA > accB Then
                accp1 = 1 + ((accA - accB) / 200)
                accp2 = 1 - ((accA - accB) / 400)
            End If
            If accA < accB Then
                accp2 = 1 + ((accB - accA) / 200)
                accp1 = 1 - ((accB - accA) / 400)
            End If
            If accA = accB Then
                accp1 = 1
                accp2 = 1
            End If
            If accp1 > 1.4 Then
                accp1 = 1.4
            End If
            If accp2 > 1.4 Then
                accp2 = 1.4
            End If
            If accp1 < 0.75 Then
                accp1 = 0.75
            End If
            If accp2 < 0.75 Then
                accp2 = 0.75
            End If

            '3 turn loop starts
            'part 1: recording moves
            For moves = 1 To 3 Step 1
                If moves = 1 Then
                    movea = opta1
                    moveb = optb1
                End If
                If moves = 2 Then
                    movea = opta2
                    moveb = optb2
                End If
                If moves = 3 Then
                    movea = opta3
                    moveb = optb3
                End If

                colora = Color.WhiteSmoke
                colorb = Color.WhiteSmoke

                Select Case movea
                    Case 1
                        aa = 1
                        ab = 1
                    Case 2
                        aa = 1
                        ab = 2
                    Case 3
                        aa = 1
                        ab = 3
                    Case 4
                        aa = 2
                        ab = 1
                    Case 5
                        aa = 2
                        ab = 2
                    Case 6
                        aa = 2
                        ab = 3
                    Case 7
                        aa = 3
                        ab = 1
                    Case 8
                        aa = 3
                        ab = 2
                    Case 9
                        aa = 3
                        ab = 3
                End Select

                Select Case moveb
                    Case 1
                        ba = 1
                        bb = 1
                    Case 2
                        ba = 1
                        bb = 2
                    Case 3
                        ba = 1
                        bb = 3
                    Case 4
                        ba = 2
                        bb = 1
                    Case 5
                        ba = 2
                        bb = 2
                    Case 6
                        ba = 2
                        bb = 3
                    Case 7
                        ba = 3
                        bb = 1
                    Case 8
                        ba = 3
                        bb = 2
                    Case 9
                        ba = 3
                        bb = 3
                End Select



                'attack vs attack
                If aa = 1 And ba = 1 Then
                    If ab = 1 And bb = 1 Then
                        If accA > accB Then
                            minuslife2 = minuslife2 + (attackA * 65 / 100 * accp1)
                            minuslife1 = minuslife1 + (attackB * 55 / 100 * accp2)
                        End If
                        If accA = accB Then
                            minuslife2 = minuslife2 + (attackA * 60 / 100 * accp1)
                            minuslife1 = minuslife1 + (attackB * 60 / 100 * accp2)
                        End If
                        If accA < accB Then
                            minuslife2 = minuslife2 + (attackA * 55 / 100 * accp1)
                            minuslife1 = minuslife1 + (attackB * 65 / 100 * accp2)
                        End If
                    End If
                    If ab = 1 And bb = 2 Then
                        minuslife2 = minuslife2 + (attackA * 6 / 10 * accp1)
                        minuslife1 = minuslife1 + (attackB * accp2)
                    End If
                    If ab = 1 And bb = 3 Then
                        minuslife2 = minuslife2 + (attackA * 6 / 10 * accp1)
                        minuslife1 = minuslife1 + (attackB * 14 / 10 * accp2)
                    End If
                    If ab = 2 And bb = 1 Then
                        minuslife2 = minuslife2 + (attackA * accp1)
                        minuslife1 = minuslife1 + (attackB * 6 / 10 * accp2)
                    End If
                    If ab = 2 And bb = 2 Then
                        If accA > accB Then
                            minuslife2 = minuslife2 + (attackA * 105 / 100 * accp1)
                            minuslife1 = minuslife1 + (attackB * 95 / 100 * accp2)
                        End If
                        If accA = accB Then
                            minuslife2 = minuslife2 + (attackA * accp1)
                            minuslife1 = minuslife1 + (attackB * accp2)
                        End If
                        If accA < accB Then
                            minuslife2 = minuslife2 + (attackA * 95 / 100 * accp1)
                            minuslife1 = minuslife1 + (attackB * 105 / 100 * accp2)
                        End If
                    End If
                    If ab = 2 And bb = 3 Then
                        minuslife2 = minuslife2 + (attackA * accp1)
                        minuslife1 = minuslife1 + (attackB * 14 / 10 * accp2)
                    End If
                    If ab = 3 And bb = 1 Then
                        minuslife1 = minuslife1 + (attackB * 6 / 10 * accp2)
                        minuslife2 = minuslife2 + (attackA * 14 / 10 * accp1)
                    End If
                    If ab = 3 And bb = 2 Then
                        minuslife1 = minuslife1 + (attackB * accp2)
                        minuslife2 = minuslife2 + (attackA * 14 / 10 * accp1)
                    End If
                    If ab = 3 And bb = 3 Then
                        If accA > accB Then
                            minuslife2 = minuslife2 + (attackA * 150 / 100 * accp1)
                            minuslife1 = minuslife1 + (attackB * 130 / 100 * accp2)
                        End If
                        If accA = accB Then
                            minuslife2 = minuslife2 + (attackA * 140 / 100 * accp1)
                            minuslife1 = minuslife1 + (attackB * 140 / 100 * accp2)
                        End If
                        If accA < accB Then
                            minuslife2 = minuslife2 + (attackA * 130 / 100 * accp1)
                            minuslife1 = minuslife1 + (attackB * 150 / 100 * accp2)
                        End If
                    End If
                End If

                'attack vs guard
                If aa = 1 And ba = 2 Then
                    If ab = 1 And bb = 1 Then
                        colora = Color.Red
                        colorb = Color.Green
                        minuslife1 = minuslife1 + (attackB * accp2)
                    End If
                    If ab = 1 And bb = 2 Then
                        colora = Color.Red
                        colorb = Color.Green
                        spval2 = spval2 + 1
                    End If
                    If ab = 1 And bb = 3 Then
                        colorb = Color.Red
                        colora = Color.Green
                        minuslife2 = minuslife2 + (attackA * 6 / 10 * accp1)
                    End If
                    If ab = 2 And bb = 1 Then
                        colora = Color.Red
                        colorb = Color.Green
                        minuslife1 = minuslife1 + (attackB * accp2)
                    End If
                    If ab = 2 And bb = 2 Then
                        colora = Color.Red
                        colorb = Color.Green
                        spval2 = spval2 + 1
                    End If
                    If ab = 2 And bb = 3 Then
                        colorb = Color.Red
                        colora = Color.Green
                        minuslife2 = minuslife2 + (attackA * accp1)
                    End If
                    If ab = 3 And bb = 1 Then
                        colora = Color.Red
                        colorb = Color.Green
                        minuslife1 = minuslife1 + (attackB * 220 / 100 * accp2)
                    End If
                    If ab = 3 And bb = 2 Then
                        colora = Color.Red
                        colorb = Color.Green
                        spval2 = spval2 + 1
                        minuslife1 = minuslife1 + (attackB * 120 / 100 * accp2)
                    End If
                    If ab = 3 And bb = 3 Then
                        colorb = Color.Red
                        colora = Color.Green
                        minuslife2 = minuslife2 + (attackA * 150 / 100 * accp1)
                    End If
                End If

                'attack vs break
                If aa = 1 And ba = 3 Then
                    colora = Color.Green
                    colorb = Color.Red
                    If ab = 1 Then
                        minuslife2 = minuslife2 + (attackA * 6 / 10 * accp1)
                        spval1 = spval1 + 1
                    End If
                    If ab = 2 Then
                        minuslife2 = minuslife2 + (attackA * accp1)
                    End If
                    If ab = 3 Then
                        minuslife2 = minuslife2 + (attackA * 15 / 10 * accp1)
                    End If
                End If

                'guard vs attack
                If aa = 2 And ba = 1 Then
                    If ab = 1 And bb = 1 Then
                        colorb = Color.Red
                        colora = Color.Green
                        minuslife2 = minuslife2 + (attackA * accp1)
                    End If
                    If ab = 2 And bb = 1 Then
                        colorb = Color.Red
                        colora = Color.Green
                        spval1 = spval1 + 1
                    End If
                    If ab = 3 And bb = 1 Then
                        colora = Color.Red
                        colorb = Color.Green
                        minuslife1 = minuslife1 + (attackB * 6 / 10 * accp2)
                    End If
                    If ab = 1 And bb = 2 Then
                        colorb = Color.Red
                        colora = Color.Green
                        minuslife2 = minuslife2 + (attackA * accp1)
                    End If
                    If ab = 2 And bb = 2 Then
                        colorb = Color.Red
                        colora = Color.Green
                        spval1 = spval1 + 1
                    End If
                    If ab = 3 And bb = 2 Then
                        colora = Color.Red
                        colorb = Color.Green
                        minuslife1 = minuslife1 + (attackB * accp2)
                    End If
                    If ab = 1 And bb = 3 Then
                        colorb = Color.Red
                        colora = Color.Green
                        minuslife2 = minuslife2 + (attackA * 220 / 100 * accp1)
                    End If
                    If ab = 2 And bb = 3 Then
                        colorb = Color.Red
                        colora = Color.Green
                        spval2 = spval2 + 1
                        minuslife2 = minuslife2 + (attackA * 120 / 100 * accp1)
                    End If
                    If ab = 3 And bb = 3 Then
                        colora = Color.Red
                        colorb = Color.Green
                        minuslife1 = minuslife1 + (attackB * 150 / 100 * accp2)
                    End If
                End If

                'guard vs guard
                If aa = 2 And ba = 2 Then
                    If ab = 2 Then
                        spval1 = spval1 + 1
                    End If
                    If bb = 2 Then
                        spval2 = spval2 + 1
                    End If
                    If ab = 3 Then
                        spval1 = spval1 + 2
                    End If
                    If bb = 3 Then
                        spval2 = spval2 + 2
                    End If
                End If

                'guard vs break
                If aa = 2 And ba = 3 Then
                    colora = Color.Red
                    colorb = Color.Green
                    If bb = 1 Then
                        minuslife2 = minuslife2 - (maxlifeB / 10)
                    End If
                    If bb = 2 Then
                        minuslife1 = minuslife1 + (attackB / 2 * accp2)
                        spval2 = spval2 + 1
                    End If
                    If bb = 3 Then
                        minuslife1 = minuslife1 + (maxlifeA / 20)
                        minuslife2 = minuslife2 - (maxlifeA / 20)
                    End If
                End If

                'break vs attack
                If aa = 3 And ba = 1 Then
                    colorb = Color.Green
                    colora = Color.Red
                    If bb = 1 Then
                        minuslife1 = minuslife1 + (attackB * 6 / 10 * accp2)
                        spval2 = spval2 + 1
                    End If
                    If bb = 2 Then
                        minuslife1 = minuslife1 + (attackB * accp2)
                    End If
                    If bb = 3 Then
                        minuslife1 = minuslife1 + (attackB * 15 / 10 * accp2)
                    End If
                End If

                'break vs guard
                If aa = 3 And ba = 2 Then
                    colorb = Color.Red
                    colora = Color.Green
                    If ab = 1 Then
                        minuslife1 = minuslife1 - (maxlifeA / 10)
                    End If
                    If ab = 2 Then
                        minuslife2 = minuslife2 + (attackA / 2 * accp1)
                        spval1 = spval1 + 1
                    End If
                    If ab = 3 Then
                        minuslife2 = minuslife2 + (maxlifeB / 20)
                        minuslife1 = minuslife1 - (maxlifeB / 20)
                    End If
                End If

                'break vs break
                If aa = 3 And ba = 3 Then
                    If ab = 1 Then
                        minuslife1 = minuslife1 - (maxlifeA / 10)
                    End If
                    If ab = 2 Then
                        minuslife2 = minuslife2 + (attackA / 2 * accp1)
                    End If
                    If ab = 3 Then
                        minuslife2 = minuslife2 + (maxlifeB / 20)
                        minuslife1 = minuslife1 - (maxlifeB / 20)
                    End If
                    If bb = 1 Then
                        minuslife2 = minuslife2 - (maxlifeB / 10)
                    End If
                    If bb = 2 Then
                        minuslife1 = minuslife1 + (attackB / 2 * accp2)
                    End If
                    If bb = 3 Then
                        minuslife1 = minuslife1 + (maxlifeA / 20)
                        minuslife2 = minuslife2 - (maxlifeA / 20)
                    End If
                End If

                'checking if values "overflow"
                If spval1 = 1 Then
                    p1special.Text = "SP 1/3"
                End If
                If spval2 = 1 Then
                    p2special.Text = "SP 1/3"
                End If
                If spval1 = 2 Then
                    p1special.Text = "SP 2/3"
                End If
                If spval2 = 2 Then
                    p2special.Text = "SP 2/3"
                End If
                If spval1 >= 3 Then
                    spval1 = 3
                    p1special.Text = "SP 3/3"
                    p1special.ForeColor = Color.Blue
                    Label3.Visible = 1
                End If
                If spval2 >= 3 Then
                    spval2 = 3
                    p2special.Text = "SP 3/3"
                    p2special.ForeColor = Color.Blue
                    Label4.Visible = 1
                End If

                If moves = 1 Then
                    p1turn1.BackColor = colora
                    p2turn1.BackColor = colorb
                    p1turna.SelectedIndex = opta1
                    p2turna.SelectedIndex = optb1
                End If
                If moves = 2 Then
                    p1turn2.BackColor = colora
                    p2turn2.BackColor = colorb
                    p1turnb.SelectedIndex = opta2
                    p2turnb.SelectedIndex = optb2
                End If
                If moves = 3 Then
                    p1turn3.BackColor = colora
                    p2turn3.BackColor = colorb
                    p1turnc.SelectedIndex = opta3
                    p2turnc.SelectedIndex = optb3
                End If
                Threading.Thread.Sleep(400)
            Next
        End If

        'bonuses
        If p1turn1.BackColor = Color.Green And p1turn2.BackColor = Color.Green And p1turn3.BackColor = Color.Green And minuslife2 > 0 Then
            minuslife2 = minuslife2 * 3 / 2
        End If
        If p2turn1.BackColor = Color.Green And p2turn2.BackColor = Color.Green And p2turn3.BackColor = Color.Green And minuslife1 > 0 Then
            minuslife1 = minuslife1 * 3 / 2
        End If

        total1 = minuslife1
        total2 = minuslife2

        'effects of moves (remaining life)
        If total1 = 0 Then
            p1deduct.Visible = 0
        End If
        If total2 = 0 Then
            p2deduct.Visible = 0
        End If
        If total1 > 0 Then
            p1deduct.ForeColor = Color.Red
            p1deduct.Text = "-" & total1
            lifep1 = Val(life1.Text) - total1
        End If
        If total2 > 0 Then
            p2deduct.ForeColor = Color.Red
            p2deduct.Text = "-" & total2
            lifep2 = Val(life2.Text) - total2
        End If
        If total1 < 0 Then
            p1deduct.ForeColor = Color.Green
            p1deduct.Text = "+" & total1 * -1
            lifep1 = Val(life1.Text) - total1
        End If
        If total2 < 0 Then
            p2deduct.ForeColor = Color.Green
            p2deduct.Text = "+" & total2 * -1
            lifep2 = Val(life2.Text) - total2
        End If
        Button2.Enabled = 1
        percent1.Text = "(" & lifep1 * 100 \ maxlifeA & "%)"
        percent2.Text = "(" & lifep2 * 100 \ maxlifeB & "%)"
        life1.Text = lifep1
        life2.Text = lifep2

        If Val(life1.Text) >= maxlifeA Then
            life1.Text = maxlifeA
            percent1.Text = "(100%)"
        End If
        If Val(life2.Text) >= maxlifeB Then
            life2.Text = maxlifeB
            percent2.Text = "(100%)"
        End If

        If Val(life1.Text) > 0 And percent1.Text = "(0%)" Then
            percent1.Text = "(1%)"
        End If
        If Val(life2.Text) > 0 And percent2.Text = "(0%)" Then
            percent2.Text = "(1%)"
        End If
        If lifep1 * 100 \ maxlifeA < 20 Then
            life1.ForeColor = Color.Red
            percent1.ForeColor = Color.Red
        Else
            life1.ForeColor = Color.Black
            percent1.ForeColor = Color.Black
        End If
        If lifep2 * 100 \ maxlifeB < 20 Then
            life2.ForeColor = Color.Red
            percent2.ForeColor = Color.Red
        Else
            life2.ForeColor = Color.Black
            percent2.ForeColor = Color.Black
        End If

        If Val(life1.Text) <= 0 And Val(life2.Text) > 0 Then
            life1.Text = 0
            percent1.Text = "(0%)"
            MsgBox(Playername2.Text & " have just defeated " & Playername1.Text & " in " & turn & " rounds with remaining health of " & life2.Text & ".", MsgBoxStyle.Information, Title:="PLAYER 2 WON!")
            Button2.Enabled = 0
            Label9.Visible = 1
        End If
        If Val(life2.Text) <= 0 And Val(life1.Text) > 0 Then
            life2.Text = 0
            percent2.Text = "(0%)"
            MsgBox(Playername1.Text & " have just defeated " & Playername2.Text & " in " & turn & " rounds with remaining health of " & life1.Text & ".", MsgBoxStyle.Information, Title:="PLAYER 1 WON!")
            Button2.Enabled = 0
            Label8.Visible = 1
        End If
        If Val(life2.Text) <= 0 And Val(life1.Text) <= 0 Then
            life2.Text = 0
            percent2.Text = "(0%)"
            life1.Text = 0
            percent1.Text = "(0%)"
            MsgBox("Both of you ran out of HP at the same time = NO winner for this game!", MsgBoxStyle.Critical, Title:="DRAW")
            Button2.Enabled = 0
        End If
    End Sub


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        Button2.Enabled = 0
        p1deduct.Visible = 0
        p2deduct.Visible = 0
        p1turn1.BackColor = Color.WhiteSmoke
        p1turn2.BackColor = Color.WhiteSmoke
        p1turn3.BackColor = Color.WhiteSmoke
        p2turn1.BackColor = Color.WhiteSmoke
        p2turn2.BackColor = Color.WhiteSmoke
        p2turn3.BackColor = Color.WhiteSmoke
        Threading.Thread.Sleep(500)
        If spval1 = 3 Then
            Button5.Enabled = 1
            Button5.Visible = 1
        End If
        turn = turn + 1
        Label5.Text = "Round " & turn

        Label6.Visible = 0
        Label7.Visible = 0
        p1turna.SelectedIndex = 0
        p1turnb.SelectedIndex = 0
        p1turnc.SelectedIndex = 0
        p2turna.SelectedIndex = 0
        p2turnb.SelectedIndex = 0
        p2turnc.SelectedIndex = 0

        p1turna.Visible = 1
        p1turnb.Visible = 1
        p1turnc.Visible = 1
        p2turna.Visible = 0
        p2turnb.Visible = 0
        p2turnc.Visible = 0

        p1turna.Enabled = 1
        p1turnb.Enabled = 1
        p1turnc.Enabled = 1
        p2turna.Enabled = 1
        p2turnb.Enabled = 1
        p2turnc.Enabled = 1

        Button4.Visible = 1

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If p1turna.SelectedIndex = 0 Or p1turnb.SelectedIndex = 0 Or p1turnc.SelectedIndex = 0 Then
            MsgBox("Please choose all your moves.", MsgBoxStyle.Exclamation, Title:="Error 5")
        Else

            p1turna.Visible = 0
            p1turnb.Visible = 0
            p1turnc.Visible = 0
            Button4.Visible = 0
            Button5.Visible = 0
            Threading.Thread.Sleep(500)
            p2turna.Visible = 1
            p2turnb.Visible = 1
            p2turnc.Visible = 1
            Button6.Visible = 1
            Button3.Visible = 0
            opta1 = p1turna.SelectedIndex
            opta2 = p1turnb.SelectedIndex
            opta3 = p1turnc.SelectedIndex

            If spval2 = 3 Then
                Button3.Enabled = 1
                Button3.Visible = 1
            End If
        End If
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        If p2turna.SelectedIndex = 0 Or p2turnb.SelectedIndex = 0 Or p2turnc.SelectedIndex = 0 Then
            MsgBox("Please choose all your moves.", MsgBoxStyle.Exclamation, Title:="Error 5")
        Else
            p2turna.Visible = 0
            p2turnb.Visible = 0
            p2turnc.Visible = 0
            Button6.Visible = 0
            Button3.Visible = 0
            optb1 = p2turna.SelectedIndex
            optb2 = p2turnb.SelectedIndex
            optb3 = p2turnc.SelectedIndex
            Threading.Thread.Sleep(500)
            Button1.Enabled = 1
            p1turna.Visible = 1
            p1turnb.Visible = 1
            p1turnc.Visible = 1
            p2turna.Visible = 1
            p2turnb.Visible = 1
            p2turnc.Visible = 1
            p1turna.Enabled = 0
            p1turnb.Enabled = 0
            p1turnc.Enabled = 0
            p2turna.Enabled = 0
            p2turnb.Enabled = 0
            p2turnc.Enabled = 0
            p1turna.SelectedIndex = 0
            p1turnb.SelectedIndex = 0
            p1turnc.SelectedIndex = 0
            p2turna.SelectedIndex = 0
            p2turnb.SelectedIndex = 0
            p2turnc.SelectedIndex = 0
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        spuse1 = 1

        p1turna.Visible = 0
        p1turnb.Visible = 0
        p1turnc.Visible = 0
        Button4.Visible = 0
        Button5.Visible = 0
        Threading.Thread.Sleep(500)
        p2turna.Visible = 1
        p2turnb.Visible = 1
        p2turnc.Visible = 1
        Button6.Visible = 1
        Button3.Visible = 0
        If spval2 = 3 Then
            Button3.Enabled = 1
            Button3.Visible = 1
        End If
        opta1 = 0
        opta2 = 0
        opta3 = 0
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        spuse2 = 1

        p2turna.Visible = 0
        p2turnb.Visible = 0
        p2turnc.Visible = 0
        Button6.Visible = 0
        Button3.Visible = 0
        optb1 = 0
        optb2 = 0
        optb3 = 0
        Threading.Thread.Sleep(500)
        Button1.Enabled = 1
        p1turna.Visible = 1
        p1turnb.Visible = 1
        p1turnc.Visible = 1
        p2turna.Visible = 1
        p2turnb.Visible = 1
        p2turnc.Visible = 1
        p1turna.Enabled = 0
        p1turnb.Enabled = 0
        p1turnc.Enabled = 0
        p2turna.Enabled = 0
        p2turnb.Enabled = 0
        p2turnc.Enabled = 0
        p1turna.SelectedIndex = 0
        p1turnb.SelectedIndex = 0
        p1turnc.SelectedIndex = 0
        p2turna.SelectedIndex = 0
        p2turnb.SelectedIndex = 0
        p2turnc.SelectedIndex = 0
    End Sub
End Class