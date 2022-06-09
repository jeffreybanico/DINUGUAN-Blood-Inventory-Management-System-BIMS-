<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminRequestInformation
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.labelDonationInfo = New System.Windows.Forms.Label()
        Me.labelANurse = New System.Windows.Forms.Label()
        Me.labelRID = New System.Windows.Forms.Label()
        Me.anurse = New System.Windows.Forms.Label()
        Me.adatedonated = New System.Windows.Forms.Label()
        Me.txtRQuantity1 = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1ReqStat = New System.Windows.Forms.Label()
        Me.labelRequestStatus = New System.Windows.Forms.Label()
        Me.labelRNurse = New System.Windows.Forms.Label()
        Me.dropRBloodType = New System.Windows.Forms.ComboBox()
        Me.labelBType = New System.Windows.Forms.Label()
        Me.labelRequestID = New System.Windows.Forms.Label()
        Me.aquantity = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.labelDonorInfo1 = New System.Windows.Forms.Label()
        Me.btnRequestUpdate = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtRAddress = New System.Windows.Forms.TextBox()
        Me.labelRAddress = New System.Windows.Forms.Label()
        Me.labelDonorID2 = New System.Windows.Forms.Label()
        Me.txtRLName = New System.Windows.Forms.TextBox()
        Me.labelRLName = New System.Windows.Forms.Label()
        Me.txtRFName = New System.Windows.Forms.TextBox()
        Me.labelRFName = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.labelBIMS5 = New System.Windows.Forms.Label()
        Me.labelDinuguan5 = New System.Windows.Forms.Label()
        Me.btnExitRequest = New System.Windows.Forms.Button()
        Me.gridRequestList2 = New System.Windows.Forms.DataGridView()
        Me.idrequest = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.requestFname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.requestLname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bloodType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.requestStat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.attNurse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.labelDonorInfo = New System.Windows.Forms.Label()
        Me.btnRLoadRequests = New System.Windows.Forms.Button()
        Me.btnBackRequest2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnADelete = New System.Windows.Forms.Button()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.gridRequestList2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelDonationInfo
        '
        Me.labelDonationInfo.AutoSize = True
        Me.labelDonationInfo.BackColor = System.Drawing.Color.Transparent
        Me.labelDonationInfo.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelDonationInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelDonationInfo.Location = New System.Drawing.Point(433, 114)
        Me.labelDonationInfo.Name = "labelDonationInfo"
        Me.labelDonationInfo.Size = New System.Drawing.Size(132, 16)
        Me.labelDonationInfo.TabIndex = 54
        Me.labelDonationInfo.Text = "Request Information"
        '
        'labelANurse
        '
        Me.labelANurse.AutoSize = True
        Me.labelANurse.BackColor = System.Drawing.Color.Transparent
        Me.labelANurse.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelANurse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelANurse.Location = New System.Drawing.Point(168, 165)
        Me.labelANurse.Name = "labelANurse"
        Me.labelANurse.Size = New System.Drawing.Size(0, 16)
        Me.labelANurse.TabIndex = 20
        '
        'labelRID
        '
        Me.labelRID.AutoSize = True
        Me.labelRID.BackColor = System.Drawing.Color.Transparent
        Me.labelRID.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelRID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelRID.Location = New System.Drawing.Point(180, 20)
        Me.labelRID.Name = "labelRID"
        Me.labelRID.Size = New System.Drawing.Size(159, 16)
        Me.labelRID.TabIndex = 19
        Me.labelRID.Text = "                                      "
        '
        'anurse
        '
        Me.anurse.AutoSize = True
        Me.anurse.BackColor = System.Drawing.Color.Transparent
        Me.anurse.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.anurse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.anurse.Location = New System.Drawing.Point(43, 174)
        Me.anurse.Name = "anurse"
        Me.anurse.Size = New System.Drawing.Size(110, 16)
        Me.anurse.TabIndex = 18
        Me.anurse.Text = "Attending Nurse:"
        '
        'adatedonated
        '
        Me.adatedonated.AutoSize = True
        Me.adatedonated.BackColor = System.Drawing.Color.Transparent
        Me.adatedonated.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.adatedonated.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.adatedonated.Location = New System.Drawing.Point(43, 58)
        Me.adatedonated.Name = "adatedonated"
        Me.adatedonated.Size = New System.Drawing.Size(0, 16)
        Me.adatedonated.TabIndex = 17
        '
        'txtRQuantity1
        '
        Me.txtRQuantity1.Location = New System.Drawing.Point(180, 91)
        Me.txtRQuantity1.Name = "txtRQuantity1"
        Me.txtRQuantity1.Size = New System.Drawing.Size(159, 23)
        Me.txtRQuantity1.TabIndex = 16
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.Controls.Add(Me.Label1ReqStat)
        Me.Panel5.Controls.Add(Me.labelRequestStatus)
        Me.Panel5.Controls.Add(Me.labelRNurse)
        Me.Panel5.Controls.Add(Me.dropRBloodType)
        Me.Panel5.Controls.Add(Me.labelBType)
        Me.Panel5.Controls.Add(Me.labelANurse)
        Me.Panel5.Controls.Add(Me.labelRID)
        Me.Panel5.Controls.Add(Me.labelRequestID)
        Me.Panel5.Controls.Add(Me.anurse)
        Me.Panel5.Controls.Add(Me.adatedonated)
        Me.Panel5.Controls.Add(Me.txtRQuantity1)
        Me.Panel5.Controls.Add(Me.aquantity)
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(372, 215)
        Me.Panel5.TabIndex = 29
        '
        'Label1ReqStat
        '
        Me.Label1ReqStat.AutoSize = True
        Me.Label1ReqStat.BackColor = System.Drawing.Color.Transparent
        Me.Label1ReqStat.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1ReqStat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1ReqStat.Location = New System.Drawing.Point(180, 134)
        Me.Label1ReqStat.Name = "Label1ReqStat"
        Me.Label1ReqStat.Size = New System.Drawing.Size(159, 16)
        Me.Label1ReqStat.TabIndex = 61
        Me.Label1ReqStat.Text = "                                      "
        '
        'labelRequestStatus
        '
        Me.labelRequestStatus.AutoSize = True
        Me.labelRequestStatus.BackColor = System.Drawing.Color.Transparent
        Me.labelRequestStatus.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelRequestStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelRequestStatus.Location = New System.Drawing.Point(43, 134)
        Me.labelRequestStatus.Name = "labelRequestStatus"
        Me.labelRequestStatus.Size = New System.Drawing.Size(100, 16)
        Me.labelRequestStatus.TabIndex = 35
        Me.labelRequestStatus.Text = "Request Status:"
        '
        'labelRNurse
        '
        Me.labelRNurse.AutoSize = True
        Me.labelRNurse.BackColor = System.Drawing.Color.Transparent
        Me.labelRNurse.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelRNurse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelRNurse.Location = New System.Drawing.Point(180, 174)
        Me.labelRNurse.Name = "labelRNurse"
        Me.labelRNurse.Size = New System.Drawing.Size(159, 16)
        Me.labelRNurse.TabIndex = 34
        Me.labelRNurse.Text = "                                      "
        '
        'dropRBloodType
        '
        Me.dropRBloodType.BackColor = System.Drawing.SystemColors.ControlText
        Me.dropRBloodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropRBloodType.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.dropRBloodType.FormattingEnabled = True
        Me.dropRBloodType.Items.AddRange(New Object() {"A-", "A+", "B-", "B+", "O-", "O+", "AB-", "AB+"})
        Me.dropRBloodType.Location = New System.Drawing.Point(180, 54)
        Me.dropRBloodType.Name = "dropRBloodType"
        Me.dropRBloodType.Size = New System.Drawing.Size(159, 23)
        Me.dropRBloodType.TabIndex = 33
        '
        'labelBType
        '
        Me.labelBType.AutoSize = True
        Me.labelBType.BackColor = System.Drawing.Color.Transparent
        Me.labelBType.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelBType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelBType.Location = New System.Drawing.Point(43, 57)
        Me.labelBType.Name = "labelBType"
        Me.labelBType.Size = New System.Drawing.Size(81, 16)
        Me.labelBType.TabIndex = 13
        Me.labelBType.Text = "Blood Type:"
        '
        'labelRequestID
        '
        Me.labelRequestID.AutoSize = True
        Me.labelRequestID.BackColor = System.Drawing.Color.Transparent
        Me.labelRequestID.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelRequestID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelRequestID.Location = New System.Drawing.Point(43, 20)
        Me.labelRequestID.Name = "labelRequestID"
        Me.labelRequestID.Size = New System.Drawing.Size(85, 16)
        Me.labelRequestID.TabIndex = 12
        Me.labelRequestID.Text = "Request ID: "
        '
        'aquantity
        '
        Me.aquantity.AutoSize = True
        Me.aquantity.BackColor = System.Drawing.Color.Transparent
        Me.aquantity.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.aquantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.aquantity.Location = New System.Drawing.Point(43, 95)
        Me.aquantity.Name = "aquantity"
        Me.aquantity.Size = New System.Drawing.Size(131, 16)
        Me.aquantity.TabIndex = 15
        Me.aquantity.Text = "Quantity Requested:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Firebrick
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Location = New System.Drawing.Point(409, 124)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(379, 221)
        Me.Panel4.TabIndex = 59
        '
        'labelDonorInfo1
        '
        Me.labelDonorInfo1.AutoSize = True
        Me.labelDonorInfo1.BackColor = System.Drawing.Color.Transparent
        Me.labelDonorInfo1.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelDonorInfo1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelDonorInfo1.Location = New System.Drawing.Point(36, 114)
        Me.labelDonorInfo1.Name = "labelDonorInfo1"
        Me.labelDonorInfo1.Size = New System.Drawing.Size(114, 16)
        Me.labelDonorInfo1.TabIndex = 53
        Me.labelDonorInfo1.Text = "Basic Information"
        '
        'btnRequestUpdate
        '
        Me.btnRequestUpdate.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRequestUpdate.Location = New System.Drawing.Point(18, 360)
        Me.btnRequestUpdate.Name = "btnRequestUpdate"
        Me.btnRequestUpdate.Size = New System.Drawing.Size(107, 32)
        Me.btnRequestUpdate.TabIndex = 50
        Me.btnRequestUpdate.Text = "Update"
        Me.btnRequestUpdate.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.txtRAddress)
        Me.Panel3.Controls.Add(Me.labelRAddress)
        Me.Panel3.Controls.Add(Me.labelDonorID2)
        Me.Panel3.Controls.Add(Me.txtRLName)
        Me.Panel3.Controls.Add(Me.labelRLName)
        Me.Panel3.Controls.Add(Me.txtRFName)
        Me.Panel3.Controls.Add(Me.labelRFName)
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(372, 215)
        Me.Panel3.TabIndex = 29
        '
        'txtRAddress
        '
        Me.txtRAddress.Location = New System.Drawing.Point(162, 142)
        Me.txtRAddress.Name = "txtRAddress"
        Me.txtRAddress.Size = New System.Drawing.Size(173, 23)
        Me.txtRAddress.TabIndex = 13
        '
        'labelRAddress
        '
        Me.labelRAddress.AutoSize = True
        Me.labelRAddress.BackColor = System.Drawing.Color.Transparent
        Me.labelRAddress.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelRAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelRAddress.Location = New System.Drawing.Point(41, 145)
        Me.labelRAddress.Name = "labelRAddress"
        Me.labelRAddress.Size = New System.Drawing.Size(57, 16)
        Me.labelRAddress.TabIndex = 12
        Me.labelRAddress.Text = "Address:"
        '
        'labelDonorID2
        '
        Me.labelDonorID2.AutoSize = True
        Me.labelDonorID2.BackColor = System.Drawing.Color.Transparent
        Me.labelDonorID2.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelDonorID2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelDonorID2.Location = New System.Drawing.Point(162, 31)
        Me.labelDonorID2.Name = "labelDonorID2"
        Me.labelDonorID2.Size = New System.Drawing.Size(31, 16)
        Me.labelDonorID2.TabIndex = 11
        Me.labelDonorID2.Text = "      "
        '
        'txtRLName
        '
        Me.txtRLName.Location = New System.Drawing.Point(162, 95)
        Me.txtRLName.Name = "txtRLName"
        Me.txtRLName.Size = New System.Drawing.Size(173, 23)
        Me.txtRLName.TabIndex = 6
        '
        'labelRLName
        '
        Me.labelRLName.AutoSize = True
        Me.labelRLName.BackColor = System.Drawing.Color.Transparent
        Me.labelRLName.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelRLName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelRLName.Location = New System.Drawing.Point(39, 98)
        Me.labelRLName.Name = "labelRLName"
        Me.labelRLName.Size = New System.Drawing.Size(75, 16)
        Me.labelRLName.TabIndex = 5
        Me.labelRLName.Text = "Last Name:"
        '
        'txtRFName
        '
        Me.txtRFName.Location = New System.Drawing.Point(162, 50)
        Me.txtRFName.Name = "txtRFName"
        Me.txtRFName.Size = New System.Drawing.Size(173, 23)
        Me.txtRFName.TabIndex = 4
        '
        'labelRFName
        '
        Me.labelRFName.AutoSize = True
        Me.labelRFName.BackColor = System.Drawing.Color.Transparent
        Me.labelRFName.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelRFName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelRFName.Location = New System.Drawing.Point(39, 53)
        Me.labelRFName.Name = "labelRFName"
        Me.labelRFName.Size = New System.Drawing.Size(77, 16)
        Me.labelRFName.TabIndex = 3
        Me.labelRFName.Text = "First Name:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Firebrick
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(18, 124)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(379, 221)
        Me.Panel2.TabIndex = 52
        '
        'labelBIMS5
        '
        Me.labelBIMS5.AutoSize = True
        Me.labelBIMS5.BackColor = System.Drawing.Color.Firebrick
        Me.labelBIMS5.Font = New System.Drawing.Font("Imprint MT Shadow", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelBIMS5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.labelBIMS5.Location = New System.Drawing.Point(28, 46)
        Me.labelBIMS5.Name = "labelBIMS5"
        Me.labelBIMS5.Size = New System.Drawing.Size(193, 9)
        Me.labelBIMS5.TabIndex = 7
        Me.labelBIMS5.Text = "BLOOD INVENTORY MANAGEMENT SYSTEM"
        '
        'labelDinuguan5
        '
        Me.labelDinuguan5.AutoSize = True
        Me.labelDinuguan5.BackColor = System.Drawing.Color.Firebrick
        Me.labelDinuguan5.Font = New System.Drawing.Font("Imprint MT Shadow", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelDinuguan5.ForeColor = System.Drawing.Color.Transparent
        Me.labelDinuguan5.Location = New System.Drawing.Point(12, 6)
        Me.labelDinuguan5.Name = "labelDinuguan5"
        Me.labelDinuguan5.Size = New System.Drawing.Size(230, 40)
        Me.labelDinuguan5.TabIndex = 6
        Me.labelDinuguan5.Text = "DINUGUAN"
        '
        'btnExitRequest
        '
        Me.btnExitRequest.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnExitRequest.Location = New System.Drawing.Point(670, 637)
        Me.btnExitRequest.Name = "btnExitRequest"
        Me.btnExitRequest.Size = New System.Drawing.Size(107, 32)
        Me.btnExitRequest.TabIndex = 58
        Me.btnExitRequest.Text = "Exit"
        Me.btnExitRequest.UseVisualStyleBackColor = True
        '
        'gridRequestList2
        '
        Me.gridRequestList2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridRequestList2.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.gridRequestList2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridRequestList2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idrequest, Me.requestFname, Me.requestLname, Me.address, Me.bloodType, Me.Column6, Me.requestStat, Me.attNurse})
        Me.gridRequestList2.Location = New System.Drawing.Point(21, 409)
        Me.gridRequestList2.Name = "gridRequestList2"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridRequestList2.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gridRequestList2.RowTemplate.Height = 25
        Me.gridRequestList2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.gridRequestList2.Size = New System.Drawing.Size(756, 219)
        Me.gridRequestList2.TabIndex = 55
        '
        'idrequest
        '
        Me.idrequest.HeaderText = "Request ID"
        Me.idrequest.Name = "idrequest"
        '
        'requestFname
        '
        Me.requestFname.HeaderText = "First Name"
        Me.requestFname.Name = "requestFname"
        '
        'requestLname
        '
        Me.requestLname.HeaderText = "Last Name"
        Me.requestLname.Name = "requestLname"
        '
        'address
        '
        Me.address.HeaderText = "Address"
        Me.address.Name = "address"
        '
        'bloodType
        '
        Me.bloodType.HeaderText = "Blood Type"
        Me.bloodType.Name = "bloodType"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Quantity Requested"
        Me.Column6.Name = "Column6"
        '
        'requestStat
        '
        Me.requestStat.HeaderText = "Request Status"
        Me.requestStat.Name = "requestStat"
        '
        'attNurse
        '
        Me.attNurse.HeaderText = "Attending Nurse"
        Me.attNurse.Name = "attNurse"
        '
        'labelDonorInfo
        '
        Me.labelDonorInfo.AutoSize = True
        Me.labelDonorInfo.BackColor = System.Drawing.Color.Firebrick
        Me.labelDonorInfo.Font = New System.Drawing.Font("Imprint MT Shadow", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelDonorInfo.ForeColor = System.Drawing.Color.Transparent
        Me.labelDonorInfo.Location = New System.Drawing.Point(451, 15)
        Me.labelDonorInfo.Name = "labelDonorInfo"
        Me.labelDonorInfo.Size = New System.Drawing.Size(337, 40)
        Me.labelDonorInfo.TabIndex = 15
        Me.labelDonorInfo.Text = "Request Information"
        '
        'btnRLoadRequests
        '
        Me.btnRLoadRequests.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRLoadRequests.Location = New System.Drawing.Point(633, 360)
        Me.btnRLoadRequests.Name = "btnRLoadRequests"
        Me.btnRLoadRequests.Size = New System.Drawing.Size(151, 32)
        Me.btnRLoadRequests.TabIndex = 56
        Me.btnRLoadRequests.Text = "Load Requests"
        Me.btnRLoadRequests.UseVisualStyleBackColor = True
        '
        'btnBackRequest2
        '
        Me.btnBackRequest2.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBackRequest2.Location = New System.Drawing.Point(545, 637)
        Me.btnBackRequest2.Name = "btnBackRequest2"
        Me.btnBackRequest2.Size = New System.Drawing.Size(107, 32)
        Me.btnBackRequest2.TabIndex = 57
        Me.btnBackRequest2.Text = "Back"
        Me.btnBackRequest2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Firebrick
        Me.Panel1.Controls.Add(Me.labelDonorInfo)
        Me.Panel1.Controls.Add(Me.labelBIMS5)
        Me.Panel1.Controls.Add(Me.labelDinuguan5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 72)
        Me.Panel1.TabIndex = 51
        '
        'btnADelete
        '
        Me.btnADelete.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnADelete.Location = New System.Drawing.Point(164, 360)
        Me.btnADelete.Name = "btnADelete"
        Me.btnADelete.Size = New System.Drawing.Size(107, 32)
        Me.btnADelete.TabIndex = 60
        Me.btnADelete.Text = "Delete"
        Me.btnADelete.UseVisualStyleBackColor = True
        '
        'AdminRequestInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 675)
        Me.Controls.Add(Me.btnADelete)
        Me.Controls.Add(Me.labelDonationInfo)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.labelDonorInfo1)
        Me.Controls.Add(Me.btnRequestUpdate)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnExitRequest)
        Me.Controls.Add(Me.gridRequestList2)
        Me.Controls.Add(Me.btnRLoadRequests)
        Me.Controls.Add(Me.btnBackRequest2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AdminRequestInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Request Information"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.gridRequestList2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelDonationInfo As Label
    Friend WithEvents labelANurse As Label
    Friend WithEvents labelRID As Label
    Friend WithEvents anurse As Label
    Friend WithEvents adatedonated As Label
    Friend WithEvents txtRQuantity1 As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents aquantity As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents labelDonorInfo1 As Label
    Friend WithEvents btnRequestUpdate As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dropRBloodType As ComboBox
    Friend WithEvents labelBType As Label
    Friend WithEvents labelRequestID As Label
    Friend WithEvents labelDonorID2 As Label
    Friend WithEvents txtRLName As TextBox
    Friend WithEvents labelRLName As Label
    Friend WithEvents txtRFName As TextBox
    Friend WithEvents labelRFName As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents labelBIMS5 As Label
    Friend WithEvents labelDinuguan5 As Label
    Friend WithEvents btnExitRequest As Button
    Friend WithEvents gridRequestList2 As DataGridView
    Friend WithEvents labelDonorInfo As Label
    Friend WithEvents btnRLoadRequests As Button
    Friend WithEvents btnBackRequest2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtRAddress As TextBox
    Friend WithEvents labelRAddress As Label
    Friend WithEvents labelRNurse As Label
    Friend WithEvents labelRequestStatus As Label
    Friend WithEvents idrequest As DataGridViewTextBoxColumn
    Friend WithEvents requestFname As DataGridViewTextBoxColumn
    Friend WithEvents requestLname As DataGridViewTextBoxColumn
    Friend WithEvents address As DataGridViewTextBoxColumn
    Friend WithEvents bloodType As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents requestStat As DataGridViewTextBoxColumn
    Friend WithEvents attNurse As DataGridViewTextBoxColumn
    Friend WithEvents Label1ReqStat As Label
    Friend WithEvents btnADelete As Button
End Class
