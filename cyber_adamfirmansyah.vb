Imports System.IO
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        With SaveFileDialog1
            .FileName = "document"
            .Filter = "txt file (.txt)|.txt|All files (.)|."
            .DefaultExt = "txt"
            .FilterIndex = 2
            .RestoreDirectory = True
        End With

        Try
            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                Dim writter As StreamWriter
                writter = File.AppendText(SaveFileDialog1.FileName)
                writter.Write(RichTextBox1.Text)
                writter.Flush()
                RichTextBox1.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                My.Computer.FileSystem.DeleteFile(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class