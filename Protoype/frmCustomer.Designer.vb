<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
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
        Me.lblCustomerSignUp = New System.Windows.Forms.Label()
        Me.btnCustomerSignUp = New System.Windows.Forms.Button()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.lblCustomerEmail = New System.Windows.Forms.Label()
        Me.lblCustomerPhone = New System.Windows.Forms.Label()
        Me.lblCustomerAdress = New System.Windows.Forms.Label()
        Me.lblCustomerPassword = New System.Windows.Forms.Label()
        Me.txtCustomerPassword = New System.Windows.Forms.TextBox()
        Me.txtCustomerAddress = New System.Windows.Forms.TextBox()
        Me.txtCustomerPhone = New System.Windows.Forms.TextBox()
        Me.txtCustomerEmail = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblCustomerSignUp
        '
        Me.lblCustomerSignUp.AutoSize = True
        Me.lblCustomerSignUp.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerSignUp.Location = New System.Drawing.Point(744, 46)
        Me.lblCustomerSignUp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustomerSignUp.Name = "lblCustomerSignUp"
        Me.lblCustomerSignUp.Size = New System.Drawing.Size(345, 48)
        Me.lblCustomerSignUp.TabIndex = 0
        Me.lblCustomerSignUp.Text = "Customer Sign Up"
        '
        'btnCustomerSignUp
        '
        Me.btnCustomerSignUp.BackColor = System.Drawing.Color.White
        Me.btnCustomerSignUp.Location = New System.Drawing.Point(840, 442)
        Me.btnCustomerSignUp.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCustomerSignUp.Name = "btnCustomerSignUp"
        Me.btnCustomerSignUp.Size = New System.Drawing.Size(100, 28)
        Me.btnCustomerSignUp.TabIndex = 2
        Me.btnCustomerSignUp.Text = "Sign Up"
        Me.btnCustomerSignUp.UseVisualStyleBackColor = False
        '
        'txtCustomerName
        '
        Me.txtCustomerName.ForeColor = System.Drawing.Color.Black
        Me.txtCustomerName.Location = New System.Drawing.Point(840, 199)
        Me.txtCustomerName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(210, 22)
        Me.txtCustomerName.TabIndex = 3
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Location = New System.Drawing.Point(733, 208)
        Me.lblCustomerName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(68, 16)
        Me.lblCustomerName.TabIndex = 4
        Me.lblCustomerName.Text = "Full Name"
        '
        'lblCustomerEmail
        '
        Me.lblCustomerEmail.AutoSize = True
        Me.lblCustomerEmail.Location = New System.Drawing.Point(733, 258)
        Me.lblCustomerEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustomerEmail.Name = "lblCustomerEmail"
        Me.lblCustomerEmail.Size = New System.Drawing.Size(41, 16)
        Me.lblCustomerEmail.TabIndex = 5
        Me.lblCustomerEmail.Text = "Email"
        '
        'lblCustomerPhone
        '
        Me.lblCustomerPhone.AutoSize = True
        Me.lblCustomerPhone.Location = New System.Drawing.Point(664, 293)
        Me.lblCustomerPhone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustomerPhone.Name = "lblCustomerPhone"
        Me.lblCustomerPhone.Size = New System.Drawing.Size(158, 16)
        Me.lblCustomerPhone.TabIndex = 6
        Me.lblCustomerPhone.Text = "Phone Number (Optional)"
        '
        'lblCustomerAdress
        '
        Me.lblCustomerAdress.AutoSize = True
        Me.lblCustomerAdress.Location = New System.Drawing.Point(716, 332)
        Me.lblCustomerAdress.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustomerAdress.Name = "lblCustomerAdress"
        Me.lblCustomerAdress.Size = New System.Drawing.Size(58, 16)
        Me.lblCustomerAdress.TabIndex = 7
        Me.lblCustomerAdress.Text = "Address"
        '
        'lblCustomerPassword
        '
        Me.lblCustomerPassword.AutoSize = True
        Me.lblCustomerPassword.Location = New System.Drawing.Point(716, 364)
        Me.lblCustomerPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustomerPassword.Name = "lblCustomerPassword"
        Me.lblCustomerPassword.Size = New System.Drawing.Size(67, 16)
        Me.lblCustomerPassword.TabIndex = 8
        Me.lblCustomerPassword.Text = "Password"
        '
        'txtCustomerPassword
        '
        Me.txtCustomerPassword.ForeColor = System.Drawing.Color.Black
        Me.txtCustomerPassword.Location = New System.Drawing.Point(840, 356)
        Me.txtCustomerPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustomerPassword.Name = "txtCustomerPassword"
        Me.txtCustomerPassword.Size = New System.Drawing.Size(210, 22)
        Me.txtCustomerPassword.TabIndex = 10
        '
        'txtCustomerAddress
        '
        Me.txtCustomerAddress.ForeColor = System.Drawing.Color.Black
        Me.txtCustomerAddress.Location = New System.Drawing.Point(840, 324)
        Me.txtCustomerAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustomerAddress.Name = "txtCustomerAddress"
        Me.txtCustomerAddress.Size = New System.Drawing.Size(210, 22)
        Me.txtCustomerAddress.TabIndex = 11
        '
        'txtCustomerPhone
        '
        Me.txtCustomerPhone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtCustomerPhone.Location = New System.Drawing.Point(840, 284)
        Me.txtCustomerPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustomerPhone.Name = "txtCustomerPhone"
        Me.txtCustomerPhone.Size = New System.Drawing.Size(210, 22)
        Me.txtCustomerPhone.TabIndex = 12
        '
        'txtCustomerEmail
        '
        Me.txtCustomerEmail.ForeColor = System.Drawing.Color.Black
        Me.txtCustomerEmail.Location = New System.Drawing.Point(840, 250)
        Me.txtCustomerEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustomerEmail.Name = "txtCustomerEmail"
        Me.txtCustomerEmail.Size = New System.Drawing.Size(210, 22)
        Me.txtCustomerEmail.TabIndex = 13
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1824, 794)
        Me.Controls.Add(Me.txtCustomerEmail)
        Me.Controls.Add(Me.txtCustomerPhone)
        Me.Controls.Add(Me.txtCustomerAddress)
        Me.Controls.Add(Me.txtCustomerPassword)
        Me.Controls.Add(Me.lblCustomerPassword)
        Me.Controls.Add(Me.lblCustomerAdress)
        Me.Controls.Add(Me.lblCustomerPhone)
        Me.Controls.Add(Me.lblCustomerEmail)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.btnCustomerSignUp)
        Me.Controls.Add(Me.lblCustomerSignUp)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmCustomer"
        Me.Text = "frmCustomer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCustomerSignUp As Label
    Friend WithEvents btnCustomerSignUp As Button
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents lblCustomerEmail As Label
    Friend WithEvents lblCustomerPhone As Label
    Friend WithEvents lblCustomerAdress As Label
    Friend WithEvents lblCustomerPassword As Label
    Friend WithEvents txtCustomerPassword As TextBox
    Friend WithEvents txtCustomerAddress As TextBox
    Friend WithEvents txtCustomerPhone As TextBox
    Friend WithEvents txtCustomerEmail As TextBox
End Class
