using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MadeByBejjo
{
    public partial class SecretForm : Form
    {
        public SecretForm()
        {
            InitializeComponent();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SecretForm_Load(object sender, EventArgs e)
        {
            rdo1.Text = "Putih";
            rdo2.Text = "Hitam";
        }
        int a=0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (rdo2.Checked && rdo2.Text == "Hitam")
            {
                rdo1.Text = "A";
                rdo2.Text = "Z";
            }
            else if (rdo1.Checked && rdo1.Text == "Putih")
            {
                a++;
                MessageBox.Show("Salah");
            }
            else if (rdo1.Checked && rdo1.Text == "A")
            {
                rdo1.Text = "10";
                rdo2.Text = "15";
            }
            else if (rdo2.Checked && rdo2.Text == "Z")
            {
                a++;
                MessageBox.Show("Salah");
            }
            else if (rdo1.Checked && rdo1.Text == "10")
            {
                a++;
                MessageBox.Show("Salah");
            }
            else if (rdo2.Checked && rdo2.Text == "15")
            {
                rdo1.Text = "$";
                rdo2.Text = "*";
            }
            else if (rdo1.Checked && rdo1.Text == "$")
            {
                rdo1.Enabled = false;
                rdo2.Enabled = false;
                textBox1.Enabled = true;
                rdo1.Text = "Masukkan Ke kotak Diatas";
                rdo2.Text = "ASDW";
            }
            else if (rdo2.Checked && rdo2.Text == "*")
            {
                a++;
                MessageBox.Show("Salah");
            }
            else if (textBox1.Text == "ASDW")
            {
                button1.Enabled = false;
                textBox1.Hide();
                MessageBox.Show("Ingat");
                this.Close();
            }

            if (a == 0)
            {
            }
            else if (a == 1)
            {
                MessageBox.Show("Kesempatan Salah 1 Lagi");
            }
            else if (a == 2)
            {
                MessageBox.Show("Kesempatan Salah Habis");
            }
            else if (a == 3)
            {
                MessageBox.Show("Semua Kesempatan Habis");
                button1.Enabled = false;
            }
        }
        private void SecretForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
