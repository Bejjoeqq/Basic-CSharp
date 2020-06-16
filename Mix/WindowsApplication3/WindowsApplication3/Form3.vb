Imports MySql.Data.MySqlClient

Public Class Form3
    Sub bersih()
        txtkec.Text = ""
        txtkel.Text = ""
        txtpos.Text = ""
    End Sub

    Sub tampilalamat()
        Try
            Call connectt()
            da = New MySqlDataAdapter("select * from kasir order by kode_kasir asc", conn)
            ds = New DataSet
            da.Fill(ds, "kasir")
            DataGridView1.DataSource = ds.Tables("kasir")
        Catch ex As Exception

        End Try

    End Sub

    Sub simpan()
        Try
            Call connectt()
            Dim str As String
            str = "insert into kasir(kode_kasir,nama_kasir,password) values('" & txtpos.Text & "','" & txtkel.Text & "','" & txtkec.Text & "')"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Berhasil", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Gagal", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub ubah()
        Try
            Call connectt()
            Dim str As String
            str = "update kasir set kode_kasir='" & txtpos.Text & "',nama_kasir='" & txtkel.Text & "',password='" & txtkec.Text & "' where kode_kasir='" & txtpos.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Berhasil", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Gagal", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub


    Sub hapus()
        Try
            Call connectt()
            Dim str As String
            str = "delete from kasir where kode_kasir='" & txtpos.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Berhasil", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Gagal", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KasirTableAdapter.Fill(Me.PegawaiDataSet2.kasir)

    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        If (MessageBox.Show("Yakin Ingin Menghapus", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            Call hapus()
            Call bersih()
            Call tampilalamat()
        End If
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        If (MessageBox.Show("Yakin Ingin Menyimpan", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            Call simpan()
            Call bersih()
            Call tampilalamat()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (MessageBox.Show("Yakin Ingin Mengubah", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            Call ubah()
            Call bersih()
            Call tampilalamat()
        End If
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Try
            txtpos.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Catch ex As Exception

        End Try
    End Sub
End Class