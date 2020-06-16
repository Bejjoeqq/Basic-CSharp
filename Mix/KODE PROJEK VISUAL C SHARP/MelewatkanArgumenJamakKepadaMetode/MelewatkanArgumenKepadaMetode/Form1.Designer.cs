namespace MelewatkanArgumenKepadaMetode
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
            this.tombolDemo1 = new System.Windows.Forms.Button();
            this.tombolDemo2 = new System.Windows.Forms.Button();
            this.tombolDemo3 = new System.Windows.Forms.Button();
            this.tombolKeluar = new System.Windows.Forms.Button();
            this.kotakList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tombolDemo1
            // 
            this.tombolDemo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolDemo1.Location = new System.Drawing.Point(13, 13);
            this.tombolDemo1.Name = "tombolDemo1";
            this.tombolDemo1.Size = new System.Drawing.Size(142, 42);
            this.tombolDemo1.TabIndex = 0;
            this.tombolDemo1.Text = "Demo 1";
            this.tombolDemo1.UseVisualStyleBackColor = true;
            this.tombolDemo1.Click += new System.EventHandler(this.tombolDemo1_Click);
            // 
            // tombolDemo2
            // 
            this.tombolDemo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolDemo2.Location = new System.Drawing.Point(13, 79);
            this.tombolDemo2.Name = "tombolDemo2";
            this.tombolDemo2.Size = new System.Drawing.Size(142, 42);
            this.tombolDemo2.TabIndex = 1;
            this.tombolDemo2.Text = "Demo 2";
            this.tombolDemo2.UseVisualStyleBackColor = true;
            this.tombolDemo2.Click += new System.EventHandler(this.tombolDemo2_Click);
            // 
            // tombolDemo3
            // 
            this.tombolDemo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolDemo3.Location = new System.Drawing.Point(13, 153);
            this.tombolDemo3.Name = "tombolDemo3";
            this.tombolDemo3.Size = new System.Drawing.Size(142, 42);
            this.tombolDemo3.TabIndex = 2;
            this.tombolDemo3.Text = "Demo 3";
            this.tombolDemo3.UseVisualStyleBackColor = true;
            this.tombolDemo3.Click += new System.EventHandler(this.tombolDemo3_Click);
            // 
            // tombolKeluar
            // 
            this.tombolKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolKeluar.Location = new System.Drawing.Point(12, 231);
            this.tombolKeluar.Name = "tombolKeluar";
            this.tombolKeluar.Size = new System.Drawing.Size(142, 42);
            this.tombolKeluar.TabIndex = 3;
            this.tombolKeluar.Text = "Keluar";
            this.tombolKeluar.UseVisualStyleBackColor = true;
            this.tombolKeluar.Click += new System.EventHandler(this.tombolKeluar_Click);
            // 
            // kotakList
            // 
            this.kotakList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kotakList.FormattingEnabled = true;
            this.kotakList.ItemHeight = 20;
            this.kotakList.Location = new System.Drawing.Point(193, 13);
            this.kotakList.Name = "kotakList";
            this.kotakList.ScrollAlwaysVisible = true;
            this.kotakList.Size = new System.Drawing.Size(285, 264);
            this.kotakList.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 293);
            this.Controls.Add(this.kotakList);
            this.Controls.Add(this.tombolKeluar);
            this.Controls.Add(this.tombolDemo3);
            this.Controls.Add(this.tombolDemo2);
            this.Controls.Add(this.tombolDemo1);
            this.Name = "Form1";
            this.Text = "Pelewatan Argumen Kepada Metode";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tombolDemo1;
        private System.Windows.Forms.Button tombolDemo2;
        private System.Windows.Forms.Button tombolDemo3;
        private System.Windows.Forms.Button tombolKeluar;
        private System.Windows.Forms.ListBox kotakList;
    }
}

