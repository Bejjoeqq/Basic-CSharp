namespace PenjelajahanPencarianBiner
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
            this.tombolJelajah = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kotakListInorder = new System.Windows.Forms.ListBox();
            this.kotakListPreorder = new System.Windows.Forms.ListBox();
            this.kotakListPostorder = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tombolJelajah
            // 
            this.tombolJelajah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolJelajah.Location = new System.Drawing.Point(13, 13);
            this.tombolJelajah.Name = "tombolJelajah";
            this.tombolJelajah.Size = new System.Drawing.Size(619, 50);
            this.tombolJelajah.TabIndex = 0;
            this.tombolJelajah.Text = "Tunjukkan Penjelajahan";
            this.tombolJelajah.UseVisualStyleBackColor = true;
            this.tombolJelajah.Click += new System.EventHandler(this.tombolJelajah_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Penjelajahan Inorder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Penjelajahan Preorder";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(455, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Penjelajahan Postorder";
            // 
            // kotakListInorder
            // 
            this.kotakListInorder.FormattingEnabled = true;
            this.kotakListInorder.Location = new System.Drawing.Point(16, 105);
            this.kotakListInorder.Name = "kotakListInorder";
            this.kotakListInorder.Size = new System.Drawing.Size(171, 134);
            this.kotakListInorder.TabIndex = 4;
            // 
            // kotakListPreorder
            // 
            this.kotakListPreorder.FormattingEnabled = true;
            this.kotakListPreorder.Location = new System.Drawing.Point(234, 105);
            this.kotakListPreorder.Name = "kotakListPreorder";
            this.kotakListPreorder.Size = new System.Drawing.Size(171, 134);
            this.kotakListPreorder.TabIndex = 5;
            // 
            // kotakListPostorder
            // 
            this.kotakListPostorder.FormattingEnabled = true;
            this.kotakListPostorder.Location = new System.Drawing.Point(461, 105);
            this.kotakListPostorder.Name = "kotakListPostorder";
            this.kotakListPostorder.Size = new System.Drawing.Size(171, 134);
            this.kotakListPostorder.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 253);
            this.Controls.Add(this.kotakListPostorder);
            this.Controls.Add(this.kotakListPreorder);
            this.Controls.Add(this.kotakListInorder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tombolJelajah);
            this.Name = "Form1";
            this.Text = "Penjelajahan Pencarian Biner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tombolJelajah;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox kotakListInorder;
        private System.Windows.Forms.ListBox kotakListPreorder;
        private System.Windows.Forms.ListBox kotakListPostorder;
    }
}

