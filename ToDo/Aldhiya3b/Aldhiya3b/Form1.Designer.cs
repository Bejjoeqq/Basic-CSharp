namespace Aldhiya3b
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
            this.txtTampil = new System.Windows.Forms.TextBox();
            this.grpPerataan = new System.Windows.Forms.GroupBox();
            this.grpBackground = new System.Windows.Forms.GroupBox();
            this.rdoKiri = new System.Windows.Forms.RadioButton();
            this.rdoTengah = new System.Windows.Forms.RadioButton();
            this.rdoKanan = new System.Windows.Forms.RadioButton();
            this.chkPutih = new System.Windows.Forms.CheckBox();
            this.chkKuning = new System.Windows.Forms.CheckBox();
            this.chkHijau = new System.Windows.Forms.CheckBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnTutup = new System.Windows.Forms.Button();
            this.grpPerataan.SuspendLayout();
            this.grpBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTampil
            // 
            this.txtTampil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtTampil.Location = new System.Drawing.Point(12, 12);
            this.txtTampil.Multiline = true;
            this.txtTampil.Name = "txtTampil";
            this.txtTampil.Size = new System.Drawing.Size(452, 49);
            this.txtTampil.TabIndex = 0;
            // 
            // grpPerataan
            // 
            this.grpPerataan.Controls.Add(this.rdoKanan);
            this.grpPerataan.Controls.Add(this.rdoTengah);
            this.grpPerataan.Controls.Add(this.rdoKiri);
            this.grpPerataan.Location = new System.Drawing.Point(22, 90);
            this.grpPerataan.Name = "grpPerataan";
            this.grpPerataan.Size = new System.Drawing.Size(200, 100);
            this.grpPerataan.TabIndex = 1;
            this.grpPerataan.TabStop = false;
            this.grpPerataan.Text = "Perataan Text";
            // 
            // grpBackground
            // 
            this.grpBackground.Controls.Add(this.chkHijau);
            this.grpBackground.Controls.Add(this.chkKuning);
            this.grpBackground.Controls.Add(this.chkPutih);
            this.grpBackground.Location = new System.Drawing.Point(264, 90);
            this.grpBackground.Name = "grpBackground";
            this.grpBackground.Size = new System.Drawing.Size(200, 100);
            this.grpBackground.TabIndex = 0;
            this.grpBackground.TabStop = false;
            this.grpBackground.Text = "Warna Background";
            // 
            // rdoKiri
            // 
            this.rdoKiri.AutoSize = true;
            this.rdoKiri.Location = new System.Drawing.Point(6, 21);
            this.rdoKiri.Name = "rdoKiri";
            this.rdoKiri.Size = new System.Drawing.Size(83, 21);
            this.rdoKiri.TabIndex = 0;
            this.rdoKiri.TabStop = true;
            this.rdoKiri.Text = "Rata Kiri";
            this.rdoKiri.UseVisualStyleBackColor = true;
            this.rdoKiri.CheckedChanged += new System.EventHandler(this.rdoKiri_CheckedChanged);
            // 
            // rdoTengah
            // 
            this.rdoTengah.AutoSize = true;
            this.rdoTengah.Location = new System.Drawing.Point(6, 48);
            this.rdoTengah.Name = "rdoTengah";
            this.rdoTengah.Size = new System.Drawing.Size(112, 21);
            this.rdoTengah.TabIndex = 1;
            this.rdoTengah.TabStop = true;
            this.rdoTengah.Text = "Rata Tengah";
            this.rdoTengah.UseVisualStyleBackColor = true;
            this.rdoTengah.CheckedChanged += new System.EventHandler(this.rdoTengah_CheckedChanged);
            // 
            // rdoKanan
            // 
            this.rdoKanan.AutoSize = true;
            this.rdoKanan.Location = new System.Drawing.Point(6, 73);
            this.rdoKanan.Name = "rdoKanan";
            this.rdoKanan.Size = new System.Drawing.Size(104, 21);
            this.rdoKanan.TabIndex = 2;
            this.rdoKanan.TabStop = true;
            this.rdoKanan.Text = "Rata Kanan";
            this.rdoKanan.UseVisualStyleBackColor = true;
            this.rdoKanan.CheckedChanged += new System.EventHandler(this.rdoKanan_CheckedChanged);
            // 
            // chkPutih
            // 
            this.chkPutih.AutoSize = true;
            this.chkPutih.Location = new System.Drawing.Point(6, 21);
            this.chkPutih.Name = "chkPutih";
            this.chkPutih.Size = new System.Drawing.Size(62, 21);
            this.chkPutih.TabIndex = 0;
            this.chkPutih.Text = "Putih";
            this.chkPutih.UseVisualStyleBackColor = true;
            this.chkPutih.CheckedChanged += new System.EventHandler(this.chkPutih_CheckedChanged);
            // 
            // chkKuning
            // 
            this.chkKuning.AutoSize = true;
            this.chkKuning.Location = new System.Drawing.Point(6, 48);
            this.chkKuning.Name = "chkKuning";
            this.chkKuning.Size = new System.Drawing.Size(74, 21);
            this.chkKuning.TabIndex = 1;
            this.chkKuning.Text = "Kuning";
            this.chkKuning.UseVisualStyleBackColor = true;
            this.chkKuning.CheckedChanged += new System.EventHandler(this.chkKuning_CheckedChanged);
            // 
            // chkHijau
            // 
            this.chkHijau.AutoSize = true;
            this.chkHijau.Location = new System.Drawing.Point(6, 75);
            this.chkHijau.Name = "chkHijau";
            this.chkHijau.Size = new System.Drawing.Size(62, 21);
            this.chkHijau.TabIndex = 2;
            this.chkHijau.Text = "Hijau";
            this.chkHijau.UseVisualStyleBackColor = true;
            this.chkHijau.CheckedChanged += new System.EventHandler(this.chkHijau_CheckedChanged);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(78, 196);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus Data";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnTutup
            // 
            this.btnTutup.Location = new System.Drawing.Point(315, 196);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(75, 23);
            this.btnTutup.TabIndex = 4;
            this.btnTutup.Text = "Tutup";
            this.btnTutup.UseVisualStyleBackColor = true;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 253);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnTutup);
            this.Controls.Add(this.grpBackground);
            this.Controls.Add(this.grpPerataan);
            this.Controls.Add(this.txtTampil);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpPerataan.ResumeLayout(false);
            this.grpPerataan.PerformLayout();
            this.grpBackground.ResumeLayout(false);
            this.grpBackground.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTampil;
        private System.Windows.Forms.GroupBox grpPerataan;
        private System.Windows.Forms.RadioButton rdoKanan;
        private System.Windows.Forms.RadioButton rdoTengah;
        private System.Windows.Forms.RadioButton rdoKiri;
        private System.Windows.Forms.GroupBox grpBackground;
        private System.Windows.Forms.CheckBox chkHijau;
        private System.Windows.Forms.CheckBox chkKuning;
        private System.Windows.Forms.CheckBox chkPutih;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnTutup;
    }
}

