Public Class ADDMEMBERS
    Dim mname, address, phn, gender, stat, dob As String
    Dim i As Integer
    Dim dob1 As Date

    Public Sub routine()
        Me.MEMBERTableAdapter.Fill(Me.DataSet1.MEMBER)
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        ComboBox1.Text = "M/F"
        ComboBox2.Text = "SINGLE/MARRIED"
        ComboBox3.Text = "DAY"
        ComboBox4.Text = "MONTH"
        ComboBox5.Text = "YEAR"

    End Sub

    Private Sub ADDMEMBERS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet1.MEMBER' table. You can move, or remove it, as needed.
        Me.MEMBERTableAdapter.Fill(Me.DataSet1.MEMBER)
        For i = 1 To 30
            If i < 10 Then
                ComboBox3.Items.Add("0" & i)
            Else
                ComboBox3.Items.Add(i)
            End If

        Next
        For i = 1 To 12
            If i < 10 Then
                ComboBox4.Items.Add("0" & i)
            Else
                ComboBox4.Items.Add(i)
            End If

        Next
        For i = Today.Date.Year To 1900 Step -1
            ComboBox5.Items.Add(i)
        Next
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click, Label16.Click

    End Sub

    Private Sub MEMBERBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MEMBERBindingSource.EndEdit()
        Me.MEMBERTableAdapter.Update(Me.DataSet1.MEMBER)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        phn = TextBox7.Text
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        gender = ComboBox1.SelectedItem

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        stat = ComboBox2.SelectedItem

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        mname = TextBox1.Text & " " & TextBox2.Text & " " & TextBox3.Text
        address = TextBox4.Text & "," & TextBox5.Text & "," & TextBox6.Text
        dob = ComboBox3.SelectedItem & ComboBox4.SelectedItem & ComboBox5.SelectedItem

        dob = dob.Substring(0, 2) & "/" & dob.Substring(2, 2) & "/" & dob.Substring(4, 4)
        
        dob1 = DateTime.Parse(dob, Globalization.CultureInfo.CreateSpecificCulture("en-CA"))
        If TextBox1.Text = "" Or address = "" Or gender = "" Or stat = "" Or phn = "" Then
            If TextBox1.Text = "" Then
                MsgBox("FIRST NAME FEILD CAN NOT BE EMPTY")
            End If
            If address = "" Then
                MsgBox("ADDRESS FEILD CAN NOT BE EMPTY")
            End If
            If gender = "" Then
                MsgBox("GENDER FEILD CAN NOT BE EMPTY")
            End If
            If stat = "" Then
                MsgBox("MARITIAL STATUS FEILD CAN NOT BE EMPTY")
            End If
            Exit Sub
        End If
        MEMBERTableAdapter.InsertQuery(mname, address, phn, dob1, gender, stat, 0)
        MEMBERTableAdapter.Update(DataSet1.MEMBER)
        Call routine()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Menu1.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        homepage.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call routine()
    End Sub
End Class