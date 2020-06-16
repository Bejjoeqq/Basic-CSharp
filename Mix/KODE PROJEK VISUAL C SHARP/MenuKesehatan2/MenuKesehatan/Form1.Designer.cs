namespace MenuKesehatan
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
            this.checkObat = new System.Windows.Forms.CheckBox();
            this.checkGigi = new System.Windows.Forms.CheckBox();
            this.checkMata = new System.Windows.Forms.CheckBox();
            this.checkKesehatan = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.teksTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkObat
            // 
            this.checkObat.AutoSize = true;
            this.checkObat.Location = new System.Drawing.Point(12, 12);
            this.checkObat.Name = "checkObat";
            this.checkObat.Size = new System.Drawing.Size(203, 17);
            this.checkObat.TabIndex = 0;
            this.checkObat.Text = "Pembelian obat-obatan (Rp. 350.000)";
            this.checkObat.UseVisualStyleBackColor = true;
            this.checkObat.CheckedChanged += new System.EventHandler(this.checkObat_CheckedChanged);
            // 
            // checkGigi
            // 
            this.checkGigi.AutoSize = true;
            this.checkGigi.Location = new System.Drawing.Point(12, 35);
            this.checkGigi.Name = "checkGigi";
            this.checkGigi.Size = new System.Drawing.Size(174, 17);
            this.checkGigi.TabIndex = 1;
            this.checkGigi.Text = "Pemeriksaan gigi (Rp. 550.000)";
            this.checkGigi.UseVisualStyleBackColor = true;
            this.checkGigi.CheckedChanged += new System.EventHandler(this.checkGigi_CheckedChanged);
            // 
            // checkMata
            // 
            this.checkMata.AutoSize = true;
            this.checkMata.Location = new System.Drawing.Point(12, 58);
            this.checkMata.Name = "checkMata";
            this.checkMata.Size = new System.Drawing.Size(181, 17);
            this.checkMata.TabIndex = 2;
            this.checkMata.Text = "Pemeriksaan mata (Rp. 750.000)";
            this.checkMata.UseVisualStyleBackColor = true;
            this.checkMata.CheckedChanged += new System.EventHandler(this.checkMata_CheckedChanged);
            // 
            // checkKesehatan
            // 
            this.checkKesehatan.AutoSize = true;
            this.checkKesehatan.Location = new System.Drawing.Point(12, 81);
            this.checkKesehatan.Name = "checkKesehatan";
            this.checkKesehatan.Size = new System.Drawing.Size(217, 17);
            this.checkKesehatan.TabIndex = 3;
            this.checkKesehatan.Text = "Pemeriksaan kesehatan (Rp. 1.550.000)";
            this.checkKesehatan.UseVisualStyleBackColor = true;
            this.checkKesehatan.CheckedChanged += new System.EventHandler(this.checkKesehatan_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total biaya bulanan:";
            // 
            // teksTotal
            // 
            this.teksTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksTotal.Location = new System.Drawing.Point(12, 137);
            this.teksTotal.Name = "teksTotal";
            this.teksTotal.ReadOnly = true;
            this.teksTotal.Size = new System.Drawing.Size(217, 26);
            this.teksTotal.TabIndex = 6;
            this.teksTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 190);
            this.Controls.Add(this.teksTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkKesehatan);
            this.Controls.Add(this.checkMata);
            this.Controls.Add(this.checkGigi);
            this.Controls.Add(this.checkObat);
            this.Name = "Form1";
            this.Text = "Menu Kesehatan 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkObat;
        private System.Windows.Forms.CheckBox checkGigi;
        private System.Windows.Forms.CheckBox checkMata;
        private System.Windows.Forms.CheckBox checkKesehatan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teksTotal;
    }
}

