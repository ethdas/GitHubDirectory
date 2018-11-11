Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Const decUNDER_20_CHECKS As Decimal = 0.1D
        Const decUNDER_40_CHECKS As Decimal = 0.08D
        Const decUNDER_60_CHECKS As Decimal = 0.06D
        Const decOVER_59_CHECKS As Decimal = 0.04D
        Dim intChecks As UInt32 = 0
        Dim decMonthlyCommCheckingAcc As Decimal = 10D
        Dim decCheckFee As Decimal
        Dim decTotalBankCharge As Decimal

        Try
            'Get number of checks written
            intChecks = CUInt(txtChecksWritten.Text)

            'Determine the  fee rate 
            Select Case intChecks
                Case Is < 20
                    decCheckFee = decUNDER_20_CHECKS
                Case 20 To 39
                    decCheckFee = decUNDER_40_CHECKS
                Case 40 To 59
                    decCheckFee = decUNDER_60_CHECKS
                Case Is >= 60
                    decCheckFee = decOVER_59_CHECKS
            End Select

            ' Calculate Total monthly Bank charge 
            decTotalBankCharge = decMonthlyCommCheckingAcc + (decCheckFee * intChecks)

            lblMonthlyBankFee.Text = "Your  Bank Charge for this month is " + decTotalBankCharge.ToString("C") _
                + ".  Thank you for using Bank of America"
        Catch ex As Exception
            ' Error Message 
            lblMonthlyBankFee.Text = "Please enter positive numeric Value"
        End Try


    End Sub

    Protected Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtChecksWritten.Text = String.Empty
        lblMonthlyBankFee.Text = String.Empty
    End Sub
End Class