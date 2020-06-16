namespace StatemenIfDenganAND
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.teksBahanBakar = new System.Windows.Forms.TextBox();
            this.teksBaterei = new System.Windows.Forms.TextBox();
            this.teksKunci = new System.Windows.Forms.TextBox();
            this.tombolNyalakan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiga Perangkat Untuk Menyalakan Mobil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bahan Bakar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Baterei:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kunci:";
            // 
            // teksBahanBakar
            // 
            this.teksBahanBakar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.teksBahanBakar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksBahanBakar.Location = new System.Drawing.Point(142, 76);
            this.teksBahanBakar.Name = "teksBahanBakar";
            this.teksBahanBakar.Size = new System.Drawing.Size(200, 26);
            this.teksBahanBakar.TabIndex = 4;
            // 
            // teksBaterei
            // 
            this.teksBaterei.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.teksBaterei.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksBaterei.Location = new System.Drawing.Point(142, 114);
            this.teksBaterei.Name = "teksBaterei";
            this.teksBaterei.Size = new System.Drawing.Size(200, 26);
            this.teksBaterei.TabIndex = 5;
            // 
            // teksKunci
            // 
            this.teksKunci.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.teksKunci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksKunci.Location = new System.Drawing.Point(143, 156);
            this.teksKunci.Name = "teksKunci";
            this.teksKunci.Size = new System.Drawing.Size(200, 26);
            this.teksKunci.TabIndex = 6;
            // 
            // tombolNyalakan
            // 
            this.tombolNyalakan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolNyalakan.Location = new System.Drawing.Point(22, 205);
            this.tombolNyalakan.Name = "tombolNyalakan";
            this.tombolNyalakan.Size = new System.Drawing.Size(321, 48);
            this.tombolNyalakan.TabIndex = 7;
            this.tombolNyalakan.Text = "Nyalakan Mobil";
            this.tombolNyalakan.UseVisualStyleBackColor = true;
            this.tombolNyalakan.Click += new System.EventHandler(this.tombolNyalakan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 274);
            this.Controls.Add(this.tombolNyalakan);
            this.Controls.Add(this.teksKunci);
            this.Controls.Add(this.teksBaterei);
            this.Controls.Add(this.teksBahanBakar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Statemen If dengan ||";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox teksBahanBakar;
        private System.Windows.Forms.TextBox teksBaterei;
        private System.Windows.Forms.TextBox teksKunci;
        private System.Windows.Forms.Button tombolNyalakan;
    }
}

