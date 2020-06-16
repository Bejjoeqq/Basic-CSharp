namespace MelewatkanArrayKepadaMetode
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tombolHitung = new System.Windows.Forms.Button();
            this.tombolKeluar = new System.Windows.Forms.Button();
            this.teksTotal = new System.Windows.Forms.TextBox();
            this.teksRata = new System.Windows.Forms.TextBox();
            this.teksTertinggi = new System.Windows.Forms.TextBox();
            this.teksTerendah = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.teksTerendah);
            this.groupBox1.Controls.Add(this.teksTertinggi);
            this.groupBox1.Controls.Add(this.teksRata);
            this.groupBox1.Controls.Add(this.teksTotal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Penjualan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Penjualan Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Penjualan Rata-rata:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Penjualan Tertinggi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Penjualan Terendah:";
            // 
            // tombolHitung
            // 
            this.tombolHitung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolHitung.Location = new System.Drawing.Point(13, 205);
            this.tombolHitung.Name = "tombolHitung";
            this.tombolHitung.Size = new System.Drawing.Size(232, 45);
            this.tombolHitung.TabIndex = 1;
            this.tombolHitung.Text = "Hitung Data Penjualan";
            this.tombolHitung.UseVisualStyleBackColor = true;
            this.tombolHitung.Click += new System.EventHandler(this.tombolHitung_Click);
            // 
            // tombolKeluar
            // 
            this.tombolKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolKeluar.Location = new System.Drawing.Point(288, 205);
            this.tombolKeluar.Name = "tombolKeluar";
            this.tombolKeluar.Size = new System.Drawing.Size(123, 45);
            this.tombolKeluar.TabIndex = 2;
            this.tombolKeluar.Text = "Keluar";
            this.tombolKeluar.UseVisualStyleBackColor = true;
            this.tombolKeluar.Click += new System.EventHandler(this.tombolKeluar_Click);
            // 
            // teksTotal
            // 
            this.teksTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksTotal.Location = new System.Drawing.Point(118, 18);
            this.teksTotal.Name = "teksTotal";
            this.teksTotal.ReadOnly = true;
            this.teksTotal.Size = new System.Drawing.Size(264, 29);
            this.teksTotal.TabIndex = 4;
            // 
            // teksRata
            // 
            this.teksRata.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksRata.Location = new System.Drawing.Point(118, 57);
            this.teksRata.Name = "teksRata";
            this.teksRata.ReadOnly = true;
            this.teksRata.Size = new System.Drawing.Size(264, 29);
            this.teksRata.TabIndex = 5;
            // 
            // teksTertinggi
            // 
            this.teksTertinggi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksTertinggi.Location = new System.Drawing.Point(118, 99);
            this.teksTertinggi.Name = "teksTertinggi";
            this.teksTertinggi.ReadOnly = true;
            this.teksTertinggi.Size = new System.Drawing.Size(264, 29);
            this.teksTertinggi.TabIndex = 6;
            // 
            // teksTerendah
            // 
            this.teksTerendah.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksTerendah.Location = new System.Drawing.Point(118, 138);
            this.teksTerendah.Name = "teksTerendah";
            this.teksTerendah.ReadOnly = true;
            this.teksTerendah.Size = new System.Drawing.Size(264, 29);
            this.teksTerendah.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 262);
            this.Controls.Add(this.tombolKeluar);
            this.Controls.Add(this.tombolHitung);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Melewatkan Array Kepada Metode";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox teksTerendah;
        private System.Windows.Forms.TextBox teksTertinggi;
        private System.Windows.Forms.TextBox teksRata;
        private System.Windows.Forms.TextBox teksTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tombolHitung;
        private System.Windows.Forms.Button tombolKeluar;
    }
}

