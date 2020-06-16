namespace Aldhiya4a
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPanjang = new System.Windows.Forms.TextBox();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.txtLebar = new System.Windows.Forms.TextBox();
            this.btnProses = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROGRAM MENCARI LUAS PERSEGI PANJANG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Masukkan Nilai Panjang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Masukkan Nilai Lebar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hasil Perhitungan";
            // 
            // txtPanjang
            // 
            this.txtPanjang.Location = new System.Drawing.Point(218, 107);
            this.txtPanjang.Name = "txtPanjang";
            this.txtPanjang.Size = new System.Drawing.Size(100, 22);
            this.txtPanjang.TabIndex = 4;
            this.txtPanjang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(218, 239);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(100, 22);
            this.txtHasil.TabIndex = 5;
            this.txtHasil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHasil.TextChanged += new System.EventHandler(this.txtHasil_TextChanged);
            // 
            // txtLebar
            // 
            this.txtLebar.Location = new System.Drawing.Point(218, 171);
            this.txtLebar.Name = "txtLebar";
            this.txtLebar.Size = new System.Drawing.Size(100, 22);
            this.txtLebar.TabIndex = 6;
            this.txtLebar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(41, 343);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(75, 23);
            this.btnProses.TabIndex = 7;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(191, 343);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(333, 343);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 427);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.txtLebar);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.txtPanjang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Luas persegi panjang";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPanjang;
        private System.Windows.Forms.TextBox txtHasil;
        private System.Windows.Forms.TextBox txtLebar;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}

