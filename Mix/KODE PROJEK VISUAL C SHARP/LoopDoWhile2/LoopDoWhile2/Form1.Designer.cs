namespace LoopDoWhile2
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
            this.listKeluaran = new System.Windows.Forms.ListBox();
            this.tombolDemo = new System.Windows.Forms.Button();
            this.tombolBersih = new System.Windows.Forms.Button();
            this.tombolKeluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listKeluaran
            // 
            this.listKeluaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listKeluaran.FormattingEnabled = true;
            this.listKeluaran.ItemHeight = 20;
            this.listKeluaran.Location = new System.Drawing.Point(13, 13);
            this.listKeluaran.Name = "listKeluaran";
            this.listKeluaran.ScrollAlwaysVisible = true;
            this.listKeluaran.Size = new System.Drawing.Size(214, 164);
            this.listKeluaran.TabIndex = 0;
            // 
            // tombolDemo
            // 
            this.tombolDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolDemo.Location = new System.Drawing.Point(12, 265);
            this.tombolDemo.Name = "tombolDemo";
            this.tombolDemo.Size = new System.Drawing.Size(214, 44);
            this.tombolDemo.TabIndex = 1;
            this.tombolDemo.Text = "Demo";
            this.tombolDemo.UseVisualStyleBackColor = true;
            this.tombolDemo.Click += new System.EventHandler(this.tombolDemo_Click);
            // 
            // tombolBersih
            // 
            this.tombolBersih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolBersih.Location = new System.Drawing.Point(121, 205);
            this.tombolBersih.Name = "tombolBersih";
            this.tombolBersih.Size = new System.Drawing.Size(105, 44);
            this.tombolBersih.TabIndex = 2;
            this.tombolBersih.Text = "Bersih";
            this.tombolBersih.UseVisualStyleBackColor = true;
            this.tombolBersih.Click += new System.EventHandler(this.tombolBersih_Click);
            // 
            // tombolKeluar
            // 
            this.tombolKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolKeluar.Location = new System.Drawing.Point(12, 205);
            this.tombolKeluar.Name = "tombolKeluar";
            this.tombolKeluar.Size = new System.Drawing.Size(103, 44);
            this.tombolKeluar.TabIndex = 3;
            this.tombolKeluar.Text = "Keluar";
            this.tombolKeluar.UseVisualStyleBackColor = true;
            this.tombolKeluar.Click += new System.EventHandler(this.tombolKeluar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 321);
            this.Controls.Add(this.tombolKeluar);
            this.Controls.Add(this.tombolBersih);
            this.Controls.Add(this.tombolDemo);
            this.Controls.Add(this.listKeluaran);
            this.Name = "Form1";
            this.Text = "Loop Do While 2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listKeluaran;
        private System.Windows.Forms.Button tombolDemo;
        private System.Windows.Forms.Button tombolBersih;
        private System.Windows.Forms.Button tombolKeluar;
    }
}

