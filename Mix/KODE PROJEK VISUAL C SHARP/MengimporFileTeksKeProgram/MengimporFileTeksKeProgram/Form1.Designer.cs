namespace MengimporFileTeksKeProgram
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
            this.CBPath = new System.Windows.Forms.ComboBox();
            this.tombolIsiKotakList = new System.Windows.Forms.Button();
            this.kotakList = new System.Windows.Forms.ListBox();
            this.tombolSimpan = new System.Windows.Forms.Button();
            this.tombolKeluar = new System.Windows.Forms.Button();
            this.kotakTeks = new System.Windows.Forms.TextBox();
            this.tombolIsiKotakTeks = new System.Windows.Forms.Button();
            this.teksPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CBPath
            // 
            this.CBPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBPath.FormattingEnabled = true;
            this.CBPath.Items.AddRange(new object[] {
            "E:\\propinsi.txt"});
            this.CBPath.Location = new System.Drawing.Point(11, 10);
            this.CBPath.Name = "CBPath";
            this.CBPath.Size = new System.Drawing.Size(188, 28);
            this.CBPath.TabIndex = 1;
            // 
            // tombolIsiKotakList
            // 
            this.tombolIsiKotakList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolIsiKotakList.Location = new System.Drawing.Point(231, 10);
            this.tombolIsiKotakList.Name = "tombolIsiKotakList";
            this.tombolIsiKotakList.Size = new System.Drawing.Size(186, 35);
            this.tombolIsiKotakList.TabIndex = 2;
            this.tombolIsiKotakList.Text = "Isi Kotak List";
            this.tombolIsiKotakList.UseVisualStyleBackColor = true;
            this.tombolIsiKotakList.Click += new System.EventHandler(this.tombolIsiKotakList_Click);
            // 
            // kotakList
            // 
            this.kotakList.FormattingEnabled = true;
            this.kotakList.Location = new System.Drawing.Point(231, 62);
            this.kotakList.Name = "kotakList";
            this.kotakList.ScrollAlwaysVisible = true;
            this.kotakList.Size = new System.Drawing.Size(186, 186);
            this.kotakList.TabIndex = 3;
            // 
            // tombolSimpan
            // 
            this.tombolSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolSimpan.Location = new System.Drawing.Point(231, 254);
            this.tombolSimpan.Name = "tombolSimpan";
            this.tombolSimpan.Size = new System.Drawing.Size(186, 35);
            this.tombolSimpan.TabIndex = 4;
            this.tombolSimpan.Text = "Simpan";
            this.tombolSimpan.UseVisualStyleBackColor = true;
            this.tombolSimpan.Click += new System.EventHandler(this.tombolSimpan_Click);
            // 
            // tombolKeluar
            // 
            this.tombolKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolKeluar.Location = new System.Drawing.Point(231, 295);
            this.tombolKeluar.Name = "tombolKeluar";
            this.tombolKeluar.Size = new System.Drawing.Size(186, 35);
            this.tombolKeluar.TabIndex = 5;
            this.tombolKeluar.Text = "Keluar";
            this.tombolKeluar.UseVisualStyleBackColor = true;
            this.tombolKeluar.Click += new System.EventHandler(this.tombolKeluar_Click);
            // 
            // kotakTeks
            // 
            this.kotakTeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kotakTeks.Location = new System.Drawing.Point(13, 62);
            this.kotakTeks.Multiline = true;
            this.kotakTeks.Name = "kotakTeks";
            this.kotakTeks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.kotakTeks.Size = new System.Drawing.Size(186, 186);
            this.kotakTeks.TabIndex = 6;
            // 
            // tombolIsiKotakTeks
            // 
            this.tombolIsiKotakTeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolIsiKotakTeks.Location = new System.Drawing.Point(11, 254);
            this.tombolIsiKotakTeks.Name = "tombolIsiKotakTeks";
            this.tombolIsiKotakTeks.Size = new System.Drawing.Size(188, 35);
            this.tombolIsiKotakTeks.TabIndex = 7;
            this.tombolIsiKotakTeks.Text = "Isi Kotak Teks";
            this.tombolIsiKotakTeks.UseVisualStyleBackColor = true;
            this.tombolIsiKotakTeks.Click += new System.EventHandler(this.tombolIsiKotakTeks_Click);
            // 
            // teksPath
            // 
            this.teksPath.Location = new System.Drawing.Point(11, 304);
            this.teksPath.Name = "teksPath";
            this.teksPath.Size = new System.Drawing.Size(188, 20);
            this.teksPath.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 339);
            this.Controls.Add(this.teksPath);
            this.Controls.Add(this.tombolIsiKotakTeks);
            this.Controls.Add(this.kotakTeks);
            this.Controls.Add(this.tombolKeluar);
            this.Controls.Add(this.tombolSimpan);
            this.Controls.Add(this.kotakList);
            this.Controls.Add(this.tombolIsiKotakList);
            this.Controls.Add(this.CBPath);
            this.Name = "Form1";
            this.Text = "Mengimpor File Teks Ke Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBPath;
        private System.Windows.Forms.Button tombolIsiKotakList;
        private System.Windows.Forms.ListBox kotakList;
        private System.Windows.Forms.Button tombolSimpan;
        private System.Windows.Forms.Button tombolKeluar;
        private System.Windows.Forms.TextBox kotakTeks;
        private System.Windows.Forms.Button tombolIsiKotakTeks;
        private System.Windows.Forms.TextBox teksPath;
    }
}

