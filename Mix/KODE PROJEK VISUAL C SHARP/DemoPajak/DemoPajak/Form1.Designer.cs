namespace DemoPajak
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
            this.teksSblmSkrg = new System.Windows.Forms.TextBox();
            this.teksTglSkrg = new System.Windows.Forms.TextBox();
            this.tombolHitung = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.teksPajak = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Penghasilan Sebelum Tahun Ini:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Penghasilan Pada Tahun Ini:";
            // 
            // teksSblmSkrg
            // 
            this.teksSblmSkrg.BackColor = System.Drawing.Color.MistyRose;
            this.teksSblmSkrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksSblmSkrg.Location = new System.Drawing.Point(206, 10);
            this.teksSblmSkrg.Name = "teksSblmSkrg";
            this.teksSblmSkrg.Size = new System.Drawing.Size(170, 29);
            this.teksSblmSkrg.TabIndex = 2;
            // 
            // teksTglSkrg
            // 
            this.teksTglSkrg.BackColor = System.Drawing.Color.MistyRose;
            this.teksTglSkrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksTglSkrg.Location = new System.Drawing.Point(206, 50);
            this.teksTglSkrg.Name = "teksTglSkrg";
            this.teksTglSkrg.Size = new System.Drawing.Size(170, 29);
            this.teksTglSkrg.TabIndex = 3;
            // 
            // tombolHitung
            // 
            this.tombolHitung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolHitung.Location = new System.Drawing.Point(16, 101);
            this.tombolHitung.Name = "tombolHitung";
            this.tombolHitung.Size = new System.Drawing.Size(360, 53);
            this.tombolHitung.TabIndex = 4;
            this.tombolHitung.Text = "Hitung Pajak";
            this.tombolHitung.UseVisualStyleBackColor = true;
            this.tombolHitung.Click += new System.EventHandler(this.tombolHitung_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pajak Dibayarkan:";
            // 
            // teksPajak
            // 
            this.teksPajak.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksPajak.Location = new System.Drawing.Point(113, 173);
            this.teksPajak.Name = "teksPajak";
            this.teksPajak.ReadOnly = true;
            this.teksPajak.Size = new System.Drawing.Size(263, 29);
            this.teksPajak.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 222);
            this.Controls.Add(this.teksPajak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tombolHitung);
            this.Controls.Add(this.teksTglSkrg);
            this.Controls.Add(this.teksSblmSkrg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Demo Pajak";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox teksSblmSkrg;
        private System.Windows.Forms.TextBox teksTglSkrg;
        private System.Windows.Forms.Button tombolHitung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox teksPajak;
    }
}

