Public Class frmStaff
    Private Sub ChkHide_CheckedChanged(sender As Object, e As EventArgs) Handles ChkStaffHide.CheckedChanged
        If ChkStaffHide.Checked = True Then
            txtStaffPassword.UseSystemPasswordChar = True
        Else
            txtStaffPassword.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub btnStaffSignIn_Click(sender As Object, e As EventArgs) Handles btnStaffSignIn.Click
        If txtStaffEmail.Text = "1@" And
            txtStaffPassword.Text = "1" Then
            frmStaffMain.Show()
            Me.Hide()
        Else
            MsgBox("Incorrect Username or Password", MsgBoxStyle.Information, "Error")
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub txtStaffEmail_TextChanged(sender As Object, e As EventArgs) Handles txtStaffEmail.TextChanged
        btnStaffSignIn.Enabled = txtStaffEmail.Text.Contains("@")
    End Sub
End Class