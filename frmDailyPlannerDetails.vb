Imports System.IO
Imports System.Drawing.Printing

Public Class frmDailyPlannerDetails
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Collect task info
        If txtTask.Text = Nothing Then
            MsgBox("Please enter a valid task name!", MsgBoxStyle.Information, "Task Name Empty")
        ElseIf txtDate.Text = Nothing Or IsDate(txtDate.Text) = False Then
            MsgBox("Please enter a valid date! (MM/dd/yyyy)", MsgBoxStyle.Information, "Date Error")
        ElseIf txtTime.Text = Nothing Or IsDate(txtTime.Text) = False Then
            MsgBox("Please enter a valid time! (HH:mm)", MsgBoxStyle.Information, "Time Error")
        ElseIf lblCategory.Text = Nothing Then
            MsgBox("Please pick a valid color!", MsgBoxStyle.Information, "Color Error")
        Else
            ' Create task info objects
            Dim tiTaskInfo As TaskInfo
            With tiTaskInfo
                .strName = txtTask.Text
                .dtDate = txtDate.Text
                .dtTime = txtTime.Text
                .blnComplete = chkComplete.CheckState
                .strCategory = lblCategory.Text
            End With
            ' Add task info to list box and then clear TextBoxes, Label and uncheck Complete
            lstDetails.Items.Add(tiTaskInfo.strName & ", " & tiTaskInfo.dtDate.ToString("MM/dd/yyyy") & ", " & tiTaskInfo.dtTime.ToString("HH:mm") & ", " & tiTaskInfo.blnComplete.ToString & ", " & tiTaskInfo.strCategory)
        End If
        Clear()
        ValidateList()
    End Sub
    Public Sub Clear()
        ' Clear method
        txtTask.Text = Nothing
        txtDate.Text = Nothing
        txtTime.Text = Nothing
        chkComplete.CheckState = CheckState.Unchecked
        lblCategory.Text = Nothing
        ValidateList()
    End Sub
    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click
        Dim objDialog As DialogResult
        objDialog = dlgColorDialog.ShowDialog
        If objDialog = Windows.Forms.DialogResult.OK Then
            lblCategory.ForeColor = dlgColorDialog.Color
            lblCategory.Text = dlgColorDialog.Color.ToString
        End If
        ValidateList()
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim intIndex As Integer
        ' remove selected item
        intIndex = lstDetails.SelectedIndex
        If intIndex <> -1 Then
            lstDetails.Items.RemoveAt(intIndex)
        Else
            MsgBox("No item selected!", MsgBoxStyle.Information, "Error")
        End If
        ValidateList()
    End Sub
    Private Sub lstDetails_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstDetails.SelectedIndexChanged
        ' As the user selects an item in the list, it populates Task, Date, Time, Complete, and Category fields
        If lstDetails.SelectedItem <> "" Then
            If Not lstDetails.SelectedItem.ToString.Contains(",") Then
                Clear()
                MsgBox("Data not seperated by "","" ", MsgBoxStyle.Information, "Display Error")
            Else
                Dim strSelectedItem As String = lstDetails.SelectedItem.ToString
                Dim strArray() As String = Split(strSelectedItem, ",")
                Try
                    txtTask.Text = strArray(0)
                    txtDate.Text = strArray(1).Trim
                    txtTime.Text = strArray(2).Trim
                    lblCategory.Text = strArray(4).Trim
                    lblCategory.ForeColor = Color.Black
                    If strArray(3).Trim = "True" Then
                        chkComplete.CheckState = CheckState.Checked
                    ElseIf strArray(3).Trim = "False" Then
                        chkComplete.CheckState = CheckState.Unchecked
                    Else
                        chkComplete.CheckState = CheckState.Unchecked
                    End If
                Catch ex As Exception
                    Clear()
                    MsgBox("You've selected an invalid item! (The item you selected has missing data)", MsgBoxStyle.Information, "Missing data")
                End Try

            End If
        Else
            Clear()
        End If
        ValidateList()
    End Sub

    Private Sub ValidateList()
        If lstDetails.Items.Count < 1 Then
            btnSave.Enabled = False
            btnCancel.Enabled = False
        Else
            btnSave.Enabled = True
            btnCancel.Enabled = True
        End If
    End Sub

    Private Sub frmDailyPlannerDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ValidateList()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Reopen the file to write and save
        Dim objWriteFile As StreamWriter
        objWriteFile = File.CreateText(frmDailyPlannerApplication.txtFileName.Text)
        For Each strItem As String In lstDetails.Items
            objWriteFile.WriteLine(strItem)
        Next
        objWriteFile.Close()
        frmDailyPlannerApplication.txtFileName.Text = ""
        Me.Close()
        frmDailyPlannerApplication.txtFileName.Text = ""
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ' Create a YES/NO prompt Message Box
        Dim answer As Integer
        answer = MsgBox("Pending changes, sure you want to cancel?", vbQuestion + vbYesNo + vbDefaultButton2, "Confirmation")
        If answer = vbYes Then
            Me.Close()
            frmDailyPlannerApplication.txtFileName.Text = ""
        End If
    End Sub
End Class