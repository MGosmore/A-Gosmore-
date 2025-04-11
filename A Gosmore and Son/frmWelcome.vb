Public Class frmWelcome
    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        frmStaff.Show()
        Me.Hide()
    End Sub

    Private Sub btnCustomer_Click(sender As Object, e As EventArgs) Handles btnCustomer.Click
        frmCustomer.Show()
        Me.Hide()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub

    Private Sub btnGuest_Click(sender As Object, e As EventArgs) Handles btnGuest.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub frmWelcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
