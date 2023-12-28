Public Class Form2

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Please do not leave any blanks in Player 1 stats.", MsgBoxStyle.Exclamation, Title:="Error 1")
        End If
        If TextBox6.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Or TextBox10.Text = "" Then
            MsgBox("Please do not leave any blanks in Player 2 stats.", MsgBoxStyle.Exclamation, Title:="Error 2")
        End If
        If Not (TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Or TextBox10.Text = "") Then
            If Val(TextBox2.Text) < 750 Or Val(TextBox9.Text) < 750 Or Val(TextBox3.Text) < 50 Or Val(TextBox8.Text) < 50 Or Val(TextBox5.Text) < 30 Or Val(TextBox6.Text) < 30 Then
                MsgBox("The following must be satisfied: HP should be at least 750; Attack should be at least 50; and Accuracy should beat least 30.", MsgBoxStyle.Exclamation, Title:="Error 3")
            ElseIf Val(TextBox2.Text) < Val(TextBox3.Text) Or Val(TextBox9.Text) < Val(TextBox8.Text) Then
                MsgBox("Player/Computer HP cannot be greater than their respective attack value.", MsgBoxStyle.Exclamation, Title:="Error 4")
            Else
                Dim MyForm As New Form1
                MyForm.ShowDialog()
            End If
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox8.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox9_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox9.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) Then
            MessageBox.Show("Please enter numbers only")
            e.Handled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Please do not leave any blanks in Player 1 stats.", MsgBoxStyle.Exclamation, Title:="Error 1")
        End If
        If TextBox6.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Or TextBox10.Text = "" Then
            MsgBox("Please do not leave any blanks in Player 2 stats.", MsgBoxStyle.Exclamation, Title:="Error 2")
        End If
        If Not (TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Or TextBox10.Text = "") Then
            If Val(TextBox2.Text) < 750 Or Val(TextBox9.Text) < 750 Or Val(TextBox3.Text) < 50 Or Val(TextBox8.Text) < 50 Or Val(TextBox5.Text) < 30 Or Val(TextBox6.Text) < 30 Then
                MsgBox("The following must be satisfied: HP should be at least 750; Attack should be at least 50; and Accuracy should beat least 30.", MsgBoxStyle.Exclamation, Title:="Error 3")
            ElseIf Val(TextBox2.Text) < Val(TextBox3.Text) Or Val(TextBox9.Text) < Val(TextBox8.Text) Then
                MsgBox("Player/Computer HP cannot be greater than their respective attack value.", MsgBoxStyle.Exclamation, Title:="Error 4")
            Else
                Dim MyForm As New Form5
                MyForm.ShowDialog()
            End If
        End If
    End Sub
End Class