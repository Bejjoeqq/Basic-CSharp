namespace DemoKembalian
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
            this.teksBerat = new System.Windows.Forms.TextBox();
            this.teksUang = new System.Windows.Forms.TextBox();
            this.tombolHitung = new System.Windows.Forms.Button();
            this.teksKeluaran = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Berat Apel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Uang Yang Dibayarkan:";
            // 
            // teksBerat
            // 
            this.teksBerat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksBerat.Location = new System.Drawing.Point(140, 20);
            this.teksBerat.Name = "teksBerat";
            this.teksBerat.Size = new System.Drawing.Size(190, 31);
            this.teksBerat.TabIndex = 2;
            // 
            // teksUang
            // 
            this.teksUang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksUang.Location = new System.Drawing.Point(140, 69);
            this.teksUang.Name = "teksUang";
            this.teksUang.Size = new System.Drawing.Size(190, 31);
            this.teksUang.TabIndex = 3;
            // 
            // tombolHitung
            // 
            this.tombolHitung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolHitung.Location = new System.Drawing.Point(16, 131);
            this.tombolHitung.Name = "tombolHitung";
            this.tombolHitung.Size = new System.Drawing.Size(314, 44);
            this.tombolHitung.TabIndex = 4;
            this.tombolHitung.Text = "Hitung Uang Kembalian";
            this.tombolHitung.UseVisualStyleBackColor = true;
            this.tombolHitung.Click += new System.EventHandler(this.tombolHitung_Click);
            // 
            // teksKeluaran
            // 
            this.teksKeluaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksKeluaran.Location = new System.Drawing.Point(16, 200);
            this.teksKeluaran.Name = "teksKeluaran";
            this.teksKeluaran.ReadOnly = true;
            this.teksKeluaran.Size = new System.Drawing.Size(314, 26);
            this.teksKeluaran.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 262);
            this.Controls.Add(this.teksKeluaran);
            this.Controls.Add(this.tombolHitung);
            this.Controls.Add(this.teksUang);
            this.Controls.Add(this.teksBerat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Demo Kembalian";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox teksBerat;
        private System.Windows.Forms.TextBox teksUang;
        private System.Windows.Forms.Button tombolHitung;
        private System.Windows.Forms.TextBox teksKeluaran;
    }
}

