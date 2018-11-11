Public Class DateStringForm
    Private Sub btnShowDate_Click(sender As Object, e As EventArgs) Handles btnShowDate.Click
        lblDateString.Text = txtDayOfWeek.Text & ", " &
            txtMonth.Text &
            txtDayOfMonth.Text & ", " &
            txtYear.Text
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDayOfWeek.Clear()
        txtMonth.Clear()
        txtDayOfMonth.Clear()
        txtYear.Clear()
        lblDateString.Text = String.Empty
        'Give the focus to 
        txtMonth.Focus()
    End Sub

    Private Sub DateStringForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
