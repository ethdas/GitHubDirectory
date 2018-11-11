'Name : Daniel Neway
'Course : Visual Basic CIS 159
'Project Title: Rainfall statistics 
'Purpose: To create an application that calcuates
'       And displays Rainfall statistics based on values entered by users

Public Class RainfallStats
    ' Declare the variables and the arrays that hold rainfall statistics 
    Const intMAX_VALUE As Integer = 11
    Dim strMonths() = {"January", "February", "March", "April", "May", "June",
        "July", "August", "September", "October", "November", "December"}
    Dim dblRainfall(intMAX_VALUE) As Double
    Dim intCount As Integer
    Dim dblTotalrainfall As Double = 0
    Dim dblAverageRainfall As Double = 0.00D
    Dim dblHighestRainfall As Double = 0.00D
    Dim dblLowestRainfall As Double = 0.00D

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click



        ' Ask the user to enter rainfall for each month
        Try
            UserInput()
        Catch
            Chatch()
        End Try


        ' Calculate Total Rainfall for the year
        Calc_TotalRainfall()

        Calc_AverageRainfall()


        'First element assigned before calculating the highest value

        Calc_HighestRainfall()


        Calc_LowestRainfall()


        MessageBox.Show("Now click 'Display stats' button in the next screen to see sumary of yearly rainfall Stats")
    End Sub

    Private Sub RainfallStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("This application lets you enter the rainfall for each of the 12 months. In the next screen Please click the button 'Input Monthly rainfall' and  enter a valid numeric value.")
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        'Make the labels and the heading label visible 

        MakeLabelsVisible()

        ' Display statistics
        DisplayRainfallstats()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear listbox and all labels
        ClearListBoxAndLebels()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    'A procedure to clear the list box and all the labels
    Sub ClearListBoxAndLebels()
        lbStatistics.Items.Clear()
        lblTotal.Text = String.Empty
        lblAverage.Text = String.Empty
        lblMaximum.Text = String.Empty
        lblMinimum.Text = String.Empty

    End Sub
    'A procedure to display stats on the form 
    Sub DisplayRainfallstats()
        lblTotal.Text = " The Total Rainfall was : " & dblTotalrainfall.ToString()
        lblAverage.Text = " The AverageRainfall was : " & dblAverageRainfall.ToString("N2")
        lblMaximum.Text = " The Maximum Rainfall was : " & dblHighestRainfall.ToString()
        lblMinimum.Text = " The Minimum Rainfall was : " & dblLowestRainfall.ToString()

    End Sub
    'A procedure to make the labels visible again
    Sub MakeLabelsVisible()
        lblHeading.Visible = True
        lblTotal.Visible = True
        lblAverage.Visible = True
        lblMaximum.Visible = True
        lblMinimum.Visible = True
    End Sub
    'A procedure to calculate the lowest rainfall value
    Sub Calc_LowestRainfall()
        dblLowestRainfall = dblRainfall(0)
        For intCount = 1 To (dblRainfall.Length - 1)
            If dblRainfall(intCount) < dblLowestRainfall Then
                dblLowestRainfall = dblRainfall(intCount)

            End If
        Next
        MessageBox.Show("Here is the lowest Rainfall in the Year " & dblLowestRainfall.ToString())
    End Sub
    'A procedure to calculate the highest rainfall value
    Sub Calc_HighestRainfall()
        dblHighestRainfall = dblRainfall(0)
        For intCount = 1 To (dblRainfall.Length - 1)
            If dblRainfall(intCount) > dblHighestRainfall Then
                dblHighestRainfall = dblRainfall(intCount)
            End If
        Next
        MessageBox.Show("Here is the Highest Rainfall in the Year " & dblHighestRainfall.ToString())
    End Sub
    'A procedure to the average rainfall value
    Sub Calc_AverageRainfall()
        dblAverageRainfall = 0.00D
        dblAverageRainfall = CDbl(dblTotalrainfall / (dblRainfall.Length))
        MessageBox.Show("Here is the average rainfall:  " & dblAverageRainfall.ToString("N2"))
    End Sub
    'A procedure to calculate the total rainfall value
    Sub Calc_TotalRainfall()
        dblTotalrainfall = 0.00D
        For intCount = 0 To (dblRainfall.Length - 1)
            dblTotalrainfall += dblRainfall(intCount)

        Next
        MessageBox.Show("Total rainfall adds up to:  " & dblTotalrainfall)
    End Sub
    'A procedure to make listbox visible and  ask the user to enter rainfall for each month
    Sub UserInput()
        lbStatistics.Visible = True
        lbStatistics.Items.Add("Monthly Rainfall input")
        lbStatistics.Items.Add("----------------------------------")


        Do While intCount < dblRainfall.Length
            Try
                dblRainfall(intCount) =
                     CDbl(InputBox("Enter Rainfall Value for  " & strMonths(intCount)))
                MessageBox.Show("The Value you intered is : " & dblRainfall(intCount) & " We are now transferring it to the display board")
                lbStatistics.Items.Add(strMonths(intCount) & " Rainfall = " & dblRainfall(intCount))

                intCount += 1


            Catch
                Chatch()

            End Try

        Loop
    End Sub
    'A procedure  the cat
    Sub Chatch()
        MessageBox.Show(" ooha ! This is not a  valid number. Make sure they are numeric")
    End Sub
End Class
