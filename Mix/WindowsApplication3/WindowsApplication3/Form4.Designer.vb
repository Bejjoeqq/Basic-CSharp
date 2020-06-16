<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtkab = New System.Windows.Forms.TextBox()
        Me.txtkec = New System.Windows.Forms.TextBox()
        Me.txtkel = New System.Windows.Forms.TextBox()
        Me.txtpos = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PegawaiDataSet3 = New WindowsApplication3.pegawaiDataSet3()
        Me.PegawaiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PegawaiTableAdapter = New WindowsApplication3.pegawaiDataSet3TableAdapters.pegawaiTableAdapter()
        Me.NipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamapegawaiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JabatanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PegawaiDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PegawaiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(262, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 17)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Pegawai"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(452, 237)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "Ubah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(265, 237)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 52
        Me.btnTambah.Text = "Simpan"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(78, 237)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 51
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(84, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 17)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "jabatan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 17)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "alamat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "nama_pegawai"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 17)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "nip"
        '
        'txtkab
        '
        Me.txtkab.Location = New System.Drawing.Point(203, 168)
        Me.txtkab.Name = "txtkab"
        Me.txtkab.Size = New System.Drawing.Size(324, 22)
        Me.txtkab.TabIndex = 44
        '
        'txtkec
        '
        Me.txtkec.Location = New System.Drawing.Point(203, 140)
        Me.txtkec.Name = "txtkec"
        Me.txtkec.Size = New System.Drawing.Size(324, 22)
        Me.txtkec.TabIndex = 43
        '
        'txtkel
        '
        Me.txtkel.Location = New System.Drawing.Point(203, 112)
        Me.txtkel.Name = "txtkel"
        Me.txtkel.Size = New System.Drawing.Size(324, 22)
        Me.txtkel.TabIndex = 42
        '
        'txtpos
        '
        Me.txtpos.Location = New System.Drawing.Point(203, 84)
        Me.txtpos.Name = "txtpos"
        Me.txtpos.Size = New System.Drawing.Size(324, 22)
        Me.txtpos.TabIndex = 41
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NipDataGridViewTextBoxColumn, Me.NamapegawaiDataGridViewTextBoxColumn, Me.AlamatDataGridViewTextBoxColumn, Me.JabatanDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PegawaiBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(31, 283)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(553, 150)
        Me.DataGridView1.TabIndex = 40
        '
        'PegawaiDataSet3
        '
        Me.PegawaiDataSet3.DataSetName = "pegawaiDataSet3"
        Me.PegawaiDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PegawaiBindingSource
        '
        Me.PegawaiBindingSource.DataMember = "pegawai"
        Me.PegawaiBindingSource.DataSource = Me.PegawaiDataSet3
        '
        'PegawaiTableAdapter
        '
        Me.PegawaiTableAdapter.ClearBeforeFill = True
        '
        'NipDataGridViewTextBoxColumn
        '
        Me.NipDataGridViewTextBoxColumn.DataPropertyName = "nip"
        Me.NipDataGridViewTextBoxColumn.HeaderText = "nip"
        Me.NipDataGridViewTextBoxColumn.Name = "NipDataGridViewTextBoxColumn"
        '
        'NamapegawaiDataGridViewTextBoxColumn
        '
        Me.NamapegawaiDataGridViewTextBoxColumn.DataPropertyName = "nama_pegawai"
        Me.NamapegawaiDataGridViewTextBoxColumn.HeaderText = "nama_pegawai"
        Me.NamapegawaiDataGridViewTextBoxColumn.Name = "NamapegawaiDataGridViewTextBoxColumn"
        '
        'AlamatDataGridViewTextBoxColumn
        '
        Me.AlamatDataGridViewTextBoxColumn.DataPropertyName = "alamat"
        Me.AlamatDataGridViewTextBoxColumn.HeaderText = "alamat"
        Me.AlamatDataGridViewTextBoxColumn.Name = "AlamatDataGridViewTextBoxColumn"
        '
        'JabatanDataGridViewTextBoxColumn
        '
        Me.JabatanDataGridViewTextBoxColumn.DataPropertyName = "jabatan"
        Me.JabatanDataGridViewTextBoxColumn.HeaderText = "jabatan"
        Me.JabatanDataGridViewTextBoxColumn.Name = "JabatanDataGridViewTextBoxColumn"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 473)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtkab)
        Me.Controls.Add(Me.txtkec)
        Me.Controls.Add(Me.txtkel)
        Me.Controls.Add(Me.txtpos)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PegawaiDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PegawaiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtkab As System.Windows.Forms.TextBox
    Friend WithEvents txtkec As System.Windows.Forms.TextBox
    Friend WithEvents txtkel As System.Windows.Forms.TextBox
    Friend WithEvents txtpos As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PegawaiDataSet3 As WindowsApplication3.pegawaiDataSet3
    Friend WithEvents PegawaiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PegawaiTableAdapter As WindowsApplication3.pegawaiDataSet3TableAdapters.pegawaiTableAdapter
    Friend WithEvents NipDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamapegawaiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlamatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JabatanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
