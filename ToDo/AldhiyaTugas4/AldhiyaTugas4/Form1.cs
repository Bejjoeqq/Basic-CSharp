using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AldhiyaTugas4
{
    public partial class Form1 : Form
    {
        double bagi, kali, kurang, tambah, hasil, a;
        int c;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtHasil.Text == "0")
            {
                txtHasil.Clear();
            }
            if (txtHasil.Text == "/")
            {
                txtHasil.Clear();
            }
            if (txtHasil.Text == "*")
            {
                txtHasil.Clear();
            }
            if (txtHasil.Text == "-")
            {
                txtHasil.Clear();
            }
            if (txtHasil.Text == "+")
            {
                txtHasil.Clear();
            }
            txtHasil.Text = txtHasil.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtHasil.Text == "0")
            {
                txtHasil.Clear();
            }
            if (txtHasil.Text == "/")
            {
                txtHasil.Clear();
            }
            if (txtHasil.Text == "*")
            {
                txtHasil.Clear();
            }
            if (txtHasil.Text == "-")
            {
                txtHasil.Clear();
            }
            if (txtHasil.Text == "+")
            {
                txtHasil.Clear();
            }
            txtHasil.Text = txtHasil.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtHasil.Text == "0")
            {
                txtHasil.Clear();
            }
            if (txtHasil.Text == "/")
            {
                txtHasil.Clear();
            }
            if (txtHasil.Text == "*")
            {
                txtHasil.Clear();
            }
            if (txtHasil.Text == "-")
            {
                txtHasil.Clear();
            }
            if (txtHasil.Text == "+")
            {
                txtHasil.Clear();
            }
            txtHasil.Text = txtHasil.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtHasil.Text == "0")
            {
                txtHasil.Clear();
            }
            if (txtHasil.Text == "/")
            {
                txtHasil.Clear();
            }
            if (txtHasil.Text == "*")
            {
                txtHasil.Clear();
            }
            if (txtHasil.Text == "-")
            {
                txtHasil.Clear();
            }
            if (txtHasil.Text == "+")
            {
                txtHasil.Clear();
            }
            txtHasil.Text = txtHasil.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtHasil.Text == "0")
            {
                txtHasil.Clear();
            }
            if (txtHasil.Text == "/")
            {
                txtHasil.Clear();
            }
            if (txtHasil.Text == "*")
            {
                txtHasil.Clear();
            }
            if (txtHasil.Text == "-")
            {
                txtHasil.Clear();
            }
            if (txtHasil.Text == "+")
            {
                txtHasil.Clear();
            }
            txtHasil.Text = txtHasil.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtHasil.Text == "0")
            {
                txtHasil.Clear();
            }
            if (txtHasil.Text == "/")
            {
                txtHasil.Clear();
            }
            if (txtHasil.Text == "*")
            {
                txtHasil.Clear();
            }
            if (txtHasil.Text == "-")
            {
                txtHasil.Clear();
            }
            if (txtHasil.Text == "+")
            {
                txtHasil.Clear();
            }
            txtHasil.Text = txtHasil.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtHasil.Text == "0")
            {
                txtHasil.Clear();
            }
            if (txtHasil.Text == "/")
            {
                txtHasil.Clear();
            }
            if (txtHasil.Text == "*")
            {
                txtHasil.Clear();
            }
            if (txtHasil.Text == "-")
            {
                txtHasil.Clear();
            }
            if (txtHasil.Text == "+")
            {
                txtHasil.Clear();
            }
            txtHasil.Text = txtHasil.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtHasil.Text == "0")
            {
                txtHasil.Clear();
            }
            if (txtHasil.Text == "/")
            {
                txtHasil.Clear();
            }
            if (txtHasil.Text == "*")
            {
                txtHasil.Clear();
            }
            if (txtHasil.Text == "-")
            {
                txtHasil.Clear();
            }
            if (txtHasil.Text == "+")
            {
                txtHasil.Clear();
            }
            txtHasil.Text = txtHasil.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtHasil.Text == "0")
            {
                txtHasil.Clear();
            }
            if (txtHasil.Text == "/")
            {
                txtHasil.Clear();
            }
            if (txtHasil.Text == "*")
            {
                txtHasil.Clear();
            }
            if (txtHasil.Text == "-")
            {
                txtHasil.Clear();
            }
            if (txtHasil.Text == "+")
            {
                txtHasil.Clear();
            }
            txtHasil.Text = txtHasil.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtHasil.Text == "0")
            {
                txtHasil.Clear();
            }
            if (txtHasil.Text == "/")
            {
                txtHasil.Clear();
            }
            if (txtHasil.Text == "*")
            {
                txtHasil.Clear();
            }
            if (txtHasil.Text == "-")
            {
                txtHasil.Clear();
            }
            if (txtHasil.Text == "+")
            {
                txtHasil.Clear();
            }
            txtHasil.Text = txtHasil.Text + "0";
        }

        private void btnBagi_Click(object sender, EventArgs e)
        {
            if (txtHasil.Text == "/")
            {
                txtHasil.Clear();
            }
            bagi = double.Parse(txtHasil.Text);
            txtHasil.Text = "/";
            c = 1;
        }

        private void btnKali_Click(object sender, EventArgs e)
        {
            kali = double.Parse(txtHasil.Text);
            txtHasil.Text = "*";
            c = 2;
        }

        private void btnKurang_Click(object sender, EventArgs e)
        {
            kurang = double.Parse(txtHasil.Text);
            txtHasil.Text = "-";
            c = 3;
        }

        private void btnJumlah_Click(object sender, EventArgs e)
        {
            tambah = double.Parse(txtHasil.Text);
            txtHasil.Text = "+";
            c = 4;
        }

        private void btnHasil_Click(object sender, EventArgs e)
        {

            switch (c)
            {
                case 1:
                    hasil = (bagi / double.Parse(txtHasil.Text));
                    break;

                case 2:
                    hasil = (kali * double.Parse(txtHasil.Text));
                    break;

                case 3:
                    hasil = (kurang - double.Parse(txtHasil.Text));
                    break;

                case 4:
                    hasil = (tambah + double.Parse(txtHasil.Text));
                    break;
            }
            txtHasil.Text = Convert.ToString(hasil);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHasil.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
