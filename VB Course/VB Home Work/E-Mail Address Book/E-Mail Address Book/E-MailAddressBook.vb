Public Class frmMain


    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Create an instance of Add New Name form
        Dim frmAddNewName As New frmName

        'Display the form
        frmAddNewName.ShowDialog()


    End Sub
    ' a procedure that updates the list box in the main form
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim Z As String = InputBox("Enter phone number of the list you want to edit")
        Try
            Dim J As AddressBook
            J = CType(addressList.Item(Z), AddressBook)
            J.Name = InputBox("enter the new Name")
            J.EmailAddress = InputBox("enter the new email Address")
            J.Notes = InputBox("enter the new comment")
            DisplayEntry()
        Catch ex As Exception
            ' display an error message 
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim Z As String = InputBox("Enter phone number of the  list you want to remove ")
        Try
            Dim J As AddressBook
            J = CType(addressList.Item(Z), AddressBook)
            addressList.Remove(Z)
            DisplayEntry()
        Catch ex As Exception
            ' display an error message 
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayEntry()
    End Sub

End Class
