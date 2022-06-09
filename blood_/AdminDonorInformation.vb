Imports MySql.Data.MySqlClient
Public Class AdminDonorInformation

    Private Sub AdminDonorInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub gridDonorList2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridDonorList2.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = gridDonorList2.Rows(index)

        labelDonorID2.Text = selectedRow.Cells(0).Value.ToString()
        txtDFName.Text = selectedRow.Cells(1).Value.ToString()
        txtDLName.Text = selectedRow.Cells(2).Value.ToString()
        dropDBloodType1.Text = selectedRow.Cells(3).Value.ToString()
        labelADateDonated.Text = selectedRow.Cells(4).Value.ToString()
        txtAQuantity1.Text = selectedRow.Cells(5).Value.ToString()
        labelANurse.Text = selectedRow.Cells(6).Value.ToString()

        Dim newDataRow As DataGridViewRow
        newDataRow = gridDonorList2.Rows(index)
        newDataRow.Cells(0).Value = labelDonorID2.Text
        newDataRow.Cells(1).Value = txtDFName.Text
        newDataRow.Cells(2).Value = txtDLName.Text
        newDataRow.Cells(3).Value = dropDBloodType1.Text
        newDataRow.Cells(4).Value = labelADateDonated.Text
        newDataRow.Cells(5).Value = txtAQuantity1.Text
        newDataRow.Cells(6).Value = labelANurse.Text
    End Sub

    Private Sub btnDLoadDonors_Click(sender As Object, e As EventArgs) Handles btnDLoadDonors.Click
        Me.gridDonorList2.Rows.Clear()
        Dim strsql As String
        Dim mycommand As New MySqlCommand
        strsql = "select donor.iddonor, d_fname, d_lname,  bloodtype.bloodtype, date_donated,
                    d_quantitydonated, concat(u_fname,' ', u_lname)
                    FROM donor
                    inner JOIN blood ON donor.iddonor = `blood`.iddonor
                    inner JOIN user on `user`.iduser = donor.iduser
                    inner join bloodtype on blood.idbloodtype = `bloodtype`.idbloodtype;"
        Connect_to_DB()
        With mycommand
            .Connection = DBConnection
            .CommandType = CommandType.Text
            .CommandText = strsql
        End With
        Dim myreader As MySqlDataReader
        myreader = mycommand.ExecuteReader
        While myreader.Read()
            Me.gridDonorList2.Rows.Add(New Object() {myreader.Item("iddonor"), myreader.Item("d_fname"), myreader.Item("d_lname"), myreader.Item("bloodtype"), myreader.Item("date_donated"), myreader.Item("d_quantitydonated"), myreader.Item("concat(u_fname,' ', u_lname)")})
        End While
        Disconnect_to_DB()
    End Sub

    Private Sub btnDonorUpdate_Click(sender As Object, e As EventArgs) Handles btnDonorUpdate.Click
        Dim strsql As String
        'get first the bloodtype ID
        Connect_to_DB()
        Dim bloodType As Integer
        Dim mycommand As New MySqlCommand("select idbloodtype from bloodtype where bloodtype = @param1", DBConnection)
        mycommand.Parameters.AddWithValue("@param1", dropDBloodType1.Text)
        Dim myreader As MySqlDataReader = mycommand.ExecuteReader
        If myreader.Read() Then
            Try
                bloodType = myreader("idbloodtype")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
        Disconnect_to_DB()
        'update donor
        strsql = "UPDATE `blood_msdb`.`donor` 
                  SET 
                    `d_fname` = '" & txtDFName.Text & "',
                    `d_lname` = '" & txtDLName.Text & "',
                    `d_quantitydonated` = '" & txtAQuantity1.Text & "'
                WHERE
                    donor.iddonor ='" & labelDonorID2.Text & "'"
        Connect_to_DB()
        Try
            mycommand.Connection = DBConnection
            mycommand.CommandText = strsql
            mycommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Disconnect_to_DB()
        'get the blood id
        Connect_to_DB()
        Dim bloodId As Double
        Dim cmd As New MySqlCommand("SELECT 
                                        idblood
                                    FROM
                                        blood
                                            INNER JOIN
                                        donor ON blood.iddonor = donor.iddonor
                                    WHERE
                                        donor.iddonor = @param1", DBConnection)
        cmd.Parameters.AddWithValue("@param1", labelDonorID2.Text)
        myreader = cmd.ExecuteReader
        If myreader.Read() Then
            Try
                bloodId = myreader("idblood")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
        Disconnect_to_DB()
        'update blood table
        strsql = "UPDATE `blood_msdb`.`blood` 
                  SET 
                    `idbloodtype` = '" & bloodType & "'
                WHERE
                    blood.idblood = '" & bloodId & "';"
        Connect_to_DB()
        Try
            mycommand.Connection = DBConnection
            mycommand.CommandText = strsql
            mycommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Disconnect_to_DB()
        'query the inventory table
        strsql = "SELECT 
                        COUNT(bloodtype)
                    FROM
                        bloodtype;"
        Connect_to_DB()
        Dim numOfBloodtype As Integer
        mycommand.Connection = DBConnection
        mycommand.CommandText = strsql
        myreader = mycommand.ExecuteReader()
        If myreader.Read() Then
            Try
                numOfBloodtype = myreader("COUNT(bloodtype)")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
        'update all content of inventory table
        Dim count As Integer
        count = 1
        While count <= numOfBloodtype

            strsql = "SELECT 
                        SUM(d_quantitydonated)
                    FROM
                        donor
                            INNER JOIN
                        blood ON blood.iddonor = donor.iddonor
                            INNER JOIN
                        bloodtype ON blood.idbloodtype = bloodtype.idbloodtype
                            INNER JOIN
                        inventory ON bloodtype.idbloodtype = inventory.idbloodtype
                    WHERE
                        inventory.idinventory = '" & count & "';"
            Connect_to_DB()
            Dim sum As Integer = 0
            mycommand.Connection = DBConnection
            mycommand.CommandText = strsql
            myreader = mycommand.ExecuteReader()
            If myreader.Read() Then
                Try
                    If myreader("SUM(d_quantitydonated)") Is DBNull.Value Then
                        sum = 0
                    Else
                        sum = myreader("SUM(d_quantitydonated)")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical)
                End Try
            End If
            Disconnect_to_DB()
            'update to invnetory table
            strsql = "UPDATE `blood_msdb`.`inventory` 
                    SET 
                        `number_of_blood_added` = '" & sum & "'
                    WHERE
                        (`idinventory` = '" & count & "');"
            Connect_to_DB()
            Try
                mycommand.Connection = DBConnection
                mycommand.CommandText = strsql
                mycommand.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
            Disconnect_to_DB()
            count = count + 1
        End While
        MessageBox.Show("Record Updated")
        Call btnDLoadDonors_Click(sender, e)
    End Sub
    Private Sub btnClearADonorInfo_Click(sender As System.Object,
                              e As System.EventArgs)
        clear_ALL()
    End Sub
    Private Sub clear_ALL()
        Dim ctrl As Control = Me.GetNextControl(Me, True)
        Do Until ctrl Is Nothing
            If TypeOf ctrl Is TextBox Then
                DirectCast(ctrl, TextBox).Clear()
            ElseIf TypeOf ctrl Is Label Then
                labelDonorID2.Text = ""
                labelADateDonated.Text = ""
                labelANurse.Text = ""
            ElseIf TypeOf ctrl Is ComboBox Then
                Dim cbo = DirectCast(ctrl, ComboBox)
                cbo.SelectedIndex = -1
            End If
            ctrl = Me.GetNextControl(ctrl, True)
        Loop
    End Sub
    Private Sub btnBackDonor2_Click(sender As Object, e As EventArgs) Handles btnBackDonor2.Click
        Me.Close()
        AdminDonorList.Show()
    End Sub

    Private Sub btnExitDonor_Click(sender As Object, e As EventArgs) Handles btnExitDonor.Click
        Me.Close()
        AdminDonorList.Close()
        AdminInterface.Show()
    End Sub

    Private Sub btnADelete_Click(sender As Object, e As EventArgs) Handles btnADelete.Click
        Dim strsql As String
        'get first the bloodtype ID
        Connect_to_DB()
        Dim bloodType As Integer
        Dim mycommand As New MySqlCommand("select idbloodtype from bloodtype where bloodtype = @param1", DBConnection)
        mycommand.Parameters.AddWithValue("@param1", dropDBloodType1.Text)
        Dim myreader As MySqlDataReader = mycommand.ExecuteReader
        If myreader.Read() Then
            Try
                bloodType = myreader("idbloodtype")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
        Disconnect_to_DB()
        'new value
        strsql = "SELECT 
                        (number_of_blood_added - d_quantitydonated)
                    FROM
                        donor
                            INNER JOIN
                        blood ON blood.iddonor = donor.iddonor
                            INNER JOIN
                        inventory ON inventory.idbloodtype = blood.idbloodtype
                    WHERE
                        donor.iddonor = '" & labelDonorID2.Text & "'"
        Connect_to_DB()
        Dim diff As Integer = 0
        mycommand.Connection = DBConnection
        mycommand.CommandText = strsql
        myreader = mycommand.ExecuteReader()
        If myreader.Read() Then
            Try
                If myreader("(number_of_blood_added - d_quantitydonated)") Is DBNull.Value Then
                    diff = 0
                Else
                    diff = myreader("(number_of_blood_added - d_quantitydonated)")
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
        Disconnect_to_DB()
        'update inventory
        strsql = "UPDATE `blood_msdb`.`inventory` 
                    SET 
                        `number_of_blood_added` = '" & diff & "'
                    WHERE
                        (`idbloodtype` = '" & bloodType & "');"
        Connect_to_DB()
        Try
            mycommand.Connection = DBConnection
            mycommand.CommandText = strsql
            mycommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Disconnect_to_DB()
        'delete blood kasama na dito yung trigger
        strsql = "DELETE FROM `blood_msdb`.`blood` WHERE (`iddonor` = '" & labelDonorID2.Text & "');"
        Connect_to_DB()
        Try
            mycommand.Connection = DBConnection
            mycommand.CommandText = strsql
            mycommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Disconnect_to_DB()
        MsgBox("Successfully deleted!")
        Call btnDLoadDonors_Click(sender, e)
    End Sub
End Class
