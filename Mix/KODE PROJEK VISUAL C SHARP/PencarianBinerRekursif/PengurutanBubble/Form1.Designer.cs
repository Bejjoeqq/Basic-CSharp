namespace PengurutanBubble
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
            this.tombolBinerRekursif = new System.Windows.Forms.Button();
            this.kotakList = new System.Windows.Forms.ListBox();
            this.tombolBersih = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tombolBinerRekursif
            // 
            this.tombolBinerRekursif.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolBinerRekursif.Location = new System.Drawing.Point(13, 13);
            this.tombolBinerRekursif.Name = "tombolBinerRekursif";
            this.tombolBinerRekursif.Size = new System.Drawing.Size(658, 42);
            this.tombolBinerRekursif.TabIndex = 0;
            this.tombolBinerRekursif.Text = "Pencarian Biner Rekursif";
            this.tombolBinerRekursif.UseVisualStyleBackColor = true;
            this.tombolBinerRekursif.Click += new System.EventHandler(this.tombolBinerRekursif_Click);
            // 
            // kotakList
            // 
            this.kotakList.FormattingEnabled = true;
            this.kotakList.Location = new System.Drawing.Point(13, 73);
            this.kotakList.Name = "kotakList";
            this.kotakList.ScrollAlwaysVisible = true;
            this.kotakList.Size = new System.Drawing.Size(658, 355);
            this.kotakList.TabIndex = 1;
            // 
            // tombolBersih
            // 
            this.tombolBersih.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolBersih.Location = new System.Drawing.Point(13, 443);
            this.tombolBersih.Name = "tombolBersih";
            this.tombolBersih.Size = new System.Drawing.Size(658, 42);
            this.tombolBersih.TabIndex = 2;
            this.tombolBersih.Text = "Bersihkan";
            this.tombolBersih.UseVisualStyleBackColor = true;
            this.tombolBersih.Click += new System.EventHandler(this.tombolBersih_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 497);
            this.Controls.Add(this.tombolBersih);
            this.Controls.Add(this.kotakList);
            this.Controls.Add(this.tombolBinerRekursif);
            this.Name = "Form1";
            this.Text = "Pencarian Biner Rekursif";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tombolBinerRekursif;
        private System.Windows.Forms.ListBox kotakList;
        private System.Windows.Forms.Button tombolBersih;
    }
}

