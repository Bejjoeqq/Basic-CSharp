namespace Aldhiya_2b
{
    partial class frmLatihan
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
            this.lblText1 = new System.Windows.Forms.Label();
            this.lblText2 = new System.Windows.Forms.Label();
            this.lblText3 = new System.Windows.Forms.Label();
            this.lblText4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblText1
            // 
            this.lblText1.AutoSize = true;
            this.lblText1.Location = new System.Drawing.Point(12, 21);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(46, 17);
            this.lblText1.TabIndex = 0;
            this.lblText1.Text = "label1";
            // 
            // lblText2
            // 
            this.lblText2.AutoSize = true;
            this.lblText2.Location = new System.Drawing.Point(12, 81);
            this.lblText2.Name = "lblText2";
            this.lblText2.Size = new System.Drawing.Size(46, 17);
            this.lblText2.TabIndex = 1;
            this.lblText2.Text = "label2";
            // 
            // lblText3
            // 
            this.lblText3.AutoSize = true;
            this.lblText3.Location = new System.Drawing.Point(12, 146);
            this.lblText3.Name = "lblText3";
            this.lblText3.Size = new System.Drawing.Size(46, 17);
            this.lblText3.TabIndex = 2;
            this.lblText3.Text = "label3";
            // 
            // lblText4
            // 
            this.lblText4.AutoSize = true;
            this.lblText4.Location = new System.Drawing.Point(12, 213);
            this.lblText4.Name = "lblText4";
            this.lblText4.Size = new System.Drawing.Size(46, 17);
            this.lblText4.TabIndex = 3;
            this.lblText4.Text = "label4";
            // 
            // frmLatihan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.lblText4);
            this.Controls.Add(this.lblText3);
            this.Controls.Add(this.lblText2);
            this.Controls.Add(this.lblText1);
            this.Name = "frmLatihan";
            this.Text = "Latihan Label";
            this.Load += new System.EventHandler(this.frmLatihan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.Label lblText2;
        private System.Windows.Forms.Label lblText3;
        private System.Windows.Forms.Label lblText4;
    }
}

