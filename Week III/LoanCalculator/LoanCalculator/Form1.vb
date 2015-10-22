Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 1 To 30
            cmbYears.Items.Add(i)
        Next
    End Sub
End Class
