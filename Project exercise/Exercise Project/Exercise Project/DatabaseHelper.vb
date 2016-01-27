Imports System.Data.SqlClient
Public Class DatabaseHelper
    'Private memberss of the class
    Private _ConnectionString As String
    Private _cmd As SqlCommand
    Private _con As SqlConnection

    Public Sub New()
        'The connection string is stored in the settings file.
        'You can find this file in Solution->Exercise Project -> My Project -> Settings (on the left pane)
        'The value of connection string is: 
        'Server=BudgetDB.db.11351610.hostedresource.com;Database=BudgetDB;User Id=BudgetDB;Password=Budg3tDB123@#;
        _ConnectionString = My.Settings.ConnectionString
        _con = New SqlConnection(_ConnectionString)
        _cmd = _con.CreateCommand()
    End Sub


    ''' <summary>
    ''' This sub will execute an sql command. It will not return anything. It also accepts an array of parameters to 
    ''' pass to the sql command
    ''' </summary>
    ''' <param name="command"></param>
    ''' <param name="params"></param>
    ''' <remarks></remarks>
    Public Sub ExecuteNonQuery(ByRef command As String, ByRef params() As SqlParameter)
        _cmd.Parameters.Clear()
        _cmd.CommandText = command
        If Not params Is Nothing Then
            For Each p As SqlParameter In params
                _cmd.Parameters.Add(p)
            Next
        End If
        _con.Open()
        _cmd.ExecuteNonQuery()
        _con.Close()
    End Sub


    ''' <summary>
    ''' This function executes a scalar method. It returns an object type which will need to be casted on the client 
    ''' side
    ''' </summary>
    ''' <param name="command"></param>
    ''' <param name="params"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ExecuteScalar(ByRef command As String, ByRef params() As SqlParameter)
        _cmd.Parameters.Clear()
        _cmd.CommandText = command

        If Not params Is Nothing Then
            For Each p As SqlParameter In params
                _cmd.Parameters.Add(p)
            Next
        End If

        Dim ret As Object
        _con.Open()
        ret = _cmd.ExecuteScalar()
        _con.Close()

        Return ret
    End Function


    ''' <summary>
    ''' This function returns an sqldatareader. It closes the connection as soon as the reader is disposed
    ''' </summary>
    ''' <param name="command"></param>
    ''' <param name="params"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ExecuteReader(ByRef command As String, ByRef params() As SqlParameter) As SqlDataReader
        _cmd.Parameters.Clear()
        _cmd.CommandText = command
        If Not params Is Nothing Then
            For Each p As SqlParameter In params
                _cmd.Parameters.Add(p)
            Next
        End If
        
        Dim ret As SqlDataReader
        _con.Open()
        'Must use this behaviour as parameter so the connection closes when we do not use the reader.
        'Note that the connection is private and we cannot access its value from outside the class.
        ret = _cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection)

        Return ret
    End Function

End Class
