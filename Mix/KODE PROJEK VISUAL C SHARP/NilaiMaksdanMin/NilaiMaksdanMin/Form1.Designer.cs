namespace NilaiMaksdanMin
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
            this.tombolHitung = new System.Windows.Forms.Button();
            this.teksNilai = new System.Windows.Forms.TextBox();
            this.kotakList = new System.Windows.Forms.ListBox();
            this.teksRerata = new System.Windows.Forms.TextBox();
            this.teksMaks = new System.Windows.Forms.TextBox();
            this.teksMin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tombolHitung
            // 
            this.tombolHitung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolHitung.Location = new System.Drawing.Point(13, 23);
            this.tombolHitung.Name = "tombolHitung";
            this.tombolHitung.Size = new System.Drawing.Size(133, 49);
            this.tombolHitung.TabIndex = 0;
            this.tombolHitung.Text = "Hitung";
            this.tombolHitung.UseVisualStyleBackColor = true;
            this.tombolHitung.Click += new System.EventHandler(this.tombolHitung_Click);
            // 
            // teksNilai
            // 
            this.teksNilai.BackColor = System.Drawing.Color.Moccasin;
            this.teksNilai.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksNilai.Location = new System.Drawing.Point(166, 25);
            this.teksNilai.Name = "teksNilai";
            this.teksNilai.Size = new System.Drawing.Size(261, 44);
            this.teksNilai.TabIndex = 1;
            // 
            // kotakList
            // 
            this.kotakList.BackColor = System.Drawing.Color.LemonChiffon;
            this.kotakList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kotakList.FormattingEnabled = true;
            this.kotakList.ItemHeight = 24;
            this.kotakList.Location = new System.Drawing.Point(13, 95);
            this.kotakList.Name = "kotakList";
            this.kotakList.ScrollAlwaysVisible = true;
            this.kotakList.Size = new System.Drawing.Size(414, 172);
            this.kotakList.TabIndex = 2;
            // 
            // teksRerata
            // 
            this.teksRerata.BackColor = System.Drawing.Color.Gainsboro;
            this.teksRerata.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksRerata.Location = new System.Drawing.Point(13, 287);
            this.teksRerata.Name = "teksRerata";
            this.teksRerata.ReadOnly = true;
            this.teksRerata.Size = new System.Drawing.Size(414, 44);
            this.teksRerata.TabIndex = 3;
            // 
            // teksMaks
            // 
            this.teksMaks.BackColor = System.Drawing.Color.Gainsboro;
            this.teksMaks.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksMaks.Location = new System.Drawing.Point(12, 337);
            this.teksMaks.Name = "teksMaks";
            this.teksMaks.ReadOnly = true;
            this.teksMaks.Size = new System.Drawing.Size(415, 44);
            this.teksMaks.TabIndex = 4;
            // 
            // teksMin
            // 
            this.teksMin.BackColor = System.Drawing.Color.Gainsboro;
            this.teksMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksMin.Location = new System.Drawing.Point(12, 393);
            this.teksMin.Name = "teksMin";
            this.teksMin.ReadOnly = true;
            this.teksMin.Size = new System.Drawing.Size(415, 44);
            this.teksMin.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 449);
            this.Controls.Add(this.teksMin);
            this.Controls.Add(this.teksMaks);
            this.Controls.Add(this.teksRerata);
            this.Controls.Add(this.kotakList);
            this.Controls.Add(this.teksNilai);
            this.Controls.Add(this.tombolHitung);
            this.Name = "Form1";
            this.Text = "Menghitung Nilai Maksimum dan Minimum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tombolHitung;
        private System.Windows.Forms.TextBox teksNilai;
        private System.Windows.Forms.ListBox kotakList;
        private System.Windows.Forms.TextBox teksRerata;
        private System.Windows.Forms.TextBox teksMaks;
        private System.Windows.Forms.TextBox teksMin;
    }
}

