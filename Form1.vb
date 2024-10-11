Imports System.Threading
Imports System.Windows.Forms.VisualStyles
Imports Windows.Win32

Public Class Form1
    Private Sub convertBtn_Click(sender As Object, e As EventArgs) Handles convertBtn.Click
        Try
            Dim userDigit As Single = Single.Parse(userInputBox.Text)
            If userDigit Then
                Dim finalValue As Single = 0
                Dim dollarValue As Single = 0
                Dim cedisValue As Single = 0
                Dim poundValue As Single = 0
                Dim euroValue As Single = 0
                Dim shilingsValue As Single = 0

                Select Case currencyMenuBox.SelectedItem.ToString()
                    Case "Dollar"
                        dollarValue = userDigit
                    Case "Cedis"
                        cedisValue = userDigit
                    Case "Pound"
                        poundValue = userDigit
                    Case "Euro"
                        euroValue = userDigit
                    Case "Shilings"
                        shilingsValue = userDigit
                    Case Else
                        errorLabel.Text = "Please Select a currency"
                        Exit Sub
                End Select
                Select Case unitMenuBox.SelectedItem.ToString()
                    Case "Dollar"
                        If dollarValue Then
                            finalValue = dollarValue * 1

                        ElseIf cedisValue Then
                            finalValue = cedisValue * 0.06

                        ElseIf poundValue Then
                            finalValue = poundValue * 1.30789

                        ElseIf euroValue Then

                            finalValue = euroValue * 1.09

                        ElseIf shilingsValue Then
                            finalValue = shilingsValue * 0.00769

                        Else
                            Dim invaildinputValue As Integer = 0
                            currencyDisplayBox.Text = invaildinputValue.ToString()
                        End If
                    Case "Cedis"
                        If dollarValue Then
                            finalValue = dollarValue * 15.99

                        ElseIf cedisValue Then
                            finalValue = cedisValue * 1

                        ElseIf poundValue Then
                            finalValue = poundValue * 20.7992

                        ElseIf euroValue Then
                            finalValue = euroValue * 17.33

                        ElseIf shilingsValue Then
                            finalValue = shilingsValue * 0.12223
                        Else
                            Dim invaildinputValue As Integer = 0
                            currencyDisplayBox.Text = invaildinputValue.ToString()
                        End If
                    Case "Pound"
                        If dollarValue Then
                            finalValue = dollarValue * 0.76447
                        ElseIf cedisValue Then
                            finalValue = cedisValue * 0.04796
                        ElseIf poundValue Then
                            finalValue = poundValue * 1
                        ElseIf euroValue Then
                            finalValue = euroValue * 0.84
                        ElseIf shilingsValue Then
                            finalValue = shilingsValue * 0.00588
                        Else
                            Dim invaildinputValue As Integer = 0
                            currencyDisplayBox.Text = invaildinputValue.ToString()
                        End If
                    Case "Euro"
                        If dollarValue Then
                            finalValue = dollarValue * 0.9127
                        ElseIf cedisValue Then
                            finalValue = cedisValue * 0.06
                        ElseIf poundValue Then
                            finalValue = poundValue * 1.19377
                        ElseIf euroValue Then
                            finalValue = euroValue * 1
                        ElseIf shilingsValue Then
                            finalValue = shilingsValue * 0.00702
                        Else
                            Dim invaildinputValue As Integer = 0
                            currencyDisplayBox.Text = invaildinputValue.ToString()
                        End If
                    Case "Shilings"
                        If dollarValue Then
                            finalValue = dollarValue * 127.938
                        ElseIf cedisValue Then
                            finalValue = cedisValue * 8.02613
                        ElseIf poundValue Then
                            finalValue = poundValue * 167.329
                        ElseIf euroValue Then
                            finalValue = euroValue * 140.156
                        ElseIf shilingsValue Then
                            finalValue = shilingsValue * 1
                        Else
                            Dim invaildinputValue As Integer = 0
                            currencyDisplayBox.Text = invaildinputValue.ToString()
                        End If
                    Case Else
                        MessageBox.Show("Please select a unit of conversion")
                        Exit Sub
                End Select
                currencyDisplayBox.Text = "0"
                currencyDisplayBox.Text = finalValue.ToString()
            Else
                MessageBox.Show("Please enter a vaild number")
            End If
        Catch ex As Exception
            errorLabel.Text = "Try again..."
        End Try
    End Sub
End Class
