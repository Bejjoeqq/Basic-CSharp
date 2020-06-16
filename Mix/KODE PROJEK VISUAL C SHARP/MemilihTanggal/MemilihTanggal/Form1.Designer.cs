namespace MemilihTanggal
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
            this.DTP1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.DTP2 = new System.Windows.Forms.DateTimePicker();
            this.tombolTampil = new System.Windows.Forms.Button();
            this.teksHasil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pilihlah Sebuah Tanggal:";
            // 
            // DTP1
            // 
            this.DTP1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP1.Location = new System.Drawing.Point(15, 35);
            this.DTP1.Name = "DTP1";
            this.DTP1.Size = new System.Drawing.Size(274, 22);
            this.DTP1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pilihlah Tanggal Lain:";
            // 
            // DTP2
            // 
            this.DTP2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP2.Location = new System.Drawing.Point(15, 95);
            this.DTP2.Name = "DTP2";
            this.DTP2.Size = new System.Drawing.Size(274, 22);
            this.DTP2.TabIndex = 3;
            // 
            // tombolTampil
            // 
            this.tombolTampil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolTampil.Location = new System.Drawing.Point(15, 146);
            this.tombolTampil.Name = "tombolTampil";
            this.tombolTampil.Size = new System.Drawing.Size(271, 49);
            this.tombolTampil.TabIndex = 4;
            this.tombolTampil.Text = "Tampilkan";
            this.tombolTampil.UseVisualStyleBackColor = true;
            this.tombolTampil.Click += new System.EventHandler(this.tombolTampil_Click);
            // 
            // teksHasil
            // 
            this.teksHasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksHasil.Location = new System.Drawing.Point(15, 216);
            this.teksHasil.Multiline = true;
            this.teksHasil.Name = "teksHasil";
            this.teksHasil.ReadOnly = true;
            this.teksHasil.Size = new System.Drawing.Size(271, 93);
            this.teksHasil.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 329);
            this.Controls.Add(this.teksHasil);
            this.Controls.Add(this.tombolTampil);
            this.Controls.Add(this.DTP2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DTP1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Memilih Tanggal ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DTP1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DTP2;
        private System.Windows.Forms.Button tombolTampil;
        private System.Windows.Forms.TextBox teksHasil;
    }
}

