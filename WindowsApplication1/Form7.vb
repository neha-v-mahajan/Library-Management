Imports System.Data
Imports System.Data.OleDb
Public Class Form7

    Dim cnn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\WindowsApplication1\WindowsApplication1\management.accdb")

    Public Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ManagementDataSet6.studentrecords' table. You can move, or remove it, as needed.
        'Me.StudentrecordsTableAdapter1.Fill(Me.ManagementDataSet6.studentrecords)

        'Me.StudentrecordsTableAdapter.Fill(Me.ManagementDataSet5.studentrecords)
        'TODO: This line of code loads data into the 'ManagementDataSet.student_records' table. You can move, or remove it, as needed.

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form5.Show()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub

    
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Form8.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim insert As String = "insert into studentrecords values('" & TextBox3.Text & "','" & TextBox1.Text & "','" & TextBox4.Text & "','" & TextBox2.Text & "','" & Label6.Text & "')"
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

                Else : MessageBox.Show("Try Again")

                End If

                cnn.Close()
            End Using
        End Using



    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim dbselect As String = "select issuedate,returndate,bookid,bookname from studentrecords where rollno='" & Label6.Text & "';"
        Using cnn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\WindowsApplication1\WindowsApplication1\management.accdb")


            Using selectquery As New OleDbCommand(dbselect, cnn)
                cnn.Open()
                selectquery.ExecuteReader()
                Dim resulttable As New OleDbDataAdapter(selectquery)
                Dim datatable As New DataTable("studentrecords")
                cnn.Close()
                resulttable.Fill(datatable)
                DataGridView1.DataSource = datatable

            End Using
        End Using
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim update As String = "update studentrecords SET [returndate]='" & TextBox2.Text & "' where [bookid]='" & TextBox3.Text & "';"
        Using cnn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\WindowsApplication1\WindowsApplication1\management.accdb")
            Using cmd1 As New OleDb.OleDbCommand(update, cnn)

                cmd1.Connection = cnn
                cnn.Open()
                If cmd1.ExecuteNonQuery() Then
                    TextBox3.Clear()
                    TextBox2.Clear()
                    MessageBox.Show("Successfully save")

                Else : MessageBox.Show("Try Again")

                End If
                cnn.Close()
            End Using
        End Using




    End Sub
End Class