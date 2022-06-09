Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop
Public Class AdminBloodInventory
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        AdminInterface.Show()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Me.gridBloodInventory.Rows.Clear()
        Dim strsql As String
        Dim mycommand As New MySqlCommand
        strsql = "SELECT 
                        idinventory,
                        bloodtype,
                        (number_of_blood_added - number_of_request_granted) AS stock
                    FROM
                        inventory
                            INNER JOIN
                        bloodtype ON bloodtype.idbloodtype = inventory.idbloodtype"
        Connect_to_DB()
        With mycommand
            .Connection = DBConnection
            .CommandType = CommandType.Text
            .CommandText = strsql
        End With
        Dim myreader As MySqlDataReader
        myreader = mycommand.ExecuteReader
        While myreader.Read()
            If myreader("stock") < 0 Then
                Me.gridBloodInventory.Rows.Add(New Object() {myreader.Item("idinventory"), myreader.Item("bloodtype"), myreader.Item(0)})
            Else
                Me.gridBloodInventory.Rows.Add(New Object() {myreader.Item("idinventory"), myreader.Item("bloodtype"), myreader.Item("stock")})
            End If

        End While
        Disconnect_to_DB()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
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
        xlsFiles = "C:\Users\Jeffrey Banico\Desktop\EDP\BIMS - FINAL PROJECT\bloodinventory\"
        xlsWB = xlsApp.Workbooks.Open(xlsPath & "bloodinventory.xlsx")

        xlsSheet = xlsWB.Worksheets(1)
        Dim x As Integer
        xlsSheet.Cells(1, 1) = "Blood Inventory"
        Dim currentRow As Integer = 5
        For x = 0 To gridBloodInventory.RowCount - 1

            xlsSheet.Cells(currentRow, 1) = "'" & gridBloodInventory.Rows(x).Cells("inventoryNo").Value
            xlsSheet.Cells(currentRow, 2) = gridBloodInventory.Rows(x).Cells("BloodType").Value
            xlsSheet.Cells(currentRow, 3) = gridBloodInventory.Rows(x).Cells("stock").Value


            currentRow += 1
        Next

        Dim myfilename As String = "BloodInventory" & DateTime.Now.ToString("MMddyy-HHmmmss") & ".xlsx"
        xlsApp.ActiveWindow.DisplayGridlines = True
        xlsWB.SaveAs(xlsFiles & myfilename)
        xlsApp.Quit()
        xlsApp = Nothing
        xlsWB = Nothing
        xlsSheet = Nothing
        MsgBox("File Successfully Exported")
    End Sub
End Class