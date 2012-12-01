Imports WindowsApplication4.DataSet1
Imports System.Data
Imports System.Data.OleDb


Public Class login
    Dim usrname, pass As String


    Private Sub login_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim dr As DataRow
            For Each dr In DataSet1.EMPLOYEE

                a = dr.Item(1)
                b = dr.Item(2)
                c = dr.Item(3)
                state = c
                If usrname = a And b = pass Then

                    Menu1.Show()
                    Me.Close()
                    Exit Sub
                End If
            Next dr
            MsgBox(" UNAUTHORIZED ACCESS DETECTED")
            MsgBox(" ENTER VALID USERNAME AND PASSWORD")
            TextBox1.Clear()
            TextBox2.Clear()
        End If

        e.Handled = True

    End Sub

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.EMPLOYEE' table. You can move, or remove it, as needed.
        Me.Employeeadapter.Fill(Me.DataSet1.EMPLOYEE)
        'TODO: This line of code loads data into the 'DataSet1.BOOK' table. You can move, or remove it, as needed.
        Me.BOOKTableAdapter.Fill(Me.DataSet1.BOOK)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BOOKBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.BOOKBindingSource.EndEdit()
        Me.BOOKTableAdapter.Update(Me.DataSet1.BOOK)

    End Sub


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim con As New OleDb.OleDbConnection
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Documents and Settings\cabin3\My Documents\lib.mdb")

        Dim dr As DataRow
        For Each dr In DataSet1.EMPLOYEE

            a = dr.Item(1)
            b = dr.Item(2)
            c = dr.Item(3)
            state = c
            If usrname = a And b = pass Then

                Menu1.Show()
                Me.Close()
                Exit Sub
            End If
        Next dr
        MsgBox(" UNAUTHORIZED ACCESS DETECTED")
        MsgBox(" ENTER VALID USERNAME AND PASSWORD")
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        homepage.Close()
    End Sub

    Private Sub TextBox1_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        usrname = TextBox1.Text
    End Sub

    Private Sub TextBox2_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        pass = TextBox2.Text
    End Sub
End Class
