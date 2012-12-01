<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RET
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim BOOK__CODELabel1 As System.Windows.Forms.Label
        Dim MEMBER_IDLabel1 As System.Windows.Forms.Label
        Dim BOOK_IDLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RET))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.MEMBER_IDCombo = New System.Windows.Forms.ComboBox
        Me.BOOK_CODECombo = New System.Windows.Forms.ComboBox
        Me.BOOK_IDCombo = New System.Windows.Forms.ComboBox
        Me.TRANSACTIONDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TRANSACTIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New WindowsApplication4.DataSet1
        Me.BOOKBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BOOKTableAdapter = New WindowsApplication4.DataSet1TableAdapters.BOOKTableAdapter
        Me.MEMBERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MEMBERTableAdapter = New WindowsApplication4.DataSet1TableAdapters.MEMBERTableAdapter
        Me.TRANSACTIONTableAdapter = New WindowsApplication4.DataSet1TableAdapters.TRANSACTIONTableAdapter
        Me.MembeR1TableAdapter = New WindowsApplication4.DataSet1TableAdapters.MEMBER1TableAdapter
        Me.BooK1TableAdapter1 = New WindowsApplication4.LibDataSetTableAdapters.BOOK1TableAdapter
        Me.MEMBER1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BOOK1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BOOK1TableAdapter = New WindowsApplication4.DataSet1TableAdapters.BOOK1TableAdapter
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox
        BOOK__CODELabel1 = New System.Windows.Forms.Label
        MEMBER_IDLabel1 = New System.Windows.Forms.Label
        BOOK_IDLabel1 = New System.Windows.Forms.Label
        CType(Me.TRANSACTIONDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRANSACTIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BOOKBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEMBERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEMBER1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BOOK1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BOOK__CODELabel1
        '
        BOOK__CODELabel1.AutoSize = True
        BOOK__CODELabel1.ForeColor = System.Drawing.SystemColors.HotTrack
        BOOK__CODELabel1.Location = New System.Drawing.Point(127, 116)
        BOOK__CODELabel1.Name = "BOOK__CODELabel1"
        BOOK__CODELabel1.Size = New System.Drawing.Size(76, 13)
        BOOK__CODELabel1.TabIndex = 28
        BOOK__CODELabel1.Text = "BOOK  CODE:"
        '
        'MEMBER_IDLabel1
        '
        MEMBER_IDLabel1.AutoSize = True
        MEMBER_IDLabel1.ForeColor = System.Drawing.SystemColors.HotTrack
        MEMBER_IDLabel1.Location = New System.Drawing.Point(127, 176)
        MEMBER_IDLabel1.Name = "MEMBER_IDLabel1"
        MEMBER_IDLabel1.Size = New System.Drawing.Size(71, 13)
        MEMBER_IDLabel1.TabIndex = 26
        MEMBER_IDLabel1.Text = "MEMBER ID:"
        '
        'BOOK_IDLabel1
        '
        BOOK_IDLabel1.AutoSize = True
        BOOK_IDLabel1.ForeColor = System.Drawing.SystemColors.HotTrack
        BOOK_IDLabel1.Location = New System.Drawing.Point(127, 54)
        BOOK_IDLabel1.Name = "BOOK_IDLabel1"
        BOOK_IDLabel1.Size = New System.Drawing.Size(54, 13)
        BOOK_IDLabel1.TabIndex = 25
        BOOK_IDLabel1.Text = "BOOK ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(304, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RETURN BOOK"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.Location = New System.Drawing.Point(359, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "RETURN DATE"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(454, 48)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(186, 20)
        Me.DateTimePicker1.TabIndex = 16
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(492, 226)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 27)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "EXIT"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(377, 226)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 27)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "GO BACK"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(266, 226)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 27)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "REFRESH"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(154, 226)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 27)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "RETURN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MEMBER_IDCombo
        '
        Me.MEMBER_IDCombo.FormattingEnabled = True
        Me.MEMBER_IDCombo.Location = New System.Drawing.Point(220, 173)
        Me.MEMBER_IDCombo.Name = "MEMBER_IDCombo"
        Me.MEMBER_IDCombo.Size = New System.Drawing.Size(121, 21)
        Me.MEMBER_IDCombo.TabIndex = 30
        '
        'BOOK_CODECombo
        '
        Me.BOOK_CODECombo.FormattingEnabled = True
        Me.BOOK_CODECombo.Location = New System.Drawing.Point(220, 108)
        Me.BOOK_CODECombo.Name = "BOOK_CODECombo"
        Me.BOOK_CODECombo.Size = New System.Drawing.Size(121, 21)
        Me.BOOK_CODECombo.TabIndex = 29
        '
        'BOOK_IDCombo
        '
        Me.BOOK_IDCombo.FormattingEnabled = True
        Me.BOOK_IDCombo.Location = New System.Drawing.Point(220, 47)
        Me.BOOK_IDCombo.Name = "BOOK_IDCombo"
        Me.BOOK_IDCombo.Size = New System.Drawing.Size(121, 21)
        Me.BOOK_IDCombo.TabIndex = 27
        '
        'TRANSACTIONDataGridView
        '
        Me.TRANSACTIONDataGridView.AutoGenerateColumns = False
        Me.TRANSACTIONDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TRANSACTIONDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.TRANSACTIONDataGridView.DataSource = Me.TRANSACTIONBindingSource
        Me.TRANSACTIONDataGridView.GridColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TRANSACTIONDataGridView.Location = New System.Drawing.Point(57, 282)
        Me.TRANSACTIONDataGridView.Name = "TRANSACTIONDataGridView"
        Me.TRANSACTIONDataGridView.ReadOnly = True
        Me.TRANSACTIONDataGridView.Size = New System.Drawing.Size(618, 199)
        Me.TRANSACTIONDataGridView.TabIndex = 30
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "SERIAL_NO"
        Me.DataGridViewTextBoxColumn1.HeaderText = "SERIAL_NO"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "BOOK CODE"
        Me.DataGridViewTextBoxColumn2.HeaderText = "BOOK CODE"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "BOOK_ID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "BOOK_ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "MEMBER_ID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "MEMBER_ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DATE OF ISSUE"
        Me.DataGridViewTextBoxColumn5.HeaderText = "DATE OF ISSUE"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DUE DATE"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DUE DATE"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "DATE OF RETURN"
        Me.DataGridViewTextBoxColumn7.HeaderText = "DATE OF RETURN"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "FINE (IF ANY)"
        Me.DataGridViewTextBoxColumn8.HeaderText = "FINE (IF ANY)"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'TRANSACTIONBindingSource
        '
        Me.TRANSACTIONBindingSource.DataMember = "TRANSACTION"
        Me.TRANSACTIONBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BOOKBindingSource
        '
        Me.BOOKBindingSource.DataMember = "BOOK"
        Me.BOOKBindingSource.DataSource = Me.DataSet1
        '
        'BOOKTableAdapter
        '
        Me.BOOKTableAdapter.ClearBeforeFill = True
        '
        'MEMBERBindingSource
        '
        Me.MEMBERBindingSource.DataMember = "MEMBER"
        Me.MEMBERBindingSource.DataSource = Me.DataSet1
        '
        'MEMBERTableAdapter
        '
        Me.MEMBERTableAdapter.ClearBeforeFill = True
        '
        'TRANSACTIONTableAdapter
        '
        Me.TRANSACTIONTableAdapter.ClearBeforeFill = True
        '
        'MembeR1TableAdapter
        '
        Me.MembeR1TableAdapter.ClearBeforeFill = True
        '
        'BooK1TableAdapter1
        '
        Me.BooK1TableAdapter1.ClearBeforeFill = True
        '
        'MEMBER1BindingSource
        '
        Me.MEMBER1BindingSource.DataMember = "MEMBER1"
        Me.MEMBER1BindingSource.DataSource = Me.DataSet1
        '
        'BOOK1BindingSource
        '
        Me.BOOK1BindingSource.DataMember = "BOOK1"
        Me.BOOK1BindingSource.DataSource = Me.DataSet1
        '
        'BOOK1TableAdapter
        '
        Me.BOOK1TableAdapter.ClearBeforeFill = True
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(-3, -2)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(217, 482)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 31
        Me.LogoPictureBox.TabStop = False
        '
        'RET
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(675, 482)
        Me.Controls.Add(Me.TRANSACTIONDataGridView)
        Me.Controls.Add(Me.MEMBER_IDCombo)
        Me.Controls.Add(BOOK__CODELabel1)
        Me.Controls.Add(Me.BOOK_CODECombo)
        Me.Controls.Add(Me.BOOK_IDCombo)
        Me.Controls.Add(MEMBER_IDLabel1)
        Me.Controls.Add(BOOK_IDLabel1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.MaximizeBox = False
        Me.Name = "RET"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RET"
        CType(Me.TRANSACTIONDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRANSACTIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BOOKBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEMBERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEMBER1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BOOK1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MEMBER_IDCombo As System.Windows.Forms.ComboBox
    Friend WithEvents BOOK_CODECombo As System.Windows.Forms.ComboBox
    Friend WithEvents BOOK_IDCombo As System.Windows.Forms.ComboBox
    Friend WithEvents DataSet1 As WindowsApplication4.DataSet1
    Friend WithEvents BOOKBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BOOKTableAdapter As WindowsApplication4.DataSet1TableAdapters.BOOKTableAdapter
    Friend WithEvents MEMBERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MEMBERTableAdapter As WindowsApplication4.DataSet1TableAdapters.MEMBERTableAdapter
    Friend WithEvents TRANSACTIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TRANSACTIONTableAdapter As WindowsApplication4.DataSet1TableAdapters.TRANSACTIONTableAdapter
    Friend WithEvents TRANSACTIONDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MembeR1TableAdapter As WindowsApplication4.DataSet1TableAdapters.MEMBER1TableAdapter
    Friend WithEvents BooK1TableAdapter1 As WindowsApplication4.LibDataSetTableAdapters.BOOK1TableAdapter
    Friend WithEvents MEMBER1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BOOK1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BOOK1TableAdapter As WindowsApplication4.DataSet1TableAdapters.BOOK1TableAdapter
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
End Class
