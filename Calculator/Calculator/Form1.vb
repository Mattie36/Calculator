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

    Private Sub Plus_Click(sender As Object, e As EventArgs) Handles Plus.Click
        store = number
        TextBox2.Text = store
        number = 0
        TextBox1.Text = number
        addition = True
    End Sub

    Private Sub Minus_Click(sender As Object, e As EventArgs) Handles Minus.Click
        store = number
        TextBox2.Text = store
        number = 0
        TextBox1.Text = number
        subtraction = True
    End Sub

    Private Sub Multiply_Click(sender As Object, e As EventArgs) Handles Multiply.Click
        store = number
        TextBox2.Text = store
        number = 0
        TextBox1.Text = number
        multiplication = True
    End Sub

    Private Sub Divide_Click(sender As Object, e As EventArgs) Handles Divide.Click
        store = number
        TextBox2.Text = store
        number = 0
        TextBox1.Text = number
        division = True
    End Sub

    Private Sub Solve_Click(sender As Object, e As EventArgs) Handles Solve.Click
        If addition = True Then
            displayed = store + number
            TextBox1.Text = displayed
            TextBox2.Text = "store + number ="
            number = 0
            store = 0

        ElseIf subtraction = True Then
        End If
    End Sub
End Class