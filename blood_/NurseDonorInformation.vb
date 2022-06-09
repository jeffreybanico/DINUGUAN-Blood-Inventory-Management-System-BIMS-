Imports MySql.Data.MySqlClient
Public Class NurseDonorInformation
    Public Property userIdNurse As String
    Private Sub NurseDonorInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connect_to_DB()
        Dim mycommand As New MySqlCommand("select idbloodtype,bloodtype from bloodtype", DBConnection)
        Dim myadapter As New MySqlDataAdapter
        myadapter.SelectCommand = mycommand
        Dim table1 As New DataTable
        myadapter.Fill(table1)
        Dim row As DataRow = table1.NewRow
        row(0) = 0
        row(1) = "Select bloodtype"
        table1.Rows.InsertAt(row, 0)
        dropNDBloodType1.DataSource = table1
        dropNDBloodType1.DisplayMember = "Blood"
        dropNDBloodType1.ValueMember = "bloodtype"
        Disconnect_to_DB()

    End Sub

    Private Sub btnNExitDonor_Click(sender As Object, e As EventArgs) Handles btnNExitDonor.Click
        Me.Close()
        NurseDonorList.Close()
        NurseInterface.Show()
    End Sub

    Private Sub btnNBackDonor2_Click(sender As Object, e As EventArgs) Handles btnNBackDonor2.Click
        Me.Close()
        NurseDonorList.Show()
    End Sub

    Private Sub btnNDLoadDonors_Click(sender As Object, e As EventArgs) Handles btnNDLoadDonors.Click
        Me.gridNDonorList2.Rows.Clear()
        Dim strsql As String
        Dim mycommand As New MySqlCommand
        strsql = "select donor.iddonor, d_fname, d_lname, date_donated, d_quantitydonated, bloodtype.bloodtype, concat(u_fname,' ', u_lname)
            FROM donor 
            inner JOIN `blood` ON donor.iddonor = `blood`.iddonor
            inner JOIN `user` on `user`.iduser = donor.iduser
            inner join `bloodtype` on blood.idbloodtype = `bloodtype`.idbloodtype;"
        Connect_to_DB()
        With mycommand
            .Connection = DBConnection
            .CommandType = CommandType.Text
            .CommandText = strsql
        End With
        Dim myreader As MySqlDataReader
        myreader = mycommand.ExecuteReader
        While myreader.Read()

            Me.gridNDonorList2.Rows.Add(New Object() {myreader.Item("iddonor"), myreader.Item("d_fname"), myreader.Item("d_lname"), myreader.Item("bloodtype"), myreader.Item("date_donated"), myreader.Item("d_quantitydonated"), myreader.Item("concat(u_fname,' ', u_lname)")})
        End While
        Disconnect_to_DB()
    End Sub
    Private Sub btnNAddDonor_Click(sender As Object, e As EventArgs) Handles btnNAddDonor.Click
        Connect_to_DB()
        'insert to donor
        Dim mycommand As New MySqlCommand
        Dim strsql As String = "insert into donor(iduser ,d_fname, d_lname, date_donated, d_quantitydonated) values('" + userIdNurse + "','" & txtNDFName.Text & "','" & txtNDLName.Text & "',  current_timestamp(), '" & txtNQuantity1.Text & "')"
        Try
            mycommand.Connection = DBConnection
            mycommand.CommandText = strsql
            mycommand.ExecuteNonQuery()
            MsgBox("Successfully recorded!")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Disconnect_to_DB()
        'get donor id
        Connect_to_DB()
        Dim donorId As String
        Dim cmd As New MySqlCommand("select iddonor from donor where d_fname = @param1 and d_lname = @param2 and iduser = @param3 and d_quantitydonated = @param4;", DBConnection)
        cmd.Parameters.AddWithValue("@param1", txtNDFName.Text)
        cmd.Parameters.AddWithValue("@param2", txtNDLName.Text)
        cmd.Parameters.AddWithValue("@param3", userIdNurse)
        cmd.Parameters.AddWithValue("@param4", txtNQuantity1.Text)
        Dim myreader As MySqlDataReader = cmd.ExecuteReader
        If myreader.Read() Then
            Try
                donorId = myreader("iddonor")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
        Disconnect_to_DB()
        'get bloodtype id
        Connect_to_DB()
        Dim bloodtypeId As String
        Dim command As New MySqlCommand("select idbloodtype from bloodtype where bloodtype = @param1;", DBConnection)
        command.Parameters.AddWithValue("@param1", dropNDBloodType1.Text)

        myreader = command.ExecuteReader
        If myreader.Read() Then
            Try
                bloodtypeId = myreader("idbloodtype")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
        Disconnect_to_DB()
        'insert bloodtype id and donor id in blood table
        Connect_to_DB()
        strsql = "insert into blood(iddonor, idbloodtype) values('" + donorId + "','" + bloodtypeId + "')"
        Try
            mycommand.Connection = DBConnection
            mycommand.CommandText = strsql
            mycommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Disconnect_to_DB()

        Call btnNDLoadDonors_Click(sender, e)
    End Sub

    Private Sub gridNDonorList2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridNDonorList2.CellContentClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = gridNDonorList2.Rows(index)

        labelNDonorID2.Text = selectedRow.Cells(0).Value.ToString()
        txtNDFName.Text = selectedRow.Cells(1).Value.ToString()
        txtNDLName.Text = selectedRow.Cells(2).Value.ToString()
        dropNDBloodType1.Text = selectedRow.Cells(3).Value.ToString()
        labelNDateDonated.Text = selectedRow.Cells(4).Value.ToString()
        txtNQuantity1.Text = selectedRow.Cells(5).Value.ToString()
        labelNNurse.Text = selectedRow.Cells(6).Value.ToString()

        Dim newDataRow As DataGridViewRow
        newDataRow = gridNDonorList2.Rows(index)
        newDataRow.Cells(0).Value = labelNDonorID2.Text
        newDataRow.Cells(1).Value = txtNDFName.Text
        newDataRow.Cells(2).Value = txtNDLName.Text
        newDataRow.Cells(3).Value = dropNDBloodType1.Text
        newDataRow.Cells(4).Value = labelNDateDonated.Text
        newDataRow.Cells(5).Value = txtNQuantity1.Text
        newDataRow.Cells(6).Value = labelNNurse.Text
    End Sub

    Private Sub btnNDonorUpdate_Click(sender As Object, e As EventArgs) Handles btnNDonorUpdate.Click
        Dim strsql As String
        'get first the bloodtype ID
        Connect_to_DB()
        Dim bloodType As Integer
        Dim mycommand As New MySqlCommand("select idbloodtype from bloodtype where bloodtype = @param1", DBConnection)
        mycommand.Parameters.AddWithValue("@param1", dropNDBloodType1.Text)
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
                    `d_fname` = '" & txtNDFName.Text & "',
                    `d_lname` = '" & txtNDLName.Text & "',
                    `d_quantitydonated` = '" & txtNQuantity1.Text & "'
                WHERE
                    donor.iddonor ='" & labelNDonorID2.Text & "'"
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
        cmd.Parameters.AddWithValue("@param1", labelNDonorID2.Text)
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
        Call btnNDLoadDonors_Click(sender, e)
    End Sub

    Private Sub btnNDelete_Click(sender As Object, e As EventArgs) Handles btnNDelete.Click
        Dim strsql As String
        'get first the bloodtype ID
        Connect_to_DB()
        Dim bloodType As Integer
        Dim mycommand As New MySqlCommand("select idbloodtype from bloodtype where bloodtype = @param1", DBConnection)
        mycommand.Parameters.AddWithValue("@param1", dropNDBloodType1.Text)
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
                        donor.iddonor = '" & labelNDonorID2.Text & "'"
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
        'delete blood kasama na dito yung triggers

        strsql = "DELETE FROM `blood_msdb`.`blood` WHERE (`iddonor` = '" & labelNDonorID2.Text & "');"
        Connect_to_DB()
        Try
            mycommand.Connection = DBConnection
            mycommand.CommandText = strsql
            mycommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Disconnect_to_DB()
        MessageBox.Show("Record Deleted")
        Call btnNDLoadDonors_Click(sender, e)
    End Sub
    Private Sub btnClearNDonInfo_Click(sender As System.Object,
                              e As System.EventArgs) Handles btnNClearDonInfo.Click
        clear_ALL()
    End Sub
    Private Sub clear_ALL()
        Dim ctrl As Control = Me.GetNextControl(Me, True)
        Do Until ctrl Is Nothing
            If TypeOf ctrl Is TextBox Then
                DirectCast(ctrl, TextBox).Clear()
            ElseIf TypeOf ctrl Is Label Then
                labelNDonorID2.Text = ""
                labelNDateDonated.Text = ""
                labelNNurse.Text = ""
            ElseIf TypeOf ctrl Is ComboBox Then
                Dim cbo = DirectCast(ctrl, ComboBox)
                cbo.SelectedIndex = -1
            End If
            ctrl = Me.GetNextControl(ctrl, True)
        Loop
    End Sub
End Class