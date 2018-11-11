Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        lblMessage.Text = "Thank you for signing up for the " & "picnic, " & txtFirst.Text & "."
        If chkVegeterian.Checked = True Then
            lblMessage.Text &= "you will be recieving a " & "vegeterian meal."
        End If

    End Sub
End Class