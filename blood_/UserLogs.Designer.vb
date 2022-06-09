<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userLog
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
        Me.gridLogView = New System.Windows.Forms.DataGridView()
        Me.logId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.userFname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.userLname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.actvityLog = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateLog = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.labelDonorList = New System.Windows.Forms.Label()
        Me.labelBIMS4 = New System.Windows.Forms.Label()
        Me.labelDinuguan4 = New System.Windows.Forms.Label()
        Me.btnBackLog = New System.Windows.Forms.Button()
        Me.loadLog = New System.Windows.Forms.Button()
        Me.dropSearchLog = New System.Windows.Forms.ComboBox()
        Me.txtSearchLog = New System.Windows.Forms.TextBox()
        Me.labelSearchLog = New System.Windows.Forms.Label()
        Me.btnSearchLog = New System.Windows.Forms.Button()
        Me.btnClearLog = New System.Windows.Forms.Button()
        CType(Me.gridLogView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridLogView
        '
        Me.gridLogView.AllowUserToAddRows = False
        Me.gridLogView.AllowUserToDeleteRows = False
        Me.gridLogView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridLogView.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.gridLogView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridLogView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.logId, Me.userFname, Me.userLname, Me.actvityLog, Me.dateLog})
        Me.gridLogView.Location = New System.Drawing.Point(12, 135)
        Me.gridLogView.Name = "gridLogView"
        Me.gridLogView.ReadOnly = True
        Me.gridLogView.RowTemplate.Height = 25
        Me.gridLogView.Size = New System.Drawing.Size(776, 309)
        Me.gridLogView.TabIndex = 2
        '
        'logId
        '
        Me.logId.HeaderText = "Log ID"
        Me.logId.Name = "logId"
        Me.logId.ReadOnly = True
        '
        'userFname
        '
        Me.userFname.HeaderText = "First Name"
        Me.userFname.Name = "userFname"
        Me.userFname.ReadOnly = True
        '
        'userLname
        '
        Me.userLname.HeaderText = "Last Name"
        Me.userLname.Name = "userLname"
        Me.userLname.ReadOnly = True
        '
        'actvityLog
        '
        Me.actvityLog.HeaderText = "Activity"
        Me.actvityLog.Name = "actvityLog"
        Me.actvityLog.ReadOnly = True
        '
        'dateLog
        '
        Me.dateLog.HeaderText = "Timestamp"
        Me.dateLog.Name = "dateLog"
        Me.dateLog.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Firebrick
        Me.Panel1.Controls.Add(Me.labelDonorList)
        Me.Panel1.Controls.Add(Me.labelBIMS4)
        Me.Panel1.Controls.Add(Me.labelDinuguan4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 72)
        Me.Panel1.TabIndex = 29
        '
        'labelDonorList
        '
        Me.labelDonorList.AutoSize = True
        Me.labelDonorList.BackColor = System.Drawing.Color.Firebrick
        Me.labelDonorList.Font = New System.Drawing.Font("Imprint MT Shadow", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelDonorList.ForeColor = System.Drawing.Color.Transparent
        Me.labelDonorList.Location = New System.Drawing.Point(600, 15)
        Me.labelDonorList.Name = "labelDonorList"
        Me.labelDonorList.Size = New System.Drawing.Size(175, 40)
        Me.labelDonorList.TabIndex = 15
        Me.labelDonorList.Text = "User Logs"
        '
        'labelBIMS4
        '
        Me.labelBIMS4.AutoSize = True
        Me.labelBIMS4.BackColor = System.Drawing.Color.Firebrick
        Me.labelBIMS4.Font = New System.Drawing.Font("Imprint MT Shadow", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelBIMS4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.labelBIMS4.Location = New System.Drawing.Point(28, 46)
        Me.labelBIMS4.Name = "labelBIMS4"
        Me.labelBIMS4.Size = New System.Drawing.Size(193, 9)
        Me.labelBIMS4.TabIndex = 7
        Me.labelBIMS4.Text = "BLOOD INVENTORY MANAGEMENT SYSTEM"
        '
        'labelDinuguan4
        '
        Me.labelDinuguan4.AutoSize = True
        Me.labelDinuguan4.BackColor = System.Drawing.Color.Firebrick
        Me.labelDinuguan4.Font = New System.Drawing.Font("Imprint MT Shadow", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelDinuguan4.ForeColor = System.Drawing.Color.Transparent
        Me.labelDinuguan4.Location = New System.Drawing.Point(12, 6)
        Me.labelDinuguan4.Name = "labelDinuguan4"
        Me.labelDinuguan4.Size = New System.Drawing.Size(230, 40)
        Me.labelDinuguan4.TabIndex = 6
        Me.labelDinuguan4.Text = "DINUGUAN"
        '
        'btnBackLog
        '
        Me.btnBackLog.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBackLog.Location = New System.Drawing.Point(681, 459)
        Me.btnBackLog.Name = "btnBackLog"
        Me.btnBackLog.Size = New System.Drawing.Size(107, 32)
        Me.btnBackLog.TabIndex = 32
        Me.btnBackLog.Text = "Back"
        Me.btnBackLog.UseVisualStyleBackColor = True
        '
        'loadLog
        '
        Me.loadLog.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.loadLog.Location = New System.Drawing.Point(12, 459)
        Me.loadLog.Name = "loadLog"
        Me.loadLog.Size = New System.Drawing.Size(146, 32)
        Me.loadLog.TabIndex = 33
        Me.loadLog.Text = "Load Logs"
        Me.loadLog.UseVisualStyleBackColor = True
        '
        'dropSearchLog
        '
        Me.dropSearchLog.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.dropSearchLog.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropSearchLog.FormattingEnabled = True
        Me.dropSearchLog.Items.AddRange(New Object() {"All", "Last Name", "First Name", "Activity"})
        Me.dropSearchLog.Location = New System.Drawing.Point(159, 92)
        Me.dropSearchLog.Name = "dropSearchLog"
        Me.dropSearchLog.Size = New System.Drawing.Size(123, 23)
        Me.dropSearchLog.TabIndex = 26
        '
        'txtSearchLog
        '
        Me.txtSearchLog.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtSearchLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchLog.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtSearchLog.Location = New System.Drawing.Point(299, 92)
        Me.txtSearchLog.Multiline = True
        Me.txtSearchLog.Name = "txtSearchLog"
        Me.txtSearchLog.Size = New System.Drawing.Size(236, 23)
        Me.txtSearchLog.TabIndex = 27
        '
        'labelSearchLog
        '
        Me.labelSearchLog.AutoSize = True
        Me.labelSearchLog.BackColor = System.Drawing.Color.WhiteSmoke
        Me.labelSearchLog.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelSearchLog.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelSearchLog.Location = New System.Drawing.Point(97, 95)
        Me.labelSearchLog.Name = "labelSearchLog"
        Me.labelSearchLog.Size = New System.Drawing.Size(49, 16)
        Me.labelSearchLog.TabIndex = 28
        Me.labelSearchLog.Text = "Search:"
        '
        'btnSearchLog
        '
        Me.btnSearchLog.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSearchLog.Location = New System.Drawing.Point(553, 88)
        Me.btnSearchLog.Name = "btnSearchLog"
        Me.btnSearchLog.Size = New System.Drawing.Size(61, 29)
        Me.btnSearchLog.TabIndex = 30
        Me.btnSearchLog.Text = "Search"
        Me.btnSearchLog.UseVisualStyleBackColor = True
        '
        'btnClearLog
        '
        Me.btnClearLog.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClearLog.Location = New System.Drawing.Point(620, 88)
        Me.btnClearLog.Name = "btnClearLog"
        Me.btnClearLog.Size = New System.Drawing.Size(54, 29)
        Me.btnClearLog.TabIndex = 34
        Me.btnClearLog.Text = "Clear"
        Me.btnClearLog.UseVisualStyleBackColor = True
        '
        'userLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(800, 503)
        Me.Controls.Add(Me.btnClearLog)
        Me.Controls.Add(Me.loadLog)
        Me.Controls.Add(Me.btnBackLog)
        Me.Controls.Add(Me.btnSearchLog)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.labelSearchLog)
        Me.Controls.Add(Me.txtSearchLog)
        Me.Controls.Add(Me.dropSearchLog)
        Me.Controls.Add(Me.gridLogView)
        Me.Name = "userLog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Logs"
        CType(Me.gridLogView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gridLogView As DataGridView
    Friend WithEvents logId As DataGridViewTextBoxColumn
    Friend WithEvents userFname As DataGridViewTextBoxColumn
    Friend WithEvents userLname As DataGridViewTextBoxColumn
    Friend WithEvents actvityLog As DataGridViewTextBoxColumn
    Friend WithEvents dateLog As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents labelDonorList As Label
    Friend WithEvents labelBIMS4 As Label
    Friend WithEvents labelDinuguan4 As Label
    Friend WithEvents btnBackLog As Button
    Friend WithEvents loadLog As Button
    Friend WithEvents dropSearchLog As ComboBox
    Friend WithEvents txtSearchLog As TextBox
    Friend WithEvents labelSearchLog As Label
    Friend WithEvents btnSearchLog As Button
    Friend WithEvents btnClearLog As Button
End Class
