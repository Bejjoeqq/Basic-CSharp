namespace EventTextChanged
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
            this.teksNilai = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // teksNilai
            // 
            this.teksNilai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksNilai.Location = new System.Drawing.Point(13, 31);
            this.teksNilai.Name = "teksNilai";
            this.teksNilai.Size = new System.Drawing.Size(281, 29);
            this.teksNilai.TabIndex = 0;
            this.teksNilai.TextChanged += new System.EventHandler(this.teksNilai_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 106);
            this.Controls.Add(this.teksNilai);
            this.Name = "Form1";
            this.Text = "Penggunaan Event TextChanged";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox teksNilai;
    }
}

