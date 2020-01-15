Public Class Calculator
    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.AppendText(0)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel2.Paint

    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click

        If TextBox1.Text = 0 Then
            TextBox1.Clear()
        End If

        TextBox1.AppendText(0)

    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        If TextBox1.Text = 0 Then
            TextBox1.Clear()
        End If

        TextBox1.AppendText(1)
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        If TextBox1.Text = 0 Then
            TextBox1.Clear()
        End If

        TextBox1.AppendText(2)
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        If TextBox1.Text = 0 Then
            TextBox1.Clear()
        End If

        TextBox1.AppendText(3)
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        If TextBox1.Text = 0 Then
            TextBox1.Clear()
        End If

        TextBox1.AppendText(4)
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        If TextBox1.Text = 0 Then
            TextBox1.Clear()
        End If

        TextBox1.AppendText(5)
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        If TextBox1.Text = 0 Then
            TextBox1.Clear()
        End If

        TextBox1.AppendText(6)
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If TextBox1.Text = 0 Then
            TextBox1.Clear()
        End If

        TextBox1.AppendText(7)
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If TextBox1.Text = 0 Then
            TextBox1.Clear()
        End If

        TextBox1.AppendText(8)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If TextBox1.Text = 0 Then
            TextBox1.Clear()
        End If

        TextBox1.AppendText(9)
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click

    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click

    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Clear()
        TextBox1.AppendText(0)
    End Sub
End Class
