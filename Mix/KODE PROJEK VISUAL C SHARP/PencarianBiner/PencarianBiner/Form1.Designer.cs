﻿namespace PencarianBiner
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
            this.teksTarget = new System.Windows.Forms.TextBox();
            this.tombolCari = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.teksList = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masukkan Nilai Target:";
            // 
            // teksTarget
            // 
            this.teksTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksTarget.Location = new System.Drawing.Point(16, 30);
            this.teksTarget.Name = "teksTarget";
            this.teksTarget.Size = new System.Drawing.Size(114, 44);
            this.teksTarget.TabIndex = 1;
            // 
            // tombolCari
            // 
            this.tombolCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolCari.Location = new System.Drawing.Point(12, 91);
            this.tombolCari.Name = "tombolCari";
            this.tombolCari.Size = new System.Drawing.Size(114, 51);
            this.tombolCari.TabIndex = 2;
            this.tombolCari.Text = "Cari";
            this.tombolCari.UseVisualStyleBackColor = true;
            this.tombolCari.Click += new System.EventHandler(this.tombolCari_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "List:";
            // 
            // teksList
            // 
            this.teksList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksList.Location = new System.Drawing.Point(163, 30);
            this.teksList.Multiline = true;
            this.teksList.Name = "teksList";
            this.teksList.Size = new System.Drawing.Size(100, 196);
            this.teksList.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 240);
            this.Controls.Add(this.teksList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tombolCari);
            this.Controls.Add(this.teksTarget);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pencarian Biner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teksTarget;
        private System.Windows.Forms.Button tombolCari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox teksList;
    }
}

