using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AldhiyaTugas3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdoJUM_CheckedChanged(object sender, EventArgs e)
        {
            lblOP.Text = "+";
        }

        private void rdoKUR_CheckedChanged(object sender, EventArgs e)
        {
            lblOP.Text = "-";
        }

        private void rdoKAL_CheckedChanged(object sender, EventArgs e)
        {
            lblOP.Text = "*";
        }

        private void rdoBAG_CheckedChanged(object sender, EventArgs e)
        {
            lblOP.Text = "/";
        }

        private void rdoPAN_CheckedChanged(object sender, EventArgs e)
        {
            lblOP.Text = "^";
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            double n1, n2, hasil;
            n1 = Convert.ToInt16(txtBIL1.Text);
            n2 = Convert.ToInt16(txtBIL2.Text);

            if (lblOP.Text == "+")
            {
                hasil = n1 + n2;
            }
            else if (lblOP.Text == "-")
            {
                hasil = n1 - n2;
            }
            else if (lblOP.Text == "*")
            {
                hasil = n1 * n2;
            }
            else if (lblOP.Text == "/")
            {
                hasil = n1 / n2;
            }
            else if (lblOP.Text == "^")
            {
                hasil = Math.Pow(n1, n2);
            }
            else
            {
                hasil = 0;
            }

            txtHasil.Text = Convert.ToString(hasil);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBIL1.Text = "";
            txtBIL2.Text = "";
            txtHasil.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult button = MessageBox.Show("Yakin mau keluar ?", "QUIT",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                     MessageBoxDefaultButton.Button2);
            if (button == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
