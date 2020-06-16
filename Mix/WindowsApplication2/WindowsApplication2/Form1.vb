Imports MySql.Data.MySqlClient
Public Class Form1

    Sub bersih()
        txtkab.Text = ""
        txtkec.Text = ""
        txtkel.Text = ""
        txtpos.Text = ""
        txtpro.Text = ""
    End Sub

    Sub tampilalamat()
        Try
            Call connectt()
            da = New MySqlDataAdapter("select * from alamat order by kode_pos asc", conn)
            ds = New DataSet
            da.Fill(ds, "alamat")
            DataGridView1.DataSource = ds.Tables("alamat")
        Catch ex As Exception

        End Try

    End Sub

    Sub simpan()
        Try
            Call connectt()
            Dim str As String
            str = "insert into alamat(kode_pos,kelurahan,kecamatan,kabupaten,provinsi) values('" & txtpos.Text & "','" & txtkel.Text & "','" & txtkec.Text & "','" & txtkab.Text & "','" & txtpro.Text & "')"
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
            str = "update alamat set kode_pos='" & txtpos.Text & "',Kelurahan='" & txtkel.Text & "',Kecamatan='" & txtkec.Text & "',Kabupaten='" & txtkab.Text & "',Provinsi='" & txtpro.Text & "' where kode_pos='" & txtpos.Text & "'"
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
            str = "delete from alamat where kode_pos='" & txtpos.Text & "'"
            cmd = New MySqlCommand(str, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Berhasil", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Gagal", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AlamatTableAdapter.Fill(Me.SiswasDataSet.alamat)
        Call tampilalamat()
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        If (MessageBox.Show("Yakin Ingin Menyimpan", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            Call simpan()
            Call bersih()
            Call tampilalamat()
        End If
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        If (MessageBox.Show("Yakin Ingin Menghapus", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            Call hapus()
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (MessageBox.Show("Yakin Ingin Mengubah", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            Call ubah()
            Call bersih()
            Call tampilalamat()
        End If
    End Sub
End Class
