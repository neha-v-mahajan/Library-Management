Imports System.Data.OleDb
Imports System.Data
Public Class Form2
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
    End Sub

    ' Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    'TODO: This line of code loads data into the 'ManagementDataSet.admin' table. You can move, or remove it, as needed.
    '    Me.AdminTableAdapter.Fill(Me.ManagementDataSet.admin)
    'End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\WindowsApplication1\WindowsApplication1\management.accdb")
        Dim cmd As OleDbCommand = New OleDbCommand("select * from admin where username='" & TextBox1.Text & "' and [password]='" & TextBox2.Text & "'", con)

        con.Open()
        Dim sdr As OleDbDataReader = cmd.ExecuteReader()
        If (sdr.Read() = True) Then
            Me.Hide()
            Form3.Show()
        Else
            MessageBox.Show("Invalid")
        End If
        con.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form4.Show()
    End Sub
End Class