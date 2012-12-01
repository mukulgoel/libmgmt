Public Class ADDBOOK

    Public Sub routine()
        Me.BOOKTableAdapter.Fill(Me.DataSet1.BOOK)
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
    End Sub
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        bookcode = TextBox2.Text
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        bname = TextBox3.Text
    End Sub

    Private Sub ADDBOOK_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.BOOK' table. You can move, or remove it, as needed.
        Me.BOOKTableAdapter.Fill(Me.DataSet1.BOOK)

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        author = TextBox4.Text
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        publisher = TextBox5.Text
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        status = ComboBox1.SelectedItem

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        copies = Val(TextBox6.Text)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' details.Show()

        '  If Module1.ys = 1 Then
        For i = 1 To copies
            BOOKTableAdapter.InsertQuery(bookcode, bname, author, publisher, status)
            BOOKTableAdapter.Update(DataSet1.BOOK)
        Next
        Call routine()
        'End If

        'If Module1.ys = 2 Then
        'Call routine()
        'End If

    End Sub

    Private Sub BOOKBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.BOOKBindingSource.EndEdit()
        Me.BOOKTableAdapter.Update(Me.DataSet1.BOOK)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call routine()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        Menu1.Show()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
        homepage.Close()

    End Sub
End Class