namespace LoopWhile
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
            this.tombolTampil = new System.Windows.Forms.Button();
            this.listAngka = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tombolTampil
            // 
            this.tombolTampil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolTampil.Location = new System.Drawing.Point(13, 24);
            this.tombolTampil.Name = "tombolTampil";
            this.tombolTampil.Size = new System.Drawing.Size(205, 52);
            this.tombolTampil.TabIndex = 0;
            this.tombolTampil.Text = "Tampilkan";
            this.tombolTampil.UseVisualStyleBackColor = true;
            this.tombolTampil.Click += new System.EventHandler(this.tombolTampil_Click);
            // 
            // listAngka
            // 
            this.listAngka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listAngka.FormattingEnabled = true;
            this.listAngka.ItemHeight = 20;
            this.listAngka.Location = new System.Drawing.Point(13, 98);
            this.listAngka.Name = "listAngka";
            this.listAngka.ScrollAlwaysVisible = true;
            this.listAngka.Size = new System.Drawing.Size(205, 124);
            this.listAngka.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 238);
            this.Controls.Add(this.listAngka);
            this.Controls.Add(this.tombolTampil);
            this.Name = "Form1";
            this.Text = "Demo Loop While";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tombolTampil;
        private System.Windows.Forms.ListBox listAngka;
    }
}

