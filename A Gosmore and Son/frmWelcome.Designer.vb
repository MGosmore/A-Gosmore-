<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWelcome
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
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnStaff = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnGuest = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Microsoft YaHei UI", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(587, 52)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(605, 48)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.Text = "Welcome to A Gosmore and Son"
        '
        'btnCustomer
        '
        Me.btnCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCustomer.Location = New System.Drawing.Point(628, 294)
        Me.btnCustomer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(131, 57)
        Me.btnCustomer.TabIndex = 1
        Me.btnCustomer.Text = "Customer Sign In or Sign Up"
        Me.btnCustomer.UseVisualStyleBackColor = False
        '
        'btnStaff
        '
        Me.btnStaff.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnStaff.Location = New System.Drawing.Point(813, 294)
        Me.btnStaff.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnStaff.Name = "btnStaff"
        Me.btnStaff.Size = New System.Drawing.Size(131, 57)
        Me.btnStaff.TabIndex = 2
        Me.btnStaff.Text = "Staff Sign In"
        Me.btnStaff.UseVisualStyleBackColor = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnQuit.Location = New System.Drawing.Point(12, 731)
        Me.btnQuit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(91, 25)
        Me.btnQuit.TabIndex = 3
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'btnGuest
        '
        Me.btnGuest.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnGuest.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnGuest.Location = New System.Drawing.Point(982, 294)
        Me.btnGuest.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGuest.Name = "btnGuest"
        Me.btnGuest.Size = New System.Drawing.Size(131, 57)
        Me.btnGuest.TabIndex = 4
        Me.btnGuest.Text = "Continue as guest"
        Me.btnGuest.UseVisualStyleBackColor = False
        '
        'frmWelcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1835, 768)
        Me.Controls.Add(Me.btnGuest)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnStaff)
        Me.Controls.Add(Me.btnCustomer)
        Me.Controls.Add(Me.lblWelcome)
        Me.HelpButton = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmWelcome"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnCustomer As Button
    Friend WithEvents btnStaff As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnGuest As Button
End Class
