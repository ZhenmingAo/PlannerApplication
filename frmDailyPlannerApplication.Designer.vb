<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDailyPlannerApplication
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblFilesLabel = New System.Windows.Forms.Label()
        Me.lblFileNameLabel = New System.Windows.Forms.Label()
        Me.lstFiles = New System.Windows.Forms.ListBox()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.btnCreateFile = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPrintFile = New System.Windows.Forms.Button()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.dlgOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'lblFilesLabel
        '
        Me.lblFilesLabel.AutoSize = True
        Me.lblFilesLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblFilesLabel.Location = New System.Drawing.Point(51, 27)
        Me.lblFilesLabel.Name = "lblFilesLabel"
        Me.lblFilesLabel.Size = New System.Drawing.Size(44, 21)
        Me.lblFilesLabel.TabIndex = 0
        Me.lblFilesLabel.Text = "Files:"
        '
        'lblFileNameLabel
        '
        Me.lblFileNameLabel.AutoSize = True
        Me.lblFileNameLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblFileNameLabel.Location = New System.Drawing.Point(51, 331)
        Me.lblFileNameLabel.Name = "lblFileNameLabel"
        Me.lblFileNameLabel.Size = New System.Drawing.Size(79, 21)
        Me.lblFileNameLabel.TabIndex = 1
        Me.lblFileNameLabel.Text = "FileName:"
        '
        'lstFiles
        '
        Me.lstFiles.FormattingEnabled = True
        Me.lstFiles.HorizontalScrollbar = True
        Me.lstFiles.ItemHeight = 19
        Me.lstFiles.Location = New System.Drawing.Point(51, 51)
        Me.lstFiles.Name = "lstFiles"
        Me.lstFiles.Size = New System.Drawing.Size(484, 194)
        Me.lstFiles.TabIndex = 2
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(136, 329)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(399, 26)
        Me.txtFileName.TabIndex = 3
        '
        'btnCreateFile
        '
        Me.btnCreateFile.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCreateFile.Location = New System.Drawing.Point(85, 271)
        Me.btnCreateFile.Name = "btnCreateFile"
        Me.btnCreateFile.Size = New System.Drawing.Size(100, 30)
        Me.btnCreateFile.TabIndex = 4
        Me.btnCreateFile.Text = "Create File"
        Me.btnCreateFile.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.Location = New System.Drawing.Point(403, 271)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 30)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnPrintFile
        '
        Me.btnPrintFile.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnPrintFile.Location = New System.Drawing.Point(297, 271)
        Me.btnPrintFile.Name = "btnPrintFile"
        Me.btnPrintFile.Size = New System.Drawing.Size(100, 30)
        Me.btnPrintFile.TabIndex = 6
        Me.btnPrintFile.Text = "Print File"
        Me.btnPrintFile.UseVisualStyleBackColor = True
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnOpenFile.Location = New System.Drawing.Point(191, 271)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(100, 30)
        Me.btnOpenFile.TabIndex = 7
        Me.btnOpenFile.Text = "Open File"
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'dlgOpenFileDialog
        '
        Me.dlgOpenFileDialog.FileName = "OpenFileDialog1"
        '
        'frmDailyPlannerApplication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 401)
        Me.Controls.Add(Me.btnOpenFile)
        Me.Controls.Add(Me.btnPrintFile)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCreateFile)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.lstFiles)
        Me.Controls.Add(Me.lblFileNameLabel)
        Me.Controls.Add(Me.lblFilesLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmDailyPlannerApplication"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daily Planner Application"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFilesLabel As Label
    Friend WithEvents lblFileNameLabel As Label
    Friend WithEvents lstFiles As ListBox
    Friend WithEvents txtFileName As TextBox
    Friend WithEvents btnCreateFile As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnPrintFile As Button
    Friend WithEvents btnOpenFile As Button
    Friend WithEvents dlgOpenFileDialog As OpenFileDialog
End Class
