namespace KalkulatorPinjamanMobil
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kotakTeksJumBulan = new System.Windows.Forms.TextBox();
            this.kotakTeksUM = new System.Windows.Forms.TextBox();
            this.kotakTeksHarga = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RBBekas = new System.Windows.Forms.RadioButton();
            this.RBBaru = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.kotakTeksBunga = new System.Windows.Forms.TextBox();
            this.kotakTeksPesan = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.kotakList = new System.Windows.Forms.ListBox();
            this.tombolHitung = new System.Windows.Forms.Button();
            this.tombolBersih = new System.Windows.Forms.Button();
            this.tombolKeluar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kotakTeksJumBulan);
            this.groupBox1.Controls.Add(this.kotakTeksUM);
            this.groupBox1.Controls.Add(this.kotakTeksHarga);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informasi Pinjaman Mobil";
            // 
            // kotakTeksJumBulan
            // 
            this.kotakTeksJumBulan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kotakTeksJumBulan.Location = new System.Drawing.Point(122, 79);
            this.kotakTeksJumBulan.Name = "kotakTeksJumBulan";
            this.kotakTeksJumBulan.Size = new System.Drawing.Size(146, 26);
            this.kotakTeksJumBulan.TabIndex = 5;
            // 
            // kotakTeksUM
            // 
            this.kotakTeksUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kotakTeksUM.Location = new System.Drawing.Point(122, 47);
            this.kotakTeksUM.Name = "kotakTeksUM";
            this.kotakTeksUM.Size = new System.Drawing.Size(146, 26);
            this.kotakTeksUM.TabIndex = 4;
            // 
            // kotakTeksHarga
            // 
            this.kotakTeksHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kotakTeksHarga.Location = new System.Drawing.Point(122, 12);
            this.kotakTeksHarga.Name = "kotakTeksHarga";
            this.kotakTeksHarga.Size = new System.Drawing.Size(146, 26);
            this.kotakTeksHarga.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jumlah Bulan:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jumlah Uang Muka:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Harga Mobil:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RBBekas);
            this.groupBox2.Controls.Add(this.RBBaru);
            this.groupBox2.Location = new System.Drawing.Point(395, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(114, 81);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Baru Atau Bekas";
            // 
            // RBBekas
            // 
            this.RBBekas.AutoSize = true;
            this.RBBekas.Location = new System.Drawing.Point(6, 47);
            this.RBBekas.Name = "RBBekas";
            this.RBBekas.Size = new System.Drawing.Size(55, 17);
            this.RBBekas.TabIndex = 1;
            this.RBBekas.TabStop = true;
            this.RBBekas.Text = "Bekas";
            this.RBBekas.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.RBBekas.UseVisualStyleBackColor = true;
            this.RBBekas.CheckedChanged += new System.EventHandler(this.RBBekas_CheckedChanged);
            // 
            // RBBaru
            // 
            this.RBBaru.AutoSize = true;
            this.RBBaru.Location = new System.Drawing.Point(7, 20);
            this.RBBaru.Name = "RBBaru";
            this.RBBaru.Size = new System.Drawing.Size(47, 17);
            this.RBBaru.TabIndex = 0;
            this.RBBaru.TabStop = true;
            this.RBBaru.Text = "Baru";
            this.RBBaru.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.RBBaru.UseVisualStyleBackColor = true;
            this.RBBaru.CheckedChanged += new System.EventHandler(this.RBBaru_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(567, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Suku Bunga Per Tahun:";
            // 
            // kotakTeksBunga
            // 
            this.kotakTeksBunga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kotakTeksBunga.Location = new System.Drawing.Point(570, 27);
            this.kotakTeksBunga.Name = "kotakTeksBunga";
            this.kotakTeksBunga.ReadOnly = true;
            this.kotakTeksBunga.Size = new System.Drawing.Size(119, 26);
            this.kotakTeksBunga.TabIndex = 3;
            // 
            // kotakTeksPesan
            // 
            this.kotakTeksPesan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kotakTeksPesan.Location = new System.Drawing.Point(13, 140);
            this.kotakTeksPesan.Name = "kotakTeksPesan";
            this.kotakTeksPesan.ReadOnly = true;
            this.kotakTeksPesan.Size = new System.Drawing.Size(676, 26);
            this.kotakTeksPesan.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.kotakList);
            this.groupBox3.Location = new System.Drawing.Point(13, 173);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(676, 257);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pembayaran Pokok Hutang dan Bunga";
            // 
            // kotakList
            // 
            this.kotakList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kotakList.FormattingEnabled = true;
            this.kotakList.ItemHeight = 20;
            this.kotakList.Location = new System.Drawing.Point(9, 20);
            this.kotakList.Name = "kotakList";
            this.kotakList.ScrollAlwaysVisible = true;
            this.kotakList.Size = new System.Drawing.Size(656, 224);
            this.kotakList.TabIndex = 0;
            // 
            // tombolHitung
            // 
            this.tombolHitung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolHitung.Location = new System.Drawing.Point(22, 454);
            this.tombolHitung.Name = "tombolHitung";
            this.tombolHitung.Size = new System.Drawing.Size(134, 45);
            this.tombolHitung.TabIndex = 6;
            this.tombolHitung.Text = "Hitung";
            this.tombolHitung.UseVisualStyleBackColor = true;
            this.tombolHitung.Click += new System.EventHandler(this.tombolHitung_Click);
            // 
            // tombolBersih
            // 
            this.tombolBersih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolBersih.Location = new System.Drawing.Point(282, 454);
            this.tombolBersih.Name = "tombolBersih";
            this.tombolBersih.Size = new System.Drawing.Size(134, 45);
            this.tombolBersih.TabIndex = 7;
            this.tombolBersih.Text = "Bersihkan";
            this.tombolBersih.UseVisualStyleBackColor = true;
            this.tombolBersih.Click += new System.EventHandler(this.tombolBersih_Click);
            // 
            // tombolKeluar
            // 
            this.tombolKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolKeluar.Location = new System.Drawing.Point(555, 454);
            this.tombolKeluar.Name = "tombolKeluar";
            this.tombolKeluar.Size = new System.Drawing.Size(134, 45);
            this.tombolKeluar.TabIndex = 8;
            this.tombolKeluar.Text = "Keluar";
            this.tombolKeluar.UseVisualStyleBackColor = true;
            this.tombolKeluar.Click += new System.EventHandler(this.tombolKeluar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 511);
            this.Controls.Add(this.tombolKeluar);
            this.Controls.Add(this.tombolBersih);
            this.Controls.Add(this.tombolHitung);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.kotakTeksPesan);
            this.Controls.Add(this.kotakTeksBunga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Kalkulator Pinjaman Mobil";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox kotakTeksJumBulan;
        private System.Windows.Forms.TextBox kotakTeksUM;
        private System.Windows.Forms.TextBox kotakTeksHarga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RBBekas;
        private System.Windows.Forms.RadioButton RBBaru;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kotakTeksBunga;
        private System.Windows.Forms.TextBox kotakTeksPesan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox kotakList;
        private System.Windows.Forms.Button tombolHitung;
        private System.Windows.Forms.Button tombolBersih;
        private System.Windows.Forms.Button tombolKeluar;
    }
}

