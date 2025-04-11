Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmCustomer

    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnCustomerSignUp.Enabled = False
    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerName.TextChanged, txtCustomerEmail.TextChanged, txtCustomerAddress.TextChanged, txtCustomerPassword.TextChanged
        btnCustomerSignUp.Enabled = Not String.IsNullOrWhiteSpace(txtCustomerName.Text) AndAlso Not String.IsNullOrWhiteSpace(txtCustomerEmail.Text) AndAlso Not String.IsNullOrWhiteSpace(txtCustomerAddress.Text) AndAlso Not String.IsNullOrWhiteSpace(txtCustomerPassword.Text)
        btnCustomerSignUp.Enabled = txtCustomerEmail.Text.Contains("@")
    End Sub
    Private Sub btnCustomerSignUp_Click(sender As Object, e As EventArgs) Handles btnCustomerSignUp.Click
        Dim filePath As String = "C:\Users\matth\Desktop\Project\Customers.txt"

        Dim customerData As String = txtCustomerName.Text & Environment.NewLine &
                                     txtCustomerEmail.Text & Environment.NewLine &
                                     txtCustomerPhone.Text & Environment.NewLine &
                                     txtCustomerAddress.Text & Environment.NewLine &
                                     txtCustomerPassword.Text & Environment.NewLine


        Try
            File.AppendAllText(filePath, customerData)
            MessageBox.Show("Customer Info has been saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error saving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        frmMain.Show()
        Me.Hide()

    End Sub

    Private Sub ChkCustomerHide_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCustomerHide.CheckedChanged
        If ChkCustomerHide.Checked = True Then
            txtCustomerPassword.UseSystemPasswordChar = True
        Else
            txtCustomerPassword.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btnCustomerSignIn_Click(sender As Object, e As EventArgs) Handles btnCustomerSignIn.Click
        frmCustomerSignIn.Show()
        Me.Hide()
    End Sub
End Class