namespace Aldhiya5c
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
            this.txtNilai1 = new System.Windows.Forms.TextBox();
            this.txtNilai2 = new System.Windows.Forms.TextBox();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lstOperator = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nilai Ke-1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nilai Ke-2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hasil Perhitungan";
            // 
            // txtNilai1
            // 
            this.txtNilai1.Location = new System.Drawing.Point(270, 78);
            this.txtNilai1.Name = "txtNilai1";
            this.txtNilai1.Size = new System.Drawing.Size(100, 22);
            this.txtNilai1.TabIndex = 4;
            this.txtNilai1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNilai2
            // 
            this.txtNilai2.Location = new System.Drawing.Point(270, 245);
            this.txtNilai2.Name = "txtNilai2";
            this.txtNilai2.Size = new System.Drawing.Size(100, 22);
            this.txtNilai2.TabIndex = 5;
            this.txtNilai2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtHasil
            // 
            this.txtHasil.Enabled = false;
            this.txtHasil.Location = new System.Drawing.Point(270, 297);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(100, 22);
            this.txtHasil.TabIndex = 6;
            this.txtHasil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(12, 352);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(75, 23);
            this.btnHitung.TabIndex = 7;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(158, 352);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(295, 352);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lstOperator
            // 
            this.lstOperator.FormattingEnabled = true;
            this.lstOperator.ItemHeight = 16;
            this.lstOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "Mod"});
            this.lstOperator.Location = new System.Drawing.Point(270, 131);
            this.lstOperator.Name = "lstOperator";
            this.lstOperator.Size = new System.Drawing.Size(100, 84);
            this.lstOperator.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(348, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "PROGRAM PENGGUNAAN OPERATOR ARITMATIKA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 424);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lstOperator);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.txtNilai2);
            this.Controls.Add(this.txtNilai1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Operator Aritmatika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNilai1;
        private System.Windows.Forms.TextBox txtNilai2;
        private System.Windows.Forms.TextBox txtHasil;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lstOperator;
        private System.Windows.Forms.Label label5;
    }
}

