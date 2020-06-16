namespace Aldhiya3c
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboNama = new System.Windows.Forms.ComboBox();
            this.lstNama = new System.Windows.Forms.ListBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnKurang = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.8F);
            this.label1.Location = new System.Drawing.Point(104, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROGRAM PENGOLAH NAMA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // cboNama
            // 
            this.cboNama.FormattingEnabled = true;
            this.cboNama.Location = new System.Drawing.Point(109, 58);
            this.cboNama.Name = "cboNama";
            this.cboNama.Size = new System.Drawing.Size(226, 24);
            this.cboNama.TabIndex = 2;
            // 
            // lstNama
            // 
            this.lstNama.FormattingEnabled = true;
            this.lstNama.ItemHeight = 16;
            this.lstNama.Items.AddRange(new object[] {
            "lstNama"});
            this.lstNama.Location = new System.Drawing.Point(109, 94);
            this.lstNama.Name = "lstNama";
            this.lstNama.Size = new System.Drawing.Size(226, 164);
            this.lstNama.TabIndex = 3;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(364, 59);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 4;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnKurang
            // 
            this.btnKurang.Location = new System.Drawing.Point(364, 113);
            this.btnKurang.Name = "btnKurang";
            this.btnKurang.Size = new System.Drawing.Size(75, 23);
            this.btnKurang.TabIndex = 5;
            this.btnKurang.Text = "Kurang";
            this.btnKurang.UseVisualStyleBackColor = true;
            this.btnKurang.Click += new System.EventHandler(this.btnKurang_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(364, 235);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 23);
            this.btnKeluar.TabIndex = 6;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(364, 172);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 7;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 326);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnKurang);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.lstNama);
            this.Controls.Add(this.cboNama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form Pengolah Nama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboNama;
        private System.Windows.Forms.ListBox lstNama;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnKurang;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button btnHapus;
    }
}

