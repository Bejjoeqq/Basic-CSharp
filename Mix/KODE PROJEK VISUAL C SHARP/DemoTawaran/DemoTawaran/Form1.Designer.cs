namespace DemoTawaran
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
            this.tombolEvaluasi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.teksPersen = new System.Windows.Forms.TextBox();
            this.teksDiskon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.teksTawaranTerbaik = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tombolEvaluasi
            // 
            this.tombolEvaluasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolEvaluasi.Location = new System.Drawing.Point(13, 26);
            this.tombolEvaluasi.Name = "tombolEvaluasi";
            this.tombolEvaluasi.Size = new System.Drawing.Size(259, 48);
            this.tombolEvaluasi.TabIndex = 0;
            this.tombolEvaluasi.Text = "Evaluasi Penawaran";
            this.tombolEvaluasi.UseVisualStyleBackColor = true;
            this.tombolEvaluasi.Click += new System.EventHandler(this.tombolEvaluasi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "50 % Vol Lebih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "35% Diskon";
            // 
            // teksPersen
            // 
            this.teksPersen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksPersen.Location = new System.Drawing.Point(97, 106);
            this.teksPersen.Name = "teksPersen";
            this.teksPersen.ReadOnly = true;
            this.teksPersen.Size = new System.Drawing.Size(175, 29);
            this.teksPersen.TabIndex = 3;
            // 
            // teksDiskon
            // 
            this.teksDiskon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksDiskon.Location = new System.Drawing.Point(97, 146);
            this.teksDiskon.Name = "teksDiskon";
            this.teksDiskon.ReadOnly = true;
            this.teksDiskon.Size = new System.Drawing.Size(175, 29);
            this.teksDiskon.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Biaya Per Ons";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tawaran Terbaik";
            // 
            // teksTawaranTerbaik
            // 
            this.teksTawaranTerbaik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksTawaranTerbaik.Location = new System.Drawing.Point(16, 221);
            this.teksTawaranTerbaik.Name = "teksTawaranTerbaik";
            this.teksTawaranTerbaik.ReadOnly = true;
            this.teksTawaranTerbaik.Size = new System.Drawing.Size(256, 29);
            this.teksTawaranTerbaik.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.teksTawaranTerbaik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.teksDiskon);
            this.Controls.Add(this.teksPersen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tombolEvaluasi);
            this.Name = "Form1";
            this.Text = "Demo Tawaran";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tombolEvaluasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox teksPersen;
        private System.Windows.Forms.TextBox teksDiskon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox teksTawaranTerbaik;
    }
}

