Public Class SEARCH
    Dim bookname, bookcode, author As String
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub BOOKBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.BOOKBindingSource.EndEdit()
        Me.BOOKTableAdapter.Update(Me.DataSet1.BOOK)

    End Sub


    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub BOOKBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.BOOKBindingSource.EndEdit()
        Me.BOOKTableAdapter.Update(Me.DataSet1.BOOK)

    End Sub

    

    Private Sub SEARCH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'DataSet1.BOOK' table. You can move, or remove it, as needed.
        Me.BOOKTableAdapter.Fill(Me.DataSet1.BOOK)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        bookcode = TextBox1.Text
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        bookname = TextBox2.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim FLAG = 0
        If bookcode = "" And bookname = "" And author = "" Then
            MsgBox("ALL THE FEILDS CANT BE EMPTY")
            Exit Sub
        End If
        Dim dr As DataRow
        For Each dr In DataSet1.BOOK.Rows()
            If dr.Item(1) = bookcode Then
                FLAG = 1
                DataGridView1.Rows.Add(New String() {dr.Item(0), dr.Item(1), dr.Item(2), dr.Item(3), dr.Item(4), dr.Item(5)})
            End If
            If dr.Item(2) = bookname Then
                FLAG = 1
                DataGridView1.Rows.Add(New String() {dr.Item(0), dr.Item(1), dr.Item(2), dr.Item(3), dr.Item(4), dr.Item(5)})
            End If
            If dr.Item(3) = author Then
                FLAG = 1
                DataGridView1.Rows.Add(New String() {dr.Item(0), dr.Item(1), dr.Item(2), dr.Item(3), dr.Item(4), dr.Item(5)})
            End If
        Next
        If FLAG = 0 Then
            MsgBox("RECORD DOES NOT EXIST")
            Exit Sub
        End If
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.ResetText()
        TextBox2.ResetText()
        DataGridView1.DataSource = DBNull.Value
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        Menu1.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
        homepage.Close()
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        author = TextBox3.Text
    End Sub
End Class