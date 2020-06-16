namespace MenulisDataKeFile
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
            this.tombolCiptakan = new System.Windows.Forms.Button();
            this.tombolKeluar = new System.Windows.Forms.Button();
            this.tombolTempel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tombolCiptakan
            // 
            this.tombolCiptakan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolCiptakan.Location = new System.Drawing.Point(12, 27);
            this.tombolCiptakan.Name = "tombolCiptakan";
            this.tombolCiptakan.Size = new System.Drawing.Size(184, 49);
            this.tombolCiptakan.TabIndex = 0;
            this.tombolCiptakan.Text = "Ciptakan File";
            this.tombolCiptakan.UseVisualStyleBackColor = true;
            this.tombolCiptakan.Click += new System.EventHandler(this.tombolCiptakan_Click);
            // 
            // tombolKeluar
            // 
            this.tombolKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolKeluar.Location = new System.Drawing.Point(449, 27);
            this.tombolKeluar.Name = "tombolKeluar";
            this.tombolKeluar.Size = new System.Drawing.Size(118, 49);
            this.tombolKeluar.TabIndex = 1;
            this.tombolKeluar.Text = "Keluar";
            this.tombolKeluar.UseVisualStyleBackColor = true;
            this.tombolKeluar.Click += new System.EventHandler(this.tombolKeluar_Click);
            // 
            // tombolTempel
            // 
            this.tombolTempel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolTempel.Location = new System.Drawing.Point(229, 27);
            this.tombolTempel.Name = "tombolTempel";
            this.tombolTempel.Size = new System.Drawing.Size(184, 49);
            this.tombolTempel.TabIndex = 2;
            this.tombolTempel.Text = "Tempelkan Data";
            this.tombolTempel.UseVisualStyleBackColor = true;
            this.tombolTempel.Click += new System.EventHandler(this.tombolTempel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 111);
            this.Controls.Add(this.tombolTempel);
            this.Controls.Add(this.tombolKeluar);
            this.Controls.Add(this.tombolCiptakan);
            this.Name = "Form1";
            this.Text = "Menempelkan Data Di Dalam File";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tombolCiptakan;
        private System.Windows.Forms.Button tombolKeluar;
        private System.Windows.Forms.Button tombolTempel;
    }
}

