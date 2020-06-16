namespace AplikasiPencarianString
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
            this.teksCari = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tombolGo = new System.Windows.Forms.Button();
            this.teksIndeks = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.teksSubstring = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.teksHasil = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "String Pencarian:";
            // 
            // teksCari
            // 
            this.teksCari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksCari.Location = new System.Drawing.Point(117, 25);
            this.teksCari.Name = "teksCari";
            this.teksCari.ReadOnly = true;
            this.teksCari.Size = new System.Drawing.Size(344, 26);
            this.teksCari.TabIndex = 1;
            this.teksCari.Text = "abcABC00123573@ 123 ABC 98ABC123";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nomor Indeks:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(339, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "012345678901234567890123456789012";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(209, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(306, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "20";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(409, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "30";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tombolGo);
            this.groupBox1.Controls.Add(this.teksIndeks);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.teksSubstring);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(15, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pencarian";
            // 
            // tombolGo
            // 
            this.tombolGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolGo.Location = new System.Drawing.Point(295, 27);
            this.tombolGo.Name = "tombolGo";
            this.tombolGo.Size = new System.Drawing.Size(128, 61);
            this.tombolGo.TabIndex = 4;
            this.tombolGo.Text = "Go!";
            this.tombolGo.UseVisualStyleBackColor = true;
            this.tombolGo.Click += new System.EventHandler(this.tombolGo_Click);
            // 
            // teksIndeks
            // 
            this.teksIndeks.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.teksIndeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksIndeks.Location = new System.Drawing.Point(122, 62);
            this.teksIndeks.Name = "teksIndeks";
            this.teksIndeks.Size = new System.Drawing.Size(154, 26);
            this.teksIndeks.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Mulai dari indeks:";
            // 
            // teksSubstring
            // 
            this.teksSubstring.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.teksSubstring.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksSubstring.Location = new System.Drawing.Point(122, 24);
            this.teksSubstring.Name = "teksSubstring";
            this.teksSubstring.Size = new System.Drawing.Size(154, 26);
            this.teksSubstring.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Substring yang dicari:";
            // 
            // teksHasil
            // 
            this.teksHasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksHasil.Location = new System.Drawing.Point(15, 280);
            this.teksHasil.Name = "teksHasil";
            this.teksHasil.ReadOnly = true;
            this.teksHasil.Size = new System.Drawing.Size(439, 26);
            this.teksHasil.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 327);
            this.Controls.Add(this.teksHasil);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.teksCari);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Aplikasi Pencarian String";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teksCari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button tombolGo;
        private System.Windows.Forms.TextBox teksIndeks;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox teksSubstring;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox teksHasil;
    }
}

