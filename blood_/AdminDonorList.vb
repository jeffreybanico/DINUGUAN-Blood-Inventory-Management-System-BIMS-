Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop
Public Class AdminDonorList

    Private Sub btnEditDonor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditDonor.Click
        Me.Hide()
        AdminDonorInformation.Show()
    End Sub
    Private Sub btnExportDonor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportDonor.Click
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
        xlsFiles = "C:\Users\Jeffrey Banico\Desktop\EDP\BIMS - FINAL PROJECT\donorlist\"
        xlsWB = xlsApp.Workbooks.Open(xlsPath & "donor.xlsx")

        xlsSheet = xlsWB.Worksheets(1)
        Dim x As Integer
        xlsSheet.Cells(1, 1) = "Donor List"
        Dim currentRow As Integer = 5
        For x = 0 To gridDonorList.RowCount - 1

            xlsSheet.Cells(currentRow, 1) = "'" & gridDonorList.Rows(x).Cells("donorId").Value
            xlsSheet.Cells(currentRow, 2) = gridDonorList.Rows(x).Cells("donorFname").Value
            xlsSheet.Cells(currentRow, 3) = gridDonorList.Rows(x).Cells("donorLname").Value
            xlsSheet.Cells(currentRow, 4) = gridDonorList.Rows(x).Cells("donorBloodType").Value
            xlsSheet.Cells(currentRow, 5) = gridDonorList.Rows(x).Cells("donorQty").Value
            xlsSheet.Cells(currentRow, 6) = gridDonorList.Rows(x).Cells("donorDate").Value

            currentRow += 1
        Next

        Dim myfilename As String = "DonorList" & DateTime.Now.ToString("MMddyy-HHmmmss") & ".xlsx"
        xlsApp.ActiveWindow.DisplayGridlines = True
        xlsWB.SaveAs(xlsFiles & myfilename)
        xlsApp.Quit()
        xlsApp = Nothing
        xlsWB = Nothing
        xlsSheet = Nothing
        MsgBox("File Successfully Exported")
    End Sub
    Private Sub btnDonorList_Click(sender As Object, e As EventArgs) Handles btnDonorList.Click
        Load_donors()
    End Sub
    Private Sub Load_donors()
        Me.gridDonorList.Rows.Clear()
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
            Me.gridDonorList.Rows.Add(New Object() {myreader.Item("iddonor"), myreader.Item("d_fname"), myreader.Item("d_lname"), myreader.Item("bloodtype"), myreader.Item("d_quantitydonated"), myreader.Item("date_donated")})
        End While
        Disconnect_to_DB()
    End Sub
    Private Sub btnClearADonor_Click(sender As System.Object,
                              e As System.EventArgs) Handles btnClearADonor.Click
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
    Private Sub dropBType1_TextChanged(sender As Object, e As EventArgs) Handles dropBType1.SelectedIndexChanged
        Dim drop As String = dropBType1.Text

        If (drop = "All") Then
            Load_donors()
        Else
            Me.gridDonorList.Rows.Clear()
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
                    Me.gridDonorList.Rows.Add(New Object() {myreader.Item("iddonor"), myreader.Item("d_fname"), myreader.Item("d_lname"), myreader.Item("bloodtype"), myreader.Item("d_quantitydonated"), myreader.Item("date_donated")})
                End While
                Disconnect_to_DB()
            End If
        End If
    End Sub

    Private Sub txtSearchDonor_TextChanged(sender As Object, e As EventArgs) Handles txtSearchDonor.TextChanged

    End Sub


    Private Sub btnSearchDonor_Click(sender As Object, e As EventArgs) Handles btnSearchDonor.Click
        Me.gridDonorList.Rows.Clear()
        Dim strsql As String
        Dim mycommand As New MySqlCommand

        If Me.dropSearchDonor.Text = "All" Or Me.dropSearchDonor.SelectedIndex = -1 Then
            strsql = "select donor.iddonor, d_fname, d_lname, bloodtype.bloodtype, d_quantitydonated, date_donated
                    FROM donor 
                    inner JOIN `blood` ON donor.iddonor = `blood`.iddonor
                    inner join `bloodtype` on blood.idbloodtype = `bloodtype`.idbloodtype where '" _
                     & Me.txtSearchDonor.Text _
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
                    Me.gridDonorList.Rows.Add(New Object() {myreader.Item("iddonor"), myreader.Item("d_fname"), myreader.Item("d_lname"), myreader.Item("bloodtype"), myreader.Item("d_quantitydonated"), myreader.Item("date_donated")})
                End While
                Disconnect_to_DB()
            Else
                MessageBox.Show("No records found")
            End If

        Else
            Dim drop_search_val As String

            Select Case Me.dropSearchDonor.Text
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
                     & Me.txtSearchDonor.Text _
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
                Me.gridDonorList.Rows.Add(New Object() {myreader.Item("iddonor"), myreader.Item("d_fname"), myreader.Item("d_lname"), myreader.Item("bloodtype"), myreader.Item("d_quantitydonated"), myreader.Item("date_donated")})
            End While
            Disconnect_to_DB()
        End If
    End Sub
    Private Sub btnBackDonor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackDonor.Click
        Me.Close()
        AdminInterface.Show()
    End Sub

    Private Sub donorList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AdminDonorList_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub dropSearchDonor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dropSearchDonor.SelectedIndexChanged

    End Sub
End Class