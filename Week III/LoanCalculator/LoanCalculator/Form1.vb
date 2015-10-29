Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For i As Integer = 1 To 30
            cmbYears.Items.Add(i)
        Next

    End Sub

    Private Sub cmbYears_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbYears.SelectedIndexChanged

        Dim years As Integer
        years = Convert.ToInt32(cmbYears.Text)
        txtMonths.Text = years * 12


    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim monthlyPayement As Decimal 'M
        Dim principalAmount As Decimal 'P
        Dim realInterestRate As Decimal 'J
        Dim months As Integer 'N
        'Calculations are based on the following formula
        'M = P * (J/(1-(1+J)^-N))
        Dim years As Integer
        years = Convert.ToInt32(cmbYears.Text)
        months = years * 12

        If Integer.TryParse(txtAmount.Text, principalAmount) = False Then
            MessageBox.Show("Please write a numeric value for amount!")
            txtAmount.Focus()
            Return
        End If

        Dim interestRate As Decimal

        If Decimal.TryParse(txtInterestRate.Text, interestRate) = False Then
            MessageBox.Show("Please write a numeric value for interest rate!")
            txtInterestRate.Focus()
            Return
        End If
        
        realInterestRate = (interestRate / 100) / 12
        monthlyPayement = principalAmount * (realInterestRate / (1 - (Math.Pow(1 + realInterestRate, -months))))


        Dim startDate As DateTime = dtpStartDate.Value

        lstMonthlyPayments.Items.Clear()

        For i As Integer = 1 To months
            lstMonthlyPayments.Items.Add(startDate.ToShortDateString() + " - " + monthlyPayement.ToString("C2"))
            startDate = startDate.AddMonths(1)

        Next

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAmount.Text = ""
        cmbYears.SelectedIndex = 0
        txtInterestRate.Text = ""
        lstMonthlyPayments.Items.Clear()
        dtpStartDate.Value = Now
        txtAmount.Focus()
    End Sub
End Class
