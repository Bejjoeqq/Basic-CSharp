namespace LampuONOFF
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
            this.statusLampu = new System.Windows.Forms.TextBox();
            this.tombolSaklar = new System.Windows.Forms.Button();
            this.tombolKeluar = new System.Windows.Forms.Button();
            this.PBLampuOFF = new System.Windows.Forms.PictureBox();
            this.PBLampuON = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBLampuOFF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBLampuON)).BeginInit();
            this.SuspendLayout();
            // 
            // statusLampu
            // 
            this.statusLampu.BackColor = System.Drawing.Color.LightGray;
            this.statusLampu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLampu.Location = new System.Drawing.Point(158, 228);
            this.statusLampu.Name = "statusLampu";
            this.statusLampu.Size = new System.Drawing.Size(100, 29);
            this.statusLampu.TabIndex = 2;
            // 
            // tombolSaklar
            // 
            this.tombolSaklar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolSaklar.Location = new System.Drawing.Point(12, 276);
            this.tombolSaklar.Name = "tombolSaklar";
            this.tombolSaklar.Size = new System.Drawing.Size(191, 42);
            this.tombolSaklar.TabIndex = 3;
            this.tombolSaklar.Text = "Saklar Lampu";
            this.tombolSaklar.UseVisualStyleBackColor = true;
            this.tombolSaklar.Click += new System.EventHandler(this.tombolSaklar_Click);
            // 
            // tombolKeluar
            // 
            this.tombolKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolKeluar.Location = new System.Drawing.Point(211, 276);
            this.tombolKeluar.Name = "tombolKeluar";
            this.tombolKeluar.Size = new System.Drawing.Size(198, 42);
            this.tombolKeluar.TabIndex = 4;
            this.tombolKeluar.Text = "Keluar";
            this.tombolKeluar.UseVisualStyleBackColor = true;
            this.tombolKeluar.Click += new System.EventHandler(this.tombolKeluar_Click);
            // 
            // PBLampuOFF
            // 
            this.PBLampuOFF.Image = global::LampuONOFF.Resource1.lampOFF;
            this.PBLampuOFF.Location = new System.Drawing.Point(211, 13);
            this.PBLampuOFF.Name = "PBLampuOFF";
            this.PBLampuOFF.Size = new System.Drawing.Size(198, 209);
            this.PBLampuOFF.TabIndex = 1;
            this.PBLampuOFF.TabStop = false;
            // 
            // PBLampuON
            // 
            this.PBLampuON.Image = global::LampuONOFF.Resource1.lampON;
            this.PBLampuON.Location = new System.Drawing.Point(13, 13);
            this.PBLampuON.Name = "PBLampuON";
            this.PBLampuON.Size = new System.Drawing.Size(191, 209);
            this.PBLampuON.TabIndex = 0;
            this.PBLampuON.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 330);
            this.Controls.Add(this.tombolKeluar);
            this.Controls.Add(this.tombolSaklar);
            this.Controls.Add(this.statusLampu);
            this.Controls.Add(this.PBLampuOFF);
            this.Controls.Add(this.PBLampuON);
            this.Name = "Form1";
            this.Text = "Lampu ON OFF";
            ((System.ComponentModel.ISupportInitialize)(this.PBLampuOFF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBLampuON)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBLampuON;
        private System.Windows.Forms.PictureBox PBLampuOFF;
        private System.Windows.Forms.TextBox statusLampu;
        private System.Windows.Forms.Button tombolSaklar;
        private System.Windows.Forms.Button tombolKeluar;
    }
}

