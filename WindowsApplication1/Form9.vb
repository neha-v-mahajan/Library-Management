Imports System.Data.OleDb
Imports System.Data

Public Class Form9
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\WindowsApplication1\WindowsApplication1\management.accdb")
    
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Hide()
        Form10.Show()
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\WindowsApplication1\WindowsApplication1\management.accdb")
        Dim cmd2 As OleDbCommand = New OleDbCommand("select * from staff where staffname='" & TextBox2.Text & "' and [contact]='" & TextBox1.Text & "' and branch='" & ComboBox1.Text & "'", con)

        con.Open()
        Dim rdd As OleDbDataReader = cmd2.ExecuteReader()
        If (rdd.Read() = True) Then
            Me.Hide()
            Form11.Show()
            Form11.Label5.Text = Me.TextBox2.Text
            Form11.Label6.Text = Me.TextBox1.Text
            Form11.Label7.Text = Me.ComboBox1.Text
            TextBox1.Clear()
            TextBox2.Clear()
        Else
            MessageBox.Show("Invalid")
        End If
        con.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.Show()
        TextBox1.Clear()
        TextBox2.Clear()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\WindowsApplication1\WindowsApplication1\management.accdb")
            con.Open()
            Dim cmd As New OleDbCommand("delete * from staff where staffname='" & TextBox2.Text & "' and [contact]='" & TextBox1.Text & "'", con)
            cmd.ExecuteNonQuery()
            TextBox1.Clear()
            TextBox2.Clear()
            MessageBox.Show("Record Deleted Successfully")
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Error Occured")
        End Try

    End Sub

    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub
End Class