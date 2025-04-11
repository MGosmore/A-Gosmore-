Public Class frmWelcome


    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        frmCustomer.Show()
        Me.Hide()
    End Sub



    Private Sub frmWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
