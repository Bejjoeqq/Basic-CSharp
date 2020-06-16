namespace RencanaLayananTelkomSelular
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
            this.CBstrRencana = new System.Windows.Forms.ComboBox();
            this.teksVoiceMail = new System.Windows.Forms.TextBox();
            this.teksJumMenit = new System.Windows.Forms.TextBox();
            this.teksData = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tombolHitung = new System.Windows.Forms.Button();
            this.labelHarga = new System.Windows.Forms.Label();
            this.kotakList = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelVoiceMail = new System.Windows.Forms.Label();
            this.labelJumMenit = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tombolBersih = new System.Windows.Forms.Button();
            this.tombolKeluar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CBstrRencana);
            this.groupBox1.Controls.Add(this.teksVoiceMail);
            this.groupBox1.Controls.Add(this.teksJumMenit);
            this.groupBox1.Controls.Add(this.teksData);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pilihan";
            // 
            // CBstrRencana
            // 
            this.CBstrRencana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBstrRencana.FormattingEnabled = true;
            this.CBstrRencana.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.CBstrRencana.Location = new System.Drawing.Point(483, 36);
            this.CBstrRencana.Name = "CBstrRencana";
            this.CBstrRencana.Size = new System.Drawing.Size(73, 28);
            this.CBstrRencana.TabIndex = 7;
            // 
            // teksVoiceMail
            // 
            this.teksVoiceMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksVoiceMail.Location = new System.Drawing.Point(329, 36);
            this.teksVoiceMail.Name = "teksVoiceMail";
            this.teksVoiceMail.Size = new System.Drawing.Size(128, 29);
            this.teksVoiceMail.TabIndex = 6;
            // 
            // teksJumMenit
            // 
            this.teksJumMenit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksJumMenit.Location = new System.Drawing.Point(170, 37);
            this.teksJumMenit.Name = "teksJumMenit";
            this.teksJumMenit.Size = new System.Drawing.Size(128, 29);
            this.teksJumMenit.TabIndex = 5;
            // 
            // teksData
            // 
            this.teksData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksData.Location = new System.Drawing.Point(10, 37);
            this.teksData.Name = "teksData";
            this.teksData.Size = new System.Drawing.Size(128, 29);
            this.teksData.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(480, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pilih Rencana:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Voice Mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jumlah Menit:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data:";
            // 
            // tombolHitung
            // 
            this.tombolHitung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolHitung.Location = new System.Drawing.Point(13, 108);
            this.tombolHitung.Name = "tombolHitung";
            this.tombolHitung.Size = new System.Drawing.Size(210, 77);
            this.tombolHitung.TabIndex = 1;
            this.tombolHitung.Text = "Hitung";
            this.tombolHitung.UseVisualStyleBackColor = true;
            this.tombolHitung.Click += new System.EventHandler(this.tombolHitung_Click);
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHarga.Location = new System.Drawing.Point(12, 420);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(111, 24);
            this.labelHarga.TabIndex = 2;
            this.labelHarga.Text = "labelHarga";
            // 
            // kotakList
            // 
            this.kotakList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kotakList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kotakList.FormattingEnabled = true;
            this.kotakList.ItemHeight = 20;
            this.kotakList.Location = new System.Drawing.Point(250, 108);
            this.kotakList.Name = "kotakList";
            this.kotakList.ScrollAlwaysVisible = true;
            this.kotakList.Size = new System.Drawing.Size(527, 240);
            this.kotakList.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelVoiceMail);
            this.groupBox2.Controls.Add(this.labelJumMenit);
            this.groupBox2.Controls.Add(this.labelData);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(250, 354);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 84);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informasi";
            // 
            // labelVoiceMail
            // 
            this.labelVoiceMail.AutoSize = true;
            this.labelVoiceMail.Location = new System.Drawing.Point(217, 52);
            this.labelVoiceMail.Name = "labelVoiceMail";
            this.labelVoiceMail.Size = new System.Drawing.Size(75, 13);
            this.labelVoiceMail.TabIndex = 11;
            this.labelVoiceMail.Text = "labelVoiceMail";
            // 
            // labelJumMenit
            // 
            this.labelJumMenit.AutoSize = true;
            this.labelJumMenit.Location = new System.Drawing.Point(101, 51);
            this.labelJumMenit.Name = "labelJumMenit";
            this.labelJumMenit.Size = new System.Drawing.Size(74, 13);
            this.labelJumMenit.TabIndex = 10;
            this.labelJumMenit.Text = "labelJumMenit";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(9, 51);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(52, 13);
            this.labelData.TabIndex = 9;
            this.labelData.Text = "labelData";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(217, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Voice Mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Jumlah Menit:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Data:";
            // 
            // tombolBersih
            // 
            this.tombolBersih.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolBersih.Location = new System.Drawing.Point(588, 359);
            this.tombolBersih.Name = "tombolBersih";
            this.tombolBersih.Size = new System.Drawing.Size(189, 36);
            this.tombolBersih.TabIndex = 6;
            this.tombolBersih.Text = "Bersihkan";
            this.tombolBersih.UseVisualStyleBackColor = true;
            this.tombolBersih.Click += new System.EventHandler(this.tombolBersih_Click);
            // 
            // tombolKeluar
            // 
            this.tombolKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolKeluar.Location = new System.Drawing.Point(588, 401);
            this.tombolKeluar.Name = "tombolKeluar";
            this.tombolKeluar.Size = new System.Drawing.Size(189, 37);
            this.tombolKeluar.TabIndex = 7;
            this.tombolKeluar.Text = "Keluar";
            this.tombolKeluar.UseVisualStyleBackColor = true;
            this.tombolKeluar.Click += new System.EventHandler(this.tombolKeluar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RencanaLayananTelkomSelular.Resource1.handphonegirl;
            this.pictureBox1.Location = new System.Drawing.Point(13, 191);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 221);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 456);
            this.Controls.Add(this.tombolKeluar);
            this.Controls.Add(this.tombolBersih);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kotakList);
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.tombolHitung);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Rencana Layanan Telkom Selular";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CBstrRencana;
        private System.Windows.Forms.TextBox teksVoiceMail;
        private System.Windows.Forms.TextBox teksJumMenit;
        private System.Windows.Forms.TextBox teksData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tombolHitung;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.ListBox kotakList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelVoiceMail;
        private System.Windows.Forms.Label labelJumMenit;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button tombolBersih;
        private System.Windows.Forms.Button tombolKeluar;
    }
}

