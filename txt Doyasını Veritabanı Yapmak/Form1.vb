Public Class Form1
    Dim user As New RichTextBox

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "/veri/" & TextBox1.Text & ".txt") = True Then
            user.LoadFile(Application.StartupPath & "/veri/" & TextBox1.Text & ".txt", RichTextBoxStreamType.PlainText)
            TextBox1.Text = user.Lines(0).Split("="c)(user.Lines(0).Split("="c).Length - 1)
            TextBox2.Text = user.Lines(1).Split("="c)(user.Lines(1).Split("="c).Length - 1)
        Else
            MsgBox("Kullanıcı Bulunamadı.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        user.Text = "=" & TextBox1.Text & vbNewLine & "=" & TextBox2.Text
        user.SaveFile(Application.StartupPath & "/veri/" & TextBox1.Text & ".txt", RichTextBoxStreamType.PlainText)
        RichTextBox1.Text = RichTextBox1.Text & vbNewLine & TextBox1.Text
        RichTextBox1.SaveFile(Application.StartupPath & "/veri/veri.txt", RichTextBoxStreamType.PlainText)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "/veri/" & TextBox1.Text & ".txt") = True Then
            If MsgBox("Emin Misiniz?", MsgBoxStyle.YesNo, TextBox1.Text & " Silinsin mi?") = MsgBoxResult.Yes Then
                My.Computer.FileSystem.DeleteFile(Application.StartupPath & "/veri/" & TextBox1.Text & ".txt")
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RichTextBox1.LoadFile(Application.StartupPath & "/veri/veri.txt", RichTextBoxStreamType.PlainText)
    End Sub
End Class
