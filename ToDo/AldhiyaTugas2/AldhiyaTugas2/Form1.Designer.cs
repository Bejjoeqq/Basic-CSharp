namespace AldhiyaTugas2
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
            this.lblNama = new System.Windows.Forms.Label();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.cboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLabel = new System.Windows.Forms.Button();
            this.btnText = new System.Windows.Forms.Button();
            this.btnCombo = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(12, 13);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(98, 17);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "SMK TELKOM";
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(116, 10);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(140, 88);
            this.txtBox.TabIndex = 1;
            // 
            // cboBox
            // 
            this.cboBox.FormattingEnabled = true;
            this.cboBox.Items.AddRange(new object[] {
            "Senin",
            "Selasa",
            "Rabu"});
            this.cboBox.Location = new System.Drawing.Point(310, 10);
            this.cboBox.Name = "cboBox";
            this.cboBox.Size = new System.Drawing.Size(121, 24);
            this.cboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hari :";
            // 
            // btnLabel
            // 
            this.btnLabel.Location = new System.Drawing.Point(15, 144);
            this.btnLabel.Name = "btnLabel";
            this.btnLabel.Size = new System.Drawing.Size(95, 23);
            this.btnLabel.TabIndex = 4;
            this.btnLabel.Text = "Get Label";
            this.btnLabel.UseVisualStyleBackColor = true;
            this.btnLabel.Click += new System.EventHandler(this.btnLabel_Click);
            // 
            // btnText
            // 
            this.btnText.Location = new System.Drawing.Point(130, 144);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(75, 23);
            this.btnText.TabIndex = 5;
            this.btnText.Text = "Text Box";
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // btnCombo
            // 
            this.btnCombo.Location = new System.Drawing.Point(239, 144);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(75, 23);
            this.btnCombo.TabIndex = 6;
            this.btnCombo.Text = "Combo Box";
            this.btnCombo.UseVisualStyleBackColor = true;
            this.btnCombo.Click += new System.EventHandler(this.btnCombo_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(346, 144);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lstBox
            // 
            this.lstBox.FormattingEnabled = true;
            this.lstBox.ItemHeight = 16;
            this.lstBox.Location = new System.Drawing.Point(15, 193);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(416, 84);
            this.lstBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 316);
            this.Controls.Add(this.lstBox);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCombo);
            this.Controls.Add(this.btnText);
            this.Controls.Add(this.btnLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboBox);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.lblNama);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.ComboBox cboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLabel;
        private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.Button btnCombo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstBox;
    }
}

