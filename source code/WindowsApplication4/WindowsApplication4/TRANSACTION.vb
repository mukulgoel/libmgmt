Public Class TRANSACTION

    Private Sub TRANSACTIONBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TRANSACTIONBindingSource.EndEdit()
        Me.TRANSACTIONTableAdapter.Update(Me.DataSet1.TRANSACTION)

    End Sub

    Private Sub TRANSACTION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.TRANSACTION' table. You can move, or remove it, as needed.
        Me.TRANSACTIONTableAdapter.Fill(Me.DataSet1.TRANSACTION)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Menu1.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        homepage.Close()
    End Sub

    Private Sub TRANSACTIONDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TRANSACTIONDataGridView.CellContentClick

    End Sub
End Class