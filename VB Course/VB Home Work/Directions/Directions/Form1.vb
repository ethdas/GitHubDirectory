Public Class Form1
    Private Sub btnDisplayDirections_Click(sender As Object, e As EventArgs) Handles btnDisplayDirections.Click
        'Make the directions visible.
        lblDirections.Visible = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the Form.
        Me.Close()
    End Sub
End Class
