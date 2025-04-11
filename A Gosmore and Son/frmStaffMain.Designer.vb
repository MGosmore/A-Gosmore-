<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStaffMain
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
        Me.btnView = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBookings = New System.Windows.Forms.Button()
        Me.btnProducts = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(256, 310)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(157, 56)
        Me.btnView.TabIndex = 0
        Me.btnView.Text = "View Signed up Customers"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(508, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 48)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Staff Main Menu"
        '
        'btnBookings
        '
        Me.btnBookings.Location = New System.Drawing.Point(537, 310)
        Me.btnBookings.Name = "btnBookings"
        Me.btnBookings.Size = New System.Drawing.Size(155, 56)
        Me.btnBookings.TabIndex = 2
        Me.btnBookings.Text = "View requested bookings"
        Me.btnBookings.UseVisualStyleBackColor = True
        '
        'btnProducts
        '
        Me.btnProducts.Location = New System.Drawing.Point(775, 310)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Size = New System.Drawing.Size(124, 56)
        Me.btnProducts.TabIndex = 3
        Me.btnProducts.Text = "View requested products"
        Me.btnProducts.UseVisualStyleBackColor = True
        '
        'frmStaffMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1329, 587)
        Me.Controls.Add(Me.btnProducts)
        Me.Controls.Add(Me.btnBookings)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnView)
        Me.Name = "frmStaffMain"
        Me.Text = "frmStaffMain"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnView As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBookings As Button
    Friend WithEvents btnProducts As Button
End Class
