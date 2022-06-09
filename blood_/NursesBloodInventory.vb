Imports MySql.Data.MySqlClient
Public Class NursesBloodInventory

    Private Sub btnRefresh_Click_1(sender As Object, e As EventArgs) Handles btnRefresh.Click
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

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        NurseInterface.Show()
    End Sub
End Class