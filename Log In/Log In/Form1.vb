Public Class Form1
    Public wrong As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        If TextBox1.Text = "admin" Then
            End
        End If

        If TextBox1.Text = "" Then
            Label3.Text = "Please enter a username"
            Label5.Visible = False
        ElseIf TextBox2.Text = "" Then
            Label3.Text = "Please enter a password"
            Label5.Visible = False
        ElseIf TextBox2.Text = "gradeeleven" Then
            If TextBox1.Text = "marc" Then
                Label3.Text = "Error: User does not exist"
                Label5.Visible = False
                TextBox2.Text = ""
                TextBox1.Text = ""
            Else
                End
            End If
        Else
            Label3.Text = "Incorrect password"
            TextBox2.Text = ""
            Label5.Visible = True
        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label3.Text = ""
        Label5.Visible = False
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label5.Visible = False
        wrong = 0
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        Label3.Text = ""
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Label3.Text = ""
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
