Imports System.IO
Public Class frmName

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim objAddressBook As New AddressBook
        GetData(objAddressBook)
        SaveData(objAddressBook)
        AddRecord(objAddressBook)
        ' Update the contents of the list box in the main form
        DisplayEntry()


    End Sub

    ' The get data procedure which gets data from the text boxes
    'and stores it in the object

    Public Sub SaveData(ByVal objAddressBook As AddressBook)
        Dim writer As StreamWriter
        Try
            'open file in append mode
            writer = File.AppendText("AddressBook.txt")

            writer.WriteLine(objAddressBook.Name)
            writer.WriteLine(objAddressBook.EmailAddress)
            writer.WriteLine(objAddressBook.PhoneNumber)
            writer.WriteLine(objAddressBook.Notes)

            ' close the stream writer 
            writer.Close()
        Catch ex As Exception
            ' display an error message 
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub GetData(ByVal objAddressBook As AddressBook)
        Try
            'assign values from the form to the object properties
            objAddressBook.Name = txtName.Text
            objAddressBook.EmailAddress = txtEmailAddress.Text
            objAddressBook.PhoneNumber = txtPhone.Text
            objAddressBook.Notes = txtNotes.Text
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class