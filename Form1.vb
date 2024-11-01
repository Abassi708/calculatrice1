Public Class Form1
    Dim op As Char
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btn_plus_Click(sender As Object, e As EventArgs) Handles btn_plus.Click
        op = "+"

    End Sub

    Private Sub btn_moins_Click(sender As Object, e As EventArgs) Handles btn_moins.Click
        op = "-"
    End Sub

    Private Sub btn_mult_Click(sender As Object, e As EventArgs) Handles btn_mult.Click
        op = "*"
    End Sub

    Private Sub btn_div_Click(sender As Object, e As EventArgs) Handles btn_div.Click
        op = "/"
    End Sub

    Private Sub btn_equal_Click(sender As Object, e As EventArgs) Handles btn_equal.Click
        Dim a = Integer.Parse(txt_A.Text)
        Dim b = Integer.Parse(txt_B.Text)
        Dim res = 0
        Dim test = True
        If op = "+" Then
            res = a + b
        ElseIf op = "-" Then
            res = a - b
        ElseIf op = "*" Then
            res = a * b
        ElseIf op = "/" And Not b = 0 Then
            res = a / b
        Else
            MessageBox.Show("veuiller choisir un opérateur")
            test = False
        End If
        If test Then
            lbl_res.text = a.ToString + " " + op + " " + b.ToString + " = " + res.ToString
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
