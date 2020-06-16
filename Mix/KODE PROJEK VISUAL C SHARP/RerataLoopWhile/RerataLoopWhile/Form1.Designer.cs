namespace RerataLoopWhile
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
            this.label1 = new System.Windows.Forms.Label();
            this.teksRerata = new System.Windows.Forms.TextBox();
            this.tombolBaca = new System.Windows.Forms.Button();
            this.tombolKeluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nilai Rerata:";
            // 
            // teksRerata
            // 
            this.teksRerata.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksRerata.Location = new System.Drawing.Point(84, 13);
            this.teksRerata.Name = "teksRerata";
            this.teksRerata.ReadOnly = true;
            this.teksRerata.Size = new System.Drawing.Size(203, 29);
            this.teksRerata.TabIndex = 1;
            // 
            // tombolBaca
            // 
            this.tombolBaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolBaca.Location = new System.Drawing.Point(16, 63);
            this.tombolBaca.Name = "tombolBaca";
            this.tombolBaca.Size = new System.Drawing.Size(135, 42);
            this.tombolBaca.TabIndex = 2;
            this.tombolBaca.Text = "Baca Skor";
            this.tombolBaca.UseVisualStyleBackColor = true;
            this.tombolBaca.Click += new System.EventHandler(this.tombolBaca_Click);
            // 
            // tombolKeluar
            // 
            this.tombolKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolKeluar.Location = new System.Drawing.Point(179, 63);
            this.tombolKeluar.Name = "tombolKeluar";
            this.tombolKeluar.Size = new System.Drawing.Size(108, 42);
            this.tombolKeluar.TabIndex = 3;
            this.tombolKeluar.Text = "Keluar";
            this.tombolKeluar.UseVisualStyleBackColor = true;
            this.tombolKeluar.Click += new System.EventHandler(this.tombolKeluar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 127);
            this.Controls.Add(this.tombolKeluar);
            this.Controls.Add(this.tombolBaca);
            this.Controls.Add(this.teksRerata);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Rerata Dengan Loop While";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teksRerata;
        private System.Windows.Forms.Button tombolBaca;
        private System.Windows.Forms.Button tombolKeluar;
    }
}

