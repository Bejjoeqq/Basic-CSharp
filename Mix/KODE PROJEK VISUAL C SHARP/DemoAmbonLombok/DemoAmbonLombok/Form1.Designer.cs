namespace DemoAmbonLombok
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
            this.tombolAmbon = new System.Windows.Forms.Button();
            this.tombolLombok = new System.Windows.Forms.Button();
            this.listKeluaran = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tombolAmbon
            // 
            this.tombolAmbon.Location = new System.Drawing.Point(13, 13);
            this.tombolAmbon.Name = "tombolAmbon";
            this.tombolAmbon.Size = new System.Drawing.Size(118, 40);
            this.tombolAmbon.TabIndex = 0;
            this.tombolAmbon.Text = "Ambon";
            this.tombolAmbon.UseVisualStyleBackColor = true;
            this.tombolAmbon.Click += new System.EventHandler(this.tombolAmbon_Click);
            // 
            // tombolLombok
            // 
            this.tombolLombok.Location = new System.Drawing.Point(154, 13);
            this.tombolLombok.Name = "tombolLombok";
            this.tombolLombok.Size = new System.Drawing.Size(118, 40);
            this.tombolLombok.TabIndex = 1;
            this.tombolLombok.Text = "Lombok";
            this.tombolLombok.UseVisualStyleBackColor = true;
            this.tombolLombok.Click += new System.EventHandler(this.tombolLombok_Click);
            // 
            // listKeluaran
            // 
            this.listKeluaran.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listKeluaran.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listKeluaran.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listKeluaran.FormattingEnabled = true;
            this.listKeluaran.ItemHeight = 20;
            this.listKeluaran.Location = new System.Drawing.Point(13, 91);
            this.listKeluaran.Name = "listKeluaran";
            this.listKeluaran.Size = new System.Drawing.Size(259, 120);
            this.listKeluaran.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 225);
            this.Controls.Add(this.listKeluaran);
            this.Controls.Add(this.tombolLombok);
            this.Controls.Add(this.tombolAmbon);
            this.Name = "Form1";
            this.Text = "Demo Ambon Lombok";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tombolAmbon;
        private System.Windows.Forms.Button tombolLombok;
        private System.Windows.Forms.ListBox listKeluaran;
    }
}

