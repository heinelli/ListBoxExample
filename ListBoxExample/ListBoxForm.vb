Option Strict On
Option Explicit On

Public Class ListBoxForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        'ListBox1.Items.Add(TextBox1.Text)
        Count()
        ComboBox1.Items.Add(TextBox1.Text)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Me.Text = $"Index {ListBox1.SelectedIndex} contains: {ListBox1.SelectedItem}"
    End Sub

    Sub Count()
        Dim rowData As String
        For i = 0 To 9
            For j = 0 To 9
                rowData &= (CStr(i) & CStr(j)).PadLeft(5) & " "
            Next
            ListBox1.Items.Add(rowData)
            rowData = ""
        Next
    End Sub
End Class
