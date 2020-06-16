namespace AplikasiPenjualanDoWhile
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
            this.teksHasil = new System.Windows.Forms.TextBox();
            this.tombolMasukkan = new System.Windows.Forms.Button();
            this.tombolKeluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Penjualan";
            // 
            // teksHasil
            // 
            this.teksHasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksHasil.Location = new System.Drawing.Point(21, 37);
            this.teksHasil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.teksHasil.Name = "teksHasil";
            this.teksHasil.ReadOnly = true;
            this.teksHasil.Size = new System.Drawing.Size(387, 34);
            this.teksHasil.TabIndex = 1;
            // 
            // tombolMasukkan
            // 
            this.tombolMasukkan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolMasukkan.Location = new System.Drawing.Point(21, 101);
            this.tombolMasukkan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tombolMasukkan.Name = "tombolMasukkan";
            this.tombolMasukkan.Size = new System.Drawing.Size(225, 65);
            this.tombolMasukkan.TabIndex = 2;
            this.tombolMasukkan.Text = "Masukkan Penjualan";
            this.tombolMasukkan.UseVisualStyleBackColor = true;
            this.tombolMasukkan.Click += new System.EventHandler(this.tombolMasukkan_Click);
            // 
            // tombolKeluar
            // 
            this.tombolKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolKeluar.Location = new System.Drawing.Point(271, 101);
            this.tombolKeluar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tombolKeluar.Name = "tombolKeluar";
            this.tombolKeluar.Size = new System.Drawing.Size(139, 65);
            this.tombolKeluar.TabIndex = 3;
            this.tombolKeluar.Text = "Keluar";
            this.tombolKeluar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 197);
            this.Controls.Add(this.tombolKeluar);
            this.Controls.Add(this.tombolMasukkan);
            this.Controls.Add(this.teksHasil);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Aplikasi Penjualan Dengan Do While";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teksHasil;
        private System.Windows.Forms.Button tombolMasukkan;
        private System.Windows.Forms.Button tombolKeluar;
    }
}

