Imports System.Data.OleDb
Imports System.Data
Public Class Form5
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\WindowsApplication1\WindowsApplication1\management.accdb")

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Form6.Show()
        TextBox2.Clear()
        TextBox1.Clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Form3.Show()
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\WindowsApplication1\WindowsApplication1\management.accdb")
        Dim cmd1 As OleDbCommand = New OleDbCommand("select * from student where studname='" & TextBox1.Text & "' and [rollno]='" & TextBox2.Text & "'", con)

        con.Open()
        Dim rd As OleDbDataReader = cmd1.ExecuteReader()
        If (rd.Read() = True) Then
            Me.Hide()
            Form7.Show()
            Form7.Label5.Text = Me.TextBox1.Text
            Form7.Label6.Text = Me.TextBox2.Text
            Form7.Label11.Text = Me.ComboBox1.Text
            TextBox1.Clear()
            TextBox2.Clear()


        Else
            MessageBox.Show("Invalid")
        End If
        con.Close()

    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ManagementDataSet.student' table. You can move, or remove it, as needed

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\WindowsApplication1\WindowsApplication1\management.accdb")
            con.Open()
            Dim cmd As New OleDbCommand("delete * from student where studname='" & TextBox1.Text & "' and [rollno]='" & TextBox2.Text & "'", con)
            cmd.ExecuteNonQuery()
            TextBox1.Clear()
            TextBox2.Clear()
            MessageBox.Show("Record Deleted Successfully")
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error Occured")
        End Try
    End Sub
End Class