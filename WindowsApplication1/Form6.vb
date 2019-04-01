Imports System.Data.OleDb
Imports System.Data
Public Class Form6
    Dim cnn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\WindowsApplication1\WindowsApplication1\management.accdb")
    Dim cmd As New OleDbCommand
    Dim ra As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form5.Show()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim insert As String = "insert into student values('" & TextBox2.Text & "','" & TextBox1.Text & "','" & ComboBox1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
        Using cnn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\WindowsApplication1\WindowsApplication1\management.accdb")
            Using cmd As New OleDb.OleDbCommand(insert, cnn)

                cmd.Connection = cnn
                cnn.Open()
                If cmd.ExecuteNonQuery() Then
                    TextBox1.Clear()
                    TextBox2.Clear()
                    TextBox3.Clear()
                    TextBox4.Clear()

                    MessageBox.Show("Successfully save")
                    Me.Hide()
                    Form5.Show()
                    Refresh()
                    Me.Button2.PerformClick()

                Else : MessageBox.Show("Try Again")

                End If
                cnn.Close()
            End Using
        End Using
    End Sub


End Class