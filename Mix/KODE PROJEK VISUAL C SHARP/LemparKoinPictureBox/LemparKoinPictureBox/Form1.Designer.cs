namespace LemparKoinPictureBox
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
            this.components = new System.ComponentModel.Container();
            this.tombolLempar = new System.Windows.Forms.Button();
            this.tombolKeluar = new System.Windows.Forms.Button();
            this.PB1 = new System.Windows.Forms.PictureBox();
            this.PB2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB2)).BeginInit();
            this.SuspendLayout();
            // 
            // tombolLempar
            // 
            this.tombolLempar.Location = new System.Drawing.Point(44, 232);
            this.tombolLempar.Name = "tombolLempar";
            this.tombolLempar.Size = new System.Drawing.Size(117, 41);
            this.tombolLempar.TabIndex = 0;
            this.tombolLempar.Text = "Lempar Koin";
            this.toolTip1.SetToolTip(this.tombolLempar, "Untuk Melempar Koin");
            this.tombolLempar.UseVisualStyleBackColor = true;
            this.tombolLempar.Click += new System.EventHandler(this.tombolLempar_Click);
            // 
            // tombolKeluar
            // 
            this.tombolKeluar.Location = new System.Drawing.Point(266, 227);
            this.tombolKeluar.Name = "tombolKeluar";
            this.tombolKeluar.Size = new System.Drawing.Size(117, 41);
            this.tombolKeluar.TabIndex = 1;
            this.tombolKeluar.Text = "Keluar";
            this.tombolKeluar.UseVisualStyleBackColor = true;
            this.tombolKeluar.Click += new System.EventHandler(this.tombolKeluar_Click);
            // 
            // PB1
            // 
            this.PB1.Image = global::LemparKoinPictureBox.Resource1.head;
            this.PB1.Location = new System.Drawing.Point(13, 13);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(206, 208);
            this.PB1.TabIndex = 2;
            this.PB1.TabStop = false;
            // 
            // PB2
            // 
            this.PB2.Image = global::LemparKoinPictureBox.Resource1.tail2;
            this.PB2.Location = new System.Drawing.Point(226, 13);
            this.PB2.Name = "PB2";
            this.PB2.Size = new System.Drawing.Size(204, 208);
            this.PB2.TabIndex = 3;
            this.PB2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 285);
            this.Controls.Add(this.PB2);
            this.Controls.Add(this.PB1);
            this.Controls.Add(this.tombolKeluar);
            this.Controls.Add(this.tombolLempar);
            this.Name = "Form1";
            this.Text = "Melempar Koin PictureBox";
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tombolLempar;
        private System.Windows.Forms.Button tombolKeluar;
        private System.Windows.Forms.PictureBox PB1;
        private System.Windows.Forms.PictureBox PB2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

