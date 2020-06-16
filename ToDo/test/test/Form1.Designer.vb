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
        Me.BukuDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BukuDataSet = New test.BukuDataSet()
        Me.PenerbanganDataSet1 = New test.penerbanganDataSet1()
        Me.JadwalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JadwalTableAdapter = New test.penerbanganDataSet1TableAdapters.jadwalTableAdapter()
        Me.KodepenerbanganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodetujuanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PergipulangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BukuDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BukuDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenerbanganDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JadwalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodepenerbanganDataGridViewTextBoxColumn, Me.KodetujuanDataGridViewTextBoxColumn, Me.PergipulangDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.JadwalBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(70, 53)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(516, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'BukuDataSetBindingSource
        '
        Me.BukuDataSetBindingSource.DataSource = Me.BukuDataSet
        Me.BukuDataSetBindingSource.Position = 0
        '
        'BukuDataSet
        '
        Me.BukuDataSet.DataSetName = "BukuDataSet"
        Me.BukuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PenerbanganDataSet1
        '
        Me.PenerbanganDataSet1.DataSetName = "penerbanganDataSet1"
        Me.PenerbanganDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JadwalBindingSource
        '
        Me.JadwalBindingSource.DataMember = "jadwal"
        Me.JadwalBindingSource.DataSource = Me.PenerbanganDataSet1
        '
        'JadwalTableAdapter
        '
        Me.JadwalTableAdapter.ClearBeforeFill = True
        '
        'KodepenerbanganDataGridViewTextBoxColumn
        '
        Me.KodepenerbanganDataGridViewTextBoxColumn.DataPropertyName = "kode_penerbangan"
        Me.KodepenerbanganDataGridViewTextBoxColumn.HeaderText = "kode_penerbangan"
        Me.KodepenerbanganDataGridViewTextBoxColumn.Name = "KodepenerbanganDataGridViewTextBoxColumn"
        '
        'KodetujuanDataGridViewTextBoxColumn
        '
        Me.KodetujuanDataGridViewTextBoxColumn.DataPropertyName = "kode_tujuan"
        Me.KodetujuanDataGridViewTextBoxColumn.HeaderText = "kode_tujuan"
        Me.KodetujuanDataGridViewTextBoxColumn.Name = "KodetujuanDataGridViewTextBoxColumn"
        '
        'PergipulangDataGridViewTextBoxColumn
        '
        Me.PergipulangDataGridViewTextBoxColumn.DataPropertyName = "pergi_pulang"
        Me.PergipulangDataGridViewTextBoxColumn.HeaderText = "pergi_pulang"
        Me.PergipulangDataGridViewTextBoxColumn.Name = "PergipulangDataGridViewTextBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 253)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BukuDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BukuDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenerbanganDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JadwalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BukuDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BukuDataSet As test.BukuDataSet
    Friend WithEvents PenerbanganDataSet1 As test.penerbanganDataSet1
    Friend WithEvents JadwalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents JadwalTableAdapter As test.penerbanganDataSet1TableAdapters.jadwalTableAdapter
    Friend WithEvents KodepenerbanganDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KodetujuanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PergipulangDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
