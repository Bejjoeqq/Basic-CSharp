namespace KalkulatorSederhana
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
            this.listJawaban = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.teksAngka1 = new System.Windows.Forms.TextBox();
            this.teksAngka2 = new System.Windows.Forms.TextBox();
            this.teksJawaban = new System.Windows.Forms.TextBox();
            this.tombolKali = new System.Windows.Forms.Button();
            this.tombolBagi = new System.Windows.Forms.Button();
            this.tombolKurang = new System.Windows.Forms.Button();
            this.tombolTambah = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listJawaban
            // 
            this.listJawaban.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listJawaban.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listJawaban.FormattingEnabled = true;
            this.listJawaban.ItemHeight = 20;
            this.listJawaban.Location = new System.Drawing.Point(13, 28);
            this.listJawaban.Name = "listJawaban";
            this.listJawaban.ScrollAlwaysVisible = true;
            this.listJawaban.Size = new System.Drawing.Size(351, 204);
            this.listJawaban.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jawaban:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Angka 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(521, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Angka 2:";
            // 
            // teksAngka1
            // 
            this.teksAngka1.BackColor = System.Drawing.Color.Khaki;
            this.teksAngka1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksAngka1.Location = new System.Drawing.Point(390, 30);
            this.teksAngka1.Name = "teksAngka1";
            this.teksAngka1.Size = new System.Drawing.Size(100, 31);
            this.teksAngka1.TabIndex = 4;
            // 
            // teksAngka2
            // 
            this.teksAngka2.BackColor = System.Drawing.Color.Khaki;
            this.teksAngka2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksAngka2.Location = new System.Drawing.Point(524, 30);
            this.teksAngka2.Name = "teksAngka2";
            this.teksAngka2.Size = new System.Drawing.Size(100, 31);
            this.teksAngka2.TabIndex = 5;
            // 
            // teksJawaban
            // 
            this.teksJawaban.BackColor = System.Drawing.Color.Aquamarine;
            this.teksJawaban.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksJawaban.Location = new System.Drawing.Point(390, 89);
            this.teksJawaban.Name = "teksJawaban";
            this.teksJawaban.Size = new System.Drawing.Size(234, 44);
            this.teksJawaban.TabIndex = 6;
            // 
            // tombolKali
            // 
            this.tombolKali.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolKali.Location = new System.Drawing.Point(392, 188);
            this.tombolKali.Name = "tombolKali";
            this.tombolKali.Size = new System.Drawing.Size(47, 44);
            this.tombolKali.TabIndex = 7;
            this.tombolKali.Text = "x";
            this.tombolKali.UseVisualStyleBackColor = true;
            this.tombolKali.Click += new System.EventHandler(this.tombolKali_Click);
            // 
            // tombolBagi
            // 
            this.tombolBagi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolBagi.Location = new System.Drawing.Point(455, 188);
            this.tombolBagi.Name = "tombolBagi";
            this.tombolBagi.Size = new System.Drawing.Size(47, 44);
            this.tombolBagi.TabIndex = 8;
            this.tombolBagi.Text = "/";
            this.tombolBagi.UseVisualStyleBackColor = true;
            this.tombolBagi.Click += new System.EventHandler(this.tombolBagi_Click);
            // 
            // tombolKurang
            // 
            this.tombolKurang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolKurang.Location = new System.Drawing.Point(517, 188);
            this.tombolKurang.Name = "tombolKurang";
            this.tombolKurang.Size = new System.Drawing.Size(47, 44);
            this.tombolKurang.TabIndex = 9;
            this.tombolKurang.Text = "-";
            this.tombolKurang.UseVisualStyleBackColor = true;
            this.tombolKurang.Click += new System.EventHandler(this.tombolKurang_Click);
            // 
            // tombolTambah
            // 
            this.tombolTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolTambah.Location = new System.Drawing.Point(577, 188);
            this.tombolTambah.Name = "tombolTambah";
            this.tombolTambah.Size = new System.Drawing.Size(47, 44);
            this.tombolTambah.TabIndex = 10;
            this.tombolTambah.Text = "+";
            this.tombolTambah.UseVisualStyleBackColor = true;
            this.tombolTambah.Click += new System.EventHandler(this.tombolTambah_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 249);
            this.Controls.Add(this.tombolTambah);
            this.Controls.Add(this.tombolKurang);
            this.Controls.Add(this.tombolBagi);
            this.Controls.Add(this.tombolKali);
            this.Controls.Add(this.teksJawaban);
            this.Controls.Add(this.teksAngka2);
            this.Controls.Add(this.teksAngka1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listJawaban);
            this.Name = "Form1";
            this.Text = "Kalkulator Sederhana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listJawaban;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox teksAngka1;
        private System.Windows.Forms.TextBox teksAngka2;
        private System.Windows.Forms.TextBox teksJawaban;
        private System.Windows.Forms.Button tombolKali;
        private System.Windows.Forms.Button tombolBagi;
        private System.Windows.Forms.Button tombolKurang;
        private System.Windows.Forms.Button tombolTambah;
    }
}

