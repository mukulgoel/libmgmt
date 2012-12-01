Public Class homepage

    Private Sub RichTextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        While ProgressBar1.Value < 100
            System.Threading.Thread.Sleep(10)

            ProgressBar1.Value = ProgressBar1.Value + 2
        End While
        Me.Hide()
        login.Show()

    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub
End Class
