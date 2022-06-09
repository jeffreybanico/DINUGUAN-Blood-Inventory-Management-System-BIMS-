<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserInformation
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.labelAddInfo1 = New System.Windows.Forms.Label()
        Me.labelBIMS5 = New System.Windows.Forms.Label()
        Me.labelDinuguan5 = New System.Windows.Forms.Label()
        Me.btnUpdate2 = New System.Windows.Forms.Button()
        Me.btnAdd2 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.labelUserID3 = New System.Windows.Forms.Label()
        Me.labelUserID2 = New System.Windows.Forms.Label()
        Me.txtEmailAdd1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPhoneNum1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtLastName1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFirstName1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.labelUserInfo1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtRecPass2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dropUserType2 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPassword2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtUsername2 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.labelAccInfo1 = New System.Windows.Forms.Label()
        Me.gridUserList2 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnLoadUsers2 = New System.Windows.Forms.Button()
        Me.btnExit3 = New System.Windows.Forms.Button()
        Me.btnBack1 = New System.Windows.Forms.Button()
        Me.btnClearAUserInfo = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.gridUserList2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Firebrick
        Me.Panel1.Controls.Add(Me.labelAddInfo1)
        Me.Panel1.Controls.Add(Me.labelBIMS5)
        Me.Panel1.Controls.Add(Me.labelDinuguan5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 72)
        Me.Panel1.TabIndex = 27
        '
        'labelAddInfo1
        '
        Me.labelAddInfo1.AutoSize = True
        Me.labelAddInfo1.BackColor = System.Drawing.Color.Firebrick
        Me.labelAddInfo1.Font = New System.Drawing.Font("Imprint MT Shadow", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelAddInfo1.ForeColor = System.Drawing.Color.Transparent
        Me.labelAddInfo1.Location = New System.Drawing.Point(492, 15)
        Me.labelAddInfo1.Name = "labelAddInfo1"
        Me.labelAddInfo1.Size = New System.Drawing.Size(285, 40)
        Me.labelAddInfo1.TabIndex = 15
        Me.labelAddInfo1.Text = "User Information"
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
        'btnUpdate2
        '
        Me.btnUpdate2.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnUpdate2.Location = New System.Drawing.Point(147, 379)
        Me.btnUpdate2.Name = "btnUpdate2"
        Me.btnUpdate2.Size = New System.Drawing.Size(107, 32)
        Me.btnUpdate2.TabIndex = 26
        Me.btnUpdate2.Text = "Update"
        Me.btnUpdate2.UseVisualStyleBackColor = True
        '
        'btnAdd2
        '
        Me.btnAdd2.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAdd2.Location = New System.Drawing.Point(21, 379)
        Me.btnAdd2.Name = "btnAdd2"
        Me.btnAdd2.Size = New System.Drawing.Size(107, 32)
        Me.btnAdd2.TabIndex = 23
        Me.btnAdd2.Text = "Add"
        Me.btnAdd2.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Firebrick
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(18, 113)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(379, 251)
        Me.Panel2.TabIndex = 28
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.labelUserID3)
        Me.Panel3.Controls.Add(Me.labelUserID2)
        Me.Panel3.Controls.Add(Me.txtEmailAdd1)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.txtPhoneNum1)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.txtLastName1)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.txtFirstName1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(372, 245)
        Me.Panel3.TabIndex = 29
        '
        'labelUserID3
        '
        Me.labelUserID3.AutoSize = True
        Me.labelUserID3.BackColor = System.Drawing.Color.Transparent
        Me.labelUserID3.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelUserID3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelUserID3.Location = New System.Drawing.Point(39, 26)
        Me.labelUserID3.Name = "labelUserID3"
        Me.labelUserID3.Size = New System.Drawing.Size(63, 16)
        Me.labelUserID3.TabIndex = 12
        Me.labelUserID3.Text = "User ID: "
        '
        'labelUserID2
        '
        Me.labelUserID2.AutoSize = True
        Me.labelUserID2.BackColor = System.Drawing.Color.Transparent
        Me.labelUserID2.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelUserID2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelUserID2.Location = New System.Drawing.Point(158, 26)
        Me.labelUserID2.Name = "labelUserID2"
        Me.labelUserID2.Size = New System.Drawing.Size(31, 16)
        Me.labelUserID2.TabIndex = 11
        Me.labelUserID2.Text = "      "
        '
        'txtEmailAdd1
        '
        Me.txtEmailAdd1.Location = New System.Drawing.Point(162, 201)
        Me.txtEmailAdd1.Name = "txtEmailAdd1"
        Me.txtEmailAdd1.Size = New System.Drawing.Size(173, 23)
        Me.txtEmailAdd1.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(39, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "E-mail Address:"
        '
        'txtPhoneNum1
        '
        Me.txtPhoneNum1.Location = New System.Drawing.Point(162, 156)
        Me.txtPhoneNum1.Name = "txtPhoneNum1"
        Me.txtPhoneNum1.Size = New System.Drawing.Size(173, 23)
        Me.txtPhoneNum1.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(39, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Phone Number:"
        '
        'txtLastName1
        '
        Me.txtLastName1.Location = New System.Drawing.Point(162, 110)
        Me.txtLastName1.Name = "txtLastName1"
        Me.txtLastName1.Size = New System.Drawing.Size(173, 23)
        Me.txtLastName1.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(39, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Last Name:"
        '
        'txtFirstName1
        '
        Me.txtFirstName1.Location = New System.Drawing.Point(162, 65)
        Me.txtFirstName1.Name = "txtFirstName1"
        Me.txtFirstName1.Size = New System.Drawing.Size(173, 23)
        Me.txtFirstName1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(39, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "First Name:"
        '
        'labelUserInfo1
        '
        Me.labelUserInfo1.AutoSize = True
        Me.labelUserInfo1.BackColor = System.Drawing.Color.Transparent
        Me.labelUserInfo1.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelUserInfo1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelUserInfo1.Location = New System.Drawing.Point(36, 103)
        Me.labelUserInfo1.Name = "labelUserInfo1"
        Me.labelUserInfo1.Size = New System.Drawing.Size(110, 16)
        Me.labelUserInfo1.TabIndex = 29
        Me.labelUserInfo1.Text = "User Information"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Controls.Add(Me.txtRecPass2)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.dropUserType2)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.txtPassword2)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.txtUsername2)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(362, 245)
        Me.Panel4.TabIndex = 29
        '
        'txtRecPass2
        '
        Me.txtRecPass2.Location = New System.Drawing.Point(178, 131)
        Me.txtRecPass2.Name = "txtRecPass2"
        Me.txtRecPass2.Size = New System.Drawing.Size(152, 23)
        Me.txtRecPass2.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(34, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 16)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Recovery Password:"
        '
        'dropUserType2
        '
        Me.dropUserType2.BackColor = System.Drawing.SystemColors.ControlText
        Me.dropUserType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dropUserType2.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.dropUserType2.FormattingEnabled = True
        Me.dropUserType2.Items.AddRange(New Object() {"Admin", "Nurse"})
        Me.dropUserType2.Location = New System.Drawing.Point(178, 176)
        Me.dropUserType2.Name = "dropUserType2"
        Me.dropUserType2.Size = New System.Drawing.Size(152, 23)
        Me.dropUserType2.TabIndex = 32
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(34, 176)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 16)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "User Type:"
        '
        'txtPassword2
        '
        Me.txtPassword2.Location = New System.Drawing.Point(178, 89)
        Me.txtPassword2.Name = "txtPassword2"
        Me.txtPassword2.Size = New System.Drawing.Size(152, 23)
        Me.txtPassword2.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(34, 92)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 16)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Password:"
        '
        'txtUsername2
        '
        Me.txtUsername2.Location = New System.Drawing.Point(178, 44)
        Me.txtUsername2.Name = "txtUsername2"
        Me.txtUsername2.Size = New System.Drawing.Size(152, 23)
        Me.txtUsername2.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(34, 47)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 16)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Username:"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Firebrick
        Me.Panel5.Controls.Add(Me.Panel4)
        Me.Panel5.Location = New System.Drawing.Point(409, 113)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(368, 251)
        Me.Panel5.TabIndex = 30
        '
        'labelAccInfo1
        '
        Me.labelAccInfo1.AutoSize = True
        Me.labelAccInfo1.BackColor = System.Drawing.Color.Transparent
        Me.labelAccInfo1.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelAccInfo1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelAccInfo1.Location = New System.Drawing.Point(427, 103)
        Me.labelAccInfo1.Name = "labelAccInfo1"
        Me.labelAccInfo1.Size = New System.Drawing.Size(133, 16)
        Me.labelAccInfo1.TabIndex = 31
        Me.labelAccInfo1.Text = "Account Information"
        '
        'gridUserList2
        '
        Me.gridUserList2.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.gridUserList2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridUserList2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.gridUserList2.Location = New System.Drawing.Point(21, 431)
        Me.gridUserList2.Name = "gridUserList2"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridUserList2.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gridUserList2.RowTemplate.Height = 25
        Me.gridUserList2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.gridUserList2.Size = New System.Drawing.Size(756, 185)
        Me.gridUserList2.TabIndex = 32
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "iduser"
        Me.Column1.HeaderText = "User ID"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 79
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "u_fname"
        Me.Column2.HeaderText = "First Name"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 79
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "u_lname"
        Me.Column3.HeaderText = "Last Name"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 80
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "u_phone_no"
        Me.Column4.HeaderText = "Phone Number"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 79
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "u_email_add"
        Me.Column5.HeaderText = "Email Address"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 79
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "u_username"
        Me.Column6.HeaderText = "Username"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 79
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "u_password"
        Me.Column7.HeaderText = "Password"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 80
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "u_pass_recovery"
        Me.Column8.HeaderText = "Password Recovery"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 79
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "u_type"
        Me.Column9.HeaderText = "User Type"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 79
        '
        'btnLoadUsers2
        '
        Me.btnLoadUsers2.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLoadUsers2.Location = New System.Drawing.Point(623, 379)
        Me.btnLoadUsers2.Name = "btnLoadUsers2"
        Me.btnLoadUsers2.Size = New System.Drawing.Size(151, 32)
        Me.btnLoadUsers2.TabIndex = 33
        Me.btnLoadUsers2.Text = "Load Users"
        Me.btnLoadUsers2.UseVisualStyleBackColor = True
        '
        'btnExit3
        '
        Me.btnExit3.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnExit3.Location = New System.Drawing.Point(670, 631)
        Me.btnExit3.Name = "btnExit3"
        Me.btnExit3.Size = New System.Drawing.Size(107, 32)
        Me.btnExit3.TabIndex = 36
        Me.btnExit3.Text = "Exit"
        Me.btnExit3.UseVisualStyleBackColor = True
        '
        'btnBack1
        '
        Me.btnBack1.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBack1.Location = New System.Drawing.Point(544, 631)
        Me.btnBack1.Name = "btnBack1"
        Me.btnBack1.Size = New System.Drawing.Size(107, 32)
        Me.btnBack1.TabIndex = 35
        Me.btnBack1.Text = "Back"
        Me.btnBack1.UseVisualStyleBackColor = True
        '
        'btnClearAUserInfo
        '
        Me.btnClearAUserInfo.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClearAUserInfo.Location = New System.Drawing.Point(492, 379)
        Me.btnClearAUserInfo.Name = "btnClearAUserInfo"
        Me.btnClearAUserInfo.Size = New System.Drawing.Size(107, 32)
        Me.btnClearAUserInfo.TabIndex = 62
        Me.btnClearAUserInfo.Text = "Clear"
        Me.btnClearAUserInfo.UseVisualStyleBackColor = True
        '
        'UserInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(800, 675)
        Me.Controls.Add(Me.btnClearAUserInfo)
        Me.Controls.Add(Me.btnExit3)
        Me.Controls.Add(Me.btnBack1)
        Me.Controls.Add(Me.btnLoadUsers2)
        Me.Controls.Add(Me.gridUserList2)
        Me.Controls.Add(Me.labelAccInfo1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.labelUserInfo1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnUpdate2)
        Me.Controls.Add(Me.btnAdd2)
        Me.Name = "UserInformation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Information"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.gridUserList2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents labelAddInfo1 As Label
    Friend WithEvents labelBIMS5 As Label
    Friend WithEvents labelDinuguan5 As Label
    Friend WithEvents btnUpdate2 As Button
    Friend WithEvents btnAdd2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents labelUserInfo1 As Label
    Friend WithEvents txtEmailAdd1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPhoneNum1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtLastName1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtFirstName1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPassword2 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtUsername2 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents labelAccInfo1 As Label
    Friend WithEvents dropUserType2 As ComboBox
    Friend WithEvents txtRecPass2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents gridUserList2 As DataGridView
    Friend WithEvents btnLoadUsers2 As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents btnExit3 As Button
    Friend WithEvents btnBack1 As Button
    Friend WithEvents labelUserID2 As Label
    Friend WithEvents labelUserID3 As Label
    Friend WithEvents btnClearAUserInfo As Button
End Class
