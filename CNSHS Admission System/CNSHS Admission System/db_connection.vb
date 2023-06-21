Imports MySql.Data.MySqlClient

Module db_connection

    Public tax_rate As Double = 0.25
    Public myadocon, conn As New MySqlConnection
    Public cmd As New MySqlCommand
    Public cmdread As MySqlDataReader

    Public db_server = "'localhost'"
    Public db_uid = "'root'"
    Public db_pwd = "''"
    Public db_name = "'cnshs_admission_system'"
    Public strconn As String = "server =" & db_server & ";uid = " & db_uid & ";password = " & db_pwd & "; database =" & db_name & ""


    Public Sub readqueary(ByVal sql As String)
        Try
            With conn
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = strconn
                .Open()
            End With
            With cmd
                .Connection = conn
                .CommandText = sql
                cmdread = .ExecuteReader
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

End Module

