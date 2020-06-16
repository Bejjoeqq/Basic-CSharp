namespace PembangkitanAngkaAcak
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
            this.teksAcak = new System.Windows.Forms.TextBox();
            this.tombolBangkitkan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.teksTerbesar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Angka-angka acak";
            // 
            // teksAcak
            // 
            this.teksAcak.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksAcak.Location = new System.Drawing.Point(17, 61);
            this.teksAcak.Name = "teksAcak";
            this.teksAcak.Size = new System.Drawing.Size(437, 29);
            this.teksAcak.TabIndex = 1;
            // 
            // tombolBangkitkan
            // 
            this.tombolBangkitkan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolBangkitkan.Location = new System.Drawing.Point(17, 134);
            this.tombolBangkitkan.Name = "tombolBangkitkan";
            this.tombolBangkitkan.Size = new System.Drawing.Size(212, 62);
            this.tombolBangkitkan.TabIndex = 2;
            this.tombolBangkitkan.Text = "Bangkitkan Angka Acak dan Hitung Terbesar";
            this.tombolBangkitkan.UseVisualStyleBackColor = true;
            this.tombolBangkitkan.Click += new System.EventHandler(this.tombolBangkitkan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Angka Terbesar:";
            // 
            // teksTerbesar
            // 
            this.teksTerbesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksTerbesar.Location = new System.Drawing.Point(261, 134);
            this.teksTerbesar.Name = "teksTerbesar";
            this.teksTerbesar.ReadOnly = true;
            this.teksTerbesar.Size = new System.Drawing.Size(193, 62);
            this.teksTerbesar.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 223);
            this.Controls.Add(this.teksTerbesar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tombolBangkitkan);
            this.Controls.Add(this.teksAcak);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pembangkitan Angka Acak";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teksAcak;
        private System.Windows.Forms.Button tombolBangkitkan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox teksTerbesar;
    }
}

