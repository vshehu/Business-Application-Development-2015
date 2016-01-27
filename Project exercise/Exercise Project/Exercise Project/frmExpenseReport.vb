Imports System.Data.SqlClient

Public Class frmExpenseReport

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkGroup.CheckedChanged
        'Checkbox should disable combobox (mutually exclusive)
        cmbCategory.Enabled = Not chkGroup.Checked
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String

        Dim params As New List(Of SqlParameter)
        params.Add(New SqlParameter("@start", dtFrom.Value))
        params.Add(New SqlParameter("@end", dtTo.Value))
        
        If chkGroup.Checked Then
            sql = "select MIN(CONVERT(VARCHAR(10),transaction_date,110)) as 'Date', MIN(category) as 'Category', SUM(case transaction_type 	when 'income' then amount 	else 0 END) AS 'Incomes', SUM(case transaction_type when 'expense' then amount else 0 END) AS 'Expenses' From transactions WHERE transaction_date between @start and @end group by transaction_type "

        Else
            If cmbCategory.Text = "All" Then
                sql = "select CONVERT(VARCHAR(10),transaction_date,110) as 'Date', category as 'Category', [description] as 'Description', case transaction_type  when 'income' then amount else 0 END AS 'Incomes', case transaction_type when 'expense' then amount else 0 END AS 'Expenses' From transactions WHERE transaction_date between @start and @end "

            Else
                sql = "select CONVERT(VARCHAR(10),transaction_date,110) as 'Date', category as 'Category', [description] as 'Description', case transaction_type  when 'income' then amount else 0 END AS 'Incomes', case transaction_type when 'expense' then amount else 0 END AS 'Expenses' From transactions WHERE transaction_date between @start and @end AND category=@category"
                params.Add(New SqlParameter("@category", cmbCategory.Text))

            End If

        End If
        

        Dim dh As New DatabaseHelper
        Dim table As New DataTable
        table.Load(dh.ExecuteReader(sql, params.ToArray()))

        grdReport.DataSource = table


    End Sub

    Private Sub frmExpenseReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dh As New DatabaseHelper
        Dim sql As String
        sql = "SELECT DISTINCT category FROM Transactions"
        cmbCategory.Items.Add("All")
        Dim dr As SqlDataReader = dh.ExecuteReader(sql, Nothing)
        While dr.Read
            cmbCategory.Items.Add(dr(0).ToString())
        End While

        cmbCategory.SelectedIndex = 0
    End Sub
End Class