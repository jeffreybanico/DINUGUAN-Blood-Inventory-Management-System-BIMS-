<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NurseRequest
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
        Me.requestStat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numofRequest = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bloodType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.requestLname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.requestFname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.attNurse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNBack = New System.Windows.Forms.Button()
        Me.btnNSearchRequest = New System.Windows.Forms.Button()
        Me.dropNStatus = New System.Windows.Forms.ComboBox()
        Me.labelSearchDonor = New System.Windows.Forms.Label()
        Me.dropNSearchRequest = New System.Windows.Forms.ComboBox()
        Me.btnNEditRequest = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.labelDonorList = New System.Windows.Forms.Label()
        Me.labelBIMS4 = New System.Windows.Forms.Label()
        Me.labelDinuguan4 = New System.Windows.Forms.Label()
        Me.gridNRequestList = New System.Windows.Forms.DataGridView()
        Me.txtNSearchRequest = New System.Windows.Forms.TextBox()
        Me.labelBType = New System.Windows.Forms.Label()
        Me.btnNRequest = New System.Windows.Forms.Button()
        Me.btnClearNRequest = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.gridNRequestList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'requestStat
        '
        Me.requestStat.HeaderText = "Request Status"
        Me.requestStat.Name = "requestStat"
        Me.requestStat.ReadOnly = True
        '
        'address
        '
        Me.address.HeaderText = "Address"
        Me.address.Name = "address"
        Me.address.ReadOnly = True
        '
        'numofRequest
        '
        Me.numofRequest.HeaderText = "Quantity Requested"
        Me.numofRequest.Name = "numofRequest"
        Me.numofRequest.ReadOnly = True
        '
        'bloodType
        '
        Me.bloodType.HeaderText = "Blood Type"
        Me.bloodType.Name = "bloodType"
        Me.bloodType.ReadOnly = True
        '
        'requestLname
        '
        Me.requestLname.HeaderText = "Last Name"
        Me.requestLname.Name = "requestLname"
        Me.requestLname.ReadOnly = True
        '
        'requestFname
        '
        Me.requestFname.HeaderText = "First Name"
        Me.requestFname.Name = "requestFname"
        Me.requestFname.ReadOnly = True
        '
        'attNurse
        '
        Me.attNurse.HeaderText = "Attending Nurse"
        Me.attNurse.Name = "attNurse"
        Me.attNurse.ReadOnly = True
        '
        'btnNBack
        '
        Me.btnNBack.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNBack.Location = New System.Drawing.Point(682, 458)
        Me.btnNBack.Name = "btnNBack"
        Me.btnNBack.Size = New System.Drawing.Size(107, 32)
        Me.btnNBack.TabIndex = 68
        Me.btnNBack.Text = "Back"
        Me.btnNBack.UseVisualStyleBackColor = True
        '
        'btnNSearchRequest
        '
        Me.btnNSearchRequest.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNSearchRequest.Location = New System.Drawing.Point(452, 91)
        Me.btnNSearchRequest.Name = "btnNSearchRequest"
        Me.btnNSearchRequest.Size = New System.Drawing.Size(67, 29)
        Me.btnNSearchRequest.TabIndex = 67
        Me.btnNSearchRequest.Text = "Search"
        Me.btnNSearchRequest.UseVisualStyleBackColor = True
        '
        'dropNStatus
        '
        Me.dropNStatus.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.dropNStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropNStatus.FormattingEnabled = True
        Me.dropNStatus.Items.AddRange(New Object() {"All", "Pending", "Cancelled", "Granted"})
        Me.dropNStatus.Location = New System.Drawing.Point(595, 101)
        Me.dropNStatus.Name = "dropNStatus"
        Me.dropNStatus.Size = New System.Drawing.Size(168, 23)
        Me.dropNStatus.TabIndex = 66
        '
        'labelSearchDonor
        '
        Me.labelSearchDonor.AutoSize = True
        Me.labelSearchDonor.BackColor = System.Drawing.SystemColors.Control
        Me.labelSearchDonor.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelSearchDonor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelSearchDonor.Location = New System.Drawing.Point(34, 98)
        Me.labelSearchDonor.Name = "labelSearchDonor"
        Me.labelSearchDonor.Size = New System.Drawing.Size(49, 16)
        Me.labelSearchDonor.TabIndex = 64
        Me.labelSearchDonor.Text = "Search:"
        '
        'dropNSearchRequest
        '
        Me.dropNSearchRequest.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.dropNSearchRequest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropNSearchRequest.FormattingEnabled = True
        Me.dropNSearchRequest.Items.AddRange(New Object() {"All", "First Name", "Last Name", "Blood Type"})
        Me.dropNSearchRequest.Location = New System.Drawing.Point(96, 95)
        Me.dropNSearchRequest.Name = "dropNSearchRequest"
        Me.dropNSearchRequest.Size = New System.Drawing.Size(125, 23)
        Me.dropNSearchRequest.TabIndex = 62
        '
        'btnNEditRequest
        '
        Me.btnNEditRequest.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNEditRequest.Location = New System.Drawing.Point(15, 457)
        Me.btnNEditRequest.Name = "btnNEditRequest"
        Me.btnNEditRequest.Size = New System.Drawing.Size(107, 32)
        Me.btnNEditRequest.TabIndex = 60
        Me.btnNEditRequest.Text = "Edit"
        Me.btnNEditRequest.UseVisualStyleBackColor = True
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
        Me.Panel1.TabIndex = 59
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
        'gridNRequestList
        '
        Me.gridNRequestList.AllowUserToAddRows = False
        Me.gridNRequestList.AllowUserToDeleteRows = False
        Me.gridNRequestList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridNRequestList.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.gridNRequestList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridNRequestList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.requestFname, Me.requestLname, Me.bloodType, Me.numofRequest, Me.address, Me.attNurse, Me.requestStat})
        Me.gridNRequestList.Location = New System.Drawing.Point(13, 133)
        Me.gridNRequestList.Name = "gridNRequestList"
        Me.gridNRequestList.ReadOnly = True
        Me.gridNRequestList.RowTemplate.Height = 25
        Me.gridNRequestList.Size = New System.Drawing.Size(776, 311)
        Me.gridNRequestList.TabIndex = 58
        '
        'txtNSearchRequest
        '
        Me.txtNSearchRequest.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtNSearchRequest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNSearchRequest.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtNSearchRequest.Location = New System.Drawing.Point(240, 95)
        Me.txtNSearchRequest.Multiline = True
        Me.txtNSearchRequest.Name = "txtNSearchRequest"
        Me.txtNSearchRequest.Size = New System.Drawing.Size(197, 23)
        Me.txtNSearchRequest.TabIndex = 63
        '
        'labelBType
        '
        Me.labelBType.AutoSize = True
        Me.labelBType.BackColor = System.Drawing.SystemColors.Control
        Me.labelBType.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelBType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelBType.Location = New System.Drawing.Point(595, 82)
        Me.labelBType.Name = "labelBType"
        Me.labelBType.Size = New System.Drawing.Size(156, 16)
        Me.labelBType.TabIndex = 65
        Me.labelBType.Text = "Filter by Request Status:"
        '
        'btnNRequest
        '
        Me.btnNRequest.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNRequest.Location = New System.Drawing.Point(350, 457)
        Me.btnNRequest.Name = "btnNRequest"
        Me.btnNRequest.Size = New System.Drawing.Size(146, 32)
        Me.btnNRequest.TabIndex = 61
        Me.btnNRequest.Text = "Load Requests"
        Me.btnNRequest.UseVisualStyleBackColor = True
        '
        'btnClearNRequest
        '
        Me.btnClearNRequest.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClearNRequest.Location = New System.Drawing.Point(525, 91)
        Me.btnClearNRequest.Name = "btnClearNRequest"
        Me.btnClearNRequest.Size = New System.Drawing.Size(54, 29)
        Me.btnClearNRequest.TabIndex = 69
        Me.btnClearNRequest.Text = "Clear"
        Me.btnClearNRequest.UseVisualStyleBackColor = True
        '
        'NurseRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 500)
        Me.Controls.Add(Me.btnClearNRequest)
        Me.Controls.Add(Me.btnNBack)
        Me.Controls.Add(Me.btnNSearchRequest)
        Me.Controls.Add(Me.dropNStatus)
        Me.Controls.Add(Me.labelSearchDonor)
        Me.Controls.Add(Me.dropNSearchRequest)
        Me.Controls.Add(Me.btnNEditRequest)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gridNRequestList)
        Me.Controls.Add(Me.txtNSearchRequest)
        Me.Controls.Add(Me.labelBType)
        Me.Controls.Add(Me.btnNRequest)
        Me.Name = "NurseRequest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Request List"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.gridNRequestList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents requestStat As DataGridViewTextBoxColumn
    Friend WithEvents address As DataGridViewTextBoxColumn
    Friend WithEvents numofRequest As DataGridViewTextBoxColumn
    Friend WithEvents bloodType As DataGridViewTextBoxColumn
    Friend WithEvents requestLname As DataGridViewTextBoxColumn
    Friend WithEvents requestFname As DataGridViewTextBoxColumn
    Friend WithEvents attNurse As DataGridViewTextBoxColumn
    Friend WithEvents btnNBack As Button
    Friend WithEvents btnNSearchRequest As Button
    Friend WithEvents dropNStatus As ComboBox
    Friend WithEvents labelSearchDonor As Label
    Friend WithEvents dropNSearchRequest As ComboBox
    Friend WithEvents btnNEditRequest As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents labelDonorList As Label
    Friend WithEvents labelBIMS4 As Label
    Friend WithEvents labelDinuguan4 As Label
    Friend WithEvents gridNRequestList As DataGridView
    Friend WithEvents txtNSearchRequest As TextBox
    Friend WithEvents labelBType As Label
    Friend WithEvents btnNRequest As Button
    Friend WithEvents btnClearNRequest As Button
End Class
