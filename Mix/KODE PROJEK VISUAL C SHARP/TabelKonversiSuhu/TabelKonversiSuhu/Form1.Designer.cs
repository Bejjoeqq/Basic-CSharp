namespace TabelKonversiSuhu
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
            this.tombolTampilkan = new System.Windows.Forms.Button();
            this.listKeluaran = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tombolTampilkan
            // 
            this.tombolTampilkan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolTampilkan.Location = new System.Drawing.Point(13, 25);
            this.tombolTampilkan.Name = "tombolTampilkan";
            this.tombolTampilkan.Size = new System.Drawing.Size(274, 47);
            this.tombolTampilkan.TabIndex = 0;
            this.tombolTampilkan.Text = "Tampilkan Tabel Konversi Suhu";
            this.tombolTampilkan.UseVisualStyleBackColor = true;
            this.tombolTampilkan.Click += new System.EventHandler(this.tombolTampilkan_Click);
            // 
            // listKeluaran
            // 
            this.listKeluaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listKeluaran.FormattingEnabled = true;
            this.listKeluaran.ItemHeight = 20;
            this.listKeluaran.Location = new System.Drawing.Point(13, 98);
            this.listKeluaran.Name = "listKeluaran";
            this.listKeluaran.ScrollAlwaysVisible = true;
            this.listKeluaran.Size = new System.Drawing.Size(274, 124);
            this.listKeluaran.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 243);
            this.Controls.Add(this.listKeluaran);
            this.Controls.Add(this.tombolTampilkan);
            this.Name = "Form1";
            this.Text = "Tabel Konversi Suhu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tombolTampilkan;
        private System.Windows.Forms.ListBox listKeluaran;
    }
}

