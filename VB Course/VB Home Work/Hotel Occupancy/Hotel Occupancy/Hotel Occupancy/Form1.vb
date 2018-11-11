Public Class Form1
    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Const intNUM_FLOOR As Integer = 8           'number of floor
        Dim intNumOfFloor As Integer = 1            'loop counter
        Const dblNUM_ROOMS_PER_FLOOR As Double = 30 'the number of rooms available per floor
        Const dblTOTALROOMS As Double = 240         'Total room available
        Dim dblTotalRoomsOccupied As Double = 0     'the accumulator
        Dim strOccupiedToday As String              'string form of daily number of rooms occupied
        Dim dblOccupiedToday As Double              ' numeric form of daily number of rooms occpied
        Dim dblOccRate As Double                    'to hold the occupancy rate per floor
        Dim dblOverallOccupancy As Double           'to hold the over all occupancy rate


        'Get the number of rooms occupied per floor
        Do While intNumOfFloor <= intNUM_FLOOR

            strOccupiedToday = InputBox("Enter the number of rooms occupied on floor number " & intNumOfFloor)

            Try
                ' convert input to a double and validate entry 
                dblOccupiedToday = CDbl(strOccupiedToday)

                'validate entry between 1 and 30
                If (dblOccupiedToday >= 1 And dblOccupiedToday <= 30) Then
                    'Calculate Daily occupancy rate
                    dblOccRate = (dblOccupiedToday / dblNUM_ROOMS_PER_FLOOR)
                    'post the result of the calculation on to the list box
                    FloorOccupancyData.Items.Add("Floor: " & intNumOfFloor &
                                     " Rooms Occupied " & strOccupiedToday &
                                     " Occupancy Rate : " & dblOccRate.ToString("p"))
                    ' Accumulate the total number of occupied rooms 
                    dblTotalRoomsOccupied += dblOccupiedToday
                    ' increment the counter by 1
                    intNumOfFloor += 1
                    ' error message if value entered is other than between 1 and 30
                Else
                    MessageBox.Show("entered value has to be a numeric value between 1 and 30")
                End If
                'error message if value entered can not be converted to numeric value 
            Catch

                MessageBox.Show("entered value has to be a numeric value ")
            End Try


        Loop


        ' calculate Over all occupancy rate 
        dblOverallOccupancy = dblTotalRoomsOccupied / dblTOTALROOMS
        ' Assign total number of occupied rooms to a label
        lblTotalOccupied.Text = dblTotalRoomsOccupied.ToString()
        ' assign overall occupancy rate to a label
        lblOverallOccupancy.Text = dblOverallOccupancy.ToString("p")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear data
        FloorOccupancyData.Items.Clear()
        lblOverallOccupancy.Text = String.Empty
        lblTotalOccupied.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close form
        Me.Close()
    End Sub
End Class
