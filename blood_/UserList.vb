Imports MySql.Data.MySqlClient 'NEED TO ADD "MYSQL.DATA.DLL" AS PROJECT REFERENCE
Public Class UserList
    Private Sub btnEdit1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit1.Click
        Me.Hide()
        UserInformation.Show()
    End Sub
    Private Sub btnLoadUsers_Click(sender As Object, e As EventArgs) Handles btnLoadUsers.Click
        Load_users()
    End Sub
    Private Sub btnClearUser_Click(sender As System.Object,
                              e As System.EventArgs) Handles btnClearUser.Click
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
    Private Sub Load_users()
        Me.gridUserList.Rows.Clear()
        Dim strsql As String
        Dim mycommand As New MySqlCommand
        strsql = "Select u_username, u_lname, u_fname, u_type, u_phone_no, u_email_add from user"
        Connect_to_DB()
        With mycommand
            .Connection = DBConnection
            .CommandType = CommandType.Text
            .CommandText = strsql
        End With
        Dim myreader As MySqlDataReader
        myreader = mycommand.ExecuteReader
        While myreader.Read()
            Me.gridUserList.Rows.Add(New Object() {myreader.Item("u_username"), myreader.Item("u_lname"), myreader.Item("u_fname"), myreader.Item("u_type"), myreader.Item("u_phone_no"), myreader.Item("u_email_add")})
        End While
        Disconnect_to_DB()
    End Sub
    Private Sub dropUserType1_TextChanged(sender As Object, e As EventArgs) Handles dropUserType1.SelectedIndexChanged
        Dim drop As String = dropUserType1.Text

        If (drop = "All") Then
            Load_users()
        Else
            Me.gridUserList.Rows.Clear()
            Dim strsql As String
            Dim mycommand As New MySqlCommand
            strsql = "Select u_username, u_lname, u_fname, u_type, u_phone_no, u_email_add from user where u_type ='" & drop & "'"
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
                    Me.gridUserList.Rows.Add(New Object() {myreader.Item("u_username"), myreader.Item("u_lname"), myreader.Item("u_fname"), myreader.Item("u_type"), myreader.Item("u_phone_no"), myreader.Item("u_email_add")})
                End While
                Disconnect_to_DB()
            End If
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

    End Sub

    Private Sub dropSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dropSearch.SelectedIndexChanged

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Me.gridUserList.Rows.Clear()
        Dim strsql As String
        Dim mycommand As New MySqlCommand

        If Me.dropSearch.Text = "All" Or Me.dropSearch.SelectedIndex = -1 Then
            strsql = "Select u_username, u_lname, u_fname, u_type, u_phone_no, u_email_add from user where '" _
                     & Me.txtSearch.Text _
                     & "' in (u_username, u_lname, u_fname, u_type, u_phone_no, u_email_add) "
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
                    Me.gridUserList.Rows.Add(New Object() {myreader.Item("u_username"), myreader.Item("u_lname"), myreader.Item("u_fname"), myreader.Item("u_type"), myreader.Item("u_phone_no"), myreader.Item("u_email_add")})
                End While
                Disconnect_to_DB()
            Else
                MessageBox.Show("No records found")
            End If

        Else
            Dim drop_search_val As String

            Select Case Me.dropSearch.Text
                Case "Last Name"
                    drop_search_val = "u_lname"
                Case "First Name"
                    drop_search_val = "u_fname"
                Case Else
                    drop_search_val = "u_email_add"
            End Select

            strsql = "Select u_username, u_lname, u_fname, u_type, u_phone_no, u_email_add from user where " _
                     & drop_search_val _
                     & " like '" _
                     & Me.txtSearch.Text _
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
                Me.gridUserList.Rows.Add(New Object() {myreader.Item("u_username"), myreader.Item("u_lname"), myreader.Item("u_fname"), myreader.Item("u_type"), myreader.Item("u_phone_no"), myreader.Item("u_email_add")})
            End While
            Disconnect_to_DB()
        End If
    End Sub

    Private Sub btnExit1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack1.Click
        Me.Close()
        AdminInterface.Show()
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ListOfUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub gridUserList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridUserList.CellContentClick

    End Sub
End Class