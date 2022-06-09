<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminBloodInventory
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gridBloodInventory = New System.Windows.Forms.DataGridView()
        Me.inventoryNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BloodType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.labelDonorInfo = New System.Windows.Forms.Label()
        Me.labelBIMS5 = New System.Windows.Forms.Label()
        Me.labelDinuguan5 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.gridBloodInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridBloodInventory
        '
        Me.gridBloodInventory.AllowUserToAddRows = False
        Me.gridBloodInventory.AllowUserToDeleteRows = False
        Me.gridBloodInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridBloodInventory.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.gridBloodInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridBloodInventory.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.inventoryNo, Me.BloodType, Me.stock})
        Me.gridBloodInventory.Location = New System.Drawing.Point(73, 100)
        Me.gridBloodInventory.Name = "gridBloodInventory"
        Me.gridBloodInventory.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridBloodInventory.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gridBloodInventory.RowTemplate.Height = 25
        Me.gridBloodInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.gridBloodInventory.Size = New System.Drawing.Size(374, 224)
        Me.gridBloodInventory.TabIndex = 56
        '
        'inventoryNo
        '
        Me.inventoryNo.HeaderText = "Inventory No."
        Me.inventoryNo.Name = "inventoryNo"
        Me.inventoryNo.ReadOnly = True
        '
        'BloodType
        '
        Me.BloodType.HeaderText = "Blood Type"
        Me.BloodType.Name = "BloodType"
        Me.BloodType.ReadOnly = True
        '
        'stock
        '
        Me.stock.HeaderText = "Stock"
        Me.stock.Name = "stock"
        Me.stock.ReadOnly = True
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
        Me.Panel1.Size = New System.Drawing.Size(735, 72)
        Me.Panel1.TabIndex = 57
        '
        'labelDonorInfo
        '
        Me.labelDonorInfo.AutoSize = True
        Me.labelDonorInfo.BackColor = System.Drawing.Color.Firebrick
        Me.labelDonorInfo.Font = New System.Drawing.Font("Imprint MT Shadow", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelDonorInfo.ForeColor = System.Drawing.Color.Transparent
        Me.labelDonorInfo.Location = New System.Drawing.Point(268, 15)
        Me.labelDonorInfo.Name = "labelDonorInfo"
        Me.labelDonorInfo.Size = New System.Drawing.Size(464, 40)
        Me.labelDonorInfo.TabIndex = 15
        Me.labelDonorInfo.Text = "Blood Inventory Information"
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
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRefresh.Location = New System.Drawing.Point(495, 129)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(159, 43)
        Me.btnRefresh.TabIndex = 58
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnExport.Location = New System.Drawing.Point(495, 193)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(159, 43)
        Me.btnExport.TabIndex = 59
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBack.Location = New System.Drawing.Point(495, 257)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(159, 43)
        Me.btnBack.TabIndex = 60
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'AdminBloodInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 353)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gridBloodInventory)
        Me.Name = "AdminBloodInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Blood Inventory Information"
        CType(Me.gridBloodInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gridBloodInventory As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents labelDonorInfo As Label
    Friend WithEvents labelBIMS5 As Label
    Friend WithEvents labelDinuguan5 As Label
    Friend WithEvents inventoryNo As DataGridViewTextBoxColumn
    Friend WithEvents BloodType As DataGridViewTextBoxColumn
    Friend WithEvents stock As DataGridViewTextBoxColumn
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents btnBack As Button
End Class
