<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminRequest
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtASearchRequest = New System.Windows.Forms.TextBox()
        Me.labelDonorList = New System.Windows.Forms.Label()
        Me.labelBIMS4 = New System.Windows.Forms.Label()
        Me.labelDinuguan4 = New System.Windows.Forms.Label()
        Me.btnASearchRequest = New System.Windows.Forms.Button()
        Me.dropStatus = New System.Windows.Forms.ComboBox()
        Me.labelBType = New System.Windows.Forms.Label()
        Me.labelSearchDonor = New System.Windows.Forms.Label()
        Me.dropASearchRequest = New System.Windows.Forms.ComboBox()
        Me.btnRequest = New System.Windows.Forms.Button()
        Me.btnAEditRequest = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gridRequestList = New System.Windows.Forms.DataGridView()
        Me.requestFname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.requestLname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bloodType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numofRequest = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.attNurse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.requestStat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnClearARequest = New System.Windows.Forms.Button()
        Me.btnExportRequest = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.gridRequestList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBack.Location = New System.Drawing.Point(680, 465)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(107, 32)
        Me.btnBack.TabIndex = 57
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'txtASearchRequest
        '
        Me.txtASearchRequest.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtASearchRequest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtASearchRequest.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtASearchRequest.Location = New System.Drawing.Point(242, 102)
        Me.txtASearchRequest.Multiline = True
        Me.txtASearchRequest.Name = "txtASearchRequest"
        Me.txtASearchRequest.Size = New System.Drawing.Size(197, 23)
        Me.txtASearchRequest.TabIndex = 52
        '
        'labelDonorList
        '
        Me.labelDonorList.AutoSize = True
        Me.labelDonorList.BackColor = System.Drawing.Color.Firebrick
        Me.labelDonorList.Font = New System.Drawing.Font("Imprint MT Shadow", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelDonorList.ForeColor = System.Drawing.Color.Transparent
        Me.labelDonorList.Location = New System.Drawing.Point(575, 15)
        Me.labelDonorList.Name = "labelDonorList"
        Me.labelDonorList.Size = New System.Drawing.Size(213, 40)
        Me.labelDonorList.TabIndex = 15
        Me.labelDonorList.Text = "Request List"
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
        'btnASearchRequest
        '
        Me.btnASearchRequest.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnASearchRequest.Location = New System.Drawing.Point(454, 98)
        Me.btnASearchRequest.Name = "btnASearchRequest"
        Me.btnASearchRequest.Size = New System.Drawing.Size(67, 29)
        Me.btnASearchRequest.TabIndex = 56
        Me.btnASearchRequest.Text = "Search"
        Me.btnASearchRequest.UseVisualStyleBackColor = True
        '
        'dropStatus
        '
        Me.dropStatus.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.dropStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropStatus.FormattingEnabled = True
        Me.dropStatus.Items.AddRange(New Object() {"All", "Pending", "Cancelled", "Granted"})
        Me.dropStatus.Location = New System.Drawing.Point(598, 105)
        Me.dropStatus.Name = "dropStatus"
        Me.dropStatus.Size = New System.Drawing.Size(159, 23)
        Me.dropStatus.TabIndex = 55
        '
        'labelBType
        '
        Me.labelBType.AutoSize = True
        Me.labelBType.BackColor = System.Drawing.Color.WhiteSmoke
        Me.labelBType.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelBType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelBType.Location = New System.Drawing.Point(598, 86)
        Me.labelBType.Name = "labelBType"
        Me.labelBType.Size = New System.Drawing.Size(156, 16)
        Me.labelBType.TabIndex = 54
        Me.labelBType.Text = "Filter by Request Status:"
        '
        'labelSearchDonor
        '
        Me.labelSearchDonor.AutoSize = True
        Me.labelSearchDonor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.labelSearchDonor.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelSearchDonor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelSearchDonor.Location = New System.Drawing.Point(32, 105)
        Me.labelSearchDonor.Name = "labelSearchDonor"
        Me.labelSearchDonor.Size = New System.Drawing.Size(49, 16)
        Me.labelSearchDonor.TabIndex = 53
        Me.labelSearchDonor.Text = "Search:"
        '
        'dropASearchRequest
        '
        Me.dropASearchRequest.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.dropASearchRequest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropASearchRequest.FormattingEnabled = True
        Me.dropASearchRequest.Items.AddRange(New Object() {"All", "First Name", "Last Name", "Blood Type"})
        Me.dropASearchRequest.Location = New System.Drawing.Point(94, 102)
        Me.dropASearchRequest.Name = "dropASearchRequest"
        Me.dropASearchRequest.Size = New System.Drawing.Size(127, 23)
        Me.dropASearchRequest.TabIndex = 51
        '
        'btnRequest
        '
        Me.btnRequest.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRequest.Location = New System.Drawing.Point(384, 464)
        Me.btnRequest.Name = "btnRequest"
        Me.btnRequest.Size = New System.Drawing.Size(146, 32)
        Me.btnRequest.TabIndex = 50
        Me.btnRequest.Text = "Load Requests"
        Me.btnRequest.UseVisualStyleBackColor = True
        '
        'btnAEditRequest
        '
        Me.btnAEditRequest.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAEditRequest.Location = New System.Drawing.Point(13, 464)
        Me.btnAEditRequest.Name = "btnAEditRequest"
        Me.btnAEditRequest.Size = New System.Drawing.Size(107, 32)
        Me.btnAEditRequest.TabIndex = 49
        Me.btnAEditRequest.Text = "Edit"
        Me.btnAEditRequest.UseVisualStyleBackColor = True
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
        Me.Panel1.TabIndex = 48
        '
        'gridRequestList
        '
        Me.gridRequestList.AllowUserToAddRows = False
        Me.gridRequestList.AllowUserToDeleteRows = False
        Me.gridRequestList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridRequestList.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.gridRequestList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridRequestList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.requestFname, Me.requestLname, Me.bloodType, Me.numofRequest, Me.address, Me.attNurse, Me.requestStat})
        Me.gridRequestList.Location = New System.Drawing.Point(11, 140)
        Me.gridRequestList.Name = "gridRequestList"
        Me.gridRequestList.ReadOnly = True
        Me.gridRequestList.RowTemplate.Height = 25
        Me.gridRequestList.Size = New System.Drawing.Size(776, 311)
        Me.gridRequestList.TabIndex = 47
        '
        'requestFname
        '
        Me.requestFname.HeaderText = "First Name"
        Me.requestFname.Name = "requestFname"
        Me.requestFname.ReadOnly = True
        '
        'requestLname
        '
        Me.requestLname.HeaderText = "Last Name"
        Me.requestLname.Name = "requestLname"
        Me.requestLname.ReadOnly = True
        '
        'bloodType
        '
        Me.bloodType.HeaderText = "Blood Type"
        Me.bloodType.Name = "bloodType"
        Me.bloodType.ReadOnly = True
        '
        'numofRequest
        '
        Me.numofRequest.HeaderText = "Quantity Requested"
        Me.numofRequest.Name = "numofRequest"
        Me.numofRequest.ReadOnly = True
        '
        'address
        '
        Me.address.HeaderText = "Address"
        Me.address.Name = "address"
        Me.address.ReadOnly = True
        '
        'attNurse
        '
        Me.attNurse.HeaderText = "Attending Nurse"
        Me.attNurse.Name = "attNurse"
        Me.attNurse.ReadOnly = True
        '
        'requestStat
        '
        Me.requestStat.HeaderText = "Request Status"
        Me.requestStat.Name = "requestStat"
        Me.requestStat.ReadOnly = True
        '
        'btnClearARequest
        '
        Me.btnClearARequest.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClearARequest.Location = New System.Drawing.Point(527, 98)
        Me.btnClearARequest.Name = "btnClearARequest"
        Me.btnClearARequest.Size = New System.Drawing.Size(54, 29)
        Me.btnClearARequest.TabIndex = 58
        Me.btnClearARequest.Text = "Clear"
        Me.btnClearARequest.UseVisualStyleBackColor = True
        '
        'btnExportRequest
        '
        Me.btnExportRequest.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnExportRequest.Location = New System.Drawing.Point(262, 464)
        Me.btnExportRequest.Name = "btnExportRequest"
        Me.btnExportRequest.Size = New System.Drawing.Size(116, 32)
        Me.btnExportRequest.TabIndex = 59
        Me.btnExportRequest.Text = "Export"
        Me.btnExportRequest.UseVisualStyleBackColor = True
        '
        'AdminRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.Controls.Add(Me.btnExportRequest)
        Me.Controls.Add(Me.btnClearARequest)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtASearchRequest)
        Me.Controls.Add(Me.btnASearchRequest)
        Me.Controls.Add(Me.dropStatus)
        Me.Controls.Add(Me.labelBType)
        Me.Controls.Add(Me.labelSearchDonor)
        Me.Controls.Add(Me.dropASearchRequest)
        Me.Controls.Add(Me.btnRequest)
        Me.Controls.Add(Me.btnAEditRequest)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gridRequestList)
        Me.Name = "AdminRequest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminRequest"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.gridRequestList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents txtASearchRequest As TextBox
    Friend WithEvents labelDonorList As Label
    Friend WithEvents labelBIMS4 As Label
    Friend WithEvents labelDinuguan4 As Label
    Friend WithEvents btnASearchRequest As Button
    Friend WithEvents dropStatus As ComboBox
    Friend WithEvents labelBType As Label
    Friend WithEvents labelSearchDonor As Label
    Friend WithEvents dropASearchRequest As ComboBox
    Friend WithEvents btnRequest As Button
    Friend WithEvents btnAEditRequest As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents gridRequestList As DataGridView
    Friend WithEvents requestFname As DataGridViewTextBoxColumn
    Friend WithEvents requestLname As DataGridViewTextBoxColumn
    Friend WithEvents bloodType As DataGridViewTextBoxColumn
    Friend WithEvents numofRequest As DataGridViewTextBoxColumn
    Friend WithEvents address As DataGridViewTextBoxColumn
    Friend WithEvents attNurse As DataGridViewTextBoxColumn
    Friend WithEvents requestStat As DataGridViewTextBoxColumn
    Friend WithEvents btnClearARequest As Button
    Friend WithEvents btnExportRequest As Button
End Class
