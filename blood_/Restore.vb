Public Class restoreForm
    Private Sub btnBrowseRestore_Click(sender As Object, e As EventArgs) Handles btnBrowseRestore.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            restoreTxt.Text = System.IO.Path.GetFileName(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnRestoreFile_Click(sender As Object, e As EventArgs) Handles btnRestoreFile.Click
        Dim file As String = OpenFileDialog1.FileName
        MessageBox.Show(file)
        If String.IsNullOrEmpty(restoreTxt.Text) Then
            MessageBox.Show("Please select file first.")
        Else


            Dim restoreProcess As New Process()
            restoreProcess.StartInfo.FileName = "cmd.exe"
            restoreProcess.StartInfo.UseShellExecute = False
            restoreProcess.StartInfo.WorkingDirectory = "C:\Program Files\MySQL\MySQL Server 8.0\bin"
            restoreProcess.StartInfo.RedirectStandardInput = True
            restoreProcess.StartInfo.RedirectStandardOutput = True
            restoreProcess.Start()
            Dim myStreamWriter As IO.StreamWriter = restoreProcess.StandardInput
            Dim myStreamReader As IO.StreamReader = restoreProcess.StandardOutput
            myStreamWriter.WriteLine("mysql.exe -u root -p blood_msdb < """ & file & """ ")
            myStreamWriter.Close()
            restoreProcess.WaitForExit()
            restoreProcess.Close()
            MsgBox("Database is successfully restored")
            Me.Close()
        End If
    End Sub

    Private Sub btnCancelRestore_Click(sender As Object, e As EventArgs) Handles btnCancelRestore.Click
        Me.Close()
        AdminInterface.Show()
    End Sub
End Class