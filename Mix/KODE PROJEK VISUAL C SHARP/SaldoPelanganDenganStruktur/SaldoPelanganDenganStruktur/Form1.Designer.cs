namespace SaldoPelanganDenganStruktur
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
            this.tombolDaftar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.teksNamaBlkg = new System.Windows.Forms.TextBox();
            this.teksNamaDepan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.teksSaldoAkhir = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.teksPinjaman = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.teksDeposito = new System.Windows.Forms.TextBox();
            this.teksNoAkun = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.teksNama = new System.Windows.Forms.TextBox();
            this.kotakList = new System.Windows.Forms.ListBox();
            this.teksEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tombolKeluar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tombolDaftar
            // 
            this.tombolDaftar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolDaftar.Location = new System.Drawing.Point(13, 398);
            this.tombolDaftar.Name = "tombolDaftar";
            this.tombolDaftar.Size = new System.Drawing.Size(331, 47);
            this.tombolDaftar.TabIndex = 0;
            this.tombolDaftar.Text = "Daftar Konsumen";
            this.tombolDaftar.UseVisualStyleBackColor = true;
            this.tombolDaftar.Click += new System.EventHandler(this.tombolDaftar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.teksNamaBlkg);
            this.groupBox1.Controls.Add(this.teksNamaDepan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 106);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identitas";
            // 
            // teksNamaBlkg
            // 
            this.teksNamaBlkg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksNamaBlkg.Location = new System.Drawing.Point(98, 65);
            this.teksNamaBlkg.Name = "teksNamaBlkg";
            this.teksNamaBlkg.Size = new System.Drawing.Size(217, 29);
            this.teksNamaBlkg.TabIndex = 3;
            // 
            // teksNamaDepan
            // 
            this.teksNamaDepan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksNamaDepan.Location = new System.Drawing.Point(98, 19);
            this.teksNamaDepan.Name = "teksNamaDepan";
            this.teksNamaDepan.Size = new System.Drawing.Size(217, 29);
            this.teksNamaDepan.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Belakang:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Depan:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.teksSaldoAkhir);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.teksPinjaman);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.teksDeposito);
            this.groupBox2.Controls.Add(this.teksNoAkun);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(13, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 192);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tentang Saldo";
            // 
            // teksSaldoAkhir
            // 
            this.teksSaldoAkhir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksSaldoAkhir.Location = new System.Drawing.Point(98, 148);
            this.teksSaldoAkhir.Name = "teksSaldoAkhir";
            this.teksSaldoAkhir.ReadOnly = true;
            this.teksSaldoAkhir.Size = new System.Drawing.Size(217, 29);
            this.teksSaldoAkhir.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Saldo Akhir";
            // 
            // teksPinjaman
            // 
            this.teksPinjaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksPinjaman.Location = new System.Drawing.Point(98, 103);
            this.teksPinjaman.Name = "teksPinjaman";
            this.teksPinjaman.Size = new System.Drawing.Size(217, 29);
            this.teksPinjaman.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pinjaman:";
            // 
            // teksDeposito
            // 
            this.teksDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksDeposito.Location = new System.Drawing.Point(98, 65);
            this.teksDeposito.Name = "teksDeposito";
            this.teksDeposito.Size = new System.Drawing.Size(217, 29);
            this.teksDeposito.TabIndex = 3;
            // 
            // teksNoAkun
            // 
            this.teksNoAkun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksNoAkun.Location = new System.Drawing.Point(98, 19);
            this.teksNoAkun.Name = "teksNoAkun";
            this.teksNoAkun.Size = new System.Drawing.Size(217, 29);
            this.teksNoAkun.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Deposito:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nomor Akun:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(365, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Nama:";
            // 
            // teksNama
            // 
            this.teksNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksNama.Location = new System.Drawing.Point(368, 35);
            this.teksNama.Name = "teksNama";
            this.teksNama.ReadOnly = true;
            this.teksNama.Size = new System.Drawing.Size(297, 29);
            this.teksNama.TabIndex = 8;
            // 
            // kotakList
            // 
            this.kotakList.FormattingEnabled = true;
            this.kotakList.Location = new System.Drawing.Point(368, 81);
            this.kotakList.Name = "kotakList";
            this.kotakList.ScrollAlwaysVisible = true;
            this.kotakList.Size = new System.Drawing.Size(297, 277);
            this.kotakList.TabIndex = 9;
            // 
            // teksEmail
            // 
            this.teksEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksEmail.Location = new System.Drawing.Point(13, 351);
            this.teksEmail.Name = "teksEmail";
            this.teksEmail.ReadOnly = true;
            this.teksEmail.Size = new System.Drawing.Size(331, 26);
            this.teksEmail.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Email:";
            // 
            // tombolKeluar
            // 
            this.tombolKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolKeluar.Location = new System.Drawing.Point(368, 377);
            this.tombolKeluar.Name = "tombolKeluar";
            this.tombolKeluar.Size = new System.Drawing.Size(297, 68);
            this.tombolKeluar.TabIndex = 12;
            this.tombolKeluar.Text = "Keluar";
            this.tombolKeluar.UseVisualStyleBackColor = true;
            this.tombolKeluar.Click += new System.EventHandler(this.tombolKeluar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 466);
            this.Controls.Add(this.tombolKeluar);
            this.Controls.Add(this.teksEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.kotakList);
            this.Controls.Add(this.teksNama);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tombolDaftar);
            this.Name = "Form1";
            this.Text = "Layanan Saldo Dengan Struktur";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tombolDaftar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox teksNamaBlkg;
        private System.Windows.Forms.TextBox teksNamaDepan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox teksSaldoAkhir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox teksPinjaman;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox teksDeposito;
        private System.Windows.Forms.TextBox teksNoAkun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox teksNama;
        private System.Windows.Forms.ListBox kotakList;
        private System.Windows.Forms.TextBox teksEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button tombolKeluar;
    }
}

