Imports System.IO

Public Class frmView
    Private filePath As String = "C:\Users\matth\Desktop\Project\Customers.txt"

    Private Sub frmView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFile()
    End Sub

    Private Sub LoadFile()
        If File.Exists(filePath) Then
            lstBox.Items.Clear()
            Dim lines As String() = File.ReadAllLines(filePath)
            lstBox.Items.AddRange(lines)
        End If
    End Sub

    Private Sub SaveFile()
        Dim lines As New List(Of String)
        For Each item In lstBox.Items
            lines.Add(item.ToString())
        Next
        File.WriteAllLines(filePath, lines)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchText As String = txtSearch.Text.ToLower()
        If Not String.IsNullOrWhiteSpace(searchText) Then
            For i As Integer = 0 To lstBox.Items.Count - 1
                If lstBox.Items(i).ToString().ToLower().Contains(searchText) Then
                    lstBox.SelectedIndex = i
                    Exit Sub
                End If
            Next
            MessageBox.Show("Item not found.")
        End If
    End Sub
End Class