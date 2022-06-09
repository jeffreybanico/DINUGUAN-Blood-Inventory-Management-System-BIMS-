<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.labelUsername = New System.Windows.Forms.Label()
        Me.labelPass = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.labelDinuguan = New System.Windows.Forms.Label()
        Me.labelBIMS = New System.Windows.Forms.Label()
        Me.labelForgot = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'labelUsername
        '
        Me.labelUsername.AutoSize = True
        Me.labelUsername.BackColor = System.Drawing.Color.Transparent
        Me.labelUsername.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelUsername.ForeColor = System.Drawing.SystemColors.Control
        Me.labelUsername.Location = New System.Drawing.Point(135, 187)
        Me.labelUsername.Name = "labelUsername"
        Me.labelUsername.Size = New System.Drawing.Size(69, 16)
        Me.labelUsername.TabIndex = 0
        Me.labelUsername.Text = "Username:"
        '
        'labelPass
        '
        Me.labelPass.AutoSize = True
        Me.labelPass.BackColor = System.Drawing.Color.Transparent
        Me.labelPass.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelPass.ForeColor = System.Drawing.SystemColors.Control
        Me.labelPass.Location = New System.Drawing.Point(135, 242)
        Me.labelPass.Name = "labelPass"
        Me.labelPass.Size = New System.Drawing.Size(67, 16)
        Me.labelPass.TabIndex = 1
        Me.labelPass.Text = "Password:"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(239, 184)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(173, 23)
        Me.txtUsername.TabIndex = 2
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(239, 239)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.Size = New System.Drawing.Size(173, 23)
        Me.txtPassword.TabIndex = 3
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnLogin.Location = New System.Drawing.Point(185, 320)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(85, 28)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'labelDinuguan
        '
        Me.labelDinuguan.AutoSize = True
        Me.labelDinuguan.BackColor = System.Drawing.Color.Transparent
        Me.labelDinuguan.Font = New System.Drawing.Font("Imprint MT Shadow", 37.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelDinuguan.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.labelDinuguan.Location = New System.Drawing.Point(111, 57)
        Me.labelDinuguan.Name = "labelDinuguan"
        Me.labelDinuguan.Size = New System.Drawing.Size(334, 58)
        Me.labelDinuguan.TabIndex = 5
        Me.labelDinuguan.Text = "DINUGUAN"
        '
        'labelBIMS
        '
        Me.labelBIMS.AutoSize = True
        Me.labelBIMS.BackColor = System.Drawing.Color.Transparent
        Me.labelBIMS.Font = New System.Drawing.Font("Imprint MT Shadow", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelBIMS.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.labelBIMS.Location = New System.Drawing.Point(111, 115)
        Me.labelBIMS.Name = "labelBIMS"
        Me.labelBIMS.Size = New System.Drawing.Size(331, 16)
        Me.labelBIMS.TabIndex = 6
        Me.labelBIMS.Text = "BLOOD INVENTORY MANAGEMENT SYSTEM"
        '
        'labelForgot
        '
        Me.labelForgot.AutoSize = True
        Me.labelForgot.BackColor = System.Drawing.Color.Transparent
        Me.labelForgot.Cursor = System.Windows.Forms.Cursors.Hand
        Me.labelForgot.Font = New System.Drawing.Font("Imprint MT Shadow", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.labelForgot.ForeColor = System.Drawing.SystemColors.Control
        Me.labelForgot.Location = New System.Drawing.Point(313, 265)
        Me.labelForgot.Name = "labelForgot"
        Me.labelForgot.Size = New System.Drawing.Size(99, 14)
        Me.labelForgot.TabIndex = 8
        Me.labelForgot.Text = "Forgot Password?"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Imprint MT Shadow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCancel.Location = New System.Drawing.Point(276, 320)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 28)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(550, 408)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.labelForgot)
        Me.Controls.Add(Me.labelBIMS)
        Me.Controls.Add(Me.labelDinuguan)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.labelPass)
        Me.Controls.Add(Me.labelUsername)
        Me.DoubleBuffered = True
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelUsername As Label
    Friend WithEvents labelPass As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents labelDinuguan As Label
    Friend WithEvents labelBIMS As Label
    Friend WithEvents labelForgot As Label
    Friend WithEvents btnCancel As Button
End Class
