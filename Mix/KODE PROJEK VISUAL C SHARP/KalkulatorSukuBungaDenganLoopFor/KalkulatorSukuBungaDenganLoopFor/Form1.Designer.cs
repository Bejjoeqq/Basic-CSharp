namespace KalkulatorSukuBungaDenganLoopFor
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
            this.teksKeluaran = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.teksInvestasi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.teksBunga = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.teksJumTahun = new System.Windows.Forms.TextBox();
            this.kotakList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBTahun = new System.Windows.Forms.RadioButton();
            this.RBBulan = new System.Windows.Forms.RadioButton();
            this.RBMinggu = new System.Windows.Forms.RadioButton();
            this.RBHari = new System.Windows.Forms.RadioButton();
            this.tombolHitung = new System.Windows.Forms.Button();
            this.tombolBersih = new System.Windows.Forms.Button();
            this.tombolKeluar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // teksKeluaran
            // 
            this.teksKeluaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksKeluaran.Location = new System.Drawing.Point(13, 13);
            this.teksKeluaran.Name = "teksKeluaran";
            this.teksKeluaran.ReadOnly = true;
            this.teksKeluaran.Size = new System.Drawing.Size(411, 26);
            this.teksKeluaran.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Investasi:";
            // 
            // teksInvestasi
            // 
            this.teksInvestasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksInvestasi.Location = new System.Drawing.Point(16, 66);
            this.teksInvestasi.Name = "teksInvestasi";
            this.teksInvestasi.Size = new System.Drawing.Size(205, 29);
            this.teksInvestasi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bunga (dalam %):";
            // 
            // teksBunga
            // 
            this.teksBunga.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksBunga.Location = new System.Drawing.Point(16, 123);
            this.teksBunga.Name = "teksBunga";
            this.teksBunga.Size = new System.Drawing.Size(111, 29);
            this.teksBunga.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Berapa Tahun:";
            // 
            // teksJumTahun
            // 
            this.teksJumTahun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksJumTahun.Location = new System.Drawing.Point(16, 186);
            this.teksJumTahun.Name = "teksJumTahun";
            this.teksJumTahun.Size = new System.Drawing.Size(86, 29);
            this.teksJumTahun.TabIndex = 6;
            // 
            // kotakList
            // 
            this.kotakList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kotakList.FormattingEnabled = true;
            this.kotakList.ItemHeight = 20;
            this.kotakList.Location = new System.Drawing.Point(227, 66);
            this.kotakList.Name = "kotakList";
            this.kotakList.ScrollAlwaysVisible = true;
            this.kotakList.Size = new System.Drawing.Size(197, 324);
            this.kotakList.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBHari);
            this.groupBox1.Controls.Add(this.RBMinggu);
            this.groupBox1.Controls.Add(this.RBBulan);
            this.groupBox1.Controls.Add(this.RBTahun);
            this.groupBox1.Location = new System.Drawing.Point(16, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 77);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bunga Dibayarkan";
            // 
            // RBTahun
            // 
            this.RBTahun.AutoSize = true;
            this.RBTahun.Location = new System.Drawing.Point(7, 19);
            this.RBTahun.Name = "RBTahun";
            this.RBTahun.Size = new System.Drawing.Size(75, 17);
            this.RBTahun.TabIndex = 0;
            this.RBTahun.TabStop = true;
            this.RBTahun.Tag = "1";
            this.RBTahun.Text = "Per Tahun";
            this.RBTahun.UseVisualStyleBackColor = true;
            this.RBTahun.CheckedChanged += new System.EventHandler(this.RBTahun_CheckedChanged);
            // 
            // RBBulan
            // 
            this.RBBulan.AutoSize = true;
            this.RBBulan.Location = new System.Drawing.Point(7, 42);
            this.RBBulan.Name = "RBBulan";
            this.RBBulan.Size = new System.Drawing.Size(71, 17);
            this.RBBulan.TabIndex = 1;
            this.RBBulan.TabStop = true;
            this.RBBulan.Tag = "12";
            this.RBBulan.Text = "Per Bulan";
            this.RBBulan.UseVisualStyleBackColor = true;
            this.RBBulan.CheckedChanged += new System.EventHandler(this.RBBulan_CheckedChanged);
            // 
            // RBMinggu
            // 
            this.RBMinggu.AutoSize = true;
            this.RBMinggu.Location = new System.Drawing.Point(107, 19);
            this.RBMinggu.Name = "RBMinggu";
            this.RBMinggu.Size = new System.Drawing.Size(79, 17);
            this.RBMinggu.TabIndex = 2;
            this.RBMinggu.TabStop = true;
            this.RBMinggu.Tag = "52";
            this.RBMinggu.Text = "Per Minggu";
            this.RBMinggu.UseVisualStyleBackColor = true;
            this.RBMinggu.CheckedChanged += new System.EventHandler(this.RBMinggu_CheckedChanged);
            // 
            // RBHari
            // 
            this.RBHari.AutoSize = true;
            this.RBHari.Location = new System.Drawing.Point(107, 42);
            this.RBHari.Name = "RBHari";
            this.RBHari.Size = new System.Drawing.Size(63, 17);
            this.RBHari.TabIndex = 3;
            this.RBHari.TabStop = true;
            this.RBHari.Tag = "365";
            this.RBHari.Text = "Per Hari";
            this.RBHari.UseVisualStyleBackColor = true;
            this.RBHari.CheckedChanged += new System.EventHandler(this.RBHari_CheckedChanged);
            // 
            // tombolHitung
            // 
            this.tombolHitung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolHitung.Location = new System.Drawing.Point(16, 394);
            this.tombolHitung.Name = "tombolHitung";
            this.tombolHitung.Size = new System.Drawing.Size(200, 48);
            this.tombolHitung.TabIndex = 9;
            this.tombolHitung.Text = "Hitung";
            this.tombolHitung.UseVisualStyleBackColor = true;
            this.tombolHitung.Click += new System.EventHandler(this.tombolHitung_Click);
            // 
            // tombolBersih
            // 
            this.tombolBersih.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolBersih.Location = new System.Drawing.Point(222, 394);
            this.tombolBersih.Name = "tombolBersih";
            this.tombolBersih.Size = new System.Drawing.Size(116, 48);
            this.tombolBersih.TabIndex = 10;
            this.tombolBersih.Text = "Bersihkan";
            this.tombolBersih.UseVisualStyleBackColor = true;
            this.tombolBersih.Click += new System.EventHandler(this.tombolBersih_Click);
            // 
            // tombolKeluar
            // 
            this.tombolKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolKeluar.Location = new System.Drawing.Point(344, 394);
            this.tombolKeluar.Name = "tombolKeluar";
            this.tombolKeluar.Size = new System.Drawing.Size(80, 48);
            this.tombolKeluar.TabIndex = 11;
            this.tombolKeluar.Text = "Keluar";
            this.tombolKeluar.UseVisualStyleBackColor = true;
            this.tombolKeluar.Click += new System.EventHandler(this.tombolKeluar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 454);
            this.Controls.Add(this.tombolKeluar);
            this.Controls.Add(this.tombolBersih);
            this.Controls.Add(this.tombolHitung);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kotakList);
            this.Controls.Add(this.teksJumTahun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.teksBunga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.teksInvestasi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teksKeluaran);
            this.Name = "Form1";
            this.Text = "Kalkulator Bunga Dengan Loop For";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox teksKeluaran;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teksInvestasi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox teksBunga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox teksJumTahun;
        private System.Windows.Forms.ListBox kotakList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RBHari;
        private System.Windows.Forms.RadioButton RBMinggu;
        private System.Windows.Forms.RadioButton RBBulan;
        private System.Windows.Forms.RadioButton RBTahun;
        private System.Windows.Forms.Button tombolHitung;
        private System.Windows.Forms.Button tombolBersih;
        private System.Windows.Forms.Button tombolKeluar;
    }
}

