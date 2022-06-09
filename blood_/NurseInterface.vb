Imports MySql.Data.MySqlClient
Public Class NurseInterface
    Public Property userIdNurse As String
    Public Property nfname As String
    Public Property nlname As String
    Public Property nuname As String

    Private Sub btnDonorList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNDonorList.Click
        NurseDonorList.Show()
        NurseDonorInformation.userIdNurse = userIdNurse
    End Sub
    Private Sub btnBloodInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNBloodInventory.Click
        NursesBloodInventory.Show()
    End Sub
    Private Sub btnRequests_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNRequests.Click
        NurseRequest.Show()
    End Sub
    Private Sub StaffInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labelNName.Text = nfname + " " + nlname
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Connect_to_DB()
        'query ng pag insert ng credentials logs ni user sa database
        Dim strsql As String = "insert into log values(uuid_short(), '" + userIdNurse + "','Logout', current_timestamp())"
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
End Class