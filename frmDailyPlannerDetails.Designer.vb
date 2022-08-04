<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDailyPlannerDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lstDetails = New System.Windows.Forms.ListBox()
        Me.lblTaskLabel = New System.Windows.Forms.Label()
        Me.lblDateLabel = New System.Windows.Forms.Label()
        Me.lblTimeLabel = New System.Windows.Forms.Label()
        Me.lblCategoryLabel = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.txtTask = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.MaskedTextBox()
        Me.txtTime = New System.Windows.Forms.MaskedTextBox()
        Me.chkComplete = New System.Windows.Forms.CheckBox()
        Me.btnColor = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.dlgColorDialog = New System.Windows.Forms.ColorDialog()
        Me.SuspendLayout()
        '
        'lstDetails
        '
        Me.lstDetails.FormattingEnabled = True
        Me.lstDetails.HorizontalScrollbar = True
        Me.lstDetails.ItemHeight = 19
        Me.lstDetails.Location = New System.Drawing.Point(12, 12)
        Me.lstDetails.Name = "lstDetails"
        Me.lstDetails.Size = New System.Drawing.Size(354, 612)
        Me.lstDetails.TabIndex = 0
        '
        'lblTaskLabel
        '
        Me.lblTaskLabel.AutoSize = True
        Me.lblTaskLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTaskLabel.Location = New System.Drawing.Point(384, 30)
        Me.lblTaskLabel.Name = "lblTaskLabel"
        Me.lblTaskLabel.Size = New System.Drawing.Size(51, 25)
        Me.lblTaskLabel.TabIndex = 1
        Me.lblTaskLabel.Text = "Task:"
        '
        'lblDateLabel
        '
        Me.lblDateLabel.AutoSize = True
        Me.lblDateLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDateLabel.Location = New System.Drawing.Point(384, 100)
        Me.lblDateLabel.Name = "lblDateLabel"
        Me.lblDateLabel.Size = New System.Drawing.Size(55, 25)
        Me.lblDateLabel.TabIndex = 2
        Me.lblDateLabel.Text = "Date:"
        '
        'lblTimeLabel
        '
        Me.lblTimeLabel.AutoSize = True
        Me.lblTimeLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTimeLabel.Location = New System.Drawing.Point(384, 175)
        Me.lblTimeLabel.Name = "lblTimeLabel"
        Me.lblTimeLabel.Size = New System.Drawing.Size(138, 25)
        Me.lblTimeLabel.TabIndex = 3
        Me.lblTimeLabel.Text = "Time: (HH:MM)"
        '
        'lblCategoryLabel
        '
        Me.lblCategoryLabel.AutoSize = True
        Me.lblCategoryLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCategoryLabel.Location = New System.Drawing.Point(384, 286)
        Me.lblCategoryLabel.Name = "lblCategoryLabel"
        Me.lblCategoryLabel.Size = New System.Drawing.Size(92, 25)
        Me.lblCategoryLabel.TabIndex = 4
        Me.lblCategoryLabel.Text = "Category:"
        '
        'lblCategory
        '
        Me.lblCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCategory.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCategory.Location = New System.Drawing.Point(384, 322)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(165, 30)
        Me.lblCategory.TabIndex = 5
        '
        'txtTask
        '
        Me.txtTask.Location = New System.Drawing.Point(384, 58)
        Me.txtTask.Name = "txtTask"
        Me.txtTask.Size = New System.Drawing.Size(165, 26)
        Me.txtTask.TabIndex = 6
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(384, 128)
        Me.txtDate.Mask = "00/00/0000"
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(165, 26)
        Me.txtDate.TabIndex = 7
        Me.txtDate.ValidatingType = GetType(Date)
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(384, 203)
        Me.txtTime.Mask = "90:00"
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(165, 26)
        Me.txtTime.TabIndex = 8
        Me.txtTime.ValidatingType = GetType(Date)
        '
        'chkComplete
        '
        Me.chkComplete.Location = New System.Drawing.Point(384, 235)
        Me.chkComplete.Name = "chkComplete"
        Me.chkComplete.Size = New System.Drawing.Size(97, 30)
        Me.chkComplete.TabIndex = 9
        Me.chkComplete.Text = "Complete ?"
        Me.chkComplete.UseVisualStyleBackColor = True
        '
        'btnColor
        '
        Me.btnColor.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnColor.Location = New System.Drawing.Point(384, 358)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(125, 30)
        Me.btnColor.TabIndex = 10
        Me.btnColor.Text = "Color"
        Me.btnColor.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAdd.Location = New System.Drawing.Point(384, 424)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(125, 30)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRemove.Location = New System.Drawing.Point(384, 460)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(125, 30)
        Me.btnRemove.TabIndex = 12
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSave.Location = New System.Drawing.Point(384, 527)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(125, 30)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Enabled = False
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCancel.Location = New System.Drawing.Point(384, 563)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(125, 30)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmDailyPlannerDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 642)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnColor)
        Me.Controls.Add(Me.chkComplete)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtTask)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.lblCategoryLabel)
        Me.Controls.Add(Me.lblTimeLabel)
        Me.Controls.Add(Me.lblDateLabel)
        Me.Controls.Add(Me.lblTaskLabel)
        Me.Controls.Add(Me.lstDetails)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmDailyPlannerDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daily Planner Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstDetails As ListBox
    Friend WithEvents lblTaskLabel As Label
    Friend WithEvents lblDateLabel As Label
    Friend WithEvents lblTimeLabel As Label
    Friend WithEvents lblCategoryLabel As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents txtTask As TextBox
    Friend WithEvents txtDate As MaskedTextBox
    Friend WithEvents txtTime As MaskedTextBox
    Friend WithEvents chkComplete As CheckBox
    Friend WithEvents btnColor As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents dlgColorDialog As ColorDialog
End Class
