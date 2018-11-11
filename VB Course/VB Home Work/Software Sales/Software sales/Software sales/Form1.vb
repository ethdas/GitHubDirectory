'The purpose of this to calculate and display the amount sold per package and Grand total amount 
'by collecting number of units sold per package 

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblInstruction.Text = " Please enter number of units sold 
for each software package below"



    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        ' Declare variables to hold the values entered into the text boxes 
        'Data type was unsigned integer on purpose to prevent negative values
        Dim UintQuPackageA As UInteger
        Dim UintQuPackageB As UInteger
        Dim UintQuPackageC As UInteger

        'Variables to hold the retail prices and the discount
        Dim DecRetailPrice As Decimal
        Dim DecDiscount As Decimal

        ' Variables to hold the calculated totals of each packages
        Dim DecTotalA As Decimal
        Dim DecTotalB As Decimal
        Dim DecTotalC As Decimal
        Dim DecGrandTotal As Decimal


        'Input validation txtPackageA
        If UInteger.TryParse(txtPackageA.Text, UintQuPackageA) Then


            'Assign Retail price based on package 
            If UintQuPackageA Then
                DecRetailPrice = 99

                'Assign Discount based on quantity
                Select Case UintQuPackageA
                    Case 10 To 19
                        DecDiscount = 0.2

                    Case 20 To 49
                        DecDiscount = 0.3

                    Case 50 To 99
                        DecDiscount = 0.4
                    Case Is >= 100
                        DecDiscount = 0.5
                End Select
                'Calculate total for package A
                DecTotalA = UintQuPackageA * (DecRetailPrice - (DecDiscount * DecRetailPrice))

            End If

        End If


        'Input validation txtPackageB
        If UInteger.TryParse(txtPackageB.Text, UintQuPackageB) Then

            'Assign Retail price based on package 
            If UintQuPackageB Then
                DecRetailPrice = 199

                'Assign Discount based on quantity
                Select Case UintQuPackageB
                    Case 10 To 19
                        DecDiscount = 0.2
                    Case 20 To 49
                        DecDiscount = 0.3
                    Case 50 To 99
                        DecDiscount = 0.4
                    Case Is >= 100
                        DecDiscount = 0.5
                End Select

                'Calculate total for package B
                DecTotalB = UintQuPackageB * (DecRetailPrice - (DecDiscount * DecRetailPrice))


            End If
        End If


        'Input validation txtPackageC
        If UInteger.TryParse(txtPackageC.Text, UintQuPackageC) Then

            'Assign Retail price based on package 
            If UintQuPackageC Then
                DecRetailPrice = 299

                'Assign Discount based on quantity
                Select Case UintQuPackageC
                    Case 10 To 19
                        DecDiscount = 0.2
                    Case 20 To 49
                        DecDiscount = 0.3
                    Case 50 To 99
                        DecDiscount = 0.4
                    Case Is >= 100
                        DecDiscount = 0.5
                End Select

                'Calculate total for package C
                DecTotalC = UintQuPackageC * (DecRetailPrice - (DecDiscount * DecRetailPrice))

            End If
            'Calculate the grand total
            DecGrandTotal = DecTotalA + DecTotalB + DecTotalC

            ' Display all the totals and the Grand total onto  lblMessage 
            lblMessage.Text = "Package A : " & DecTotalA.ToString("n2") & vbNewLine &
                    "Package B : " & DecTotalB.ToString("n2") & vbNewLine & "Package C : " &
                    DecTotalC.ToString("n") & vbNewLine & vbNewLine & "Grand Total : " & DecGrandTotal.ToString("n")
        Else
            MessageBox.Show("The value you enter onto the textbox cannot be non-numeric or a negative number  ")
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Reset the text boxes and the lebel control 
        txtPackageA.Clear()
        txtPackageB.Clear()
        txtPackageC.Clear()
        lblMessage.Text = String.Empty
        txtPackageA.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the form
        Me.Close()
    End Sub
End Class
