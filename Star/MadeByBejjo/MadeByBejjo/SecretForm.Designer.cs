namespace MadeByBejjo
{
    partial class SecretForm
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
            this.rdo1 = new System.Windows.Forms.RadioButton();
            this.rdo2 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hint Username Dan Password";
            // 
            // rdo1
            // 
            this.rdo1.AutoSize = true;
            this.rdo1.Location = new System.Drawing.Point(12, 193);
            this.rdo1.Name = "rdo1";
            this.rdo1.Size = new System.Drawing.Size(59, 21);
            this.rdo1.TabIndex = 1;
            this.rdo1.TabStop = true;
            this.rdo1.Text = "AW1";
            this.rdo1.UseVisualStyleBackColor = true;
            this.rdo1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdo2
            // 
            this.rdo2.AutoSize = true;
            this.rdo2.Location = new System.Drawing.Point(12, 220);
            this.rdo2.Name = "rdo2";
            this.rdo2.Size = new System.Drawing.Size(59, 21);
            this.rdo2.TabIndex = 2;
            this.rdo2.TabStop = true;
            this.rdo2.Text = "AW2";
            this.rdo2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 42);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 145);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(245, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SecretForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rdo2);
            this.Controls.Add(this.rdo1);
            this.Controls.Add(this.label1);
            this.Name = "SecretForm";
            this.Text = "SecretForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SecretForm_FormClosing);
            this.Load += new System.EventHandler(this.SecretForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdo1;
        private System.Windows.Forms.RadioButton rdo2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}