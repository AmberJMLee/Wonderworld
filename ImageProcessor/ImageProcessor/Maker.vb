Public Class Maker
    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Dim myFileDlog As New OpenFileDialog()
        'look for files in the C drive
        myFileDlog.InitialDirectory = "c:\"
        'specifies what type of data files to look for
        myFileDlog.Filter = ".png Files (*.png)|*.png" & "|.jpg Files (*.jpg)|*.jpg"
        'myFileDlog.Filter = "All Files (*.*)|*.*" &
        '    "|Data Files (*.dat)|*.dat"
        'specifies which data type is focused on start up
        myFileDlog.FilterIndex = 1
        'Gets or sets a value indicating whether the dialog box restores the current directory before closing.
        myFileDlog.RestoreDirectory = True

        'seperates message outputs for files found or not found
        If myFileDlog.ShowDialog() =
            DialogResult.OK Then
            If Dir(myFileDlog.FileName) <> "" Then
                'MsgBox("File Exists: " &
                'myFileDlog.FileName,
                'MsgBoxStyle.Information)
            Else
                MsgBox("File Not Found",
                       MsgBoxStyle.Critical)
            End If
        End If

        'Adds the file directory to the text box
        txtFileDirectory.Text = myFileDlog.FileName
        'picDisplay.Picture = LoadPicture(myFileDlog.FileName)
        PictureBox1.Load(txtFileDirectory.Text)
    End Sub

    Private Sub Maker_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
