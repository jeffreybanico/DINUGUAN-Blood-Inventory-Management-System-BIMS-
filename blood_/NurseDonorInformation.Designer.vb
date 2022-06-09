<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NurseDonorInformation
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.labelDonationInfo = New System.Windows.Forms.Label()
        Me.txtNQuantity1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.labelNNurse = New System.Windows.Forms.Label()
        Me.labelNDateDonated = New System.Windows.Forms.Label()
        Me.nnurse = New System.Windows.Forms.Label()
        Me.ndatedonated = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.labelDonorInfo1 = New System.Windows.Forms.Label()
        Me.btnNDonorUpdate = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dropNDBloodType1 = New System.Windows.Forms.ComboBox()
        Me.labelBType = New System.Windows.Forms.Label()
        Me.labelDonorID = New System.Windows.Forms.Label()
        Me.labelNDonorID2 = New System.Windows.Forms.Label()
        Me.txtNDLName = New System.Windows.Forms.TextBox()
        Me.labelDLName = New System.Windows.Forms.Label()
        Me.txtNDFName = New System.Windows.Forms.TextBox()
        Me.labelDFName = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.labelDinuguan5 = New System.Windows.Forms.Label()
        Me.btnNExitDonor = New System.Windows.Forms.Button()
        Me.gridNDonorList2 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.labelBIMS5 = New System.Windows.Forms.Label()
        Me.btnNDLoadDonors = New System.Windows.Forms.Button()
        Me.btnNBackDonor2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.labelDonorInfo = New System.Windows.Forms.Label()
        Me.btnNAddDonor = New System.Windows.Forms.Button()
        Me.btnNDelete = New System.Windows.Forms.Button()
        Me.btnNClearDonInfo = New System.Windows.Forms.Button()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.gridNDonorList2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelDonationInfo
        '
        Me.labelDonationInfo.AutoSize = True
        Me.labelDonationInfo.BackColor = System.Drawing.Color.Transparent
        Me.labelDonationInfo.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelDonationInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelDonationInfo.Location = New System.Drawing.Point(434, 101)
        Me.labelDonationInfo.Name = "labelDonationInfo"
        Me.labelDonationInfo.Size = New System.Drawing.Size(140, 16)
        Me.labelDonationInfo.TabIndex = 54
        Me.labelDonationInfo.Text = "Donation Information"
        '
        'txtNQuantity1
        '
        Me.txtNQuantity1.Location = New System.Drawing.Point(164, 94)
        Me.txtNQuantity1.Name = "txtNQuantity1"
        Me.txtNQuantity1.Size = New System.Drawing.Size(173, 23)
        Me.txtNQuantity1.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(42, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Quantity Donated:"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.Controls.Add(Me.labelNNurse)
        Me.Panel5.Controls.Add(Me.labelNDateDonated)
        Me.Panel5.Controls.Add(Me.nnurse)
        Me.Panel5.Controls.Add(Me.ndatedonated)
        Me.Panel5.Controls.Add(Me.txtNQuantity1)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(372, 215)
        Me.Panel5.TabIndex = 29
        '
        'labelNNurse
        '
        Me.labelNNurse.AutoSize = True
        Me.labelNNurse.BackColor = System.Drawing.Color.Transparent
        Me.labelNNurse.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelNNurse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelNNurse.Location = New System.Drawing.Point(164, 137)
        Me.labelNNurse.Name = "labelNNurse"
        Me.labelNNurse.Size = New System.Drawing.Size(171, 16)
        Me.labelNNurse.TabIndex = 14
        Me.labelNNurse.Text = "                                         "
        '
        'labelNDateDonated
        '
        Me.labelNDateDonated.AutoSize = True
        Me.labelNDateDonated.BackColor = System.Drawing.Color.Transparent
        Me.labelNDateDonated.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelNDateDonated.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelNDateDonated.Location = New System.Drawing.Point(165, 59)
        Me.labelNDateDonated.Name = "labelNDateDonated"
        Me.labelNDateDonated.Size = New System.Drawing.Size(171, 16)
        Me.labelNDateDonated.TabIndex = 13
        Me.labelNDateDonated.Text = "                                         "
        '
        'nnurse
        '
        Me.nnurse.AutoSize = True
        Me.nnurse.BackColor = System.Drawing.Color.Transparent
        Me.nnurse.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.nnurse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.nnurse.Location = New System.Drawing.Point(42, 137)
        Me.nnurse.Name = "nnurse"
        Me.nnurse.Size = New System.Drawing.Size(110, 16)
        Me.nnurse.TabIndex = 12
        Me.nnurse.Text = "Attending Nurse:"
        '
        'ndatedonated
        '
        Me.ndatedonated.AutoSize = True
        Me.ndatedonated.BackColor = System.Drawing.Color.Transparent
        Me.ndatedonated.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ndatedonated.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ndatedonated.Location = New System.Drawing.Point(42, 59)
        Me.ndatedonated.Name = "ndatedonated"
        Me.ndatedonated.Size = New System.Drawing.Size(95, 16)
        Me.ndatedonated.TabIndex = 11
        Me.ndatedonated.Text = "Date Donated:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Firebrick
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Location = New System.Drawing.Point(410, 111)
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
        Me.labelDonorInfo1.Location = New System.Drawing.Point(37, 101)
        Me.labelDonorInfo1.Name = "labelDonorInfo1"
        Me.labelDonorInfo1.Size = New System.Drawing.Size(122, 16)
        Me.labelDonorInfo1.TabIndex = 53
        Me.labelDonorInfo1.Text = "Donor Information"
        '
        'btnNDonorUpdate
        '
        Me.btnNDonorUpdate.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNDonorUpdate.Location = New System.Drawing.Point(157, 347)
        Me.btnNDonorUpdate.Name = "btnNDonorUpdate"
        Me.btnNDonorUpdate.Size = New System.Drawing.Size(107, 32)
        Me.btnNDonorUpdate.TabIndex = 50
        Me.btnNDonorUpdate.Text = "Update"
        Me.btnNDonorUpdate.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.dropNDBloodType1)
        Me.Panel3.Controls.Add(Me.labelBType)
        Me.Panel3.Controls.Add(Me.labelDonorID)
        Me.Panel3.Controls.Add(Me.labelNDonorID2)
        Me.Panel3.Controls.Add(Me.txtNDLName)
        Me.Panel3.Controls.Add(Me.labelDLName)
        Me.Panel3.Controls.Add(Me.txtNDFName)
        Me.Panel3.Controls.Add(Me.labelDFName)
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(372, 215)
        Me.Panel3.TabIndex = 29
        '
        'dropNDBloodType1
        '
        Me.dropNDBloodType1.BackColor = System.Drawing.SystemColors.ControlText
        Me.dropNDBloodType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropNDBloodType1.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.dropNDBloodType1.FormattingEnabled = True
        Me.dropNDBloodType1.Items.AddRange(New Object() {"A-", "A+", "B-", "B+", "O-", "O+", "AB-", "AB+"})
        Me.dropNDBloodType1.Location = New System.Drawing.Point(162, 160)
        Me.dropNDBloodType1.Name = "dropNDBloodType1"
        Me.dropNDBloodType1.Size = New System.Drawing.Size(173, 23)
        Me.dropNDBloodType1.TabIndex = 33
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
        'labelNDonorID2
        '
        Me.labelNDonorID2.AutoSize = True
        Me.labelNDonorID2.BackColor = System.Drawing.Color.Transparent
        Me.labelNDonorID2.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelNDonorID2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelNDonorID2.Location = New System.Drawing.Point(162, 31)
        Me.labelNDonorID2.Name = "labelNDonorID2"
        Me.labelNDonorID2.Size = New System.Drawing.Size(31, 16)
        Me.labelNDonorID2.TabIndex = 11
        Me.labelNDonorID2.Text = "      "
        '
        'txtNDLName
        '
        Me.txtNDLName.Location = New System.Drawing.Point(162, 115)
        Me.txtNDLName.Name = "txtNDLName"
        Me.txtNDLName.Size = New System.Drawing.Size(173, 23)
        Me.txtNDLName.TabIndex = 6
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
        'txtNDFName
        '
        Me.txtNDFName.Location = New System.Drawing.Point(162, 70)
        Me.txtNDFName.Name = "txtNDFName"
        Me.txtNDFName.Size = New System.Drawing.Size(173, 23)
        Me.txtNDFName.TabIndex = 4
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Firebrick
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(19, 111)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(379, 221)
        Me.Panel2.TabIndex = 52
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
        'btnNExitDonor
        '
        Me.btnNExitDonor.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNExitDonor.Location = New System.Drawing.Point(682, 631)
        Me.btnNExitDonor.Name = "btnNExitDonor"
        Me.btnNExitDonor.Size = New System.Drawing.Size(107, 32)
        Me.btnNExitDonor.TabIndex = 58
        Me.btnNExitDonor.Text = "Exit"
        Me.btnNExitDonor.UseVisualStyleBackColor = True
        '
        'gridNDonorList2
        '
        Me.gridNDonorList2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridNDonorList2.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.gridNDonorList2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridNDonorList2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.gridNDonorList2.Location = New System.Drawing.Point(19, 397)
        Me.gridNDonorList2.Name = "gridNDonorList2"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridNDonorList2.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.gridNDonorList2.RowTemplate.Height = 25
        Me.gridNDonorList2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.gridNDonorList2.Size = New System.Drawing.Size(769, 219)
        Me.gridNDonorList2.TabIndex = 55
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
        'btnNDLoadDonors
        '
        Me.btnNDLoadDonors.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNDLoadDonors.Location = New System.Drawing.Point(634, 347)
        Me.btnNDLoadDonors.Name = "btnNDLoadDonors"
        Me.btnNDLoadDonors.Size = New System.Drawing.Size(151, 32)
        Me.btnNDLoadDonors.TabIndex = 56
        Me.btnNDLoadDonors.Text = "Load Donors"
        Me.btnNDLoadDonors.UseVisualStyleBackColor = True
        '
        'btnNBackDonor2
        '
        Me.btnNBackDonor2.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNBackDonor2.Location = New System.Drawing.Point(557, 631)
        Me.btnNBackDonor2.Name = "btnNBackDonor2"
        Me.btnNBackDonor2.Size = New System.Drawing.Size(107, 32)
        Me.btnNBackDonor2.TabIndex = 57
        Me.btnNBackDonor2.Text = "Back"
        Me.btnNBackDonor2.UseVisualStyleBackColor = True
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
        'btnNAddDonor
        '
        Me.btnNAddDonor.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNAddDonor.Location = New System.Drawing.Point(22, 347)
        Me.btnNAddDonor.Name = "btnNAddDonor"
        Me.btnNAddDonor.Size = New System.Drawing.Size(107, 32)
        Me.btnNAddDonor.TabIndex = 60
        Me.btnNAddDonor.Text = "Add"
        Me.btnNAddDonor.UseVisualStyleBackColor = True
        '
        'btnNDelete
        '
        Me.btnNDelete.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNDelete.Location = New System.Drawing.Point(287, 347)
        Me.btnNDelete.Name = "btnNDelete"
        Me.btnNDelete.Size = New System.Drawing.Size(107, 32)
        Me.btnNDelete.TabIndex = 61
        Me.btnNDelete.Text = "Delete"
        Me.btnNDelete.UseVisualStyleBackColor = True
        '
        'btnNClearDonInfo
        '
        Me.btnNClearDonInfo.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNClearDonInfo.Location = New System.Drawing.Point(504, 347)
        Me.btnNClearDonInfo.Name = "btnNClearDonInfo"
        Me.btnNClearDonInfo.Size = New System.Drawing.Size(107, 32)
        Me.btnNClearDonInfo.TabIndex = 62
        Me.btnNClearDonInfo.Text = "Clear"
        Me.btnNClearDonInfo.UseVisualStyleBackColor = True
        '
        'NurseDonorInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 675)
        Me.Controls.Add(Me.btnNClearDonInfo)
        Me.Controls.Add(Me.btnNDelete)
        Me.Controls.Add(Me.btnNAddDonor)
        Me.Controls.Add(Me.labelDonationInfo)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.labelDonorInfo1)
        Me.Controls.Add(Me.btnNDonorUpdate)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnNExitDonor)
        Me.Controls.Add(Me.gridNDonorList2)
        Me.Controls.Add(Me.btnNDLoadDonors)
        Me.Controls.Add(Me.btnNBackDonor2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "NurseDonorInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nurse Donor Information"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.gridNDonorList2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelDonationInfo As Label
    Friend WithEvents txtNQuantity1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents labelDonorInfo1 As Label
    Friend WithEvents btnNDonorUpdate As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dropNDBloodType1 As ComboBox
    Friend WithEvents labelBType As Label
    Friend WithEvents labelDonorID As Label
    Friend WithEvents labelNDonorID2 As Label
    Friend WithEvents txtNDLName As TextBox
    Friend WithEvents labelDLName As Label
    Friend WithEvents txtNDFName As TextBox
    Friend WithEvents labelDFName As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents labelDinuguan5 As Label
    Friend WithEvents btnNExitDonor As Button
    Friend WithEvents gridNDonorList2 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents labelBIMS5 As Label
    Friend WithEvents btnNDLoadDonors As Button
    Friend WithEvents btnNBackDonor2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents labelDonorInfo As Label
    Friend WithEvents btnNAddDonor As Button
    Friend WithEvents labelNNurse As Label
    Friend WithEvents labelNDateDonated As Label
    Friend WithEvents nnurse As Label
    Friend WithEvents ndatedonated As Label
    Friend WithEvents btnNDelete As Button
    Friend WithEvents btnNClearDonInfo As Button
End Class
