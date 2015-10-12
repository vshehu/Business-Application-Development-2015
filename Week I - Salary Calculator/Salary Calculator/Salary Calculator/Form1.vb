Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        txtRetirement.Text = Val(txtGrossSalary.Text) * 18 / 100
        txtHealth.Text = Val(txtGrossSalary.Text) * 7.3 / 100
        txtEmployment.Text = Val(txtGrossSalary.Text) * 1.2 / 100
        txtSicnkess.Text = Val(txtGrossSalary.Text) * 0.5 / 100

        txtTaxable.Text = Val(txtGrossSalary.Text) - (Val(txtRetirement.Text) + Val(txtHealth.Text) + Val(txtEmployment.Text) + Val(txtSicnkess.Text))

        txtPersonal.Text = Val(txtTaxable.Text) * 10 / 100

        txtNetSalary.Text = Val(txtTaxable.Text) - Val(txtPersonal.Text)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGrossSalary.Text = ""
        txtRetirement.Text = ""
        txtHealth.Text = ""
        txtEmployment.Text = ""
        txtSicnkess.Text = ""
        txtTaxable.Text = ""
        txtPersonal.Text = ""
        txtNetSalary.Text = ""

        txtGrossSalary.Focus()
    End Sub
End Class
