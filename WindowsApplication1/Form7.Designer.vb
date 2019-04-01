<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.StudentrecordsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ManagementDataSet5 = New WindowsApplication1.managementDataSet5()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.StudentrecordsTableAdapter = New WindowsApplication1.managementDataSet5TableAdapters.studentrecordsTableAdapter()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.StudentrecordsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ManagementDataSet6 = New WindowsApplication1.managementDataSet6()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.StudentrecordsTableAdapter1 = New WindowsApplication1.managementDataSet6TableAdapters.studentrecordsTableAdapter()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BookidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IssuedateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BooknameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReturndateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.StudentrecordsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ManagementDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentrecordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ManagementDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(465, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "... RECORDS ..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(59, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(42, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Roll No. :"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(24, 476)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(40, 40)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "<"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(951, 481)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 30)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Return"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(1032, 481)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 30)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Ok"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(126, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.StudentrecordsBindingSource1, "rollno", True))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(126, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Label6"
        '
        'StudentrecordsBindingSource1
        '
        Me.StudentrecordsBindingSource1.DataMember = "studentrecords"
        Me.StudentrecordsBindingSource1.DataSource = Me.ManagementDataSet5
        '
        'ManagementDataSet5
        '
        Me.ManagementDataSet5.DataSetName = "managementDataSet5"
        Me.ManagementDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(750, 481)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 30)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Search Book"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'StudentrecordsTableAdapter
        '
        Me.StudentrecordsTableAdapter.ClearBeforeFill = True
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(870, 481)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(74, 30)
        Me.Button5.TabIndex = 19
        Me.Button5.Text = "Issue"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(215, 321)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Enter Issue Date :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(206, 350)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(157, 16)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Enter Return Date :"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.StudentrecordsBindingSource1, "issuedate", True))
        Me.TextBox1.Location = New System.Drawing.Point(369, 314)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 23)
        Me.TextBox1.TabIndex = 22
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.StudentrecordsBindingSource1, "returndate", True))
        Me.TextBox2.Location = New System.Drawing.Point(369, 343)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(132, 23)
        Me.TextBox2.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(82, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "BookID :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(261, 292)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 16)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Book Name :"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.StudentrecordsBindingSource, "bookid", True))
        Me.TextBox3.Location = New System.Drawing.Point(369, 256)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(132, 23)
        Me.TextBox3.TabIndex = 26
        '
        'StudentrecordsBindingSource
        '
        Me.StudentrecordsBindingSource.DataMember = "studentrecords"
        Me.StudentrecordsBindingSource.DataSource = Me.ManagementDataSet6
        '
        'ManagementDataSet6
        '
        Me.ManagementDataSet6.DataSetName = "managementDataSet6"
        Me.ManagementDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.StudentrecordsBindingSource1, "bookname", True))
        Me.TextBox4.Location = New System.Drawing.Point(369, 285)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(132, 23)
        Me.TextBox4.TabIndex = 27
        '
        'StudentrecordsTableAdapter1
        '
        Me.StudentrecordsTableAdapter1.ClearBeforeFill = True
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Location = New System.Drawing.Point(669, 481)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(74, 30)
        Me.Button6.TabIndex = 28
        Me.Button6.Text = "Refresh"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BookidDataGridViewTextBoxColumn, Me.IssuedateDataGridViewTextBoxColumn, Me.BooknameDataGridViewTextBoxColumn, Me.ReturndateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StudentrecordsBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(580, 221)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(446, 150)
        Me.DataGridView1.TabIndex = 29
        '
        'BookidDataGridViewTextBoxColumn
        '
        Me.BookidDataGridViewTextBoxColumn.DataPropertyName = "bookid"
        Me.BookidDataGridViewTextBoxColumn.HeaderText = "BookID"
        Me.BookidDataGridViewTextBoxColumn.Name = "BookidDataGridViewTextBoxColumn"
        '
        'IssuedateDataGridViewTextBoxColumn
        '
        Me.IssuedateDataGridViewTextBoxColumn.DataPropertyName = "issuedate"
        Me.IssuedateDataGridViewTextBoxColumn.HeaderText = "Issuedate"
        Me.IssuedateDataGridViewTextBoxColumn.Name = "IssuedateDataGridViewTextBoxColumn"
        '
        'BooknameDataGridViewTextBoxColumn
        '
        Me.BooknameDataGridViewTextBoxColumn.DataPropertyName = "bookname"
        Me.BooknameDataGridViewTextBoxColumn.HeaderText = "Bookname"
        Me.BooknameDataGridViewTextBoxColumn.Name = "BooknameDataGridViewTextBoxColumn"
        '
        'ReturndateDataGridViewTextBoxColumn
        '
        Me.ReturndateDataGridViewTextBoxColumn.DataPropertyName = "returndate"
        Me.ReturndateDataGridViewTextBoxColumn.HeaderText = "Returndate"
        Me.ReturndateDataGridViewTextBoxColumn.Name = "ReturndateDataGridViewTextBoxColumn"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(3, 153)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(117, 16)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Branch name :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.StudentrecordsBindingSource1, "rollno", True))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(126, 153)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 16)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Label11"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(209, 221)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(336, 150)
        Me.Panel1.TabIndex = 32
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources._20160304_21_29_28
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1129, 534)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form7"
        Me.Text = "Form7"
        CType(Me.StudentrecordsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ManagementDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentrecordsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ManagementDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ManagementDataSet5 As WindowsApplication1.managementDataSet5
    Friend WithEvents StudentrecordsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents StudentrecordsTableAdapter As WindowsApplication1.managementDataSet5TableAdapters.studentrecordsTableAdapter
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents ManagementDataSet6 As WindowsApplication1.managementDataSet6
    Friend WithEvents StudentrecordsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentrecordsTableAdapter1 As WindowsApplication1.managementDataSet6TableAdapters.studentrecordsTableAdapter
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents BookidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IssuedateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BooknameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReturndateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
