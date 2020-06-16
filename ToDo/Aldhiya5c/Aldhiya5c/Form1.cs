using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aldhiya5c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            int n1, n2, h;

            n1 = Convert.ToInt16(txtNilai1.Text);
            n2 = Convert.ToInt16(txtNilai2.Text);

            if (lstOperator.Text == "+")
            {
                h = n1 + n2;
            }
            else if (lstOperator.Text == "-")
            {
                h = n1 - n2;
            }
            else if (lstOperator.Text == "*")
            {
                h = n1 * n2;
            }
            else if (lstOperator.Text == "/")
            {
                h = n1 / n2;
            }
            else
            {
                h = n1 % n2;
            }

            txtHasil.Text = Convert.ToString(h);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNilai1.Text = "";
            txtNilai2.Text = "";
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
