namespace AldhiyaKoneksi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.siswasDataSet = new AldhiyaKoneksi.siswasDataSet();
            this.siswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siswaTableAdapter = new AldhiyaKoneksi.siswasDataSetTableAdapters.siswaTableAdapter();
            this.nisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kelasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siswasDataSet1 = new AldhiyaKoneksi.siswasDataSet1();
            this.siswatblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siswatblTableAdapter = new AldhiyaKoneksi.siswasDataSet1TableAdapters.siswatblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswasDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswatblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nisDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.kelasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.siswatblBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(83, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(576, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // siswasDataSet
            // 
            this.siswasDataSet.DataSetName = "siswasDataSet";
            this.siswasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siswaBindingSource
            // 
            this.siswaBindingSource.DataMember = "siswa";
            this.siswaBindingSource.DataSource = this.siswasDataSet;
            // 
            // siswaTableAdapter
            // 
            this.siswaTableAdapter.ClearBeforeFill = true;
            // 
            // nisDataGridViewTextBoxColumn
            // 
            this.nisDataGridViewTextBoxColumn.DataPropertyName = "nis";
            this.nisDataGridViewTextBoxColumn.HeaderText = "nis";
            this.nisDataGridViewTextBoxColumn.Name = "nisDataGridViewTextBoxColumn";
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "nama";
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            // 
            // kelasDataGridViewTextBoxColumn
            // 
            this.kelasDataGridViewTextBoxColumn.DataPropertyName = "kelas";
            this.kelasDataGridViewTextBoxColumn.HeaderText = "kelas";
            this.kelasDataGridViewTextBoxColumn.Name = "kelasDataGridViewTextBoxColumn";
            // 
            // siswasDataSet1
            // 
            this.siswasDataSet1.DataSetName = "siswasDataSet1";
            this.siswasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siswatblBindingSource
            // 
            this.siswatblBindingSource.DataMember = "siswatbl";
            this.siswatblBindingSource.DataSource = this.siswasDataSet1;
            // 
            // siswatblTableAdapter
            // 
            this.siswatblTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 393);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswasDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswatblBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private siswasDataSet siswasDataSet;
        private System.Windows.Forms.BindingSource siswaBindingSource;
        private siswasDataSetTableAdapters.siswaTableAdapter siswaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kelasDataGridViewTextBoxColumn;
        private siswasDataSet1 siswasDataSet1;
        private System.Windows.Forms.BindingSource siswatblBindingSource;
        private siswasDataSet1TableAdapters.siswatblTableAdapter siswatblTableAdapter;
    }
}

