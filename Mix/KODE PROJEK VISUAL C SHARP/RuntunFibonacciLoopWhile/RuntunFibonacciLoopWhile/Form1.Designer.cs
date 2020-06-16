namespace RuntunFibonacciLoopWhile
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
            this.tombolJalankan = new System.Windows.Forms.Button();
            this.teksAngka = new System.Windows.Forms.TextBox();
            this.kotakList = new System.Windows.Forms.ListBox();
            this.tombolBersih = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tombolJalankan
            // 
            this.tombolJalankan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolJalankan.Location = new System.Drawing.Point(13, 13);
            this.tombolJalankan.Name = "tombolJalankan";
            this.tombolJalankan.Size = new System.Drawing.Size(140, 50);
            this.tombolJalankan.TabIndex = 0;
            this.tombolJalankan.Text = "Jalankan";
            this.tombolJalankan.UseVisualStyleBackColor = true;
            this.tombolJalankan.Click += new System.EventHandler(this.tombolJalankan_Click);
            // 
            // teksAngka
            // 
            this.teksAngka.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksAngka.Location = new System.Drawing.Point(183, 16);
            this.teksAngka.Name = "teksAngka";
            this.teksAngka.Size = new System.Drawing.Size(143, 44);
            this.teksAngka.TabIndex = 1;
            // 
            // kotakList
            // 
            this.kotakList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kotakList.FormattingEnabled = true;
            this.kotakList.ItemHeight = 24;
            this.kotakList.Location = new System.Drawing.Point(13, 80);
            this.kotakList.Name = "kotakList";
            this.kotakList.ScrollAlwaysVisible = true;
            this.kotakList.Size = new System.Drawing.Size(313, 172);
            this.kotakList.TabIndex = 2;
            // 
            // tombolBersih
            // 
            this.tombolBersih.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolBersih.Location = new System.Drawing.Point(13, 259);
            this.tombolBersih.Name = "tombolBersih";
            this.tombolBersih.Size = new System.Drawing.Size(313, 50);
            this.tombolBersih.TabIndex = 3;
            this.tombolBersih.Text = "Bersihkan";
            this.tombolBersih.UseVisualStyleBackColor = true;
            this.tombolBersih.Click += new System.EventHandler(this.tombolBersih_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 321);
            this.Controls.Add(this.tombolBersih);
            this.Controls.Add(this.kotakList);
            this.Controls.Add(this.teksAngka);
            this.Controls.Add(this.tombolJalankan);
            this.Name = "Form1";
            this.Text = "Runtun Fibonacci Loop While";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tombolJalankan;
        private System.Windows.Forms.TextBox teksAngka;
        private System.Windows.Forms.ListBox kotakList;
        private System.Windows.Forms.Button tombolBersih;
    }
}

