Public Class DELETEMEMBER
    Dim memberid As String
    Dim flag As Integer
    Public Sub routine()
        TextBox1.Clear()
        Me.MEMBERTableAdapter.Fill(Me.DataSet1.MEMBER)
    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub MEMBERBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MEMBERBindingSource.EndEdit()
        Me.MEMBERTableAdapter.Update(Me.DataSet1.MEMBER)

    End Sub

    Private Sub DELETEMEMBER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.MEMBER' table. You can move, or remove it, as needed.
        Me.MEMBERTableAdapter.Fill(Me.DataSet1.MEMBER)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        memberid = TextBox1.Text
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        flag = 0
        If memberid = "" Then
            MsgBox("MEMBER ID FEILD CAN NOT BE BLANK")
            Call routine()
            Exit Sub
        End If
        Dim dr As DataRow
        For Each dr In DataSet1.MEMBER
            If dr.Item(0) = memberid Then
                flag = 1
            End If
            If flag = 0 Then
                MsgBox("ENTER VALID MEMBER ID")
                Call routine()
                Exit Sub
            End If
        Next
        For Each dr In DataSet1.MEMBER
            If dr.Item(7) <> 0 Then
                MsgBox("BOOKS ISSUED TO MEMBER ,CAN NOT PROCESS THE REQUEST")
                Exit Sub

            End If
        Next
        MEMBERTableAdapter.DeleteQuery(memberid)
        MEMBERTableAdapter.Update(DataSet1.MEMBER)
        Call routine()
    End Sub
End Class