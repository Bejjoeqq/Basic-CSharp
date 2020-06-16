namespace DemoRerata
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
            this.teksSkor1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.teksSkor2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.teksSkor3 = new System.Windows.Forms.TextBox();
            this.tombolHitung = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.teksRerata = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Skor 1:";
            // 
            // teksSkor1
            // 
            this.teksSkor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksSkor1.Location = new System.Drawing.Point(60, 14);
            this.teksSkor1.Name = "teksSkor1";
            this.teksSkor1.Size = new System.Drawing.Size(100, 31);
            this.teksSkor1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Skor 2:";
            // 
            // teksSkor2
            // 
            this.teksSkor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksSkor2.Location = new System.Drawing.Point(238, 14);
            this.teksSkor2.Name = "teksSkor2";
            this.teksSkor2.Size = new System.Drawing.Size(100, 31);
            this.teksSkor2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Skor 3:";
            // 
            // teksSkor3
            // 
            this.teksSkor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksSkor3.Location = new System.Drawing.Point(423, 14);
            this.teksSkor3.Name = "teksSkor3";
            this.teksSkor3.Size = new System.Drawing.Size(100, 31);
            this.teksSkor3.TabIndex = 5;
            // 
            // tombolHitung
            // 
            this.tombolHitung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolHitung.Location = new System.Drawing.Point(16, 89);
            this.tombolHitung.Name = "tombolHitung";
            this.tombolHitung.Size = new System.Drawing.Size(507, 41);
            this.tombolHitung.TabIndex = 6;
            this.tombolHitung.Text = "Hitung Rerata Dari Dua Skor Tertinggi";
            this.tombolHitung.UseVisualStyleBackColor = true;
            this.tombolHitung.Click += new System.EventHandler(this.tombolHitung_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rerata:";
            // 
            // teksRerata
            // 
            this.teksRerata.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksRerata.Location = new System.Drawing.Point(209, 149);
            this.teksRerata.Name = "teksRerata";
            this.teksRerata.ReadOnly = true;
            this.teksRerata.Size = new System.Drawing.Size(146, 31);
            this.teksRerata.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 210);
            this.Controls.Add(this.teksRerata);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tombolHitung);
            this.Controls.Add(this.teksSkor3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.teksSkor2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.teksSkor1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Demo Rerata";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teksSkor1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox teksSkor2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox teksSkor3;
        private System.Windows.Forms.Button tombolHitung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox teksRerata;
    }
}

