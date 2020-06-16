namespace KalkulatorMenuKafe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.RBWhite = new System.Windows.Forms.RadioButton();
            this.RBWholeWhite = new System.Windows.Forms.RadioButton();
            this.RBTidak = new System.Windows.Forms.RadioButton();
            this.RBRegular = new System.Windows.Forms.RadioButton();
            this.RBCappuccino = new System.Windows.Forms.RadioButton();
            this.RBCafe = new System.Windows.Forms.RadioButton();
            this.CBCream = new System.Windows.Forms.CheckBox();
            this.CBButter = new System.Windows.Forms.CheckBox();
            this.CBBlueberry = new System.Windows.Forms.CheckBox();
            this.CBRaspberry = new System.Windows.Forms.CheckBox();
            this.CBPeach = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.teksSubtotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.teksPajak = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.teksTotal = new System.Windows.Forms.TextBox();
            this.tombolHitung = new System.Windows.Forms.Button();
            this.tombolReset = new System.Windows.Forms.Button();
            this.tombolKeluar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minerva", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kafe Kopi dan Bagel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBWholeWhite);
            this.groupBox1.Controls.Add(this.RBWhite);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 74);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pilih Bagel";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RBCafe);
            this.groupBox2.Controls.Add(this.RBCappuccino);
            this.groupBox2.Controls.Add(this.RBRegular);
            this.groupBox2.Controls.Add(this.RBTidak);
            this.groupBox2.Location = new System.Drawing.Point(189, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 122);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mau Kopi?";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CBPeach);
            this.groupBox3.Controls.Add(this.CBRaspberry);
            this.groupBox3.Controls.Add(this.CBBlueberry);
            this.groupBox3.Controls.Add(this.CBButter);
            this.groupBox3.Controls.Add(this.CBCream);
            this.groupBox3.Location = new System.Drawing.Point(12, 144);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(159, 143);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pilih Topping";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.teksTotal);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.teksPajak);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.teksSubtotal);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(189, 192);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(186, 204);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Harga";
            // 
            // RBWhite
            // 
            this.RBWhite.AutoSize = true;
            this.RBWhite.Location = new System.Drawing.Point(7, 20);
            this.RBWhite.Name = "RBWhite";
            this.RBWhite.Size = new System.Drawing.Size(112, 17);
            this.RBWhite.TabIndex = 0;
            this.RBWhite.TabStop = true;
            this.RBWhite.Text = "White (Rp. 12500)";
            this.RBWhite.UseVisualStyleBackColor = true;
            // 
            // RBWholeWhite
            // 
            this.RBWholeWhite.AutoSize = true;
            this.RBWholeWhite.Location = new System.Drawing.Point(7, 43);
            this.RBWholeWhite.Name = "RBWholeWhite";
            this.RBWholeWhite.Size = new System.Drawing.Size(146, 17);
            this.RBWholeWhite.TabIndex = 1;
            this.RBWholeWhite.TabStop = true;
            this.RBWholeWhite.Text = "Whole White (Rp. 15000)";
            this.RBWholeWhite.UseVisualStyleBackColor = true;
            // 
            // RBTidak
            // 
            this.RBTidak.AutoSize = true;
            this.RBTidak.Location = new System.Drawing.Point(7, 20);
            this.RBTidak.Name = "RBTidak";
            this.RBTidak.Size = new System.Drawing.Size(52, 17);
            this.RBTidak.TabIndex = 0;
            this.RBTidak.TabStop = true;
            this.RBTidak.Text = "Tidak";
            this.RBTidak.UseVisualStyleBackColor = true;
            // 
            // RBRegular
            // 
            this.RBRegular.AutoSize = true;
            this.RBRegular.Location = new System.Drawing.Point(7, 43);
            this.RBRegular.Name = "RBRegular";
            this.RBRegular.Size = new System.Drawing.Size(134, 17);
            this.RBRegular.TabIndex = 1;
            this.RBRegular.TabStop = true;
            this.RBRegular.Text = "Kopi Biasa (Rp. 12500)";
            this.RBRegular.UseVisualStyleBackColor = true;
            // 
            // RBCappuccino
            // 
            this.RBCappuccino.AutoSize = true;
            this.RBCappuccino.Location = new System.Drawing.Point(7, 66);
            this.RBCappuccino.Name = "RBCappuccino";
            this.RBCappuccino.Size = new System.Drawing.Size(138, 17);
            this.RBCappuccino.TabIndex = 2;
            this.RBCappuccino.TabStop = true;
            this.RBCappuccino.Text = "Cappuccino (Rp.20000)";
            this.RBCappuccino.UseVisualStyleBackColor = true;
            // 
            // RBCafe
            // 
            this.RBCafe.AutoSize = true;
            this.RBCafe.Location = new System.Drawing.Point(7, 89);
            this.RBCafe.Name = "RBCafe";
            this.RBCafe.Size = new System.Drawing.Size(134, 17);
            this.RBCafe.TabIndex = 3;
            this.RBCafe.TabStop = true;
            this.RBCafe.Text = "Cafe au lait (Rp.17500)";
            this.RBCafe.UseVisualStyleBackColor = true;
            // 
            // CBCream
            // 
            this.CBCream.AutoSize = true;
            this.CBCream.Location = new System.Drawing.Point(7, 20);
            this.CBCream.Name = "CBCream";
            this.CBCream.Size = new System.Drawing.Size(148, 17);
            this.CBCream.TabIndex = 0;
            this.CBCream.Text = "Cream Cheese (Rp. 5000)";
            this.CBCream.UseVisualStyleBackColor = true;
            // 
            // CBButter
            // 
            this.CBButter.AutoSize = true;
            this.CBButter.Location = new System.Drawing.Point(7, 43);
            this.CBButter.Name = "CBButter";
            this.CBButter.Size = new System.Drawing.Size(107, 17);
            this.CBButter.TabIndex = 1;
            this.CBButter.Text = "Butter (Rp. 2500)";
            this.CBButter.UseVisualStyleBackColor = true;
            // 
            // CBBlueberry
            // 
            this.CBBlueberry.AutoSize = true;
            this.CBBlueberry.Location = new System.Drawing.Point(7, 66);
            this.CBBlueberry.Name = "CBBlueberry";
            this.CBBlueberry.Size = new System.Drawing.Size(145, 17);
            this.CBBlueberry.TabIndex = 2;
            this.CBBlueberry.Text = "Blueberry Jam (Rp. 7500)";
            this.CBBlueberry.UseVisualStyleBackColor = true;
            // 
            // CBRaspberry
            // 
            this.CBRaspberry.AutoSize = true;
            this.CBRaspberry.Location = new System.Drawing.Point(7, 89);
            this.CBRaspberry.Name = "CBRaspberry";
            this.CBRaspberry.Size = new System.Drawing.Size(149, 17);
            this.CBRaspberry.TabIndex = 3;
            this.CBRaspberry.Text = "Raspberry Jam (Rp. 7500)";
            this.CBRaspberry.UseVisualStyleBackColor = true;
            // 
            // CBPeach
            // 
            this.CBPeach.AutoSize = true;
            this.CBPeach.Location = new System.Drawing.Point(7, 112);
            this.CBPeach.Name = "CBPeach";
            this.CBPeach.Size = new System.Drawing.Size(133, 17);
            this.CBPeach.TabIndex = 4;
            this.CBPeach.Text = "Peach Jelly (Rp. 7500)";
            this.CBPeach.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "SubTotal:";
            // 
            // teksSubtotal
            // 
            this.teksSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksSubtotal.Location = new System.Drawing.Point(10, 41);
            this.teksSubtotal.Name = "teksSubtotal";
            this.teksSubtotal.ReadOnly = true;
            this.teksSubtotal.Size = new System.Drawing.Size(170, 29);
            this.teksSubtotal.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pajak:";
            // 
            // teksPajak
            // 
            this.teksPajak.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksPajak.Location = new System.Drawing.Point(10, 98);
            this.teksPajak.Name = "teksPajak";
            this.teksPajak.ReadOnly = true;
            this.teksPajak.Size = new System.Drawing.Size(170, 29);
            this.teksPajak.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total:";
            // 
            // teksTotal
            // 
            this.teksTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teksTotal.Location = new System.Drawing.Point(10, 156);
            this.teksTotal.Name = "teksTotal";
            this.teksTotal.ReadOnly = true;
            this.teksTotal.Size = new System.Drawing.Size(170, 29);
            this.teksTotal.TabIndex = 5;
            // 
            // tombolHitung
            // 
            this.tombolHitung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolHitung.Location = new System.Drawing.Point(12, 295);
            this.tombolHitung.Name = "tombolHitung";
            this.tombolHitung.Size = new System.Drawing.Size(159, 37);
            this.tombolHitung.TabIndex = 5;
            this.tombolHitung.Text = "Hitung Total";
            this.tombolHitung.UseVisualStyleBackColor = true;
            this.tombolHitung.Click += new System.EventHandler(this.tombolHitung_Click);
            // 
            // tombolReset
            // 
            this.tombolReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolReset.Location = new System.Drawing.Point(12, 338);
            this.tombolReset.Name = "tombolReset";
            this.tombolReset.Size = new System.Drawing.Size(159, 34);
            this.tombolReset.TabIndex = 6;
            this.tombolReset.Text = "Reset Form";
            this.tombolReset.UseVisualStyleBackColor = true;
            this.tombolReset.Click += new System.EventHandler(this.tombolReset_Click);
            // 
            // tombolKeluar
            // 
            this.tombolKeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tombolKeluar.Location = new System.Drawing.Point(12, 378);
            this.tombolKeluar.Name = "tombolKeluar";
            this.tombolKeluar.Size = new System.Drawing.Size(159, 34);
            this.tombolKeluar.TabIndex = 7;
            this.tombolKeluar.Text = "Keluar";
            this.tombolKeluar.UseVisualStyleBackColor = true;
            this.tombolKeluar.Click += new System.EventHandler(this.tombolKeluar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 418);
            this.Controls.Add(this.tombolKeluar);
            this.Controls.Add(this.tombolReset);
            this.Controls.Add(this.tombolHitung);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kalkulator Menu Kafe";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RBWholeWhite;
        private System.Windows.Forms.RadioButton RBWhite;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RBCafe;
        private System.Windows.Forms.RadioButton RBCappuccino;
        private System.Windows.Forms.RadioButton RBRegular;
        private System.Windows.Forms.RadioButton RBTidak;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox CBPeach;
        private System.Windows.Forms.CheckBox CBRaspberry;
        private System.Windows.Forms.CheckBox CBBlueberry;
        private System.Windows.Forms.CheckBox CBButter;
        private System.Windows.Forms.CheckBox CBCream;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox teksTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox teksPajak;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox teksSubtotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tombolHitung;
        private System.Windows.Forms.Button tombolReset;
        private System.Windows.Forms.Button tombolKeluar;
    }
}

