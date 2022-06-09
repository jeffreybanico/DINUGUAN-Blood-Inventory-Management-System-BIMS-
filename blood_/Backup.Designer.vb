<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class backupForm
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
        Me.pathTextBox = New System.Windows.Forms.TextBox()
        Me.labelPath = New System.Windows.Forms.Label()
        Me.btnBrowsePath = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnCancelBackup = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'pathTextBox
        '
        Me.pathTextBox.Location = New System.Drawing.Point(64, 97)
        Me.pathTextBox.Name = "pathTextBox"
        Me.pathTextBox.Size = New System.Drawing.Size(274, 23)
        Me.pathTextBox.TabIndex = 0
        '
        'labelPath
        '
        Me.labelPath.AutoSize = True
        Me.labelPath.BackColor = System.Drawing.Color.Transparent
        Me.labelPath.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelPath.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.labelPath.Location = New System.Drawing.Point(64, 75)
        Me.labelPath.Name = "labelPath"
        Me.labelPath.Size = New System.Drawing.Size(79, 19)
        Me.labelPath.TabIndex = 1
        Me.labelPath.Text = "Select Path:"
        '
        'btnBrowsePath
        '
        Me.btnBrowsePath.Location = New System.Drawing.Point(328, 97)
        Me.btnBrowsePath.Name = "btnBrowsePath"
        Me.btnBrowsePath.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowsePath.TabIndex = 2
        Me.btnBrowsePath.Text = "Browse"
        Me.btnBrowsePath.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(86, 160)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(131, 33)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save Backup"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancelBackup
        '
        Me.btnCancelBackup.Location = New System.Drawing.Point(223, 160)
        Me.btnCancelBackup.Name = "btnCancelBackup"
        Me.btnCancelBackup.Size = New System.Drawing.Size(131, 33)
        Me.btnCancelBackup.TabIndex = 7
        Me.btnCancelBackup.Text = "Cancel"
        Me.btnCancelBackup.UseVisualStyleBackColor = True
        '
        'backupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ForgotPassword.My.Resources.Resources.DINUGUAN__1_
        Me.ClientSize = New System.Drawing.Size(496, 279)
        Me.Controls.Add(Me.btnCancelBackup)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnBrowsePath)
        Me.Controls.Add(Me.labelPath)
        Me.Controls.Add(Me.pathTextBox)
        Me.Name = "backupForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Backup Database"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pathTextBox As TextBox
    Friend WithEvents labelPath As Label
    Friend WithEvents btnBrowsePath As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents btnCancelBackup As Button
End Class
