Imports MySql.Data.MySqlClient
Public Class userLog
    Private Sub loadLog_Click(sender As Object, e As EventArgs) Handles loadLog.Click
        Me.gridLogView.Rows.Clear()
        Dim strsql As String
        Dim mycommand As New MySqlCommand
        strsql = "select idlog, u_fname, u_lname, activity, datetimelog
                    From log 
                    LEFT Join `user` On log.iduser = `user`.iduser
                   Where log.iduser =`user`.iduser;"
        Connect_to_DB()
        With mycommand
            .Connection = DBConnection
            .CommandType = CommandType.Text
            .CommandText = strsql
        End With
        Dim myreader As MySqlDataReader
        myreader = mycommand.ExecuteReader
        While myreader.Read()

            Me.gridLogView.Rows.Add(New Object() {myreader.Item("idlog"), myreader.Item("u_fname"), myreader.Item("u_lname"), myreader.Item("activity"), myreader.Item("datetimelog")})
        End While
        Disconnect_to_DB()

    End Sub
    Private Sub btnClearLog_Click(sender As System.Object,
                              e As System.EventArgs) Handles btnClearLog.Click
        clear_ALL()
    End Sub
    Private Sub clear_ALL()
        Dim ctrl As Control = Me.GetNextControl(Me, True)
        Do Until ctrl Is Nothing
            If TypeOf ctrl Is TextBox Then
                DirectCast(ctrl, TextBox).Clear()
            ElseIf TypeOf ctrl Is ComboBox Then
                Dim cbo = DirectCast(ctrl, ComboBox)
                cbo.SelectedIndex = -1
            End If
            ctrl = Me.GetNextControl(ctrl, True)
        Loop
    End Sub
    Private Sub txtSearchLog_TextChanged(sender As Object, e As EventArgs) Handles txtSearchLog.TextChanged

    End Sub

    Private Sub dropSearchLog_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dropSearchLog.SelectedIndexChanged

    End Sub

    Private Sub btnSearchLog_Click(sender As Object, e As EventArgs) Handles btnSearchLog.Click
        Me.gridLogView.Rows.Clear()
        Dim strsql As String
        Dim mycommand As New MySqlCommand

        If Me.dropSearchLog.Text = "All" Or Me.dropSearchLog.SelectedIndex = -1 Then
            strsql = "select idlog, u_fname, u_lname, activity, datetimelog
                    From log 
                    LEFT Join `user` On log.iduser = `user`.iduser where '" _
                     & Me.txtSearchLog.Text _
                     & "' in (idlog, u_fname, u_lname, activity, datetimelog) "
            Connect_to_DB()
            With mycommand
                .Connection = DBConnection
                .CommandType = CommandType.Text
                .CommandText = strsql
            End With
            Dim myreader As MySqlDataReader
            myreader = mycommand.ExecuteReader
            If myreader.HasRows Then
                While myreader.Read()
                    Me.gridLogView.Rows.Add(New Object() {myreader.Item("idlog"), myreader.Item("u_fname"), myreader.Item("u_lname"), myreader.Item("activity"), myreader.Item("datetimelog")})
                End While
                Disconnect_to_DB()
            Else
                MessageBox.Show("No records found")
            End If

        Else
            Dim drop_search_val As String

            Select Case Me.dropSearchLog.Text
                Case "Last Name"
                    drop_search_val = "u_lname"
                Case "First Name"
                    drop_search_val = "u_fname"
                Case Else
                    drop_search_val = "activity"
            End Select

            strsql = "select idlog, u_fname, u_lname, activity, datetimelog
                    From log 
                    LEFT Join `user` On log.iduser = `user`.iduser where " _
                     & drop_search_val _
                     & " like '" _
                     & Me.txtSearchLog.Text _
                     & "'"
            Connect_to_DB()
            With mycommand
                .Connection = DBConnection
                .CommandType = CommandType.Text
                .CommandText = strsql
            End With
            Dim myreader As MySqlDataReader
            myreader = mycommand.ExecuteReader

            While myreader.Read()
                Me.gridLogView.Rows.Add(New Object() {myreader.Item("idlog"), myreader.Item("u_fname"), myreader.Item("u_lname"), myreader.Item("activity"), myreader.Item("datetimelog")})
            End While
            Disconnect_to_DB()
        End If
    End Sub

    Private Sub btnBackLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackLog.Click
        Me.Close()
        AdminInterface.Show()
    End Sub

    Private Sub userLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class