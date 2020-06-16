namespace Aldhiya7a
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
            this.label8 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.txtBiaya = new System.Windows.Forms.TextBox();
            this.txtPembayaran = new System.Windows.Forms.TextBox();
            this.txtKembali = new System.Windows.Forms.TextBox();
            this.btnProses = new System.Windows.Forms.Button();
            this.btnKembali = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblJumlah = new System.Windows.Forms.Label();
            this.lblBayar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(131, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "FOTO COPY BEJJO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dapatkan harga lebih murah\r\napabila anda menjadi member kami";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Harga Per Lembar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Status Pelanggan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Jumlah Lembar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Biaya";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Pembayaran";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Kembali Uang";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Member",
            "Non Member"});
            this.cboStatus.Location = new System.Drawing.Point(231, 71);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(137, 24);
            this.cboStatus.TabIndex = 8;
            this.cboStatus.SelectedIndexChanged += new System.EventHandler(this.cboStatus_SelectedIndexChanged);
            // 
            // txtHarga
            // 
            this.txtHarga.Enabled = false;
            this.txtHarga.Location = new System.Drawing.Point(538, 71);
            this.txtHarga.Multiline = true;
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(125, 55);
            this.txtHarga.TabIndex = 9;
            this.txtHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtJumlah
            // 
            this.txtJumlah.Enabled = false;
            this.txtJumlah.Location = new System.Drawing.Point(268, 131);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(100, 22);
            this.txtJumlah.TabIndex = 10;
            // 
            // txtBiaya
            // 
            this.txtBiaya.Enabled = false;
            this.txtBiaya.Location = new System.Drawing.Point(268, 240);
            this.txtBiaya.Name = "txtBiaya";
            this.txtBiaya.Size = new System.Drawing.Size(100, 22);
            this.txtBiaya.TabIndex = 11;
            // 
            // txtPembayaran
            // 
            this.txtPembayaran.Enabled = false;
            this.txtPembayaran.Location = new System.Drawing.Point(268, 294);
            this.txtPembayaran.Name = "txtPembayaran";
            this.txtPembayaran.Size = new System.Drawing.Size(100, 22);
            this.txtPembayaran.TabIndex = 12;
            // 
            // txtKembali
            // 
            this.txtKembali.Enabled = false;
            this.txtKembali.Location = new System.Drawing.Point(268, 403);
            this.txtKembali.Name = "txtKembali";
            this.txtKembali.Size = new System.Drawing.Size(100, 22);
            this.txtKembali.TabIndex = 13;
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(282, 184);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(75, 23);
            this.btnProses.TabIndex = 14;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(282, 345);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(75, 23);
            this.btnKembali.TabIndex = 15;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(507, 403);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(588, 403);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblJumlah
            // 
            this.lblJumlah.AutoSize = true;
            this.lblJumlah.Location = new System.Drawing.Point(374, 134);
            this.lblJumlah.Name = "lblJumlah";
            this.lblJumlah.Size = new System.Drawing.Size(0, 17);
            this.lblJumlah.TabIndex = 18;
            // 
            // lblBayar
            // 
            this.lblBayar.AutoSize = true;
            this.lblBayar.Location = new System.Drawing.Point(374, 297);
            this.lblBayar.Name = "lblBayar";
            this.lblBayar.Size = new System.Drawing.Size(0, 17);
            this.lblBayar.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 438);
            this.Controls.Add(this.lblBayar);
            this.Controls.Add(this.lblJumlah);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.txtKembali);
            this.Controls.Add(this.txtPembayaran);
            this.Controls.Add(this.txtBiaya);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "BejjoEqq";
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.TextBox txtBiaya;
        private System.Windows.Forms.TextBox txtPembayaran;
        private System.Windows.Forms.TextBox txtKembali;
        private System.Windows.Forms.Button btnProses;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblJumlah;
        private System.Windows.Forms.Label lblBayar;
    }
}

