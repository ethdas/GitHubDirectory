Public Class Form1
    Private Sub btnInches_Click(sender As Object, e As EventArgs) Handles btnInches.Click
        lblMessage.Text = "1 Kilometer = 2000 Inches"
    End Sub

    Private Sub btnFeet_Click(sender As Object, e As EventArgs) Handles btnFeet.Click
        lblMessage.Text = "1 kilometer = 324 Feet"

    End Sub

    Private Sub btnYards_Click(sender As Object, e As EventArgs) Handles btnYards.Click
        lblMessage.Text = "1 kilometer = 7645 Yard"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
