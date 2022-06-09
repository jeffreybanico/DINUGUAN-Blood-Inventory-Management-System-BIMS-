Imports MySql.Data.MySqlClient
Public Class NurseRequestInformation
    Public Property userIdNurse As String
    Private Sub gridNRequestList2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridNRequestList2.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = gridNRequestList2.Rows(index)

        labelNRID.Text = selectedRow.Cells(0).Value.ToString()
        txtNRFName.Text = selectedRow.Cells(1).Value.ToString()
        txtNRLName.Text = selectedRow.Cells(2).Value.ToString()
        txtNRAddress.Text = selectedRow.Cells(3).Value.ToString()
        dropNRBloodType.Text = selectedRow.Cells(4).Value.ToString()
        txtNRQuantity1.Text = selectedRow.Cells(5).Value.ToString()
        labelRequestStat.Text = selectedRow.Cells(6).Value.ToString()
        labelNRNurse.Text = selectedRow.Cells(7).Value.ToString()

        Dim newDataRow As DataGridViewRow
        newDataRow = gridNRequestList2.Rows(index)
        newDataRow.Cells(0).Value = labelNRID.Text
        newDataRow.Cells(1).Value = txtNRFName.Text
        newDataRow.Cells(2).Value = txtNRLName.Text
        newDataRow.Cells(3).Value = txtNRAddress.Text
        newDataRow.Cells(4).Value = dropNRBloodType.Text
        newDataRow.Cells(5).Value = txtNRQuantity1.Text
        newDataRow.Cells(6).Value = labelRequestStat.Text
        newDataRow.Cells(7).Value = labelNRNurse.Text
    End Sub

    Private Sub btnNRLoadRequests_Click(sender As Object, e As EventArgs) Handles btnNRLoadRequests.Click
        Me.gridNRequestList2.Rows.Clear()
        Dim strsql As String
        Dim mycommand As New MySqlCommand
        strsql = "Select request.idrequest, r_fname, r_lname, r_address, bloodtype.bloodtype, r_quantityrequest, r_status, concat(`user`.u_fname, "" "", `user`.u_lname) as attending_nurse 
                    from request
                    inner join bloodtype on request.idbloodtype = bloodtype.idbloodtype
                    inner join `user` on `user`.iduser = request.iduser where r_status = 'Pending';"
        Connect_to_DB()
        With mycommand
            .Connection = DBConnection
            .CommandType = CommandType.Text
            .CommandText = strsql
        End With
        Dim myreader As MySqlDataReader
        myreader = mycommand.ExecuteReader
        While myreader.Read()
            Me.gridNRequestList2.Rows.Add(New Object() {myreader.Item("idrequest"), myreader.Item("r_fname"), myreader.Item("r_lname"), myreader.Item("r_address"), myreader.Item("bloodtype"), myreader.Item("r_quantityrequest"), myreader.Item("r_status"), myreader.Item("attending_nurse")})
        End While
        Disconnect_to_DB()
    End Sub
    Private Sub btnNBackRequest2_Click(sender As Object, e As EventArgs) Handles btnNBackRequest2.Click
        Me.Close()
        NurseRequest.Show()
    End Sub

    Private Sub btnNExitRequest_Click(sender As Object, e As EventArgs) Handles btnNExitRequest.Click
        Me.Close()
        NurseRequest.Close()
        NurseInterface.Show()
    End Sub

    Private Sub NurseRequestInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnNAddRequest_Click(sender As Object, e As EventArgs) Handles btnNAddRequest.Click
        Connect_to_DB()
        'insert to request table
        Dim bloodtypeId As String
        Dim mycommand As New MySqlCommand("select idbloodtype from bloodtype where bloodtype = @param1;", DBConnection)
        mycommand.Parameters.AddWithValue("@param1", dropNRBloodType.Text)
        Dim myreader As MySqlDataReader
        myreader = mycommand.ExecuteReader
        If myreader.Read() Then
            Try
                bloodtypeId = myreader("idbloodtype")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
        Disconnect_to_DB()
        Connect_to_DB()
        Dim strsql = "insert into request(idbloodtype, iduser, r_fname, r_lname, r_address,r_quantityrequest,r_status) values('" + bloodtypeId + "','" + userIdNurse + "','" & txtNRFName.Text & "','" & txtNRLName.Text & "','" & txtNRAddress.Text & "','" & txtNRQuantity1.Text & "', 'Pending');"
        Try
            mycommand.Connection = DBConnection
            mycommand.CommandText = strsql
            mycommand.ExecuteNonQuery()
            MsgBox("Successfully recorded!")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Disconnect_to_DB()
        Call btnNRLoadRequests_Click(sender, e)
    End Sub

    Private Sub btnNRequestUpdate_Click(sender As Object, e As EventArgs) Handles btnNRequestUpdate.Click
        Dim strsql As String
        'get first the bloodtype ID
        Connect_to_DB()
        Dim bloodType As String
        Dim mycommand As New MySqlCommand("select idbloodtype from bloodtype where bloodtype = @param1", DBConnection)
        mycommand.Parameters.AddWithValue("@param1", dropNRBloodType.Text)
        Dim myreader As MySqlDataReader = mycommand.ExecuteReader
        If myreader.Read() Then
            Try
                bloodType = myreader("idbloodtype")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
        Disconnect_to_DB()
        'update request table
        strsql = "UPDATE `blood_msdb`.`request` 
                  SET 
                    `idbloodtype` = '" + bloodType + "',
                    `r_fname` = '" & txtNRFName.Text & "',
                    `r_lname` = '" & txtNRLName.Text & "',
                    `r_address`  = '" & txtNRAddress.Text & "',
                    `r_quantityrequest` = '" & txtNRQuantity1.Text & "'
                WHERE
                    idrequest = '" & labelNRID.Text & "';"
        Connect_to_DB()
        Try
            mycommand.Connection = DBConnection
            mycommand.CommandText = strsql
            mycommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Disconnect_to_DB()
        MsgBox("Record Updated! ")
        Call btnNRLoadRequests_Click(sender, e)
    End Sub

    'Delete request
    Private Sub btnNRDelete_Click(sender As Object, e As EventArgs) Handles btnNRDelete.Click
        Dim strsql As String
        strsql = "DELETE FROM `blood_msdb`.`request` WHERE (`idrequest` = '" & labelNRID.Text & "');"
        Connect_to_DB()
        Dim mycommand As New MySqlCommand
        Try
            mycommand.Connection = DBConnection
            mycommand.CommandText = strsql
            mycommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Disconnect_to_DB()
        MsgBox("Successfully deleted!")
        Call btnNRLoadRequests_Click(sender, e)
    End Sub

    Private Sub btnGrantReq_Click(sender As Object, e As EventArgs) Handles btnGrantReq.Click
        'get first the bloodtype ID
        Connect_to_DB()
        Dim bloodType As String
        Dim mycommand As New MySqlCommand("select idbloodtype from bloodtype where bloodtype = @param1", DBConnection)
        mycommand.Parameters.AddWithValue("@param1", dropNRBloodType.Text)
        Dim myreader As MySqlDataReader = mycommand.ExecuteReader
        If myreader.Read() Then
            Try
                bloodType = myreader("idbloodtype")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
        Disconnect_to_DB()
        'get the stock
        Dim strsql As String
        Dim stock As Integer
        Connect_to_DB()
        strsql = "SELECT 
                    SUM(number_of_blood_added - number_of_request_granted)
                FROM
                    bloodtype
                        INNER JOIN
                    inventory ON inventory.idbloodtype = bloodtype.idbloodtype
                WHERE
                    bloodtype.idbloodtype = '" & bloodType & "';"
        Connect_to_DB()
        With mycommand
            .Connection = DBConnection
            .CommandType = CommandType.Text
            .CommandText = strsql
        End With
        myreader = mycommand.ExecuteReader
        While myreader.Read()
            stock = myreader("SUM(number_of_blood_added - number_of_request_granted)")
        End While
        Disconnect_to_DB()

        If (stock <= 0) Then
            MsgBox("No available blood Stock!")
        Else
            If (txtNRQuantity1.Text <= stock) Then
                'execute grant query and trigger here
                strsql = "UPDATE `blood_msdb`.`request` 
                  SET 
                    `r_status` = 'Granted'
                WHERE
                    idrequest = '" & labelNRID.Text & "';"
                Connect_to_DB()
                Try
                    mycommand.Connection = DBConnection
                    mycommand.CommandText = strsql
                    mycommand.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                End Try
                Disconnect_to_DB()
                MsgBox("Request Granted!")
            Else
                MsgBox("The inventory of " + dropNRBloodType.Text + " is running low.")
            End If
        End If
    End Sub

    Private Sub btnCancelReq_Click(sender As Object, e As EventArgs) Handles btnCancelReq.Click
        'Cancel request
        Dim mycommand As New MySqlCommand
        Dim strsql As String
        strsql = "UPDATE `blood_msdb`.`request` 
                  SET 
                    `r_status` = 'Cancel'
                WHERE
                    idrequest = '" & labelNRID.Text & "';"
        Connect_to_DB()
        Try
            mycommand.Connection = DBConnection
            mycommand.CommandText = strsql
            mycommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Disconnect_to_DB()
        MsgBox("Request Cancel!")
        Call btnNRLoadRequests_Click(sender, e)
    End Sub
    Private Sub btnClearAUserInfo_Click(sender As System.Object,
                              e As System.EventArgs) Handles btnNClearNReqInfo.Click
        clear_ALL()
    End Sub
    Private Sub clear_ALL()
        Dim ctrl As Control = Me.GetNextControl(Me, True)
        Do Until ctrl Is Nothing
            If TypeOf ctrl Is TextBox Then
                DirectCast(ctrl, TextBox).Clear()
            ElseIf TypeOf ctrl Is Label Then
                labelNRID.Text = ""
                labelRequestStat.Text = ""
                labelNRNurse.Text = ""
            ElseIf TypeOf ctrl Is ComboBox Then
                Dim cbo = DirectCast(ctrl, ComboBox)
                cbo.SelectedIndex = -1
            End If
            ctrl = Me.GetNextControl(ctrl, True)
        Loop
    End Sub
End Class