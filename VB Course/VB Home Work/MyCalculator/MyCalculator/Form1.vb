Public Class Form1
    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        Dim dblResult As Double
        dblResult = CDbl(txt1stNum.Text) + CDbl(txt2ndNum.Text)
        txtResult.Text = CStr(dblResult)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        Dim dblResult As Double

        dblResult = CDbl(txt1stNum.Text) - CDbl(txt2ndNum.Text)
        txtResult.Text = CStr(dblResult)
    End Sub

    Private Sub btntimes_Click(sender As Object, e As EventArgs) Handles btntimes.Click
        Dim dblResult As Double

        dblResult = CDbl(txt1stNum.Text) * CDbl(txt2ndNum.Text)
        txtResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        Dim dblResult As Double

        dblResult = CDbl(txt1stNum.Text) / CDbl(txt2ndNum.Text)
        txtResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnDiv2_Click(sender As Object, e As EventArgs) Handles btnDiv2.Click
        Dim dblResult As Double

        dblResult = CDbl(txt1stNum.Text) \ CDbl(txt2ndNum.Text)
        txtResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnExpo_Click(sender As Object, e As EventArgs) Handles btnExpo.Click
        Dim dblResult As Double

        dblResult = CDbl(txt1stNum.Text) ^ CDbl(txt2ndNum.Text)
        txtResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Dim dblResult As Double

        dblResult = CDbl(txt1stNum.Text) Mod CDbl(txt2ndNum.Text)
        txtResult.Text = CStr(dblResult)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtResult.Text = String.Empty
        txt1stNum.Text = String.Empty
        txt2ndNum.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
