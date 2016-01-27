Imports System.Data.SqlClient

Public Class frmOutgoingTransactions

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim amount As Decimal
        If Decimal.TryParse(txtAmount.Text, amount) = False Then
            MessageBox.Show("Amount should be a numeric value!")
            txtAmount.Focus()
            txtAmount.SelectAll()
            Return
        End If

        Dim sql As String
        sql = "INSERT INTO Transactions(transaction_date, category, description, amount, transaction_type) VALUES(@td, @cat, @descr, @amnt, 'expense')"
        Dim params As New List(Of SqlParameter)
        params.Add(New SqlParameter("@td", dtTransactionDate.Value))
        params.Add(New SqlParameter("@cat", cmbCategory.Text))
        params.Add(New SqlParameter("@descr", txtDescription.Text))
        params.Add(New SqlParameter("@amnt", txtAmount.Text))

        Dim dh As New DatabaseHelper
        dh.ExecuteNonQuery(sql, params.ToArray())

        If MessageBox.Show("Do you want to register a new expense?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Me.Close()
        Else
            txtAmount.Clear()
            txtDescription.Clear()
            cmbCategory.SelectedIndex = 0
            dtTransactionDate.Focus()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class