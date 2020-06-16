<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.KodemapelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamamapelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodeprasyaratDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MapelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SiswasDataSet2 = New WindowsApplication2.siswasDataSet2()
        Me.MapelTableAdapter = New WindowsApplication2.siswasDataSet2TableAdapters.mapelTableAdapter()
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MapelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SiswasDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodemapelDataGridViewTextBoxColumn, Me.NamamapelDataGridViewTextBoxColumn, Me.JpDataGridViewTextBoxColumn, Me.KodeprasyaratDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MapelBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(1, 242)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(449, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'KodemapelDataGridViewTextBoxColumn
        '
        Me.KodemapelDataGridViewTextBoxColumn.DataPropertyName = "kode_mapel"
        Me.KodemapelDataGridViewTextBoxColumn.HeaderText = "kode_mapel"
        Me.KodemapelDataGridViewTextBoxColumn.Name = "KodemapelDataGridViewTextBoxColumn"
        '
        'NamamapelDataGridViewTextBoxColumn
        '
        Me.NamamapelDataGridViewTextBoxColumn.DataPropertyName = "nama_mapel"
        Me.NamamapelDataGridViewTextBoxColumn.HeaderText = "nama_mapel"
        Me.NamamapelDataGridViewTextBoxColumn.Name = "NamamapelDataGridViewTextBoxColumn"
        '
        'JpDataGridViewTextBoxColumn
        '
        Me.JpDataGridViewTextBoxColumn.DataPropertyName = "jp"
        Me.JpDataGridViewTextBoxColumn.HeaderText = "jp"
        Me.JpDataGridViewTextBoxColumn.Name = "JpDataGridViewTextBoxColumn"
        '
        'KodeprasyaratDataGridViewTextBoxColumn
        '
        Me.KodeprasyaratDataGridViewTextBoxColumn.DataPropertyName = "kode_prasyarat"
        Me.KodeprasyaratDataGridViewTextBoxColumn.HeaderText = "kode_prasyarat"
        Me.KodeprasyaratDataGridViewTextBoxColumn.Name = "KodeprasyaratDataGridViewTextBoxColumn"
        '
        'MapelBindingSource
        '
        Me.MapelBindingSource.DataMember = "mapel"
        Me.MapelBindingSource.DataSource = Me.SiswasDataSet2
        '
        'SiswasDataSet2
        '
        Me.SiswasDataSet2.DataSetName = "siswasDataSet2"
        Me.SiswasDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MapelTableAdapter
        '
        Me.MapelTableAdapter.ClearBeforeFill = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(209, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 17)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Mapel"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(350, 201)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Ubah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(185, 201)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 37
        Me.btnTambah.Text = "Simpan"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(25, 201)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 36
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 17)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Kode Prasyarat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 17)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "JP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 17)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Nama Mapel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 17)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Kode Mapel"
        '
        'txtkab
        '
        Me.txtkab.Location = New System.Drawing.Point(150, 132)
        Me.txtkab.Name = "txtkab"
        Me.txtkab.Size = New System.Drawing.Size(275, 22)
        Me.txtkab.TabIndex = 29
        '
        'txtkec
        '
        Me.txtkec.Location = New System.Drawing.Point(150, 104)
        Me.txtkec.Name = "txtkec"
        Me.txtkec.Size = New System.Drawing.Size(275, 22)
        Me.txtkec.TabIndex = 28
        '
        'txtkel
        '
        Me.txtkel.Location = New System.Drawing.Point(150, 76)
        Me.txtkel.Name = "txtkel"
        Me.txtkel.Size = New System.Drawing.Size(275, 22)
        Me.txtkel.TabIndex = 27
        '
        'txtpos
        '
        Me.txtpos.Location = New System.Drawing.Point(150, 48)
        Me.txtpos.Name = "txtpos"
        Me.txtpos.Size = New System.Drawing.Size(275, 22)
        Me.txtpos.TabIndex = 26
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 391)
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
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MapelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiswasDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SiswasDataSet2 As WindowsApplication2.siswasDataSet2
    Friend WithEvents MapelBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MapelTableAdapter As WindowsApplication2.siswasDataSet2TableAdapters.mapelTableAdapter
    Friend WithEvents KodemapelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamamapelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JpDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KodeprasyaratDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
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
End Class
