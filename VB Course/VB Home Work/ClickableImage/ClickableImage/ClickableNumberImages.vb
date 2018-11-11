Public Class ClickableNumberImages
    Private Sub PicOne_Click(sender As Object, e As EventArgs) Handles PicOne.Click
        'When clicked shoud display the English word one
        MessageBox.Show("one")
        'Display the spanish word for one 
        lblSpanish.Text = "Uno"
    End Sub

    Private Sub PicTwo_Click(sender As Object, e As EventArgs) Handles PicTwo.Click
        'When clicked shoud display the English word two
        MessageBox.Show("Two")
        'Display the spanish word for Two
        lblSpanish.Text = "dos"
    End Sub

    Private Sub PicFour_Click(sender As Object, e As EventArgs) Handles PicFour.Click
        'When clicked shoud display the English word four
        MessageBox.Show("Four")
        'Display the spanish word for Four
        lblSpanish.Text = "Cuatros"
    End Sub

    Private Sub PicThree_Click(sender As Object, e As EventArgs) Handles PicThree.Click
        'When clicked shoud display the English word three
        MessageBox.Show("Three")
        'Display the spanish word for Three 
        lblSpanish.Text = "Tres"
    End Sub

    Private Sub PicFive_Click(sender As Object, e As EventArgs) Handles PicFive.Click
        'When clicked shoud display the English word five
        MessageBox.Show("Five")
        'Display the spanish word for Five
        lblSpanish.Text = "Cinco"
    End Sub
End Class
