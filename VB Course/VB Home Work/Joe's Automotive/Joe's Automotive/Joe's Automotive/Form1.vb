'Project Title: Programming Challenge 4: "Joe's Automotive," 
'--------------
'Purpose: Create an application that displays the total for a customer's visit to Joe's automotive
'--------
'Program Author: Daniel Neway
'--------------
'Subject : CIS159 
'--------

Public Class Form1
    ' Class-Level Declaration
    Const decOIL_cHANGE As Decimal = 26D        'Amount charged for oil change
    Const decLUBE_JOB As Decimal = 18D          'Amount charged for lube job
    Const decRADIATOR_F As Decimal = 30D        'Amount charged for Radiator Flushing
    Const decTRANSMISSION_F As Decimal = 80D    'Amount charged for Transmission Flushing
    Const decINSPECTION As Decimal = 15D        'Amount charged for general Inspection
    Const decREPLAC_M As Decimal = 100D         'Amount charged for Muffler Replacement
    Const decTIRE_R As Decimal = 20D            'Amount charged for Tire Rotation
    Const decLABOR_COST_PERHR As Decimal = 20D  'Amount charged per hour for Labor cost 
    Const decTAX_RATE As Decimal = 0.06D        'Tax Rate for Parts only
    ' This procedure calculates the total of service ordered and ,
    'the cost Of parts separately , cost Of other services including Labor,
    ' And tax charged on parts only
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Try
            Dim decServicesandLabor As Decimal 'holds Services and labor cost only

            decServicesandLabor = (OilLubeCharges() +
                                    FlushCharges() +
                                    MiscCharges() +
                                    Labor())


            lblService.Text = CStr(decServicesandLabor) ' 
            lblParts.Text = Parts().ToString()
            lblTaxOnParts.Text = TaxCharges.ToString()
            lblTotal.Text = TotalCharges(0.00, 0.00, 0.00).ToString()
        Catch
            MessageBox.Show("The amount you enter should be a numeric value greater than zero")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This procedure resets all controls to their default state
        ClearOilLube()
        ClearFlushes()
        ClearMisc()
        ClearOther()
        ClearFees()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This procedure closes the form 
        Me.Close()
    End Sub
    'This function returns the total cost of oil change and lube job
    Function OilLubeCharges() As Decimal
        Dim decOil As Decimal
        Dim decLube As Decimal

        If chkOil.Checked = True Then
            decOil = decOIL_cHANGE
        Else
            decOil = 0

        End If
        If chkLube.Checked = True Then
            decLube = decLUBE_JOB
        Else
            decLube = 0

        End If
        Return decOil + decLube

    End Function

    'This function returns the total cost of Radiator and Transmission flush
    Function FlushCharges() As Decimal

        Dim decRadiator As Decimal
        Dim decTransmission As Decimal

        If chkRad.Checked = True Then
            decRadiator = decRADIATOR_F
        Else
            decRadiator = 0

        End If
        If chkTrans.Checked = True Then
            decTransmission = decTRANSMISSION_F
        Else
            decTransmission = 0

        End If
        Return decRadiator + decTransmission

    End Function

    'This function returns the total cost of other miscellaneouse charges including general Inspection
    Function MiscCharges() As Decimal
        Dim decinspec As Decimal
        Dim decRepMuffler As Decimal
        Dim decRotation As Decimal

        If chkInsp.Checked = True Then
            decinspec = decINSPECTION
        Else
            decinspec = 0
        End If
        If chkRepM.Checked = True Then
            decRepMuffler = decREPLAC_M
        Else
            decRepMuffler = 0
        End If
        If chkTireR.Checked = True Then
            decRotation = decTIRE_R
        Else
            decRotation = 0
        End If
        Return decinspec + decRepMuffler + decRotation

    End Function

    'This function returns the total cost of parts separately before tax
    Function Parts() As Decimal


        Dim decParts As Decimal


        decParts = CDec(txtParts.Text)


        Return decParts
    End Function

    'This function returns the total cost of labor
    Function Labor()
        Dim decLabor As Decimal
        Dim LCost As Decimal

        decLabor = CInt(txtLabor.Text)
        LCost = decLabor * decLABOR_COST_PERHR

        Return LCost
    End Function

    'This function returns the tax amount to be deducted from parts only
    Function TaxCharges() As Decimal
        Dim decPartsTax As Decimal

        decPartsTax = (Parts() * decTAX_RATE)

        Return decPartsTax

    End Function

    'This function returns the gross total cost of ordered services less Tax amount on parts
    Function TotalCharges(decServices As Decimal, decOtherCharges As Decimal, decTaxes As Decimal) As Decimal
        decServices = OilLubeCharges() + FlushCharges() + MiscCharges()
        decOtherCharges = Labor() + Parts()
        decTaxes = TaxCharges()

        Return (decServices + decOtherCharges) - TaxCharges()



    End Function
    'This procedure resets Oil and Lube section of the form
    Sub ClearOilLube()
        chkOil.Checked = False
        chkLube.Checked = False
    End Sub

    'This procedure resets Flush section of the form
    Sub ClearFlushes()
        chkRad.Checked = False
        chkTrans.Checked = False
    End Sub

    'This procedure resets Misc section of the form
    Sub ClearMisc()
        chkInsp.Checked = False
        chkRepM.Checked = False
        chkTireR.Checked = False

    End Sub

    'This procedure resets Parts and Labor section of the form
    Sub ClearOther()
        txtParts.Text = String.Empty
        txtLabor.Text = String.Empty
    End Sub

    'This procedure resets Summary section of the form
    Sub ClearFees()
        lblService.Text = String.Empty
        lblParts.Text = String.Empty
        lblTaxOnParts.Text = String.Empty
        lblTotal.Text = String.Empty

    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub
End Class
