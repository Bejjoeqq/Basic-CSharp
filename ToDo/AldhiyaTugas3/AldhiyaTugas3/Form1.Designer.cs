namespace AldhiyaTugas3
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
            this.lblOP = new System.Windows.Forms.Label();
            this.txtBIL1 = new System.Windows.Forms.TextBox();
            this.txtBIL2 = new System.Windows.Forms.TextBox();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.btnProses = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.rdoJUM = new System.Windows.Forms.RadioButton();
            this.rdoKUR = new System.Windows.Forms.RadioButton();
            this.rdoKAL = new System.Windows.Forms.RadioButton();
            this.rdoBAG = new System.Windows.Forms.RadioButton();
            this.rdoPAN = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROGRAM PERHITUNGAN ARITMATIKA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Masukkan Bilangan 1 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Masukkan Bilangan 2 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hasil Perhitungan";
            // 
            // lblOP
            // 
            this.lblOP.AutoSize = true;
            this.lblOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOP.Location = new System.Drawing.Point(297, 143);
            this.lblOP.Name = "lblOP";
            this.lblOP.Size = new System.Drawing.Size(0, 44);
            this.lblOP.TabIndex = 4;
            // 
            // txtBIL1
            // 
            this.txtBIL1.Location = new System.Drawing.Point(267, 96);
            this.txtBIL1.Name = "txtBIL1";
            this.txtBIL1.Size = new System.Drawing.Size(100, 22);
            this.txtBIL1.TabIndex = 5;
            // 
            // txtBIL2
            // 
            this.txtBIL2.Location = new System.Drawing.Point(267, 217);
            this.txtBIL2.Name = "txtBIL2";
            this.txtBIL2.Size = new System.Drawing.Size(100, 22);
            this.txtBIL2.TabIndex = 6;
            // 
            // txtHasil
            // 
            this.txtHasil.Enabled = false;
            this.txtHasil.Location = new System.Drawing.Point(267, 339);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(100, 22);
            this.txtHasil.TabIndex = 7;
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(280, 277);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(75, 23);
            this.btnProses.TabIndex = 8;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(442, 372);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // rdoJUM
            // 
            this.rdoJUM.AutoSize = true;
            this.rdoJUM.Location = new System.Drawing.Point(6, 31);
            this.rdoJUM.Name = "rdoJUM";
            this.rdoJUM.Size = new System.Drawing.Size(111, 21);
            this.rdoJUM.TabIndex = 10;
            this.rdoJUM.TabStop = true;
            this.rdoJUM.Text = "Penjumlahan";
            this.rdoJUM.UseVisualStyleBackColor = true;
            this.rdoJUM.CheckedChanged += new System.EventHandler(this.rdoJUM_CheckedChanged);
            // 
            // rdoKUR
            // 
            this.rdoKUR.AutoSize = true;
            this.rdoKUR.Location = new System.Drawing.Point(6, 58);
            this.rdoKUR.Name = "rdoKUR";
            this.rdoKUR.Size = new System.Drawing.Size(115, 21);
            this.rdoKUR.TabIndex = 11;
            this.rdoKUR.TabStop = true;
            this.rdoKUR.Text = "Pengurangan";
            this.rdoKUR.UseVisualStyleBackColor = true;
            this.rdoKUR.CheckedChanged += new System.EventHandler(this.rdoKUR_CheckedChanged);
            // 
            // rdoKAL
            // 
            this.rdoKAL.AutoSize = true;
            this.rdoKAL.Location = new System.Drawing.Point(6, 85);
            this.rdoKAL.Name = "rdoKAL";
            this.rdoKAL.Size = new System.Drawing.Size(88, 21);
            this.rdoKAL.TabIndex = 12;
            this.rdoKAL.TabStop = true;
            this.rdoKAL.Text = "Perkalian";
            this.rdoKAL.UseVisualStyleBackColor = true;
            this.rdoKAL.CheckedChanged += new System.EventHandler(this.rdoKAL_CheckedChanged);
            // 
            // rdoBAG
            // 
            this.rdoBAG.AutoSize = true;
            this.rdoBAG.Location = new System.Drawing.Point(6, 112);
            this.rdoBAG.Name = "rdoBAG";
            this.rdoBAG.Size = new System.Drawing.Size(100, 21);
            this.rdoBAG.TabIndex = 13;
            this.rdoBAG.TabStop = true;
            this.rdoBAG.Text = "Pembagian";
            this.rdoBAG.UseVisualStyleBackColor = true;
            this.rdoBAG.CheckedChanged += new System.EventHandler(this.rdoBAG_CheckedChanged);
            // 
            // rdoPAN
            // 
            this.rdoPAN.AutoSize = true;
            this.rdoPAN.Location = new System.Drawing.Point(6, 139);
            this.rdoPAN.Name = "rdoPAN";
            this.rdoPAN.Size = new System.Drawing.Size(116, 21);
            this.rdoPAN.TabIndex = 14;
            this.rdoPAN.TabStop = true;
            this.rdoPAN.Text = "Pemangkatan";
            this.rdoPAN.UseVisualStyleBackColor = true;
            this.rdoPAN.CheckedChanged += new System.EventHandler(this.rdoPAN_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoPAN);
            this.groupBox1.Controls.Add(this.rdoJUM);
            this.groupBox1.Controls.Add(this.rdoKUR);
            this.groupBox1.Controls.Add(this.rdoKAL);
            this.groupBox1.Controls.Add(this.rdoBAG);
            this.groupBox1.Location = new System.Drawing.Point(419, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 177);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pilihan Proses";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(442, 325);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 416);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.txtBIL2);
            this.Controls.Add(this.txtBIL1);
            this.Controls.Add(this.lblOP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "frmMath";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOP;
        private System.Windows.Forms.TextBox txtBIL1;
        private System.Windows.Forms.TextBox txtBIL2;
        private System.Windows.Forms.TextBox txtHasil;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RadioButton rdoJUM;
        private System.Windows.Forms.RadioButton rdoKUR;
        private System.Windows.Forms.RadioButton rdoKAL;
        private System.Windows.Forms.RadioButton rdoBAG;
        private System.Windows.Forms.RadioButton rdoPAN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClear;
    }
}

