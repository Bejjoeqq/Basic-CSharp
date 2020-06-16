namespace KalkulatorComboBox
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
            this.teks1 = new System.Windows.Forms.TextBox();
            this.teks2 = new System.Windows.Forms.TextBox();
            this.kotakKombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.teksHasil = new System.Windows.Forms.TextBox();
            this.tombolHitung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teks1
            // 
            this.teks1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teks1.Location = new System.Drawing.Point(13, 23);
            this.teks1.Name = "teks1";
            this.teks1.Size = new System.Drawing.Size(124, 31);
            this.teks1.TabIndex = 0;
            // 
            // teks2
            // 
            this.teks2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teks2.Location = new System.Drawing.Point(249, 23);
            this.teks2.Name = "teks2";
            this.teks2.Size = new System.Drawing.Size(124, 31);
            this.teks2.TabIndex = 1;
            // 
            // kotakKombo
            // 
            this.kotakKombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kotakKombo.FormattingEnabled = true;
            this.kotakKombo.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.kotakKombo.Location = new System.Drawing.Point(156, 23);
            this.kotakKombo.Name = "kotakKombo";
            this.kotakKombo.Size = new System.Drawing.Size(66, 32);
            this.kotakKombo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // teksHasil
            // 
            this.teksHasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksHasil.Location = new System.Drawing.Point(448, 22);
            this.teksHasil.Name = "teksHasil";
            this.teksHasil.ReadOnly = true;
            this.teksHasil.Size = new System.Drawing.Size(206, 31);
            this.teksHasil.TabIndex = 4;
            // 
            // tombolHitung
            // 
            this.tombolHitung.Location = new System.Drawing.Point(670, 22);
            this.tombolHitung.Name = "tombolHitung";
            this.tombolHitung.Size = new System.Drawing.Size(117, 31);
            this.tombolHitung.TabIndex = 5;
            this.tombolHitung.Text = "Hitung";
            this.tombolHitung.UseVisualStyleBackColor = true;
            this.tombolHitung.Click += new System.EventHandler(this.tombolHitung_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 101);
            this.Controls.Add(this.tombolHitung);
            this.Controls.Add(this.teksHasil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kotakKombo);
            this.Controls.Add(this.teks2);
            this.Controls.Add(this.teks1);
            this.Name = "Form1";
            this.Text = "Kalkulator Dengan ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox teks1;
        private System.Windows.Forms.TextBox teks2;
        private System.Windows.Forms.ComboBox kotakKombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teksHasil;
        private System.Windows.Forms.Button tombolHitung;
    }
}

