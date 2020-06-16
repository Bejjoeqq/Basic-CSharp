namespace TahunLeapLoopDoWhile
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
            this.tombolPeriksa = new System.Windows.Forms.Button();
            this.teksTahun = new System.Windows.Forms.TextBox();
            this.kotakList = new System.Windows.Forms.ListBox();
            this.tombolBersih = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tombolPeriksa
            // 
            this.tombolPeriksa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolPeriksa.Location = new System.Drawing.Point(13, 13);
            this.tombolPeriksa.Name = "tombolPeriksa";
            this.tombolPeriksa.Size = new System.Drawing.Size(168, 41);
            this.tombolPeriksa.TabIndex = 0;
            this.tombolPeriksa.Text = "Periksa Tahun";
            this.tombolPeriksa.UseVisualStyleBackColor = true;
            this.tombolPeriksa.Click += new System.EventHandler(this.tombolPeriksa_Click);
            // 
            // teksTahun
            // 
            this.teksTahun.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksTahun.Location = new System.Drawing.Point(207, 13);
            this.teksTahun.Name = "teksTahun";
            this.teksTahun.Size = new System.Drawing.Size(166, 40);
            this.teksTahun.TabIndex = 1;
            // 
            // kotakList
            // 
            this.kotakList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kotakList.FormattingEnabled = true;
            this.kotakList.ItemHeight = 24;
            this.kotakList.Location = new System.Drawing.Point(13, 73);
            this.kotakList.Name = "kotakList";
            this.kotakList.ScrollAlwaysVisible = true;
            this.kotakList.Size = new System.Drawing.Size(360, 172);
            this.kotakList.TabIndex = 2;
            // 
            // tombolBersih
            // 
            this.tombolBersih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolBersih.Location = new System.Drawing.Point(13, 261);
            this.tombolBersih.Name = "tombolBersih";
            this.tombolBersih.Size = new System.Drawing.Size(360, 41);
            this.tombolBersih.TabIndex = 3;
            this.tombolBersih.Text = "Bersihkan";
            this.tombolBersih.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 314);
            this.Controls.Add(this.tombolBersih);
            this.Controls.Add(this.kotakList);
            this.Controls.Add(this.teksTahun);
            this.Controls.Add(this.tombolPeriksa);
            this.Name = "Form1";
            this.Text = "Menentukan Tahun Leap Dengan Loop Do While";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tombolPeriksa;
        private System.Windows.Forms.TextBox teksTahun;
        private System.Windows.Forms.ListBox kotakList;
        private System.Windows.Forms.Button tombolBersih;
    }
}

