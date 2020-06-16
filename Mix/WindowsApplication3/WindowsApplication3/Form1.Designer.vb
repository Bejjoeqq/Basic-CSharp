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
        Me.PegawaiDataSet = New WindowsApplication3.pegawaiDataSet()
        Me.GajiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GajiTableAdapter = New WindowsApplication3.pegawaiDataSetTableAdapters.gajiTableAdapter()
        Me.NipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoslipDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TanggalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PeriodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GajiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PegawaiDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GajiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NipDataGridViewTextBoxColumn, Me.NoslipDataGridViewTextBoxColumn, Me.TanggalDataGridViewTextBoxColumn, Me.PeriodeDataGridViewTextBoxColumn, Me.GajiDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.GajiBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(3, 249)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(553, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'PegawaiDataSet
        '
        Me.PegawaiDataSet.DataSetName = "pegawaiDataSet"
        Me.PegawaiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GajiBindingSource
        '
        Me.GajiBindingSource.DataMember = "gaji"
        Me.GajiBindingSource.DataSource = Me.PegawaiDataSet
        '
        'GajiTableAdapter
        '
        Me.GajiTableAdapter.ClearBeforeFill = True
        '
        'NipDataGridViewTextBoxColumn
        '
        Me.NipDataGridViewTextBoxColumn.DataPropertyName = "nip"
        Me.NipDataGridViewTextBoxColumn.HeaderText = "nip"
        Me.NipDataGridViewTextBoxColumn.Name = "NipDataGridViewTextBoxColumn"
        '
        'NoslipDataGridViewTextBoxColumn
        '
        Me.NoslipDataGridViewTextBoxColumn.DataPropertyName = "no_slip"
        Me.NoslipDataGridViewTextBoxColumn.HeaderText = "no_slip"
        Me.NoslipDataGridViewTextBoxColumn.Name = "NoslipDataGridViewTextBoxColumn"
        '
        'TanggalDataGridViewTextBoxColumn
        '
        Me.TanggalDataGridViewTextBoxColumn.DataPropertyName = "tanggal"
        Me.TanggalDataGridViewTextBoxColumn.HeaderText = "tanggal"
        Me.TanggalDataGridViewTextBoxColumn.Name = "TanggalDataGridViewTextBoxColumn"
        '
        'PeriodeDataGridViewTextBoxColumn
        '
        Me.PeriodeDataGridViewTextBoxColumn.DataPropertyName = "periode"
        Me.PeriodeDataGridViewTextBoxColumn.HeaderText = "periode"
        Me.PeriodeDataGridViewTextBoxColumn.Name = "PeriodeDataGridViewTextBoxColumn"
        '
        'GajiDataGridViewTextBoxColumn
        '
        Me.GajiDataGridViewTextBoxColumn.DataPropertyName = "gaji"
        Me.GajiDataGridViewTextBoxColumn.HeaderText = "gaji"
        Me.GajiDataGridViewTextBoxColumn.Name = "GajiDataGridViewTextBoxColumn"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(234, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 17)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Gaji"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(424, 203)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Ubah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(237, 203)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 37
        Me.btnTambah.Text = "Simpan"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(50, 203)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 36
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 17)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "gaji"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "periode"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 17)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "tanggal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "no slip"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 17)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "nip"
        '
        'txtpro
        '
        Me.txtpro.Location = New System.Drawing.Point(175, 162)
        Me.txtpro.Name = "txtpro"
        Me.txtpro.Size = New System.Drawing.Size(324, 22)
        Me.txtpro.TabIndex = 30
        '
        'txtkab
        '
        Me.txtkab.Location = New System.Drawing.Point(175, 134)
        Me.txtkab.Name = "txtkab"
        Me.txtkab.Size = New System.Drawing.Size(324, 22)
        Me.txtkab.TabIndex = 29
        '
        'txtkec
        '
        Me.txtkec.Location = New System.Drawing.Point(175, 106)
        Me.txtkec.Name = "txtkec"
        Me.txtkec.Size = New System.Drawing.Size(324, 22)
        Me.txtkec.TabIndex = 28
        '
        'txtkel
        '
        Me.txtkel.Location = New System.Drawing.Point(175, 78)
        Me.txtkel.Name = "txtkel"
        Me.txtkel.Size = New System.Drawing.Size(324, 22)
        Me.txtkel.TabIndex = 27
        '
        'txtpos
        '
        Me.txtpos.Location = New System.Drawing.Point(175, 50)
        Me.txtpos.Name = "txtpos"
        Me.txtpos.Size = New System.Drawing.Size(324, 22)
        Me.txtpos.TabIndex = 26
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 399)
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
        CType(Me.PegawaiDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GajiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PegawaiDataSet As WindowsApplication3.pegawaiDataSet
    Friend WithEvents GajiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GajiTableAdapter As WindowsApplication3.pegawaiDataSetTableAdapters.gajiTableAdapter
    Friend WithEvents NipDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoslipDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TanggalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PeriodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GajiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
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

End Class
