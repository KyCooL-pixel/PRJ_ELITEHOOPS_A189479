Module mod_globals_a189479
    Public githubLink As String = "https://github.com/KyCooL-pixel/PRJ_ELITEHOOPS_A189479"
    Public connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DB_ELITEHOOPS_A189479.accdb;Persist Security Info=False;"
    Public connectionString2 As New OleDb.OleDbConnection(connectionString)
    Public Function run_sql_query(mysql As String) As DataTable
        Dim mydatatable As New DataTable
        Dim myreader As New OleDb.OleDbDataAdapter(mysql, connectionString)
        Try
            myreader.Fill(mydatatable)
        Catch ex As Exception
            Beep()
            MsgBox("There is an error:" & vbCrLf & vbCrLf & ex.Message)
        End Try
        Return mydatatable
    End Function
    Public Sub run_sql_command(thissql As String)
        Dim mywriter As New OleDb.OleDbCommand(thissql, connectionString2)
        Try
            mywriter.Connection.Open()
            mywriter.ExecuteNonQuery()
            mywriter.Connection.Close()
        Catch ex As Exception
            Beep()
            MsgBox("There is a mistake in the data you entered, as shown below" & vbCrLf & vbCrLf & ex.Message)
            mywriter.Connection.Close()
        End Try
    End Sub
End Module
