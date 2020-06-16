namespace StatemenIfDenganOperatorLogikal
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
            this.teksJawaban = new System.Windows.Forms.TextBox();
            this.tombolEvaluasi = new System.Windows.Forms.Button();
            this.teksHasil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Berapa banyak propinsi di Indonesia:";
            // 
            // teksJawaban
            // 
            this.teksJawaban.BackColor = System.Drawing.Color.MistyRose;
            this.teksJawaban.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksJawaban.Location = new System.Drawing.Point(200, 24);
            this.teksJawaban.Name = "teksJawaban";
            this.teksJawaban.Size = new System.Drawing.Size(201, 29);
            this.teksJawaban.TabIndex = 1;
            // 
            // tombolEvaluasi
            // 
            this.tombolEvaluasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolEvaluasi.Location = new System.Drawing.Point(15, 89);
            this.tombolEvaluasi.Name = "tombolEvaluasi";
            this.tombolEvaluasi.Size = new System.Drawing.Size(386, 49);
            this.tombolEvaluasi.TabIndex = 2;
            this.tombolEvaluasi.Text = "Evaluasi Jawaban";
            this.tombolEvaluasi.UseVisualStyleBackColor = true;
            this.tombolEvaluasi.Click += new System.EventHandler(this.tombolEvaluasi_Click);
            // 
            // teksHasil
            // 
            this.teksHasil.BackColor = System.Drawing.SystemColors.Menu;
            this.teksHasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksHasil.Location = new System.Drawing.Point(15, 169);
            this.teksHasil.Multiline = true;
            this.teksHasil.Name = "teksHasil";
            this.teksHasil.ReadOnly = true;
            this.teksHasil.Size = new System.Drawing.Size(386, 58);
            this.teksHasil.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 243);
            this.Controls.Add(this.teksHasil);
            this.Controls.Add(this.tombolEvaluasi);
            this.Controls.Add(this.teksJawaban);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Statemen If Dengan Operator Logikal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox teksJawaban;
        private System.Windows.Forms.Button tombolEvaluasi;
        private System.Windows.Forms.TextBox teksHasil;
    }
}

