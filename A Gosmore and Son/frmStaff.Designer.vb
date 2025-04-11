<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStaff
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
        Me.lblStaffSignIn = New System.Windows.Forms.Label()
        Me.btnStaffSignIn = New System.Windows.Forms.Button()
        Me.lblStaffPassword = New System.Windows.Forms.Label()
        Me.lblStaffEmail = New System.Windows.Forms.Label()
        Me.txtStaffPassword = New System.Windows.Forms.TextBox()
        Me.txtStaffEmail = New System.Windows.Forms.TextBox()
        Me.ChkStaffHide = New System.Windows.Forms.CheckBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblStaffSignIn
        '
        Me.lblStaffSignIn.AutoSize = True
        Me.lblStaffSignIn.Font = New System.Drawing.Font("Microsoft YaHei UI", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStaffSignIn.Location = New System.Drawing.Point(784, 78)
        Me.lblStaffSignIn.Name = "lblStaffSignIn"
        Me.lblStaffSignIn.Size = New System.Drawing.Size(235, 48)
        Me.lblStaffSignIn.TabIndex = 1
        Me.lblStaffSignIn.Text = "Staff Sign In"
        '
        'btnStaffSignIn
        '
        Me.btnStaffSignIn.Location = New System.Drawing.Point(877, 459)
        Me.btnStaffSignIn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnStaffSignIn.Name = "btnStaffSignIn"
        Me.btnStaffSignIn.Size = New System.Drawing.Size(125, 43)
        Me.btnStaffSignIn.TabIndex = 2
        Me.btnStaffSignIn.Text = "Sign In"
        Me.btnStaffSignIn.UseVisualStyleBackColor = True
        '
        'lblStaffPassword
        '
        Me.lblStaffPassword.AutoSize = True
        Me.lblStaffPassword.Location = New System.Drawing.Point(753, 318)
        Me.lblStaffPassword.Name = "lblStaffPassword"
        Me.lblStaffPassword.Size = New System.Drawing.Size(67, 16)
        Me.lblStaffPassword.TabIndex = 3
        Me.lblStaffPassword.Text = "Password"
        '
        'lblStaffEmail
        '
        Me.lblStaffEmail.AutoSize = True
        Me.lblStaffEmail.Location = New System.Drawing.Point(753, 249)
        Me.lblStaffEmail.Name = "lblStaffEmail"
        Me.lblStaffEmail.Size = New System.Drawing.Size(41, 16)
        Me.lblStaffEmail.TabIndex = 4
        Me.lblStaffEmail.Text = "Email"
        '
        'txtStaffPassword
        '
        Me.txtStaffPassword.Location = New System.Drawing.Point(843, 318)
        Me.txtStaffPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStaffPassword.Name = "txtStaffPassword"
        Me.txtStaffPassword.Size = New System.Drawing.Size(185, 22)
        Me.txtStaffPassword.TabIndex = 5
        '
        'txtStaffEmail
        '
        Me.txtStaffEmail.Location = New System.Drawing.Point(843, 249)
        Me.txtStaffEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStaffEmail.Name = "txtStaffEmail"
        Me.txtStaffEmail.Size = New System.Drawing.Size(185, 22)
        Me.txtStaffEmail.TabIndex = 6
        '
        'ChkStaffHide
        '
        Me.ChkStaffHide.AutoSize = True
        Me.ChkStaffHide.Location = New System.Drawing.Point(1045, 319)
        Me.ChkStaffHide.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChkStaffHide.Name = "ChkStaffHide"
        Me.ChkStaffHide.Size = New System.Drawing.Size(121, 20)
        Me.ChkStaffHide.TabIndex = 7
        Me.ChkStaffHide.Text = "Hide Password"
        Me.ChkStaffHide.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(29, 708)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(125, 43)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1837, 764)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.ChkStaffHide)
        Me.Controls.Add(Me.txtStaffEmail)
        Me.Controls.Add(Me.txtStaffPassword)
        Me.Controls.Add(Me.lblStaffEmail)
        Me.Controls.Add(Me.lblStaffPassword)
        Me.Controls.Add(Me.btnStaffSignIn)
        Me.Controls.Add(Me.lblStaffSignIn)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmStaff"
        Me.Text = "frmStaff"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStaffSignIn As Label
    Friend WithEvents btnStaffSignIn As Button
    Friend WithEvents lblStaffPassword As Label
    Friend WithEvents lblStaffEmail As Label
    Friend WithEvents txtStaffPassword As TextBox
    Friend WithEvents txtStaffEmail As TextBox
    Friend WithEvents ChkStaffHide As CheckBox
    Friend WithEvents btnBack As Button
End Class
