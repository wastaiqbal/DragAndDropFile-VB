Imports System.Runtime
Imports System.IO

Public Class Form1

    Private MyFile As FileInfo

    Private Sub ShowFileInfo()
        'Atribut Tampilan
        TxtFileName.Text = MyFile.FullName

        LbFilename.Text = "File Name: " & MyFile.Name
        LbFiletype.Text = "File Type: " & MyFile.Extension
        LbFilesize.Text = "Size: " & Math.Round(MyFile.Length / 1024) & "KB"
        LbCreated.Text = "Created: " & MyFile.CreationTime
        LbModified.Text = "Modified: " & MyFile.LastWriteTime

        PicIcon.Image = Icon.ExtractAssociatedIcon(MyFile.FullName).ToBitmap
    End Sub

    Private Sub BtnDropFile_DragEnter(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles BtnDropFile.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub BtnDropFile_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles BtnDropFile.DragDrop
        'Mengambil File Path Drop
        Dim file As String = e.Data.GetData(DataFormats.FileDrop)(0)

        'Mengambil Path File Info
        Dim path As String = file
        MyFile = New FileInfo(path)

        'Validasi File
        If String.IsNullOrWhiteSpace(MyFile.Extension) Then Exit Sub

        'Menampilkan File Detail
        ShowFileInfo()
    End Sub

    Private Sub BtnOpen_Click(sender As System.Object, e As System.EventArgs) Handles BtnOpen.Click
        Try
            'Open File
            Process.Start(TxtFileName.Text)
        Catch ex As Exception
        End Try
    End Sub

End Class
