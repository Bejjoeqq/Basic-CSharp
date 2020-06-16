namespace StatemenIf1
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
            this.SuspendLayout();
            // 
            // tombolHitung
            // 
            this.tombolHitung.Location = new System.Drawing.Point(13, 12);
            this.tombolHitung.Name = "tombolHitung";
            this.tombolHitung.Size = new System.Drawing.Size(117, 40);
            this.tombolHitung.TabIndex = 0;
            this.tombolHitung.Text = "Hitung";
            this.tombolHitung.UseVisualStyleBackColor = true;
            this.tombolHitung.Click += new System.EventHandler(this.tombolHitung_Click);
            // 
            // teksNilai
            // 
            this.teksNilai.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksNilai.Location = new System.Drawing.Point(148, 12);
            this.teksNilai.Multiline = true;
            this.teksNilai.Name = "teksNilai";
            this.teksNilai.Size = new System.Drawing.Size(151, 40);
            this.teksNilai.TabIndex = 1;
            // 
            // kotakList
            // 
            this.kotakList.BackColor = System.Drawing.Color.SandyBrown;
            this.kotakList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kotakList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kotakList.FormattingEnabled = true;
            this.kotakList.ItemHeight = 25;
            this.kotakList.Location = new System.Drawing.Point(13, 76);
            this.kotakList.Name = "kotakList";
            this.kotakList.Size = new System.Drawing.Size(286, 150);
            this.kotakList.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 262);
            this.Controls.Add(this.kotakList);
            this.Controls.Add(this.teksNilai);
            this.Controls.Add(this.tombolHitung);
            this.Name = "Form1";
            this.Text = "Contoh Statemen If";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tombolHitung;
        private System.Windows.Forms.TextBox teksNilai;
        private System.Windows.Forms.ListBox kotakList;
    }
}

