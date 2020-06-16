namespace Aldhiya9A
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNim = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtStudi = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "DATA MAHASISWA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Program Studi";
            // 
            // txtNim
            // 
            this.txtNim.Enabled = false;
            this.txtNim.Location = new System.Drawing.Point(194, 85);
            this.txtNim.Name = "txtNim";
            this.txtNim.Size = new System.Drawing.Size(144, 22);
            this.txtNim.TabIndex = 4;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(194, 132);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(144, 22);
            this.txtNama.TabIndex = 5;
            // 
            // txtStudi
            // 
            this.txtStudi.Location = new System.Drawing.Point(194, 175);
            this.txtStudi.Name = "txtStudi";
            this.txtStudi.Size = new System.Drawing.Size(144, 22);
            this.txtStudi.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(11, 252);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(327, 152);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(223, 212);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(115, 23);
            this.btnData.TabIndex = 8;
            this.btnData.Text = "Entry Data";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 416);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtStudi);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtNim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNim;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtStudi;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnData;
    }
}

