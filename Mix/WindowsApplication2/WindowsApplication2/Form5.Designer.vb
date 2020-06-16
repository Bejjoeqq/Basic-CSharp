<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.KodeguruDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaguruDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodeagamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamajalanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodeposDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GuruBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SiswasDataSet4 = New WindowsApplication2.siswasDataSet4()
        Me.GuruTableAdapter = New WindowsApplication2.siswasDataSet4TableAdapters.guruTableAdapter()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuruBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SiswasDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeguruDataGridViewTextBoxColumn, Me.NamaguruDataGridViewTextBoxColumn, Me.JkDataGridViewTextBoxColumn, Me.KodeagamaDataGridViewTextBoxColumn, Me.NamajalanDataGridViewTextBoxColumn, Me.KodeposDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.GuruBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(-4, 245)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(670, 164)
        Me.DataGridView1.TabIndex = 1
        '
        'KodeguruDataGridViewTextBoxColumn
        '
        Me.KodeguruDataGridViewTextBoxColumn.DataPropertyName = "kode_guru"
        Me.KodeguruDataGridViewTextBoxColumn.HeaderText = "kode_guru"
        Me.KodeguruDataGridViewTextBoxColumn.Name = "KodeguruDataGridViewTextBoxColumn"
        '
        'NamaguruDataGridViewTextBoxColumn
        '
        Me.NamaguruDataGridViewTextBoxColumn.DataPropertyName = "nama_guru"
        Me.NamaguruDataGridViewTextBoxColumn.HeaderText = "nama_guru"
        Me.NamaguruDataGridViewTextBoxColumn.Name = "NamaguruDataGridViewTextBoxColumn"
        '
        'JkDataGridViewTextBoxColumn
        '
        Me.JkDataGridViewTextBoxColumn.DataPropertyName = "jk"
        Me.JkDataGridViewTextBoxColumn.HeaderText = "jk"
        Me.JkDataGridViewTextBoxColumn.Name = "JkDataGridViewTextBoxColumn"
        '
        'KodeagamaDataGridViewTextBoxColumn
        '
        Me.KodeagamaDataGridViewTextBoxColumn.DataPropertyName = "kode_agama"
        Me.KodeagamaDataGridViewTextBoxColumn.HeaderText = "kode_agama"
        Me.KodeagamaDataGridViewTextBoxColumn.Name = "KodeagamaDataGridViewTextBoxColumn"
        '
        'NamajalanDataGridViewTextBoxColumn
        '
        Me.NamajalanDataGridViewTextBoxColumn.DataPropertyName = "nama_jalan"
        Me.NamajalanDataGridViewTextBoxColumn.HeaderText = "nama_jalan"
        Me.NamajalanDataGridViewTextBoxColumn.Name = "NamajalanDataGridViewTextBoxColumn"
        '
        'KodeposDataGridViewTextBoxColumn
        '
        Me.KodeposDataGridViewTextBoxColumn.DataPropertyName = "kode_pos"
        Me.KodeposDataGridViewTextBoxColumn.HeaderText = "kode_pos"
        Me.KodeposDataGridViewTextBoxColumn.Name = "KodeposDataGridViewTextBoxColumn"
        '
        'GuruBindingSource
        '
        Me.GuruBindingSource.DataMember = "guru"
        Me.GuruBindingSource.DataSource = Me.SiswasDataSet4
        '
        'SiswasDataSet4
        '
        Me.SiswasDataSet4.DataSetName = "siswasDataSet4"
        Me.SiswasDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GuruTableAdapter
        '
        Me.GuruTableAdapter.ClearBeforeFill = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(274, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 17)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Guru"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(464, 216)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Ubah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(277, 216)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 37
        Me.btnTambah.Text = "Simpan"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(90, 216)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 36
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(96, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 17)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "nama jalan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(96, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 17)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "kode agama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(96, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 17)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "jk"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(96, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "nama guru"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(96, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "kode guru"
        '
        'txtpro
        '
        Me.txtpro.Location = New System.Drawing.Point(215, 145)
        Me.txtpro.Name = "txtpro"
        Me.txtpro.Size = New System.Drawing.Size(324, 22)
        Me.txtpro.TabIndex = 30
        '
        'txtkab
        '
        Me.txtkab.Location = New System.Drawing.Point(215, 117)
        Me.txtkab.Name = "txtkab"
        Me.txtkab.Size = New System.Drawing.Size(324, 22)
        Me.txtkab.TabIndex = 29
        '
        'txtkec
        '
        Me.txtkec.Location = New System.Drawing.Point(215, 89)
        Me.txtkec.Name = "txtkec"
        Me.txtkec.Size = New System.Drawing.Size(324, 22)
        Me.txtkec.TabIndex = 28
        '
        'txtkel
        '
        Me.txtkel.Location = New System.Drawing.Point(215, 61)
        Me.txtkel.Name = "txtkel"
        Me.txtkel.Size = New System.Drawing.Size(324, 22)
        Me.txtkel.TabIndex = 27
        '
        'txtpos
        '
        Me.txtpos.Location = New System.Drawing.Point(215, 33)
        Me.txtpos.Name = "txtpos"
        Me.txtpos.Size = New System.Drawing.Size(324, 22)
        Me.txtpos.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(96, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 17)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "kode pos"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(215, 173)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(324, 22)
        Me.TextBox1.TabIndex = 40
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 410)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox1)
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
        Me.Name = "Form5"
        Me.Text = "Form5"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuruBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiswasDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SiswasDataSet4 As WindowsApplication2.siswasDataSet4
    Friend WithEvents GuruBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GuruTableAdapter As WindowsApplication2.siswasDataSet4TableAdapters.guruTableAdapter
    Friend WithEvents KodeguruDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaguruDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JkDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KodeagamaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamajalanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KodeposDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
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
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
