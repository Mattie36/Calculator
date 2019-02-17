Public Class Form1
    Dim number As Double                            'Current number
    Dim store As Double                             'Stored first number
    Dim displayed As Double                         'Final answer being displayed
    Dim addition As Boolean = False                 'If user is adding
    Dim subtraction As Boolean = False              'If user is subtracting
    Dim multiplication As Boolean = False           'If user is multiplying
    Dim division As Boolean = False                 'If user is dividing
    Dim squaring As Boolean = False                 'If user is squaring
    Dim sqrRoot As Boolean = False                  'If user is square rooting
    Dim power As Boolean = False                    'If user is setting a number to a power
    Dim numberRoot As Boolean = False               'If user is rooting a number by a higher number
    Dim decimalPress As Boolean = False             'If user is typing decimals

    Dim numDigit1 As Integer                        'First number
    Dim numDigit2 As Integer                        '|
    Dim numDigit3 As Integer                        '|
    Dim numDigit4 As Integer                        '|
    Dim numDigit5 As Integer                        '|
    Dim numDigit6 As Integer                        '|
    Dim numDigit7 As Integer                        '|
    Dim numDigit8 As Integer                        '|
    Dim numDigit9 As Integer                        'V
    Dim numDigit0 As Integer                        'Tenth number

    Dim storeDigit1 As Integer                      'First number
    Dim storeDigit2 As Integer                      '|
    Dim storeDigit3 As Integer                      '|
    Dim storeDigit4 As Integer                      '|
    Dim storeDigit5 As Integer                      '|
    Dim storeDigit6 As Integer                      '|
    Dim storeDigit7 As Integer                      '|
    Dim storeDigit8 As Integer                      '|
    Dim storeDigit9 As Integer                      'V
    Dim storeDigit0 As Integer                      'Tenth number

    Dim isNumDigit1 As Integer                      'First number boolean
    Dim isNumDigit2 As Integer                      '|
    Dim isNumDigit3 As Integer                      '|
    Dim isNumDigit4 As Integer                      '|
    Dim isNumDigit5 As Integer                      '|
    Dim isNumDigit6 As Integer                      '|
    Dim isNumDigit7 As Integer                      '|
    Dim isNumDigit8 As Integer                      '|
    Dim isNumDigit9 As Integer                      'V
    Dim isNumDigit0 As Integer                      'Tenth number boolean

    Dim isStoreDigit1 As Integer                    'First number boolean
    Dim isStoreDigit2 As Integer                    '|
    Dim isStoreDigit3 As Integer                    '|
    Dim isStoreDigit4 As Integer                    '|
    Dim isStoreDigit5 As Integer                    '|
    Dim isStoreDigit6 As Integer                    '|
    Dim isStoreDigit7 As Integer                    '|
    Dim isStoreDigit8 As Integer                    '|
    Dim isStoreDigit9 As Integer                    'V
    Dim isStoreDigit0 As Integer                    'Tenth number boolean

    Dim decimalNumber As Integer = 0                'How many digits have been entered after decimal

    Private Sub One_Click(sender As Object, e As EventArgs) Handles One.Click

        If decimalPress = False Then
            number *= 10
            number += 1
            TextBox1.Text = number
        ElseIf decimalPress = True Then
            decimalNumber += 1
            number += (1 / (Math.Pow(10, decimalNumber)))
            TextBox1.Text = Str(number)
        End If

        If addition = False And subtraction = False And multiplication = False And division = False And squaring = False And sqrRoot = False And power = False And numberRoot = False Then
            If isStoreDigit1 = False Then
                storeDigit1 = 1
                isStoreDigit1 = True
            ElseIf isStoreDigit2 = False Then
                storeDigit2 = 1
                isStoreDigit2 = True
            ElseIf isStoreDigit3 = False Then
                storeDigit3 = 1
                isStoreDigit3 = True
            ElseIf isStoreDigit4 = False Then
                storeDigit4 = 1
                isStoreDigit4 = True
            ElseIf isStoreDigit5 = False Then
                storeDigit5 = 1
                isStoreDigit5 = True
            ElseIf isStoreDigit6 = False Then
                storeDigit6 = 1
                isStoreDigit6 = True
            ElseIf isStoreDigit7 = False Then
                storeDigit7 = 1
                isStoreDigit7 = True
            ElseIf isStoreDigit8 = False Then
                storeDigit8 = 1
                isStoreDigit8 = True
            ElseIf isStoreDigit9 = False Then
                storeDigit9 = 1
                isStoreDigit9 = True
            ElseIf isStoreDigit0 = False Then
                storeDigit0 = 1
                isStoreDigit0 = True
            Else
                MessageBox.Show("Too many digits.")
            End If
        ElseIf addition = True Or subtraction = True Or multiplication = True Or division = True Or squaring = True Or sqrRoot = True Or power = True Or numberRoot = True Then
            If isNumDigit1 = False Then
                numDigit1 = 1
                isNumDigit1 = True
            ElseIf isNumDigit2 = False Then
                numDigit2 = 1
                isNumDigit2 = True
            ElseIf isNumDigit3 = False Then
                numDigit3 = 1
                isNumDigit3 = True
            ElseIf isNumDigit4 = False Then
                numDigit4 = 1
                isNumDigit4 = True
            ElseIf isNumDigit5 = False Then
                numDigit5 = 1
                isNumDigit5 = True
            ElseIf isNumDigit6 = False Then
                numDigit6 = 1
                isNumDigit6 = True
            ElseIf isNumDigit7 = False Then
                numDigit7 = 1
                isNumDigit7 = True
            ElseIf isNumDigit8 = False Then
                numDigit8 = 1
                isNumDigit8 = True
            ElseIf isNumDigit9 = False Then
                numDigit9 = 1
                isNumDigit9 = True
            ElseIf isNumDigit0 = False Then
                numDigit0 = 1
                isNumDigit0 = True
            Else
                MessageBox.Show("Too many digits.")
            End If
        End If
    End Sub

    Private Sub Two_Click(sender As Object, e As EventArgs) Handles Two.Click

        If decimalPress = False Then
            number *= 10
            number += 2
            TextBox1.Text = number
        ElseIf decimalPress = True Then
            decimalNumber += 1
            number += (2 / (Math.Pow(10, decimalNumber)))
            TextBox1.Text = Str(number)
        End If

        If addition = False And subtraction = False And multiplication = False And division = False And squaring = False And sqrRoot = False And power = False And numberRoot = False Then
            If isStoreDigit1 = False Then
                storeDigit1 = 2
                isStoreDigit1 = True
            ElseIf isStoreDigit2 = False Then
                storeDigit2 = 2
                isStoreDigit2 = True
            ElseIf isStoreDigit3 = False Then
                storeDigit3 = 2
                isStoreDigit3 = True
            ElseIf isStoreDigit4 = False Then
                storeDigit4 = 2
                isStoreDigit4 = True
            ElseIf isStoreDigit5 = False Then
                storeDigit5 = 2
                isStoreDigit5 = True
            ElseIf isStoreDigit6 = False Then
                storeDigit6 = 2
                isStoreDigit6 = True
            ElseIf isStoreDigit7 = False Then
                storeDigit7 = 2
                isStoreDigit7 = True
            ElseIf isStoreDigit8 = False Then
                storeDigit8 = 2
                isStoreDigit8 = True
            ElseIf isStoreDigit9 = False Then
                storeDigit9 = 2
                isStoreDigit9 = True
            ElseIf isStoreDigit0 = False Then
                storeDigit0 = 2
                isStoreDigit0 = True
            Else
                MessageBox.Show("Too many digits.")
            End If
        ElseIf addition = True Or subtraction = True Or multiplication = True Or division = True Or squaring = True Or sqrRoot = True Or power = True Or numberRoot = True Then
            If isNumDigit1 = False Then
                numDigit1 = 2
                isNumDigit1 = True
            ElseIf isNumDigit2 = False Then
                numDigit2 = 2
                isNumDigit2 = True
            ElseIf isNumDigit3 = False Then
                numDigit3 = 2
                isNumDigit3 = True
            ElseIf isNumDigit4 = False Then
                numDigit4 = 2
                isNumDigit4 = True
            ElseIf isNumDigit5 = False Then
                numDigit5 = 2
                isNumDigit5 = True
            ElseIf isNumDigit6 = False Then
                numDigit6 = 2
                isNumDigit6 = True
            ElseIf isNumDigit7 = False Then
                numDigit7 = 2
                isNumDigit7 = True
            ElseIf isNumDigit8 = False Then
                numDigit8 = 2
                isNumDigit8 = True
            ElseIf isNumDigit9 = False Then
                numDigit9 = 2
                isNumDigit9 = True
            ElseIf isNumDigit0 = False Then
                numDigit0 = 2
                isNumDigit0 = True
            Else
                MessageBox.Show("Too many digits.")
            End If
        End If
    End Sub

    Private Sub Three_Click(sender As Object, e As EventArgs) Handles Three.Click

        If decimalPress = False Then
            number *= 10
            number += 3
            TextBox1.Text = number
        ElseIf decimalPress = True Then
            decimalNumber += 1
            number += (3 / (Math.Pow(10, decimalNumber)))
            TextBox1.Text = Str(number)
        End If

        If addition = False And subtraction = False And multiplication = False And division = False And squaring = False And sqrRoot = False And power = False And numberRoot = False Then
            If isStoreDigit1 = False Then
                storeDigit1 = 3
                isStoreDigit1 = True
            ElseIf isStoreDigit2 = False Then
                storeDigit2 = 3
                isStoreDigit2 = True
            ElseIf isStoreDigit3 = False Then
                storeDigit3 = 3
                isStoreDigit3 = True
            ElseIf isStoreDigit4 = False Then
                storeDigit4 = 3
                isStoreDigit4 = True
            ElseIf isStoreDigit5 = False Then
                storeDigit5 = 3
                isStoreDigit5 = True
            ElseIf isStoreDigit6 = False Then
                storeDigit6 = 3
                isStoreDigit6 = True
            ElseIf isStoreDigit7 = False Then
                storeDigit7 = 3
                isStoreDigit7 = True
            ElseIf isStoreDigit8 = False Then
                storeDigit8 = 3
                isStoreDigit8 = True
            ElseIf isStoreDigit9 = False Then
                storeDigit9 = 3
                isStoreDigit9 = True
            ElseIf isStoreDigit0 = False Then
                storeDigit0 = 3
                isStoreDigit0 = True
            Else
                MessageBox.Show("Too many digits.")
            End If
        ElseIf addition = True Or subtraction = True Or multiplication = True Or division = True Or squaring = True Or sqrRoot = True Or power = True Or numberRoot = True Then
            If isNumDigit1 = False Then
                numDigit1 = 3
                isNumDigit1 = True
            ElseIf isNumDigit2 = False Then
                numDigit2 = 3
                isNumDigit2 = True
            ElseIf isNumDigit3 = False Then
                numDigit3 = 3
                isNumDigit3 = True
            ElseIf isNumDigit4 = False Then
                numDigit4 = 3
                isNumDigit4 = True
            ElseIf isNumDigit5 = False Then
                numDigit5 = 3
                isNumDigit5 = True
            ElseIf isNumDigit6 = False Then
                numDigit6 = 3
                isNumDigit6 = True
            ElseIf isNumDigit7 = False Then
                numDigit7 = 3
                isNumDigit7 = True
            ElseIf isNumDigit8 = False Then
                numDigit8 = 3
                isNumDigit8 = True
            ElseIf isNumDigit9 = False Then
                numDigit9 = 3
                isNumDigit9 = True
            ElseIf isNumDigit0 = False Then
                numDigit0 = 3
                isNumDigit0 = True
            Else
                MessageBox.Show("Too many digits.")
            End If
        End If
    End Sub

    Private Sub Four_Click(sender As Object, e As EventArgs) Handles Four.Click

        If decimalPress = False Then
            number *= 10
            number += 4
            TextBox1.Text = number
        ElseIf decimalPress = True Then
            decimalNumber += 1
            number += (4 / (Math.Pow(10, decimalNumber)))
            TextBox1.Text = Str(number)
        End If

        If addition = False And subtraction = False And multiplication = False And division = False And squaring = False And sqrRoot = False And power = False And numberRoot = False Then
            If isStoreDigit1 = False Then
                storeDigit1 = 4
                isStoreDigit1 = True
            ElseIf isStoreDigit2 = False Then
                storeDigit2 = 4
                isStoreDigit2 = True
            ElseIf isStoreDigit3 = False Then
                storeDigit3 = 4
                isStoreDigit3 = True
            ElseIf isStoreDigit4 = False Then
                storeDigit4 = 4
                isStoreDigit4 = True
            ElseIf isStoreDigit5 = False Then
                storeDigit5 = 4
                isStoreDigit5 = True
            ElseIf isStoreDigit6 = False Then
                storeDigit6 = 4
                isStoreDigit6 = True
            ElseIf isStoreDigit7 = False Then
                storeDigit7 = 4
                isStoreDigit7 = True
            ElseIf isStoreDigit8 = False Then
                storeDigit8 = 4
                isStoreDigit8 = True
            ElseIf isStoreDigit9 = False Then
                storeDigit9 = 4
                isStoreDigit9 = True
            ElseIf isStoreDigit0 = False Then
                storeDigit0 = 4
                isStoreDigit0 = True
            Else
                MessageBox.Show("Too many digits.")
            End If
        ElseIf addition = True Or subtraction = True Or multiplication = True Or division = True Or squaring = True Or sqrRoot = True Or power = True Or numberRoot = True Then
            If isNumDigit1 = False Then
                numDigit1 = 4
                isNumDigit1 = True
            ElseIf isNumDigit2 = False Then
                numDigit2 = 4
                isNumDigit2 = True
            ElseIf isNumDigit3 = False Then
                numDigit3 = 4
                isNumDigit3 = True
            ElseIf isNumDigit4 = False Then
                numDigit4 = 4
                isNumDigit4 = True
            ElseIf isNumDigit5 = False Then
                numDigit5 = 4
                isNumDigit5 = True
            ElseIf isNumDigit6 = False Then
                numDigit6 = 4
                isNumDigit6 = True
            ElseIf isNumDigit7 = False Then
                numDigit7 = 4
                isNumDigit7 = True
            ElseIf isNumDigit8 = False Then
                numDigit8 = 4
                isNumDigit8 = True
            ElseIf isNumDigit9 = False Then
                numDigit9 = 4
                isNumDigit9 = True
            ElseIf isNumDigit0 = False Then
                numDigit0 = 4
                isNumDigit0 = True
            Else
                MessageBox.Show("Too many digits.")
            End If
        End If
    End Sub

    Private Sub Five_Click(sender As Object, e As EventArgs) Handles Five.Click

        If decimalPress = False Then
            number *= 10
            number += 5
            TextBox1.Text = number
        ElseIf decimalPress = True Then
            decimalNumber += 1
            number += (5 / (Math.Pow(10, decimalNumber)))
            TextBox1.Text = Str(number)
        End If

        If addition = False And subtraction = False And multiplication = False And division = False And squaring = False And sqrRoot = False And power = False And numberRoot = False Then
            If isStoreDigit1 = False Then
                storeDigit1 = 5
                isStoreDigit1 = True
            ElseIf isStoreDigit2 = False Then
                storeDigit2 = 5
                isStoreDigit2 = True
            ElseIf isStoreDigit3 = False Then
                storeDigit3 = 5
                isStoreDigit3 = True
            ElseIf isStoreDigit4 = False Then
                storeDigit4 = 5
                isStoreDigit4 = True
            ElseIf isStoreDigit5 = False Then
                storeDigit5 = 5
                isStoreDigit5 = True
            ElseIf isStoreDigit6 = False Then
                storeDigit6 = 5
                isStoreDigit6 = True
            ElseIf isStoreDigit7 = False Then
                storeDigit7 = 5
                isStoreDigit7 = True
            ElseIf isStoreDigit8 = False Then
                storeDigit8 = 5
                isStoreDigit8 = True
            ElseIf isStoreDigit9 = False Then
                storeDigit9 = 5
                isStoreDigit9 = True
            ElseIf isStoreDigit0 = False Then
                storeDigit0 = 5
                isStoreDigit0 = True
            Else
                MessageBox.Show("Too many digits.")
            End If
        ElseIf addition = True Or subtraction = True Or multiplication = True Or division = True Or squaring = True Or sqrRoot = True Or power = True Or numberRoot = True Then
            If isNumDigit1 = False Then
                numDigit1 = 5
                isNumDigit1 = True
            ElseIf isNumDigit2 = False Then
                numDigit2 = 5
                isNumDigit2 = True
            ElseIf isNumDigit3 = False Then
                numDigit3 = 5
                isNumDigit3 = True
            ElseIf isNumDigit4 = False Then
                numDigit4 = 5
                isNumDigit4 = True
            ElseIf isNumDigit5 = False Then
                numDigit5 = 5
                isNumDigit5 = True
            ElseIf isNumDigit6 = False Then
                numDigit6 = 5
                isNumDigit6 = True
            ElseIf isNumDigit7 = False Then
                numDigit7 = 5
                isNumDigit7 = True
            ElseIf isNumDigit8 = False Then
                numDigit8 = 5
                isNumDigit8 = True
            ElseIf isNumDigit9 = False Then
                numDigit9 = 5
                isNumDigit9 = True
            ElseIf isNumDigit0 = False Then
                numDigit0 = 5
                isNumDigit0 = True
            Else
                MessageBox.Show("Too many digits.")
            End If
        End If
    End Sub

    Private Sub Six_Click(sender As Object, e As EventArgs) Handles Six.Click

        If decimalPress = False Then
            number *= 10
            number += 6
            TextBox1.Text = number
        ElseIf decimalPress = True Then
            decimalNumber += 1
            number += (6 / (Math.Pow(10, decimalNumber)))
            TextBox1.Text = Str(number)
        End If

        If addition = False And subtraction = False And multiplication = False And division = False And squaring = False And sqrRoot = False And power = False And numberRoot = False Then
            If isStoreDigit1 = False Then
                storeDigit1 = 6
                isStoreDigit1 = True
            ElseIf isStoreDigit2 = False Then
                storeDigit2 = 6
                isStoreDigit2 = True
            ElseIf isStoreDigit3 = False Then
                storeDigit3 = 6
                isStoreDigit3 = True
            ElseIf isStoreDigit4 = False Then
                storeDigit4 = 6
                isStoreDigit4 = True
            ElseIf isStoreDigit5 = False Then
                storeDigit5 = 6
                isStoreDigit5 = True
            ElseIf isStoreDigit6 = False Then
                storeDigit6 = 6
                isStoreDigit6 = True
            ElseIf isStoreDigit7 = False Then
                storeDigit7 = 6
                isStoreDigit7 = True
            ElseIf isStoreDigit8 = False Then
                storeDigit8 = 6
                isStoreDigit8 = True
            ElseIf isStoreDigit9 = False Then
                storeDigit9 = 6
                isStoreDigit9 = True
            ElseIf isStoreDigit0 = False Then
                storeDigit0 = 6
                isStoreDigit0 = True
            Else
                MessageBox.Show("Too many digits.")
            End If
        ElseIf addition = True Or subtraction = True Or multiplication = True Or division = True Or squaring = True Or sqrRoot = True Or power = True Or numberRoot = True Then
            If isNumDigit1 = False Then
                numDigit1 = 6
                isNumDigit1 = True
            ElseIf isNumDigit2 = False Then
                numDigit2 = 6
                isNumDigit2 = True
            ElseIf isNumDigit3 = False Then
                numDigit3 = 6
                isNumDigit3 = True
            ElseIf isNumDigit4 = False Then
                numDigit4 = 6
                isNumDigit4 = True
            ElseIf isNumDigit5 = False Then
                numDigit5 = 6
                isNumDigit5 = True
            ElseIf isNumDigit6 = False Then
                numDigit6 = 6
                isNumDigit6 = True
            ElseIf isNumDigit7 = False Then
                numDigit7 = 6
                isNumDigit7 = True
            ElseIf isNumDigit8 = False Then
                numDigit8 = 6
                isNumDigit8 = True
            ElseIf isNumDigit9 = False Then
                numDigit9 = 6
                isNumDigit9 = True
            ElseIf isNumDigit0 = False Then
                numDigit0 = 6
                isNumDigit0 = True
            Else
                MessageBox.Show("Too many digits.")
            End If
        End If
    End Sub

    Private Sub Seven_Click(sender As Object, e As EventArgs) Handles Seven.Click

        If decimalPress = False Then
            number *= 10
            number += 7
            TextBox1.Text = number
        ElseIf decimalPress = True Then
            decimalNumber += 1
            number += (7 / (Math.Pow(10, decimalNumber)))
            TextBox1.Text = Str(number)
        End If

        If addition = False And subtraction = False And multiplication = False And division = False And squaring = False And sqrRoot = False And power = False And numberRoot = False Then
            If isStoreDigit1 = False Then
                storeDigit1 = 7
                isStoreDigit1 = True
            ElseIf isStoreDigit2 = False Then
                storeDigit2 = 7
                isStoreDigit2 = True
            ElseIf isStoreDigit3 = False Then
                storeDigit3 = 7
                isStoreDigit3 = True
            ElseIf isStoreDigit4 = False Then
                storeDigit4 = 7
                isStoreDigit4 = True
            ElseIf isStoreDigit5 = False Then
                storeDigit5 = 7
                isStoreDigit5 = True
            ElseIf isStoreDigit6 = False Then
                storeDigit6 = 7
                isStoreDigit6 = True
            ElseIf isStoreDigit7 = False Then
                storeDigit7 = 7
                isStoreDigit7 = True
            ElseIf isStoreDigit8 = False Then
                storeDigit8 = 7
                isStoreDigit8 = True
            ElseIf isStoreDigit9 = False Then
                storeDigit9 = 7
                isStoreDigit9 = True
            ElseIf isStoreDigit0 = False Then
                storeDigit0 = 7
                isStoreDigit0 = True
            Else
                MessageBox.Show("Too many digits.")
            End If
        ElseIf addition = True Or subtraction = True Or multiplication = True Or division = True Or squaring = True Or sqrRoot = True Or power = True Or numberRoot = True Then
            If isNumDigit1 = False Then
                numDigit1 = 7
                isNumDigit1 = True
            ElseIf isNumDigit2 = False Then
                numDigit2 = 7
                isNumDigit2 = True
            ElseIf isNumDigit3 = False Then
                numDigit3 = 7
                isNumDigit3 = True
            ElseIf isNumDigit4 = False Then
                numDigit4 = 7
                isNumDigit4 = True
            ElseIf isNumDigit5 = False Then
                numDigit5 = 7
                isNumDigit5 = True
            ElseIf isNumDigit6 = False Then
                numDigit6 = 7
                isNumDigit6 = True
            ElseIf isNumDigit7 = False Then
                numDigit7 = 7
                isNumDigit7 = True
            ElseIf isNumDigit8 = False Then
                numDigit8 = 7
                isNumDigit8 = True
            ElseIf isNumDigit9 = False Then
                numDigit9 = 7
                isNumDigit9 = True
            ElseIf isNumDigit0 = False Then
                numDigit0 = 7
                isNumDigit0 = True
            Else
                MessageBox.Show("Too many digits.")
            End If
        End If
    End Sub

    Private Sub Eight_Click(sender As Object, e As EventArgs) Handles Eight.Click

        If decimalPress = False Then
            number *= 10
            number += 8
            TextBox1.Text = number
        ElseIf decimalPress = True Then
            decimalNumber += 1
            number += (8 / (Math.Pow(10, decimalNumber)))
            TextBox1.Text = Str(number)
        End If

        If addition = False And subtraction = False And multiplication = False And division = False And squaring = False And sqrRoot = False And power = False And numberRoot = False Then
            If isStoreDigit1 = False Then
                storeDigit1 = 8
                isStoreDigit1 = True
            ElseIf isStoreDigit2 = False Then
                storeDigit2 = 8
                isStoreDigit2 = True
            ElseIf isStoreDigit3 = False Then
                storeDigit3 = 8
                isStoreDigit3 = True
            ElseIf isStoreDigit4 = False Then
                storeDigit4 = 8
                isStoreDigit4 = True
            ElseIf isStoreDigit5 = False Then
                storeDigit5 = 8
                isStoreDigit5 = True
            ElseIf isStoreDigit6 = False Then
                storeDigit6 = 8
                isStoreDigit6 = True
            ElseIf isStoreDigit7 = False Then
                storeDigit7 = 8
                isStoreDigit7 = True
            ElseIf isStoreDigit8 = False Then
                storeDigit8 = 8
                isStoreDigit8 = True
            ElseIf isStoreDigit9 = False Then
                storeDigit9 = 8
                isStoreDigit9 = True
            ElseIf isStoreDigit0 = False Then
                storeDigit0 = 8
                isStoreDigit0 = True
            Else
                MessageBox.Show("Too many digits.")
            End If
        ElseIf addition = True Or subtraction = True Or multiplication = True Or division = True Or squaring = True Or sqrRoot = True Or power = True Or numberRoot = True Then
            If isNumDigit1 = False Then
                numDigit1 = 8
                isNumDigit1 = True
            ElseIf isNumDigit2 = False Then
                numDigit2 = 8
                isNumDigit2 = True
            ElseIf isNumDigit3 = False Then
                numDigit3 = 8
                isNumDigit3 = True
            ElseIf isNumDigit4 = False Then
                numDigit4 = 8
                isNumDigit4 = True
            ElseIf isNumDigit5 = False Then
                numDigit5 = 8
                isNumDigit5 = True
            ElseIf isNumDigit6 = False Then
                numDigit6 = 8
                isNumDigit6 = True
            ElseIf isNumDigit7 = False Then
                numDigit7 = 8
                isNumDigit7 = True
            ElseIf isNumDigit8 = False Then
                numDigit8 = 8
                isNumDigit8 = True
            ElseIf isNumDigit9 = False Then
                numDigit9 = 8
                isNumDigit9 = True
            ElseIf isNumDigit0 = False Then
                numDigit0 = 8
                isNumDigit0 = True
            Else
                MessageBox.Show("Too many digits.")
            End If
        End If
    End Sub

    Private Sub Nine_Click(sender As Object, e As EventArgs) Handles Nine.Click

        If decimalPress = False Then
            number *= 10
            number += 9
            TextBox1.Text = number
        ElseIf decimalPress = True Then
            decimalNumber += 1
            number += (9 / (Math.Pow(10, decimalNumber)))
            TextBox1.Text = Str(number)
        End If

        If addition = False And subtraction = False And multiplication = False And division = False And squaring = False And sqrRoot = False And power = False And numberRoot = False Then
            If isStoreDigit1 = False Then
                storeDigit1 = 9
                isStoreDigit1 = True
            ElseIf isStoreDigit2 = False Then
                storeDigit2 = 9
                isStoreDigit2 = True
            ElseIf isStoreDigit3 = False Then
                storeDigit3 = 9
                isStoreDigit3 = True
            ElseIf isStoreDigit4 = False Then
                storeDigit4 = 9
                isStoreDigit4 = True
            ElseIf isStoreDigit5 = False Then
                storeDigit5 = 9
                isStoreDigit5 = True
            ElseIf isStoreDigit6 = False Then
                storeDigit6 = 9
                isStoreDigit6 = True
            ElseIf isStoreDigit7 = False Then
                storeDigit7 = 9
                isStoreDigit7 = True
            ElseIf isStoreDigit8 = False Then
                storeDigit8 = 9
                isStoreDigit8 = True
            ElseIf isStoreDigit9 = False Then
                storeDigit9 = 9
                isStoreDigit9 = True
            ElseIf isStoreDigit0 = False Then
                storeDigit0 = 9
                isStoreDigit0 = True
            Else
                MessageBox.Show("Too many digits.")
            End If
        ElseIf addition = True Or subtraction = True Or multiplication = True Or division = True Or squaring = True Or sqrRoot = True Or power = True Or numberRoot = True Then
            If isNumDigit1 = False Then
                numDigit1 = 9
                isNumDigit1 = True
            ElseIf isNumDigit2 = False Then
                numDigit2 = 9
                isNumDigit2 = True
            ElseIf isNumDigit3 = False Then
                numDigit3 = 9
                isNumDigit3 = True
            ElseIf isNumDigit4 = False Then
                numDigit4 = 9
                isNumDigit4 = True
            ElseIf isNumDigit5 = False Then
                numDigit5 = 9
                isNumDigit5 = True
            ElseIf isNumDigit6 = False Then
                numDigit6 = 9
                isNumDigit6 = True
            ElseIf isNumDigit7 = False Then
                numDigit7 = 9
                isNumDigit7 = True
            ElseIf isNumDigit8 = False Then
                numDigit8 = 9
                isNumDigit8 = True
            ElseIf isNumDigit9 = False Then
                numDigit9 = 9
                isNumDigit9 = True
            ElseIf isNumDigit0 = False Then
                numDigit0 = 9
                isNumDigit0 = True
            Else
                MessageBox.Show("Too many digits.")
            End If
        End If
    End Sub

    Private Sub Zero_Click(sender As Object, e As EventArgs) Handles Zero.Click

        If decimalPress = False Then
            number *= 10
            TextBox1.Text = number
        ElseIf decimalPress = True Then
            decimalNumber += 1
            number += (0 / (Math.Pow(10, decimalNumber)))
            TextBox1.Text += "0"
        End If

        If addition = False And subtraction = False And multiplication = False And division = False And squaring = False And sqrRoot = False And power = False And numberRoot = False Then
            If isStoreDigit1 = False Then
                storeDigit1 = 0
                isStoreDigit1 = True
            ElseIf isStoreDigit2 = False Then
                storeDigit2 = 0
                isStoreDigit2 = True
            ElseIf isStoreDigit3 = False Then
                storeDigit3 = 0
                isStoreDigit3 = True
            ElseIf isStoreDigit4 = False Then
                storeDigit4 = 0
                isStoreDigit4 = True
            ElseIf isStoreDigit5 = False Then
                storeDigit5 = 0
                isStoreDigit5 = True
            ElseIf isStoreDigit6 = False Then
                storeDigit6 = 0
                isStoreDigit6 = True
            ElseIf isStoreDigit7 = False Then
                storeDigit7 = 0
                isStoreDigit7 = True
            ElseIf isStoreDigit8 = False Then
                storeDigit8 = 0
                isStoreDigit8 = True
            ElseIf isStoreDigit9 = False Then
                storeDigit9 = 0
                isStoreDigit9 = True
            ElseIf isStoreDigit0 = False Then
                storeDigit0 = 0
                isStoreDigit0 = True
            Else
                MessageBox.Show("Too many digits.")
            End If
        ElseIf addition = True Or subtraction = True Or multiplication = True Or division = True Or squaring = True Or sqrRoot = True Or power = True Or numberRoot = True Then
            If isNumDigit1 = False Then
                numDigit1 = 0
                isNumDigit1 = True
            ElseIf isNumDigit2 = False Then
                numDigit2 = 0
                isNumDigit2 = True
            ElseIf isNumDigit3 = False Then
                numDigit3 = 0
                isNumDigit3 = True
            ElseIf isNumDigit4 = False Then
                numDigit4 = 0
                isNumDigit4 = True
            ElseIf isNumDigit5 = False Then
                numDigit5 = 0
                isNumDigit5 = True
            ElseIf isNumDigit6 = False Then
                numDigit6 = 0
                isNumDigit6 = True
            ElseIf isNumDigit7 = False Then
                numDigit7 = 0
                isNumDigit7 = True
            ElseIf isNumDigit8 = False Then
                numDigit8 = 0
                isNumDigit8 = True
            ElseIf isNumDigit9 = False Then
                numDigit9 = 0
                isNumDigit9 = True
            ElseIf isNumDigit0 = False Then
                numDigit0 = 0
                isNumDigit0 = True
            Else
                MessageBox.Show("Too many digits.")
            End If
        End If
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        number = 0
        store = 0
        displayed = 0
        TextBox1.Text = number
        TextBox2.Text = "0"

        addition = False
        subtraction = False
        multiplication = False
        division = False
        squaring = False
        sqrRoot = False
        power = False
        numberRoot = False
        decimalPress = False

        numDigit1 = 0
        numDigit2 = 0
        numDigit3 = 0
        numDigit4 = 0
        numDigit5 = 0
        numDigit6 = 0
        numDigit7 = 0
        numDigit8 = 0
        numDigit9 = 0
        numDigit0 = 0

        storeDigit1 = 0
        storeDigit2 = 0
        storeDigit3 = 0
        storeDigit4 = 0
        storeDigit5 = 0
        storeDigit6 = 0
        storeDigit7 = 0
        storeDigit8 = 0
        storeDigit9 = 0
        storeDigit0 = 0

        isNumDigit1 = False
        isNumDigit2 = False
        isNumDigit3 = False
        isNumDigit4 = False
        isNumDigit5 = False
        isNumDigit6 = False
        isNumDigit7 = False
        isNumDigit8 = False
        isNumDigit9 = False
        isNumDigit0 = False

        isStoreDigit1 = False
        isStoreDigit2 = False
        isStoreDigit3 = False
        isStoreDigit4 = False
        isStoreDigit5 = False
        isStoreDigit6 = False
        isStoreDigit7 = False
        isStoreDigit8 = False
        isStoreDigit9 = False
        isStoreDigit0 = False

        decimalNumber = 0

    End Sub

    Private Sub Backspace_Click(sender As Object, e As EventArgs) Handles Backspace.Click
        If decimalPress = False Then
            If isNumDigit0 = True Then
                number -= numDigit0
                number /= 10
                numDigit0 = 0
                isNumDigit0 = False
            ElseIf isNumDigit9 = True Then
                number -= numDigit9
                number /= 10
                numDigit9 = 0
                isNumDigit9 = False
            ElseIf isNumDigit8 = True Then
                number -= numDigit8
                number /= 10
                numDigit8 = 0
                isNumDigit8 = False
            ElseIf isNumDigit7 = True Then
                number -= numDigit7
                number /= 10
                numDigit7 = 0
                isNumDigit7 = False
            ElseIf isNumDigit6 = True Then
                number -= numDigit6
                number /= 10
                numDigit6 = 0
                isNumDigit6 = False
            ElseIf isNumDigit5 = True Then
                number -= numDigit5
                number /= 10
                numDigit5 = 0
                isNumDigit5 = False
            ElseIf isNumDigit4 = True Then
                number -= numDigit4
                number /= 10
                numDigit4 = 0
                isNumDigit4 = False
            ElseIf isNumDigit3 = True Then
                number -= numDigit3
                number /= 10
                numDigit3 = 0
                isNumDigit3 = False
            ElseIf isNumDigit2 = True Then
                number -= numDigit2
                number /= 10
                numDigit2 = 0
                isNumDigit2 = False
            ElseIf isNumDigit1 = True Then
                number -= numDigit1
                number /= 10
                numDigit1 = 0
                isNumDigit1 = False
            ElseIf isStoreDigit0 = True Then
                number -= storeDigit0
                number /= 10
                storeDigit0 = 0
                isStoreDigit0 = False
            ElseIf isStoreDigit9 = True Then
                number -= storeDigit9
                number /= 10
                storeDigit9 = 0
                isStoreDigit9 = False
            ElseIf isStoreDigit8 = True Then
                number -= storeDigit8
                number /= 10
                storeDigit8 = 0
                isStoreDigit8 = False
            ElseIf isStoreDigit7 = True Then
                number -= storeDigit7
                number /= 10
                storeDigit7 = 0
                isStoreDigit7 = False
            ElseIf isStoreDigit6 = True Then
                number -= storeDigit6
                number /= 10
                storeDigit6 = 0
                isStoreDigit6 = False
            ElseIf isStoreDigit5 = True Then
                number -= storeDigit5
                number /= 10
                storeDigit5 = 0
                isStoreDigit5 = False
            ElseIf isStoreDigit4 = True Then
                number -= storeDigit4
                number /= 10
                storeDigit4 = 0
                isStoreDigit4 = False
            ElseIf isStoreDigit3 = True Then
                number -= storeDigit3
                number /= 10
                storeDigit3 = 0
                isStoreDigit3 = False
            ElseIf isStoreDigit2 = True Then
                number -= storeDigit2
                number /= 10
                storeDigit2 = 0
                isStoreDigit2 = False
            ElseIf isStoreDigit1 = True Then
                number -= storeDigit1
                number /= 10
                storeDigit1 = 0
                isStoreDigit1 = False
            End If
        ElseIf decimalPress = True Then
            If isNumDigit0 = True Then
                number -= (numDigit0 / (Math.Pow(10, decimalNumber)))
                numDigit0 = 0
                isNumDigit0 = False
                decimalNumber -= 1
            ElseIf isNumDigit9 = True Then
                number -= (numDigit9 / (Math.Pow(10, decimalNumber)))
                numDigit9 = 0
                isNumDigit9 = False
                decimalNumber -= 1
            ElseIf isNumDigit8 = True Then
                number -= (numDigit8 / (Math.Pow(10, decimalNumber)))
                numDigit8 = 0
                isNumDigit8 = False
                decimalNumber -= 1
            ElseIf isNumDigit7 = True Then
                number -= (numDigit7 / (Math.Pow(10, decimalNumber)))
                numDigit7 = 0
                isNumDigit7 = False
                decimalNumber -= 1
            ElseIf isNumDigit6 = True Then
                number -= (numDigit6 / (Math.Pow(10, decimalNumber)))
                numDigit6 = 0
                isNumDigit6 = False
                decimalNumber -= 1
            ElseIf isNumDigit5 = True Then
                number -= (numDigit5 / (Math.Pow(10, decimalNumber)))
                numDigit5 = 0
                isNumDigit5 = False
                decimalNumber -= 1
            ElseIf isNumDigit4 = True Then
                number -= (numDigit4 / (Math.Pow(10, decimalNumber)))
                numDigit4 = 0
                isNumDigit4 = False
                decimalNumber -= 1
            ElseIf isNumDigit3 = True Then
                number -= (numDigit3 / (Math.Pow(10, decimalNumber)))
                numDigit3 = 0
                isNumDigit3 = False
                decimalNumber -= 1
            ElseIf isNumDigit2 = True Then
                number -= (numDigit2 / (Math.Pow(10, decimalNumber)))
                numDigit2 = 0
                isNumDigit2 = False
                decimalNumber -= 1
            ElseIf isNumDigit1 = True Then
                number -= (numDigit1 / (Math.Pow(10, decimalNumber)))
                numDigit1 = 0
                isNumDigit1 = False
                decimalNumber -= 1
            ElseIf isStoreDigit0 = True Then
                number -= (storeDigit0 / (Math.Pow(10, decimalNumber)))
                storeDigit0 = 0
                isStoreDigit0 = False
                decimalNumber -= 1
            ElseIf isStoreDigit9 = True Then
                number -= (storeDigit9 / (Math.Pow(10, decimalNumber)))
                storeDigit9 = 0
                isStoreDigit9 = False
                decimalNumber -= 1
            ElseIf isStoreDigit8 = True Then
                number -= (storeDigit8 / (Math.Pow(10, decimalNumber)))
                storeDigit8 = 0
                isStoreDigit8 = False
                decimalNumber -= 1
            ElseIf isStoreDigit7 = True Then
                number -= (storeDigit7 / (Math.Pow(10, decimalNumber)))
                storeDigit7 = 0
                isStoreDigit7 = False
                decimalNumber -= 1
            ElseIf isStoreDigit6 = True Then
                number -= (storeDigit6 / (Math.Pow(10, decimalNumber)))
                storeDigit6 = 0
                isStoreDigit6 = False
                decimalNumber -= 1
            ElseIf isStoreDigit5 = True Then
                number -= (storeDigit5 / (Math.Pow(10, decimalNumber)))
                storeDigit5 = 0
                isStoreDigit5 = False
                decimalNumber -= 1
            ElseIf isStoreDigit4 = True Then
                number -= (storeDigit4 / (Math.Pow(10, decimalNumber)))
                storeDigit4 = 0
                isStoreDigit4 = False
                decimalNumber -= 1
            ElseIf isStoreDigit3 = True Then
                number -= (storeDigit3 / (Math.Pow(10, decimalNumber)))
                storeDigit3 = 0
                isStoreDigit3 = False
                decimalNumber -= 1
            ElseIf isStoreDigit2 = True Then
                number -= (storeDigit2 / (Math.Pow(10, decimalNumber)))
                storeDigit2 = 0
                isStoreDigit2 = False
                decimalNumber -= 1
            ElseIf isStoreDigit1 = True Then
                number -= (storeDigit1 / (Math.Pow(10, decimalNumber)))
                storeDigit1 = 0
                isStoreDigit1 = False
                decimalNumber -= 1
            End If
        End If

        TextBox1.Text = Str(number)
    End Sub

    Private Sub Plus_Click(sender As Object, e As EventArgs) Handles Plus.Click
        store = number
        TextBox2.Text = Str(store) + " +"
        number = 0
        TextBox1.Text = Str(number)
        addition = True
        decimalPress = False
        decimalNumber = 0
    End Sub

    Private Sub Minus_Click(sender As Object, e As EventArgs) Handles Minus.Click
        store = number
        TextBox2.Text = Str(store) + " -"
        number = 0
        TextBox1.Text = Str(number)
        subtraction = True
        decimalPress = False
        decimalNumber = 0
    End Sub

    Private Sub Multiply_Click(sender As Object, e As EventArgs) Handles Multiply.Click
        store = number
        TextBox2.Text = Str(store) + " *"
        number = 0
        TextBox1.Text = Str(number)
        multiplication = True
        decimalPress = False
        decimalNumber = 0
    End Sub

    Private Sub Divide_Click(sender As Object, e As EventArgs) Handles Divide.Click
        store = number
        TextBox2.Text = Str(store) + " /"
        number = 0
        TextBox1.Text = Str(number)
        division = True
        decimalPress = False
        decimalNumber = 0
    End Sub

    Private Sub Solve_Click(sender As Object, e As EventArgs) Handles Solve.Click

        If addition = True Then
            displayed = store + number
            TextBox1.Text = Str(displayed)
            TextBox2.Text = Str(store) + " + " + Str(number) + " ="
            number = 0
            store = 0
        ElseIf subtraction = True Then
            displayed = store - number
            TextBox1.Text = Str(displayed)
            TextBox2.Text = Str(store) + " - " + Str(number) + " ="
            number = 0
            store = 0
        ElseIf multiplication = True Then
            displayed = store * number
            TextBox1.Text = Str(displayed)
            TextBox2.Text = Str(store) + " * " + Str(number) + " ="
            number = 0
            store = 0
        ElseIf division = True Then
            displayed = store / number
            TextBox1.Text = Str(displayed)
            TextBox2.Text = Str(store) + " / " + Str(number) + " ="
            number = 0
            store = 0
        ElseIf squaring = True Then
            store *= store
            displayed = store
            TextBox1.Text = Str(displayed)
            TextBox2.Text += " ="
            number = 0
            store = 0
        ElseIf sqrRoot = True Then
            store = Math.Sqrt(store)
            displayed = store
            TextBox1.Text = Str(displayed)
            TextBox2.Text += " ="
            number = 0
            store = 0
        ElseIf power = True Then
            displayed = Math.Pow(store, number)
            TextBox1.Text = Str(displayed)
            TextBox2.Text += " " + Str(number) + " ="
            number = 0
            store = 0
        ElseIf numberRoot = True Then
            displayed = Math.Pow(number, (1 / store))
            TextBox1.Text = Str(displayed)
            TextBox2.Text += Str(number) + " ="
            number = 0
            store = 0
        End If

        addition = False
        subtraction = False
        multiplication = False
        division = False
        squaring = False
        sqrRoot = False
        power = False
        numberRoot = False
        decimalPress = False

        numDigit1 = 0
        numDigit2 = 0
        numDigit3 = 0
        numDigit4 = 0
        numDigit5 = 0
        numDigit6 = 0
        numDigit7 = 0
        numDigit8 = 0
        numDigit9 = 0
        numDigit0 = 0

        storeDigit1 = 0
        storeDigit2 = 0
        storeDigit3 = 0
        storeDigit4 = 0
        storeDigit5 = 0
        storeDigit6 = 0
        storeDigit7 = 0
        storeDigit8 = 0
        storeDigit9 = 0
        storeDigit0 = 0

        isNumDigit1 = False
        isNumDigit2 = False
        isNumDigit3 = False
        isNumDigit4 = False
        isNumDigit5 = False
        isNumDigit6 = False
        isNumDigit7 = False
        isNumDigit8 = False
        isNumDigit9 = False
        isNumDigit0 = False

        isStoreDigit1 = False
        isStoreDigit2 = False
        isStoreDigit3 = False
        isStoreDigit4 = False
        isStoreDigit5 = False
        isStoreDigit6 = False
        isStoreDigit7 = False
        isStoreDigit8 = False
        isStoreDigit9 = False
        isStoreDigit0 = False

        decimalNumber = 0
    End Sub

    Private Sub Negative_Click(sender As Object, e As EventArgs) Handles Negative.Click

        number *= -1
        TextBox1.Text = Str(number)

    End Sub

    Private Sub Square_Click(sender As Object, e As EventArgs) Handles Square.Click
        store = number
        TextBox2.Text = Str(store) + " ^2"
        number = 0
        TextBox1.Text = Str(number)
        squaring = True
        decimalPress = False
        decimalNumber = 0
    End Sub

    Private Sub SquareRoot_Click(sender As Object, e As EventArgs) Handles SquareRoot.Click
        store = number
        TextBox2.Text = "√" + Str(store)
        number = 0
        TextBox1.Text = Str(number)
        sqrRoot = True
        decimalPress = False
        decimalNumber = 0
    End Sub

    Private Sub Exponent_Click(sender As Object, e As EventArgs) Handles Exponent.Click
        store = number
        TextBox2.Text = Str(store) + " ^"
        number = 0
        TextBox1.Text = Str(number)
        power = True
        decimalPress = False
        decimalNumber = 0
    End Sub

    Private Sub Roots_Click(sender As Object, e As EventArgs) Handles Roots.Click
        store = number
        TextBox2.Text = Str(store) + "√"
        number = 0
        TextBox1.Text = Str(number)
        numberRoot = True
        decimalPress = False
        decimalNumber = 0
    End Sub

    Private Sub Point_Click(sender As Object, e As EventArgs) Handles Point.Click

        decimalPress = True

        TextBox1.Text += "."
    End Sub
End Class