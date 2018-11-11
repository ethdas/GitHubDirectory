Imports System.IO

Module CustomerAccountsModule

    Public Structure CustomerAccounts
        Public CustomerNumber As String
        Public FirstName As String
        Public LastName As String
        Public Address As String
        Public City As String
        Public State As String
        Public ZipCode As String
        Public TelephoneNumber As String
        Public AccountBallance As String
        Public DateofLastPayment As String
    End Structure
    Public Sub SbyAccnumber()
        Dim inputFound As String
        Dim ReadAccount As StreamReader

        ReadAccount = File.OpenText("Content.txt")
        Dim X As String = InputBox("Type Account number ")
        frmMain.lblDisplay.Text = String.Empty
        While Not ReadAccount.EndOfStream
            Try
                inputFound = ReadAccount.ReadLine()
                Dim arryList() As String = inputFound.Split(",")
                If (arryList(0).Contains(X)) = True Then
                    frmMain.lblDisplay.Text = inputFound

                    Exit While

                End If
            Catch
                frmMain.lblDisplay.Text = "Humm ... the requested Account Number may not exist or
                Have you mis something?"
            End Try

        End While

        ReadAccount.Close()
    End Sub

    Public Sub SbyLastName()
        Dim inputFound As String
        Dim ReadFile As StreamReader

        ReadFile = File.OpenText("Content.txt")
        Dim X As String = InputBox("Type Last name  ")
        frmMain.lblDisplay.Text = String.Empty
        While Not ReadFile.EndOfStream
            Try
                inputFound = ReadFile.ReadLine()
                Dim arryList() As String = inputFound.Split(",")
                If (arryList(1).Contains(X)) = True Then
                    frmMain.lblDisplay.Text = inputFound

                    Exit While

                End If
            Catch
                frmMain.lblDisplay.Text = "Humm ... the requested Name may not exist or
                Have you mis spelled it?"
            End Try

        End While

        ReadFile.Close()
    End Sub

    'Public Sub ShowMyName()
    '    Dim EachLine As String
    '    Dim TheTextFile As StreamReader

    '    TheTextFile = File.OpenText("Aeis.txt")

    '    While Not TheTextFile.EndOfStream
    '        Try
    '            EachLine = TheTextFile.ReadLine()

    '            If EachLine.Contains("D") Then
    '                If EachLine.Contains("a") Then
    '                    If EachLine.Contains("n") Then
    '                        If EachLine.Contains("i") Then
    '                            If EachLine.Contains("e") Then
    '                                If EachLine.Contains("l") Then
    '                                    If EachLine.Contains("N") Then
    '                                        If EachLine.Contains("e") Then
    '                                            If EachLine.Contains("w") Then
    '                                                If EachLine.Contains("a") Then
    '                                                    If EachLine.Contains("y") Then
    '                                                        frmMain.lblMyName.Text =
    '                                                        "D" + "a" + "n" + "i" + "e" + "l" + "" +
    '                                                        "N" + "e" + "w" + "a" + "y"
    '                                                    End If
    '                                                End If
    '                                            End If
    '                                        End If
    '                                    End If
    '                                    End If
    '                                End If
    '                        End If

    '                    End If
    '                End If


    '            Exit While

    '            End If
    '        Catch
    '            frmMain.lblDisplay.Text = "Humm ... the requested Name may not exist or
    '            Have you mis spelled it?"
    '        End Try

    '    End While

    '    TheTextFile.Close()

    'End Sub



End Module
