Imports MySql.Data.MySqlClient
Public Class LoginForm

    Private Sub Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim userType As String
        Dim userId As String
        Dim firstName As String
        Dim lastName As String
        Connect_to_DB()
        Dim mycommand As New MySqlCommand("select iduser, u_fname, u_lname, u_type from user where u_username = @param1 and u_password = @param2", DBConnection)
        mycommand.Parameters.AddWithValue("@param1", txtUsername.Text)
        mycommand.Parameters.AddWithValue("@param2", txtPassword.Text)
        Dim myreader As MySqlDataReader = mycommand.ExecuteReader
        If myreader.Read() Then
            Try
                userType = myreader("u_type")
                userId = myreader("iduser")
                firstName = myreader("u_fname")
                lastName = myreader("u_lname")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
        Disconnect_to_DB()
        Connect_to_DB()
        Dim strsql As String = "insert into log values(uuid_short(), '" + userId + "','Login',  current_timestamp())"
        Try
            mycommand.Connection = DBConnection
            mycommand.CommandText = strsql
            mycommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        If userType = "Admin" Then
            Try
                AdminInterface.userIdAdmin = userId
                AdminInterface.fname = firstName
                AdminInterface.lname = lastName
                AdminInterface.uname = txtUsername.Text
                Me.Hide()
                AdminInterface.Show()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        ElseIf userType = "Nurse" Then
            Try
                NurseInterface.userIdNurse = userId
                NurseInterface.nfname = firstName
                NurseInterface.nlname = lastName
                NurseInterface.nuname = txtUsername.Text
                NurseRequestInformation.userIdNurse = userId
                Me.Hide()
                NurseInterface.Show()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        Else
            MsgBox("Login credentials not found!")
        End If
        Disconnect_to_DB()

    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles labelUsername.Click

    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles labelDinuguan.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles labelBIMS.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles labelForgot.Click
        PasswordRecovery.Show()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
