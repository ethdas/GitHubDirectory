Public Class PrintBooks

    Private Sub PrintBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbprint.SelectedIndexChanged

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()
    End Sub

    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click

        If MainForm.lbAdded.SelectedItem <> -1 Then
            MainForm.lbAdded.Items.Add(Me.lbprint.SelectedItem.ToString())
            MainForm.lblSub.Text = (CDbl(MainForm.lblSub.Text) + PrintBooksPrice(lbprint.SelectedIndex)).ToString()
            MainForm.lblTax.Text = (CDbl(MainForm.lblTax.Text) + PrintBooksPrice(lbprint.SelectedIndex) * 0.06).ToString()
            MainForm.lblShipping.Text = (CDbl(MainForm.lblShipping.Text) + 2.0).ToString()
            MainForm.lblTotal.Text = (CDbl(MainForm.lblTax.Text) + CDbl(MainForm.lblSub.Text) +
                CDbl(MainForm.lblTax.Text) + CDbl(MainForm.lblShipping.Text)).ToString()
        End If

    End Sub

End Class