namespace DaftarTemanDariMasukanPengguna
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
            this.teksNama = new System.Windows.Forms.TextBox();
            this.kotakList = new System.Windows.Forms.ListBox();
            this.tombolTambah = new System.Windows.Forms.Button();
            this.tombolTampiltombolTampil = new System.Windows.Forms.Button();
            this.tombolBersih = new System.Windows.Forms.Button();
            this.tombolKeluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masukkan Nama Teman:";
            // 
            // teksNama
            // 
            this.teksNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksNama.Location = new System.Drawing.Point(16, 30);
            this.teksNama.Name = "teksNama";
            this.teksNama.Size = new System.Drawing.Size(194, 29);
            this.teksNama.TabIndex = 1;
            // 
            // kotakList
            // 
            this.kotakList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kotakList.FormattingEnabled = true;
            this.kotakList.ItemHeight = 20;
            this.kotakList.Location = new System.Drawing.Point(225, 30);
            this.kotakList.Name = "kotakList";
            this.kotakList.ScrollAlwaysVisible = true;
            this.kotakList.Size = new System.Drawing.Size(240, 224);
            this.kotakList.TabIndex = 2;
            // 
            // tombolTambah
            // 
            this.tombolTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolTambah.Location = new System.Drawing.Point(16, 65);
            this.tombolTambah.Name = "tombolTambah";
            this.tombolTambah.Size = new System.Drawing.Size(194, 42);
            this.tombolTambah.TabIndex = 3;
            this.tombolTambah.Text = "Tambahkan";
            this.tombolTambah.UseVisualStyleBackColor = true;
            this.tombolTambah.Click += new System.EventHandler(this.tombolTambah_Click);
            // 
            // tombolTampiltombolTampil
            // 
            this.tombolTampiltombolTampil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolTampiltombolTampil.Location = new System.Drawing.Point(16, 113);
            this.tombolTampiltombolTampil.Name = "tombolTampiltombolTampil";
            this.tombolTampiltombolTampil.Size = new System.Drawing.Size(194, 42);
            this.tombolTampiltombolTampil.TabIndex = 4;
            this.tombolTampiltombolTampil.Text = "Tampilkan Semua";
            this.tombolTampiltombolTampil.UseVisualStyleBackColor = true;
            this.tombolTampiltombolTampil.Click += new System.EventHandler(this.tombolTampiltombolTampil_Click);
            // 
            // tombolBersih
            // 
            this.tombolBersih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolBersih.Location = new System.Drawing.Point(16, 161);
            this.tombolBersih.Name = "tombolBersih";
            this.tombolBersih.Size = new System.Drawing.Size(194, 42);
            this.tombolBersih.TabIndex = 5;
            this.tombolBersih.Text = "Bersihkan";
            this.tombolBersih.UseVisualStyleBackColor = true;
            this.tombolBersih.Click += new System.EventHandler(this.tombolBersih_Click);
            // 
            // tombolKeluar
            // 
            this.tombolKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolKeluar.Location = new System.Drawing.Point(16, 209);
            this.tombolKeluar.Name = "tombolKeluar";
            this.tombolKeluar.Size = new System.Drawing.Size(194, 42);
            this.tombolKeluar.TabIndex = 6;
            this.tombolKeluar.Text = "Keluar";
            this.tombolKeluar.UseVisualStyleBackColor = true;
            this.tombolKeluar.Click += new System.EventHandler(this.tombolKeluar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 266);
            this.Controls.Add(this.tombolKeluar);
            this.Controls.Add(this.tombolBersih);
            this.Controls.Add(this.tombolTampiltombolTampil);
            this.Controls.Add(this.tombolTambah);
            this.Controls.Add(this.kotakList);
            this.Controls.Add(this.teksNama);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Daftar Teman Dari Masukan Pengguna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teksNama;
        private System.Windows.Forms.ListBox kotakList;
        private System.Windows.Forms.Button tombolTambah;
        private System.Windows.Forms.Button tombolTampiltombolTampil;
        private System.Windows.Forms.Button tombolBersih;
        private System.Windows.Forms.Button tombolKeluar;
    }
}

