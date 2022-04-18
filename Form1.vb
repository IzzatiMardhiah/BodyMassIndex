Public Class Form1
    Private Function BMI(Height As Single, weight As Single) As Double
        BMI = weight / Height ^ 2
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim h As Single, w As Single
        h = Val(TextBox1.Text)
        w = Val(TextBox2.Text)
        lblBMI.Text = BMI(h, w)

        If lblBMI.Text <= 24.9 Then
            lblBMI.BackColor = Color.SkyBlue
        ElseIf lblBMI.Text <= 29.9 Then
            lblBMI.BackColor = Color.Blue
        ElseIf lblBMI.Text <= 34.9 Then
            lblBMI.BackColor = Color.YellowGreen
        ElseIf lblBMI.Text <= 39.9 Then
            lblBMI.BackColor = Color.Red
        ElseIf lblBMI.Text >= 40 Then
            lblBMI.BackColor = Color.DarkRed
        End If
    End Sub
End Class
