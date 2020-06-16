<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.KodeposDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KelurahanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KecamatanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KabupatenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvinsiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SiswasDataSet = New WindowsApplication2.siswasDataSet()
        Me.AlamatTableAdapter = New WindowsApplication2.siswasDataSetTableAdapters.alamatTableAdapter()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtpro = New System.Windows.Forms.TextBox()
        Me.txtkab = New System.Windows.Forms.TextBox()
        Me.txtkec = New System.Windows.Forms.TextBox()
        Me.txtkel = New System.Windows.Forms.TextBox()
        Me.txtpos = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlamatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SiswasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeposDataGridViewTextBoxColumn, Me.KelurahanDataGridViewTextBoxColumn, Me.KecamatanDataGridViewTextBoxColumn, Me.KabupatenDataGridViewTextBoxColumn, Me.ProvinsiDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AlamatBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(1, 244)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(543, 164)
        Me.DataGridView1.TabIndex = 0
        '
        'KodeposDataGridViewTextBoxColumn
        '
        Me.KodeposDataGridViewTextBoxColumn.DataPropertyName = "kode_pos"
        Me.KodeposDataGridViewTextBoxColumn.HeaderText = "kode_pos"
        Me.KodeposDataGridViewTextBoxColumn.Name = "KodeposDataGridViewTextBoxColumn"
        '
        'KelurahanDataGridViewTextBoxColumn
        '
        Me.KelurahanDataGridViewTextBoxColumn.DataPropertyName = "kelurahan"
        Me.KelurahanDataGridViewTextBoxColumn.HeaderText = "kelurahan"
        Me.KelurahanDataGridViewTextBoxColumn.Name = "KelurahanDataGridViewTextBoxColumn"
        '
        'KecamatanDataGridViewTextBoxColumn
        '
        Me.KecamatanDataGridViewTextBoxColumn.DataPropertyName = "kecamatan"
        Me.KecamatanDataGridViewTextBoxColumn.HeaderText = "kecamatan"
        Me.KecamatanDataGridViewTextBoxColumn.Name = "KecamatanDataGridViewTextBoxColumn"
        '
        'KabupatenDataGridViewTextBoxColumn
        '
        Me.KabupatenDataGridViewTextBoxColumn.DataPropertyName = "kabupaten"
        Me.KabupatenDataGridViewTextBoxColumn.HeaderText = "kabupaten"
        Me.KabupatenDataGridViewTextBoxColumn.Name = "KabupatenDataGridViewTextBoxColumn"
        '
        'ProvinsiDataGridViewTextBoxColumn
        '
        Me.ProvinsiDataGridViewTextBoxColumn.DataPropertyName = "provinsi"
        Me.ProvinsiDataGridViewTextBoxColumn.HeaderText = "provinsi"
        Me.ProvinsiDataGridViewTextBoxColumn.Name = "ProvinsiDataGridViewTextBoxColumn"
        '
        'AlamatBindingSource
        '
        Me.AlamatBindingSource.DataMember = "alamat"
        Me.AlamatBindingSource.DataSource = Me.SiswasDataSet
        '
        'SiswasDataSet
        '
        Me.SiswasDataSet.DataSetName = "siswasDataSet"
        Me.SiswasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlamatTableAdapter
        '
        Me.AlamatTableAdapter.ClearBeforeFill = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(227, 206)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 23
        Me.btnTambah.Text = "Simpan"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(40, 206)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 22
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 17)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Provinsi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 17)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Kabupaten"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Kecamatan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Kelurahan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Kode Pos"
        '
        'txtpro
        '
        Me.txtpro.Location = New System.Drawing.Point(165, 165)
        Me.txtpro.Name = "txtpro"
        Me.txtpro.Size = New System.Drawing.Size(324, 22)
        Me.txtpro.TabIndex = 16
        '
        'txtkab
        '
        Me.txtkab.Location = New System.Drawing.Point(165, 137)
        Me.txtkab.Name = "txtkab"
        Me.txtkab.Size = New System.Drawing.Size(324, 22)
        Me.txtkab.TabIndex = 15
        '
        'txtkec
        '
        Me.txtkec.Location = New System.Drawing.Point(165, 109)
        Me.txtkec.Name = "txtkec"
        Me.txtkec.Size = New System.Drawing.Size(324, 22)
        Me.txtkec.TabIndex = 14
        '
        'txtkel
        '
        Me.txtkel.Location = New System.Drawing.Point(165, 81)
        Me.txtkel.Name = "txtkel"
        Me.txtkel.Size = New System.Drawing.Size(324, 22)
        Me.txtkel.TabIndex = 13
        '
        'txtpos
        '
        Me.txtpos.Location = New System.Drawing.Point(165, 53)
        Me.txtpos.Name = "txtpos"
        Me.txtpos.Size = New System.Drawing.Size(324, 22)
        Me.txtpos.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(414, 206)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Ubah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(224, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 17)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Alamat"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 408)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtpro)
        Me.Controls.Add(Me.txtkab)
        Me.Controls.Add(Me.txtkec)
        Me.Controls.Add(Me.txtkel)
        Me.Controls.Add(Me.txtpos)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlamatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiswasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SiswasDataSet As WindowsApplication2.siswasDataSet
    Friend WithEvents AlamatBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AlamatTableAdapter As WindowsApplication2.siswasDataSetTableAdapters.alamatTableAdapter
    Friend WithEvents KodeposDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KelurahanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KecamatanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KabupatenDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvinsiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtpro As System.Windows.Forms.TextBox
    Friend WithEvents txtkab As System.Windows.Forms.TextBox
    Friend WithEvents txtkec As System.Windows.Forms.TextBox
    Friend WithEvents txtkel As System.Windows.Forms.TextBox
    Friend WithEvents txtpos As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
