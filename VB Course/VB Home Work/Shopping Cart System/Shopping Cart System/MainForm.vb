Public Class MainForm

    Private Sub ProductsSelected_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub AudioBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AudioBooksToolStripMenuItem.Click
        'Create an instance of Audio Books form
        Dim frmAudioBook As New Audio_Books

        'Display the Audio Book form in Modal style
        frmAudioBook.ShowDialog()
    End Sub

    Private Sub ProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductsToolStripMenuItem.Click

    End Sub

    Private Sub PrintBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintBooksToolStripMenuItem.Click
        'Create an instance of Print  Books form
        Dim frmPrintBook As New PrintBooks

        'Display the Audio Book form in Modal style
        frmPrintBook.ShowDialog()
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        lblSub.Text = "0.00"
        lblShipping.Text = "0.00"

        lblTax.Text = "0.00"
        lblTotal.Text = "0.00"

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Added_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbAdded.SelectedIndexChanged

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click


        If Me.lbAdded.SelectedIndex <> -1 Then
            Me.lblTotal.Text = CDbl(Me.lblTotal.Text) - AudioBooksPrice(lbAdded.SelectedIndex).ToString()
            Me.lblTax.Text = (CDbl(Me.lblTax.Text) - Calculate.AudioBooksPrice(lbAdded.SelectedIndex) * 0.06).ToString()
            Me.lblSub.Text = (CDbl(Me.lblSub.Text) - Calculate.AudioBooksPrice(lbAdded.SelectedIndex)).ToString()
        Else
            Me.lblTotal.Text = CDbl(Me.lblTotal.Text) - PrintBooksPrice(lbAdded.SelectedIndex).ToString()
            Me.lblTax.Text = (CDbl(Me.lblTax.Text) - Calculate.PrintBooksPrice(lbAdded.SelectedIndex) * 0.06).ToString()
            Me.lblSub.Text = (CDbl(Me.lblSub.Text) - Calculate.PrintBooksPrice(lbAdded.SelectedIndex)).ToString()
        End If
        Me.lblShipping.Text = (CDbl(Me.lblShipping.Text) - 2.0).ToString()
        Me.lblTotal.Text = (CDbl(Me.lblTotal.Text) - 2.0).ToString()

        Me.lbAdded.Items.Remove(Me.lbAdded.SelectedItem)

    End Sub

    Private Sub lblSub_Click(sender As Object, e As EventArgs) Handles lblSub.Click

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
    Public PrintBooksPrice() As Double = {11.95, 14.5, 29.95, 18.5}
    Public AudioBooksPrice() As Double = {29.95, 14.5, 12.95, 11.5}
    Public strPrint() As String = {"I did it Your Way", "The History Of Scotland",
    "Learn Calculus In One Day", "Feel the Stress"}
    Public strAudio() As String = {"Learn Calculus in One Way", "The History of Scotland",
    "The Science of Body Language", "Relaxation Technique"}

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("This Is the hardest project ever")
    End Sub
End Class
