namespace UangPendaftaran
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
            this.radioAnak = new System.Windows.Forms.RadioButton();
            this.radioMinor = new System.Windows.Forms.RadioButton();
            this.radioDewasa = new System.Windows.Forms.RadioButton();
            this.radioSenior = new System.Windows.Forms.RadioButton();
            this.tombolTentukan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.teksUang = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioSenior);
            this.groupBox1.Controls.Add(this.radioDewasa);
            this.groupBox1.Controls.Add(this.radioMinor);
            this.groupBox1.Controls.Add(this.radioAnak);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usia";
            // 
            // radioAnak
            // 
            this.radioAnak.AutoSize = true;
            this.radioAnak.Location = new System.Drawing.Point(7, 20);
            this.radioAnak.Name = "radioAnak";
            this.radioAnak.Size = new System.Drawing.Size(104, 17);
            this.radioAnak.TabIndex = 0;
            this.radioAnak.TabStop = true;
            this.radioAnak.Text = "Anak (< 6 tahun)";
            this.radioAnak.UseVisualStyleBackColor = true;
            // 
            // radioMinor
            // 
            this.radioMinor.AutoSize = true;
            this.radioMinor.Location = new System.Drawing.Point(7, 46);
            this.radioMinor.Name = "radioMinor";
            this.radioMinor.Size = new System.Drawing.Size(117, 17);
            this.radioMinor.TabIndex = 1;
            this.radioMinor.TabStop = true;
            this.radioMinor.Text = "Minor (6 - 17 tahun)";
            this.radioMinor.UseVisualStyleBackColor = true;
            // 
            // radioDewasa
            // 
            this.radioDewasa.AutoSize = true;
            this.radioDewasa.Location = new System.Drawing.Point(7, 74);
            this.radioDewasa.Name = "radioDewasa";
            this.radioDewasa.Size = new System.Drawing.Size(136, 17);
            this.radioDewasa.TabIndex = 2;
            this.radioDewasa.TabStop = true;
            this.radioDewasa.Text = "Dewasa (18 - 64 tahun)";
            this.radioDewasa.UseVisualStyleBackColor = true;
            // 
            // radioSenior
            // 
            this.radioSenior.AutoSize = true;
            this.radioSenior.Location = new System.Drawing.Point(7, 103);
            this.radioSenior.Name = "radioSenior";
            this.radioSenior.Size = new System.Drawing.Size(112, 17);
            this.radioSenior.TabIndex = 3;
            this.radioSenior.TabStop = true;
            this.radioSenior.Text = "Senior (65+ tahun)";
            this.radioSenior.UseVisualStyleBackColor = true;
            // 
            // tombolTentukan
            // 
            this.tombolTentukan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolTentukan.Location = new System.Drawing.Point(229, 22);
            this.tombolTentukan.Name = "tombolTentukan";
            this.tombolTentukan.Size = new System.Drawing.Size(209, 70);
            this.tombolTentukan.TabIndex = 1;
            this.tombolTentukan.Text = "Tentukan Uang Pendaftaran";
            this.tombolTentukan.UseVisualStyleBackColor = true;
            this.tombolTentukan.Click += new System.EventHandler(this.tombolTentukan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Uang Pendaftaran:";
            // 
            // teksUang
            // 
            this.teksUang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksUang.Location = new System.Drawing.Point(232, 120);
            this.teksUang.Name = "teksUang";
            this.teksUang.ReadOnly = true;
            this.teksUang.Size = new System.Drawing.Size(206, 26);
            this.teksUang.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 172);
            this.Controls.Add(this.teksUang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tombolTentukan);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Uang Pendaftaran";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioSenior;
        private System.Windows.Forms.RadioButton radioDewasa;
        private System.Windows.Forms.RadioButton radioMinor;
        private System.Windows.Forms.RadioButton radioAnak;
        private System.Windows.Forms.Button tombolTentukan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teksUang;
    }
}

