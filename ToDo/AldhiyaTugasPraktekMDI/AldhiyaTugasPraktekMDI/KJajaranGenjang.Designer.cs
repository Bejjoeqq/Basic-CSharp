﻿namespace AldhiyaTugasPraktekMDI
{
    partial class KJajaranGenjang
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
            this.txth1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txts2 = new System.Windows.Forms.TextBox();
            this.txts1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txth1
            // 
            this.txth1.Location = new System.Drawing.Point(110, 192);
            this.txth1.Name = "txth1";
            this.txth1.Size = new System.Drawing.Size(100, 22);
            this.txth1.TabIndex = 17;
            this.txth1.TextChanged += new System.EventHandler(this.txth1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Hasil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Sisi 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sisi 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txts2
            // 
            this.txts2.Location = new System.Drawing.Point(110, 94);
            this.txts2.Name = "txts2";
            this.txts2.Size = new System.Drawing.Size(100, 22);
            this.txts2.TabIndex = 13;
            this.txts2.TextChanged += new System.EventHandler(this.txts2_TextChanged);
            // 
            // txts1
            // 
            this.txts1.Location = new System.Drawing.Point(110, 42);
            this.txts1.Name = "txts1";
            this.txts1.Size = new System.Drawing.Size(100, 22);
            this.txts1.TabIndex = 12;
            this.txts1.TextChanged += new System.EventHandler(this.txts1_TextChanged);
            // 
            // KJajaranGenjang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.txth1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txts2);
            this.Controls.Add(this.txts1);
            this.Name = "KJajaranGenjang";
            this.Text = "KJajaranGenjang";
            this.Load += new System.EventHandler(this.KJajaranGenjang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txth1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txts2;
        private System.Windows.Forms.TextBox txts1;
    }
}