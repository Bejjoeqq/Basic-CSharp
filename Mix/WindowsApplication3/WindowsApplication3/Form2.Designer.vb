<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtkec = New System.Windows.Forms.TextBox()
        Me.txtkel = New System.Windows.Forms.TextBox()
        Me.txtpos = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PegawaiDataSet1 = New WindowsApplication3.pegawaiDataSet1()
        Me.JabatanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JabatanTableAdapter = New WindowsApplication3.pegawaiDataSet1TableAdapters.jabatanTableAdapter()
        Me.KodejabatanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamajabatanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GajiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PegawaiDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JabatanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(231, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 17)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Jabatan"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(421, 201)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "Ubah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(234, 201)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 52
        Me.btnTambah.Text = "Simpan"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(47, 201)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 51
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 17)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "gaji"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "nama_jabatan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 17)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "kode_jabatan"
        '
        'txtkec
        '
        Me.txtkec.Location = New System.Drawing.Point(172, 104)
        Me.txtkec.Name = "txtkec"
        Me.txtkec.Size = New System.Drawing.Size(324, 22)
        Me.txtkec.TabIndex = 43
        '
        'txtkel
        '
        Me.txtkel.Location = New System.Drawing.Point(172, 76)
        Me.txtkel.Name = "txtkel"
        Me.txtkel.Size = New System.Drawing.Size(324, 22)
        Me.txtkel.TabIndex = 42
        '
        'txtpos
        '
        Me.txtpos.Location = New System.Drawing.Point(172, 48)
        Me.txtpos.Name = "txtpos"
        Me.txtpos.Size = New System.Drawing.Size(324, 22)
        Me.txtpos.TabIndex = 41
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodejabatanDataGridViewTextBoxColumn, Me.NamajabatanDataGridViewTextBoxColumn, Me.GajiDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.JabatanBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 247)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(553, 150)
        Me.DataGridView1.TabIndex = 40
        '
        'PegawaiDataSet1
        '
        Me.PegawaiDataSet1.DataSetName = "pegawaiDataSet1"
        Me.PegawaiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JabatanBindingSource
        '
        Me.JabatanBindingSource.DataMember = "jabatan"
        Me.JabatanBindingSource.DataSource = Me.PegawaiDataSet1
        '
        'JabatanTableAdapter
        '
        Me.JabatanTableAdapter.ClearBeforeFill = True
        '
        'KodejabatanDataGridViewTextBoxColumn
        '
        Me.KodejabatanDataGridViewTextBoxColumn.DataPropertyName = "kode_jabatan"
        Me.KodejabatanDataGridViewTextBoxColumn.HeaderText = "kode_jabatan"
        Me.KodejabatanDataGridViewTextBoxColumn.Name = "KodejabatanDataGridViewTextBoxColumn"
        '
        'NamajabatanDataGridViewTextBoxColumn
        '
        Me.NamajabatanDataGridViewTextBoxColumn.DataPropertyName = "nama_jabatan"
        Me.NamajabatanDataGridViewTextBoxColumn.HeaderText = "nama_jabatan"
        Me.NamajabatanDataGridViewTextBoxColumn.Name = "NamajabatanDataGridViewTextBoxColumn"
        '
        'GajiDataGridViewTextBoxColumn
        '
        Me.GajiDataGridViewTextBoxColumn.DataPropertyName = "gaji"
        Me.GajiDataGridViewTextBoxColumn.HeaderText = "gaji"
        Me.GajiDataGridViewTextBoxColumn.Name = "GajiDataGridViewTextBoxColumn"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 398)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtkec)
        Me.Controls.Add(Me.txtkel)
        Me.Controls.Add(Me.txtpos)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PegawaiDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JabatanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtkec As System.Windows.Forms.TextBox
    Friend WithEvents txtkel As System.Windows.Forms.TextBox
    Friend WithEvents txtpos As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PegawaiDataSet1 As WindowsApplication3.pegawaiDataSet1
    Friend WithEvents JabatanBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JabatanTableAdapter As WindowsApplication3.pegawaiDataSet1TableAdapters.jabatanTableAdapter
    Friend WithEvents KodejabatanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamajabatanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GajiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
