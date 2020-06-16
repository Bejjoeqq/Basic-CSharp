namespace Aldhiya7b
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
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cboKode = new System.Windows.Forms.ComboBox();
            this.cboJabatan = new System.Windows.Forms.ComboBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.cboAnak = new System.Windows.Forms.ComboBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtBagian = new System.Windows.Forms.TextBox();
            this.txtGaji = new System.Windows.Forms.TextBox();
            this.txtPajak = new System.Windows.Forms.TextBox();
            this.txtKeluarga = new System.Windows.Forms.TextBox();
            this.txtAnak = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnProses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORM PENGGAJIAN PEGAWAI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kode Pegawai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bagian";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Jabatan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gaji Pokok";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Pajak Penghasilan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Jumlah Anak";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Tunjangan Keluarga";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 384);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Tunjangan Anak";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 422);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Total Gaji";
            // 
            // cboKode
            // 
            this.cboKode.FormattingEnabled = true;
            this.cboKode.Items.AddRange(new object[] {
            "PM101",
            "PS201",
            "KU301"});
            this.cboKode.Location = new System.Drawing.Point(261, 38);
            this.cboKode.Name = "cboKode";
            this.cboKode.Size = new System.Drawing.Size(146, 24);
            this.cboKode.TabIndex = 12;
            this.cboKode.SelectedIndexChanged += new System.EventHandler(this.cboKode_SelectedIndexChanged);
            // 
            // cboJabatan
            // 
            this.cboJabatan.FormattingEnabled = true;
            this.cboJabatan.Items.AddRange(new object[] {
            "Kepala Devisi",
            "Staff"});
            this.cboJabatan.Location = new System.Drawing.Point(261, 148);
            this.cboJabatan.Name = "cboJabatan";
            this.cboJabatan.Size = new System.Drawing.Size(146, 24);
            this.cboJabatan.TabIndex = 13;
            this.cboJabatan.SelectedIndexChanged += new System.EventHandler(this.cboJabatan_SelectedIndexChanged);
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Menikah",
            "Belum Menikah"});
            this.cboStatus.Location = new System.Drawing.Point(261, 262);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(146, 24);
            this.cboStatus.TabIndex = 14;
            this.cboStatus.SelectedIndexChanged += new System.EventHandler(this.cboStatus_SelectedIndexChanged);
            // 
            // cboAnak
            // 
            this.cboAnak.FormattingEnabled = true;
            this.cboAnak.Items.AddRange(new object[] {
            "3",
            "2",
            "1"});
            this.cboAnak.Location = new System.Drawing.Point(261, 301);
            this.cboAnak.Name = "cboAnak";
            this.cboAnak.Size = new System.Drawing.Size(146, 24);
            this.cboAnak.TabIndex = 15;
            this.cboAnak.SelectedIndexChanged += new System.EventHandler(this.cboAnak_SelectedIndexChanged);
            // 
            // txtNama
            // 
            this.txtNama.Enabled = false;
            this.txtNama.Location = new System.Drawing.Point(261, 77);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(146, 22);
            this.txtNama.TabIndex = 16;
            // 
            // txtBagian
            // 
            this.txtBagian.Enabled = false;
            this.txtBagian.Location = new System.Drawing.Point(261, 115);
            this.txtBagian.Name = "txtBagian";
            this.txtBagian.Size = new System.Drawing.Size(146, 22);
            this.txtBagian.TabIndex = 18;
            // 
            // txtGaji
            // 
            this.txtGaji.Enabled = false;
            this.txtGaji.Location = new System.Drawing.Point(261, 187);
            this.txtGaji.Name = "txtGaji";
            this.txtGaji.Size = new System.Drawing.Size(146, 22);
            this.txtGaji.TabIndex = 19;
            // 
            // txtPajak
            // 
            this.txtPajak.Enabled = false;
            this.txtPajak.Location = new System.Drawing.Point(261, 224);
            this.txtPajak.Name = "txtPajak";
            this.txtPajak.Size = new System.Drawing.Size(146, 22);
            this.txtPajak.TabIndex = 20;
            // 
            // txtKeluarga
            // 
            this.txtKeluarga.Enabled = false;
            this.txtKeluarga.Location = new System.Drawing.Point(261, 341);
            this.txtKeluarga.Name = "txtKeluarga";
            this.txtKeluarga.Size = new System.Drawing.Size(146, 22);
            this.txtKeluarga.TabIndex = 21;
            // 
            // txtAnak
            // 
            this.txtAnak.Enabled = false;
            this.txtAnak.Location = new System.Drawing.Point(261, 381);
            this.txtAnak.Name = "txtAnak";
            this.txtAnak.Size = new System.Drawing.Size(146, 22);
            this.txtAnak.TabIndex = 22;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(261, 419);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(146, 22);
            this.txtTotal.TabIndex = 23;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 461);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(332, 461);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(75, 23);
            this.btnProses.TabIndex = 25;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 496);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtAnak);
            this.Controls.Add(this.txtKeluarga);
            this.Controls.Add(this.txtPajak);
            this.Controls.Add(this.txtGaji);
            this.Controls.Add(this.txtBagian);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.cboAnak);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.cboJabatan);
            this.Controls.Add(this.cboKode);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form Gaji Pegawai";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboKode;
        private System.Windows.Forms.ComboBox cboJabatan;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.ComboBox cboAnak;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtBagian;
        private System.Windows.Forms.TextBox txtGaji;
        private System.Windows.Forms.TextBox txtPajak;
        private System.Windows.Forms.TextBox txtKeluarga;
        private System.Windows.Forms.TextBox txtAnak;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnProses;
    }
}

