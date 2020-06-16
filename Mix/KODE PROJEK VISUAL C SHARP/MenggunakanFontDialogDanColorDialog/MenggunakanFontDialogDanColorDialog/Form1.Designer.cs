namespace MenggunakanFontDialogDanColorDialog
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
            this.tombolDemoColorDialog = new System.Windows.Forms.Button();
            this.tombolDemoFontDialog = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Demo FontDialog dan ColorDialog";
            // 
            // tombolDemoColorDialog
            // 
            this.tombolDemoColorDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolDemoColorDialog.Location = new System.Drawing.Point(18, 75);
            this.tombolDemoColorDialog.Name = "tombolDemoColorDialog";
            this.tombolDemoColorDialog.Size = new System.Drawing.Size(169, 51);
            this.tombolDemoColorDialog.TabIndex = 1;
            this.tombolDemoColorDialog.Text = "Demo ColorDialog";
            this.tombolDemoColorDialog.UseVisualStyleBackColor = true;
            this.tombolDemoColorDialog.Click += new System.EventHandler(this.tombolDemoColorDialog_Click);
            // 
            // tombolDemoFontDialog
            // 
            this.tombolDemoFontDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolDemoFontDialog.Location = new System.Drawing.Point(221, 75);
            this.tombolDemoFontDialog.Name = "tombolDemoFontDialog";
            this.tombolDemoFontDialog.Size = new System.Drawing.Size(197, 51);
            this.tombolDemoFontDialog.TabIndex = 2;
            this.tombolDemoFontDialog.Text = "Demo FontDialog";
            this.tombolDemoFontDialog.UseVisualStyleBackColor = true;
            this.tombolDemoFontDialog.Click += new System.EventHandler(this.tombolDemoFontDialog_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Color = System.Drawing.SystemColors.ControlText;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 154);
            this.Controls.Add(this.tombolDemoFontDialog);
            this.Controls.Add(this.tombolDemoColorDialog);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Menggunakan FontDialog dan ColorDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tombolDemoColorDialog;
        private System.Windows.Forms.Button tombolDemoFontDialog;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

