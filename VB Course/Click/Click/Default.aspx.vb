Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click
        lblMessage.Text = "Thank you for clicking the button!"
    End Sub
End Class