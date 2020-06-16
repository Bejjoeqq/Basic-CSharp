namespace KonversiSuhu
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
            this.teksSuhu = new System.Windows.Forms.TextBox();
            this.tombolKonversi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tombolRadio1 = new System.Windows.Forms.RadioButton();
            this.tombolRadio2 = new System.Windows.Forms.RadioButton();
            this.teksHasil = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // teksSuhu
            // 
            this.teksSuhu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksSuhu.Location = new System.Drawing.Point(13, 27);
            this.teksSuhu.Name = "teksSuhu";
            this.teksSuhu.Size = new System.Drawing.Size(150, 29);
            this.teksSuhu.TabIndex = 0;
            // 
            // tombolKonversi
            // 
            this.tombolKonversi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolKonversi.Location = new System.Drawing.Point(170, 27);
            this.tombolKonversi.Name = "tombolKonversi";
            this.tombolKonversi.Size = new System.Drawing.Size(165, 29);
            this.tombolKonversi.TabIndex = 1;
            this.tombolKonversi.Text = "Konversi";
            this.tombolKonversi.UseVisualStyleBackColor = true;
            this.tombolKonversi.Click += new System.EventHandler(this.tombolKonversi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tombolRadio2);
            this.groupBox1.Controls.Add(this.tombolRadio1);
            this.groupBox1.Location = new System.Drawing.Point(13, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 86);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pilih";
            // 
            // tombolRadio1
            // 
            this.tombolRadio1.AutoSize = true;
            this.tombolRadio1.Location = new System.Drawing.Point(7, 20);
            this.tombolRadio1.Name = "tombolRadio1";
            this.tombolRadio1.Size = new System.Drawing.Size(128, 17);
            this.tombolRadio1.TabIndex = 0;
            this.tombolRadio1.TabStop = true;
            this.tombolRadio1.Text = "Fahrenheit Ke Celcius";
            this.tombolRadio1.UseVisualStyleBackColor = true;
            // 
            // tombolRadio2
            // 
            this.tombolRadio2.AutoSize = true;
            this.tombolRadio2.Location = new System.Drawing.Point(6, 52);
            this.tombolRadio2.Name = "tombolRadio2";
            this.tombolRadio2.Size = new System.Drawing.Size(128, 17);
            this.tombolRadio2.TabIndex = 1;
            this.tombolRadio2.TabStop = true;
            this.tombolRadio2.Text = "Celcius Ke Fahrenheit";
            this.tombolRadio2.UseVisualStyleBackColor = true;
            // 
            // teksHasil
            // 
            this.teksHasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksHasil.Location = new System.Drawing.Point(170, 85);
            this.teksHasil.Multiline = true;
            this.teksHasil.Name = "teksHasil";
            this.teksHasil.Size = new System.Drawing.Size(165, 75);
            this.teksHasil.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 189);
            this.Controls.Add(this.teksHasil);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tombolKonversi);
            this.Controls.Add(this.teksSuhu);
            this.Name = "Form1";
            this.Text = "Konversi Suhu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox teksSuhu;
        private System.Windows.Forms.Button tombolKonversi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton tombolRadio2;
        private System.Windows.Forms.RadioButton tombolRadio1;
        private System.Windows.Forms.TextBox teksHasil;
    }
}

