namespace MenghitungPeluruhan
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
            this.tombolTentukan = new System.Windows.Forms.Button();
            this.teksKeluaran = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tombolTentukan
            // 
            this.tombolTentukan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolTentukan.Location = new System.Drawing.Point(13, 25);
            this.tombolTentukan.Name = "tombolTentukan";
            this.tombolTentukan.Size = new System.Drawing.Size(352, 65);
            this.tombolTentukan.TabIndex = 0;
            this.tombolTentukan.Text = "Tentukan Waktu Peluruhan Strontium";
            this.tombolTentukan.UseVisualStyleBackColor = true;
            this.tombolTentukan.Click += new System.EventHandler(this.tombolTentukan_Click);
            // 
            // teksKeluaran
            // 
            this.teksKeluaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksKeluaran.Location = new System.Drawing.Point(13, 114);
            this.teksKeluaran.Name = "teksKeluaran";
            this.teksKeluaran.ReadOnly = true;
            this.teksKeluaran.Size = new System.Drawing.Size(352, 29);
            this.teksKeluaran.TabIndex = 1;
            this.teksKeluaran.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 174);
            this.Controls.Add(this.teksKeluaran);
            this.Controls.Add(this.tombolTentukan);
            this.Name = "Form1";
            this.Text = "Menghitung Peluruhan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tombolTentukan;
        private System.Windows.Forms.TextBox teksKeluaran;
    }
}

