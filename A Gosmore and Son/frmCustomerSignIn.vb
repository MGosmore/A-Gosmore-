Public Class frmCustomerSignIn
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmCustomer.Show()
        Me.Hide()
    End Sub

    Private Sub btnCustomerSignIn_Click(sender As Object, e As EventArgs) Handles btnCustomerSignIn.Click
        If txtCustomerEmail.Text = "1" And
            txtCustomerPassword.Text = "1" Then
            frmMain.Show()
            Me.Hide()
        Else
            MsgBox("Incorrect Username or Password", MsgBoxStyle.Information, "Error")
        End If
    End Sub

    Private Sub ChkCustomerHide_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCustomerHide.CheckedChanged
        If ChkCustomerHide.Checked = True Then
            txtCustomerPassword.UseSystemPasswordChar = True
        Else
            txtCustomerPassword.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub txtCustomerEmail_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerEmail.TextChanged
        btnCustomerSignIn.Enabled = txtCustomerEmail.Text.Contains("@")
    End Sub
End Class