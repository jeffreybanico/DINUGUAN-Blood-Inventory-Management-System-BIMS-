<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class restoreForm
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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.restoreTxt = New System.Windows.Forms.TextBox()
        Me.btnBrowseRestore = New System.Windows.Forms.Button()
        Me.btnRestoreFile = New System.Windows.Forms.Button()
        Me.btnCancelRestore = New System.Windows.Forms.Button()
        Me.restoreLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'restoreTxt
        '
        Me.restoreTxt.Location = New System.Drawing.Point(79, 112)
        Me.restoreTxt.Name = "restoreTxt"
        Me.restoreTxt.Size = New System.Drawing.Size(286, 23)
        Me.restoreTxt.TabIndex = 0
        '
        'btnBrowseRestore
        '
        Me.btnBrowseRestore.Location = New System.Drawing.Point(353, 111)
        Me.btnBrowseRestore.Name = "btnBrowseRestore"
        Me.btnBrowseRestore.Size = New System.Drawing.Size(75, 24)
        Me.btnBrowseRestore.TabIndex = 1
        Me.btnBrowseRestore.Text = "Browse"
        Me.btnBrowseRestore.UseVisualStyleBackColor = True
        '
        'btnRestoreFile
        '
        Me.btnRestoreFile.Location = New System.Drawing.Point(130, 157)
        Me.btnRestoreFile.Name = "btnRestoreFile"
        Me.btnRestoreFile.Size = New System.Drawing.Size(113, 38)
        Me.btnRestoreFile.TabIndex = 2
        Me.btnRestoreFile.Text = "Restore"
        Me.btnRestoreFile.UseVisualStyleBackColor = True
        '
        'btnCancelRestore
        '
        Me.btnCancelRestore.Location = New System.Drawing.Point(249, 157)
        Me.btnCancelRestore.Name = "btnCancelRestore"
        Me.btnCancelRestore.Size = New System.Drawing.Size(113, 38)
        Me.btnCancelRestore.TabIndex = 3
        Me.btnCancelRestore.Text = "Cancel"
        Me.btnCancelRestore.UseVisualStyleBackColor = True
        '
        'restoreLabel
        '
        Me.restoreLabel.AutoSize = True
        Me.restoreLabel.BackColor = System.Drawing.Color.Transparent
        Me.restoreLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.restoreLabel.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.restoreLabel.Location = New System.Drawing.Point(79, 90)
        Me.restoreLabel.Name = "restoreLabel"
        Me.restoreLabel.Size = New System.Drawing.Size(132, 19)
        Me.restoreLabel.TabIndex = 4
        Me.restoreLabel.Text = "Select Database File:"
        '
        'restoreForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ForgotPassword.My.Resources.Resources.DINUGUAN__1_
        Me.ClientSize = New System.Drawing.Size(495, 277)
        Me.Controls.Add(Me.restoreLabel)
        Me.Controls.Add(Me.btnCancelRestore)
        Me.Controls.Add(Me.btnRestoreFile)
        Me.Controls.Add(Me.btnBrowseRestore)
        Me.Controls.Add(Me.restoreTxt)
        Me.Name = "restoreForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Restore Database"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents restoreTxt As TextBox
    Friend WithEvents btnBrowseRestore As Button
    Friend WithEvents btnRestoreFile As Button
    Friend WithEvents btnCancelRestore As Button
    Friend WithEvents restoreLabel As Label
End Class
