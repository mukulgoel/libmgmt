Imports System.Data
Imports System.data.oledb
Imports System.Data.SqlTypes


Public Class ISSUE

    Dim ldate As Date
    Dim cmpdate As Date = Nothing
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
        For Each dr In DataSet1.BOOK1
            BOOK_IDCombo.Items.Add(dr.Item(0))
            BOOK_CODECombo.Items.Add(dr.Item(1))
        Next
        For Each dr In DataSet1.MEMBER
            MEMBER_IDCombo.Items.Add(dr.Item(0))
        Next


    End Sub

    Dim bookid, memberid, bookcode As String
    Dim issuedate, duedate As Date
    Private Sub TRANSACTIONBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TRANSACTIONBindingSource.EndEdit()
        Me.TRANSACTIONTableAdapter.Update(Me.DataSet1.TRANSACTION)

    End Sub

    Private Sub ISSUE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.MEMBER1' table. You can move, or remove it, as needed.
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
        Dim dr As DataRow
        For Each dr In DataSet1.BOOK1
            BOOK_IDCombo.Items.Add(dr.Item(0))
            BOOK_CODECombo.Items.Add(dr.Item(1))
        Next
        For Each dr In DataSet1.MEMBER
            MEMBER_IDCombo.Items.Add(dr.Item(0))
        Next

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        issuedate = DateTimePicker1.Value
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        duedate = DateTimePicker2.Value
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dr As DataRow
        If bookid = "" Or memberid = "" Then
            If bookid = "" Then
                MsgBox(" enter valid BOOK ID")
                Exit Sub

            End If
            If memberid = "" Then
                MsgBox("enter valid MEMBER ID")
                Exit Sub
            End If
        End If
        For Each dr In DataSet1.MEMBER
            If dr.Item(0) = memberid Then
                If dr.Item(7) >= 5 Then
                    MsgBox("MAXIMUM ISSUE LIMIT REACHED")
                    Exit Sub
                End If
              
            End If

        Next
        For Each dr In DataSet1.TRANSACTION
            If dr.Item(2) = bookid Then
                ldate = dr.Item(6)
                If ldate.CompareTo(cmpdate) = 0 Then
                    MsgBox("BOOK ALREADY ISSUED")
                    Exit Sub
                End If
            End If

        Next
        For Each dr In DataSet1.TRANSACTION
            If dr.Item(2) = bookid Then
                MsgBox(dr.Item(6))
               
            End If

        Next

        TRANSACTIONTableAdapter.InsertQuery(bookcode, bookid, memberid, issuedate, duedate, 0)
        DataSet1.TRANSACTION.AcceptChanges()
        TRANSACTIONTableAdapter.Update(DataSet1.TRANSACTION)
        DataSet1.TRANSACTION.GetChanges()

        For Each dr In DataSet1.MEMBER
            If dr.Item(0) = memberid Then
                dr.Item(7) = dr.Item(7) + 1


            End If
        Next

        MEMBERTableAdapter.Update(DataSet1.MEMBER)

        For Each dr In DataSet1.BOOK
            If dr.Item(0) = bookid Then
                dr.Item(5) = "I"


            End If

        Next

        BOOKTableAdapter.Update(DataSet1.BOOK)
        Call routine()

    End Sub


    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        Menu1.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
        homepage.Close()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call routine()
    End Sub


    Private Sub BOOK__CODEComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub


    Private Sub BOOK__CODELabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub BOOK_IDCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BOOK_IDCombo.SelectedIndexChanged
        bookid = BOOK_IDCombo.SelectedItem
        Dim dr As DataRow
        For Each dr In DataSet1.BOOK1
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

    Private Sub BOOK_CODECombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BOOK_CODECombo.SelectedIndexChanged
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub TRANSACTIONDataGridView_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TRANSACTIONDataGridView.Validating

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class