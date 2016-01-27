Imports System.Data.SqlClient

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        'When the user logs off, we hide the menu and show the login box
        'The opposite happens on successfull login
        MenuStrip1.Visible = False
        GroupBox1.Visible = True
    End Sub

    Private Sub IncomesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncomesToolStripMenuItem.Click
        Dim frm As New frmIncomingTransaction
        frm.ShowDialog()
    End Sub

    Private Sub ExpensesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExpensesToolStripMenuItem.Click
        Dim frm As New frmOutgoingTransactions
        frm.ShowDialog()

    End Sub

    Private Sub ExpenseReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExpenseReportToolStripMenuItem.Click
        Dim frm As New frmExpenseReport
        frm.ShowDialog()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String
        sql = "SELECT FirstName + ' ' + LastName FROM Users WHERE UserName = @user AND Password = @password"
        Dim params As New List(Of SqlParameter)
        params.Add(New SqlParameter("user", txtUser.Text))
        params.Add(New SqlParameter("password", txtPassword.Text))

        Dim dh As New DatabaseHelper
        If dh.ExecuteScalar(sql, params.ToArray) Is Nothing Then
            MessageBox.Show("Username and/or password is incorrect!")
            Return

        End If
        Dim ret As String = dh.ExecuteScalar(sql, params.ToArray).ToString()
        If String.IsNullOrEmpty(ret) Then
            MessageBox.Show("Username and/or password is incorrect!")
            Return
        Else
            MessageBox.Show("Welcome " + ret)
            MenuStrip1.Visible = True
            GroupBox1.Visible = False
        End If

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
