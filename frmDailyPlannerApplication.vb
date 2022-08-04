'Affirmation of Authorship:

'Name: Zhenming Ao

'Date: 6/23/2022

'I affirm that this program was created by me. It is solely my work and ‘does not include any work done by anyone else.

' import libraries
Imports System.IO
Imports System.Drawing.Printing

Public Class frmDailyPlannerApplication
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCreateFile_Click(sender As Object, e As EventArgs) Handles btnCreateFile.Click
        ' Create a file
        Dim objWriteFile As StreamWriter
        Dim strFileName As String

        If txtFileName.Text = "" Then
            MsgBox("Please enter a valid file name!", MsgBoxStyle.Information, "Error")
        Else
            strFileName = txtFileName.Text
            objWriteFile = File.CreateText(strFileName)
            frmDailyPlannerDetails.lstDetails.Items.Clear()

            ' Check for duplicate file names
            Dim blnDupe As Boolean = False
            For Each strListItem As String In lstFiles.Items
                If strListItem = Path.GetFullPath(strFileName) Then
                    blnDupe = True
                End If
            Next
            If blnDupe = False Then
                lstFiles.Items.Add(Path.GetFullPath(strFileName))
            End If


            objWriteFile.Close()
            frmDailyPlannerDetails.Clear()
            frmDailyPlannerDetails.ShowDialog()
        End If

    End Sub

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        ' open selected file
        Dim objReadFile As StreamReader
        Dim objDialog As DialogResult
        dlgOpenFileDialog.Filter = "txt Files (Text Files)|*.txt"
        objDialog = dlgOpenFileDialog.ShowDialog
        If objDialog = Windows.Forms.DialogResult.OK Then
            txtFileName.Text = dlgOpenFileDialog.FileName

            ' Check for duplicate file names
            Dim blnDupe As Boolean = False
            For Each strListItem As String In lstFiles.Items
                If strListItem = dlgOpenFileDialog.FileName Then
                    blnDupe = True
                End If
            Next
            If blnDupe = False Then
                lstFiles.Items.Add(dlgOpenFileDialog.FileName)
            End If

            ' Open file and read each line to details list
            frmDailyPlannerDetails.lstDetails.Items.Clear()
            objReadFile = File.OpenText(dlgOpenFileDialog.FileName)
            Do Until objReadFile.EndOfStream
                frmDailyPlannerDetails.lstDetails.Items.Add(objReadFile.ReadLine)
            Loop
            objReadFile.Close()
            frmDailyPlannerDetails.Clear()
            frmDailyPlannerDetails.ShowDialog()
        End If
    End Sub
End Class
