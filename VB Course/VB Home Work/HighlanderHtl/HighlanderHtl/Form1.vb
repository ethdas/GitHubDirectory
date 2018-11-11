
' Pseudocode

'Declare variables for calculating Roomcharge , 
'for Calculating additional charges
'for calculating subtotal 
'for calculating tax 
'for calculating the grand total




Public Class Form1
    Private Sub txtTodayDate_TextChanged(sender As Object, e As EventArgs)
        Dim DatDate As Date = Now()
        lblDate.Text = CStr(DatDate)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DatDate As Date = Now()
        lblDate.Text = "Today'SByte Date : " & CStr(DatDate)
    End Sub
End Class
