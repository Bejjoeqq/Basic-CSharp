namespace BatuGuntingKertas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBKertas = new System.Windows.Forms.RadioButton();
            this.RBGunting = new System.Windows.Forms.RadioButton();
            this.RBBatu = new System.Windows.Forms.RadioButton();
            this.tombolMainkan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.teksMenang = new System.Windows.Forms.TextBox();
            this.teksKalah = new System.Windows.Forms.TextBox();
            this.teksSeri = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBKertas);
            this.groupBox1.Controls.Add(this.RBGunting);
            this.groupBox1.Controls.Add(this.RBBatu);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pilihan Anda";
            // 
            // RBKertas
            // 
            this.RBKertas.AutoSize = true;
            this.RBKertas.Location = new System.Drawing.Point(175, 29);
            this.RBKertas.Name = "RBKertas";
            this.RBKertas.Size = new System.Drawing.Size(55, 17);
            this.RBKertas.TabIndex = 2;
            this.RBKertas.TabStop = true;
            this.RBKertas.Text = "Kertas";
            this.RBKertas.UseVisualStyleBackColor = true;
            // 
            // RBGunting
            // 
            this.RBGunting.AutoSize = true;
            this.RBGunting.Location = new System.Drawing.Point(85, 29);
            this.RBGunting.Name = "RBGunting";
            this.RBGunting.Size = new System.Drawing.Size(62, 17);
            this.RBGunting.TabIndex = 1;
            this.RBGunting.TabStop = true;
            this.RBGunting.Text = "Gunting";
            this.RBGunting.UseVisualStyleBackColor = true;
            // 
            // RBBatu
            // 
            this.RBBatu.AutoSize = true;
            this.RBBatu.Location = new System.Drawing.Point(7, 29);
            this.RBBatu.Name = "RBBatu";
            this.RBBatu.Size = new System.Drawing.Size(47, 17);
            this.RBBatu.TabIndex = 0;
            this.RBBatu.TabStop = true;
            this.RBBatu.Text = "Batu";
            this.RBBatu.UseVisualStyleBackColor = true;
            // 
            // tombolMainkan
            // 
            this.tombolMainkan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolMainkan.Location = new System.Drawing.Point(13, 169);
            this.tombolMainkan.Name = "tombolMainkan";
            this.tombolMainkan.Size = new System.Drawing.Size(241, 41);
            this.tombolMainkan.TabIndex = 1;
            this.tombolMainkan.Text = "Mainkan!";
            this.tombolMainkan.UseVisualStyleBackColor = true;
            this.tombolMainkan.Click += new System.EventHandler(this.tombolMainkan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menang:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kalah:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seri";
            // 
            // teksMenang
            // 
            this.teksMenang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksMenang.Location = new System.Drawing.Point(13, 122);
            this.teksMenang.Name = "teksMenang";
            this.teksMenang.ReadOnly = true;
            this.teksMenang.Size = new System.Drawing.Size(64, 26);
            this.teksMenang.TabIndex = 5;
            // 
            // teksKalah
            // 
            this.teksKalah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksKalah.Location = new System.Drawing.Point(98, 122);
            this.teksKalah.Name = "teksKalah";
            this.teksKalah.ReadOnly = true;
            this.teksKalah.Size = new System.Drawing.Size(64, 26);
            this.teksKalah.TabIndex = 6;
            // 
            // teksSeri
            // 
            this.teksSeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksSeri.Location = new System.Drawing.Point(188, 122);
            this.teksSeri.Name = "teksSeri";
            this.teksSeri.ReadOnly = true;
            this.teksSeri.Size = new System.Drawing.Size(66, 26);
            this.teksSeri.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 223);
            this.Controls.Add(this.teksSeri);
            this.Controls.Add(this.teksKalah);
            this.Controls.Add(this.teksMenang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tombolMainkan);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Batu Gunting Kertas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RBKertas;
        private System.Windows.Forms.RadioButton RBGunting;
        private System.Windows.Forms.RadioButton RBBatu;
        private System.Windows.Forms.Button tombolMainkan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox teksMenang;
        private System.Windows.Forms.TextBox teksKalah;
        private System.Windows.Forms.TextBox teksSeri;
    }
}

