Public Class Form1

    Dim denarsToEuro As Decimal = 62.1
    Dim denarsToDollar As Decimal = 54
    Dim denarsToFranc As Decimal = 56.5

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbFrom.SelectedIndex = 0
        cmbTo.SelectedIndex = 1

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim amount As Decimal

        If Decimal.TryParse(txtAmount.Text, amount) = False Then
            MessageBox.Show("Please use valid numbers for amount!")
            txtAmount.Focus()
            txtAmount.Text = ""
            Return
        End If
       
        Dim conversionRate As Decimal
        If cmbFrom.SelectedIndex = 0 Then
            If cmbTo.SelectedIndex = 0 Then
                conversionRate = 1
            ElseIf cmbTo.SelectedIndex = 1 Then
                conversionRate = denarsToEuro
            ElseIf cmbTo.SelectedIndex = 2 Then
                conversionRate = denarsToDollar
            Else
                conversionRate = denarsToFranc
            End If
        End If

        Dim result As Decimal
        result = amount / conversionRate

        txtResult.Text = result.ToString()

    End Sub
End Class
