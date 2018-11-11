Public Class Form1
    Private Sub btnNumberF_Click(sender As Object, e As EventArgs) Handles btnNumberF.Click
        Dim DblFormatted As Double = CDbl(txtEnterData.Text)
        txtFormatted.Text = DblFormatted.ToString("n")
    End Sub

    Private Sub btnFixedF_Click(sender As Object, e As EventArgs) Handles btnFixedF.Click
        Dim DblFormatted As Double = CDbl(txtEnterData.Text)
        txtFormatted.Text = DblFormatted.ToString("f")
    End Sub

    Private Sub btnExpoF_Click(sender As Object, e As EventArgs) Handles btnExpoF.Click
        Dim DblFormatted As Double = CDbl(txtEnterData.Text)
        txtFormatted.Text = DblFormatted.ToString("e")
    End Sub

    Private Sub btnCurrF_Click(sender As Object, e As EventArgs) Handles btnCurrF.Click
        Dim DblFormatted As Double = CDbl(txtEnterData.Text)
        txtFormatted.Text = DblFormatted.ToString("c")
    End Sub

    Private Sub btnPercF_Click(sender As Object, e As EventArgs) Handles btnPercF.Click
        Dim DblFormatted As Double = CDbl(txtEnterData.Text)
        txtFormatted.Text = DblFormatted.ToString("p")
    End Sub

    Private Sub btnShortD_Click(sender As Object, e As EventArgs) Handles btnShortD.Click
        Dim DblFormatted As Date = CDate(txtEnterData.Text)
        txtFormatted.Text = DblFormatted.ToString("d")
    End Sub

    Private Sub btnLongD_Click(sender As Object, e As EventArgs) Handles btnLongD.Click
        Dim DblFormatted As Date = CDate(txtEnterData.Text)
        txtFormatted.Text = DblFormatted.ToString("D")
    End Sub

    Private Sub btnShortT_Click(sender As Object, e As EventArgs) Handles btnShortT.Click
        Dim DblFormatted As Date = CDate(txtEnterData.Text)
        txtFormatted.Text = DblFormatted.ToString("t")
    End Sub

    Private Sub btnLongT_Click(sender As Object, e As EventArgs) Handles btnLongT.Click
        Dim DblFormatted As Date = CDate(txtEnterData.Text)
        txtFormatted.Text = DblFormatted.ToString("T")
    End Sub

    Private Sub btnDateTime_Click(sender As Object, e As EventArgs) Handles btnDateTime.Click
        Dim DblFormatted As Date = CDate(txtEnterData.Text)
        txtFormatted.Text = DblFormatted.ToString("F")
    End Sub
End Class
