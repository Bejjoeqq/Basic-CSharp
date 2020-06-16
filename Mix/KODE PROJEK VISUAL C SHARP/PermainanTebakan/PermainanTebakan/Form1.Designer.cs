namespace PermainanTebakan
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
            this.tombolPermainan = new System.Windows.Forms.Button();
            this.tombolTebak = new System.Windows.Forms.Button();
            this.teksTebakAngka = new System.Windows.Forms.TextBox();
            this.kotakListTebak = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tombolPermainan
            // 
            this.tombolPermainan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolPermainan.Location = new System.Drawing.Point(13, 13);
            this.tombolPermainan.Name = "tombolPermainan";
            this.tombolPermainan.Size = new System.Drawing.Size(198, 45);
            this.tombolPermainan.TabIndex = 0;
            this.tombolPermainan.Text = "Permainan Baru";
            this.tombolPermainan.UseVisualStyleBackColor = true;
            this.tombolPermainan.Click += new System.EventHandler(this.tombolPermainan_Click);
            // 
            // tombolTebak
            // 
            this.tombolTebak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolTebak.Location = new System.Drawing.Point(13, 64);
            this.tombolTebak.Name = "tombolTebak";
            this.tombolTebak.Size = new System.Drawing.Size(198, 40);
            this.tombolTebak.TabIndex = 1;
            this.tombolTebak.Text = "Tebak";
            this.tombolTebak.UseVisualStyleBackColor = true;
            this.tombolTebak.Click += new System.EventHandler(this.tombolTebak_Click);
            // 
            // teksTebakAngka
            // 
            this.teksTebakAngka.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksTebakAngka.Location = new System.Drawing.Point(13, 126);
            this.teksTebakAngka.Name = "teksTebakAngka";
            this.teksTebakAngka.Size = new System.Drawing.Size(198, 44);
            this.teksTebakAngka.TabIndex = 2;
            // 
            // kotakListTebak
            // 
            this.kotakListTebak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kotakListTebak.FormattingEnabled = true;
            this.kotakListTebak.ItemHeight = 20;
            this.kotakListTebak.Location = new System.Drawing.Point(235, 13);
            this.kotakListTebak.Name = "kotakListTebak";
            this.kotakListTebak.ScrollAlwaysVisible = true;
            this.kotakListTebak.Size = new System.Drawing.Size(316, 244);
            this.kotakListTebak.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 262);
            this.Controls.Add(this.kotakListTebak);
            this.Controls.Add(this.teksTebakAngka);
            this.Controls.Add(this.tombolTebak);
            this.Controls.Add(this.tombolPermainan);
            this.Name = "Form1";
            this.Text = "Permainan Tebakan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tombolPermainan;
        private System.Windows.Forms.Button tombolTebak;
        private System.Windows.Forms.TextBox teksTebakAngka;
        private System.Windows.Forms.ListBox kotakListTebak;
    }
}

