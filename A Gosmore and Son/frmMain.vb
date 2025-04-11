Public Class frmMain

    Private Sub btnBookings_Click(sender As Object, e As EventArgs) Handles btnBookings.Click
        frmBooking.Show()
        Me.Hide()
    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        frmProducts.Show()
        Me.Hide()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class