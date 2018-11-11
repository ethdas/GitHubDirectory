Imports System.IO
Public Class Add_New_Record




    Private Sub Add_New_Record_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click


        Dim AccountWriter As StreamWriter
        Dim ObjCustomerAccounts As CustomerAccounts


        AccountWriter = File.AppendText("Content.txt")

        ObjCustomerAccounts.CustomerNumber = txtCustomerNumber.Text
        ObjCustomerAccounts.FirstName = txtFirstName.Text
        ObjCustomerAccounts.LastName = txtLastName.Text
        ObjCustomerAccounts.Address = txtAddress.Text
        ObjCustomerAccounts.City = txtCity.Text
        ObjCustomerAccounts.State = txtState.Text
        ObjCustomerAccounts.ZipCode = txtZipCode.Text
        ObjCustomerAccounts.TelephoneNumber = txtTelephoneNumber.Text
        ObjCustomerAccounts.AccountBallance = txtAccountBallance.Text
        ObjCustomerAccounts.DateofLastPayment = txtDate.Text


        AccountWriter.WriteLine("{0} , {1} ,{2} , {3} , {4} , {5} , {6} , {7} , {8} , {9}  ",
                                ObjCustomerAccounts.CustomerNumber,
                                ObjCustomerAccounts.FirstName,
                                ObjCustomerAccounts.LastName,
                                ObjCustomerAccounts.Address,
                                ObjCustomerAccounts.City,
                                ObjCustomerAccounts.State,
                                ObjCustomerAccounts.ZipCode,
                                ObjCustomerAccounts.TelephoneNumber,
                                ObjCustomerAccounts.AccountBallance,
                                ObjCustomerAccounts.DateofLastPayment)


        AccountWriter.Close()


    End Sub



    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        txtCustomerNumber.Text = String.Empty
        txtFirstName.Text = String.Empty
        txtLastName.Text = String.Empty
        txtAddress.Text = String.Empty
        txtCity.Text = String.Empty
        txtState.Text = String.Empty
        txtZipCode.Text = String.Empty
        txtTelephoneNumber.Text = String.Empty
        txtAccountBallance.Text = String.Empty
        txtDate.Text = String.Empty
    End Sub
End Class