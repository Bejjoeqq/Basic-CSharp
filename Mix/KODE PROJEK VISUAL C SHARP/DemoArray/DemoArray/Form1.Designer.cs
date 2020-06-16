namespace DemoArray
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
            this.kotakList = new System.Windows.Forms.ListBox();
            this.tombolMasuk = new System.Windows.Forms.Button();
            this.tombolKeluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kotakList
            // 
            this.kotakList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kotakList.FormattingEnabled = true;
            this.kotakList.ItemHeight = 20;
            this.kotakList.Location = new System.Drawing.Point(13, 13);
            this.kotakList.Name = "kotakList";
            this.kotakList.ScrollAlwaysVisible = true;
            this.kotakList.Size = new System.Drawing.Size(316, 164);
            this.kotakList.TabIndex = 0;
            // 
            // tombolMasuk
            // 
            this.tombolMasuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolMasuk.Location = new System.Drawing.Point(13, 192);
            this.tombolMasuk.Name = "tombolMasuk";
            this.tombolMasuk.Size = new System.Drawing.Size(176, 49);
            this.tombolMasuk.TabIndex = 1;
            this.tombolMasuk.Text = "Masukkan Nama";
            this.tombolMasuk.UseVisualStyleBackColor = true;
            this.tombolMasuk.Click += new System.EventHandler(this.tombolMasuk_Click);
            // 
            // tombolKeluar
            // 
            this.tombolKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolKeluar.Location = new System.Drawing.Point(215, 192);
            this.tombolKeluar.Name = "tombolKeluar";
            this.tombolKeluar.Size = new System.Drawing.Size(114, 49);
            this.tombolKeluar.TabIndex = 2;
            this.tombolKeluar.Text = "Keluar";
            this.tombolKeluar.UseVisualStyleBackColor = true;
            this.tombolKeluar.Click += new System.EventHandler(this.tombolKeluar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 244);
            this.Controls.Add(this.tombolKeluar);
            this.Controls.Add(this.tombolMasuk);
            this.Controls.Add(this.kotakList);
            this.Name = "Form1";
            this.Text = "Demo Array: Daftar Teman";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox kotakList;
        private System.Windows.Forms.Button tombolMasuk;
        private System.Windows.Forms.Button tombolKeluar;
    }
}

