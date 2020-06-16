namespace AplikasiBiroTravelSederhana
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
            this.komboKamar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kalenderTiba = new System.Windows.Forms.MonthCalendar();
            this.kalenderPulang = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tombolToba = new System.Windows.Forms.RadioButton();
            this.tombolJogja = new System.Windows.Forms.RadioButton();
            this.tombolPapua = new System.Windows.Forms.RadioButton();
            this.tombolPontianak = new System.Windows.Forms.RadioButton();
            this.tombolSenggigi = new System.Windows.Forms.RadioButton();
            this.tombolToraja = new System.Windows.Forms.RadioButton();
            this.tombolMakassar = new System.Windows.Forms.RadioButton();
            this.tombolNias = new System.Windows.Forms.RadioButton();
            this.tombolHitung = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.teksBiaya = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jumlah Kamar:";
            // 
            // komboKamar
            // 
            this.komboKamar.FormattingEnabled = true;
            this.komboKamar.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.komboKamar.Location = new System.Drawing.Point(16, 30);
            this.komboKamar.Name = "komboKamar";
            this.komboKamar.Size = new System.Drawing.Size(42, 21);
            this.komboKamar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tanggal Tiba:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tanggal Pulang:";
            // 
            // kalenderTiba
            // 
            this.kalenderTiba.Location = new System.Drawing.Point(103, 36);
            this.kalenderTiba.Name = "kalenderTiba";
            this.kalenderTiba.TabIndex = 4;
            // 
            // kalenderPulang
            // 
            this.kalenderPulang.Location = new System.Drawing.Point(351, 36);
            this.kalenderPulang.Name = "kalenderPulang";
            this.kalenderPulang.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tombolNias);
            this.groupBox1.Controls.Add(this.tombolMakassar);
            this.groupBox1.Controls.Add(this.tombolToraja);
            this.groupBox1.Controls.Add(this.tombolSenggigi);
            this.groupBox1.Controls.Add(this.tombolPontianak);
            this.groupBox1.Controls.Add(this.tombolPapua);
            this.groupBox1.Controls.Add(this.tombolJogja);
            this.groupBox1.Controls.Add(this.tombolToba);
            this.groupBox1.Location = new System.Drawing.Point(107, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 86);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Destinasi";
            // 
            // tombolToba
            // 
            this.tombolToba.AutoSize = true;
            this.tombolToba.Location = new System.Drawing.Point(7, 20);
            this.tombolToba.Name = "tombolToba";
            this.tombolToba.Size = new System.Drawing.Size(85, 17);
            this.tombolToba.TabIndex = 0;
            this.tombolToba.TabStop = true;
            this.tombolToba.Text = "Danau Toba";
            this.tombolToba.UseVisualStyleBackColor = true;
            // 
            // tombolJogja
            // 
            this.tombolJogja.AutoSize = true;
            this.tombolJogja.Location = new System.Drawing.Point(137, 19);
            this.tombolJogja.Name = "tombolJogja";
            this.tombolJogja.Size = new System.Drawing.Size(74, 17);
            this.tombolJogja.TabIndex = 1;
            this.tombolJogja.TabStop = true;
            this.tombolJogja.Text = "Jogjakarta";
            this.tombolJogja.UseVisualStyleBackColor = true;
            // 
            // tombolPapua
            // 
            this.tombolPapua.AutoSize = true;
            this.tombolPapua.Location = new System.Drawing.Point(264, 20);
            this.tombolPapua.Name = "tombolPapua";
            this.tombolPapua.Size = new System.Drawing.Size(56, 17);
            this.tombolPapua.TabIndex = 2;
            this.tombolPapua.TabStop = true;
            this.tombolPapua.Text = "Papua";
            this.tombolPapua.UseVisualStyleBackColor = true;
            // 
            // tombolPontianak
            // 
            this.tombolPontianak.AutoSize = true;
            this.tombolPontianak.Location = new System.Drawing.Point(380, 20);
            this.tombolPontianak.Name = "tombolPontianak";
            this.tombolPontianak.Size = new System.Drawing.Size(73, 17);
            this.tombolPontianak.TabIndex = 3;
            this.tombolPontianak.TabStop = true;
            this.tombolPontianak.Text = "Pontianak";
            this.tombolPontianak.UseVisualStyleBackColor = true;
            // 
            // tombolSenggigi
            // 
            this.tombolSenggigi.AutoSize = true;
            this.tombolSenggigi.Location = new System.Drawing.Point(6, 52);
            this.tombolSenggigi.Name = "tombolSenggigi";
            this.tombolSenggigi.Size = new System.Drawing.Size(66, 17);
            this.tombolSenggigi.TabIndex = 4;
            this.tombolSenggigi.TabStop = true;
            this.tombolSenggigi.Text = "Senggigi";
            this.tombolSenggigi.UseVisualStyleBackColor = true;
            // 
            // tombolToraja
            // 
            this.tombolToraja.AutoSize = true;
            this.tombolToraja.Location = new System.Drawing.Point(137, 52);
            this.tombolToraja.Name = "tombolToraja";
            this.tombolToraja.Size = new System.Drawing.Size(89, 17);
            this.tombolToraja.TabIndex = 5;
            this.tombolToraja.TabStop = true;
            this.tombolToraja.Text = "Tanah Toraja";
            this.tombolToraja.UseVisualStyleBackColor = true;
            // 
            // tombolMakassar
            // 
            this.tombolMakassar.AutoSize = true;
            this.tombolMakassar.Location = new System.Drawing.Point(264, 52);
            this.tombolMakassar.Name = "tombolMakassar";
            this.tombolMakassar.Size = new System.Drawing.Size(71, 17);
            this.tombolMakassar.TabIndex = 6;
            this.tombolMakassar.TabStop = true;
            this.tombolMakassar.Text = "Makassar";
            this.tombolMakassar.UseVisualStyleBackColor = true;
            // 
            // tombolNias
            // 
            this.tombolNias.AutoSize = true;
            this.tombolNias.Location = new System.Drawing.Point(380, 52);
            this.tombolNias.Name = "tombolNias";
            this.tombolNias.Size = new System.Drawing.Size(46, 17);
            this.tombolNias.TabIndex = 7;
            this.tombolNias.TabStop = true;
            this.tombolNias.Text = "Nias";
            this.tombolNias.UseVisualStyleBackColor = true;
            // 
            // tombolHitung
            // 
            this.tombolHitung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolHitung.Location = new System.Drawing.Point(12, 300);
            this.tombolHitung.Name = "tombolHitung";
            this.tombolHitung.Size = new System.Drawing.Size(148, 67);
            this.tombolHitung.TabIndex = 7;
            this.tombolHitung.Text = "Hitung Biaya";
            this.tombolHitung.UseVisualStyleBackColor = true;
            this.tombolHitung.Click += new System.EventHandler(this.tombolHitung_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total Biaya (Termasuk Tiket Pesawat):";
            // 
            // teksBiaya
            // 
            this.teksBiaya.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksBiaya.Location = new System.Drawing.Point(173, 323);
            this.teksBiaya.Name = "teksBiaya";
            this.teksBiaya.ReadOnly = true;
            this.teksBiaya.Size = new System.Drawing.Size(405, 31);
            this.teksBiaya.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 376);
            this.Controls.Add(this.teksBiaya);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tombolHitung);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kalenderPulang);
            this.Controls.Add(this.kalenderTiba);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.komboKamar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Aplikasi Biro Travel Sederhana";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox komboKamar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar kalenderTiba;
        private System.Windows.Forms.MonthCalendar kalenderPulang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton tombolNias;
        private System.Windows.Forms.RadioButton tombolMakassar;
        private System.Windows.Forms.RadioButton tombolToraja;
        private System.Windows.Forms.RadioButton tombolSenggigi;
        private System.Windows.Forms.RadioButton tombolPontianak;
        private System.Windows.Forms.RadioButton tombolPapua;
        private System.Windows.Forms.RadioButton tombolJogja;
        private System.Windows.Forms.RadioButton tombolToba;
        private System.Windows.Forms.Button tombolHitung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox teksBiaya;
    }
}

