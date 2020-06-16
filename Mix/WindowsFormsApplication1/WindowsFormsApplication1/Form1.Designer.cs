namespace WindowsFormsApplication1
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
            this.lblNama = new System.Windows.Forms.Label();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btnTombol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(23, 50);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(45, 17);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama";
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(96, 47);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(100, 22);
            this.txtBox.TabIndex = 1;
            // 
            // btnTombol
            // 
            this.btnTombol.Location = new System.Drawing.Point(250, 47);
            this.btnTombol.Name = "btnTombol";
            this.btnTombol.Size = new System.Drawing.Size(75, 23);
            this.btnTombol.TabIndex = 2;
            this.btnTombol.Text = "Submit";
            this.btnTombol.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 353);
            this.Controls.Add(this.btnTombol);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.lblNama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button btnTombol;
    }
}

