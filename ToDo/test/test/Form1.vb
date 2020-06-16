Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PenerbanganDataSet1.jadwal' table. You can move, or remove it, as needed.
        Me.JadwalTableAdapter.Fill(Me.PenerbanganDataSet1.jadwal)

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
