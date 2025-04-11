<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerProducts
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lstProducts = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtBlank2 = New System.Windows.Forms.TextBox()
        Me.txtBlank1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(613, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Products"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(815, 277)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(141, 51)
        Me.btnSubmit.TabIndex = 1
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lstProducts
        '
        Me.lstProducts.FormattingEnabled = True
        Me.lstProducts.ItemHeight = 16
        Me.lstProducts.Location = New System.Drawing.Point(422, 208)
        Me.lstProducts.Name = "lstProducts"
        Me.lstProducts.Size = New System.Drawing.Size(268, 196)
        Me.lstProducts.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(419, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(271, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Please select products you wish to purchase"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(12, 498)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(493, 427)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(211, 22)
        Me.txtName.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(419, 430)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Full Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(446, 466)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(493, 466)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(211, 22)
        Me.txtEmail.TabIndex = 8
        '
        'txtBlank2
        '
        Me.txtBlank2.Location = New System.Drawing.Point(694, 466)
        Me.txtBlank2.Name = "txtBlank2"
        Me.txtBlank2.Size = New System.Drawing.Size(10, 22)
        Me.txtBlank2.TabIndex = 9
        '
        'txtBlank1
        '
        Me.txtBlank1.Location = New System.Drawing.Point(694, 427)
        Me.txtBlank1.Name = "txtBlank1"
        Me.txtBlank1.Size = New System.Drawing.Size(10, 22)
        Me.txtBlank1.TabIndex = 10
        '
        'frmProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1357, 533)
        Me.Controls.Add(Me.txtBlank1)
        Me.Controls.Add(Me.txtBlank2)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstProducts)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmProducts"
        Me.Text = "frmProducts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lstProducts As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtBlank2 As TextBox
    Friend WithEvents txtBlank1 As TextBox
End Class
