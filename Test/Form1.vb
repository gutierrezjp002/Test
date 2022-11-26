Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Static Counter
        Counter = Counter + 1
        TextBox1.Text = Counter
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Static Counter
        Counter = Counter + 2
        TextBox2.Text = Counter
    End Sub
End Class
