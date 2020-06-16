namespace MembacaDataDariFile
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
            this.kotakList = new System.Windows.Forms.ListBox();
            this.tombolBaca = new System.Windows.Forms.Button();
            this.tombolBersih = new System.Windows.Forms.Button();
            this.tombolKeluar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kotakList);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Sahabat";
            // 
            // kotakList
            // 
            this.kotakList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kotakList.FormattingEnabled = true;
            this.kotakList.ItemHeight = 20;
            this.kotakList.Location = new System.Drawing.Point(7, 20);
            this.kotakList.Name = "kotakList";
            this.kotakList.ScrollAlwaysVisible = true;
            this.kotakList.Size = new System.Drawing.Size(441, 144);
            this.kotakList.TabIndex = 0;
            // 
            // tombolBaca
            // 
            this.tombolBaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolBaca.Location = new System.Drawing.Point(13, 212);
            this.tombolBaca.Name = "tombolBaca";
            this.tombolBaca.Size = new System.Drawing.Size(142, 43);
            this.tombolBaca.TabIndex = 1;
            this.tombolBaca.Text = "Baca Dari File";
            this.tombolBaca.UseVisualStyleBackColor = true;
            this.tombolBaca.Click += new System.EventHandler(this.tombolBaca_Click);
            // 
            // tombolBersih
            // 
            this.tombolBersih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolBersih.Location = new System.Drawing.Point(182, 212);
            this.tombolBersih.Name = "tombolBersih";
            this.tombolBersih.Size = new System.Drawing.Size(142, 43);
            this.tombolBersih.TabIndex = 2;
            this.tombolBersih.Text = "Bersihkan";
            this.tombolBersih.UseVisualStyleBackColor = true;
            this.tombolBersih.Click += new System.EventHandler(this.tombolBersih_Click);
            // 
            // tombolKeluar
            // 
            this.tombolKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolKeluar.Location = new System.Drawing.Point(347, 212);
            this.tombolKeluar.Name = "tombolKeluar";
            this.tombolKeluar.Size = new System.Drawing.Size(120, 43);
            this.tombolKeluar.TabIndex = 3;
            this.tombolKeluar.Text = "Keluar";
            this.tombolKeluar.UseVisualStyleBackColor = true;
            this.tombolKeluar.Click += new System.EventHandler(this.tombolKeluar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 262);
            this.Controls.Add(this.tombolKeluar);
            this.Controls.Add(this.tombolBersih);
            this.Controls.Add(this.tombolBaca);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Membaca Data Dari File";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox kotakList;
        private System.Windows.Forms.Button tombolBaca;
        private System.Windows.Forms.Button tombolBersih;
        private System.Windows.Forms.Button tombolKeluar;
    }
}

