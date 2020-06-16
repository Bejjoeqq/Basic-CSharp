namespace DemoNilaiHuruf
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
            this.teksNilaiNumerik = new System.Windows.Forms.TextBox();
            this.tombolCari = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.teksKeluaran = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nilai Numerik:";
            // 
            // teksNilaiNumerik
            // 
            this.teksNilaiNumerik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksNilaiNumerik.Location = new System.Drawing.Point(92, 20);
            this.teksNilaiNumerik.Name = "teksNilaiNumerik";
            this.teksNilaiNumerik.Size = new System.Drawing.Size(100, 29);
            this.teksNilaiNumerik.TabIndex = 1;
            // 
            // tombolCari
            // 
            this.tombolCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolCari.Location = new System.Drawing.Point(16, 79);
            this.tombolCari.Name = "tombolCari";
            this.tombolCari.Size = new System.Drawing.Size(244, 54);
            this.tombolCari.TabIndex = 2;
            this.tombolCari.Text = "Cari Nilai Ekivalen";
            this.tombolCari.UseVisualStyleBackColor = true;
            this.tombolCari.Click += new System.EventHandler(this.tombolCari_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nilai Huruf Ekivalen:";
            // 
            // teksKeluaran
            // 
            this.teksKeluaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksKeluaran.Location = new System.Drawing.Point(16, 198);
            this.teksKeluaran.Name = "teksKeluaran";
            this.teksKeluaran.ReadOnly = true;
            this.teksKeluaran.Size = new System.Drawing.Size(244, 29);
            this.teksKeluaran.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 250);
            this.Controls.Add(this.teksKeluaran);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tombolCari);
            this.Controls.Add(this.teksNilaiNumerik);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Demo Nilai Huruf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teksNilaiNumerik;
        private System.Windows.Forms.Button tombolCari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox teksKeluaran;
    }
}

