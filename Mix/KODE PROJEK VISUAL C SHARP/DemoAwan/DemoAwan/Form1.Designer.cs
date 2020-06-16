namespace DemoAwan
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
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.radio4 = new System.Windows.Forms.RadioButton();
            this.tombolDeskripsi = new System.Windows.Forms.Button();
            this.teksKeluaran = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesentase Cakupan Awan:";
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Location = new System.Drawing.Point(167, 22);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(60, 17);
            this.radio1.TabIndex = 1;
            this.radio1.TabStop = true;
            this.radio1.Text = "0 - 30%";
            this.radio1.UseVisualStyleBackColor = true;
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Location = new System.Drawing.Point(244, 22);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(66, 17);
            this.radio2.TabIndex = 2;
            this.radio2.TabStop = true;
            this.radio2.Text = "31 - 70%";
            this.radio2.UseVisualStyleBackColor = true;
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Location = new System.Drawing.Point(334, 22);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(66, 17);
            this.radio3.TabIndex = 3;
            this.radio3.TabStop = true;
            this.radio3.Text = "71 - 99%";
            this.radio3.UseVisualStyleBackColor = true;
            // 
            // radio4
            // 
            this.radio4.AutoSize = true;
            this.radio4.Location = new System.Drawing.Point(427, 22);
            this.radio4.Name = "radio4";
            this.radio4.Size = new System.Drawing.Size(51, 17);
            this.radio4.TabIndex = 4;
            this.radio4.TabStop = true;
            this.radio4.Text = "100%";
            this.radio4.UseVisualStyleBackColor = true;
            // 
            // tombolDeskripsi
            // 
            this.tombolDeskripsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolDeskripsi.Location = new System.Drawing.Point(16, 65);
            this.tombolDeskripsi.Name = "tombolDeskripsi";
            this.tombolDeskripsi.Size = new System.Drawing.Size(459, 60);
            this.tombolDeskripsi.TabIndex = 5;
            this.tombolDeskripsi.Text = "Deskripsikan Kondisi Langit";
            this.tombolDeskripsi.UseVisualStyleBackColor = true;
            this.tombolDeskripsi.Click += new System.EventHandler(this.tombolDeskripsi_Click);
            // 
            // teksKeluaran
            // 
            this.teksKeluaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksKeluaran.Location = new System.Drawing.Point(16, 153);
            this.teksKeluaran.Multiline = true;
            this.teksKeluaran.Name = "teksKeluaran";
            this.teksKeluaran.ReadOnly = true;
            this.teksKeluaran.Size = new System.Drawing.Size(459, 50);
            this.teksKeluaran.TabIndex = 6;
            this.teksKeluaran.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 219);
            this.Controls.Add(this.teksKeluaran);
            this.Controls.Add(this.tombolDeskripsi);
            this.Controls.Add(this.radio4);
            this.Controls.Add(this.radio3);
            this.Controls.Add(this.radio2);
            this.Controls.Add(this.radio1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Demo Awan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.RadioButton radio4;
        private System.Windows.Forms.Button tombolDeskripsi;
        private System.Windows.Forms.TextBox teksKeluaran;
    }
}

