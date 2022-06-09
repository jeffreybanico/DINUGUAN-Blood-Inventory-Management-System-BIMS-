<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDonorList
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
        Me.gridDonorList = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.labelDonorList = New System.Windows.Forms.Label()
        Me.labelBIMS4 = New System.Windows.Forms.Label()
        Me.labelDinuguan4 = New System.Windows.Forms.Label()
        Me.btnDonorList = New System.Windows.Forms.Button()
        Me.btnBackDonor = New System.Windows.Forms.Button()
        Me.btnEditDonor = New System.Windows.Forms.Button()
        Me.btnSearchDonor = New System.Windows.Forms.Button()
        Me.dropBType1 = New System.Windows.Forms.ComboBox()
        Me.labelBType = New System.Windows.Forms.Label()
        Me.labelSearchDonor = New System.Windows.Forms.Label()
        Me.txtSearchDonor = New System.Windows.Forms.TextBox()
        Me.dropSearchDonor = New System.Windows.Forms.ComboBox()
        Me.btnClearADonor = New System.Windows.Forms.Button()
        Me.btnExportDonor = New System.Windows.Forms.Button()
        Me.donorId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.donorFname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.donorLname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.donorBloodType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.donorQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.donorDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.gridDonorList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridDonorList
        '
        Me.gridDonorList.AllowUserToAddRows = False
        Me.gridDonorList.AllowUserToDeleteRows = False
        Me.gridDonorList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridDonorList.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.gridDonorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridDonorList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.donorId, Me.donorFname, Me.donorLname, Me.donorBloodType, Me.donorQty, Me.donorDate})
        Me.gridDonorList.Location = New System.Drawing.Point(12, 135)
        Me.gridDonorList.Name = "gridDonorList"
        Me.gridDonorList.ReadOnly = True
        Me.gridDonorList.RowTemplate.Height = 25
        Me.gridDonorList.Size = New System.Drawing.Size(776, 311)
        Me.gridDonorList.TabIndex = 4
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
        Me.Panel1.TabIndex = 24
        '
        'labelDonorList
        '
        Me.labelDonorList.AutoSize = True
        Me.labelDonorList.BackColor = System.Drawing.Color.Firebrick
        Me.labelDonorList.Font = New System.Drawing.Font("Imprint MT Shadow", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelDonorList.ForeColor = System.Drawing.Color.Transparent
        Me.labelDonorList.Location = New System.Drawing.Point(600, 15)
        Me.labelDonorList.Name = "labelDonorList"
        Me.labelDonorList.Size = New System.Drawing.Size(188, 40)
        Me.labelDonorList.TabIndex = 15
        Me.labelDonorList.Text = "Donor List"
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
        'btnDonorList
        '
        Me.btnDonorList.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDonorList.Location = New System.Drawing.Point(404, 459)
        Me.btnDonorList.Name = "btnDonorList"
        Me.btnDonorList.Size = New System.Drawing.Size(116, 32)
        Me.btnDonorList.TabIndex = 28
        Me.btnDonorList.Text = "Load Donors"
        Me.btnDonorList.UseVisualStyleBackColor = True
        '
        'btnBackDonor
        '
        Me.btnBackDonor.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBackDonor.Location = New System.Drawing.Point(684, 459)
        Me.btnBackDonor.Name = "btnBackDonor"
        Me.btnBackDonor.Size = New System.Drawing.Size(107, 32)
        Me.btnBackDonor.TabIndex = 27
        Me.btnBackDonor.Text = "Back"
        Me.btnBackDonor.UseVisualStyleBackColor = True
        '
        'btnEditDonor
        '
        Me.btnEditDonor.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEditDonor.Location = New System.Drawing.Point(14, 459)
        Me.btnEditDonor.Name = "btnEditDonor"
        Me.btnEditDonor.Size = New System.Drawing.Size(107, 32)
        Me.btnEditDonor.TabIndex = 26
        Me.btnEditDonor.Text = "Edit"
        Me.btnEditDonor.UseVisualStyleBackColor = True
        '
        'btnSearchDonor
        '
        Me.btnSearchDonor.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSearchDonor.Location = New System.Drawing.Point(450, 93)
        Me.btnSearchDonor.Name = "btnSearchDonor"
        Me.btnSearchDonor.Size = New System.Drawing.Size(70, 29)
        Me.btnSearchDonor.TabIndex = 34
        Me.btnSearchDonor.Text = "Search"
        Me.btnSearchDonor.UseVisualStyleBackColor = True
        '
        'dropBType1
        '
        Me.dropBType1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.dropBType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropBType1.FormattingEnabled = True
        Me.dropBType1.Items.AddRange(New Object() {"All", "A-", "A+", "B-", "B+", "O-", "O+", "AB-", "AB+"})
        Me.dropBType1.Location = New System.Drawing.Point(600, 100)
        Me.dropBType1.Name = "dropBType1"
        Me.dropBType1.Size = New System.Drawing.Size(159, 23)
        Me.dropBType1.TabIndex = 33
        '
        'labelBType
        '
        Me.labelBType.AutoSize = True
        Me.labelBType.BackColor = System.Drawing.Color.WhiteSmoke
        Me.labelBType.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelBType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelBType.Location = New System.Drawing.Point(600, 81)
        Me.labelBType.Name = "labelBType"
        Me.labelBType.Size = New System.Drawing.Size(137, 16)
        Me.labelBType.TabIndex = 32
        Me.labelBType.Text = "Filter by Blood Type:"
        '
        'labelSearchDonor
        '
        Me.labelSearchDonor.AutoSize = True
        Me.labelSearchDonor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.labelSearchDonor.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelSearchDonor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelSearchDonor.Location = New System.Drawing.Point(33, 100)
        Me.labelSearchDonor.Name = "labelSearchDonor"
        Me.labelSearchDonor.Size = New System.Drawing.Size(49, 16)
        Me.labelSearchDonor.TabIndex = 31
        Me.labelSearchDonor.Text = "Search:"
        '
        'txtSearchDonor
        '
        Me.txtSearchDonor.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtSearchDonor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearchDonor.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtSearchDonor.Location = New System.Drawing.Point(238, 97)
        Me.txtSearchDonor.Multiline = True
        Me.txtSearchDonor.Name = "txtSearchDonor"
        Me.txtSearchDonor.Size = New System.Drawing.Size(197, 23)
        Me.txtSearchDonor.TabIndex = 30
        '
        'dropSearchDonor
        '
        Me.dropSearchDonor.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.dropSearchDonor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropSearchDonor.FormattingEnabled = True
        Me.dropSearchDonor.Items.AddRange(New Object() {"All", "First Name", "Last Name", "Date Donated"})
        Me.dropSearchDonor.Location = New System.Drawing.Point(95, 97)
        Me.dropSearchDonor.Name = "dropSearchDonor"
        Me.dropSearchDonor.Size = New System.Drawing.Size(126, 23)
        Me.dropSearchDonor.TabIndex = 29
        '
        'btnClearADonor
        '
        Me.btnClearADonor.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClearADonor.Location = New System.Drawing.Point(526, 93)
        Me.btnClearADonor.Name = "btnClearADonor"
        Me.btnClearADonor.Size = New System.Drawing.Size(54, 29)
        Me.btnClearADonor.TabIndex = 35
        Me.btnClearADonor.Text = "Clear"
        Me.btnClearADonor.UseVisualStyleBackColor = True
        '
        'btnExportDonor
        '
        Me.btnExportDonor.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnExportDonor.Location = New System.Drawing.Point(282, 459)
        Me.btnExportDonor.Name = "btnExportDonor"
        Me.btnExportDonor.Size = New System.Drawing.Size(116, 32)
        Me.btnExportDonor.TabIndex = 36
        Me.btnExportDonor.Text = "Export"
        Me.btnExportDonor.UseVisualStyleBackColor = True
        '
        'donorId
        '
        Me.donorId.HeaderText = "Donor ID"
        Me.donorId.Name = "donorId"
        Me.donorId.ReadOnly = True
        '
        'donorFname
        '
        Me.donorFname.HeaderText = "First Name"
        Me.donorFname.Name = "donorFname"
        Me.donorFname.ReadOnly = True
        '
        'donorLname
        '
        Me.donorLname.HeaderText = "Last Name"
        Me.donorLname.Name = "donorLname"
        Me.donorLname.ReadOnly = True
        '
        'donorBloodType
        '
        Me.donorBloodType.HeaderText = "Blood Type"
        Me.donorBloodType.Name = "donorBloodType"
        Me.donorBloodType.ReadOnly = True
        '
        'donorQty
        '
        Me.donorQty.HeaderText = "Quantity Donated"
        Me.donorQty.Name = "donorQty"
        Me.donorQty.ReadOnly = True
        '
        'donorDate
        '
        Me.donorDate.HeaderText = "Date Donated"
        Me.donorDate.Name = "donorDate"
        Me.donorDate.ReadOnly = True
        '
        'AdminDonorList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(800, 503)
        Me.Controls.Add(Me.btnExportDonor)
        Me.Controls.Add(Me.btnClearADonor)
        Me.Controls.Add(Me.btnSearchDonor)
        Me.Controls.Add(Me.dropBType1)
        Me.Controls.Add(Me.labelBType)
        Me.Controls.Add(Me.labelSearchDonor)
        Me.Controls.Add(Me.txtSearchDonor)
        Me.Controls.Add(Me.dropSearchDonor)
        Me.Controls.Add(Me.btnDonorList)
        Me.Controls.Add(Me.btnBackDonor)
        Me.Controls.Add(Me.btnEditDonor)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gridDonorList)
        Me.Name = "AdminDonorList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Donor List"
        CType(Me.gridDonorList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gridDonorList As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents labelDonorList As Label
    Friend WithEvents labelBIMS4 As Label
    Friend WithEvents labelDinuguan4 As Label
    Friend WithEvents btnDonorList As Button
    Friend WithEvents btnBackDonor As Button
    Friend WithEvents btnEditDonor As Button
    Friend WithEvents btnSearchDonor As Button
    Friend WithEvents dropBType1 As ComboBox
    Friend WithEvents labelBType As Label
    Friend WithEvents labelSearchDonor As Label
    Friend WithEvents txtSearchDonor As TextBox
    Friend WithEvents dropSearchDonor As ComboBox
    Friend WithEvents btnClearADonor As Button
    Friend WithEvents btnExportDonor As Button
    Friend WithEvents donorId As DataGridViewTextBoxColumn
    Friend WithEvents donorFname As DataGridViewTextBoxColumn
    Friend WithEvents donorLname As DataGridViewTextBoxColumn
    Friend WithEvents donorBloodType As DataGridViewTextBoxColumn
    Friend WithEvents donorQty As DataGridViewTextBoxColumn
    Friend WithEvents donorDate As DataGridViewTextBoxColumn
End Class
