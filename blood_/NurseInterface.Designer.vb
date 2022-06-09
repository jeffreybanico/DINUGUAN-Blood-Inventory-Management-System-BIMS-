<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NurseInterface
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
        Me.labelNName = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ReportsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserLogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAccOp = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.IhihToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnNRequests = New System.Windows.Forms.Button()
        Me.btnNBloodInventory = New System.Windows.Forms.Button()
        Me.btnNDonorList = New System.Windows.Forms.Button()
        Me.labelDinuguan3 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuSystemOp = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.labelBIMS3 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelNName
        '
        Me.labelNName.AutoSize = True
        Me.labelNName.BackColor = System.Drawing.Color.Transparent
        Me.labelNName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelNName.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.labelNName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.labelNName.Location = New System.Drawing.Point(676, 53)
        Me.labelNName.Name = "labelNName"
        Me.labelNName.Size = New System.Drawing.Size(42, 16)
        Me.labelNName.TabIndex = 36
        Me.labelNName.Text = "Name"
        '
        'txtDate
        '
        Me.txtDate.AutoSize = True
        Me.txtDate.BackColor = System.Drawing.Color.Transparent
        Me.txtDate.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtDate.ForeColor = System.Drawing.SystemColors.Control
        Me.txtDate.Location = New System.Drawing.Point(36, 388)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(39, 16)
        Me.txtDate.TabIndex = 34
        Me.txtDate.Text = "Date:"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnExit.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.Location = New System.Drawing.Point(660, 407)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(107, 32)
        Me.btnExit.TabIndex = 33
        Me.btnExit.Text = "Logout"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'ReportsToolStripMenuItem1
        '
        Me.ReportsToolStripMenuItem1.Name = "ReportsToolStripMenuItem1"
        Me.ReportsToolStripMenuItem1.Size = New System.Drawing.Size(125, 22)
        Me.ReportsToolStripMenuItem1.Text = "Reports"
        '
        'UserLogsToolStripMenuItem
        '
        Me.UserLogsToolStripMenuItem.Name = "UserLogsToolStripMenuItem"
        Me.UserLogsToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.UserLogsToolStripMenuItem.Text = "User Logs"
        '
        'UserListToolStripMenuItem
        '
        Me.UserListToolStripMenuItem.Name = "UserListToolStripMenuItem"
        Me.UserListToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.UserListToolStripMenuItem.Text = "User List"
        '
        'MenuAccOp
        '
        Me.MenuAccOp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserListToolStripMenuItem, Me.UserLogsToolStripMenuItem, Me.ReportsToolStripMenuItem1})
        Me.MenuAccOp.Name = "MenuAccOp"
        Me.MenuAccOp.Size = New System.Drawing.Size(103, 20)
        Me.MenuAccOp.Text = "Blood Inventory"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Control
        Me.DateTimePicker1.Font = New System.Drawing.Font("Imprint MT Shadow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DateTimePicker1.Location = New System.Drawing.Point(36, 413)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 35
        '
        'IhihToolStripMenuItem
        '
        Me.IhihToolStripMenuItem.Name = "IhihToolStripMenuItem"
        Me.IhihToolStripMenuItem.Size = New System.Drawing.Size(12, 20)
        '
        'btnNRequests
        '
        Me.btnNRequests.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnNRequests.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNRequests.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNRequests.Location = New System.Drawing.Point(306, 288)
        Me.btnNRequests.Name = "btnNRequests"
        Me.btnNRequests.Size = New System.Drawing.Size(172, 75)
        Me.btnNRequests.TabIndex = 28
        Me.btnNRequests.Text = "Requests"
        Me.btnNRequests.UseVisualStyleBackColor = False
        '
        'btnNBloodInventory
        '
        Me.btnNBloodInventory.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnNBloodInventory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNBloodInventory.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNBloodInventory.Location = New System.Drawing.Point(415, 187)
        Me.btnNBloodInventory.Name = "btnNBloodInventory"
        Me.btnNBloodInventory.Size = New System.Drawing.Size(172, 75)
        Me.btnNBloodInventory.TabIndex = 27
        Me.btnNBloodInventory.Text = "Blood Inventory"
        Me.btnNBloodInventory.UseVisualStyleBackColor = False
        '
        'btnNDonorList
        '
        Me.btnNDonorList.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnNDonorList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNDonorList.Font = New System.Drawing.Font("Imprint MT Shadow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNDonorList.Location = New System.Drawing.Point(208, 187)
        Me.btnNDonorList.Name = "btnNDonorList"
        Me.btnNDonorList.Size = New System.Drawing.Size(172, 75)
        Me.btnNDonorList.TabIndex = 26
        Me.btnNDonorList.Text = "Donor List"
        Me.btnNDonorList.UseVisualStyleBackColor = False
        '
        'labelDinuguan3
        '
        Me.labelDinuguan3.AutoSize = True
        Me.labelDinuguan3.BackColor = System.Drawing.Color.Transparent
        Me.labelDinuguan3.Font = New System.Drawing.Font("Imprint MT Shadow", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelDinuguan3.ForeColor = System.Drawing.Color.Transparent
        Me.labelDinuguan3.Location = New System.Drawing.Point(198, 53)
        Me.labelDinuguan3.Name = "labelDinuguan3"
        Me.labelDinuguan3.Size = New System.Drawing.Size(399, 71)
        Me.labelDinuguan3.TabIndex = 24
        Me.labelDinuguan3.Text = "DINUGUAN"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IhihToolStripMenuItem, Me.MenuSystemOp, Me.MenuAccOp, Me.RequestsToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 32
        Me.MenuStrip1.Text = "Menu"
        '
        'MenuSystemOp
        '
        Me.MenuSystemOp.Name = "MenuSystemOp"
        Me.MenuSystemOp.Size = New System.Drawing.Size(73, 20)
        Me.MenuSystemOp.Text = "Donor List"
        '
        'RequestsToolStripMenuItem
        '
        Me.RequestsToolStripMenuItem.Name = "RequestsToolStripMenuItem"
        Me.RequestsToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.RequestsToolStripMenuItem.Text = "Requests"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'labelBIMS3
        '
        Me.labelBIMS3.AutoSize = True
        Me.labelBIMS3.BackColor = System.Drawing.Color.Transparent
        Me.labelBIMS3.Font = New System.Drawing.Font("Imprint MT Shadow", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelBIMS3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.labelBIMS3.Location = New System.Drawing.Point(221, 124)
        Me.labelBIMS3.Name = "labelBIMS3"
        Me.labelBIMS3.Size = New System.Drawing.Size(355, 18)
        Me.labelBIMS3.TabIndex = 25
        Me.labelBIMS3.Text = "BLOOD INVENTORY MANAGEMENT SYSTEM"
        '
        'NurseInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ForgotPassword.My.Resources.Resources.DINUGUAN__1_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.labelNName)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnNRequests)
        Me.Controls.Add(Me.btnNBloodInventory)
        Me.Controls.Add(Me.btnNDonorList)
        Me.Controls.Add(Me.labelDinuguan3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.labelBIMS3)
        Me.DoubleBuffered = True
        Me.Name = "NurseInterface"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nurse: Home"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelNName As Label
    Friend WithEvents txtDate As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents ReportsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UserLogsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuAccOp As ToolStripMenuItem
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents IhihToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnNRequests As Button
    Friend WithEvents btnNBloodInventory As Button
    Friend WithEvents btnNDonorList As Button
    Friend WithEvents labelDinuguan3 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuSystemOp As ToolStripMenuItem
    Friend WithEvents labelBIMS3 As Label
    Friend WithEvents RequestsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
End Class
