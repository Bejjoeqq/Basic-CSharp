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
        Me.txtpos = New System.Windows.Forms.TextBox()
        Me.txtkel = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.KodeagamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaagamaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgamaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SiswasDataSet1 = New WindowsApplication2.siswasDataSet1()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AgamaTableAdapter = New WindowsApplication2.siswasDataSet1TableAdapters.agamaTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgamaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SiswasDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtpos
        '
        Me.txtpos.Location = New System.Drawing.Point(122, 47)
        Me.txtpos.Name = "txtpos"
        Me.txtpos.Size = New System.Drawing.Size(213, 22)
        Me.txtpos.TabIndex = 0
        '
        'txtkel
        '
        Me.txtkel.Location = New System.Drawing.Point(122, 75)
        Me.txtkel.Name = "txtkel"
        Me.txtkel.Size = New System.Drawing.Size(213, 22)
        Me.txtkel.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Kode Agama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nama Agama"
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(57, 106)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 10
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(138, 106)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 11
        Me.btnTambah.Text = "Simpan"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeagamaDataGridViewTextBoxColumn, Me.NamaagamaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AgamaBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(15, 135)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(320, 150)
        Me.DataGridView1.TabIndex = 12
        '
        'KodeagamaDataGridViewTextBoxColumn
        '
        Me.KodeagamaDataGridViewTextBoxColumn.DataPropertyName = "kode_agama"
        Me.KodeagamaDataGridViewTextBoxColumn.HeaderText = "kode_agama"
        Me.KodeagamaDataGridViewTextBoxColumn.Name = "KodeagamaDataGridViewTextBoxColumn"
        '
        'NamaagamaDataGridViewTextBoxColumn
        '
        Me.NamaagamaDataGridViewTextBoxColumn.DataPropertyName = "nama_agama"
        Me.NamaagamaDataGridViewTextBoxColumn.HeaderText = "nama_agama"
        Me.NamaagamaDataGridViewTextBoxColumn.Name = "NamaagamaDataGridViewTextBoxColumn"
        '
        'AgamaBindingSource
        '
        Me.AgamaBindingSource.DataMember = "agama"
        Me.AgamaBindingSource.DataSource = Me.SiswasDataSet1
        '
        'SiswasDataSet1
        '
        Me.SiswasDataSet1.DataSetName = "siswasDataSet1"
        Me.SiswasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(219, 106)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Ubah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AgamaTableAdapter
        '
        Me.AgamaTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(135, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 17)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Agama"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 298)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtkel)
        Me.Controls.Add(Me.txtpos)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgamaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiswasDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtpos As System.Windows.Forms.TextBox
    Friend WithEvents txtkel As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SiswasDataSet1 As WindowsApplication2.siswasDataSet1
    Friend WithEvents AgamaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AgamaTableAdapter As WindowsApplication2.siswasDataSet1TableAdapters.agamaTableAdapter
    Friend WithEvents KodeagamaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaagamaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
