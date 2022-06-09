Imports MySql.Data.MySqlClient
Public Class AdminRequestInformation

    Private Sub gridRequestList2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridRequestList2.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = gridRequestList2.Rows(index)

        labelRID.Text = selectedRow.Cells(0).Value.ToString()
        txtRFName.Text = selectedRow.Cells(1).Value.ToString()
        txtRLName.Text = selectedRow.Cells(2).Value.ToString()
        txtRAddress.Text = selectedRow.Cells(3).Value.ToString()
        dropRBloodType.Text = selectedRow.Cells(4).Value.ToString()
        txtRQuantity1.Text = selectedRow.Cells(5).Value.ToString()
        Label1ReqStat.Text = selectedRow.Cells(6).Value.ToString()
        labelRNurse.Text = selectedRow.Cells(7).Value.ToString()

        Dim newDataRow As DataGridViewRow
        newDataRow = gridRequestList2.Rows(index)
        newDataRow.Cells(0).Value = labelRID.Text
        newDataRow.Cells(1).Value = txtRFName.Text
        newDataRow.Cells(2).Value = txtRLName.Text
        newDataRow.Cells(3).Value = txtRAddress.Text
        newDataRow.Cells(4).Value = dropRBloodType.Text
        newDataRow.Cells(5).Value = txtRQuantity1.Text
        newDataRow.Cells(6).Value = Label1ReqStat.Text
        newDataRow.Cells(7).Value = labelRNurse.Text
    End Sub

    Private Sub btnRLoadRequests_Click(sender As Object, e As EventArgs) Handles btnRLoadRequests.Click
        Me.gridRequestList2.Rows.Clear()
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
            Me.gridRequestList2.Rows.Add(New Object() {myreader.Item("idrequest"), myreader.Item("r_fname"), myreader.Item("r_lname"), myreader.Item("r_address"), myreader.Item("bloodtype"), myreader.Item("r_quantityrequest"), myreader.Item("r_status"), myreader.Item("attending_nurse")})
        End While
        Disconnect_to_DB()
    End Sub
    Private Sub btnBackRequest2_Click(sender As Object, e As EventArgs) Handles btnBackRequest2.Click
        Me.Close()
        AdminRequest.Show()
    End Sub

    Private Sub btnExitRequest_Click(sender As Object, e As EventArgs) Handles btnExitRequest.Click
        Me.Close()
        AdminRequest.Close()
        AdminInterface.Show()
    End Sub
    Private Sub AdminRequestInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnRequestUpdate_Click(sender As Object, e As EventArgs) Handles btnRequestUpdate.Click
        Dim strsql As String
        'get first the bloodtype ID
        Connect_to_DB()
        Dim bloodType As String
        Dim mycommand As New MySqlCommand("select idbloodtype from bloodtype where bloodtype = @param1", DBConnection)
        mycommand.Parameters.AddWithValue("@param1", dropRBloodType.Text)
        Dim myreader As MySqlDataReader = mycommand.ExecuteReader
        If myreader.Read() Then
            Try
                bloodType = myreader("idbloodtype")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
        Disconnect_to_DB()
        'update reqeust
        strsql = "UPDATE `blood_msdb`.`request` 
                  SET 
                    `idbloodtype` = '" + bloodType + "',
                    `r_fname` = '" & txtRFName.Text & "',
                    `r_lname` = '" & txtRLName.Text & "',
                    `r_address`  = '" & txtRAddress.Text & "',
                    `r_quantityrequest` = '" & txtRQuantity1.Text & "'
                WHERE
                    idrequest = '" & labelRID.Text & "';"
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
        Call btnRLoadRequests_Click(sender, e)
    End Sub

    Private Sub btnADelete_Click(sender As Object, e As EventArgs) Handles btnADelete.Click
        Dim strsql As String
        strsql = "DELETE FROM `blood_msdb`.`request` WHERE (`idrequest` = '" & labelRID.Text & "');"
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
        Call btnRLoadRequests_Click(sender, e)
    End Sub
End Class