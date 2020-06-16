namespace DemoLuasBangun
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
            this.teksSeleksi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.teksRadius = new System.Windows.Forms.TextBox();
            this.teksTinggi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.teksPanjang = new System.Windows.Forms.TextBox();
            this.teksLebar = new System.Windows.Forms.TextBox();
            this.tombolHitung = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.teksLuas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pilihlah Salah Satu Bangun:";
            // 
            // teksSeleksi
            // 
            this.teksSeleksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksSeleksi.Location = new System.Drawing.Point(158, 22);
            this.teksSeleksi.Name = "teksSeleksi";
            this.teksSeleksi.Size = new System.Drawing.Size(52, 29);
            this.teksSeleksi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "1. Lingkaran";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "2. Jajarang-Genjang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "3. Layang-Layang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Radius:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tinggi:";
            // 
            // teksRadius
            // 
            this.teksRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksRadius.Location = new System.Drawing.Point(62, 127);
            this.teksRadius.Name = "teksRadius";
            this.teksRadius.Size = new System.Drawing.Size(89, 29);
            this.teksRadius.TabIndex = 7;
            // 
            // teksTinggi
            // 
            this.teksTinggi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksTinggi.Location = new System.Drawing.Point(62, 176);
            this.teksTinggi.Name = "teksTinggi";
            this.teksTinggi.Size = new System.Drawing.Size(89, 29);
            this.teksTinggi.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Panjang:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(191, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Lebar:";
            // 
            // teksPanjang
            // 
            this.teksPanjang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksPanjang.Location = new System.Drawing.Point(246, 127);
            this.teksPanjang.Name = "teksPanjang";
            this.teksPanjang.Size = new System.Drawing.Size(89, 29);
            this.teksPanjang.TabIndex = 11;
            // 
            // teksLebar
            // 
            this.teksLebar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksLebar.Location = new System.Drawing.Point(246, 176);
            this.teksLebar.Name = "teksLebar";
            this.teksLebar.Size = new System.Drawing.Size(89, 29);
            this.teksLebar.TabIndex = 12;
            // 
            // tombolHitung
            // 
            this.tombolHitung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolHitung.Location = new System.Drawing.Point(17, 235);
            this.tombolHitung.Name = "tombolHitung";
            this.tombolHitung.Size = new System.Drawing.Size(318, 41);
            this.tombolHitung.TabIndex = 13;
            this.tombolHitung.Text = "Hitung Luas Bangun";
            this.tombolHitung.UseVisualStyleBackColor = true;
            this.tombolHitung.Click += new System.EventHandler(this.tombolHitung_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Luas Bangun:";
            // 
            // teksLuas
            // 
            this.teksLuas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksLuas.Location = new System.Drawing.Point(93, 289);
            this.teksLuas.Name = "teksLuas";
            this.teksLuas.ReadOnly = true;
            this.teksLuas.Size = new System.Drawing.Size(242, 29);
            this.teksLuas.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 353);
            this.Controls.Add(this.teksLuas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tombolHitung);
            this.Controls.Add(this.teksLebar);
            this.Controls.Add(this.teksPanjang);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.teksTinggi);
            this.Controls.Add(this.teksRadius);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.teksSeleksi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Demo Luas Bangun";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teksSeleksi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox teksRadius;
        private System.Windows.Forms.TextBox teksTinggi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox teksPanjang;
        private System.Windows.Forms.TextBox teksLebar;
        private System.Windows.Forms.Button tombolHitung;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox teksLuas;
    }
}

