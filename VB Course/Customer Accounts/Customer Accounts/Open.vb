
Imports System.IO
Public Class Open


    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        'Dim inputFound As String
        Dim ReadFile As StreamReader

        ReadFile = File.OpenText("Content.txt")

        txtOpen.Text = ReadFile.ReadToEnd()


        ReadFile.Close()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class