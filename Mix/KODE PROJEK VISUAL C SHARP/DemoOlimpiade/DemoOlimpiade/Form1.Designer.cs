namespace DemoOlimpiade
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
            this.teksPosisi = new System.Windows.Forms.TextBox();
            this.tombolEvaluasi = new System.Windows.Forms.Button();
            this.teksKeluaran = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Posisi Finish (1, 2, 3, ...):";
            // 
            // teksPosisi
            // 
            this.teksPosisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksPosisi.Location = new System.Drawing.Point(230, 22);
            this.teksPosisi.Name = "teksPosisi";
            this.teksPosisi.Size = new System.Drawing.Size(53, 26);
            this.teksPosisi.TabIndex = 1;
            // 
            // tombolEvaluasi
            // 
            this.tombolEvaluasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolEvaluasi.Location = new System.Drawing.Point(16, 84);
            this.tombolEvaluasi.Name = "tombolEvaluasi";
            this.tombolEvaluasi.Size = new System.Drawing.Size(266, 51);
            this.tombolEvaluasi.TabIndex = 2;
            this.tombolEvaluasi.Text = "Evaluasi Posisi";
            this.tombolEvaluasi.UseVisualStyleBackColor = true;
            this.tombolEvaluasi.Click += new System.EventHandler(this.tombolEvaluasi_Click);
            // 
            // teksKeluaran
            // 
            this.teksKeluaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksKeluaran.Location = new System.Drawing.Point(16, 163);
            this.teksKeluaran.Multiline = true;
            this.teksKeluaran.Name = "teksKeluaran";
            this.teksKeluaran.ReadOnly = true;
            this.teksKeluaran.Size = new System.Drawing.Size(266, 56);
            this.teksKeluaran.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 235);
            this.Controls.Add(this.teksKeluaran);
            this.Controls.Add(this.tombolEvaluasi);
            this.Controls.Add(this.teksPosisi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Demo Olimpiade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teksPosisi;
        private System.Windows.Forms.Button tombolEvaluasi;
        private System.Windows.Forms.TextBox teksKeluaran;
    }
}

