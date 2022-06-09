<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NurseRequestInformation
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
        Me.txtNRAddress = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.labelNRAddress = New System.Windows.Forms.Label()
        Me.labelDonorID2 = New System.Windows.Forms.Label()
        Me.txtNRLName = New System.Windows.Forms.TextBox()
        Me.labelNRLName = New System.Windows.Forms.Label()
        Me.txtNRFName = New System.Windows.Forms.TextBox()
        Me.labelNRFName = New System.Windows.Forms.Label()
        Me.btnNBackRequest2 = New System.Windows.Forms.Button()
        Me.labelBIMS5 = New System.Windows.Forms.Label()
        Me.labelDinuguan5 = New System.Windows.Forms.Label()
        Me.btnNExitRequest = New System.Windows.Forms.Button()
        Me.gridNRequestList2 = New System.Windows.Forms.DataGridView()
        Me.idrequest = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.requestFname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.requestLname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bloodType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.requestStat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.attNurse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.labelDonorInfo = New System.Windows.Forms.Label()
        Me.btnNRLoadRequests = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.labelDonationInfo = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.labelRequestStat = New System.Windows.Forms.Label()
        Me.labelNRequestStatus = New System.Windows.Forms.Label()
        Me.labelNRNurse = New System.Windows.Forms.Label()
        Me.dropNRBloodType = New System.Windows.Forms.ComboBox()
        Me.labelNBType = New System.Windows.Forms.Label()
        Me.labelANurse = New System.Windows.Forms.Label()
        Me.labelNRID = New System.Windows.Forms.Label()
        Me.labelNRequestID = New System.Windows.Forms.Label()
        Me.Nnurse = New System.Windows.Forms.Label()
        Me.adatedonated = New System.Windows.Forms.Label()
        Me.txtNRQuantity1 = New System.Windows.Forms.TextBox()
        Me.Nquantity = New System.Windows.Forms.Label()
        Me.labelDonorInfo1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnNAddRequest = New System.Windows.Forms.Button()
        Me.btnNRequestUpdate = New System.Windows.Forms.Button()
        Me.btnCancelReq = New System.Windows.Forms.Button()
        Me.btnGrantReq = New System.Windows.Forms.Button()
        Me.btnNRDelete = New System.Windows.Forms.Button()
        Me.btnNClearNReqInfo = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.gridNRequestList2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNRAddress
        '
        Me.txtNRAddress.Location = New System.Drawing.Point(162, 142)
        Me.txtNRAddress.Name = "txtNRAddress"
        Me.txtNRAddress.Size = New System.Drawing.Size(173, 23)
        Me.txtNRAddress.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Firebrick
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(18, 118)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(379, 221)
        Me.Panel2.TabIndex = 62
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.txtNRAddress)
        Me.Panel3.Controls.Add(Me.labelNRAddress)
        Me.Panel3.Controls.Add(Me.labelDonorID2)
        Me.Panel3.Controls.Add(Me.txtNRLName)
        Me.Panel3.Controls.Add(Me.labelNRLName)
        Me.Panel3.Controls.Add(Me.txtNRFName)
        Me.Panel3.Controls.Add(Me.labelNRFName)
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(372, 215)
        Me.Panel3.TabIndex = 29
        '
        'labelNRAddress
        '
        Me.labelNRAddress.AutoSize = True
        Me.labelNRAddress.BackColor = System.Drawing.Color.Transparent
        Me.labelNRAddress.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelNRAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelNRAddress.Location = New System.Drawing.Point(41, 145)
        Me.labelNRAddress.Name = "labelNRAddress"
        Me.labelNRAddress.Size = New System.Drawing.Size(57, 16)
        Me.labelNRAddress.TabIndex = 12
        Me.labelNRAddress.Text = "Address:"
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
        'txtNRLName
        '
        Me.txtNRLName.Location = New System.Drawing.Point(162, 95)
        Me.txtNRLName.Name = "txtNRLName"
        Me.txtNRLName.Size = New System.Drawing.Size(173, 23)
        Me.txtNRLName.TabIndex = 6
        '
        'labelNRLName
        '
        Me.labelNRLName.AutoSize = True
        Me.labelNRLName.BackColor = System.Drawing.Color.Transparent
        Me.labelNRLName.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelNRLName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelNRLName.Location = New System.Drawing.Point(39, 98)
        Me.labelNRLName.Name = "labelNRLName"
        Me.labelNRLName.Size = New System.Drawing.Size(75, 16)
        Me.labelNRLName.TabIndex = 5
        Me.labelNRLName.Text = "Last Name:"
        '
        'txtNRFName
        '
        Me.txtNRFName.Location = New System.Drawing.Point(162, 50)
        Me.txtNRFName.Name = "txtNRFName"
        Me.txtNRFName.Size = New System.Drawing.Size(173, 23)
        Me.txtNRFName.TabIndex = 4
        '
        'labelNRFName
        '
        Me.labelNRFName.AutoSize = True
        Me.labelNRFName.BackColor = System.Drawing.Color.Transparent
        Me.labelNRFName.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelNRFName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelNRFName.Location = New System.Drawing.Point(39, 53)
        Me.labelNRFName.Name = "labelNRFName"
        Me.labelNRFName.Size = New System.Drawing.Size(77, 16)
        Me.labelNRFName.TabIndex = 3
        Me.labelNRFName.Text = "First Name:"
        '
        'btnNBackRequest2
        '
        Me.btnNBackRequest2.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNBackRequest2.Location = New System.Drawing.Point(556, 706)
        Me.btnNBackRequest2.Name = "btnNBackRequest2"
        Me.btnNBackRequest2.Size = New System.Drawing.Size(107, 32)
        Me.btnNBackRequest2.TabIndex = 67
        Me.btnNBackRequest2.Text = "Back"
        Me.btnNBackRequest2.UseVisualStyleBackColor = True
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
        'btnNExitRequest
        '
        Me.btnNExitRequest.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNExitRequest.Location = New System.Drawing.Point(681, 706)
        Me.btnNExitRequest.Name = "btnNExitRequest"
        Me.btnNExitRequest.Size = New System.Drawing.Size(107, 32)
        Me.btnNExitRequest.TabIndex = 68
        Me.btnNExitRequest.Text = "Exit"
        Me.btnNExitRequest.UseVisualStyleBackColor = True
        '
        'gridNRequestList2
        '
        Me.gridNRequestList2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridNRequestList2.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.gridNRequestList2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridNRequestList2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idrequest, Me.requestFname, Me.requestLname, Me.address, Me.bloodType, Me.Column6, Me.requestStat, Me.attNurse})
        Me.gridNRequestList2.Location = New System.Drawing.Point(21, 441)
        Me.gridNRequestList2.Name = "gridNRequestList2"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridNRequestList2.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gridNRequestList2.RowTemplate.Height = 25
        Me.gridNRequestList2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.gridNRequestList2.Size = New System.Drawing.Size(767, 259)
        Me.gridNRequestList2.TabIndex = 65
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
        Me.labelDonorInfo.Location = New System.Drawing.Point(455, 15)
        Me.labelDonorInfo.Name = "labelDonorInfo"
        Me.labelDonorInfo.Size = New System.Drawing.Size(337, 40)
        Me.labelDonorInfo.TabIndex = 15
        Me.labelDonorInfo.Text = "Request Information"
        '
        'btnNRLoadRequests
        '
        Me.btnNRLoadRequests.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNRLoadRequests.Location = New System.Drawing.Point(633, 392)
        Me.btnNRLoadRequests.Name = "btnNRLoadRequests"
        Me.btnNRLoadRequests.Size = New System.Drawing.Size(155, 32)
        Me.btnNRLoadRequests.TabIndex = 66
        Me.btnNRLoadRequests.Text = "Load Requests"
        Me.btnNRLoadRequests.UseVisualStyleBackColor = True
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
        Me.Panel1.TabIndex = 61
        '
        'labelDonationInfo
        '
        Me.labelDonationInfo.AutoSize = True
        Me.labelDonationInfo.BackColor = System.Drawing.Color.Transparent
        Me.labelDonationInfo.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelDonationInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelDonationInfo.Location = New System.Drawing.Point(433, 108)
        Me.labelDonationInfo.Name = "labelDonationInfo"
        Me.labelDonationInfo.Size = New System.Drawing.Size(132, 16)
        Me.labelDonationInfo.TabIndex = 64
        Me.labelDonationInfo.Text = "Request Information"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.Controls.Add(Me.labelRequestStat)
        Me.Panel5.Controls.Add(Me.labelNRequestStatus)
        Me.Panel5.Controls.Add(Me.labelNRNurse)
        Me.Panel5.Controls.Add(Me.dropNRBloodType)
        Me.Panel5.Controls.Add(Me.labelNBType)
        Me.Panel5.Controls.Add(Me.labelANurse)
        Me.Panel5.Controls.Add(Me.labelNRID)
        Me.Panel5.Controls.Add(Me.labelNRequestID)
        Me.Panel5.Controls.Add(Me.Nnurse)
        Me.Panel5.Controls.Add(Me.adatedonated)
        Me.Panel5.Controls.Add(Me.txtNRQuantity1)
        Me.Panel5.Controls.Add(Me.Nquantity)
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(372, 215)
        Me.Panel5.TabIndex = 29
        '
        'labelRequestStat
        '
        Me.labelRequestStat.AutoSize = True
        Me.labelRequestStat.BackColor = System.Drawing.Color.Transparent
        Me.labelRequestStat.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelRequestStat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelRequestStat.Location = New System.Drawing.Point(180, 134)
        Me.labelRequestStat.Name = "labelRequestStat"
        Me.labelRequestStat.Size = New System.Drawing.Size(159, 16)
        Me.labelRequestStat.TabIndex = 36
        Me.labelRequestStat.Text = "                                      "
        '
        'labelNRequestStatus
        '
        Me.labelNRequestStatus.AutoSize = True
        Me.labelNRequestStatus.BackColor = System.Drawing.Color.Transparent
        Me.labelNRequestStatus.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelNRequestStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelNRequestStatus.Location = New System.Drawing.Point(43, 134)
        Me.labelNRequestStatus.Name = "labelNRequestStatus"
        Me.labelNRequestStatus.Size = New System.Drawing.Size(100, 16)
        Me.labelNRequestStatus.TabIndex = 35
        Me.labelNRequestStatus.Text = "Request Status:"
        '
        'labelNRNurse
        '
        Me.labelNRNurse.AutoSize = True
        Me.labelNRNurse.BackColor = System.Drawing.Color.Transparent
        Me.labelNRNurse.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelNRNurse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelNRNurse.Location = New System.Drawing.Point(180, 174)
        Me.labelNRNurse.Name = "labelNRNurse"
        Me.labelNRNurse.Size = New System.Drawing.Size(159, 16)
        Me.labelNRNurse.TabIndex = 34
        Me.labelNRNurse.Text = "                                      "
        '
        'dropNRBloodType
        '
        Me.dropNRBloodType.BackColor = System.Drawing.SystemColors.ControlText
        Me.dropNRBloodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropNRBloodType.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.dropNRBloodType.FormattingEnabled = True
        Me.dropNRBloodType.Items.AddRange(New Object() {"A-", "A+", "B-", "B+", "O-", "O+", "AB-", "AB+"})
        Me.dropNRBloodType.Location = New System.Drawing.Point(180, 54)
        Me.dropNRBloodType.Name = "dropNRBloodType"
        Me.dropNRBloodType.Size = New System.Drawing.Size(159, 23)
        Me.dropNRBloodType.TabIndex = 33
        '
        'labelNBType
        '
        Me.labelNBType.AutoSize = True
        Me.labelNBType.BackColor = System.Drawing.Color.Transparent
        Me.labelNBType.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelNBType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelNBType.Location = New System.Drawing.Point(43, 57)
        Me.labelNBType.Name = "labelNBType"
        Me.labelNBType.Size = New System.Drawing.Size(81, 16)
        Me.labelNBType.TabIndex = 13
        Me.labelNBType.Text = "Blood Type:"
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
        'labelNRID
        '
        Me.labelNRID.AutoSize = True
        Me.labelNRID.BackColor = System.Drawing.Color.Transparent
        Me.labelNRID.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelNRID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelNRID.Location = New System.Drawing.Point(180, 20)
        Me.labelNRID.Name = "labelNRID"
        Me.labelNRID.Size = New System.Drawing.Size(159, 16)
        Me.labelNRID.TabIndex = 19
        Me.labelNRID.Text = "                                      "
        '
        'labelNRequestID
        '
        Me.labelNRequestID.AutoSize = True
        Me.labelNRequestID.BackColor = System.Drawing.Color.Transparent
        Me.labelNRequestID.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelNRequestID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelNRequestID.Location = New System.Drawing.Point(43, 20)
        Me.labelNRequestID.Name = "labelNRequestID"
        Me.labelNRequestID.Size = New System.Drawing.Size(85, 16)
        Me.labelNRequestID.TabIndex = 12
        Me.labelNRequestID.Text = "Request ID: "
        '
        'Nnurse
        '
        Me.Nnurse.AutoSize = True
        Me.Nnurse.BackColor = System.Drawing.Color.Transparent
        Me.Nnurse.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Nnurse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Nnurse.Location = New System.Drawing.Point(43, 174)
        Me.Nnurse.Name = "Nnurse"
        Me.Nnurse.Size = New System.Drawing.Size(110, 16)
        Me.Nnurse.TabIndex = 18
        Me.Nnurse.Text = "Attending Nurse:"
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
        'txtNRQuantity1
        '
        Me.txtNRQuantity1.Location = New System.Drawing.Point(180, 91)
        Me.txtNRQuantity1.Name = "txtNRQuantity1"
        Me.txtNRQuantity1.Size = New System.Drawing.Size(159, 23)
        Me.txtNRQuantity1.TabIndex = 16
        '
        'Nquantity
        '
        Me.Nquantity.AutoSize = True
        Me.Nquantity.BackColor = System.Drawing.Color.Transparent
        Me.Nquantity.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Nquantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Nquantity.Location = New System.Drawing.Point(43, 95)
        Me.Nquantity.Name = "Nquantity"
        Me.Nquantity.Size = New System.Drawing.Size(131, 16)
        Me.Nquantity.TabIndex = 15
        Me.Nquantity.Text = "Quantity Requested:"
        '
        'labelDonorInfo1
        '
        Me.labelDonorInfo1.AutoSize = True
        Me.labelDonorInfo1.BackColor = System.Drawing.Color.Transparent
        Me.labelDonorInfo1.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelDonorInfo1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelDonorInfo1.Location = New System.Drawing.Point(36, 108)
        Me.labelDonorInfo1.Name = "labelDonorInfo1"
        Me.labelDonorInfo1.Size = New System.Drawing.Size(114, 16)
        Me.labelDonorInfo1.TabIndex = 63
        Me.labelDonorInfo1.Text = "Basic Information"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Firebrick
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Location = New System.Drawing.Point(409, 118)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(379, 221)
        Me.Panel4.TabIndex = 69
        '
        'btnNAddRequest
        '
        Me.btnNAddRequest.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNAddRequest.Location = New System.Drawing.Point(18, 354)
        Me.btnNAddRequest.Name = "btnNAddRequest"
        Me.btnNAddRequest.Size = New System.Drawing.Size(107, 32)
        Me.btnNAddRequest.TabIndex = 71
        Me.btnNAddRequest.Text = "Add"
        Me.btnNAddRequest.UseVisualStyleBackColor = True
        '
        'btnNRequestUpdate
        '
        Me.btnNRequestUpdate.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNRequestUpdate.Location = New System.Drawing.Point(153, 354)
        Me.btnNRequestUpdate.Name = "btnNRequestUpdate"
        Me.btnNRequestUpdate.Size = New System.Drawing.Size(107, 32)
        Me.btnNRequestUpdate.TabIndex = 70
        Me.btnNRequestUpdate.Text = "Update"
        Me.btnNRequestUpdate.UseVisualStyleBackColor = True
        '
        'btnCancelReq
        '
        Me.btnCancelReq.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCancelReq.Location = New System.Drawing.Point(680, 354)
        Me.btnCancelReq.Name = "btnCancelReq"
        Me.btnCancelReq.Size = New System.Drawing.Size(107, 32)
        Me.btnCancelReq.TabIndex = 72
        Me.btnCancelReq.Text = "Cancel"
        Me.btnCancelReq.UseVisualStyleBackColor = True
        '
        'btnGrantReq
        '
        Me.btnGrantReq.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnGrantReq.Location = New System.Drawing.Point(567, 354)
        Me.btnGrantReq.Name = "btnGrantReq"
        Me.btnGrantReq.Size = New System.Drawing.Size(107, 32)
        Me.btnGrantReq.TabIndex = 73
        Me.btnGrantReq.Text = "Granted"
        Me.btnGrantReq.UseVisualStyleBackColor = True
        '
        'btnNRDelete
        '
        Me.btnNRDelete.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNRDelete.Location = New System.Drawing.Point(290, 354)
        Me.btnNRDelete.Name = "btnNRDelete"
        Me.btnNRDelete.Size = New System.Drawing.Size(107, 32)
        Me.btnNRDelete.TabIndex = 74
        Me.btnNRDelete.Text = "Delete"
        Me.btnNRDelete.UseVisualStyleBackColor = True
        '
        'btnNClearNReqInfo
        '
        Me.btnNClearNReqInfo.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNClearNReqInfo.Location = New System.Drawing.Point(18, 392)
        Me.btnNClearNReqInfo.Name = "btnNClearNReqInfo"
        Me.btnNClearNReqInfo.Size = New System.Drawing.Size(107, 32)
        Me.btnNClearNReqInfo.TabIndex = 75
        Me.btnNClearNReqInfo.Text = "Clear"
        Me.btnNClearNReqInfo.UseVisualStyleBackColor = True
        '
        'NurseRequestInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 749)
        Me.Controls.Add(Me.btnNClearNReqInfo)
        Me.Controls.Add(Me.btnNRDelete)
        Me.Controls.Add(Me.btnGrantReq)
        Me.Controls.Add(Me.btnCancelReq)
        Me.Controls.Add(Me.btnNAddRequest)
        Me.Controls.Add(Me.btnNRequestUpdate)
        Me.Controls.Add(Me.labelDonorInfo1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnNBackRequest2)
        Me.Controls.Add(Me.btnNExitRequest)
        Me.Controls.Add(Me.gridNRequestList2)
        Me.Controls.Add(Me.btnNRLoadRequests)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.labelDonationInfo)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "NurseRequestInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Request Information"
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.gridNRequestList2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNRAddress As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents labelNRAddress As Label
    Friend WithEvents labelDonorID2 As Label
    Friend WithEvents txtNRLName As TextBox
    Friend WithEvents labelNRLName As Label
    Friend WithEvents txtNRFName As TextBox
    Friend WithEvents labelNRFName As Label
    Friend WithEvents btnNBackRequest2 As Button
    Friend WithEvents labelBIMS5 As Label
    Friend WithEvents labelDinuguan5 As Label
    Friend WithEvents btnNExitRequest As Button
    Friend WithEvents gridNRequestList2 As DataGridView
    Friend WithEvents idrequest As DataGridViewTextBoxColumn
    Friend WithEvents requestFname As DataGridViewTextBoxColumn
    Friend WithEvents requestLname As DataGridViewTextBoxColumn
    Friend WithEvents address As DataGridViewTextBoxColumn
    Friend WithEvents bloodType As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents requestStat As DataGridViewTextBoxColumn
    Friend WithEvents attNurse As DataGridViewTextBoxColumn
    Friend WithEvents labelDonorInfo As Label
    Friend WithEvents btnNRLoadRequests As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents labelDonationInfo As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents labelNRequestStatus As Label
    Friend WithEvents labelNRNurse As Label
    Friend WithEvents dropNRBloodType As ComboBox
    Friend WithEvents labelNBType As Label
    Friend WithEvents labelANurse As Label
    Friend WithEvents labelNRID As Label
    Friend WithEvents labelNRequestID As Label
    Friend WithEvents Nnurse As Label
    Friend WithEvents adatedonated As Label
    Friend WithEvents txtNRQuantity1 As TextBox
    Friend WithEvents Nquantity As Label
    Friend WithEvents labelDonorInfo1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnNAddRequest As Button
    Friend WithEvents btnNRequestUpdate As Button
    Friend WithEvents labelRequestStat As Label
    Friend WithEvents btnCancelReq As Button
    Friend WithEvents btnGrantReq As Button
    Friend WithEvents btnNRDelete As Button
    Friend WithEvents btnNClearNReqInfo As Button
End Class
