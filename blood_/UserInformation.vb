Imports MySql.Data.MySqlClient
Public Class UserInformation
    Private Sub btnAdd2_Click(sender As Object, e As EventArgs) Handles btnAdd2.Click
        Dim strsql As String = "insert into user (u_fname, u_lname, u_phone_no, u_email_add, u_username, u_password, u_pass_recovery, u_type) values(' " & Me.txtFirstName1.Text & "','" & Me.txtLastName1.Text & "' ,'" & Me.txtPhoneNum1.Text & "','" & Me.txtEmailAdd1.Text & "','" & Me.txtUsername2.Text & "','" & Me.txtPassword2.Text & "','" & Me.txtRecPass2.Text & "','" & Me.dropUserType2.Text & "')"
        Connect_to_DB()
        Dim mycommand As New MySqlCommand
        Try
            mycommand.Connection = DBConnection
            mycommand.CommandText = strsql
            mycommand.ExecuteNonQuery()
            MsgBox("Successfully added.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Disconnect_to_DB()
    End Sub
    Private Sub btnLoadUsers2_Click(sender As Object, e As EventArgs) Handles btnLoadUsers2.Click
        Dim mycommand As New MySqlCommand
        Dim myAdapter As New MySqlDataAdapter
        Dim myData As New DataTable
        Dim strsql As String
        strsql = "Select * from user"
        Connect_to_DB()
        With mycommand
            .Connection = DBConnection
            .CommandType = CommandType.Text
            .CommandText = strsql
            myAdapter.SelectCommand = mycommand
            myAdapter.Fill(myData)
            gridUserList2.AutoGenerateColumns = False
            gridUserList2.DataSource = myData
        End With
        Disconnect_to_DB()
    End Sub
    Private Sub gridUserList2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridUserList2.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = gridUserList2.Rows(index)

        labelUserID2.Text = selectedRow.Cells(0).Value.ToString()
        txtFirstName1.Text = selectedRow.Cells(1).Value.ToString()
        txtLastName1.Text = selectedRow.Cells(2).Value.ToString()
        txtPhoneNum1.Text = selectedRow.Cells(3).Value.ToString()
        txtEmailAdd1.Text = selectedRow.Cells(4).Value.ToString()
        txtUsername2.Text = selectedRow.Cells(5).Value.ToString()
        txtPassword2.Text = selectedRow.Cells(6).Value.ToString()
        txtRecPass2.Text = selectedRow.Cells(7).Value.ToString()
        dropUserType2.Text = selectedRow.Cells(8).Value.ToString()

        '
        Dim newDataRow As DataGridViewRow
        newDataRow = gridUserList2.Rows(index)
        newDataRow.Cells(0).Value = labelUserID2.Text
        newDataRow.Cells(1).Value = txtFirstName1.Text
        newDataRow.Cells(2).Value = txtLastName1.Text
        newDataRow.Cells(3).Value = txtPhoneNum1.Text
        newDataRow.Cells(4).Value = txtEmailAdd1.Text
        newDataRow.Cells(5).Value = txtUsername2.Text
        newDataRow.Cells(6).Value = txtPassword2.Text
        newDataRow.Cells(7).Value = txtRecPass2.Text
        newDataRow.Cells(8).Value = dropUserType2.Text
    End Sub
    Private Sub btnUpdate2_Click(sender As Object, e As EventArgs) Handles btnUpdate2.Click
        Dim strsql As String
        strsql = "Update user set u_fname = '" _
        & Me.txtFirstName1.Text & "', u_lname = '" _
        & Me.txtLastName1.Text & "', u_phone_no = '" _
        & Me.txtPhoneNum1.Text & "', u_email_add = '" _
        & Me.txtEmailAdd1.Text & "', u_username = '" _
        & Me.txtUsername2.Text & "', u_password = '" _
        & Me.txtPassword2.Text & "', u_pass_recovery = '" _
        & Me.txtRecPass2.Text & "', u_type = '" _
        & Me.dropUserType2.Text & "' where iduser = '" & Me.labelUserID2.Text & "'"
        Connect_to_DB()
        Dim mycommand As New MySqlCommand
        Try
            mycommand.Connection = DBConnection
            mycommand.CommandText = strsql
            mycommand.ExecuteNonQuery()
            MsgBox("Record Updated.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Disconnect_to_DB()
        Call btnLoadUsers2_Click(sender, e)
    End Sub
    Private Sub btnClearAUserInfo_Click(sender As System.Object,
                              e As System.EventArgs) Handles btnClearAUserInfo.Click
        clear_ALL()
    End Sub
    Private Sub clear_ALL()
        Dim ctrl As Control = Me.GetNextControl(Me, True)
        Do Until ctrl Is Nothing
            If TypeOf ctrl Is TextBox Then
                DirectCast(ctrl, TextBox).Clear()
            ElseIf TypeOf ctrl Is Label Then
                labelUserID2.Text = ""
            ElseIf TypeOf ctrl Is ComboBox Then
                Dim cbo = DirectCast(ctrl, ComboBox)
                cbo.SelectedIndex = -1
            End If
            ctrl = Me.GetNextControl(ctrl, True)
        Loop
    End Sub
    Private Sub btnBack1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack1.Click
        Me.Hide()
        UserList.Show()
    End Sub
    Private Sub btnExit3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit3.Click
        Me.Close()
    End Sub
    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub AddToDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub labelUserID2_Click(sender As Object, e As EventArgs) Handles labelUserID2.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub gridUserList2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridUserList2.CellContentClick

    End Sub
End Class