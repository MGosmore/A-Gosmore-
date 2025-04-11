Imports System.IO

Public Class frmCustomerBooking
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim filePath As String = "C:\Users\matth\Desktop\Project\Bookings.txt"

        Dim bookingData As String = txtName.Text & Environment.NewLine &
                                     txtPhone.Text & Environment.NewLine &
                                     txtLocation.Text & Environment.NewLine &
                                     dtpDate.Text & Environment.NewLine &
                                     txtOverview.Text & Environment.NewLine


        Try
            File.AppendAllText(filePath, bookingData)
            MessageBox.Show("Booking Info has been saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error saving booking data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmBooking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSubmit.Enabled = False
    End Sub
    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged, txtPhone.TextChanged, txtLocation.TextChanged, dtpDate.TextChanged, Label6.TextChanged
        btnSubmit.Enabled = Not String.IsNullOrWhiteSpace(txtName.Text) AndAlso Not String.IsNullOrWhiteSpace(txtPhone.Text) AndAlso Not String.IsNullOrWhiteSpace(txtLocation.Text) AndAlso Not String.IsNullOrWhiteSpace(dtpDate.Text) AndAlso Not String.IsNullOrWhiteSpace(Label6.Text)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMain.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtOverview.TextChanged

    End Sub
End Class