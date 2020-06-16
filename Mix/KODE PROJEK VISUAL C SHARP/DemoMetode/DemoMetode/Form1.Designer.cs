namespace DemoMetode
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
            this.teksHargaRetail = new System.Windows.Forms.TextBox();
            this.teksPersenDiskon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.teksHargaPenjualan = new System.Windows.Forms.TextBox();
            this.teksPesan = new System.Windows.Forms.TextBox();
            this.tombolHitung = new System.Windows.Forms.Button();
            this.tombolKeluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Harga Retail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Persen Diskon:";
            // 
            // teksHargaRetail
            // 
            this.teksHargaRetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksHargaRetail.Location = new System.Drawing.Point(104, 13);
            this.teksHargaRetail.Name = "teksHargaRetail";
            this.teksHargaRetail.Size = new System.Drawing.Size(238, 29);
            this.teksHargaRetail.TabIndex = 2;
            // 
            // teksPersenDiskon
            // 
            this.teksPersenDiskon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksPersenDiskon.Location = new System.Drawing.Point(104, 48);
            this.teksPersenDiskon.Name = "teksPersenDiskon";
            this.teksPersenDiskon.Size = new System.Drawing.Size(238, 29);
            this.teksPersenDiskon.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Harga Penjualan:";
            // 
            // teksHargaPenjualan
            // 
            this.teksHargaPenjualan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksHargaPenjualan.Location = new System.Drawing.Point(16, 118);
            this.teksHargaPenjualan.Name = "teksHargaPenjualan";
            this.teksHargaPenjualan.ReadOnly = true;
            this.teksHargaPenjualan.Size = new System.Drawing.Size(326, 29);
            this.teksHargaPenjualan.TabIndex = 5;
            // 
            // teksPesan
            // 
            this.teksPesan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksPesan.Location = new System.Drawing.Point(16, 172);
            this.teksPesan.Name = "teksPesan";
            this.teksPesan.ReadOnly = true;
            this.teksPesan.Size = new System.Drawing.Size(326, 29);
            this.teksPesan.TabIndex = 6;
            this.teksPesan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tombolHitung
            // 
            this.tombolHitung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolHitung.Location = new System.Drawing.Point(16, 225);
            this.tombolHitung.Name = "tombolHitung";
            this.tombolHitung.Size = new System.Drawing.Size(143, 60);
            this.tombolHitung.TabIndex = 7;
            this.tombolHitung.Text = "Hitung Harga Penjualan";
            this.tombolHitung.UseVisualStyleBackColor = true;
            this.tombolHitung.Click += new System.EventHandler(this.tombolHitung_Click);
            // 
            // tombolKeluar
            // 
            this.tombolKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolKeluar.Location = new System.Drawing.Point(244, 225);
            this.tombolKeluar.Name = "tombolKeluar";
            this.tombolKeluar.Size = new System.Drawing.Size(98, 60);
            this.tombolKeluar.TabIndex = 8;
            this.tombolKeluar.Text = "Keluar";
            this.tombolKeluar.UseVisualStyleBackColor = true;
            this.tombolKeluar.Click += new System.EventHandler(this.tombolKeluar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 301);
            this.Controls.Add(this.tombolKeluar);
            this.Controls.Add(this.tombolHitung);
            this.Controls.Add(this.teksPesan);
            this.Controls.Add(this.teksHargaPenjualan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.teksPersenDiskon);
            this.Controls.Add(this.teksHargaRetail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Demo Metode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox teksHargaRetail;
        private System.Windows.Forms.TextBox teksPersenDiskon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox teksHargaPenjualan;
        private System.Windows.Forms.TextBox teksPesan;
        private System.Windows.Forms.Button tombolHitung;
        private System.Windows.Forms.Button tombolKeluar;
    }
}

