Public Class MainPage
    Private Sub MainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KayaksRentalPricesDataSet.KayakTypes' table. You can move, or remove it, as needed.
        Me.KayakTypesTableAdapter.Fill(Me.KayaksRentalPricesDataSet.KayakTypes)

    End Sub


End Class
