namespace DemoMenghitungHari
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
            this.teksBulanMasked = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.teksTahunMasked = new System.Windows.Forms.MaskedTextBox();
            this.tombolTentukan = new System.Windows.Forms.Button();
            this.teksKeluaran = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bulan (1-12):";
            // 
            // teksBulanMasked
            // 
            this.teksBulanMasked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksBulanMasked.Location = new System.Drawing.Point(87, 19);
            this.teksBulanMasked.Mask = "00";
            this.teksBulanMasked.Name = "teksBulanMasked";
            this.teksBulanMasked.Size = new System.Drawing.Size(35, 26);
            this.teksBulanMasked.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tahun:";
            // 
            // teksTahunMasked
            // 
            this.teksTahunMasked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksTahunMasked.Location = new System.Drawing.Point(241, 19);
            this.teksTahunMasked.Mask = "0000";
            this.teksTahunMasked.Name = "teksTahunMasked";
            this.teksTahunMasked.Size = new System.Drawing.Size(55, 26);
            this.teksTahunMasked.TabIndex = 3;
            // 
            // tombolTentukan
            // 
            this.tombolTentukan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolTentukan.Location = new System.Drawing.Point(17, 72);
            this.tombolTentukan.Name = "tombolTentukan";
            this.tombolTentukan.Size = new System.Drawing.Size(284, 76);
            this.tombolTentukan.TabIndex = 4;
            this.tombolTentukan.Text = "Tentukan Jumlah Hari Pada Bulan Tersebut";
            this.tombolTentukan.UseVisualStyleBackColor = true;
            this.tombolTentukan.Click += new System.EventHandler(this.tombolTentukan_Click);
            // 
            // teksKeluaran
            // 
            this.teksKeluaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksKeluaran.Location = new System.Drawing.Point(17, 176);
            this.teksKeluaran.Multiline = true;
            this.teksKeluaran.Name = "teksKeluaran";
            this.teksKeluaran.ReadOnly = true;
            this.teksKeluaran.Size = new System.Drawing.Size(279, 60);
            this.teksKeluaran.TabIndex = 5;
            this.teksKeluaran.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 250);
            this.Controls.Add(this.teksKeluaran);
            this.Controls.Add(this.tombolTentukan);
            this.Controls.Add(this.teksTahunMasked);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.teksBulanMasked);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Demo Menghitung Hari";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox teksBulanMasked;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox teksTahunMasked;
        private System.Windows.Forms.Button tombolTentukan;
        private System.Windows.Forms.TextBox teksKeluaran;
    }
}

