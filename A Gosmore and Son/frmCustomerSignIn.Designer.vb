<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerSignIn
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
        Me.lblCustomerSignIn = New System.Windows.Forms.Label()
        Me.txtCustomerEmail = New System.Windows.Forms.TextBox()
        Me.txtCustomerPassword = New System.Windows.Forms.TextBox()
        Me.lblCustomerEmail = New System.Windows.Forms.Label()
        Me.lblCustomerPassword = New System.Windows.Forms.Label()
        Me.ChkCustomerHide = New System.Windows.Forms.CheckBox()
        Me.btnCustomerSignIn = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCustomerSignIn
        '
        Me.lblCustomerSignIn.AutoSize = True
        Me.lblCustomerSignIn.Font = New System.Drawing.Font("Microsoft YaHei UI", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerSignIn.Location = New System.Drawing.Point(772, 156)
        Me.lblCustomerSignIn.Name = "lblCustomerSignIn"
        Me.lblCustomerSignIn.Size = New System.Drawing.Size(327, 48)
        Me.lblCustomerSignIn.TabIndex = 2
        Me.lblCustomerSignIn.Text = "Customer Sign In"
        '
        'txtCustomerEmail
        '
        Me.txtCustomerEmail.Location = New System.Drawing.Point(868, 289)
        Me.txtCustomerEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCustomerEmail.Name = "txtCustomerEmail"
        Me.txtCustomerEmail.Size = New System.Drawing.Size(185, 22)
        Me.txtCustomerEmail.TabIndex = 7
        '
        'txtCustomerPassword
        '
        Me.txtCustomerPassword.Location = New System.Drawing.Point(868, 340)
        Me.txtCustomerPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCustomerPassword.Name = "txtCustomerPassword"
        Me.txtCustomerPassword.Size = New System.Drawing.Size(185, 22)
        Me.txtCustomerPassword.TabIndex = 8
        '
        'lblCustomerEmail
        '
        Me.lblCustomerEmail.AutoSize = True
        Me.lblCustomerEmail.Location = New System.Drawing.Point(805, 289)
        Me.lblCustomerEmail.Name = "lblCustomerEmail"
        Me.lblCustomerEmail.Size = New System.Drawing.Size(41, 16)
        Me.lblCustomerEmail.TabIndex = 9
        Me.lblCustomerEmail.Text = "Email"
        '
        'lblCustomerPassword
        '
        Me.lblCustomerPassword.AutoSize = True
        Me.lblCustomerPassword.Location = New System.Drawing.Point(777, 340)
        Me.lblCustomerPassword.Name = "lblCustomerPassword"
        Me.lblCustomerPassword.Size = New System.Drawing.Size(67, 16)
        Me.lblCustomerPassword.TabIndex = 10
        Me.lblCustomerPassword.Text = "Password"
        '
        'ChkCustomerHide
        '
        Me.ChkCustomerHide.AutoSize = True
        Me.ChkCustomerHide.Location = New System.Drawing.Point(1089, 343)
        Me.ChkCustomerHide.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChkCustomerHide.Name = "ChkCustomerHide"
        Me.ChkCustomerHide.Size = New System.Drawing.Size(121, 20)
        Me.ChkCustomerHide.TabIndex = 11
        Me.ChkCustomerHide.Text = "Hide Password"
        Me.ChkCustomerHide.UseVisualStyleBackColor = True
        '
        'btnCustomerSignIn
        '
        Me.btnCustomerSignIn.Location = New System.Drawing.Point(895, 386)
        Me.btnCustomerSignIn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCustomerSignIn.Name = "btnCustomerSignIn"
        Me.btnCustomerSignIn.Size = New System.Drawing.Size(125, 43)
        Me.btnCustomerSignIn.TabIndex = 12
        Me.btnCustomerSignIn.Text = "Sign In"
        Me.btnCustomerSignIn.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(12, 672)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(125, 43)
        Me.btnBack.TabIndex = 13
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmCustomerSignIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1923, 726)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnCustomerSignIn)
        Me.Controls.Add(Me.ChkCustomerHide)
        Me.Controls.Add(Me.lblCustomerPassword)
        Me.Controls.Add(Me.lblCustomerEmail)
        Me.Controls.Add(Me.txtCustomerPassword)
        Me.Controls.Add(Me.txtCustomerEmail)
        Me.Controls.Add(Me.lblCustomerSignIn)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCustomerSignIn"
        Me.Text = "frmCustomerSignIn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCustomerSignIn As Label
    Friend WithEvents txtCustomerEmail As TextBox
    Friend WithEvents txtCustomerPassword As TextBox
    Friend WithEvents lblCustomerEmail As Label
    Friend WithEvents lblCustomerPassword As Label
    Friend WithEvents ChkCustomerHide As CheckBox
    Friend WithEvents btnCustomerSignIn As Button
    Friend WithEvents btnBack As Button
End Class
