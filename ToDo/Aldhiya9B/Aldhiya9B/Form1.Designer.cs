namespace Aldhiya9B
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
            this.txtKode = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtKemasan = new System.Windows.Forms.TextBox();
            this.txtHbeli = new System.Windows.Forms.TextBox();
            this.txtHjual = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.btnTampil = new System.Windows.Forms.Button();
            this.lblSimpan = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROGRAM DATA OBAT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kode Obat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama Obat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kemasan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Harga Beli";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Harga Jual";
            // 
            // txtKode
            // 
            this.txtKode.Location = new System.Drawing.Point(172, 80);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(156, 22);
            this.txtKode.TabIndex = 6;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(172, 130);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(156, 22);
            this.txtNama.TabIndex = 7;
            // 
            // txtKemasan
            // 
            this.txtKemasan.Location = new System.Drawing.Point(172, 182);
            this.txtKemasan.Name = "txtKemasan";
            this.txtKemasan.Size = new System.Drawing.Size(156, 22);
            this.txtKemasan.TabIndex = 8;
            // 
            // txtHbeli
            // 
            this.txtHbeli.Location = new System.Drawing.Point(172, 237);
            this.txtHbeli.Name = "txtHbeli";
            this.txtHbeli.Size = new System.Drawing.Size(156, 22);
            this.txtHbeli.TabIndex = 9;
            this.txtHbeli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHbeli_KeyPress);
            // 
            // txtHjual
            // 
            this.txtHjual.Location = new System.Drawing.Point(172, 290);
            this.txtHjual.Name = "txtHjual";
            this.txtHjual.Size = new System.Drawing.Size(156, 22);
            this.txtHjual.TabIndex = 10;
            this.txtHjual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHjual_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.comboBox1.Location = new System.Drawing.Point(562, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 24);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(414, 191);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(245, 192);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(12, 360);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 13;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(253, 360);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 23);
            this.btnKeluar.TabIndex = 14;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // btnTampil
            // 
            this.btnTampil.Location = new System.Drawing.Point(575, 162);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(84, 23);
            this.btnTampil.TabIndex = 15;
            this.btnTampil.Text = "Tampil";
            this.btnTampil.UseVisualStyleBackColor = true;
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // lblSimpan
            // 
            this.lblSimpan.AutoSize = true;
            this.lblSimpan.Location = new System.Drawing.Point(93, 363);
            this.lblSimpan.Name = "lblSimpan";
            this.lblSimpan.Size = new System.Drawing.Size(55, 17);
            this.lblSimpan.TabIndex = 16;
            this.lblSimpan.Text = "Simpan";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(154, 360);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "0";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(334, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(334, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(334, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(334, 293);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 395);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblSimpan);
            this.Controls.Add(this.btnTampil);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtHjual);
            this.Controls.Add(this.txtHbeli);
            this.Controls.Add(this.txtKemasan);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtKode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtKemasan;
        private System.Windows.Forms.TextBox txtHbeli;
        private System.Windows.Forms.TextBox txtHjual;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button btnTampil;
        private System.Windows.Forms.Label lblSimpan;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

