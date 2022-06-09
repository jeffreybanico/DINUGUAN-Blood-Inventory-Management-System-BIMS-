Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop
Public Class AdminRequest
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        AdminInterface.Show()
    End Sub
    Private Sub btnClearARequest_Click(sender As System.Object,
                              e As System.EventArgs) Handles btnClearARequest.Click
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
    Private Sub dropStatus_TextChanged(sender As Object, e As EventArgs) Handles dropStatus.SelectedIndexChanged
        Dim drop As String = dropStatus.Text

        If (drop = "All") Then
            Me.gridRequestList.Rows.Clear()
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
                Me.gridRequestList.Rows.Add(New Object() {myreader.Item("r_fname"), myreader.Item("r_lname"), myreader.Item("bloodtype"), myreader.Item("r_quantityrequest"), myreader.Item("r_address"), myreader.Item("attending_nurse"), myreader.Item("r_status")})
            End While
            Disconnect_to_DB()
        Else
            Me.gridRequestList.Rows.Clear()
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
                    Me.gridRequestList.Rows.Add(New Object() {myreader.Item("r_fname"), myreader.Item("r_lname"), myreader.Item("bloodtype"), myreader.Item("r_quantityrequest"), myreader.Item("r_address"), myreader.Item("attending_nurse"), myreader.Item("r_status")})
                End While
                Disconnect_to_DB()
            End If
        End If
    End Sub

    Private Sub btnNSearchRequest_Click(sender As Object, e As EventArgs) Handles btnASearchRequest.Click
        Me.gridRequestList.Rows.Clear()
        Dim strsql As String
        Dim mycommand As New MySqlCommand

        If Me.dropASearchRequest.Text = "All" Or Me.dropASearchRequest.SelectedIndex = -1 Then
            strsql = "Select r_fname, r_lname, bloodtype.bloodtype, r_quantityrequest, r_quantityrequest , r_address, concat(`user`.u_fname, "" "", `user`.u_lname) as attending_nurse, r_status 
                    from request
                    inner join bloodtype on request.idbloodtype = bloodtype.idbloodtype
                    inner join `user` on `user`.iduser = request.iduser
                    where '" _
                     & Me.txtASearchRequest.Text _
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
                    Me.gridRequestList.Rows.Add(New Object() {myreader.Item("r_fname"), myreader.Item("r_lname"), myreader.Item("bloodtype"), myreader.Item("r_quantityrequest"), myreader.Item("r_address"), myreader.Item("attending_nurse"), myreader.Item("r_status")})
                End While
                Disconnect_to_DB()
            Else
                MessageBox.Show("No records found")
            End If

        Else
            Dim drop_search_val As String

            Select Case Me.dropASearchRequest.Text
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
                     & Me.txtASearchRequest.Text _
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
                Me.gridRequestList.Rows.Add(New Object() {myreader.Item("r_fname"), myreader.Item("r_lname"), myreader.Item("bloodtype"), myreader.Item("r_quantityrequest"), myreader.Item("r_address"), myreader.Item("attending_nurse"), myreader.Item("r_status")})
            End While
            Disconnect_to_DB()
        End If
    End Sub
    Private Sub btnRequest_Click(sender As Object, e As EventArgs) Handles btnRequest.Click
        Me.gridRequestList.Rows.Clear()
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
            Me.gridRequestList.Rows.Add(New Object() {myreader.Item("r_fname"), myreader.Item("r_lname"), myreader.Item("bloodtype"), myreader.Item("r_quantityrequest"), myreader.Item("r_address"), myreader.Item("attending_nurse"), myreader.Item("r_status")})
        End While
        Disconnect_to_DB()
    End Sub

    Private Sub btnAEditRequest_Click(sender As Object, e As EventArgs) Handles btnAEditRequest.Click
        AdminRequestInformation.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClearARequest.Click

    End Sub

    Private Sub AdminRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExportRequest_Click(sender As Object, e As EventArgs) Handles btnExportRequest.Click
        export()
    End Sub
    Public Sub export()
        Dim xlsApp As Excel.Application
        Dim xlsWB As Excel.Workbook
        Dim xlsSheet As Excel.Worksheet
        Dim xlsPath As String
        Dim xlsFiles As String

        xlsApp = New Excel.Application
        xlsApp.Visible = False
        xlsPath = "C:\Users\Jeffrey Banico\Desktop\EDP\BIMS - FINAL PROJECT\templates\"
        xlsFiles = "C:\Users\Jeffrey Banico\Desktop\EDP\BIMS - FINAL PROJECT\requestlist\"
        xlsWB = xlsApp.Workbooks.Open(xlsPath & "request.xlsx")

        xlsSheet = xlsWB.Worksheets(1)
        Dim x As Integer
        xlsSheet.Cells(1, 1) = "Request List"
        Dim currentRow As Integer = 5
        For x = 0 To gridRequestList.RowCount - 1

            xlsSheet.Cells(currentRow, 1) = "'" & gridRequestList.Rows(x).Cells("requestFname").Value
            xlsSheet.Cells(currentRow, 2) = gridRequestList.Rows(x).Cells("requestLname").Value
            xlsSheet.Cells(currentRow, 3) = gridRequestList.Rows(x).Cells("bloodType").Value
            xlsSheet.Cells(currentRow, 4) = gridRequestList.Rows(x).Cells("numofRequest").Value
            xlsSheet.Cells(currentRow, 5) = gridRequestList.Rows(x).Cells("address").Value
            xlsSheet.Cells(currentRow, 6) = gridRequestList.Rows(x).Cells("attNurse").Value
            xlsSheet.Cells(currentRow, 7) = gridRequestList.Rows(x).Cells("requestStat").Value

            currentRow += 1
        Next

        Dim myfilename As String = "RecordList" & DateTime.Now.ToString("MMddyy-HHmmmss") & ".xlsx"
        xlsApp.ActiveWindow.DisplayGridlines = True
        xlsWB.SaveAs(xlsFiles & myfilename)
        xlsApp.Quit()
        xlsApp = Nothing
        xlsWB = Nothing
        xlsSheet = Nothing
        MsgBox("File Successfully Exported")
    End Sub
End Class