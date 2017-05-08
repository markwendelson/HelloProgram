Public Class Form1
    Private Sub cmdHello_Click(sender As Object, e As EventArgs) Handles cmdHello.Click
        If txtName.Text = "" Then
            ErrorProvider1.SetError(txtName, "Name Required")
            Exit Sub
        Else
            ErrorProvider1.SetError(txtName, "")
        End If

        MessageBox.Show("Hello " & txtName.Text & vbNewLine & "The time is: " & TimeOfDay)
        Me.Text = "Hello " & txtName.Text
    End Sub
End Class
