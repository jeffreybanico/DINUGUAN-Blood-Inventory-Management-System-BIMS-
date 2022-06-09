Imports MySql.Data.MySqlClient
Public Class NurseRequest
    Private Sub btnNBack_Click(sender As Object, e As EventArgs) Handles btnNBack.Click
        Me.Close()
        NurseInterface.Show()
    End Sub
    Private Sub btnNEditRequest_Click(sender As Object, e As EventArgs) Handles btnNEditRequest.Click
        Me.Close()
        NurseRequestInformation.Show()
    End Sub
    Private Sub btnClearNRequest_Click(sender As System.Object,
                              e As System.EventArgs) Handles btnClearNRequest.Click
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

    Private Sub dropNStatus_TextChanged(sender As Object, e As EventArgs) Handles dropNStatus.SelectedIndexChanged
        Dim drop As String = dropNStatus.Text

        If (drop = "All") Then
            Me.gridNRequestList.Rows.Clear()
            Dim strsql As String
            Dim mycommand As New MySqlCommand
            strsql = "Select r_fname, r_lname, bloodtype.bloodtype, r_quantityrequest , r_address, concat(`user`.u_fname, "" "", `user`.u_lname) as attending_nurse, r_status 
                    from request
                    inner join bloodtype on request.idbloodtype = bloodtype.idbloodtype
                    inner join `user` on `user`.iduser = request.iduser"
            Connect_to_DB()
            With mycommand
                .Connection = DBConnection
                .CommandType = CommandType.Text
                .CommandText = strsql
            End With
            Dim myreader As MySqlDataReader
            myreader = mycommand.ExecuteReader
            While myreader.Read()
                Me.gridNRequestList.Rows.Add(New Object() {myreader.Item("r_fname"), myreader.Item("r_lname"), myreader.Item("bloodtype"), myreader.Item("r_quantityrequest"), myreader.Item("r_address"), myreader.Item("attending_nurse"), myreader.Item("r_status")})
            End While
            Disconnect_to_DB()
        Else
            Me.gridNRequestList.Rows.Clear()
            Dim strsql As String
            Dim mycommand As New MySqlCommand
            strsql = "Select r_fname, r_lname, bloodtype.bloodtype, r_quantityrequest , r_address, concat(`user`.u_fname, "" "", `user`.u_lname) as attending_nurse, r_status 
                    from request
                    inner join bloodtype on request.idbloodtype = bloodtype.idbloodtype
                    inner join `user` on `user`.iduser = request.iduser
                    where r_status ='" & drop & "'"
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
                    Me.gridNRequestList.Rows.Add(New Object() {myreader.Item("r_fname"), myreader.Item("r_lname"), myreader.Item("bloodtype"), myreader.Item("r_quantityrequest"), myreader.Item("r_address"), myreader.Item("attending_nurse"), myreader.Item("r_status")})
                End While
                Disconnect_to_DB()
            End If
        End If
    End Sub

    Private Sub btnNSearchRequest_Click(sender As Object, e As EventArgs) Handles btnNSearchRequest.Click
        Me.gridNRequestList.Rows.Clear()
        Dim strsql As String
        Dim mycommand As New MySqlCommand

        If Me.dropNSearchRequest.Text = "All" Or Me.dropNSearchRequest.SelectedIndex = -1 Then
            strsql = "Select r_fname, r_lname, bloodtype.bloodtype, r_quantityrequest, r_quantityrequest , r_address, concat(`user`.u_fname, "" "", `user`.u_lname) as attending_nurse, r_status 
                    from request
                    inner join bloodtype on request.idbloodtype = bloodtype.idbloodtype
                    inner join `user` on `user`.iduser = request.iduser
                    where '" _
                     & Me.txtNSearchRequest.Text _
                     & "' in (r_fname, r_lname, bloodtype.bloodtype, r_quantityrequest, r_address, attending_nurse, r_status)"
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
                    Me.gridNRequestList.Rows.Add(New Object() {myreader.Item("r_fname"), myreader.Item("r_lname"), myreader.Item("bloodtype"), myreader.Item("r_quantityrequest"), myreader.Item("r_address"), myreader.Item("attending_nurse"), myreader.Item("r_status")})
                End While
                Disconnect_to_DB()
            Else
                MessageBox.Show("No records found")
            End If

        Else
            Dim drop_search_val As String

            Select Case Me.dropNSearchRequest.Text
                Case "Last Name"
                    drop_search_val = "r_lname"
                Case "First Name"
                    drop_search_val = "r_fname"
                Case Else
                    drop_search_val = "bloodtype"
            End Select

            strsql = "Select r_fname, r_lname, bloodtype.bloodtype, r_quantityrequest, r_address, concat(`user`.u_fname, "" "", `user`.u_lname) as attending_nurse, r_status 
                    from request
                    inner join bloodtype on request.idbloodtype = bloodtype.idbloodtype
                    inner join `user` on `user`.iduser = request.iduser where " _
                     & drop_search_val _
                     & " like '" _
                     & Me.txtNSearchRequest.Text _
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
                Me.gridNRequestList.Rows.Add(New Object() {myreader.Item("r_fname"), myreader.Item("r_lname"), myreader.Item("bloodtype"), myreader.Item("r_quantityrequest"), myreader.Item("r_address"), myreader.Item("attending_nurse"), myreader.Item("r_status")})
            End While
            Disconnect_to_DB()
        End If
    End Sub
    Private Sub btnNRequest_Click(sender As Object, e As EventArgs) Handles btnNRequest.Click
        Me.gridNRequestList.Rows.Clear()
        Dim strsql As String
        Dim mycommand As New MySqlCommand
        strsql = "Select r_fname, r_lname, bloodtype.bloodtype, r_quantityrequest, r_address, concat(`user`.u_fname, "" "", `user`.u_lname) as attending_nurse, r_status 
                    from request
                    inner join bloodtype on request.idbloodtype = bloodtype.idbloodtype
                    inner join `user` on `user`.iduser = request.iduser"
        Connect_to_DB()
        With mycommand
            .Connection = DBConnection
            .CommandType = CommandType.Text
            .CommandText = strsql
        End With
        Dim myreader As MySqlDataReader
        myreader = mycommand.ExecuteReader
        While myreader.Read()
            Me.gridNRequestList.Rows.Add(New Object() {myreader.Item("r_fname"), myreader.Item("r_lname"), myreader.Item("bloodtype"), myreader.Item("r_quantityrequest"), myreader.Item("r_address"), myreader.Item("attending_nurse"), myreader.Item("r_status")})
        End While
        Disconnect_to_DB()
    End Sub

    Private Sub NurseRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class