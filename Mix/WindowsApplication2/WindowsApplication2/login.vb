Imports MySql.Data.MySqlClient
Public Class login

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Call connectt()
            Dim str As String
            str = "select * from siswa where nis='" & TextBox1.Text & "' and nama='" & TextBox2.Text & "'"
            cmd = New MySqlCommand(str, conn)
            rd = cmd.ExecuteReader
            If rd.HasRows Then
                Form5.Visible = True
                Form5.Enabled = True
                MessageBox.Show("Berhasil")
                Me.Hide()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class