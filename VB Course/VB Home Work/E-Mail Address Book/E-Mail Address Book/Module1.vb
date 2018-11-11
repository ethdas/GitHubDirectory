Imports System.IO

Module Module1
    Public addressList As New Collection
    ' AddRecored procedure adds the object referenced by 
    'A to the collection . It uses the the phone number as a key

    Public Sub AddRecord(ByVal A As AddressBook)
        Try
            addressList.Add(A, A.PhoneNumber)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub DisplayEntry()
        frmMain.lstNames.Items.Clear()


        Dim K As AddressBook
        For Each K In addressList
            frmMain.lstNames.Items.Add(K.Name)
            frmMain.lstNames.Items.Add(K.PhoneNumber)
            frmMain.lstNames.Items.Add(K.EmailAddress)
            frmMain.lstNames.Items.Add(K.Notes)
            frmMain.lstNames.Items.Add(".....")
        Next
    End Sub




End Module
