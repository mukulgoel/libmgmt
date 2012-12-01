Public Class RET
    Dim bookid, memberid, bookcode As String
    Dim dr As DataRow
    Dim retdate As Date
    Dim fine As Integer
    Dim ts As TimeSpan
    Dim ldate As String
    Dim cmpdate As Date
    Dim testmsg As Integer


    Public Sub clr()
        BOOK_IDCombo.SelectedValue = Nothing
        BOOK_CODECombo.SelectedValue = Nothing
        MEMBER_IDCombo.SelectedValue = Nothing
    End Sub
    Public Sub routine()
        Me.MEMBER1TableAdapter.Fill(Me.DataSet1.MEMBER1)
        'TODO: This line of code loads data into the 'DataSet1.BOOK1' table. You can move, or remove it, as needed.
        Me.BOOK1TableAdapter.Fill(Me.DataSet1.BOOK1)
        'TODO: This line of code loads data into the 'DataSet1.MEMBER' table. You can move, or remove it, as needed.
        Me.MEMBERTableAdapter.Fill(Me.DataSet1.MEMBER)
        'TODO: This line of code loads data into the 'DataSet1.BOOK' table. You can move, or remove it, as needed.
        Me.BOOKTableAdapter.Fill(Me.DataSet1.BOOK)
        'TODO: This line of code loads data into the 'DataSet1.TRANSACTION' table. You can move, or remove it, as needed.
        Me.TRANSACTIONTableAdapter.Fill(Me.DataSet1.TRANSACTION)
        ' Dim str As String = " select book_id,book_code from book where status = "i" "
        'Dim DA As New OleDbDataAdapter(Str, Con)
        BOOK_IDCombo.Items.Clear()
        BOOK_CODECombo.Items.Clear()
        MEMBER_IDCombo.Items.Clear()

        Dim dr As DataRow
        For Each dr In DataSet1.BOOK
            If dr.Item(5) = "I" Then
                BOOK_IDCombo.Items.Add(dr.Item(0))
                BOOK_CODECombo.Items.Add(dr.Item(1))
            End If

        Next
        For Each dr In DataSet1.MEMBER
            MEMBER_IDCombo.Items.Add(dr.Item(0))
        Next


    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)


    End Sub

    Private Sub BOOK_IDCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BOOK_IDCombo.SelectedIndexChanged
        bookid = BOOK_IDCombo.SelectedItem
        Dim dr As DataRow
        For Each dr In DataSet1.BOOK
            If dr.Item(0) = bookid Then
                BOOK_CODECombo.SelectedItem = dr.Item(1)
                bookcode = BOOK_CODECombo.SelectedItem
                BOOK_CODECombo.Enabled = False
            End If
        Next
    End Sub

    Private Sub MEMBER_IDCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MEMBER_IDCombo.SelectedIndexChanged
        memberid = MEMBER_IDCombo.SelectedItem
    End Sub

    Private Sub BOOKBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.BOOKBindingSource.EndEdit()
        Me.BOOKTableAdapter.Update(Me.DataSet1.BOOK)

    End Sub

    Private Sub RET_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.BOOK1' table. You can move, or remove it, as needed.
        Me.BOOK1TableAdapter.Fill(Me.DataSet1.BOOK1)
        'TODO: This line of code loads data into the 'DataSet1.MEMBER1' table. You can move, or remove it, as needed.
        Me.MembeR1TableAdapter.Fill(Me.DataSet1.MEMBER1)
        'TODO: This line of code loads data into the 'DataSet1.TRANSACTION' table. You can move, or remove it, as needed.
        Me.TRANSACTIONTableAdapter.Fill(Me.DataSet1.TRANSACTION)
        'TODO: This line of code loads data into the 'DataSet1.MEMBER' table. You can move, or remove it, as needed.
        Me.MEMBERTableAdapter.Fill(Me.DataSet1.MEMBER)
        'TODO: This line of code loads data into the 'DataSet1.BOOK' table. You can move, or remove it, as needed.
        Me.BOOKTableAdapter.Fill(Me.DataSet1.BOOK)
        Call routine()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If bookid = "" Or memberid = "" Then
            If bookid = "" Then
                MsgBox("ENTER VALID BOOKID")
                Call clr()
                Exit Sub
            End If
        ElseIf memberid = "" Then
            MsgBox("ENTER VALID MEMBERID")
            Call clr()
            Exit Sub
        End If
        For Each dr In DataSet1.MEMBER
            If dr.Item(0) = memberid Then
                If dr.Item(7) = 0 Then
                    MsgBox("NO BOOK ISSUED TO SELECTED MEMBER")
                    Call clr()
                    Exit Sub
                End If
            End If
        Next

        For Each dr In DataSet1.TRANSACTION
            ldate = dr.Item(6).ToString
            If dr.Item(2) = bookid And dr.Item(3) = memberid And ldate = "" Then
                cmpdate = dr.Item(5)
                ts = retdate - cmpdate
                If ts.Days <= 0 Then
                    dr.Item(6) = retdate
                    MsgBox("BOOK WITH BOOK ID " & bookid & "  RETURNED SUCCESSFULLY")

                Else
                    fine = ts.Days * 5
                    MsgBox("BOOK NOT RETURNED IN TIME, FINE =  Rs." & fine)
                    testmsg = MsgBox("FINE PAID", MsgBoxStyle.YesNo)
                    If testmsg = 6 Then
                        dr.Item(7) = fine
                        dr.Item(6) = retdate
                        TRANSACTIONTableAdapter.Update(DataSet1.TRANSACTION)
                        MsgBox("BOOK WAS RETURNED SUCCESSFULLY")
                    End If
                    If testmsg = 7 Then
                        MsgBox("BOOK CAN NOT BE RETURNED WITHOUT PAYING FINE")
                        Exit Sub
                    End If


                End If

            End If

        Next

        TRANSACTIONTableAdapter.Update(DataSet1.TRANSACTION)
        For Each dr In DataSet1.MEMBER
            If dr.Item(0) = memberid Then
                dr.Item(7) = dr.Item(7) - 1
            End If
        Next
        MEMBERTableAdapter.Update(DataSet1.MEMBER)
        For Each dr In DataSet1.BOOK
            If dr.Item(0) = bookid Then
                dr.Item(5) = "a"
            End If
        Next
        BOOKTableAdapter.Update(DataSet1.BOOK)
        Call routine()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        retdate = DateTimePicker1.Value
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call routine()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        Menu1.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        homepage.Close()
    End Sub
End Class