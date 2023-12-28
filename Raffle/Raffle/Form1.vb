Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = 0
        Threading.Thread.Sleep(1000)
        Dim a As Integer
        Dim no As String
        Dim sec As Integer
        Randomize()
        sec = Int(Rnd() * 2) + 1
        Randomize()
        a = Int(Rnd() * 25) + 1
        If a < 10 Then
            no = "0" & a
        Else
            no = a
        End If
        If sec = 1 Then
            Label1.Text = "L" & no
        ElseIf sec = 2 Then
            Label1.Text = "W" & no
        End If
        Button2.Enabled = 1
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Label1.Text = ""
        Button1.Enabled = 1
        Button2.Enabled = 0
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button2.Enabled = 0
    End Sub
End Class
