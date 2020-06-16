namespace Aldhiya4c
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTambah = new System.Windows.Forms.TextBox();
            this.txtKurang = new System.Windows.Forms.TextBox();
            this.txtBulat = new System.Windows.Forms.TextBox();
            this.txtBagi = new System.Windows.Forms.TextBox();
            this.txtKali = new System.Windows.Forms.TextBox();
            this.btnProses = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "X + Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "X - Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "X * Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "X / Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "X % Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nilai X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nilai Y";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtY);
            this.groupBox1.Controls.Add(this.txtX);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 129);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INPUT";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(197, 86);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 22);
            this.txtY.TabIndex = 10;
            this.txtY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(197, 32);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 22);
            this.txtX.TabIndex = 11;
            this.txtX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTambah);
            this.groupBox2.Controls.Add(this.txtKurang);
            this.groupBox2.Controls.Add(this.txtBulat);
            this.groupBox2.Controls.Add(this.txtBagi);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtKali);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 199);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OUTPUT";
            // 
            // txtTambah
            // 
            this.txtTambah.Location = new System.Drawing.Point(197, 23);
            this.txtTambah.Name = "txtTambah";
            this.txtTambah.Size = new System.Drawing.Size(100, 22);
            this.txtTambah.TabIndex = 9;
            this.txtTambah.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtKurang
            // 
            this.txtKurang.Location = new System.Drawing.Point(197, 62);
            this.txtKurang.Name = "txtKurang";
            this.txtKurang.Size = new System.Drawing.Size(100, 22);
            this.txtKurang.TabIndex = 8;
            this.txtKurang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBulat
            // 
            this.txtBulat.Location = new System.Drawing.Point(197, 163);
            this.txtBulat.Name = "txtBulat";
            this.txtBulat.Size = new System.Drawing.Size(100, 22);
            this.txtBulat.TabIndex = 7;
            this.txtBulat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBagi
            // 
            this.txtBagi.Location = new System.Drawing.Point(197, 129);
            this.txtBagi.Name = "txtBagi";
            this.txtBagi.Size = new System.Drawing.Size(100, 22);
            this.txtBagi.TabIndex = 5;
            this.txtBagi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtKali
            // 
            this.txtKali.Location = new System.Drawing.Point(197, 96);
            this.txtKali.Name = "txtKali";
            this.txtKali.Size = new System.Drawing.Size(100, 22);
            this.txtKali.TabIndex = 6;
            this.txtKali.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(12, 182);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(75, 23);
            this.btnProses.TabIndex = 8;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(193, 182);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(366, 182);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 463);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "FORM ARIMATIKA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtTambah;
        private System.Windows.Forms.TextBox txtKurang;
        private System.Windows.Forms.TextBox txtBulat;
        private System.Windows.Forms.TextBox txtKali;
        private System.Windows.Forms.TextBox txtBagi;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}

