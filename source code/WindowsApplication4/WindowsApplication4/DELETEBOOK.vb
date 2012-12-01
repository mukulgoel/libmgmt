Public Class DELETEBOOK
    Dim bookid As String
    Dim flag As Integer
    Public Sub routine()
        Me.BOOKTableAdapter.Fill(Me.DataSet1.BOOK)
        TextBox1.Clear()

    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        Menu1.Show()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
        homepage.Close()

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        bookid = TextBox1.Text
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        flag = 0
        If bookid = "" Then
            MsgBox("BOOK ID FEILD CAN NOT BE BLANK")
            Call routine()
            Exit Sub
        End If
        Dim dr As DataRow
        For Each dr In DataSet1.BOOK
            If dr.Item(0) = bookid Then
                flag = 1
            End If
        Next
        If flag = 0 Then
            MsgBox("ENTER VALID BOOK ID")
            Call routine()
            Exit Sub
        End If

        BOOKTableAdapter.DeleteQuery(bookid)
        BOOKTableAdapter.Update(DataSet1.BOOK)

        MsgBox("BOOK WITH BOOK ID  " & bookid & "  IS SUCCESSFULLY DELETED")
        Call routine()


    End Sub

    Private Sub BOOKBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.BOOKBindingSource.EndEdit()
        Me.BOOKTableAdapter.Update(Me.DataSet1.BOOK)

    End Sub

    Private Sub DELETEBOOK_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.BOOK' table. You can move, or remove it, as needed.
        Me.BOOKTableAdapter.Fill(Me.DataSet1.BOOK)

    End Sub

    Private Sub BOOKDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles BOOKDataGridView.CellContentClick

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call routine()
    End Sub
End Class