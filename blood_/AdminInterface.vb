Imports MySql.Data.MySqlClient
Public Class AdminInterface
    Public Property userIdAdmin As String
    Public Property fname As String
    Public Property lname As String
    Public Property uname As String
    Private Sub btnDonorList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDonorList.Click
        AdminDonorList.Show()
    End Sub
    Private Sub btnBloodInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBloodInventory.Click
        AdminBloodInventory.Show()
    End Sub
    Private Sub btnRequests_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRequests.Click
        AdminRequest.Show()
    End Sub
    Private Sub btnUserList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserList.Click
        UserList.Show()
    End Sub
    Private Sub btnUserLogs_CLick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUserLogs.Click
        userLog.Show()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Connect_to_DB()
        'query ng pag insert ng credentials logs ni user sa database
        Dim strsql As String = "insert into log values(uuid_short(), '" + userIdAdmin + "','Logout', current_timestamp())"
        Dim mycommand As New MySqlCommand
        Try
            mycommand.Connection = DBConnection
            mycommand.CommandText = strsql
            mycommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Me.Close()
        LoginForm.Close()
        Disconnect_to_DB()
    End Sub
    Private Sub AdminInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = fname + " " + lname
    End Sub

    Private Sub btnBackupDB_Click(sender As Object, e As EventArgs) Handles btnBackupDB.Click
        backupForm.Show()
    End Sub

    Private Sub btnRestoreDB_Click(sender As Object, e As EventArgs) Handles btnRestoreDB.Click
        restoreForm.Show()
    End Sub
End Class