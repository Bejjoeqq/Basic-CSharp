namespace AldhiyaTugasPraktekMDI
{
    partial class KLayang_Layang
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
            this.txth1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txts2 = new System.Windows.Forms.TextBox();
            this.txts1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txth1
            // 
            this.txth1.Location = new System.Drawing.Point(120, 190);
            this.txth1.Name = "txth1";
            this.txth1.Size = new System.Drawing.Size(100, 22);
            this.txth1.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Hasil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Sisi 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Sisi 1";
            // 
            // txts2
            // 
            this.txts2.Location = new System.Drawing.Point(120, 92);
            this.txts2.Name = "txts2";
            this.txts2.Size = new System.Drawing.Size(100, 22);
            this.txts2.TabIndex = 19;
            // 
            // txts1
            // 
            this.txts1.Location = new System.Drawing.Point(120, 40);
            this.txts1.Name = "txts1";
            this.txts1.Size = new System.Drawing.Size(100, 22);
            this.txts1.TabIndex = 18;
            // 
            // KLayang_Layang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.txth1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txts2);
            this.Controls.Add(this.txts1);
            this.Name = "KLayang_Layang";
            this.Text = "KLayang_Layang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txth1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txts2;
        private System.Windows.Forms.TextBox txts1;
    }
}