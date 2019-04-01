Imports System.Data.OleDb
Imports System.Data

Public Class Form4
    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ManagementDataSet.admin' table. You can move, or remove it, as needed.
        'Me.AdminTableAdapter.Fill(Me.ManagementDataSet.admin)
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim update As String = "update admin SET [password]='" & TextBox4.Text & "' where [password]='" & TextBox3.Text & "' ;"
        Dim update1 As String = "update admin SET [username]='" & TextBox2.Text & "' where [username]='" & TextBox1.Text & "' ;"
        Using cnn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\WindowsApplication1\WindowsApplication1\management.accdb")
            Using cmd1 As New OleDb.OleDbCommand(update, cnn)
                Using cmd As New OleDb.OleDbCommand(update1, cnn)

                    cmd1.Connection = cnn
                    cmd.Connection = cnn
                    cnn.Open()

                    If cmd1.ExecuteNonQuery() And cmd.ExecuteNonQuery Then
                        TextBox3.Clear()
                        TextBox4.Clear()
                        TextBox2.Clear()
                        TextBox1.Clear()
                        MessageBox.Show("Successfully Save")
                    Else
                        MessageBox.Show("Try Again")

                    End If
                    cnn.Close()
                End Using
            End Using
        End Using
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class