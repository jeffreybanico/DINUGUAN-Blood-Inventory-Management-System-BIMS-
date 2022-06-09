Imports MySql.Data.MySqlClient
Public Class NurseDonorList

    Private Sub btnNEditDonor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNEditDonor.Click
        Me.Hide()
        NurseDonorInformation.Show()
    End Sub
    Private Sub btnClearNDonor_Click(sender As System.Object,
                              e As System.EventArgs) Handles btnClearNDonor.Click
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
    Private Sub btnDonorList_Click(sender As Object, e As EventArgs) Handles btnNDonorList.Click
        Me.gridNDonorList.Rows.Clear()
        Dim strsql As String
        Dim mycommand As New MySqlCommand
        strsql = "select donor.iddonor, d_fname, d_lname, bloodtype.bloodtype, d_quantitydonated, date_donated
                    FROM donor 
                    inner JOIN `blood` ON donor.iddonor = `blood`.iddonor
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
            Me.gridNDonorList.Rows.Add(New Object() {myreader.Item("iddonor"), myreader.Item("d_fname"), myreader.Item("d_lname"), myreader.Item("bloodtype"), myreader.Item("d_quantitydonated"), myreader.Item("date_donated")})
        End While
        Disconnect_to_DB()
    End Sub
    Private Sub btnNDonorList_Click(sender As Object, e As EventArgs) Handles btnNDonorList.Click
        Load_ndonors()
    End Sub
    Private Sub Load_ndonors()
        Me.gridNDonorList.Rows.Clear()
        Dim strsql As String
        Dim mycommand As New MySqlCommand
        strsql = "select donor.iddonor, d_fname, d_lname, bloodtype.bloodtype, d_quantitydonated, date_donated
                    FROM donor 
                    inner JOIN `blood` ON donor.iddonor = `blood`.iddonor
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
            Me.gridNDonorList.Rows.Add(New Object() {myreader.Item("iddonor"), myreader.Item("d_fname"), myreader.Item("d_lname"), myreader.Item("bloodtype"), myreader.Item("d_quantitydonated"), myreader.Item("date_donated")})
        End While
        Disconnect_to_DB()
    End Sub
    Private Sub dropNBType1_TextChanged(sender As Object, e As EventArgs) Handles dropNBType1.SelectedIndexChanged
        Dim drop As String = dropNBType1.Text

        If (drop = "All") Then
            Load_ndonors()
        Else
            Me.gridNDonorList.Rows.Clear()
            Dim strsql As String
            Dim mycommand As New MySqlCommand
            strsql = "select donor.iddonor, d_fname, d_lname, bloodtype.bloodtype, d_quantitydonated, date_donated
                    FROM donor 
                    inner JOIN `blood` ON donor.iddonor = `blood`.iddonor
                    inner join `bloodtype` on blood.idbloodtype = `bloodtype`.idbloodtype where bloodtype.bloodtype ='" & drop & "'"
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
                    Me.gridNDonorList.Rows.Add(New Object() {myreader.Item("iddonor"), myreader.Item("d_fname"), myreader.Item("d_lname"), myreader.Item("bloodtype"), myreader.Item("d_quantitydonated"), myreader.Item("date_donated")})
                End While
                Disconnect_to_DB()
            End If
        End If
    End Sub

    Private Sub txtSearchNDonor_TextChanged(sender As Object, e As EventArgs) Handles txtNSearchDonor.TextChanged

    End Sub

    Private Sub dropSearchNDonor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dropNSearchDonor.SelectedIndexChanged

    End Sub

    Private Sub btnNSearchDonor_Click(sender As Object, e As EventArgs) Handles btnNSearchDonor.Click
        Me.gridNDonorList.Rows.Clear()
        Dim strsql As String
        Dim mycommand As New MySqlCommand

        If Me.dropNSearchDonor.Text = "All" Or Me.dropNSearchDonor.SelectedIndex = -1 Then
            strsql = "select donor.iddonor, d_fname, d_lname, bloodtype.bloodtype, d_quantitydonated, date_donated
                    FROM donor 
                    inner JOIN `blood` ON donor.iddonor = `blood`.iddonor
                    inner join `bloodtype` on blood.idbloodtype = `bloodtype`.idbloodtype where '" _
                     & Me.txtNSearchDonor.Text _
                     & "' in (donor.iddonor, d_fname, d_lname, bloodtype.bloodtype, d_quantitydonated, date_donated) "
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
                    Me.gridNDonorList.Rows.Add(New Object() {myreader.Item("iddonor"), myreader.Item("d_fname"), myreader.Item("d_lname"), myreader.Item("bloodtype"), myreader.Item("d_quantitydonated"), myreader.Item("date_donated")})
                End While
                Disconnect_to_DB()
            Else
                MessageBox.Show("No records found")
            End If

        Else
            Dim drop_search_val As String

            Select Case Me.dropNSearchDonor.Text
                Case "Last Name"
                    drop_search_val = "d_lname"
                Case "First Name"
                    drop_search_val = "d_fname"
                Case Else
                    drop_search_val = "date_donated"
            End Select

            strsql = "select donor.iddonor, d_fname, d_lname, bloodtype.bloodtype, d_quantitydonated, date_donated
                    FROM donor 
                    inner JOIN `blood` ON donor.iddonor = `blood`.iddonor
                    inner join `bloodtype` on blood.idbloodtype = `bloodtype`.idbloodtype where " _
                     & drop_search_val _
                     & " like '" _
                     & Me.txtNSearchDonor.Text _
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
                Me.gridNDonorList.Rows.Add(New Object() {myreader.Item("iddonor"), myreader.Item("d_fname"), myreader.Item("d_lname"), myreader.Item("bloodtype"), myreader.Item("d_quantitydonated"), myreader.Item("date_donated")})
            End While
            Disconnect_to_DB()
        End If
    End Sub

    Private Sub NurseDonorList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        NurseInterface.Show()
    End Sub
End Class