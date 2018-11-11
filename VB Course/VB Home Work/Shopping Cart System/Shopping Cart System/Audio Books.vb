Public Class Audio_Books

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click


        If MainForm.lbAdded.SelectedItem <> -1 Then
            MainForm.lbAdded.Items.Add(Me.lbAudioBook.SelectedItem.ToString())
            MainForm.lblSub.Text = (CDbl(MainForm.lblSub.Text) + AudioBooksPrice(lbAudioBook.SelectedIndex)).ToString()
            MainForm.lblTax.Text = (CDbl(MainForm.lblTax.Text) + AudioBooksPrice(lbAudioBook.SelectedIndex) * 0.06).ToString()
            MainForm.lblShipping.Text = (CDbl(MainForm.lblShipping.Text) + 2.0).ToString()
            MainForm.lblTotal.Text = (CDbl(MainForm.lblTax.Text) + CDbl(MainForm.lblSub.Text) +
                CDbl(MainForm.lblTax.Text) + CDbl(MainForm.lblShipping.Text)).ToString()
        End If

    End Sub
End Class