<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NurseDonorList
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
        Me.btnNSearchDonor = New System.Windows.Forms.Button()
        Me.dropNBType1 = New System.Windows.Forms.ComboBox()
        Me.labelBType = New System.Windows.Forms.Label()
        Me.labelSearchDonor = New System.Windows.Forms.Label()
        Me.dropNSearchDonor = New System.Windows.Forms.ComboBox()
        Me.btnNDonorList = New System.Windows.Forms.Button()
        Me.btnNEditDonor = New System.Windows.Forms.Button()
        Me.labelDonorList = New System.Windows.Forms.Label()
        Me.labelBIMS4 = New System.Windows.Forms.Label()
        Me.labelDinuguan4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.donorLname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.donorFname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.donorId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtNSearchDonor = New System.Windows.Forms.TextBox()
        Me.gridNDonorList = New System.Windows.Forms.DataGridView()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnClearNDonor = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.gridNDonorList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNSearchDonor
        '
        Me.btnNSearchDonor.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNSearchDonor.Location = New System.Drawing.Point(455, 92)
        Me.btnNSearchDonor.Name = "btnNSearchDonor"
        Me.btnNSearchDonor.Size = New System.Drawing.Size(63, 29)
        Me.btnNSearchDonor.TabIndex = 45
        Me.btnNSearchDonor.Text = "Search"
        Me.btnNSearchDonor.UseVisualStyleBackColor = True
        '
        'dropNBType1
        '
        Me.dropNBType1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.dropNBType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropNBType1.FormattingEnabled = True
        Me.dropNBType1.Items.AddRange(New Object() {"A-", "A+", "B-", "B+", "O-", "O+", "AB-", "AB+"})
        Me.dropNBType1.Location = New System.Drawing.Point(600, 102)
        Me.dropNBType1.Name = "dropNBType1"
        Me.dropNBType1.Size = New System.Drawing.Size(154, 23)
        Me.dropNBType1.TabIndex = 44
        '
        'labelBType
        '
        Me.labelBType.AutoSize = True
        Me.labelBType.BackColor = System.Drawing.Color.WhiteSmoke
        Me.labelBType.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelBType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelBType.Location = New System.Drawing.Point(600, 83)
        Me.labelBType.Name = "labelBType"
        Me.labelBType.Size = New System.Drawing.Size(137, 16)
        Me.labelBType.TabIndex = 43
        Me.labelBType.Text = "Filter by Blood Type:"
        '
        'labelSearchDonor
        '
        Me.labelSearchDonor.AutoSize = True
        Me.labelSearchDonor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.labelSearchDonor.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelSearchDonor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelSearchDonor.Location = New System.Drawing.Point(32, 99)
        Me.labelSearchDonor.Name = "labelSearchDonor"
        Me.labelSearchDonor.Size = New System.Drawing.Size(49, 16)
        Me.labelSearchDonor.TabIndex = 42
        Me.labelSearchDonor.Text = "Search:"
        '
        'dropNSearchDonor
        '
        Me.dropNSearchDonor.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.dropNSearchDonor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropNSearchDonor.FormattingEnabled = True
        Me.dropNSearchDonor.Items.AddRange(New Object() {"First Name", "Last Name", "Date Donated"})
        Me.dropNSearchDonor.Location = New System.Drawing.Point(94, 96)
        Me.dropNSearchDonor.Name = "dropNSearchDonor"
        Me.dropNSearchDonor.Size = New System.Drawing.Size(127, 23)
        Me.dropNSearchDonor.TabIndex = 40
        '
        'btnNDonorList
        '
        Me.btnNDonorList.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNDonorList.Location = New System.Drawing.Point(348, 458)
        Me.btnNDonorList.Name = "btnNDonorList"
        Me.btnNDonorList.Size = New System.Drawing.Size(146, 32)
        Me.btnNDonorList.TabIndex = 39
        Me.btnNDonorList.Text = "Load Donors"
        Me.btnNDonorList.UseVisualStyleBackColor = True
        '
        'btnNEditDonor
        '
        Me.btnNEditDonor.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNEditDonor.Location = New System.Drawing.Point(13, 458)
        Me.btnNEditDonor.Name = "btnNEditDonor"
        Me.btnNEditDonor.Size = New System.Drawing.Size(107, 32)
        Me.btnNEditDonor.TabIndex = 37
        Me.btnNEditDonor.Text = "Edit"
        Me.btnNEditDonor.UseVisualStyleBackColor = True
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
        Me.Panel1.TabIndex = 36
        '
        'Column3
        '
        Me.Column3.HeaderText = "Date Donated"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Quantity Donated"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Blood Type"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'donorLname
        '
        Me.donorLname.HeaderText = "Last Name"
        Me.donorLname.Name = "donorLname"
        Me.donorLname.ReadOnly = True
        '
        'donorFname
        '
        Me.donorFname.HeaderText = "First Name"
        Me.donorFname.Name = "donorFname"
        Me.donorFname.ReadOnly = True
        '
        'donorId
        '
        Me.donorId.HeaderText = "Donor ID"
        Me.donorId.Name = "donorId"
        Me.donorId.ReadOnly = True
        '
        'txtNSearchDonor
        '
        Me.txtNSearchDonor.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtNSearchDonor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNSearchDonor.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtNSearchDonor.Location = New System.Drawing.Point(242, 96)
        Me.txtNSearchDonor.Multiline = True
        Me.txtNSearchDonor.Name = "txtNSearchDonor"
        Me.txtNSearchDonor.Size = New System.Drawing.Size(197, 23)
        Me.txtNSearchDonor.TabIndex = 41
        '
        'gridNDonorList
        '
        Me.gridNDonorList.AllowUserToAddRows = False
        Me.gridNDonorList.AllowUserToDeleteRows = False
        Me.gridNDonorList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridNDonorList.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.gridNDonorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridNDonorList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.donorId, Me.donorFname, Me.donorLname, Me.Column1, Me.Column2, Me.Column3})
        Me.gridNDonorList.Location = New System.Drawing.Point(11, 134)
        Me.gridNDonorList.Name = "gridNDonorList"
        Me.gridNDonorList.ReadOnly = True
        Me.gridNDonorList.RowTemplate.Height = 25
        Me.gridNDonorList.Size = New System.Drawing.Size(776, 311)
        Me.gridNDonorList.TabIndex = 35
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBack.Location = New System.Drawing.Point(680, 459)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(107, 32)
        Me.btnBack.TabIndex = 46
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnClearNDonor
        '
        Me.btnClearNDonor.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClearNDonor.Location = New System.Drawing.Point(524, 92)
        Me.btnClearNDonor.Name = "btnClearNDonor"
        Me.btnClearNDonor.Size = New System.Drawing.Size(54, 29)
        Me.btnClearNDonor.TabIndex = 47
        Me.btnClearNDonor.Text = "Clear"
        Me.btnClearNDonor.UseVisualStyleBackColor = True
        '
        'NurseDonorList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 503)
        Me.Controls.Add(Me.btnClearNDonor)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnNSearchDonor)
        Me.Controls.Add(Me.dropNBType1)
        Me.Controls.Add(Me.labelBType)
        Me.Controls.Add(Me.labelSearchDonor)
        Me.Controls.Add(Me.dropNSearchDonor)
        Me.Controls.Add(Me.btnNDonorList)
        Me.Controls.Add(Me.btnNEditDonor)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtNSearchDonor)
        Me.Controls.Add(Me.gridNDonorList)
        Me.Name = "NurseDonorList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Donor List"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.gridNDonorList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNSearchDonor As Button
    Friend WithEvents dropNBType1 As ComboBox
    Friend WithEvents labelBType As Label
    Friend WithEvents labelSearchDonor As Label
    Friend WithEvents dropNSearchDonor As ComboBox
    Friend WithEvents btnNDonorList As Button
    Friend WithEvents btnNEditDonor As Button
    Friend WithEvents labelDonorList As Label
    Friend WithEvents labelBIMS4 As Label
    Friend WithEvents labelDinuguan4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents donorLname As DataGridViewTextBoxColumn
    Friend WithEvents donorFname As DataGridViewTextBoxColumn
    Friend WithEvents donorId As DataGridViewTextBoxColumn
    Friend WithEvents txtNSearchDonor As TextBox
    Friend WithEvents gridNDonorList As DataGridView
    Friend WithEvents btnBack As Button
    Friend WithEvents btnClearNDonor As Button
End Class
