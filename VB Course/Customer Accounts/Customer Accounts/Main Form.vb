Imports System.IO
Public Class frmMain
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AddNewRecordToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AddNewRecordToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AddNewRecordToolStripMenuItem.Click
        Add_New_Record.ShowDialog()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Open.ShowDialog()
    End Sub

    Private Sub ByCustomerNumberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ByCustomerNumberToolStripMenuItem.Click
        SbyAccnumber()
    End Sub

    Private Sub ByLastNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ByLastNameToolStripMenuItem.Click
        SbyLastName()
    End Sub



    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub pdPrint_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdPrint.PrintPage


        'Print the body of the report 
        Dim FileForPrint As StreamReader
        Dim intX As Integer = 12
        Dim intY As Integer = 12


        Try
            ' Open file 
            FileForPrint = File.OpenText("Content.txt")
            'Read file
            Do While Not FileForPrint.EndOfStream
                e.Graphics.DrawString(FileForPrint.ReadLine(),
                                      New Font("Courier New", 10, FontStyle.Regular),
                                      Brushes.Black, intX, intY)
                intY += 14
            Loop
            'Close file 
            FileForPrint.Close()
        Catch ex As Exception
            MessageBox.Show("File could not be opened")
        End Try

    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        'Print Current Document
        pdPrint.Print()
    End Sub

    Private Sub lblMyName_Click(sender As Object, e As EventArgs) Handles lblMyName.Click
        Dim EachLine As String = String.Empty
        Dim EachLine2 As String = String.Empty
        Dim TheTextFile As StreamReader

        TheTextFile = File.OpenText("NameText.txt")

        EachLine = TheTextFile.ReadToEnd()
        If EachLine.Contains("D") Then
            If EachLine.Contains("a") Then
                If EachLine.Contains("n") Then
                    If EachLine.Contains("i") Then
                        If EachLine.Contains("e") Then
                            If EachLine.Contains("l") Then
                                If EachLine.Contains("n") Then
                                    If EachLine.Contains("e") Then
                                        If EachLine.Contains("w") Then
                                            If EachLine.Contains("a") Then
                                                If EachLine.Contains("y") Then
                                                    lblMyName.Text = "D" + "a" + "n" + "i" + "e" + "l" + " " +
                                                        "N" + "e" + "w" + "a" + "y"

                                                End If

                                            End If

                                        End If

                                    End If

                                End If
                            End If

                        End If

                    End If

                End If

            End If

        End If


        TheTextFile.Close()
    End Sub

    Private Sub ProgramPurposeDescriptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramPurposeDescriptionToolStripMenuItem.Click
        'Describe purpose of the application
        MessageBox.Show("This application allow the primary user to save customer Accounts to file Search the file for a customer and Print a record ")
    End Sub
End Class
