Public Class Form1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = Now.ToLongTimeString()
    End Sub

  
    Function CalculateTotalWithoutVAT(ByVal hours As Integer, ByVal rate As Decimal, ByVal discount As Integer) As Decimal

        Dim totalWithoutDiscount As Decimal
        totalWithoutDiscount = hours * rate

        Dim totalWithDiscount As Decimal
        totalWithDiscount = totalWithoutDiscount - (totalWithDiscount * discount / 100)

        Return totalWithDiscount
    End Function

    Function CalculateTotalWithVAT(ByVal hours As Integer, ByVal rate As Decimal, ByVal discount As Integer) As Decimal

        Dim totalWithoutVat As Decimal = CalculateTotalWithoutVAT(hours, rate, discount)

        totalWithoutVat = totalWithoutVat + (totalWithoutVat * 18 / 100)

        Return totalWithoutVat

    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim rate As Integer
        Dim discount As Integer
        Dim hours As Integer

        rate = Convert.ToInt32(txtHourlyRate.Text)
        hours = dtpExit.Value.Subtract(dtpEntrance.Value).Hours

        If cmbDiscount.SelectedIndex = 0 Then
            discount = 0
        ElseIf cmbDiscount.SelectedIndex = 1 Then
            discount = 100
        Else
            discount = 50
        End If

        txtTotalWithoutVAT.Text = CalculateTotalWithoutVAT(hours, rate, discount)

        txtTotal.Text = CalculateTotalWithVAT(hours, rate, discount)
    End Sub
End Class
