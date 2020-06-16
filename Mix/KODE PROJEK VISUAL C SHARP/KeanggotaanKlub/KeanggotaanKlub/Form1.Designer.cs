namespace KeanggotaanKlub
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radDewasa = new System.Windows.Forms.RadioButton();
            this.radSenior = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkTennis = new System.Windows.Forms.CheckBox();
            this.checkLocker = new System.Windows.Forms.CheckBox();
            this.checkLaundry = new System.Windows.Forms.CheckBox();
            this.tombolHitung = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.teksBiaya = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radSenior);
            this.groupBox1.Controls.Add(this.radDewasa);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Keanggotaan";
            // 
            // radDewasa
            // 
            this.radDewasa.AutoSize = true;
            this.radDewasa.Location = new System.Drawing.Point(7, 20);
            this.radDewasa.Name = "radDewasa";
            this.radDewasa.Size = new System.Drawing.Size(136, 17);
            this.radDewasa.TabIndex = 0;
            this.radDewasa.TabStop = true;
            this.radDewasa.Text = "Dewasa (16 - 64 tahun)";
            this.radDewasa.UseVisualStyleBackColor = true;
            // 
            // radSenior
            // 
            this.radSenior.AutoSize = true;
            this.radSenior.Location = new System.Drawing.Point(7, 43);
            this.radSenior.Name = "radSenior";
            this.radSenior.Size = new System.Drawing.Size(112, 17);
            this.radSenior.TabIndex = 1;
            this.radSenior.TabStop = true;
            this.radSenior.Text = "Senior (65+ tahun)";
            this.radSenior.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkLaundry);
            this.groupBox2.Controls.Add(this.checkLocker);
            this.groupBox2.Controls.Add(this.checkTennis);
            this.groupBox2.Location = new System.Drawing.Point(174, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ekstra";
            // 
            // checkTennis
            // 
            this.checkTennis.AutoSize = true;
            this.checkTennis.Location = new System.Drawing.Point(7, 20);
            this.checkTennis.Name = "checkTennis";
            this.checkTennis.Size = new System.Drawing.Size(93, 17);
            this.checkTennis.TabIndex = 0;
            this.checkTennis.Text = "Bermain Tenis";
            this.checkTennis.UseVisualStyleBackColor = true;
            // 
            // checkLocker
            // 
            this.checkLocker.AutoSize = true;
            this.checkLocker.Location = new System.Drawing.Point(7, 44);
            this.checkLocker.Name = "checkLocker";
            this.checkLocker.Size = new System.Drawing.Size(89, 17);
            this.checkLocker.TabIndex = 1;
            this.checkLocker.Text = "Locker Privat";
            this.checkLocker.UseVisualStyleBackColor = true;
            // 
            // checkLaundry
            // 
            this.checkLaundry.AutoSize = true;
            this.checkLaundry.Location = new System.Drawing.Point(7, 67);
            this.checkLaundry.Name = "checkLaundry";
            this.checkLaundry.Size = new System.Drawing.Size(108, 17);
            this.checkLaundry.TabIndex = 2;
            this.checkLaundry.Text = "Layanan Laundry";
            this.checkLaundry.UseVisualStyleBackColor = true;
            // 
            // tombolHitung
            // 
            this.tombolHitung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolHitung.Location = new System.Drawing.Point(12, 93);
            this.tombolHitung.Name = "tombolHitung";
            this.tombolHitung.Size = new System.Drawing.Size(154, 73);
            this.tombolHitung.TabIndex = 2;
            this.tombolHitung.Text = "Hitung Biaya Bulanan";
            this.tombolHitung.UseVisualStyleBackColor = true;
            this.tombolHitung.Click += new System.EventHandler(this.tombolHitung_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Biaya Bulanan:";
            // 
            // teksBiaya
            // 
            this.teksBiaya.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksBiaya.Location = new System.Drawing.Point(177, 137);
            this.teksBiaya.Name = "teksBiaya";
            this.teksBiaya.ReadOnly = true;
            this.teksBiaya.Size = new System.Drawing.Size(146, 26);
            this.teksBiaya.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 182);
            this.Controls.Add(this.teksBiaya);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tombolHitung);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Keanggotaan Klub";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radSenior;
        private System.Windows.Forms.RadioButton radDewasa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkLaundry;
        private System.Windows.Forms.CheckBox checkLocker;
        private System.Windows.Forms.CheckBox checkTennis;
        private System.Windows.Forms.Button tombolHitung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teksBiaya;
    }
}

