Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim vapre As Double
        vapre = Val(TextBox1.Text) / 100 * Val(TextBox2.Text)
        TextBox4.Text = Val(TextBox3.Text) + Val(vapre)
    End Sub
End Class
