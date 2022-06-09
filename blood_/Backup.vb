Imports MySql.Data.MySqlClient
Public Class backupForm

    Private Sub backupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBrowsePath_Click(sender As Object, e As EventArgs) Handles btnBrowsePath.Click
        FolderBrowserDialog1.ShowDialog()
        pathTextBox.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim pathText As String = pathTextBox.Text
        Dim filename As String = "blood_msdb" + DateTime.Now.ToString("MMddyyyy-hhmmss") + ".sql"

        Dim path As String = IO.Path.Combine(pathText, filename)

        If String.IsNullOrEmpty(filename) Then
            MessageBox.Show("Please set filename first.")
        Else
            Process.Start(
                "C:\Program Files\MySQL\MySQL Server 8.0\bin\mysqldump.exe",
                "-u root -p blood_msdb -r """ & path & """ ")
            MsgBox("The database backup successfully")
            Me.Hide()
        End If
    End Sub

    Private Sub btnCancelBackup_Click(sender As Object, e As EventArgs) Handles btnCancelBackup.Click
        Me.Close()
        AdminInterface.Show()
    End Sub
End Class