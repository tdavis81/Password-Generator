Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        NumericUpDown1.Text.Trim()
        If CheckBox1.Checked = False And CheckBox2.Checked = False And CheckBox3.Checked = False Then
            MsgBox("You Must Select A Method ", MsgBoxStyle.Critical) 'You can always change your message
        End If

        If Val(NumericUpDown1.Text) <= 3 Then 'You can change the minimum number
            MsgBox("Please enter a number higher than three", MsgBoxStyle.Critical, )
            Exit Sub 'You can change your mwssage

        End If
        If Val(NumericUpDown1.Text) > 78 Then 'You can change the maximum number.
            MsgBox("number is too high max 78", MsgBoxStyle.Critical, )

            Exit Sub

        End If
        TextBox1.Text = GenerateCode()
    End Sub
    Public Function GenerateCode()
        Dim intRnd As Integer
        Dim intStep As Integer = Nothing
        Dim strname As String
        Dim intlength As Integer
        Dim strinputstring As String = ""
        Dim Numbers As String = "1234567890"
        Dim Lower As String = "abcdefghijklmnopqrstuvwxyzyz"
        Dim Upper As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZYZ"
        Dim intnamelength As Integer = 1


        If CheckBox1.Checked Then strinputstring &= Lower
        If CheckBox2.Checked Then strinputstring &= Numbers
        If CheckBox3.Checked Then strinputstring &= Upper




        intlength = Len(strinputstring)



        Integer.TryParse(NumericUpDown1.Text, intnamelength)

        Randomize()


        strname = ""


        For inStep = 1 To intnamelength


            intRnd = Int(Rnd() * intlength) + 1


            strname = strname & Mid(strinputstring, intRnd, 1)


        Next


        Return strname

    End Function

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.TextLength < 9 Then
            ProgressBar1.Value = 5

        End If

        If TextBox1.TextLength > 9 Then
            ProgressBar1.Value = 25
        End If
        If TextBox1.TextLength > 19 Then
            ProgressBar1.Value = 50
        End If
        If TextBox1.TextLength > 30 Then
            ProgressBar1.Value = 75
        End If
        If TextBox1.TextLength > 51 Then
            ProgressBar1.Value = 100
        End If
        If TextBox1.TextLength < 8 Then
            Label2.Text = "Poor!!"
            Label2.ForeColor = Color.White
            Label2.BackColor = Color.Red
            Me.BackColor = Color.Red
            MenuStrip1.BackColor = Color.Red
            CheckBox1.ForeColor = Color.White
            CheckBox2.ForeColor = Color.White
            CheckBox3.ForeColor = Color.White
            MenuStrip1.ForeColor = Color.White
            Label1.ForeColor = Color.White
        End If
        If TextBox1.TextLength > 8 Then
            Label2.Text = "Good"
            Label2.ForeColor = Color.White
            Label2.BackColor = Color.Green
            Me.BackColor = Color.Green
            MenuStrip1.BackColor = Color.Green
            CheckBox1.ForeColor = Color.White
            CheckBox2.ForeColor = Color.White
            CheckBox3.ForeColor = Color.White
            MenuStrip1.ForeColor = Color.White
            Label1.ForeColor = Color.White
        End If
        If ProgressBar1.Value > 20 Then
            Label2.Text = "Excellent"
            Label2.ForeColor = Color.White
            Label2.BackColor = Color.Green
        End If
        If ProgressBar1.Value > 50 Then
            Label2.Text = "Outstanding"
            Label2.ForeColor = Color.White
            Label2.BackColor = Color.Green
        End If
    End Sub

End Class
