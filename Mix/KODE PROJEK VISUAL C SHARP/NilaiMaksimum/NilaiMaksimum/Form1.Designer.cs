namespace NilaiMaksimum
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
            this.teksPertama = new System.Windows.Forms.TextBox();
            this.teksKedua = new System.Windows.Forms.TextBox();
            this.tombolTentukan = new System.Windows.Forms.Button();
            this.teksNilaiMaks = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Angka Pertama:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Angka Kedua:";
            // 
            // teksPertama
            // 
            this.teksPertama.BackColor = System.Drawing.Color.MistyRose;
            this.teksPertama.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksPertama.Location = new System.Drawing.Point(101, 10);
            this.teksPertama.Name = "teksPertama";
            this.teksPertama.Size = new System.Drawing.Size(333, 31);
            this.teksPertama.TabIndex = 2;
            // 
            // teksKedua
            // 
            this.teksKedua.BackColor = System.Drawing.Color.MistyRose;
            this.teksKedua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksKedua.Location = new System.Drawing.Point(101, 63);
            this.teksKedua.Name = "teksKedua";
            this.teksKedua.Size = new System.Drawing.Size(333, 31);
            this.teksKedua.TabIndex = 3;
            // 
            // tombolTentukan
            // 
            this.tombolTentukan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolTentukan.Location = new System.Drawing.Point(15, 126);
            this.tombolTentukan.Name = "tombolTentukan";
            this.tombolTentukan.Size = new System.Drawing.Size(419, 66);
            this.tombolTentukan.TabIndex = 4;
            this.tombolTentukan.Text = "Tentukan Nilai Maksimum";
            this.tombolTentukan.UseVisualStyleBackColor = true;
            this.tombolTentukan.Click += new System.EventHandler(this.tombolTentukan_Click);
            // 
            // teksNilaiMaks
            // 
            this.teksNilaiMaks.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.teksNilaiMaks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksNilaiMaks.Location = new System.Drawing.Point(15, 221);
            this.teksNilaiMaks.Name = "teksNilaiMaks";
            this.teksNilaiMaks.Size = new System.Drawing.Size(419, 31);
            this.teksNilaiMaks.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 291);
            this.Controls.Add(this.teksNilaiMaks);
            this.Controls.Add(this.tombolTentukan);
            this.Controls.Add(this.teksKedua);
            this.Controls.Add(this.teksPertama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Nilai Maksimum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox teksPertama;
        private System.Windows.Forms.TextBox teksKedua;
        private System.Windows.Forms.Button tombolTentukan;
        private System.Windows.Forms.TextBox teksNilaiMaks;
    }
}

