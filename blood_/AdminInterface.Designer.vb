<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminInterface
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
        Me.labelBIMS3 = New System.Windows.Forms.Label()
        Me.labelDinuguan3 = New System.Windows.Forms.Label()
        Me.btnDonorList = New System.Windows.Forms.Button()
        Me.btnBloodInventory = New System.Windows.Forms.Button()
        Me.btnRequests = New System.Windows.Forms.Button()
        Me.btnBackupDB = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtDate = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUserLogs = New System.Windows.Forms.Button()
        Me.btnUserList = New System.Windows.Forms.Button()
        Me.btnRestoreDB = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'labelBIMS3
        '
        Me.labelBIMS3.AutoSize = True
        Me.labelBIMS3.BackColor = System.Drawing.Color.Transparent
        Me.labelBIMS3.Font = New System.Drawing.Font("Imprint MT Shadow", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelBIMS3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.labelBIMS3.Location = New System.Drawing.Point(221, 112)
        Me.labelBIMS3.Name = "labelBIMS3"
        Me.labelBIMS3.Size = New System.Drawing.Size(355, 18)
        Me.labelBIMS3.TabIndex = 8
        Me.labelBIMS3.Text = "BLOOD INVENTORY MANAGEMENT SYSTEM"
        '
        'labelDinuguan3
        '
        Me.labelDinuguan3.AutoSize = True
        Me.labelDinuguan3.BackColor = System.Drawing.Color.Transparent
        Me.labelDinuguan3.Font = New System.Drawing.Font("Imprint MT Shadow", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelDinuguan3.ForeColor = System.Drawing.Color.Transparent
        Me.labelDinuguan3.Location = New System.Drawing.Point(198, 41)
        Me.labelDinuguan3.Name = "labelDinuguan3"
        Me.labelDinuguan3.Size = New System.Drawing.Size(399, 71)
        Me.labelDinuguan3.TabIndex = 7
        Me.labelDinuguan3.Text = "DINUGUAN"
        '
        'btnDonorList
        '
        Me.btnDonorList.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnDonorList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDonorList.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDonorList.Location = New System.Drawing.Point(100, 170)
        Me.btnDonorList.Name = "btnDonorList"
        Me.btnDonorList.Size = New System.Drawing.Size(172, 75)
        Me.btnDonorList.TabIndex = 9
        Me.btnDonorList.Text = "Donor List"
        Me.btnDonorList.UseVisualStyleBackColor = False
        '
        'btnBloodInventory
        '
        Me.btnBloodInventory.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnBloodInventory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBloodInventory.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBloodInventory.Location = New System.Drawing.Point(316, 170)
        Me.btnBloodInventory.Name = "btnBloodInventory"
        Me.btnBloodInventory.Size = New System.Drawing.Size(172, 75)
        Me.btnBloodInventory.TabIndex = 10
        Me.btnBloodInventory.Text = "Blood Inventory"
        Me.btnBloodInventory.UseVisualStyleBackColor = False
        '
        'btnRequests
        '
        Me.btnRequests.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnRequests.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRequests.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRequests.Location = New System.Drawing.Point(530, 170)
        Me.btnRequests.Name = "btnRequests"
        Me.btnRequests.Size = New System.Drawing.Size(172, 75)
        Me.btnRequests.TabIndex = 12
        Me.btnRequests.Text = "Requests"
        Me.btnRequests.UseVisualStyleBackColor = False
        '
        'btnBackupDB
        '
        Me.btnBackupDB.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnBackupDB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBackupDB.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBackupDB.Location = New System.Drawing.Point(530, 271)
        Me.btnBackupDB.Name = "btnBackupDB"
        Me.btnBackupDB.Size = New System.Drawing.Size(172, 38)
        Me.btnBackupDB.TabIndex = 13
        Me.btnBackupDB.Text = "Backup Database"
        Me.btnBackupDB.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnExit.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.Location = New System.Drawing.Point(660, 395)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(107, 32)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "Logout"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtDate
        '
        Me.txtDate.AutoSize = True
        Me.txtDate.BackColor = System.Drawing.Color.Transparent
        Me.txtDate.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtDate.ForeColor = System.Drawing.SystemColors.Control
        Me.txtDate.Location = New System.Drawing.Point(22, 374)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(39, 16)
        Me.txtDate.TabIndex = 20
        Me.txtDate.Text = "Date:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Control
        Me.DateTimePicker1.Font = New System.Drawing.Font("Imprint MT Shadow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePicker1.Location = New System.Drawing.Point(36, 401)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(676, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 16)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Name"
        '
        'btnUserLogs
        '
        Me.btnUserLogs.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnUserLogs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUserLogs.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnUserLogs.Location = New System.Drawing.Point(316, 274)
        Me.btnUserLogs.Name = "btnUserLogs"
        Me.btnUserLogs.Size = New System.Drawing.Size(172, 75)
        Me.btnUserLogs.TabIndex = 24
        Me.btnUserLogs.Text = "User Logs"
        Me.btnUserLogs.UseVisualStyleBackColor = False
        '
        'btnUserList
        '
        Me.btnUserList.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnUserList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUserList.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnUserList.Location = New System.Drawing.Point(100, 274)
        Me.btnUserList.Name = "btnUserList"
        Me.btnUserList.Size = New System.Drawing.Size(172, 75)
        Me.btnUserList.TabIndex = 25
        Me.btnUserList.Text = "User List"
        Me.btnUserList.UseVisualStyleBackColor = False
        '
        'btnRestoreDB
        '
        Me.btnRestoreDB.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnRestoreDB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestoreDB.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRestoreDB.Location = New System.Drawing.Point(530, 316)
        Me.btnRestoreDB.Name = "btnRestoreDB"
        Me.btnRestoreDB.Size = New System.Drawing.Size(172, 38)
        Me.btnRestoreDB.TabIndex = 26
        Me.btnRestoreDB.Text = "Restore Database"
        Me.btnRestoreDB.UseVisualStyleBackColor = False
        '
        'AdminInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ForgotPassword.My.Resources.Resources.DINUGUAN__1_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnRestoreDB)
        Me.Controls.Add(Me.btnUserList)
        Me.Controls.Add(Me.btnUserLogs)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBackupDB)
        Me.Controls.Add(Me.btnRequests)
        Me.Controls.Add(Me.btnBloodInventory)
        Me.Controls.Add(Me.btnDonorList)
        Me.Controls.Add(Me.labelBIMS3)
        Me.Controls.Add(Me.labelDinuguan3)
        Me.DoubleBuffered = True
        Me.Name = "AdminInterface"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin: Home"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelBIMS3 As Label
    Friend WithEvents labelDinuguan3 As Label
    Friend WithEvents btnDonorList As Button
    Friend WithEvents btnBloodInventory As Button
    Friend WithEvents btnRequests As Button
    Friend WithEvents btnBackupDB As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtDate As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUserLogs As Button
    Friend WithEvents btnUserList As Button
    Friend WithEvents btnRestoreDB As Button
End Class
