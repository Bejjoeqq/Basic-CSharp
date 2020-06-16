namespace StatemenIfBersarang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.teksGajiPerTahun = new System.Windows.Forms.TextBox();
            this.teksJumThnKerja = new System.Windows.Forms.TextBox();
            this.teksKualifikasi = new System.Windows.Forms.TextBox();
            this.tombolPeriksa = new System.Windows.Forms.Button();
            this.tombolBersih = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.teksJumThnKerja);
            this.groupBox1.Controls.Add(this.teksGajiPerTahun);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Masukkan Informasi Berikut";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gaji Per Tahun:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jumlah Tahun Kerja:";
            // 
            // teksGajiPerTahun
            // 
            this.teksGajiPerTahun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksGajiPerTahun.Location = new System.Drawing.Point(116, 31);
            this.teksGajiPerTahun.Name = "teksGajiPerTahun";
            this.teksGajiPerTahun.Size = new System.Drawing.Size(156, 26);
            this.teksGajiPerTahun.TabIndex = 2;
            // 
            // teksJumThnKerja
            // 
            this.teksJumThnKerja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksJumThnKerja.Location = new System.Drawing.Point(116, 66);
            this.teksJumThnKerja.Name = "teksJumThnKerja";
            this.teksJumThnKerja.Size = new System.Drawing.Size(156, 26);
            this.teksJumThnKerja.TabIndex = 3;
            // 
            // teksKualifikasi
            // 
            this.teksKualifikasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksKualifikasi.Location = new System.Drawing.Point(13, 160);
            this.teksKualifikasi.Multiline = true;
            this.teksKualifikasi.Name = "teksKualifikasi";
            this.teksKualifikasi.ReadOnly = true;
            this.teksKualifikasi.Size = new System.Drawing.Size(287, 47);
            this.teksKualifikasi.TabIndex = 1;
            // 
            // tombolPeriksa
            // 
            this.tombolPeriksa.Location = new System.Drawing.Point(13, 222);
            this.tombolPeriksa.Name = "tombolPeriksa";
            this.tombolPeriksa.Size = new System.Drawing.Size(133, 44);
            this.tombolPeriksa.TabIndex = 2;
            this.tombolPeriksa.Text = "Periksa Kualifikasi";
            this.tombolPeriksa.UseVisualStyleBackColor = true;
            this.tombolPeriksa.Click += new System.EventHandler(this.tombolPeriksa_Click);
            // 
            // tombolBersih
            // 
            this.tombolBersih.Location = new System.Drawing.Point(168, 222);
            this.tombolBersih.Name = "tombolBersih";
            this.tombolBersih.Size = new System.Drawing.Size(133, 44);
            this.tombolBersih.TabIndex = 3;
            this.tombolBersih.Text = "Bersihkan";
            this.tombolBersih.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 278);
            this.Controls.Add(this.tombolBersih);
            this.Controls.Add(this.tombolPeriksa);
            this.Controls.Add(this.teksKualifikasi);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Kualifikasi Hutang Statemen If Bersarang";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox teksJumThnKerja;
        private System.Windows.Forms.TextBox teksGajiPerTahun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teksKualifikasi;
        private System.Windows.Forms.Button tombolPeriksa;
        private System.Windows.Forms.Button tombolBersih;
    }
}

