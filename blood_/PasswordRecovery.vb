Imports MySql.Data.MySqlClient
Public Class PasswordRecovery
    Private Sub Confirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        Dim userId As String
        Connect_to_DB()
        Dim mycommand As New MySqlCommand("select iduser, u_password  from user where u_fname = @param1 and u_lname = @param2 and u_username = @param3 and u_pass_recovery = @param4 ", DBConnection)
        mycommand.Parameters.AddWithValue("@param1", txtfname.Text)
        mycommand.Parameters.AddWithValue("@param2", txtlname.Text)
        mycommand.Parameters.AddWithValue("@param3", txtusername.Text)
        mycommand.Parameters.AddWithValue("@param4", txtanimal.Text)
        Dim myreader As MySqlDataReader = mycommand.ExecuteReader
        If myreader.Read() Then
            userId = myreader("iduser")
            MsgBox(myreader("u_password"), MsgBoxStyle.Information, "Password")
        Else
            MsgBox("Account not exist!", MsgBoxStyle.Information, "Password")
        End If
        Disconnect_to_DB()
        Connect_to_DB()
        'query ng pag insert ng credentials logs ni user sa database
        Dim strsql As String = "insert into log values(uuid_short(), '" + userId + "','Password Recovery', current_timestamp())"
        Try
            mycommand.Connection = DBConnection
            mycommand.CommandText = strsql
            mycommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Disconnect_to_DB()

    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub PasswordRecovery_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class