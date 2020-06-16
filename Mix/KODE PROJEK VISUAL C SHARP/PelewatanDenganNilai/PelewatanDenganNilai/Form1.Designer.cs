namespace PelewatanDenganNilai
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
            this.tombolGo = new System.Windows.Forms.Button();
            this.tombolBersih = new System.Windows.Forms.Button();
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
            this.kotakList.Size = new System.Drawing.Size(670, 184);
            this.kotakList.TabIndex = 0;
            // 
            // tombolGo
            // 
            this.tombolGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolGo.Location = new System.Drawing.Point(13, 217);
            this.tombolGo.Name = "tombolGo";
            this.tombolGo.Size = new System.Drawing.Size(114, 33);
            this.tombolGo.TabIndex = 1;
            this.tombolGo.Text = "Go!";
            this.tombolGo.UseVisualStyleBackColor = true;
            this.tombolGo.Click += new System.EventHandler(this.tombolGo_Click);
            // 
            // tombolBersih
            // 
            this.tombolBersih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolBersih.Location = new System.Drawing.Point(300, 217);
            this.tombolBersih.Name = "tombolBersih";
            this.tombolBersih.Size = new System.Drawing.Size(114, 33);
            this.tombolBersih.TabIndex = 2;
            this.tombolBersih.Text = "Bersihkan";
            this.tombolBersih.UseVisualStyleBackColor = true;
            this.tombolBersih.Click += new System.EventHandler(this.tombolBersih_Click);
            // 
            // tombolKeluar
            // 
            this.tombolKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolKeluar.Location = new System.Drawing.Point(569, 217);
            this.tombolKeluar.Name = "tombolKeluar";
            this.tombolKeluar.Size = new System.Drawing.Size(114, 33);
            this.tombolKeluar.TabIndex = 3;
            this.tombolKeluar.Text = "Keluar";
            this.tombolKeluar.UseVisualStyleBackColor = true;
            this.tombolKeluar.Click += new System.EventHandler(this.tombolKeluar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 262);
            this.Controls.Add(this.tombolKeluar);
            this.Controls.Add(this.tombolBersih);
            this.Controls.Add(this.tombolGo);
            this.Controls.Add(this.kotakList);
            this.Name = "Form1";
            this.Text = "Pelewatan Dengan Nilai";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox kotakList;
        private System.Windows.Forms.Button tombolGo;
        private System.Windows.Forms.Button tombolBersih;
        private System.Windows.Forms.Button tombolKeluar;
    }
}

