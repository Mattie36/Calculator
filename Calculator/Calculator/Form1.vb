Public Class Form1
    Dim number As Double
    Dim store As Double
    Dim displayed As Double
    Dim addition As Boolean = False
    Dim subtraction As Boolean = False
    Dim multiplication As Boolean = False
    Dim division As Boolean = False

    Private Sub One_Click(sender As Object, e As EventArgs) Handles One.Click
        number = number * 10
        number = number + 1
        TextBox1.Text = number
    End Sub

    Private Sub Two_Click(sender As Object, e As EventArgs) Handles Two.Click
        number = number * 10
        number = number + 2
        TextBox1.Text = number
    End Sub

    Private Sub Three_Click(sender As Object, e As EventArgs) Handles Three.Click
        number = number * 10
        number = number + 3
        TextBox1.Text = number
    End Sub

    Private Sub Four_Click(sender As Object, e As EventArgs) Handles Four.Click
        number = number * 10
        number = number + 4
        TextBox1.Text = number
    End Sub

    Private Sub Five_Click(sender As Object, e As EventArgs) Handles Five.Click
        number = number * 10
        number = number + 5
        TextBox1.Text = number
    End Sub

    Private Sub Six_Click(sender As Object, e As EventArgs) Handles Six.Click
        number = number * 10
        number = number + 6
        TextBox1.Text = number
    End Sub

    Private Sub Seven_Click(sender As Object, e As EventArgs) Handles Seven.Click
        number = number * 10
        number = number + 7
        TextBox1.Text = number
    End Sub

    Private Sub Eight_Click(sender As Object, e As EventArgs) Handles Eight.Click
        number = number * 10
        number = number + 8
        TextBox1.Text = number
    End Sub

    Private Sub Nine_Click(sender As Object, e As EventArgs) Handles Nine.Click
        number = number * 10
        number = number + 9
        TextBox1.Text = number
    End Sub

    Private Sub Zero_Click(sender As Object, e As EventArgs) Handles Zero.Click
        number = number * 10
        number = number + 0
        TextBox1.Text = number
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        number = 0
        store = 0
        displayed = 0
        TextBox1.Text = number
        TextBox2.Text = "0"
    End Sub

    Private Sub Backspace_Click(sender As Object, e As EventArgs) Handles Backspace.Click
        number = number / 10
        TextBox1.Text = number
    End Sub
End Class