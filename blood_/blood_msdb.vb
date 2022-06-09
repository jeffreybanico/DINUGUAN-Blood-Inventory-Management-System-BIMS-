Imports MySql.Data.MySqlClient
Module blood_msdb
    Public DBConnection As New MySqlConnection

    Public Sub Connect_to_DB()
        Dim DBConnectionstring As String = "Server=localhost;Uid=root;Pwd='006381';Database=blood_msdb;"
        With DBConnection
            Try
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = DBConnectionstring
                .Open()
            Catch ex As MySqlException
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Connection Error")
                Call Disconnect_to_DB()
            End Try
        End With
    End Sub
    Public Sub Disconnect_to_DB()
        With DBConnection
            .Close()
            .Dispose()

        End With
    End Sub
End Module
