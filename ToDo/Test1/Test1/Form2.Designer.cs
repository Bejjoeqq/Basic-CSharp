namespace Test1
{
    partial class Form2
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
            this.btnDaftar = new System.Windows.Forms.Button();
            this.txtDaftar = new System.Windows.Forms.TextBox();
            this.btnKembali = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDaftar
            // 
            this.btnDaftar.Location = new System.Drawing.Point(101, 136);
            this.btnDaftar.Name = "btnDaftar";
            this.btnDaftar.Size = new System.Drawing.Size(75, 23);
            this.btnDaftar.TabIndex = 8;
            this.btnDaftar.Text = "Daftar";
            this.btnDaftar.UseVisualStyleBackColor = true;
            this.btnDaftar.Click += new System.EventHandler(this.btnDaftar_Click);
            // 
            // txtDaftar
            // 
            this.txtDaftar.Location = new System.Drawing.Point(91, 94);
            this.txtDaftar.Name = "txtDaftar";
            this.txtDaftar.Size = new System.Drawing.Size(100, 22);
            this.txtDaftar.TabIndex = 7;
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(143, 190);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(75, 23);
            this.btnKembali.TabIndex = 9;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnDaftar);
            this.Controls.Add(this.txtDaftar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDaftar;
        private System.Windows.Forms.TextBox txtDaftar;
        private System.Windows.Forms.Button btnKembali;
    }
}