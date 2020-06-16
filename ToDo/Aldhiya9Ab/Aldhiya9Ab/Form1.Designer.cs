namespace Aldhiya9Ab
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
            this.btnBrowser = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtlokasi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(25, 62);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(75, 23);
            this.btnBrowser.TabIndex = 0;
            this.btnBrowser.Text = "Browser";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(178, 62);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(95, 23);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play Music";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.txtPlay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lokasi Sound";
            // 
            // txtlokasi
            // 
            this.txtlokasi.Enabled = false;
            this.txtlokasi.Location = new System.Drawing.Point(160, 12);
            this.txtlokasi.Name = "txtlokasi";
            this.txtlokasi.Size = new System.Drawing.Size(113, 22);
            this.txtlokasi.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(318, 106);
            this.Controls.Add(this.txtlokasi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnBrowser);
            this.Name = "Form1";
            this.Text = "Sound";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtlokasi;
    }
}

