Public Class NameAddress
    Private Sub lblNameAddress_Click(sender As Object, e As EventArgs) Handles lblNameAddress.Click

    End Sub

    Private Sub btnShowInfo_Click(sender As Object, e As EventArgs) Handles btnShowInfo.Click
        lblNameAddress.Visible = True
        lblName.Visible = True
        lblStreet.Visible = True
        lblCityStateZip.Visible = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
