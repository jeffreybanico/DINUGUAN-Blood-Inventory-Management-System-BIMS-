<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserList
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
        Me.gridUserList = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dropSearch = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.labelDinuguan4 = New System.Windows.Forms.Label()
        Me.labelBIMS4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dropUserType1 = New System.Windows.Forms.ComboBox()
        Me.btnEdit1 = New System.Windows.Forms.Button()
        Me.btnBack1 = New System.Windows.Forms.Button()
        Me.labelUserList = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLoadUsers = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnClearUser = New System.Windows.Forms.Button()
        CType(Me.gridUserList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridUserList
        '
        Me.gridUserList.AllowUserToAddRows = False
        Me.gridUserList.AllowUserToDeleteRows = False
        Me.gridUserList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridUserList.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.gridUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridUserList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.gridUserList.Location = New System.Drawing.Point(13, 132)
        Me.gridUserList.Name = "gridUserList"
        Me.gridUserList.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridUserList.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.gridUserList.RowTemplate.Height = 25
        Me.gridUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.gridUserList.Size = New System.Drawing.Size(776, 306)
        Me.gridUserList.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Username"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Last Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "First Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "User Type"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Phone Number"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Email Address"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'dropSearch
        '
        Me.dropSearch.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.dropSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropSearch.FormattingEnabled = True
        Me.dropSearch.Items.AddRange(New Object() {"All", "Last Name", "First Name", "Email Address"})
        Me.dropSearch.Location = New System.Drawing.Point(90, 94)
        Me.dropSearch.Name = "dropSearch"
        Me.dropSearch.Size = New System.Drawing.Size(131, 23)
        Me.dropSearch.TabIndex = 2
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Imprint MT Shadow", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txtSearch.Location = New System.Drawing.Point(239, 94)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(197, 23)
        Me.txtSearch.TabIndex = 5
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(28, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Search:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(599, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Filter by User Type:"
        '
        'dropUserType1
        '
        Me.dropUserType1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.dropUserType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropUserType1.FormattingEnabled = True
        Me.dropUserType1.Items.AddRange(New Object() {"All", "Admin", "Nurse"})
        Me.dropUserType1.Location = New System.Drawing.Point(599, 100)
        Me.dropUserType1.Name = "dropUserType1"
        Me.dropUserType1.Size = New System.Drawing.Size(153, 23)
        Me.dropUserType1.TabIndex = 10
        '
        'btnEdit1
        '
        Me.btnEdit1.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEdit1.Location = New System.Drawing.Point(12, 459)
        Me.btnEdit1.Name = "btnEdit1"
        Me.btnEdit1.Size = New System.Drawing.Size(107, 32)
        Me.btnEdit1.TabIndex = 11
        Me.btnEdit1.Text = "Edit"
        Me.btnEdit1.UseVisualStyleBackColor = True
        '
        'btnBack1
        '
        Me.btnBack1.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBack1.Location = New System.Drawing.Point(682, 459)
        Me.btnBack1.Name = "btnBack1"
        Me.btnBack1.Size = New System.Drawing.Size(107, 32)
        Me.btnBack1.TabIndex = 14
        Me.btnBack1.Text = "Back"
        Me.btnBack1.UseVisualStyleBackColor = True
        '
        'labelUserList
        '
        Me.labelUserList.AutoSize = True
        Me.labelUserList.BackColor = System.Drawing.Color.Firebrick
        Me.labelUserList.Font = New System.Drawing.Font("Imprint MT Shadow", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelUserList.ForeColor = System.Drawing.Color.Transparent
        Me.labelUserList.Location = New System.Drawing.Point(613, 15)
        Me.labelUserList.Name = "labelUserList"
        Me.labelUserList.Size = New System.Drawing.Size(161, 40)
        Me.labelUserList.TabIndex = 15
        Me.labelUserList.Text = "User List"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Firebrick
        Me.Panel1.Controls.Add(Me.labelUserList)
        Me.Panel1.Controls.Add(Me.labelBIMS4)
        Me.Panel1.Controls.Add(Me.labelDinuguan4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 72)
        Me.Panel1.TabIndex = 16
        '
        'btnLoadUsers
        '
        Me.btnLoadUsers.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLoadUsers.Location = New System.Drawing.Point(347, 459)
        Me.btnLoadUsers.Name = "btnLoadUsers"
        Me.btnLoadUsers.Size = New System.Drawing.Size(146, 32)
        Me.btnLoadUsers.TabIndex = 17
        Me.btnLoadUsers.Text = "Load Users"
        Me.btnLoadUsers.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSearch.Location = New System.Drawing.Point(452, 90)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(66, 29)
        Me.btnSearch.TabIndex = 18
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnClearUser
        '
        Me.btnClearUser.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClearUser.Location = New System.Drawing.Point(524, 90)
        Me.btnClearUser.Name = "btnClearUser"
        Me.btnClearUser.Size = New System.Drawing.Size(54, 29)
        Me.btnClearUser.TabIndex = 19
        Me.btnClearUser.Text = "Clear"
        Me.btnClearUser.UseVisualStyleBackColor = True
        '
        'UserList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 503)
        Me.Controls.Add(Me.btnClearUser)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnLoadUsers)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnBack1)
        Me.Controls.Add(Me.btnEdit1)
        Me.Controls.Add(Me.dropUserType1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dropSearch)
        Me.Controls.Add(Me.gridUserList)
        Me.DoubleBuffered = True
        Me.Name = "UserList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User List"
        CType(Me.gridUserList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gridUserList As DataGridView
    Friend WithEvents dropSearch As ComboBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents labelDinuguan4 As Label
    Friend WithEvents labelBIMS4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dropUserType1 As ComboBox
    Friend WithEvents btnEdit1 As Button
    Friend WithEvents btnBack1 As Button
    Friend WithEvents labelUserList As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents btnLoadUsers As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnClearUser As Button
End Class
