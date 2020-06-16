namespace MenggunakanSwitch
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
            this.tombolHitung = new System.Windows.Forms.Button();
            this.teksNilai = new System.Windows.Forms.TextBox();
            this.kotakList = new System.Windows.Forms.ListBox();
            this.tombolSwitch = new System.Windows.Forms.Button();
            this.teksCase = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tombolHitung
            // 
            this.tombolHitung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolHitung.Location = new System.Drawing.Point(13, 27);
            this.tombolHitung.Name = "tombolHitung";
            this.tombolHitung.Size = new System.Drawing.Size(145, 48);
            this.tombolHitung.TabIndex = 0;
            this.tombolHitung.Text = "Hitung";
            this.tombolHitung.UseVisualStyleBackColor = true;
            this.tombolHitung.Click += new System.EventHandler(this.tombolHitung_Click);
            // 
            // teksNilai
            // 
            this.teksNilai.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.teksNilai.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksNilai.Location = new System.Drawing.Point(186, 27);
            this.teksNilai.Name = "teksNilai";
            this.teksNilai.Size = new System.Drawing.Size(193, 49);
            this.teksNilai.TabIndex = 1;
            // 
            // kotakList
            // 
            this.kotakList.BackColor = System.Drawing.Color.PaleTurquoise;
            this.kotakList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kotakList.FormattingEnabled = true;
            this.kotakList.ItemHeight = 24;
            this.kotakList.Location = new System.Drawing.Point(13, 99);
            this.kotakList.Name = "kotakList";
            this.kotakList.ScrollAlwaysVisible = true;
            this.kotakList.Size = new System.Drawing.Size(366, 124);
            this.kotakList.TabIndex = 2;
            // 
            // tombolSwitch
            // 
            this.tombolSwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolSwitch.Location = new System.Drawing.Point(13, 245);
            this.tombolSwitch.Name = "tombolSwitch";
            this.tombolSwitch.Size = new System.Drawing.Size(145, 67);
            this.tombolSwitch.TabIndex = 3;
            this.tombolSwitch.Text = "Gunakan Switch";
            this.tombolSwitch.UseVisualStyleBackColor = true;
            this.tombolSwitch.Click += new System.EventHandler(this.tombolSwitch_Click);
            // 
            // teksCase
            // 
            this.teksCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksCase.Location = new System.Drawing.Point(186, 253);
            this.teksCase.Name = "teksCase";
            this.teksCase.ReadOnly = true;
            this.teksCase.Size = new System.Drawing.Size(193, 44);
            this.teksCase.TabIndex = 4;
            this.teksCase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 324);
            this.Controls.Add(this.teksCase);
            this.Controls.Add(this.tombolSwitch);
            this.Controls.Add(this.kotakList);
            this.Controls.Add(this.teksNilai);
            this.Controls.Add(this.tombolHitung);
            this.Name = "Form1";
            this.Text = "Menggunakan Blok Switch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tombolHitung;
        private System.Windows.Forms.TextBox teksNilai;
        private System.Windows.Forms.ListBox kotakList;
        private System.Windows.Forms.Button tombolSwitch;
        private System.Windows.Forms.TextBox teksCase;
    }
}

