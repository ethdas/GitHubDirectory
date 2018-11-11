Public Class Form1
    Private Sub btnCalcRevenue_Click(sender As Object, e As EventArgs) Handles btnCalcRevenue.Click
        'This procedure calculates the gross and net revenue
        'From adult And children ticket sales


        'Declare variables 
        Dim decAdultTicketPrice As Decimal  'To hold price per ticket for Adults
        Dim intAdultTicketsSold As Integer  ' To hold number of adult tickets sold
        Dim decChildTicketPrice As Decimal  'To hold price per ticket for Children
        Dim intChldTicketsSold As Integer   'To hold number of child tickest sold 
        Const decTHEATRE_REVENUE As Decimal = 0.2D ' The 20% Theatre keeps 
        Dim decGrossAdultTickeSales As Decimal 'To hold Gross Tickets sold for adults
        Dim decGrossChildTicketSales As Decimal 'To hold Gross Tickets sold for children
        Dim decGrossRevenue As Decimal 'To store the gross revenue
        Dim decNetAdultTicketSales As Decimal 'To store the net revenue from Tickets sold for adults
        Dim decNetChildTicketSales As Decimal 'To hold the net revenue from  Tickets sold for children
        Dim decNetRevenue As Decimal 'To store the net Revenue 
        Try
            ' storing the inputs into the vaiables
            decAdultTicketPrice = CDec(txtAdultTicketPrice.Text)
            intAdultTicketsSold = CInt(txtAdultTicketsSold.Text)
            decChildTicketPrice = CDec(txtChildTicketPrice.Text)
            intChldTicketsSold = CInt(txtChildTicketsSold.Text)

            ' Calculate the gross and net revenue and 
            'store the output on to the respective variables
            decGrossAdultTickeSales =
                decAdultTicketPrice * intAdultTicketsSold
            decGrossChildTicketSales =
                decChildTicketPrice * intChldTicketsSold
            decGrossRevenue =
                decGrossAdultTickeSales + decGrossChildTicketSales
            decNetAdultTicketSales =
                decTHEATRE_REVENUE * decGrossAdultTickeSales
            decNetChildTicketSales =
                decTHEATRE_REVENUE * decGrossChildTicketSales
            decNetRevenue =
                decNetAdultTicketSales + decNetChildTicketSales

            'assigning the calculated stored variable values to the respective labels
            lblGrossAdultTicketSales.Text = decGrossAdultTickeSales.ToString("c")
            lblGrossChildTicketSales.Text = decGrossChildTicketSales.ToString("c")
            lblGrossRevenue.Text = decGrossRevenue.ToString("c")
            lblNetAdultTicketSales.Text = decNetAdultTicketSales.ToString("c")
            lblNetChildTicketSales.Text = decNetChildTicketSales.ToString("c")
            lblNetRevenue.Text = decNetRevenue.ToString("c")

            'Change the colors for the total revenue fields
            lblGrossRevenue.BackColor = Color.Beige
            lblNetRevenue.BackColor = Color.Beige

        Catch
            'Error Message to be displayed 
            MessageBox.Show("Please enter valid Numeric Values")
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'clear the text boxes
        txtAdultTicketPrice.Clear()
        txtAdultTicketsSold.Clear()
        txtChildTicketPrice.Clear()
        txtChildTicketsSold.Clear()

        'clear the labels
        lblGrossAdultTicketSales.Text = String.Empty
        lblGrossChildTicketSales.Text = String.Empty
        lblGrossRevenue.Text = String.Empty
        lblNetAdultTicketSales.Text = String.Empty
        lblNetChildTicketSales.Text = String.Empty
        lblNetRevenue.Text = String.Empty

        'Reset the focus to textbox txtAdultTicketPrice
        txtAdultTicketPrice.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close the form
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAdultTicketPrice.Focus()
        btnCalcRevenue.BackColor = Color.Cyan

    End Sub
End Class
