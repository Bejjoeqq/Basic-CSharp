namespace AldhiyaSMS
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
            this.txtHP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rchPesan = new System.Windows.Forms.RichTextBox();
            this.btnDC = new System.Windows.Forms.Button();
            this.btnKirim = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHP
            // 
            this.txtHP.Location = new System.Drawing.Point(108, 12);
            this.txtHP.Name = "txtHP";
            this.txtHP.Size = new System.Drawing.Size(162, 22);
            this.txtHP.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "No.HP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pesan";
            // 
            // rchPesan
            // 
            this.rchPesan.Location = new System.Drawing.Point(108, 46);
            this.rchPesan.Name = "rchPesan";
            this.rchPesan.Size = new System.Drawing.Size(162, 150);
            this.rchPesan.TabIndex = 3;
            this.rchPesan.Text = "";
            // 
            // btnDC
            // 
            this.btnDC.Location = new System.Drawing.Point(15, 202);
            this.btnDC.Name = "btnDC";
            this.btnDC.Size = new System.Drawing.Size(115, 23);
            this.btnDC.TabIndex = 4;
            this.btnDC.Text = "Disconnect";
            this.btnDC.UseVisualStyleBackColor = true;
            this.btnDC.Click += new System.EventHandler(this.btnDC_Click);
            // 
            // btnKirim
            // 
            this.btnKirim.Location = new System.Drawing.Point(195, 202);
            this.btnKirim.Name = "btnKirim";
            this.btnKirim.Size = new System.Drawing.Size(75, 23);
            this.btnKirim.TabIndex = 5;
            this.btnKirim.Text = "Kirim";
            this.btnKirim.UseVisualStyleBackColor = true;
            this.btnKirim.Click += new System.EventHandler(this.btnKirim_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(15, 173);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(282, 238);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnKirim);
            this.Controls.Add(this.btnDC);
            this.Controls.Add(this.rchPesan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rchPesan;
        private System.Windows.Forms.Button btnDC;
        private System.Windows.Forms.Button btnKirim;
        private System.Windows.Forms.Button btnClose;
    }
}

