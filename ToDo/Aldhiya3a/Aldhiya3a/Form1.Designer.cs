namespace Aldhiya3a
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.TxtNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTampil = new System.Windows.Forms.Label();
            this.btnProses = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROGRAM MEMASUKAN NAMA";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // TxtNama
            // 
            this.TxtNama.Location = new System.Drawing.Point(165, 55);
            this.TxtNama.Name = "TxtNama";
            this.TxtNama.Size = new System.Drawing.Size(222, 22);
            this.TxtNama.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Masukkan nama anda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tampilkan nama anda";
            // 
            // lblTampil
            // 
            this.lblTampil.AutoSize = true;
            this.lblTampil.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTampil.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTampil.Location = new System.Drawing.Point(209, 132);
            this.lblTampil.Name = "lblTampil";
            this.lblTampil.Size = new System.Drawing.Size(0, 17);
            this.lblTampil.TabIndex = 4;
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(312, 180);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(75, 23);
            this.btnProses.TabIndex = 5;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(187, 180);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(65, 180);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // lblTam
            // 
            this.lblTam.AutoSize = true;
            this.lblTam.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTam.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTam.Location = new System.Drawing.Point(184, 132);
            this.lblTam.Name = "lblTam";
            this.lblTam.Size = new System.Drawing.Size(24, 17);
            this.lblTam.TabIndex = 8;
            this.lblTam.Text = "aa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 253);
            this.Controls.Add(this.lblTam);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.lblTampil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNama);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form Memasukan Nama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox TxtNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTampil;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTam;
    }
}

