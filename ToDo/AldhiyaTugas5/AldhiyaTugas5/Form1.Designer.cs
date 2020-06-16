namespace AldhiyaTugas5
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
            this.cboKode = new System.Windows.Forms.ComboBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtBagian = new System.Windows.Forms.TextBox();
            this.txtJabatan = new System.Windows.Forms.TextBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.btnProses = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(84, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATA PEGAWAI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kode Pegawai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bagian";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Jabatan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "No. Urut";
            // 
            // cboKode
            // 
            this.cboKode.FormattingEnabled = true;
            this.cboKode.Items.AddRange(new object[] {
            "PM-A101",
            "PS-B201",
            "KU-C301",
            "GD-A401",
            "PM",
            "PS",
            "KU",
            "GD",
            "A",
            "B",
            "C",
            "101",
            "201",
            "301",
            "401",
            " "});
            this.cboKode.Location = new System.Drawing.Point(243, 126);
            this.cboKode.Name = "cboKode";
            this.cboKode.Size = new System.Drawing.Size(121, 24);
            this.cboKode.TabIndex = 6;
            this.cboKode.SelectedIndexChanged += new System.EventHandler(this.cboKode_SelectedIndexChanged);
            // 
            // txtNama
            // 
            this.txtNama.Enabled = false;
            this.txtNama.Location = new System.Drawing.Point(243, 190);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(121, 22);
            this.txtNama.TabIndex = 7;
            // 
            // txtBagian
            // 
            this.txtBagian.Enabled = false;
            this.txtBagian.Location = new System.Drawing.Point(243, 247);
            this.txtBagian.Name = "txtBagian";
            this.txtBagian.Size = new System.Drawing.Size(121, 22);
            this.txtBagian.TabIndex = 8;
            // 
            // txtJabatan
            // 
            this.txtJabatan.Enabled = false;
            this.txtJabatan.Location = new System.Drawing.Point(243, 308);
            this.txtJabatan.Name = "txtJabatan";
            this.txtJabatan.Size = new System.Drawing.Size(121, 22);
            this.txtJabatan.TabIndex = 9;
            // 
            // txtNo
            // 
            this.txtNo.Enabled = false;
            this.txtNo.Location = new System.Drawing.Point(243, 367);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(121, 22);
            this.txtNo.TabIndex = 10;
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(12, 428);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(75, 23);
            this.btnProses.TabIndex = 11;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(155, 428);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(289, 428);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 463);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.txtJabatan);
            this.Controls.Add(this.txtBagian);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.cboKode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "FORM DATA PEGAWAI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboKode;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtBagian;
        private System.Windows.Forms.TextBox txtJabatan;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}

