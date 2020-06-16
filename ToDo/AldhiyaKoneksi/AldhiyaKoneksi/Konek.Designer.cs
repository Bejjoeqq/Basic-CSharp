namespace AldhiyaKoneksi
{
    partial class Konek
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.siswasDataSet2 = new AldhiyaKoneksi.siswasDataSet2();
            this.siswatblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.siswatblTableAdapter = new AldhiyaKoneksi.siswasDataSet2TableAdapters.siswatblTableAdapter();
            this.nisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kelasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswasDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswatblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Koneksi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(2, 152);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(435, 100);
            this.listBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nisDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.kelasDataGridViewTextBoxColumn,
            this.prodiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.siswatblBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 258);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(435, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // siswasDataSet2
            // 
            this.siswasDataSet2.DataSetName = "siswasDataSet2";
            this.siswasDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // siswatblBindingSource
            // 
            this.siswatblBindingSource.DataMember = "siswatbl";
            this.siswatblBindingSource.DataSource = this.siswasDataSet2;
            // 
            // siswatblTableAdapter
            // 
            this.siswatblTableAdapter.ClearBeforeFill = true;
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
            // prodiDataGridViewTextBoxColumn
            // 
            this.prodiDataGridViewTextBoxColumn.DataPropertyName = "prodi";
            this.prodiDataGridViewTextBoxColumn.HeaderText = "prodi";
            this.prodiDataGridViewTextBoxColumn.Name = "prodiDataGridViewTextBoxColumn";
            // 
            // Konek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 408);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "Konek";
            this.Text = "Konek";
            this.Load += new System.EventHandler(this.Konek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswasDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siswatblBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private siswasDataSet2 siswasDataSet2;
        private System.Windows.Forms.BindingSource siswatblBindingSource;
        private siswasDataSet2TableAdapters.siswatblTableAdapter siswatblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kelasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodiDataGridViewTextBoxColumn;
    }
}