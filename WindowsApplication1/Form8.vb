Imports System.Data
Imports System.Data.OleDb

Public Class Form8

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim str = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\WindowsApplication1\WindowsApplication1\management.accdb"
        Dim connection As New OleDbConnection(str)
        Dim cmd1 As New OleDbCommand
        Dim ra As New Integer

        Try
            connection.Open()
            Dim com As String = "select * from books where bookname='" & ComboBox1.SelectedItem.ToString & "'"
            Dim adpt As New OleDbDataAdapter(com, connection)

            Dim ds As New DataSet()
            adpt.Fill(ds, "books")
            DataGridView2.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ManagementDataSet1.books' table. You can move, or remove it, as needed.
        ' Me.BooksTableAdapter.Fill(Me.ManagementDataSet1.books)
        
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form7.Show()
        Form7.TextBox3.Text = TextBox1.Text
        Form7.TextBox4.Text = ComboBox1.Text
        TextBox1.Clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Hide()
        Form11.Show()
        Form11.TextBox3.Text = TextBox1.Text
        Form11.TextBox4.Text = ComboBox1.Text
        TextBox1.Clear()

    End Sub
End Class