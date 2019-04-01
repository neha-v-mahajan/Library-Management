Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
        Form2.TextBox2.Clear()
        Form2.TextBox1.Clear()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If RadioButton2.Checked Then
            Me.Hide()
            Form9.Show()
        ElseIf RadioButton1.Checked Then
            Me.Hide()
            Form5.Show()
        Else
            MessageBox.Show("Please , Choose the module")
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

    End Sub


End Class