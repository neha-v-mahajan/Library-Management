Imports System.Data.OleDb
Imports System.Data

Public Class Form10
    Dim cnn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\WindowsApplication1\WindowsApplication1\management.accdb")
    Dim cmd As New OleDbCommand
    Dim s1 As String
    Dim s2 As String
    Dim s3 As String


    Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form9.Show()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        
        Dim insert As String = "insert into staff values('" & TextBox2.Text & "','" & TextBox1.Text & "','" & ComboBox1.Text & "','" & TextBox3.Text & "','" & ComboBox2.Text & "', '" & TextBox4.Text & "')"
        Using cnn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\WindowsApplication1\WindowsApplication1\management.accdb")
            Using cmd As New OleDb.OleDbCommand(insert, cnn)

                cmd.Connection = cnn
                cnn.Open()
                If cmd.ExecuteNonQuery() Then
                    MessageBox.Show("Successfully save")
                    Refresh()
                    Me.Button2.PerformClick()
                    Me.Hide()
                    Form9.Show()
                Else : MessageBox.Show("fail")

                End If
                cnn.Close()
            End Using
        End Using

    End Sub



    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class