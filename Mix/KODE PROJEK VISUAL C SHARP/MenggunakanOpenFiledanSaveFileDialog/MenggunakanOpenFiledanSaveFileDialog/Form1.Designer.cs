namespace MenggunakanOpenFiledanSaveFileDialog
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.teksPath = new System.Windows.Forms.TextBox();
            this.tombolBuka = new System.Windows.Forms.Button();
            this.tombolSimpan = new System.Windows.Forms.Button();
            this.kotakTeks = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // teksPath
            // 
            this.teksPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksPath.Location = new System.Drawing.Point(13, 13);
            this.teksPath.Name = "teksPath";
            this.teksPath.Size = new System.Drawing.Size(203, 26);
            this.teksPath.TabIndex = 0;
            // 
            // tombolBuka
            // 
            this.tombolBuka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolBuka.Location = new System.Drawing.Point(13, 57);
            this.tombolBuka.Name = "tombolBuka";
            this.tombolBuka.Size = new System.Drawing.Size(203, 42);
            this.tombolBuka.TabIndex = 1;
            this.tombolBuka.Text = "Buka File";
            this.tombolBuka.UseVisualStyleBackColor = true;
            this.tombolBuka.Click += new System.EventHandler(this.tombolBuka_Click);
            // 
            // tombolSimpan
            // 
            this.tombolSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolSimpan.Location = new System.Drawing.Point(12, 208);
            this.tombolSimpan.Name = "tombolSimpan";
            this.tombolSimpan.Size = new System.Drawing.Size(203, 42);
            this.tombolSimpan.TabIndex = 2;
            this.tombolSimpan.Text = "Simpan File";
            this.tombolSimpan.UseVisualStyleBackColor = true;
            this.tombolSimpan.Click += new System.EventHandler(this.tombolSimpan_Click);
            // 
            // kotakTeks
            // 
            this.kotakTeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kotakTeks.Location = new System.Drawing.Point(237, 13);
            this.kotakTeks.Multiline = true;
            this.kotakTeks.Name = "kotakTeks";
            this.kotakTeks.ReadOnly = true;
            this.kotakTeks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.kotakTeks.Size = new System.Drawing.Size(203, 237);
            this.kotakTeks.TabIndex = 3;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 262);
            this.Controls.Add(this.kotakTeks);
            this.Controls.Add(this.tombolSimpan);
            this.Controls.Add(this.tombolBuka);
            this.Controls.Add(this.teksPath);
            this.Name = "Form1";
            this.Text = "Menggunakan OpenFile dan SaveFile Dialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox teksPath;
        private System.Windows.Forms.Button tombolBuka;
        private System.Windows.Forms.Button tombolSimpan;
        private System.Windows.Forms.TextBox kotakTeks;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

