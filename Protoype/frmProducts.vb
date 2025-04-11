Imports System.IO

Public Class frmCustomerProducts
    Private Sub frmProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstProducts.SelectionMode = SelectionMode.MultiSimple
        lstProducts.Items.Add("Light Bulbs")
        lstProducts.Items.Add("Sockets")
        lstProducts.Items.Add("Circuit Boards")
        lstProducts.Items.Add("Wiring")
        lstProducts.Items.Add("Fuse Boxes")
        lstProducts.Items.Add("Light Switches")
        lstProducts.Items.Add("Copper Wire")
        lstProducts.Items.Add("Wire Insulation")
        lstProducts.Items.Add("Antennas")
        lstProducts.Items.Add("Television Socket")
        lstProducts.Items.Add("Screwdriver Set")
        lstProducts.Items.Add("Range of Screws and Bolts")
        lstProducts.Items.Add("Batteries")
        lstProducts.Items.Add("Extentsion Cords")
        lstProducts.Items.Add("Other")
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim selectedItems As New List(Of String)

        For Each item As Object In lstProducts.SelectedItems
            selectedItems.Add(item.ToString())
        Next

        Dim filePath As String = "C:\Users\matth\Desktop\Project\Products.txt"
        File.WriteAllLines(filePath, selectedItems)
        MessageBox.Show("Your selected Products will now be available for staff to view. They will get back to you shortly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Dim buyerData As String = txtBlank1.Text & Environment.NewLine &
                                  txtName.Text & Environment.NewLine &
                                  txtEmail.Text & Environment.NewLine &
                                  txtBlank2.Text & Environment.NewLine




        Try
            File.AppendAllText(filePath, buyerData)
            MessageBox.Show("Complete", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error saving data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lstProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProducts.SelectedIndexChanged

    End Sub
End Class