Public Class Form1
    Dim suma As Integer
    Dim re As Integer
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        suma = 2022 - TextBox2.Text
        re = Val(TextBox2.Text) - Val(18)
        re = Val(re) / Val(4)
        If TextBox2.Text >= 21 Then
            TextBox3.Text = $"hola {TextBox1.Text} {TextBox4.Text} tu fecha de cumpleaños es  {suma} y as botado  {re} veces"

        ElseIf TextBox2.Text >= 18 Then
            suma = 2022 - TextBox2.Text
            re = Val(TextBox2.Text) - Val(18)
            re = Val(re) / Val(4)
            TextBox3.Text = $"Hola {TextBox1.Text} {TextBox4.Text} tu fecha de cumpleaños es  {suma} y as botado  {re + 1} veces"


        Else
            TextBox3.Text = $"Tienes {TextBox2.Text} años, Eres menor de edad"

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
