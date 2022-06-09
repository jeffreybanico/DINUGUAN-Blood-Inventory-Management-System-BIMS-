<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminDonorInformation
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
        Me.btnExitDonor = New System.Windows.Forms.Button()
        Me.gridDonorList2 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDLoadDonors = New System.Windows.Forms.Button()
        Me.btnBackDonor2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.labelDonorInfo = New System.Windows.Forms.Label()
        Me.labelBIMS5 = New System.Windows.Forms.Label()
        Me.labelDinuguan5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dropDBloodType1 = New System.Windows.Forms.ComboBox()
        Me.labelBType = New System.Windows.Forms.Label()
        Me.labelDonorID = New System.Windows.Forms.Label()
        Me.labelDonorID2 = New System.Windows.Forms.Label()
        Me.txtDLName = New System.Windows.Forms.TextBox()
        Me.labelDLName = New System.Windows.Forms.Label()
        Me.txtDFName = New System.Windows.Forms.TextBox()
        Me.labelDFName = New System.Windows.Forms.Label()
        Me.btnDonorUpdate = New System.Windows.Forms.Button()
        Me.labelDonorInfo1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.labelANurse = New System.Windows.Forms.Label()
        Me.labelADateDonated = New System.Windows.Forms.Label()
        Me.anurse = New System.Windows.Forms.Label()
        Me.adatedonated = New System.Windows.Forms.Label()
        Me.txtAQuantity1 = New System.Windows.Forms.TextBox()
        Me.aquantity = New System.Windows.Forms.Label()
        Me.labelDonationInfo = New System.Windows.Forms.Label()
        Me.btnADelete = New System.Windows.Forms.Button()
        CType(Me.gridDonorList2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExitDonor
        '
        Me.btnExitDonor.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnExitDonor.Location = New System.Drawing.Point(670, 631)
        Me.btnExitDonor.Name = "btnExitDonor"
        Me.btnExitDonor.Size = New System.Drawing.Size(107, 32)
        Me.btnExitDonor.TabIndex = 48
        Me.btnExitDonor.Text = "Exit"
        Me.btnExitDonor.UseVisualStyleBackColor = True
        '
        'gridDonorList2
        '
        Me.gridDonorList2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridDonorList2.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.gridDonorList2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridDonorList2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.gridDonorList2.Location = New System.Drawing.Point(21, 403)
        Me.gridDonorList2.Name = "gridDonorList2"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridDonorList2.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gridDonorList2.RowTemplate.Height = 25
        Me.gridDonorList2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.gridDonorList2.Size = New System.Drawing.Size(756, 219)
        Me.gridDonorList2.TabIndex = 44
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "iduser"
        Me.Column1.HeaderText = "Donor ID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "u_fname"
        Me.Column2.HeaderText = "First Name"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "u_lname"
        Me.Column3.HeaderText = "Last Name"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "u_phone_no"
        Me.Column4.HeaderText = "Blood Type"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "u_email_add"
        Me.Column5.HeaderText = "Date Donated"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "u_username"
        Me.Column6.HeaderText = "Quantity Donated"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Attending Nurse"
        Me.Column7.Name = "Column7"
        '
        'btnDLoadDonors
        '
        Me.btnDLoadDonors.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDLoadDonors.Location = New System.Drawing.Point(633, 354)
        Me.btnDLoadDonors.Name = "btnDLoadDonors"
        Me.btnDLoadDonors.Size = New System.Drawing.Size(151, 32)
        Me.btnDLoadDonors.TabIndex = 45
        Me.btnDLoadDonors.Text = "Load Donors"
        Me.btnDLoadDonors.UseVisualStyleBackColor = True
        '
        'btnBackDonor2
        '
        Me.btnBackDonor2.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBackDonor2.Location = New System.Drawing.Point(545, 631)
        Me.btnBackDonor2.Name = "btnBackDonor2"
        Me.btnBackDonor2.Size = New System.Drawing.Size(107, 32)
        Me.btnBackDonor2.TabIndex = 47
        Me.btnBackDonor2.Text = "Back"
        Me.btnBackDonor2.UseVisualStyleBackColor = True
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
        Me.Panel1.TabIndex = 39
        '
        'labelDonorInfo
        '
        Me.labelDonorInfo.AutoSize = True
        Me.labelDonorInfo.BackColor = System.Drawing.Color.Firebrick
        Me.labelDonorInfo.Font = New System.Drawing.Font("Imprint MT Shadow", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelDonorInfo.ForeColor = System.Drawing.Color.Transparent
        Me.labelDonorInfo.Location = New System.Drawing.Point(465, 15)
        Me.labelDonorInfo.Name = "labelDonorInfo"
        Me.labelDonorInfo.Size = New System.Drawing.Size(312, 40)
        Me.labelDonorInfo.TabIndex = 15
        Me.labelDonorInfo.Text = "Donor Information"
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Firebrick
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(18, 118)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(379, 221)
        Me.Panel2.TabIndex = 40
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.dropDBloodType1)
        Me.Panel3.Controls.Add(Me.labelBType)
        Me.Panel3.Controls.Add(Me.labelDonorID)
        Me.Panel3.Controls.Add(Me.labelDonorID2)
        Me.Panel3.Controls.Add(Me.txtDLName)
        Me.Panel3.Controls.Add(Me.labelDLName)
        Me.Panel3.Controls.Add(Me.txtDFName)
        Me.Panel3.Controls.Add(Me.labelDFName)
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(372, 215)
        Me.Panel3.TabIndex = 29
        '
        'dropDBloodType1
        '
        Me.dropDBloodType1.BackColor = System.Drawing.SystemColors.ControlText
        Me.dropDBloodType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropDBloodType1.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.dropDBloodType1.FormattingEnabled = True
        Me.dropDBloodType1.Items.AddRange(New Object() {"A-", "A+", "B-", "B+", "O-", "O+", "AB-", "AB+"})
        Me.dropDBloodType1.Location = New System.Drawing.Point(162, 160)
        Me.dropDBloodType1.Name = "dropDBloodType1"
        Me.dropDBloodType1.Size = New System.Drawing.Size(173, 23)
        Me.dropDBloodType1.TabIndex = 33
        '
        'labelBType
        '
        Me.labelBType.AutoSize = True
        Me.labelBType.BackColor = System.Drawing.Color.Transparent
        Me.labelBType.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelBType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelBType.Location = New System.Drawing.Point(39, 163)
        Me.labelBType.Name = "labelBType"
        Me.labelBType.Size = New System.Drawing.Size(81, 16)
        Me.labelBType.TabIndex = 13
        Me.labelBType.Text = "Blood Type:"
        '
        'labelDonorID
        '
        Me.labelDonorID.AutoSize = True
        Me.labelDonorID.BackColor = System.Drawing.Color.Transparent
        Me.labelDonorID.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelDonorID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelDonorID.Location = New System.Drawing.Point(39, 31)
        Me.labelDonorID.Name = "labelDonorID"
        Me.labelDonorID.Size = New System.Drawing.Size(75, 16)
        Me.labelDonorID.TabIndex = 12
        Me.labelDonorID.Text = "Donor ID: "
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
        'txtDLName
        '
        Me.txtDLName.Location = New System.Drawing.Point(162, 115)
        Me.txtDLName.Name = "txtDLName"
        Me.txtDLName.Size = New System.Drawing.Size(173, 23)
        Me.txtDLName.TabIndex = 6
        '
        'labelDLName
        '
        Me.labelDLName.AutoSize = True
        Me.labelDLName.BackColor = System.Drawing.Color.Transparent
        Me.labelDLName.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelDLName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelDLName.Location = New System.Drawing.Point(39, 118)
        Me.labelDLName.Name = "labelDLName"
        Me.labelDLName.Size = New System.Drawing.Size(75, 16)
        Me.labelDLName.TabIndex = 5
        Me.labelDLName.Text = "Last Name:"
        '
        'txtDFName
        '
        Me.txtDFName.Location = New System.Drawing.Point(162, 70)
        Me.txtDFName.Name = "txtDFName"
        Me.txtDFName.Size = New System.Drawing.Size(173, 23)
        Me.txtDFName.TabIndex = 4
        '
        'labelDFName
        '
        Me.labelDFName.AutoSize = True
        Me.labelDFName.BackColor = System.Drawing.Color.Transparent
        Me.labelDFName.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelDFName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelDFName.Location = New System.Drawing.Point(39, 73)
        Me.labelDFName.Name = "labelDFName"
        Me.labelDFName.Size = New System.Drawing.Size(77, 16)
        Me.labelDFName.TabIndex = 3
        Me.labelDFName.Text = "First Name:"
        '
        'btnDonorUpdate
        '
        Me.btnDonorUpdate.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDonorUpdate.Location = New System.Drawing.Point(18, 354)
        Me.btnDonorUpdate.Name = "btnDonorUpdate"
        Me.btnDonorUpdate.Size = New System.Drawing.Size(107, 32)
        Me.btnDonorUpdate.TabIndex = 38
        Me.btnDonorUpdate.Text = "Update"
        Me.btnDonorUpdate.UseVisualStyleBackColor = True
        '
        'labelDonorInfo1
        '
        Me.labelDonorInfo1.AutoSize = True
        Me.labelDonorInfo1.BackColor = System.Drawing.Color.Transparent
        Me.labelDonorInfo1.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelDonorInfo1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelDonorInfo1.Location = New System.Drawing.Point(36, 108)
        Me.labelDonorInfo1.Name = "labelDonorInfo1"
        Me.labelDonorInfo1.Size = New System.Drawing.Size(122, 16)
        Me.labelDonorInfo1.TabIndex = 41
        Me.labelDonorInfo1.Text = "Donor Information"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Firebrick
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Location = New System.Drawing.Point(409, 118)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(379, 221)
        Me.Panel4.TabIndex = 49
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.Controls.Add(Me.labelANurse)
        Me.Panel5.Controls.Add(Me.labelADateDonated)
        Me.Panel5.Controls.Add(Me.anurse)
        Me.Panel5.Controls.Add(Me.adatedonated)
        Me.Panel5.Controls.Add(Me.txtAQuantity1)
        Me.Panel5.Controls.Add(Me.aquantity)
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(372, 215)
        Me.Panel5.TabIndex = 29
        '
        'labelANurse
        '
        Me.labelANurse.AutoSize = True
        Me.labelANurse.BackColor = System.Drawing.Color.Transparent
        Me.labelANurse.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelANurse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelANurse.Location = New System.Drawing.Point(165, 136)
        Me.labelANurse.Name = "labelANurse"
        Me.labelANurse.Size = New System.Drawing.Size(171, 16)
        Me.labelANurse.TabIndex = 20
        Me.labelANurse.Text = "                                         "
        '
        'labelADateDonated
        '
        Me.labelADateDonated.AutoSize = True
        Me.labelADateDonated.BackColor = System.Drawing.Color.Transparent
        Me.labelADateDonated.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelADateDonated.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelADateDonated.Location = New System.Drawing.Point(166, 58)
        Me.labelADateDonated.Name = "labelADateDonated"
        Me.labelADateDonated.Size = New System.Drawing.Size(171, 16)
        Me.labelADateDonated.TabIndex = 19
        Me.labelADateDonated.Text = "                                         "
        '
        'anurse
        '
        Me.anurse.AutoSize = True
        Me.anurse.BackColor = System.Drawing.Color.Transparent
        Me.anurse.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.anurse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.anurse.Location = New System.Drawing.Point(43, 136)
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
        Me.adatedonated.Size = New System.Drawing.Size(95, 16)
        Me.adatedonated.TabIndex = 17
        Me.adatedonated.Text = "Date Donated:"
        '
        'txtAQuantity1
        '
        Me.txtAQuantity1.Location = New System.Drawing.Point(165, 93)
        Me.txtAQuantity1.Name = "txtAQuantity1"
        Me.txtAQuantity1.Size = New System.Drawing.Size(173, 23)
        Me.txtAQuantity1.TabIndex = 16
        '
        'aquantity
        '
        Me.aquantity.AutoSize = True
        Me.aquantity.BackColor = System.Drawing.Color.Transparent
        Me.aquantity.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.aquantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.aquantity.Location = New System.Drawing.Point(43, 96)
        Me.aquantity.Name = "aquantity"
        Me.aquantity.Size = New System.Drawing.Size(120, 16)
        Me.aquantity.TabIndex = 15
        Me.aquantity.Text = "Quantity Donated:"
        '
        'labelDonationInfo
        '
        Me.labelDonationInfo.AutoSize = True
        Me.labelDonationInfo.BackColor = System.Drawing.Color.Transparent
        Me.labelDonationInfo.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelDonationInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelDonationInfo.Location = New System.Drawing.Point(433, 108)
        Me.labelDonationInfo.Name = "labelDonationInfo"
        Me.labelDonationInfo.Size = New System.Drawing.Size(140, 16)
        Me.labelDonationInfo.TabIndex = 42
        Me.labelDonationInfo.Text = "Donation Information"
        '
        'btnADelete
        '
        Me.btnADelete.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnADelete.Location = New System.Drawing.Point(156, 354)
        Me.btnADelete.Name = "btnADelete"
        Me.btnADelete.Size = New System.Drawing.Size(107, 32)
        Me.btnADelete.TabIndex = 50
        Me.btnADelete.Text = "Delete"
        Me.btnADelete.UseVisualStyleBackColor = True
        '
        'AdminDonorInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 675)
        Me.Controls.Add(Me.btnADelete)
        Me.Controls.Add(Me.labelDonationInfo)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.labelDonorInfo1)
        Me.Controls.Add(Me.btnExitDonor)
        Me.Controls.Add(Me.gridDonorList2)
        Me.Controls.Add(Me.btnDLoadDonors)
        Me.Controls.Add(Me.btnBackDonor2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnDonorUpdate)
        Me.Name = "AdminDonorInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Donor Information"
        CType(Me.gridDonorList2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExitDonor As Button
    Friend WithEvents gridDonorList2 As DataGridView
    Friend WithEvents btnDLoadDonors As Button
    Friend WithEvents btnBackDonor2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents labelDonorInfo As Label
    Friend WithEvents labelBIMS5 As Label
    Friend WithEvents labelDinuguan5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents labelDonorID As Label
    Friend WithEvents labelDonorID2 As Label
    Friend WithEvents txtDLName As TextBox
    Friend WithEvents labelDLName As Label
    Friend WithEvents txtDFName As TextBox
    Friend WithEvents labelDFName As Label
    Friend WithEvents btnDonorUpdate As Button
    Friend WithEvents labelDonorInfo1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents labelBType As Label
    Friend WithEvents labelDonationInfo As Label
    Friend WithEvents dropDBloodType1 As ComboBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents labelADateDonated As Label
    Friend WithEvents anurse As Label
    Friend WithEvents adatedonated As Label
    Friend WithEvents txtAQuantity1 As TextBox
    Friend WithEvents aquantity As Label
    Friend WithEvents labelANurse As Label
    Friend WithEvents btnADelete As Button
End Class
