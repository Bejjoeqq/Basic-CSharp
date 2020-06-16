namespace PembelianKomputer
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
            this.radDeluxe = new System.Windows.Forms.RadioButton();
            this.radSuper = new System.Windows.Forms.RadioButton();
            this.checkVideo = new System.Windows.Forms.CheckBox();
            this.checkModem = new System.Windows.Forms.CheckBox();
            this.checkMemori = new System.Windows.Forms.CheckBox();
            this.tombolHitung = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.teksBiayaTotal = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radSuper);
            this.groupBox1.Controls.Add(this.radDeluxe);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 63);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Model";
            // 
            // radDeluxe
            // 
            this.radDeluxe.AutoSize = true;
            this.radDeluxe.Location = new System.Drawing.Point(6, 23);
            this.radDeluxe.Name = "radDeluxe";
            this.radDeluxe.Size = new System.Drawing.Size(58, 17);
            this.radDeluxe.TabIndex = 0;
            this.radDeluxe.TabStop = true;
            this.radDeluxe.Text = "Deluxe";
            this.radDeluxe.UseVisualStyleBackColor = true;
            // 
            // radSuper
            // 
            this.radSuper.AutoSize = true;
            this.radSuper.Location = new System.Drawing.Point(156, 23);
            this.radSuper.Name = "radSuper";
            this.radSuper.Size = new System.Drawing.Size(53, 17);
            this.radSuper.TabIndex = 1;
            this.radSuper.TabStop = true;
            this.radSuper.Text = "Super";
            this.radSuper.UseVisualStyleBackColor = true;
            // 
            // checkVideo
            // 
            this.checkVideo.AutoSize = true;
            this.checkVideo.Location = new System.Drawing.Point(13, 89);
            this.checkVideo.Name = "checkVideo";
            this.checkVideo.Size = new System.Drawing.Size(81, 17);
            this.checkVideo.TabIndex = 1;
            this.checkVideo.Text = "Kartu Video";
            this.checkVideo.UseVisualStyleBackColor = true;
            // 
            // checkModem
            // 
            this.checkModem.AutoSize = true;
            this.checkModem.Location = new System.Drawing.Point(12, 112);
            this.checkModem.Name = "checkModem";
            this.checkModem.Size = new System.Drawing.Size(132, 17);
            this.checkModem.TabIndex = 2;
            this.checkModem.Text = "Modem Internal + WiFi";
            this.checkModem.UseVisualStyleBackColor = true;
            // 
            // checkMemori
            // 
            this.checkMemori.AutoSize = true;
            this.checkMemori.Location = new System.Drawing.Point(12, 135);
            this.checkMemori.Name = "checkMemori";
            this.checkMemori.Size = new System.Drawing.Size(131, 17);
            this.checkMemori.TabIndex = 3;
            this.checkMemori.Text = "Memori Eksternal 1GB";
            this.checkMemori.UseVisualStyleBackColor = true;
            // 
            // tombolHitung
            // 
            this.tombolHitung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolHitung.Location = new System.Drawing.Point(12, 172);
            this.tombolHitung.Name = "tombolHitung";
            this.tombolHitung.Size = new System.Drawing.Size(216, 51);
            this.tombolHitung.TabIndex = 4;
            this.tombolHitung.Text = "Hitung Total Biaya";
            this.tombolHitung.UseVisualStyleBackColor = true;
            this.tombolHitung.Click += new System.EventHandler(this.tombolHitung_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Biaya:";
            // 
            // teksBiayaTotal
            // 
            this.teksBiayaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksBiayaTotal.Location = new System.Drawing.Point(15, 276);
            this.teksBiayaTotal.Name = "teksBiayaTotal";
            this.teksBiayaTotal.ReadOnly = true;
            this.teksBiayaTotal.Size = new System.Drawing.Size(213, 26);
            this.teksBiayaTotal.TabIndex = 6;
            this.teksBiayaTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 323);
            this.Controls.Add(this.teksBiayaTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tombolHitung);
            this.Controls.Add(this.checkMemori);
            this.Controls.Add(this.checkModem);
            this.Controls.Add(this.checkVideo);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Pembelian Komputer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radSuper;
        private System.Windows.Forms.RadioButton radDeluxe;
        private System.Windows.Forms.CheckBox checkVideo;
        private System.Windows.Forms.CheckBox checkModem;
        private System.Windows.Forms.CheckBox checkMemori;
        private System.Windows.Forms.Button tombolHitung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teksBiayaTotal;
    }
}

