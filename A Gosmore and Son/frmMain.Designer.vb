<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnProducts = New System.Windows.Forms.Button()
        Me.btnBookings = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(545, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Main Menu"
        '
        'btnProducts
        '
        Me.btnProducts.Location = New System.Drawing.Point(476, 241)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Size = New System.Drawing.Size(91, 45)
        Me.btnProducts.TabIndex = 1
        Me.btnProducts.Text = "Purchase Products"
        Me.btnProducts.UseVisualStyleBackColor = True
        '
        'btnBookings
        '
        Me.btnBookings.Location = New System.Drawing.Point(723, 241)
        Me.btnBookings.Name = "btnBookings"
        Me.btnBookings.Size = New System.Drawing.Size(89, 45)
        Me.btnBookings.TabIndex = 2
        Me.btnBookings.Text = "Request a booking"
        Me.btnBookings.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(26, 544)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(89, 29)
        Me.btnReturn.TabIndex = 3
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1407, 585)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnBookings)
        Me.Controls.Add(Me.btnProducts)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnProducts As Button
    Friend WithEvents btnBookings As Button
    Friend WithEvents btnReturn As Button
End Class
