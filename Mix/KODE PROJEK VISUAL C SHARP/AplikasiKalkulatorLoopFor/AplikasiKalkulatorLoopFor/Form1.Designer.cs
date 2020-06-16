namespace AplikasiKalkulatorLoopFor
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
            this.tombolTabel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.teksAngka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.teksKali = new System.Windows.Forms.TextBox();
            this.tombolBersih = new System.Windows.Forms.Button();
            this.tombolKeluar = new System.Windows.Forms.Button();
            this.kotakList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tombolTabel
            // 
            this.tombolTabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolTabel.Location = new System.Drawing.Point(12, 12);
            this.tombolTabel.Name = "tombolTabel";
            this.tombolTabel.Size = new System.Drawing.Size(173, 62);
            this.tombolTabel.TabIndex = 0;
            this.tombolTabel.Text = "Tabel Perkalian";
            this.tombolTabel.UseVisualStyleBackColor = true;
            this.tombolTabel.Click += new System.EventHandler(this.tombolTabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Angka Anda:";
            // 
            // teksAngka
            // 
            this.teksAngka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksAngka.Location = new System.Drawing.Point(16, 107);
            this.teksAngka.Name = "teksAngka";
            this.teksAngka.Size = new System.Drawing.Size(169, 29);
            this.teksAngka.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dikalikan Dengan:";
            // 
            // teksKali
            // 
            this.teksKali.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksKali.Location = new System.Drawing.Point(16, 169);
            this.teksKali.Name = "teksKali";
            this.teksKali.Size = new System.Drawing.Size(169, 29);
            this.teksKali.TabIndex = 4;
            // 
            // tombolBersih
            // 
            this.tombolBersih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolBersih.Location = new System.Drawing.Point(16, 220);
            this.tombolBersih.Name = "tombolBersih";
            this.tombolBersih.Size = new System.Drawing.Size(169, 62);
            this.tombolBersih.TabIndex = 5;
            this.tombolBersih.Text = "Bersihkan";
            this.tombolBersih.UseVisualStyleBackColor = true;
            this.tombolBersih.Click += new System.EventHandler(this.tombolBersih_Click);
            // 
            // tombolKeluar
            // 
            this.tombolKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolKeluar.Location = new System.Drawing.Point(16, 294);
            this.tombolKeluar.Name = "tombolKeluar";
            this.tombolKeluar.Size = new System.Drawing.Size(169, 62);
            this.tombolKeluar.TabIndex = 6;
            this.tombolKeluar.Text = "Keluar";
            this.tombolKeluar.UseVisualStyleBackColor = true;
            this.tombolKeluar.Click += new System.EventHandler(this.tombolKeluar_Click);
            // 
            // kotakList
            // 
            this.kotakList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kotakList.FormattingEnabled = true;
            this.kotakList.ItemHeight = 20;
            this.kotakList.Location = new System.Drawing.Point(207, 15);
            this.kotakList.Name = "kotakList";
            this.kotakList.ScrollAlwaysVisible = true;
            this.kotakList.Size = new System.Drawing.Size(218, 344);
            this.kotakList.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 368);
            this.Controls.Add(this.kotakList);
            this.Controls.Add(this.tombolKeluar);
            this.Controls.Add(this.tombolBersih);
            this.Controls.Add(this.teksKali);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.teksAngka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tombolTabel);
            this.Name = "Form1";
            this.Text = "Aplikasi Kalkulator Dengan Loop For";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tombolTabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teksAngka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox teksKali;
        private System.Windows.Forms.Button tombolBersih;
        private System.Windows.Forms.Button tombolKeluar;
        private System.Windows.Forms.ListBox kotakList;
    }
}

