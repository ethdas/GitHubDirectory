' Name : Daniel Neway
' Title: Student Test Score (Lesson 8 )
'Purpose: Create an application that recieves name and test scores as entry ,
'save them To file , send them To printer And reopen them from file.


Imports System.IO


Public Class Form1
    Const intMAX_SUB_RECORD As Integer = 5
    Const intMAX_SUB_SCORES As Integer = 4

    Dim dblScore1 As Double = 0.00
    Dim dblScore2 As Double = 0.00
    Dim dblScore3 As Double = 0.00
    Dim dblScore4 As Double = 0.00
    Dim dblScore5 As Double = 0.00



    Structure StudentRecord
        Dim strName As String
        Dim dblTestScores() As Double
        Dim dblAverageScore As Double

    End Structure
    Public inPutFile As StreamReader
    Public outPutFile As StreamWriter
    Public strFileName As String
    Public intCount As Integer
    Public blnIsChanged As Boolean = False
    Public Student(intMAX_SUB_RECORD) As StudentRecord
    ' Write to file

    Sub WriteStudentRecord()

        Dim lineText As String
        Dim Array(6) As String

        Try
            outPutFile = File.CreateText(strFileName)


            Array(0) = txtNOne.Text
            Array(1) = txtScore1_1.Text
            Array(2) = txtScore1_2.Text
            Array(3) = txtScore1_3.Text
            Array(4) = txtScore1_4.Text
            Array(5) = txtScore1_5.Text
            Array(6) = lblAverage1.Text

            lineText = String.Join(",", Array)
            outPutFile.WriteLine(lineText)





            Array(0) = txtNTwo.Text
            Array(1) = txtScore2_1.Text
            Array(2) = txtScore2_2.Text
            Array(3) = txtScore2_3.Text
            Array(4) = txtScore2_4.Text
            Array(5) = txtScore2_5.Text
            Array(6) = lblAverage2.Text

            lineText = String.Join(",", Array)
            outPutFile.WriteLine(lineText)




            Array(0) = txtNThree.Text
            Array(1) = txtScore3_1.Text
            Array(2) = txtScore3_2.Text
            Array(3) = txtScore3_3.Text
            Array(4) = txtScore3_4.Text
            Array(5) = txtScore3_5.Text
            Array(6) = lblAverage3.Text

            lineText = String.Join(",", Array)
            outPutFile.WriteLine(lineText)






            Array(0) = txtNFour.Text
            Array(1) = txtScore4_1.Text
            Array(2) = txtScore4_2.Text
            Array(3) = txtScore4_3.Text
            Array(4) = txtScore4_4.Text
            Array(5) = txtScore4_5.Text
            Array(6) = lblAverage4.Text

            lineText = String.Join(",", Array)
            outPutFile.WriteLine(lineText)




            Array(0) = txtNFive.Text
            Array(1) = txtScore5_1.Text
            Array(2) = txtScore5_2.Text
            Array(3) = txtScore5_3.Text
            Array(4) = txtScore5_4.Text
            Array(5) = txtScore5_5.Text
            Array(6) = lblAverage5.Text

            lineText = String.Join(",", Array)
            outPutFile.WriteLine(lineText)




            Array(0) = txtNSix.Text
            Array(1) = txtScore6_1.Text
            Array(2) = txtScore6_2.Text
            Array(3) = txtScore6_3.Text
            Array(4) = txtScore6_4.Text
            Array(5) = txtScore6_5.Text
            Array(6) = lblAverage6.Text

            lineText = String.Join(",", Array)
            outPutFile.WriteLine(lineText)



            outPutFile.Close()
            blnIsChanged = False
        Catch
            MessageBox.Show("Error Opening the file content")
        End Try

    End Sub
    ' Read from file
    Sub ReadStudentRecord()
        If ofdOpenStudentFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            strFileName = ofdOpenStudentFile.FileName

            Dim lineText As String
            Dim Array() As String

            Try
                inPutFile = File.OpenText(strFileName)
                lineText = inPutFile.ReadLine()
                Array = lineText.Split(",")

                txtNOne.Text = Array(0)
                txtScore1_1.Text = Array(1)
                txtScore1_2.Text = Array(2)
                txtScore1_3.Text = Array(3)
                txtScore1_4.Text = Array(4)
                txtScore1_5.Text = Array(5)
                lblAverage1.Text = Array(6)

                lineText = inPutFile.ReadLine()
                Array = lineText.Split(",")

                txtNTwo.Text = Array(0)
                txtScore2_1.Text = Array(1)
                txtScore2_2.Text = Array(2)
                txtScore2_3.Text = Array(3)
                txtScore2_4.Text = Array(4)
                txtScore2_5.Text = Array(5)
                lblAverage2.Text = Array(6)

                lineText = inPutFile.ReadLine()
                Array = lineText.Split(",")

                txtNThree.Text = Array(0)
                txtScore3_1.Text = Array(1)
                txtScore3_2.Text = Array(2)
                txtScore3_3.Text = Array(3)
                txtScore3_4.Text = Array(4)
                txtScore3_5.Text = Array(5)
                lblAverage3.Text = Array(6)


                lineText = inPutFile.ReadLine()
                Array = lineText.Split(",")

                txtNFour.Text = Array(0)
                txtScore4_1.Text = Array(1)
                txtScore4_2.Text = Array(2)
                txtScore4_3.Text = Array(3)
                txtScore4_4.Text = Array(4)
                txtScore4_5.Text = Array(5)
                lblAverage4.Text = Array(6)

                lineText = inPutFile.ReadLine()
                Array = lineText.Split(",")

                txtNFive.Text = Array(0)
                txtScore5_1.Text = Array(1)
                txtScore5_2.Text = Array(2)
                txtScore5_3.Text = Array(3)
                txtScore5_4.Text = Array(4)
                txtScore5_5.Text = Array(5)
                lblAverage5.Text = Array(6)

                lineText = inPutFile.ReadLine()
                Array = lineText.Split(",")

                txtNSix.Text = Array(0)
                txtScore6_1.Text = Array(1)
                txtScore6_2.Text = Array(2)
                txtScore6_3.Text = Array(3)
                txtScore6_4.Text = Array(4)
                txtScore6_5.Text = Array(5)
                lblAverage6.Text = Array(6)



                inPutFile.Close()
                blnIsChanged = False
            Catch
                MessageBox.Show("Error Opening the file content")
            End Try
        End If
    End Sub

    ' Assign entered values to the arrays

    Sub StudentRecordEntry()

        Student(0).strName = txtNOne.Text
        Student(1).strName = txtNTwo.Text
        Student(2).strName = txtNThree.Text
        Student(3).strName = txtNFour.Text
        Student(4).strName = txtNFive.Text
        Student(5).strName = txtNSix.Text
        Try
            If CDbl(txtScore1_1.Text) < 0 Or CDbl(txtScore1_1.Text) > 100 Then
                If CDbl(txtScore2_1.Text) < 0 Or CDbl(txtScore2_1.Text) > 100 Then
                    If CDbl(txtScore3_1.Text) < 0 Or CDbl(txtScore3_1.Text) > 100 Then
                        If CDbl(txtScore4_1.Text) < 0 Or CDbl(txtScore4_1.Text) > 100 Then
                            If CDbl(txtScore5_1.Text) < 0 Or CDbl(txtScore5_1.Text) > 100 Then
                                If txtScore6_1.Text < 0 Or txtScore6_1.Text > 100 Then
                                    Student(0).dblTestScores(0) = CDbl(txtScore1_1.Text)
                                    Student(1).dblTestScores(1) = CDbl(txtScore2_1.Text)
                                    Student(2).dblTestScores(2) = CDbl(txtScore3_1.Text)
                                    Student(3).dblTestScores(3) = CDbl(txtScore4_1.Text)
                                    Student(4).dblTestScores(4) = CDbl(txtScore5_1.Text)
                                    Student(5).dblTestScores(5) = CDbl(txtScore6_1.Text)

                                End If
                            End If
                        End If
                    End If
                End If
            End If

            If CDbl(txtScore1_1.Text) < 0 Or CDbl(txtScore1_2.Text) > 100 Then
                If CDbl(txtScore2_1.Text) < 0 Or CDbl(txtScore2_2.Text) > 100 Then
                    If CDbl(txtScore3_1.Text) < 0 Or CDbl(txtScore3_2.Text) > 100 Then
                        If CDbl(txtScore4_1.Text) < 0 Or CDbl(txtScore4_2.Text) > 100 Then
                            If CDbl(txtScore5_1.Text) < 0 Or CDbl(txtScore5_2.Text) > 100 Then
                                If CDbl(txtScore6_1.Text) < 0 Or CDbl(txtScore6_2.Text) > 100 Then
                                    Student(0).dblTestScores(0) = CDbl(txtScore1_2.Text)
                                    Student(1).dblTestScores(1) = CDbl(txtScore2_2.Text)
                                    Student(2).dblTestScores(2) = CDbl(txtScore3_2.Text)
                                    Student(3).dblTestScores(3) = CDbl(txtScore4_2.Text)
                                    Student(4).dblTestScores(4) = CDbl(txtScore5_2.Text)
                                    Student(5).dblTestScores(5) = CDbl(txtScore6_2.Text)

                                End If
                            End If
                        End If
                    End If
                End If
            End If

            If CDbl(txtScore1_1.Text) < 0 Or CDbl(txtScore1_3.Text) > 100 Then
                If CDbl(txtScore2_1.Text) < 0 Or CDbl(txtScore2_3.Text) > 100 Then
                    If CDbl(txtScore3_1.Text) < 0 Or CDbl(txtScore3_3.Text) > 100 Then
                        If CDbl(txtScore4_1.Text) < 0 Or CDbl(txtScore4_3.Text) > 100 Then
                            If CDbl(txtScore5_1.Text) < 0 Or CDbl(txtScore5_3.Text) > 100 Then
                                If txtScore6_1.Text < 0 Or txtScore6_3.Text > 100 Then
                                    Student(0).dblTestScores(0) = CDbl(txtScore1_3.Text)
                                    Student(1).dblTestScores(1) = CDbl(txtScore2_3.Text)
                                    Student(2).dblTestScores(2) = CDbl(txtScore3_3.Text)
                                    Student(3).dblTestScores(3) = CDbl(txtScore4_3.Text)
                                    Student(4).dblTestScores(4) = CDbl(txtScore5_3.Text)
                                    Student(5).dblTestScores(5) = CDbl(txtScore6_3.Text)

                                End If
                            End If
                        End If
                    End If
                End If
            End If
            If CDbl(txtScore1_1.Text) < 0 Or CDbl(txtScore1_4.Text) > 100 Then
                If CDbl(txtScore2_1.Text) < 0 Or CDbl(txtScore2_4.Text) > 100 Then
                    If CDbl(txtScore3_1.Text) < 0 Or CDbl(txtScore3_4.Text) > 100 Then
                        If CDbl(txtScore4_1.Text) < 0 Or CDbl(txtScore4_4.Text) > 100 Then
                            If CDbl(txtScore5_1.Text) < 0 Or CDbl(txtScore5_4.Text) > 100 Then
                                If CDbl(txtScore6_1.Text) < 0 Or CDbl(txtScore6_4.Text) > 100 Then
                                    Student(0).dblTestScores(0) = CDbl(txtScore1_4.Text)
                                    Student(1).dblTestScores(1) = CDbl(txtScore2_4.Text)
                                    Student(2).dblTestScores(2) = CDbl(txtScore3_4.Text)
                                    Student(3).dblTestScores(3) = CDbl(txtScore4_4.Text)
                                    Student(4).dblTestScores(4) = CDbl(txtScore5_4.Text)
                                    Student(5).dblTestScores(5) = CDbl(txtScore6_4.Text)

                                End If
                            End If
                        End If
                    End If
                End If
            End If
            If CDbl(txtScore1_1.Text) < 0 Or CDbl(txtScore1_5.Text) > 100 Then
                If CDbl(txtScore2_1.Text) < 0 Or CDbl(txtScore2_5.Text) > 100 Then
                    If CDbl(txtScore3_1.Text) < 0 Or CDbl(txtScore3_5.Text) > 100 Then
                        If CDbl(txtScore4_1.Text) < 0 Or CDbl(txtScore4_5.Text) > 100 Then
                            If CDbl(txtScore5_1.Text) < 0 Or CDbl(txtScore5_5.Text) > 100 Then
                                If CDbl(txtScore6_1.Text) < 0 Or CDbl(txtScore6_5.Text) > 100 Then
                                    Student(0).dblTestScores(0) = CDbl(txtScore1_5.Text)
                                    Student(1).dblTestScores(1) = CDbl(txtScore2_5.Text)
                                    Student(2).dblTestScores(2) = CDbl(txtScore3_5.Text)
                                    Student(3).dblTestScores(3) = CDbl(txtScore4_5.Text)
                                    Student(4).dblTestScores(4) = CDbl(txtScore5_5.Text)
                                    Student(5).dblTestScores(5) = CDbl(txtScore6_5.Text)

                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Catch
            MessageBox.Show(" Enter only numbers 0 and above or 100 and below  ")
        End Try
    End Sub

    ' Calculate avarage

    Function FirstStudentScoresAverage()
        StudentRecordEntry()
        dblScore1 = CDbl(txtScore1_1.Text)
        dblScore2 = CDbl(txtScore1_2.Text)
        dblScore3 = CDbl(txtScore1_3.Text)
        dblScore4 = CDbl(txtScore1_4.Text)
        dblScore5 = CDbl(txtScore1_5.Text)
        Return (dblScore1 + dblScore2 + dblScore3 + dblScore4 + dblScore5) / 5
    End Function
    ' Calculate avarage
    Function SecondStudentScoresAverage()
        StudentRecordEntry()
        dblScore1 = CDbl(txtScore2_1.Text)
        dblScore2 = CDbl(txtScore2_2.Text)
        dblScore3 = CDbl(txtScore2_3.Text)
        dblScore4 = CDbl(txtScore2_4.Text)
        dblScore5 = CDbl(txtScore2_5.Text)
        Return (dblScore1 + dblScore2 + dblScore3 + dblScore4 + dblScore5) / 5
    End Function
    ' Calculate avarage
    Function ThirdStudentScoresAverage()
        StudentRecordEntry()
        dblScore1 = CDbl(txtScore3_1.Text)
        dblScore2 = CDbl(txtScore3_2.Text)
        dblScore3 = CDbl(txtScore3_3.Text)
        dblScore4 = CDbl(txtScore3_4.Text)
        dblScore5 = CDbl(txtScore3_5.Text)
        Return (dblScore1 + dblScore2 + dblScore3 + dblScore4 + dblScore5) / 5
    End Function
    ' Calculate avarage
    Function FourthStudentScoresAverage()
        StudentRecordEntry()
        dblScore1 = CDbl(txtScore4_1.Text)
        dblScore2 = CDbl(txtScore4_2.Text)
        dblScore3 = CDbl(txtScore4_3.Text)
        dblScore4 = CDbl(txtScore4_4.Text)
        dblScore5 = CDbl(txtScore4_5.Text)
        Return (dblScore1 + dblScore2 + dblScore3 + dblScore4 + dblScore5) / 5
    End Function
    ' Calculate avarage
    Function FivthStudentScoresAverage()
        StudentRecordEntry()
        dblScore1 = CDbl(txtScore5_1.Text)
        dblScore2 = CDbl(txtScore5_2.Text)
        dblScore3 = CDbl(txtScore5_3.Text)
        dblScore4 = CDbl(txtScore5_4.Text)
        dblScore5 = CDbl(txtScore5_5.Text)
        Return (dblScore1 + dblScore2 + dblScore3 + dblScore4 + dblScore5) / 5
    End Function
    ' Calculate avarage 
    Function sixthStudentScoresAverage()
        StudentRecordEntry()
        dblScore1 = CDbl(txtScore6_1.Text)
        dblScore2 = CDbl(txtScore6_2.Text)
        dblScore3 = CDbl(txtScore6_3.Text)
        dblScore4 = CDbl(txtScore6_4.Text)
        dblScore5 = CDbl(txtScore6_5.Text)
        Return (dblScore1 + dblScore2 + dblScore3 + dblScore4 + dblScore5) / 5
    End Function

    Sub ClearContent()
        'This clears the contents of the textboxes 
        txtNOne.Clear()
        txtNTwo.Clear()
        txtNThree.Clear()
        txtNFour.Clear()
        txtNFive.Clear()
        txtNSix.Clear()
        txtScore1_1.Clear()
        txtScore1_2.Clear()
        txtScore1_3.Clear()
        txtScore1_4.Clear()
        txtScore1_5.Clear()
        txtScore2_1.Clear()
        txtScore2_2.Clear()
        txtScore2_3.Clear()
        txtScore2_4.Clear()
        txtScore2_5.Clear()
        txtScore3_1.Clear()
        txtScore3_2.Clear()
        txtScore3_3.Clear()
        txtScore3_4.Clear()
        txtScore3_5.Clear()
        txtScore4_1.Clear()
        txtScore4_2.Clear()
        txtScore4_3.Clear()
        txtScore4_4.Clear()
        txtScore4_5.Clear()
        txtScore5_1.Clear()
        txtScore5_2.Clear()
        txtScore5_3.Clear()
        txtScore5_4.Clear()
        txtScore5_5.Clear()
        txtScore6_1.Clear()
        txtScore6_2.Clear()
        txtScore6_3.Clear()
        txtScore6_4.Clear()
        txtScore6_5.Clear()
        'This clears the contents of the  labels
        lblAverage1.Text = String.Empty
        lblAverage2.Text = String.Empty
        lblAverage3.Text = String.Empty
        lblAverage4.Text = String.Empty
        lblAverage5.Text = String.Empty
        lblAverage6.Text = String.Empty

        strFileName = String.Empty
        blnIsChanged = False


    End Sub



    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Assign the averages to the corrosponding labels
        lblAverage1.Text = FirstStudentScoresAverage().ToString()
        lblAverage2.Text = SecondStudentScoresAverage().ToString()
        lblAverage3.Text = ThirdStudentScoresAverage().ToString()
        lblAverage4.Text = FourthStudentScoresAverage().ToString()
        lblAverage5.Text = FivthStudentScoresAverage().ToString()
        lblAverage6.Text = sixthStudentScoresAverage().ToString()

    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        ' Close form
        Me.Close()
    End Sub

    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        'About message
        MessageBox.Show("Programming Challenge 3: Student Test Scores")
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        'display open dialogue box
        If blnIsChanged = True Then
            If MessageBox.Show("The current data is not saved." &
                               "Are you sure?", "Confirm", MessageBoxButtons.YesNo) =
                               Windows.Forms.DialogResult.Yes Then
                ClearContent()
                ReadStudentRecord()
            End If
        Else
            ClearContent()
            ReadStudentRecord()
        End If
    End Sub

    Private Sub mnuFileSaveAs_Click(sender As Object, e As EventArgs) Handles mnuFileSaveAs.Click
        ' set title and filter and Save file 
        sfdSaveStudentFile.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*"
        sfdSaveStudentFile.Title = "Saving Student Record"
        If sfdSaveStudentFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            strFileName = sfdSaveStudentFile.FileName
            WriteStudentRecord()

        End If
    End Sub

    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click
        ' set title and filter and Save file 
        With sfdSaveStudentFile
            .Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*"
            .Title = "Saving Student Record"
            If strFileName = String.Empty Then
                If sfdSaveStudentFile.ShowDialog = Windows.Forms.DialogResult.OK Then
                    strFileName = sfdSaveStudentFile.FileName
                    WriteStudentRecord()

                End If
            End If
        End With
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        ' clear all text boxes and label
        ClearContent()
    End Sub

    Private Sub mnuReportPrint_Click(sender As Object, e As EventArgs) Handles mnuReportPrint.Click
        'Send file to printer
        pdPrint.Print()
    End Sub

    Private Sub pdPrint_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdPrint.PrintPage
        'Printer setup

        Dim intx As Integer = 10 '
        Dim intY As Integer = 10
        Try
            inPutFile = File.OpenText(strFileName)
            Do While Not inPutFile.EndOfStream
                e.Graphics.DrawString(inPutFile.ReadLine(),
                                      New Font("Courier", 10, FontStyle.Regular),
                                      Brushes.Black, intx, intY)
                intY += 12

            Loop
            inPutFile.Close()
        Catch
            MessageBox.Show("Error: Could not open file")

        End Try

    End Sub
End Class
